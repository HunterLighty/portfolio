
namespace Assignment9_Lighty
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
            this.Cattxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Desctxt = new System.Windows.Forms.TextBox();
            this.Desclbl = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.TextBox();
            this.Catlbl = new System.Windows.Forms.TextBox();
            this.Nextbtn = new System.Windows.Forms.Button();
            this.Prevbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cattxt
            // 
            this.Cattxt.Location = new System.Drawing.Point(466, 12);
            this.Cattxt.Multiline = true;
            this.Cattxt.Name = "Cattxt";
            this.Cattxt.ReadOnly = true;
            this.Cattxt.Size = new System.Drawing.Size(301, 92);
            this.Cattxt.TabIndex = 0;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(466, 110);
            this.Nametxt.Multiline = true;
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.ReadOnly = true;
            this.Nametxt.Size = new System.Drawing.Size(301, 94);
            this.Nametxt.TabIndex = 1;
            // 
            // Desctxt
            // 
            this.Desctxt.Location = new System.Drawing.Point(466, 210);
            this.Desctxt.Multiline = true;
            this.Desctxt.Name = "Desctxt";
            this.Desctxt.ReadOnly = true;
            this.Desctxt.Size = new System.Drawing.Size(301, 83);
            this.Desctxt.TabIndex = 2;
            // 
            // Desclbl
            // 
            this.Desclbl.Location = new System.Drawing.Point(64, 239);
            this.Desclbl.Name = "Desclbl";
            this.Desclbl.ReadOnly = true;
            this.Desclbl.Size = new System.Drawing.Size(145, 20);
            this.Desclbl.TabIndex = 3;
            this.Desclbl.Text = "Description";
            // 
            // Namelbl
            // 
            this.Namelbl.Location = new System.Drawing.Point(64, 145);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.ReadOnly = true;
            this.Namelbl.Size = new System.Drawing.Size(145, 20);
            this.Namelbl.TabIndex = 4;
            this.Namelbl.Text = "Name";
            // 
            // Catlbl
            // 
            this.Catlbl.Location = new System.Drawing.Point(64, 48);
            this.Catlbl.Name = "Catlbl";
            this.Catlbl.ReadOnly = true;
            this.Catlbl.Size = new System.Drawing.Size(145, 20);
            this.Catlbl.TabIndex = 5;
            this.Catlbl.Text = "Category";
            // 
            // Nextbtn
            // 
            this.Nextbtn.Location = new System.Drawing.Point(466, 323);
            this.Nextbtn.Name = "Nextbtn";
            this.Nextbtn.Size = new System.Drawing.Size(301, 102);
            this.Nextbtn.TabIndex = 6;
            this.Nextbtn.Text = "Next";
            this.Nextbtn.UseVisualStyleBackColor = true;
            this.Nextbtn.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // Prevbtn
            // 
            this.Prevbtn.Location = new System.Drawing.Point(26, 323);
            this.Prevbtn.Name = "Prevbtn";
            this.Prevbtn.Size = new System.Drawing.Size(301, 102);
            this.Prevbtn.TabIndex = 7;
            this.Prevbtn.Text = "Previous";
            this.Prevbtn.UseVisualStyleBackColor = true;
            this.Prevbtn.Click += new System.EventHandler(this.Prevbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(346, 338);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(102, 86);
            this.Exitbtn.TabIndex = 8;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Prevbtn);
            this.Controls.Add(this.Nextbtn);
            this.Controls.Add(this.Catlbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Desclbl);
            this.Controls.Add(this.Desctxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.Cattxt);
            this.Name = "Form1";
            this.Text = "Reading Categories Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cattxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Desctxt;
        private System.Windows.Forms.TextBox Desclbl;
        private System.Windows.Forms.TextBox Namelbl;
        private System.Windows.Forms.TextBox Catlbl;
        private System.Windows.Forms.Button Nextbtn;
        private System.Windows.Forms.Button Prevbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}

