namespace HW1__weighted_grade_WFA
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
            this.Hw = new System.Windows.Forms.Label();
            this.Quiz = new System.Windows.Forms.Label();
            this.Project = new System.Windows.Forms.Label();
            this.Exam = new System.Windows.Forms.Label();
            this.Final = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.txtHw = new System.Windows.Forms.TextBox();
            this.txtQuiz = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtExam = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hw
            // 
            this.Hw.AutoSize = true;
            this.Hw.Location = new System.Drawing.Point(113, 72);
            this.Hw.Name = "Hw";
            this.Hw.Size = new System.Drawing.Size(84, 13);
            this.Hw.TabIndex = 0;
            this.Hw.Text = "Homework(10%)";
            // 
            // Quiz
            // 
            this.Quiz.AutoSize = true;
            this.Quiz.Location = new System.Drawing.Point(113, 109);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(70, 13);
            this.Quiz.TabIndex = 1;
            this.Quiz.Text = "Quizzes(20%)";
            // 
            // Project
            // 
            this.Project.AutoSize = true;
            this.Project.Location = new System.Drawing.Point(113, 156);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(71, 13);
            this.Project.TabIndex = 2;
            this.Project.Text = "Projects(25%)";
            // 
            // Exam
            // 
            this.Exam.AutoSize = true;
            this.Exam.Location = new System.Drawing.Point(113, 201);
            this.Exam.Name = "Exam";
            this.Exam.Size = new System.Drawing.Size(64, 13);
            this.Exam.TabIndex = 3;
            this.Exam.Text = "Exams(20%)";
            // 
            // Final
            // 
            this.Final.AutoSize = true;
            this.Final.Location = new System.Drawing.Point(113, 251);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(84, 13);
            this.Final.TabIndex = 4;
            this.Final.Text = "Final Exam(25%)";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(113, 353);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(63, 13);
            this.Total.TabIndex = 5;
            this.Total.Text = "Total Grade";
            // 
            // txtHw
            // 
            this.txtHw.Location = new System.Drawing.Point(345, 65);
            this.txtHw.Name = "txtHw";
            this.txtHw.Size = new System.Drawing.Size(100, 20);
            this.txtHw.TabIndex = 6;
            // 
            // txtQuiz
            // 
            this.txtQuiz.Location = new System.Drawing.Point(345, 102);
            this.txtQuiz.Name = "txtQuiz";
            this.txtQuiz.Size = new System.Drawing.Size(100, 20);
            this.txtQuiz.TabIndex = 7;
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(345, 149);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(100, 20);
            this.txtProject.TabIndex = 8;
            // 
            // txtExam
            // 
            this.txtExam.Location = new System.Drawing.Point(345, 194);
            this.txtExam.Name = "txtExam";
            this.txtExam.Size = new System.Drawing.Size(100, 20);
            this.txtExam.TabIndex = 9;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(345, 244);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(345, 346);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(323, 288);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(122, 34);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Calculate Grade";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtExam);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.txtQuiz);
            this.Controls.Add(this.txtHw);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Final);
            this.Controls.Add(this.Exam);
            this.Controls.Add(this.Project);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.Hw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hw;
        private System.Windows.Forms.Label Quiz;
        private System.Windows.Forms.Label Project;
        private System.Windows.Forms.Label Exam;
        private System.Windows.Forms.Label Final;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox txtHw;
        private System.Windows.Forms.TextBox txtQuiz;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtExam;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalc;
    }
}

