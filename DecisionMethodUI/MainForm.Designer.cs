namespace DecisionMethodUI
{
    partial class MainForm
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
            this.tabDecisionSystem = new System.Windows.Forms.TabControl();
            this.tpgDecisionMaker = new System.Windows.Forms.TabPage();
            this.tpgCoordinator = new System.Windows.Forms.TabPage();
            this.tpgExpert1 = new System.Windows.Forms.TabPage();
            this.btnAddDecision = new System.Windows.Forms.Button();
            this.btnAddGoal = new System.Windows.Forms.Button();
            this.dgvDecisionMaker = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvExpert = new System.Windows.Forms.DataGridView();
            this.btnAddRisc = new System.Windows.Forms.Button();
            this.btnAddGoalProbability = new System.Windows.Forms.Button();
            this.tpgExpert2 = new System.Windows.Forms.TabPage();
            this.btnAddGoalProbability2 = new System.Windows.Forms.Button();
            this.btnAddRisc2 = new System.Windows.Forms.Button();
            this.dgvExpert2 = new System.Windows.Forms.DataGridView();
            this.tpgExpert3 = new System.Windows.Forms.TabPage();
            this.btnAddGoalProbability3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvExpert3 = new System.Windows.Forms.DataGridView();
            this.tpgExpert4 = new System.Windows.Forms.TabPage();
            this.btnAddGoalProbability4 = new System.Windows.Forms.Button();
            this.btnAddRisc4 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.btn = new System.Windows.Forms.Button();
            this.btnAddCommonRisc = new System.Windows.Forms.Button();
            this.btnAddAverageProbability = new System.Windows.Forms.Button();
            this.dgvCoordinator = new System.Windows.Forms.DataGridView();
            this.btnShowBestDecision = new System.Windows.Forms.Button();
            this.tabDecisionSystem.SuspendLayout();
            this.tpgDecisionMaker.SuspendLayout();
            this.tpgCoordinator.SuspendLayout();
            this.tpgExpert1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecisionMaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpert)).BeginInit();
            this.tpgExpert2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpert2)).BeginInit();
            this.tpgExpert3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpert3)).BeginInit();
            this.tpgExpert4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinator)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDecisionSystem
            // 
            this.tabDecisionSystem.Controls.Add(this.tpgDecisionMaker);
            this.tabDecisionSystem.Controls.Add(this.tpgCoordinator);
            this.tabDecisionSystem.Controls.Add(this.tpgExpert1);
            this.tabDecisionSystem.Controls.Add(this.tpgExpert2);
            this.tabDecisionSystem.Controls.Add(this.tpgExpert3);
            this.tabDecisionSystem.Controls.Add(this.tpgExpert4);
            this.tabDecisionSystem.Location = new System.Drawing.Point(12, 12);
            this.tabDecisionSystem.Name = "tabDecisionSystem";
            this.tabDecisionSystem.SelectedIndex = 0;
            this.tabDecisionSystem.Size = new System.Drawing.Size(776, 426);
            this.tabDecisionSystem.TabIndex = 0;
            // 
            // tpgDecisionMaker
            // 
            this.tpgDecisionMaker.Controls.Add(this.btnShowBestDecision);
            this.tpgDecisionMaker.Controls.Add(this.btnUpdate);
            this.tpgDecisionMaker.Controls.Add(this.dgvDecisionMaker);
            this.tpgDecisionMaker.Controls.Add(this.btnAddGoal);
            this.tpgDecisionMaker.Controls.Add(this.btnAddDecision);
            this.tpgDecisionMaker.Location = new System.Drawing.Point(4, 22);
            this.tpgDecisionMaker.Name = "tpgDecisionMaker";
            this.tpgDecisionMaker.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDecisionMaker.Size = new System.Drawing.Size(768, 400);
            this.tpgDecisionMaker.TabIndex = 0;
            this.tpgDecisionMaker.Text = "ЛПР";
            this.tpgDecisionMaker.UseVisualStyleBackColor = true;
            // 
            // tpgCoordinator
            // 
            this.tpgCoordinator.Controls.Add(this.dgvCoordinator);
            this.tpgCoordinator.Controls.Add(this.btnAddAverageProbability);
            this.tpgCoordinator.Controls.Add(this.btnAddCommonRisc);
            this.tpgCoordinator.Controls.Add(this.btn);
            this.tpgCoordinator.Location = new System.Drawing.Point(4, 22);
            this.tpgCoordinator.Name = "tpgCoordinator";
            this.tpgCoordinator.Padding = new System.Windows.Forms.Padding(3);
            this.tpgCoordinator.Size = new System.Drawing.Size(768, 400);
            this.tpgCoordinator.TabIndex = 1;
            this.tpgCoordinator.Text = "Координатор";
            this.tpgCoordinator.UseVisualStyleBackColor = true;
            // 
            // tpgExpert1
            // 
            this.tpgExpert1.Controls.Add(this.btnAddGoalProbability);
            this.tpgExpert1.Controls.Add(this.btnAddRisc);
            this.tpgExpert1.Controls.Add(this.dgvExpert);
            this.tpgExpert1.Location = new System.Drawing.Point(4, 22);
            this.tpgExpert1.Name = "tpgExpert1";
            this.tpgExpert1.Size = new System.Drawing.Size(768, 400);
            this.tpgExpert1.TabIndex = 2;
            this.tpgExpert1.Text = "Эксперт 1";
            this.tpgExpert1.UseVisualStyleBackColor = true;
            // 
            // btnAddDecision
            // 
            this.btnAddDecision.Location = new System.Drawing.Point(636, 6);
            this.btnAddDecision.Name = "btnAddDecision";
            this.btnAddDecision.Size = new System.Drawing.Size(126, 23);
            this.btnAddDecision.TabIndex = 3;
            this.btnAddDecision.Text = "Добавить решение";
            this.btnAddDecision.UseVisualStyleBackColor = true;
            this.btnAddDecision.Click += new System.EventHandler(this.BtnAddDecision_Click);
            // 
            // btnAddGoal
            // 
            this.btnAddGoal.Location = new System.Drawing.Point(636, 36);
            this.btnAddGoal.Name = "btnAddGoal";
            this.btnAddGoal.Size = new System.Drawing.Size(125, 23);
            this.btnAddGoal.TabIndex = 4;
            this.btnAddGoal.Text = "Добавить цель";
            this.btnAddGoal.UseVisualStyleBackColor = true;
            this.btnAddGoal.Click += new System.EventHandler(this.BtnAddGoal_Click);
            // 
            // dgvDecisionMaker
            // 
            this.dgvDecisionMaker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDecisionMaker.Location = new System.Drawing.Point(0, 0);
            this.dgvDecisionMaker.Name = "dgvDecisionMaker";
            this.dgvDecisionMaker.Size = new System.Drawing.Size(630, 400);
            this.dgvDecisionMaker.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(636, 66);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dgvExpert
            // 
            this.dgvExpert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpert.Location = new System.Drawing.Point(0, 0);
            this.dgvExpert.Name = "dgvExpert";
            this.dgvExpert.Size = new System.Drawing.Size(630, 400);
            this.dgvExpert.TabIndex = 0;
            // 
            // btnAddRisc
            // 
            this.btnAddRisc.Location = new System.Drawing.Point(637, 4);
            this.btnAddRisc.Name = "btnAddRisc";
            this.btnAddRisc.Size = new System.Drawing.Size(128, 23);
            this.btnAddRisc.TabIndex = 1;
            this.btnAddRisc.Text = "Добавить риск";
            this.btnAddRisc.UseVisualStyleBackColor = true;
            // 
            // btnAddGoalProbability
            // 
            this.btnAddGoalProbability.Location = new System.Drawing.Point(637, 34);
            this.btnAddGoalProbability.Name = "btnAddGoalProbability";
            this.btnAddGoalProbability.Size = new System.Drawing.Size(128, 23);
            this.btnAddGoalProbability.TabIndex = 2;
            this.btnAddGoalProbability.Text = "Вероятность цели";
            this.btnAddGoalProbability.UseVisualStyleBackColor = true;
            // 
            // tpgExpert2
            // 
            this.tpgExpert2.Controls.Add(this.btnAddGoalProbability2);
            this.tpgExpert2.Controls.Add(this.btnAddRisc2);
            this.tpgExpert2.Controls.Add(this.dgvExpert2);
            this.tpgExpert2.Location = new System.Drawing.Point(4, 22);
            this.tpgExpert2.Name = "tpgExpert2";
            this.tpgExpert2.Size = new System.Drawing.Size(768, 400);
            this.tpgExpert2.TabIndex = 6;
            this.tpgExpert2.Text = "Эксперт 2";
            this.tpgExpert2.UseVisualStyleBackColor = true;
            // 
            // btnAddGoalProbability2
            // 
            this.btnAddGoalProbability2.Location = new System.Drawing.Point(637, 34);
            this.btnAddGoalProbability2.Name = "btnAddGoalProbability2";
            this.btnAddGoalProbability2.Size = new System.Drawing.Size(128, 23);
            this.btnAddGoalProbability2.TabIndex = 2;
            this.btnAddGoalProbability2.Text = "Вероятность цели";
            this.btnAddGoalProbability2.UseVisualStyleBackColor = true;
            // 
            // btnAddRisc2
            // 
            this.btnAddRisc2.Location = new System.Drawing.Point(637, 4);
            this.btnAddRisc2.Name = "btnAddRisc2";
            this.btnAddRisc2.Size = new System.Drawing.Size(128, 23);
            this.btnAddRisc2.TabIndex = 1;
            this.btnAddRisc2.Text = "Добавить риск";
            this.btnAddRisc2.UseVisualStyleBackColor = true;
            // 
            // dgvExpert2
            // 
            this.dgvExpert2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpert2.Location = new System.Drawing.Point(0, 0);
            this.dgvExpert2.Name = "dgvExpert2";
            this.dgvExpert2.Size = new System.Drawing.Size(630, 400);
            this.dgvExpert2.TabIndex = 0;
            // 
            // tpgExpert3
            // 
            this.tpgExpert3.Controls.Add(this.btnAddGoalProbability3);
            this.tpgExpert3.Controls.Add(this.button4);
            this.tpgExpert3.Controls.Add(this.dgvExpert3);
            this.tpgExpert3.Location = new System.Drawing.Point(4, 22);
            this.tpgExpert3.Name = "tpgExpert3";
            this.tpgExpert3.Size = new System.Drawing.Size(768, 400);
            this.tpgExpert3.TabIndex = 7;
            this.tpgExpert3.Text = "Эксперт 3";
            this.tpgExpert3.UseVisualStyleBackColor = true;
            // 
            // btnAddGoalProbability3
            // 
            this.btnAddGoalProbability3.Location = new System.Drawing.Point(637, 34);
            this.btnAddGoalProbability3.Name = "btnAddGoalProbability3";
            this.btnAddGoalProbability3.Size = new System.Drawing.Size(128, 23);
            this.btnAddGoalProbability3.TabIndex = 2;
            this.btnAddGoalProbability3.Text = "Вероятность цели";
            this.btnAddGoalProbability3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Добавить риск";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dgvExpert3
            // 
            this.dgvExpert3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpert3.Location = new System.Drawing.Point(0, 0);
            this.dgvExpert3.Name = "dgvExpert3";
            this.dgvExpert3.Size = new System.Drawing.Size(630, 400);
            this.dgvExpert3.TabIndex = 0;
            // 
            // tpgExpert4
            // 
            this.tpgExpert4.Controls.Add(this.btnAddGoalProbability4);
            this.tpgExpert4.Controls.Add(this.btnAddRisc4);
            this.tpgExpert4.Controls.Add(this.dataGridView5);
            this.tpgExpert4.Location = new System.Drawing.Point(4, 22);
            this.tpgExpert4.Name = "tpgExpert4";
            this.tpgExpert4.Size = new System.Drawing.Size(768, 400);
            this.tpgExpert4.TabIndex = 8;
            this.tpgExpert4.Text = "Эксперт 4";
            this.tpgExpert4.UseVisualStyleBackColor = true;
            // 
            // btnAddGoalProbability4
            // 
            this.btnAddGoalProbability4.Location = new System.Drawing.Point(637, 34);
            this.btnAddGoalProbability4.Name = "btnAddGoalProbability4";
            this.btnAddGoalProbability4.Size = new System.Drawing.Size(128, 23);
            this.btnAddGoalProbability4.TabIndex = 2;
            this.btnAddGoalProbability4.Text = "Вероятность цели";
            this.btnAddGoalProbability4.UseVisualStyleBackColor = true;
            // 
            // btnAddRisc4
            // 
            this.btnAddRisc4.Location = new System.Drawing.Point(637, 4);
            this.btnAddRisc4.Name = "btnAddRisc4";
            this.btnAddRisc4.Size = new System.Drawing.Size(128, 23);
            this.btnAddRisc4.TabIndex = 1;
            this.btnAddRisc4.Text = "Добавить риск";
            this.btnAddRisc4.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(630, 400);
            this.dataGridView5.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(613, 6);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(149, 54);
            this.btn.TabIndex = 0;
            this.btn.Text = "Рассчитать оптимальное решение";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnAddCommonRisc
            // 
            this.btnAddCommonRisc.Location = new System.Drawing.Point(613, 67);
            this.btnAddCommonRisc.Name = "btnAddCommonRisc";
            this.btnAddCommonRisc.Size = new System.Drawing.Size(148, 23);
            this.btnAddCommonRisc.TabIndex = 1;
            this.btnAddCommonRisc.Text = "Добавить риск";
            this.btnAddCommonRisc.UseVisualStyleBackColor = true;
            // 
            // btnAddAverageProbability
            // 
            this.btnAddAverageProbability.Location = new System.Drawing.Point(613, 97);
            this.btnAddAverageProbability.Name = "btnAddAverageProbability";
            this.btnAddAverageProbability.Size = new System.Drawing.Size(147, 23);
            this.btnAddAverageProbability.TabIndex = 2;
            this.btnAddAverageProbability.Text = "Добавить вероятность";
            this.btnAddAverageProbability.UseVisualStyleBackColor = true;
            // 
            // dgvCoordinator
            // 
            this.dgvCoordinator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoordinator.Location = new System.Drawing.Point(0, 0);
            this.dgvCoordinator.Name = "dgvCoordinator";
            this.dgvCoordinator.Size = new System.Drawing.Size(607, 404);
            this.dgvCoordinator.TabIndex = 3;
            // 
            // btnShowBestDecision
            // 
            this.btnShowBestDecision.Location = new System.Drawing.Point(637, 96);
            this.btnShowBestDecision.Name = "btnShowBestDecision";
            this.btnShowBestDecision.Size = new System.Drawing.Size(124, 40);
            this.btnShowBestDecision.TabIndex = 7;
            this.btnShowBestDecision.Text = "Показать лучшее решение";
            this.btnShowBestDecision.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabDecisionSystem);
            this.Name = "MainForm";
            this.Text = "Система принятия решений";
            this.tabDecisionSystem.ResumeLayout(false);
            this.tpgDecisionMaker.ResumeLayout(false);
            this.tpgCoordinator.ResumeLayout(false);
            this.tpgExpert1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecisionMaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpert)).EndInit();
            this.tpgExpert2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpert2)).EndInit();
            this.tpgExpert3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpert3)).EndInit();
            this.tpgExpert4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoordinator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDecisionSystem;
        private System.Windows.Forms.TabPage tpgDecisionMaker;
        private System.Windows.Forms.TabPage tpgCoordinator;
        private System.Windows.Forms.TabPage tpgExpert1;
        private System.Windows.Forms.Button btnAddDecision;
        private System.Windows.Forms.Button btnAddGoal;
        private System.Windows.Forms.DataGridView dgvDecisionMaker;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnAddGoalProbability;
        private System.Windows.Forms.Button btnAddRisc;
        private System.Windows.Forms.DataGridView dgvExpert;
        private System.Windows.Forms.TabPage tpgExpert2;
        private System.Windows.Forms.Button btnAddGoalProbability2;
        private System.Windows.Forms.Button btnAddRisc2;
        private System.Windows.Forms.DataGridView dgvExpert2;
        private System.Windows.Forms.TabPage tpgExpert3;
        private System.Windows.Forms.Button btnAddGoalProbability3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvExpert3;
        private System.Windows.Forms.TabPage tpgExpert4;
        private System.Windows.Forms.Button btnAddGoalProbability4;
        private System.Windows.Forms.Button btnAddRisc4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button btnShowBestDecision;
        private System.Windows.Forms.DataGridView dgvCoordinator;
        private System.Windows.Forms.Button btnAddAverageProbability;
        private System.Windows.Forms.Button btnAddCommonRisc;
    }
}