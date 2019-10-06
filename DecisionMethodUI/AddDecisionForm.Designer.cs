namespace DecisionMethodUI
{
    partial class AddDecisionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDecisionName = new System.Windows.Forms.Label();
            this.txtDecisionName = new System.Windows.Forms.TextBox();
            this.cbxDecisionValuation = new System.Windows.Forms.ComboBox();
            this.lblDecisionValuation = new System.Windows.Forms.Label();
            this.btnAddDecision = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDecisionName
            // 
            this.lblDecisionName.AutoSize = true;
            this.lblDecisionName.Location = new System.Drawing.Point(13, 30);
            this.lblDecisionName.Name = "lblDecisionName";
            this.lblDecisionName.Size = new System.Drawing.Size(57, 13);
            this.lblDecisionName.TabIndex = 0;
            this.lblDecisionName.Text = "Название";
            // 
            // txtDecisionName
            // 
            this.txtDecisionName.Location = new System.Drawing.Point(77, 30);
            this.txtDecisionName.Name = "txtDecisionName";
            this.txtDecisionName.Size = new System.Drawing.Size(280, 20);
            this.txtDecisionName.TabIndex = 1;
            // 
            // cbxDecisionValuation
            // 
            this.cbxDecisionValuation.FormattingEnabled = true;
            this.cbxDecisionValuation.Location = new System.Drawing.Point(77, 57);
            this.cbxDecisionValuation.Name = "cbxDecisionValuation";
            this.cbxDecisionValuation.Size = new System.Drawing.Size(65, 21);
            this.cbxDecisionValuation.TabIndex = 2;
            this.cbxDecisionValuation.SelectedIndexChanged += new System.EventHandler(this.CbxDecisionValuation_SelectedIndexChanged);
            // 
            // lblDecisionValuation
            // 
            this.lblDecisionValuation.AutoSize = true;
            this.lblDecisionValuation.Location = new System.Drawing.Point(13, 60);
            this.lblDecisionValuation.Name = "lblDecisionValuation";
            this.lblDecisionValuation.Size = new System.Drawing.Size(56, 13);
            this.lblDecisionValuation.TabIndex = 3;
            this.lblDecisionValuation.Text = "Ценность";
            // 
            // btnAddDecision
            // 
            this.btnAddDecision.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddDecision.Location = new System.Drawing.Point(77, 199);
            this.btnAddDecision.Name = "btnAddDecision";
            this.btnAddDecision.Size = new System.Drawing.Size(75, 23);
            this.btnAddDecision.TabIndex = 4;
            this.btnAddDecision.Text = "Добавить";
            this.btnAddDecision.UseVisualStyleBackColor = true;
            this.btnAddDecision.Click += new System.EventHandler(this.BtnAddDecision_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(281, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AddDecisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 241);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddDecision);
            this.Controls.Add(this.lblDecisionValuation);
            this.Controls.Add(this.cbxDecisionValuation);
            this.Controls.Add(this.txtDecisionName);
            this.Controls.Add(this.lblDecisionName);
            this.Name = "AddDecisionForm";
            this.Text = "Добавить решение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecisionName;
        private System.Windows.Forms.TextBox txtDecisionName;
        private System.Windows.Forms.ComboBox cbxDecisionValuation;
        private System.Windows.Forms.Label lblDecisionValuation;
        private System.Windows.Forms.Button btnAddDecision;
        private System.Windows.Forms.Button btnCancel;
    }
}