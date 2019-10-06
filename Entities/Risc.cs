using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Risc
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public float Probability
        {
            get
            {
                return Probability;
            }
            private set
            {
                if ((value >= 0) && (value <= 1))
                {
                    Probability = value;
                }
            }
        }
        public Risc(int id, string name, int weight, float probability)
        {
            Id = id;
            Name = name;
            Weight = weight;
            Probability = probability;
        }
    }
}
