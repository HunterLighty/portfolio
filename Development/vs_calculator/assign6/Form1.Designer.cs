
namespace assign6
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
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.TextBox();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(16, 199);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(76, 60);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(98, 199);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(87, 60);
            this.Subtract.TabIndex = 1;
            this.Subtract.Text = "Subtract";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(191, 199);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(78, 60);
            this.Multiply.TabIndex = 2;
            this.Multiply.Text = "Multiply";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(275, 199);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(76, 60);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(33, 328);
            this.Answer.Multiline = true;
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(307, 97);
            this.Answer.TabIndex = 4;
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(33, 65);
            this.Num1.Multiline = true;
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(102, 101);
            this.Num1.TabIndex = 5;
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(240, 65);
            this.Num2.Multiline = true;
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(100, 101);
            this.Num2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 437);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.TextBox Num2;
    }
}

