using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DAL;

namespace BLL
{
    public class BL
    {
        private readonly DAOCollection daLayer = new DAOCollection();
        public static List<double> Evaluate(Goal goal)
        {
            List<double> evaluateDecision = new List<double>();
            double evaluateDec = 0;
            List<Decision> decisions = goal.Decisions;
            foreach (var decision in decisions)
            {
                foreach (var risc in decision.Riscs)
                {
                    evaluateDec += risc.Weight * risc.Probability;
                }
                evaluateDec += goal.Weight * goal.Probability;
                evaluateDec *= decision.Valuation;
                evaluateDecision.Add(evaluateDec);
            }
            return evaluateDecision;
        }

        //DecisionMaker
        public void AddGoal(string name, int weight, List<Decision> decisions)
        {
            daLayer.AddGoal(new Goal(0, name, weight, decisions));
        }

        public void AddDecision(string name, int valuation)
        {
            daLayer.AddDecision(new Decision(0, name, valuation));
        }

        //Expert
        public void AddRisc(string name, int weight, float probability, Decision decision, IUser user)
        {
            if (user is Expert)
            {
                daLayer.AddRisc(new Risc(0, name, weight, probability), decision, user);
            }
        }

        public void AddProbabiltyOfGoal(Goal goal, float probability, IUser user)
        {
            if (user is Expert)
            {
                goal.AddProbability(probability, user);
            }
        }

        public List<Decision> GetDecisions
        {
            get
            {
                return daLayer.Decisions;
            }
        }

        public List<Risc> GetRiscs
        {
            get
            {
                return daLayer.Riscs;
            }
        }
    }
}
