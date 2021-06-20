using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_Customizer
{
    class Muster
    {
        public Muster(int mU_ID, string name)
        {
            MU_ID = mU_ID;
            Name = name;
        }

        public int MU_ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
