using DwarvenVillage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DwarvenVillage.Models;
using DwarvenVillage.Generators;

namespace DwarvenVillage.WorkUnits
{
    public class Mine : IMine
    {
        private IEnumerable<IShaft> _shafts;
        private IRandom _generator;

        public Mine(IEnumerable<IShaft> shafts, IRandom generator)
        {
            _generator = generator;
            _shafts = shafts;
        }

        public List<IDwarf> Work(List<IDwarf> villageDwarves)
        {
            giveDwarvesNumberOfDigs(villageDwarves);
            //List<List<IDwarf>> dwarfGroups = splitDwarvesIntoShaftGroups(villageDwarves);

            while (villageDwarves.Any(d => d.NumberOfDigs > 0))
            {
                foreach (var shaft in _shafts)
                {
                    if (shaft.IsOccupied == false)
                    {
                        var workingDwarves = getListOfWorkingDwarves(villageDwarves);
                        workingDwarves = shaft.Dig(workingDwarves);
                        villageDwarves.AddRange(workingDwarves);
                    }
                }
                freeAllShafts();
            }

            return villageDwarves;
        }

        private void freeAllShafts()
        {
            foreach (var shaft in _shafts)
            {
                shaft.IsOccupied = false;
            }
        }

        private void giveDwarvesNumberOfDigs(IList<IDwarf> dwarves)
        {
            foreach (var dwarf in dwarves)
            {
                dwarf.NumberOfDigs = _generator.Generate();
            }
        }


        private List<IDwarf> getListOfWorkingDwarves(List<IDwarf> dwarves)
        {
            var result = new List<IDwarf>();

            for (int i = 0; i < 5; i++)
            {
                if (dwarves.Any(d => d.NumberOfDigs > 0))
                {
                    result.Add(dwarves
                    .Where(d => d.NumberOfDigs > 0)
                    .FirstOrDefault());
                    dwarves.Remove(dwarves
                        .Where(d => d.NumberOfDigs > 0)
                        .FirstOrDefault());
                }
            }

            return result;
        }
        //private List<List<IDwarf>> splitDwarvesIntoShaftGroups(List<IDwarf> dwarves)
        //{
        //    // create empty list of dwarves groups to return after splitting
        //    List<List<IDwarf>> result = new List<List<IDwarf>>();

        //    // while there are any remaining dwarves - remember, they came from the outside
        //    while (dwarves.Count > 0)
        //    {
        //        // create empty list of dwarves aka 'shaft group' - it's just a bag for dwarves subgroups
        //        List<IDwarf> shaftGroup = new List<IDwarf>();
        //        // take 5 dwarves (or remaining ones - that's the if inside)
        //        while (dwarves.Count > 0 && shaftGroup.Count < 5)
        //        {
        //                // add last dwarf from given list to current shaft group
        //                shaftGroup.Add(dwarves.Last());
        //                // remove that dwarf to prevent from iterating over it again 
        //                // (dwarves.Count - 1 means count amount of dwarves and decrement 
        //                // it by one to get index of last dwarf, lists are indexed from 0 - remember?)
        //                dwarves.RemoveAt(dwarves.Count - 1);
        //        }
        //        // adds created shaft group to result list
        //        result.Add(shaftGroup);
        //    }

        //    return result;
        //}
        //private List<IDwarf> joinDwarvesGroupIntoOne(List<List<IDwarf>> dwarfGroups)
        //{
        //    List<IDwarf> result = new List<IDwarf>();
        //    foreach (var group in dwarfGroups)
        //    {
        //        result.AddRange(group);
        //    }

        //    return result;
        //}
    }
}
