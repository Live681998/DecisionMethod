using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionMethodUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAddDecision_Click(object sender, EventArgs e)
        {
            AddDecisionForm form = new AddDecisionForm();
            form.Show();
        }

        private void BtnAddGoal_Click(object sender, EventArgs e)
        {
            AddGoalForm form = new AddGoalForm();
            form.Show();
        }
    }
}
