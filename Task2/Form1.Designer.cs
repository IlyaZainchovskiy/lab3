namespace Task2
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rb9x12 = new System.Windows.Forms.RadioButton();
            this.rb12x15 = new System.Windows.Forms.RadioButton();
            this.rb18x24 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rb18x24);
            this.gbSize.Controls.Add(this.rb9x12);
            this.gbSize.Controls.Add(this.rb12x15);
            this.gbSize.Location = new System.Drawing.Point(51, 52);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(204, 142);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Розмір фотографії";
            // 
            // rb9x12
            // 
            this.rb9x12.AutoSize = true;
            this.rb9x12.Location = new System.Drawing.Point(6, 25);
            this.rb9x12.Name = "rb9x12";
            this.rb9x12.Size = new System.Drawing.Size(175, 24);
            this.rb9x12.TabIndex = 1;
            this.rb9x12.TabStop = true;
            this.rb9x12.Text = "9 x 12 - 5.50 грн.шт";
            this.rb9x12.UseVisualStyleBackColor = true;
            // 
            // rb12x15
            // 
            this.rb12x15.AutoSize = true;
            this.rb12x15.Location = new System.Drawing.Point(6, 55);
            this.rb12x15.Name = "rb12x15";
            this.rb12x15.Size = new System.Drawing.Size(193, 24);
            this.rb12x15.TabIndex = 2;
            this.rb12x15.TabStop = true;
            this.rb12x15.Text = "12 x 15 - 10.00 грн/шт";
            this.rb12x15.UseVisualStyleBackColor = true;
            // 
            // rb18x24
            // 
            this.rb18x24.AutoSize = true;
            this.rb18x24.Location = new System.Drawing.Point(6, 85);
            this.rb18x24.Name = "rb18x24";
            this.rb18x24.Size = new System.Drawing.Size(193, 24);
            this.rb18x24.TabIndex = 3;
            this.rb18x24.TabStop = true;
            this.rb18x24.Text = "18 x 24 - 22.50 грн/шт";
            this.rb18x24.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кількість фотографій:";
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(276, 88);
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
            this.numCount.TabIndex = 2;
            this.numCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(499, 52);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 49);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(53, 231);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(94, 20);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Розрахунок";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSize);
            this.Name = "Form1";
            this.Text = "Розрахунок вартості друку фото";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rb18x24;
        private System.Windows.Forms.RadioButton rb9x12;
        private System.Windows.Forms.RadioButton rb12x15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}

