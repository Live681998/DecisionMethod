using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Goal
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public int Weight
        {
            get
            {
                return Weight;
            }
            private set
            {
                if ((value >= 0) && (value <= 10))
                {
                    Weight = value;
                }
            }
        }

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
        public List<Decision> Decisions { get; private set; }

        public Goal(int id, string name, int weight, List<Decision> decisions)
        {
            Id = id;
            Name = name;
            Weight = weight;
            Decisions = decisions;
        }

        public void AddProbability(float probability, IUser user)
        {
            if (user is Expert)
            {
                Probability = probability;
            }
        }

        public void AddDecision (Decision decision)
        {
            Decisions.Add(decision);
        }
    }
}
