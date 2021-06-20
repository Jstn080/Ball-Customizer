using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_Customizer
{
    class Material
    {
        public Material(int mA_ID, string name)
        {
            MA_ID = mA_ID;
            Name = name;
        }

        public int MA_ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
