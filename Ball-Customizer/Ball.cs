using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball_Customizer
{
    class Ball
    {
        public Ball(int b_ID, string name, string art)
        {
            B_ID = b_ID;
            Name = name;
            Art = art;
        }

        public int B_ID { get; set; }
        public string Name { get; set; }
        public string Art { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
