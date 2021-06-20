using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_Customizer
{
    class Farbe
    {
        public Farbe(int f_ID, string name)
        {
            F_ID = f_ID;
            Name = name;
        }

        public int F_ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
