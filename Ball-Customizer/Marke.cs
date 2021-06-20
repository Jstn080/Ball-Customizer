using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_Customizer
{
    class Marke
    {
        public Marke(int iD, string name)
        {
            M_ID = iD;
            Name = name;
        }

        public int M_ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
