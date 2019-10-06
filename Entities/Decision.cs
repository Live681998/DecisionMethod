using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Decision
    {
        private int valuation;
        public int Id { get; set; }
        public string Name { get; private set; }
        public int Valuation {
            get
            {
                return valuation;
            }
            private set
            {
                if ((value >= 0) && (value <= 10))
                {
                    valuation = value;
                }
            }
        }
        public List<Risc> Riscs { get; private set; }

        public Decision(int id, string name, int valuation)
        {
            Id = id;
            Name = name;
            Valuation = valuation;
        }
        public void AddRisc(Risc risc, IUser user)
        {
            if (user is Expert)
            {
                Riscs.Add(risc);
            }
        }
    }
}
