namespace prjPopulation
{
    partial class frmPopulation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtOldPop = new System.Windows.Forms.TextBox();
            this.txtNewPop = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblOldPop = new System.Windows.Forms.Label();
            this.lblNewPop = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPercentChange = new System.Windows.Forms.Label();
            this.lblPercentIncrease = new System.Windows.Forms.Label();
            this.lblPercentDecrease = new System.Windows.Forms.Label();
            this.txtPercentIncrease = new System.Windows.Forms.TextBox();
            this.txtPercentDecrease = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Location = new System.Drawing.Point(58, 89);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(253, 27);
            this.txtCity.TabIndex = 0;
            // 
            // txtState
            // 
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtState.Location = new System.Drawing.Point(423, 89);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(66, 27);
            this.txtState.TabIndex = 1;
            // 
            // txtOldPop
            // 
            this.txtOldPop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOldPop.Location = new System.Drawing.Point(156, 218);
            this.txtOldPop.Name = "txtOldPop";
            this.txtOldPop.Size = new System.Drawing.Size(155, 27);
            this.txtOldPop.TabIndex = 2;
            // 
            // txtNewPop
            // 
            this.txtNewPop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPop.Location = new System.Drawing.Point(156, 318);
            this.txtNewPop.Name = "txtNewPop";
            this.txtNewPop.Size = new System.Drawing.Size(155, 27);
            this.txtNewPop.TabIndex = 3;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(423, 66);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(43, 20);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(58, 66);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 20);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City";
            // 
            // lblOldPop
            // 
            this.lblOldPop.AutoSize = true;
            this.lblOldPop.Location = new System.Drawing.Point(203, 195);
            this.lblOldPop.Name = "lblOldPop";
            this.lblOldPop.Size = new System.Drawing.Size(108, 20);
            this.lblOldPop.TabIndex = 6;
            this.lblOldPop.Text = "Old Population";
            // 
            // lblNewPop
            // 
            this.lblNewPop.AutoSize = true;
            this.lblNewPop.Location = new System.Drawing.Point(197, 295);
            this.lblNewPop.Name = "lblNewPop";
            this.lblNewPop.Size = new System.Drawing.Size(114, 20);
            this.lblNewPop.TabIndex = 7;
            this.lblNewPop.Text = "New Population";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(145, 378);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 50);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(341, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 50);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(532, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 50);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(460, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 199);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblPercentChange
            // 
            this.lblPercentChange.AutoSize = true;
            this.lblPercentChange.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPercentChange.Location = new System.Drawing.Point(469, 173);
            this.lblPercentChange.Name = "lblPercentChange";
            this.lblPercentChange.Size = new System.Drawing.Size(111, 20);
            this.lblPercentChange.TabIndex = 12;
            this.lblPercentChange.Text = "Percent Change";
            // 
            // lblPercentIncrease
            // 
            this.lblPercentIncrease.AutoSize = true;
            this.lblPercentIncrease.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPercentIncrease.Location = new System.Drawing.Point(497, 218);
            this.lblPercentIncrease.Name = "lblPercentIncrease";
            this.lblPercentIncrease.Size = new System.Drawing.Size(115, 20);
            this.lblPercentIncrease.TabIndex = 13;
            this.lblPercentIncrease.Text = "Percent Increase";
            // 
            // lblPercentDecrease
            // 
            this.lblPercentDecrease.AutoSize = true;
            this.lblPercentDecrease.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPercentDecrease.Location = new System.Drawing.Point(497, 285);
            this.lblPercentDecrease.Name = "lblPercentDecrease";
            this.lblPercentDecrease.Size = new System.Drawing.Size(122, 20);
            this.lblPercentDecrease.TabIndex = 14;
            this.lblPercentDecrease.Text = "Percent Decrease";
            // 
            // txtPercentIncrease
            // 
            this.txtPercentIncrease.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtPercentIncrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPercentIncrease.Location = new System.Drawing.Point(497, 255);
            this.txtPercentIncrease.Name = "txtPercentIncrease";
            this.txtPercentIncrease.ReadOnly = true;
            this.txtPercentIncrease.Size = new System.Drawing.Size(155, 27);
            this.txtPercentIncrease.TabIndex = 0;
            // 
            // txtPercentDecrease
            // 
            this.txtPercentDecrease.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtPercentDecrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPercentDecrease.Location = new System.Drawing.Point(497, 318);
            this.txtPercentDecrease.Name = "txtPercentDecrease";
            this.txtPercentDecrease.ReadOnly = true;
            this.txtPercentDecrease.Size = new System.Drawing.Size(155, 27);
            this.txtPercentDecrease.TabIndex = 0;
            // 
            // frmPopulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPercentDecrease);
            this.Controls.Add(this.txtPercentIncrease);
            this.Controls.Add(this.lblPercentDecrease);
            this.Controls.Add(this.lblPercentIncrease);
            this.Controls.Add(this.lblPercentChange);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblNewPop);
            this.Controls.Add(this.lblOldPop);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtNewPop);
            this.Controls.Add(this.txtOldPop);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Name = "frmPopulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compare Population";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtOldPop;
        private TextBox txtNewPop;
        private Label lblState;
        private Label lblCity;
        private Label lblOldPop;
        private Label lblNewPop;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private PictureBox pictureBox1;
        private Label lblPercentChange;
        private Label lblPercentIncrease;
        private Label lblPercentDecrease;
        private TextBox txtPercentIncrease;
        private TextBox txtPercentDecrease;
    }
}