namespace Reimbursement_Calculator
{
    partial class Form1
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
            this.labelStartingMileage = new System.Windows.Forms.Label();
            this.labelEndingMileage = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelAmountOwed = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonDisplayMiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStartingMileage
            // 
            this.labelStartingMileage.AutoSize = true;
            this.labelStartingMileage.Location = new System.Drawing.Point(23, 28);
            this.labelStartingMileage.Name = "labelStartingMileage";
            this.labelStartingMileage.Size = new System.Drawing.Size(83, 13);
            this.labelStartingMileage.TabIndex = 0;
            this.labelStartingMileage.Text = "Starting Mileage";
            // 
            // labelEndingMileage
            // 
            this.labelEndingMileage.AutoSize = true;
            this.labelEndingMileage.Location = new System.Drawing.Point(23, 57);
            this.labelEndingMileage.Name = "labelEndingMileage";
            this.labelEndingMileage.Size = new System.Drawing.Size(80, 13);
            this.labelEndingMileage.TabIndex = 1;
            this.labelEndingMileage.Text = "Ending Mileage";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(169, 24);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(169, 53);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // labelAmountOwed
            // 
            this.labelAmountOwed.AutoSize = true;
            this.labelAmountOwed.Location = new System.Drawing.Point(23, 86);
            this.labelAmountOwed.Name = "labelAmountOwed";
            this.labelAmountOwed.Size = new System.Drawing.Size(74, 13);
            this.labelAmountOwed.TabIndex = 4;
            this.labelAmountOwed.Text = "Amount Owed";
            this.labelAmountOwed.Click += new System.EventHandler(this.labelAmountOwed_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(169, 86);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(74, 13);
            this.labelAmount.TabIndex = 5;
            this.labelAmount.Text = "Amount Owed";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(23, 121);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(120, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonDisplayMiles
            // 
            this.buttonDisplayMiles.Location = new System.Drawing.Point(169, 121);
            this.buttonDisplayMiles.Name = "buttonDisplayMiles";
            this.buttonDisplayMiles.Size = new System.Drawing.Size(120, 23);
            this.buttonDisplayMiles.TabIndex = 7;
            this.buttonDisplayMiles.Text = "Display Miles";
            this.buttonDisplayMiles.UseVisualStyleBackColor = true;
            this.buttonDisplayMiles.Click += new System.EventHandler(this.buttonDisplayMiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 156);
            this.Controls.Add(this.buttonDisplayMiles);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelAmountOwed);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelEndingMileage);
            this.Controls.Add(this.labelStartingMileage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStartingMileage;
        private System.Windows.Forms.Label labelEndingMileage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label labelAmountOwed;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonDisplayMiles;
    }
}

