namespace quiz1_BMI_calc
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
            this.Height = new System.Windows.Forms.Label();
            this.feet = new System.Windows.Forms.Label();
            this.inch = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.pounds = new System.Windows.Forms.Label();
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtInch = new System.Windows.Forms.TextBox();
            this.txtLbs = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.BMI = new System.Windows.Forms.Label();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.Location = new System.Drawing.Point(78, 60);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(68, 32);
            this.Height.TabIndex = 0;
            this.Height.Text = "      Your \r\nHeight:";
            // 
            // feet
            // 
            this.feet.AutoSize = true;
            this.feet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feet.Location = new System.Drawing.Point(147, 95);
            this.feet.Name = "feet";
            this.feet.Size = new System.Drawing.Size(45, 13);
            this.feet.TabIndex = 1;
            this.feet.Text = "( feet )";
            // 
            // inch
            // 
            this.inch.AutoSize = true;
            this.inch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inch.Location = new System.Drawing.Point(355, 95);
            this.inch.Name = "inch";
            this.inch.Size = new System.Drawing.Size(60, 13);
            this.inch.TabIndex = 2;
            this.inch.Text = "( inches )";
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(78, 167);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(64, 32);
            this.Weight.TabIndex = 3;
            this.Weight.Text = "      Your\r\nWeight:";
            // 
            // pounds
            // 
            this.pounds.AutoSize = true;
            this.pounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pounds.Location = new System.Drawing.Point(137, 202);
            this.pounds.Name = "pounds";
            this.pounds.Size = new System.Drawing.Size(64, 13);
            this.pounds.TabIndex = 4;
            this.pounds.Text = "( pounds )";
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(140, 72);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(61, 20);
            this.txtFeet.TabIndex = 5;
            this.txtFeet.TextChanged += new System.EventHandler(this.TxtFeet_TextChanged);
            // 
            // txtInch
            // 
            this.txtInch.Location = new System.Drawing.Point(358, 72);
            this.txtInch.Name = "txtInch";
            this.txtInch.Size = new System.Drawing.Size(57, 20);
            this.txtInch.TabIndex = 6;
            this.txtInch.TextChanged += new System.EventHandler(this.TxtInch_TextChanged);
            // 
            // txtLbs
            // 
            this.txtLbs.Location = new System.Drawing.Point(140, 179);
            this.txtLbs.Name = "txtLbs";
            this.txtLbs.Size = new System.Drawing.Size(61, 20);
            this.txtLbs.TabIndex = 7;
            this.txtLbs.TextChanged += new System.EventHandler(this.TxtLbs_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(202, 263);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(165, 38);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Compute BMI";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BMI
            // 
            this.BMI.AutoSize = true;
            this.BMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI.Location = new System.Drawing.Point(239, 365);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(63, 13);
            this.BMI.TabIndex = 9;
            this.BMI.Text = "Your BMI:";
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(242, 381);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(60, 20);
            this.txtBMI.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.BMI);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtLbs);
            this.Controls.Add(this.txtInch);
            this.Controls.Add(this.txtFeet);
            this.Controls.Add(this.pounds);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.inch);
            this.Controls.Add(this.feet);
            this.Controls.Add(this.Height);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label feet;
        private System.Windows.Forms.Label inch;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label pounds;
        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.TextBox txtInch;
        private System.Windows.Forms.TextBox txtLbs;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label BMI;
        private System.Windows.Forms.TextBox txtBMI;
    }
}

