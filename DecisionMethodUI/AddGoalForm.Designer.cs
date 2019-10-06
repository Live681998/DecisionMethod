namespace DecisionMethodUI
{
    partial class AddGoalForm
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
            this.lblGoalName = new System.Windows.Forms.Label();
            this.txtGoalName = new System.Windows.Forms.TextBox();
            this.clbDecisions = new System.Windows.Forms.CheckedListBox();
            this.lblDecisions = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxGoalWeight = new System.Windows.Forms.ComboBox();
            this.lblGoalWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGoalName
            // 
            this.lblGoalName.AutoSize = true;
            this.lblGoalName.Location = new System.Drawing.Point(13, 40);
            this.lblGoalName.Name = "lblGoalName";
            this.lblGoalName.Size = new System.Drawing.Size(57, 13);
            this.lblGoalName.TabIndex = 0;
            this.lblGoalName.Text = "Название";
            // 
            // txtGoalName
            // 
            this.txtGoalName.Location = new System.Drawing.Point(76, 37);
            this.txtGoalName.Name = "txtGoalName";
            this.txtGoalName.Size = new System.Drawing.Size(263, 20);
            this.txtGoalName.TabIndex = 1;
            // 
            // clbDecisions
            // 
            this.clbDecisions.FormattingEnabled = true;
            this.clbDecisions.Location = new System.Drawing.Point(76, 64);
            this.clbDecisions.Name = "clbDecisions";
            this.clbDecisions.Size = new System.Drawing.Size(263, 139);
            this.clbDecisions.TabIndex = 2;
            // 
            // lblDecisions
            // 
            this.lblDecisions.AutoSize = true;
            this.lblDecisions.Location = new System.Drawing.Point(16, 64);
            this.lblDecisions.Name = "lblDecisions";
            this.lblDecisions.Size = new System.Drawing.Size(52, 13);
            this.lblDecisions.TabIndex = 3;
            this.lblDecisions.Text = "Решения";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(76, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(264, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxGoalWeight
            // 
            this.cbxGoalWeight.FormattingEnabled = true;
            this.cbxGoalWeight.Location = new System.Drawing.Point(360, 37);
            this.cbxGoalWeight.Name = "cbxGoalWeight";
            this.cbxGoalWeight.Size = new System.Drawing.Size(46, 21);
            this.cbxGoalWeight.TabIndex = 6;
            // 
            // lblGoalWeight
            // 
            this.lblGoalWeight.AutoSize = true;
            this.lblGoalWeight.Location = new System.Drawing.Point(426, 40);
            this.lblGoalWeight.Name = "lblGoalWeight";
            this.lblGoalWeight.Size = new System.Drawing.Size(26, 13);
            this.lblGoalWeight.TabIndex = 7;
            this.lblGoalWeight.Text = "Вес";
            // 
            // AddGoalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 285);
            this.Controls.Add(this.lblGoalWeight);
            this.Controls.Add(this.cbxGoalWeight);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDecisions);
            this.Controls.Add(this.clbDecisions);
            this.Controls.Add(this.txtGoalName);
            this.Controls.Add(this.lblGoalName);
            this.Name = "AddGoalForm";
            this.Text = "Добавить цель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoalName;
        private System.Windows.Forms.TextBox txtGoalName;
        private System.Windows.Forms.CheckedListBox clbDecisions;
        private System.Windows.Forms.Label lblDecisions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxGoalWeight;
        private System.Windows.Forms.Label lblGoalWeight;
    }
}