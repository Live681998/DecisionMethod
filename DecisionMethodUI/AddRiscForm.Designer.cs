namespace DecisionMethodUI
{
    partial class AddRiscForm
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
            this.lblRiscName = new System.Windows.Forms.Label();
            this.txtRiscName = new System.Windows.Forms.TextBox();
            this.cbxDecisionRisc = new System.Windows.Forms.ComboBox();
            this.lblDecisionRisc = new System.Windows.Forms.Label();
            this.cbxRiscWeight = new System.Windows.Forms.ComboBox();
            this.lblRiscWeight = new System.Windows.Forms.Label();
            this.lblProbability = new System.Windows.Forms.Label();
            this.cbxRiscProbability = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRiscName
            // 
            this.lblRiscName.AutoSize = true;
            this.lblRiscName.Location = new System.Drawing.Point(13, 26);
            this.lblRiscName.Name = "lblRiscName";
            this.lblRiscName.Size = new System.Drawing.Size(57, 13);
            this.lblRiscName.TabIndex = 0;
            this.lblRiscName.Text = "Название";
            // 
            // txtRiscName
            // 
            this.txtRiscName.Location = new System.Drawing.Point(77, 26);
            this.txtRiscName.Name = "txtRiscName";
            this.txtRiscName.Size = new System.Drawing.Size(363, 20);
            this.txtRiscName.TabIndex = 1;
            // 
            // cbxDecisionRisc
            // 
            this.cbxDecisionRisc.FormattingEnabled = true;
            this.cbxDecisionRisc.Location = new System.Drawing.Point(77, 53);
            this.cbxDecisionRisc.Name = "cbxDecisionRisc";
            this.cbxDecisionRisc.Size = new System.Drawing.Size(363, 21);
            this.cbxDecisionRisc.TabIndex = 2;
            // 
            // lblDecisionRisc
            // 
            this.lblDecisionRisc.AutoSize = true;
            this.lblDecisionRisc.Location = new System.Drawing.Point(13, 56);
            this.lblDecisionRisc.Name = "lblDecisionRisc";
            this.lblDecisionRisc.Size = new System.Drawing.Size(52, 13);
            this.lblDecisionRisc.TabIndex = 3;
            this.lblDecisionRisc.Text = "Решение";
            // 
            // cbxRiscWeight
            // 
            this.cbxRiscWeight.FormattingEnabled = true;
            this.cbxRiscWeight.Location = new System.Drawing.Point(77, 81);
            this.cbxRiscWeight.Name = "cbxRiscWeight";
            this.cbxRiscWeight.Size = new System.Drawing.Size(121, 21);
            this.cbxRiscWeight.TabIndex = 4;
            // 
            // lblRiscWeight
            // 
            this.lblRiscWeight.AutoSize = true;
            this.lblRiscWeight.Location = new System.Drawing.Point(13, 84);
            this.lblRiscWeight.Name = "lblRiscWeight";
            this.lblRiscWeight.Size = new System.Drawing.Size(26, 13);
            this.lblRiscWeight.TabIndex = 5;
            this.lblRiscWeight.Text = "Вес";
            // 
            // lblProbability
            // 
            this.lblProbability.AutoSize = true;
            this.lblProbability.Location = new System.Drawing.Point(216, 83);
            this.lblProbability.Name = "lblProbability";
            this.lblProbability.Size = new System.Drawing.Size(72, 13);
            this.lblProbability.TabIndex = 6;
            this.lblProbability.Text = "Вероятность";
            // 
            // cbxRiscProbability
            // 
            this.cbxRiscProbability.FormattingEnabled = true;
            this.cbxRiscProbability.Location = new System.Drawing.Point(294, 80);
            this.cbxRiscProbability.Name = "cbxRiscProbability";
            this.cbxRiscProbability.Size = new System.Drawing.Size(121, 21);
            this.cbxRiscProbability.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(77, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(365, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddRiscForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 334);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxRiscProbability);
            this.Controls.Add(this.lblProbability);
            this.Controls.Add(this.lblRiscWeight);
            this.Controls.Add(this.cbxRiscWeight);
            this.Controls.Add(this.lblDecisionRisc);
            this.Controls.Add(this.cbxDecisionRisc);
            this.Controls.Add(this.txtRiscName);
            this.Controls.Add(this.lblRiscName);
            this.Name = "AddRiscForm";
            this.Text = "Добавить риск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRiscName;
        private System.Windows.Forms.TextBox txtRiscName;
        private System.Windows.Forms.ComboBox cbxDecisionRisc;
        private System.Windows.Forms.Label lblDecisionRisc;
        private System.Windows.Forms.ComboBox cbxRiscWeight;
        private System.Windows.Forms.Label lblRiscWeight;
        private System.Windows.Forms.Label lblProbability;
        private System.Windows.Forms.ComboBox cbxRiscProbability;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}