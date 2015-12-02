namespace GudgelBudget
{
    partial class BudgetAid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetAid));
            this.TabCon = new System.Windows.Forms.TabControl();
            this.InputTab = new System.Windows.Forms.TabPage();
            this.DateLabel_I = new System.Windows.Forms.Label();
            this.ValueLabel_I = new System.Windows.Forms.Label();
            this.CategoryLabel_I = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DateTextY_I = new System.Windows.Forms.TextBox();
            this.DateTextD_I = new System.Windows.Forms.TextBox();
            this.DateTextM_I = new System.Windows.Forms.TextBox();
            this.ValueTextBox_I = new System.Windows.Forms.TextBox();
            this.CategoryTextBox_I = new System.Windows.Forms.TextBox();
            this.AnalyzeTab = new System.Windows.Forms.TabPage();
            this.CalcButton = new System.Windows.Forms.Button();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.TargetLabel = new System.Windows.Forms.Label();
            this.CategoryLabel_A = new System.Windows.Forms.Label();
            this.DateFTextY = new System.Windows.Forms.TextBox();
            this.DateFTextD = new System.Windows.Forms.TextBox();
            this.DateFTextM = new System.Windows.Forms.TextBox();
            this.DateITextY = new System.Windows.Forms.TextBox();
            this.DateITextD = new System.Windows.Forms.TextBox();
            this.DateITextM = new System.Windows.Forms.TextBox();
            this.TargetTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox_A = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TabCon.SuspendLayout();
            this.InputTab.SuspendLayout();
            this.AnalyzeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabCon
            // 
            this.TabCon.Controls.Add(this.InputTab);
            this.TabCon.Controls.Add(this.AnalyzeTab);
            this.TabCon.Location = new System.Drawing.Point(13, 13);
            this.TabCon.Name = "TabCon";
            this.TabCon.SelectedIndex = 0;
            this.TabCon.Size = new System.Drawing.Size(235, 220);
            this.TabCon.TabIndex = 0;
            // 
            // InputTab
            // 
            this.InputTab.Controls.Add(this.DateLabel_I);
            this.InputTab.Controls.Add(this.ValueLabel_I);
            this.InputTab.Controls.Add(this.CategoryLabel_I);
            this.InputTab.Controls.Add(this.SubmitButton);
            this.InputTab.Controls.Add(this.DateTextY_I);
            this.InputTab.Controls.Add(this.DateTextD_I);
            this.InputTab.Controls.Add(this.DateTextM_I);
            this.InputTab.Controls.Add(this.ValueTextBox_I);
            this.InputTab.Controls.Add(this.CategoryTextBox_I);
            this.InputTab.Location = new System.Drawing.Point(4, 22);
            this.InputTab.Name = "InputTab";
            this.InputTab.Padding = new System.Windows.Forms.Padding(3);
            this.InputTab.Size = new System.Drawing.Size(227, 194);
            this.InputTab.TabIndex = 0;
            this.InputTab.Text = "Input";
            this.InputTab.UseVisualStyleBackColor = true;
            // 
            // DateLabel_I
            // 
            this.DateLabel_I.AutoSize = true;
            this.DateLabel_I.Location = new System.Drawing.Point(11, 100);
            this.DateLabel_I.Name = "DateLabel_I";
            this.DateLabel_I.Size = new System.Drawing.Size(30, 13);
            this.DateLabel_I.TabIndex = 8;
            this.DateLabel_I.Text = "Date";
            // 
            // ValueLabel_I
            // 
            this.ValueLabel_I.AutoSize = true;
            this.ValueLabel_I.Location = new System.Drawing.Point(11, 74);
            this.ValueLabel_I.Name = "ValueLabel_I";
            this.ValueLabel_I.Size = new System.Drawing.Size(34, 13);
            this.ValueLabel_I.TabIndex = 7;
            this.ValueLabel_I.Text = "Value";
            // 
            // CategoryLabel_I
            // 
            this.CategoryLabel_I.AutoSize = true;
            this.CategoryLabel_I.Location = new System.Drawing.Point(11, 48);
            this.CategoryLabel_I.Name = "CategoryLabel_I";
            this.CategoryLabel_I.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel_I.TabIndex = 6;
            this.CategoryLabel_I.Text = "Category";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(66, 123);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DateTextY_I
            // 
            this.DateTextY_I.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DateTextY_I.Location = new System.Drawing.Point(126, 97);
            this.DateTextY_I.Name = "DateTextY_I";
            this.DateTextY_I.Size = new System.Drawing.Size(40, 20);
            this.DateTextY_I.TabIndex = 4;
            this.DateTextY_I.Text = "yyyy";
            // 
            // DateTextD_I
            // 
            this.DateTextD_I.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DateTextD_I.Location = new System.Drawing.Point(95, 97);
            this.DateTextD_I.Name = "DateTextD_I";
            this.DateTextD_I.Size = new System.Drawing.Size(25, 20);
            this.DateTextD_I.TabIndex = 3;
            this.DateTextD_I.Text = "dd";
            // 
            // DateTextM_I
            // 
            this.DateTextM_I.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DateTextM_I.Location = new System.Drawing.Point(66, 97);
            this.DateTextM_I.Name = "DateTextM_I";
            this.DateTextM_I.Size = new System.Drawing.Size(23, 20);
            this.DateTextM_I.TabIndex = 2;
            this.DateTextM_I.Text = "mm";
            // 
            // ValueTextBox_I
            // 
            this.ValueTextBox_I.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ValueTextBox_I.Location = new System.Drawing.Point(66, 71);
            this.ValueTextBox_I.Name = "ValueTextBox_I";
            this.ValueTextBox_I.Size = new System.Drawing.Size(100, 20);
            this.ValueTextBox_I.TabIndex = 1;
            this.ValueTextBox_I.Text = "8.05, 750, 3.99...";
            // 
            // CategoryTextBox_I
            // 
            this.CategoryTextBox_I.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CategoryTextBox_I.Location = new System.Drawing.Point(66, 45);
            this.CategoryTextBox_I.Name = "CategoryTextBox_I";
            this.CategoryTextBox_I.Size = new System.Drawing.Size(120, 20);
            this.CategoryTextBox_I.TabIndex = 0;
            this.CategoryTextBox_I.Text = "Food, Housing, Other...";
            // 
            // AnalyzeTab
            // 
            this.AnalyzeTab.Controls.Add(this.CalcButton);
            this.AnalyzeTab.Controls.Add(this.EndDateLabel);
            this.AnalyzeTab.Controls.Add(this.StartDateLabel);
            this.AnalyzeTab.Controls.Add(this.TargetLabel);
            this.AnalyzeTab.Controls.Add(this.CategoryLabel_A);
            this.AnalyzeTab.Controls.Add(this.DateFTextY);
            this.AnalyzeTab.Controls.Add(this.DateFTextD);
            this.AnalyzeTab.Controls.Add(this.DateFTextM);
            this.AnalyzeTab.Controls.Add(this.DateITextY);
            this.AnalyzeTab.Controls.Add(this.DateITextD);
            this.AnalyzeTab.Controls.Add(this.DateITextM);
            this.AnalyzeTab.Controls.Add(this.TargetTextBox);
            this.AnalyzeTab.Controls.Add(this.CategoryTextBox_A);
            this.AnalyzeTab.Controls.Add(this.AddressLabel);
            this.AnalyzeTab.Controls.Add(this.DescriptionLabel);
            this.AnalyzeTab.Location = new System.Drawing.Point(4, 22);
            this.AnalyzeTab.Name = "AnalyzeTab";
            this.AnalyzeTab.Padding = new System.Windows.Forms.Padding(3);
            this.AnalyzeTab.Size = new System.Drawing.Size(227, 194);
            this.AnalyzeTab.TabIndex = 1;
            this.AnalyzeTab.Text = "Analyze";
            this.AnalyzeTab.UseVisualStyleBackColor = true;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(101, 159);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(75, 23);
            this.CalcButton.TabIndex = 14;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(7, 136);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(52, 13);
            this.EndDateLabel.TabIndex = 13;
            this.EndDateLabel.Text = "End Date";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(7, 110);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(55, 13);
            this.StartDateLabel.TabIndex = 12;
            this.StartDateLabel.Text = "Start Date";
            // 
            // TargetLabel
            // 
            this.TargetLabel.AutoSize = true;
            this.TargetLabel.Location = new System.Drawing.Point(7, 84);
            this.TargetLabel.Name = "TargetLabel";
            this.TargetLabel.Size = new System.Drawing.Size(86, 13);
            this.TargetLabel.TabIndex = 11;
            this.TargetLabel.Text = "Target Spending";
            // 
            // CategoryLabel_A
            // 
            this.CategoryLabel_A.AutoSize = true;
            this.CategoryLabel_A.Location = new System.Drawing.Point(7, 56);
            this.CategoryLabel_A.Name = "CategoryLabel_A";
            this.CategoryLabel_A.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel_A.TabIndex = 10;
            this.CategoryLabel_A.Text = "Category";
            // 
            // DateFTextY
            // 
            this.DateFTextY.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DateFTextY.Location = new System.Drawing.Point(161, 133);
            this.DateFTextY.Name = "DateFTextY";
            this.DateFTextY.Size = new System.Drawing.Size(40, 20);
            this.DateFTextY.TabIndex = 9;
            this.DateFTextY.Text = "yyyy";
            // 
            // DateFTextD
            // 
            this.DateFTextD.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DateFTextD.Location = new System.Drawing.Point(129, 133);
            this.DateFTextD.Name = "DateFTextD";
            this.DateFTextD.Size = new System.Drawing.Size(26, 20);
            this.DateFTextD.TabIndex = 8;
            this.DateFTextD.Text = "dd";
            // 
            // DateFTextM
            // 
            this.DateFTextM.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DateFTextM.Location = new System.Drawing.Point(101, 133);
            this.DateFTextM.Name = "DateFTextM";
            this.DateFTextM.Size = new System.Drawing.Size(22, 20);
            this.DateFTextM.TabIndex = 7;
            this.DateFTextM.Text = "mm";
            // 
            // DateITextY
            // 
            this.DateITextY.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DateITextY.Location = new System.Drawing.Point(161, 107);
            this.DateITextY.Name = "DateITextY";
            this.DateITextY.Size = new System.Drawing.Size(40, 20);
            this.DateITextY.TabIndex = 6;
            this.DateITextY.Text = "yyyy";
            // 
            // DateITextD
            // 
            this.DateITextD.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DateITextD.Location = new System.Drawing.Point(129, 107);
            this.DateITextD.Name = "DateITextD";
            this.DateITextD.Size = new System.Drawing.Size(26, 20);
            this.DateITextD.TabIndex = 5;
            this.DateITextD.Text = "dd";
            // 
            // DateITextM
            // 
            this.DateITextM.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DateITextM.Location = new System.Drawing.Point(101, 107);
            this.DateITextM.Name = "DateITextM";
            this.DateITextM.Size = new System.Drawing.Size(22, 20);
            this.DateITextM.TabIndex = 4;
            this.DateITextM.Text = "mm";
            // 
            // TargetTextBox
            // 
            this.TargetTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.TargetTextBox.Location = new System.Drawing.Point(101, 81);
            this.TargetTextBox.Name = "TargetTextBox";
            this.TargetTextBox.Size = new System.Drawing.Size(100, 20);
            this.TargetTextBox.TabIndex = 3;
            this.TargetTextBox.Text = "2788, 436, 900...";
            // 
            // CategoryTextBox_A
            // 
            this.CategoryTextBox_A.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CategoryTextBox_A.Location = new System.Drawing.Point(101, 53);
            this.CategoryTextBox_A.Name = "CategoryTextBox_A";
            this.CategoryTextBox_A.Size = new System.Drawing.Size(100, 20);
            this.CategoryTextBox_A.TabIndex = 2;
            this.CategoryTextBox_A.Text = "All, Food, Housing...";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 26);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(0, 13);
            this.AddressLabel.TabIndex = 1;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 13);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(194, 13);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = "Budget Aid will reference data stored in:";
            // 
            // BudgetAid
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 244);
            this.Controls.Add(this.TabCon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(277, 282);
            this.MinimumSize = new System.Drawing.Size(277, 282);
            this.Name = "BudgetAid";
            this.Text = "Budget Aid 1.0";
            this.TabCon.ResumeLayout(false);
            this.InputTab.ResumeLayout(false);
            this.InputTab.PerformLayout();
            this.AnalyzeTab.ResumeLayout(false);
            this.AnalyzeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabCon;
        private System.Windows.Forms.TabPage InputTab;
        private System.Windows.Forms.TabPage AnalyzeTab;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox DateTextY_I;
        private System.Windows.Forms.TextBox DateTextD_I;
        private System.Windows.Forms.TextBox DateTextM_I;
        private System.Windows.Forms.TextBox ValueTextBox_I;
        private System.Windows.Forms.TextBox CategoryTextBox_I;
        private System.Windows.Forms.Label DateLabel_I;
        private System.Windows.Forms.Label ValueLabel_I;
        private System.Windows.Forms.Label CategoryLabel_I;
        private System.Windows.Forms.TextBox DateITextM;
        private System.Windows.Forms.TextBox TargetTextBox;
        private System.Windows.Forms.TextBox CategoryTextBox_A;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DateFTextY;
        private System.Windows.Forms.TextBox DateFTextD;
        private System.Windows.Forms.TextBox DateFTextM;
        private System.Windows.Forms.TextBox DateITextY;
        private System.Windows.Forms.TextBox DateITextD;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label TargetLabel;
        private System.Windows.Forms.Label CategoryLabel_A;
        private System.Windows.Forms.Button CalcButton;
    }
}

