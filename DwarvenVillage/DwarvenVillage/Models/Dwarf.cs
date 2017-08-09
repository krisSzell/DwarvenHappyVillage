using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarvenVillage.Models
{
    public class Dwarf
    {
        private int _id;
        private DwarfType _type;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Dwarf(int id)
        {
            _id = id;
        }
    }
}
