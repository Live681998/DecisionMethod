using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class DAOCollection
    {
        private List<IUser> users = new List<IUser>();
        private List<Goal> goals = new List<Goal>();
        private List<Decision> decisions = new List<Decision>();
        private List<Risc> riscs = new List<Risc>();

        private int riscsIds = 1;
        private int decisionsIds = 1;
        private int goalsIds = 1;

        public List<Goal> Goals
        {
            get
            {
                return goals;
            }
        }

        public List<Decision> Decisions
        {
            get
            {
                return decisions;
            }
        }

        public List<Risc> Riscs
        {
            get
            {
                return riscs;
            }
        }

        public void InitializationUsers(List<Expert> experts, Coordinator coordinator, DecisionMaker decisionMaker)
        {
            users.Add(decisionMaker);
            users.Add(coordinator);
            foreach (var expert in experts)
            {
                users.Add(expert);
            }
        }

        public void AddGoal(Goal goal)
        {
            if (goal != null)
            {
                goal.Id = goalsIds++;
                goals.Add(goal);
            }
        }

        public void AddDecision(Decision decision)
        {
            if (decision != null)
            {
                decision.Id = decisionsIds++;
                decisions.Add(decision);
            }
        }

        public void AddRisc(Risc risc, Decision decision, IUser user)
        {
            if (user is Expert)
            {
                if (risc != null)
                {
                    risc.Id = riscsIds++;
                    riscs.Add(risc);
                    AddRiscToDecision(decision, risc, user);
                }

            }
        }

        public void AddRiscToDecision(Decision decision, Risc risc, IUser user)
        {
            if (user is Expert)
            {
                decision.AddRisc(risc, user);
            }
        }

        public void AddDecisionsToGoal(Goal goal, List<Decision> decisions)
        {
            foreach (var decision in decisions)
            {
                goal.AddDecision(decision);
            }
        }

        //public IEnumerable<>
    }
}
