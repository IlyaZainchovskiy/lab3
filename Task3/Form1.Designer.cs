namespace Task3
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cb9x12 = new System.Windows.Forms.CheckBox();
            this.cb12x15 = new System.Windows.Forms.CheckBox();
            this.cb18x24 = new System.Windows.Forms.CheckBox();
            this.gbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(514, 64);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 49);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.cb9x12);
            this.gbSize.Controls.Add(this.cb18x24);
            this.gbSize.Controls.Add(this.cb12x15);
            this.gbSize.Location = new System.Drawing.Point(66, 64);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(204, 142);
            this.gbSize.TabIndex = 5;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Розмір фотографії";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(68, 243);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(94, 20);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Розрахунок";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(291, 100);
            this.numCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(120, 26);
            this.numCount.TabIndex = 7;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кількість фотографій:";
            // 
            // cb9x12
            // 
            this.cb9x12.AutoSize = true;
            this.cb9x12.Location = new System.Drawing.Point(6, 25);
            this.cb9x12.Name = "cb9x12";
            this.cb9x12.Size = new System.Drawing.Size(176, 24);
            this.cb9x12.TabIndex = 10;
            this.cb9x12.Text = "9 x 12 - 5.50 грн.шт";
            this.cb9x12.UseVisualStyleBackColor = true;
            // 
            // cb12x15
            // 
            this.cb12x15.AutoSize = true;
            this.cb12x15.Location = new System.Drawing.Point(6, 55);
            this.cb12x15.Name = "cb12x15";
            this.cb12x15.Size = new System.Drawing.Size(194, 24);
            this.cb12x15.TabIndex = 11;
            this.cb12x15.Text = "12 x 15 - 10.00 грн/шт";
            this.cb12x15.UseVisualStyleBackColor = true;
            // 
            // cb18x24
            // 
            this.cb18x24.AutoSize = true;
            this.cb18x24.Location = new System.Drawing.Point(6, 85);
            this.cb18x24.Name = "cb18x24";
            this.cb18x24.Size = new System.Drawing.Size(194, 24);
            this.cb18x24.TabIndex = 12;
            this.cb18x24.Text = "18 x 24 - 22.50 грн/шт";
            this.cb18x24.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb9x12;
        private System.Windows.Forms.CheckBox cb18x24;
        private System.Windows.Forms.CheckBox cb12x15;
    }
}

