using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace DecisionMethodUI
{
    public partial class AddGoalForm : Form
    {
        public List<string> decisionsName = HelpClass.bL.GetDecisions.Select(r => r.Name).ToList();
        public AddGoalForm()
        {
            InitializeComponent();
            foreach (var item in decisionsName)
            {
                clbDecisions.Items.Add(item); 
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
            else
            {

            }
        }
    }
}
