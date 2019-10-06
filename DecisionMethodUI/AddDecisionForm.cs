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
using Entities;

namespace DecisionMethodUI
{
    public partial class AddDecisionForm : Form
    {
        public AddDecisionForm()
        {
            InitializeComponent();
            for (int i = 0; i < 11; i++)
            {
                cbxDecisionValuation.Items.Add(i);
            }
            cbxDecisionValuation.SelectedIndexChanged += CbxDecisionValuation_SelectedIndexChanged;
        }

        private void BtnAddDecision_Click(object sender, EventArgs e)
        {
            if ((txtDecisionName.Text != null) && (cbxDecisionValuation.SelectedItem.ToString() != null))
            {
                string name = txtDecisionName.Text;
                int valuation = Convert.ToInt32(cbxDecisionValuation.SelectedItem.ToString());
                
                HelpClass.bL.AddDecision(name, valuation);
                MessageBox.Show("Решение добавлено!");
                Close();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CbxDecisionValuation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = cbxDecisionValuation.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }
    }
}
