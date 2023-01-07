
namespace FibonacciApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.camp_n = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "n=";
            // 
            // camp_n
            // 
            this.camp_n.Location = new System.Drawing.Point(96, 59);
            this.camp_n.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.camp_n.Name = "camp_n";
            this.camp_n.Size = new System.Drawing.Size(189, 22);
            this.camp_n.TabIndex = 1;
            this.camp_n.KeyDown += new System.Windows.Forms.KeyEventHandler(this.camp_n_KeyDown);
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(344, 59);
            this.rez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rez.Size = new System.Drawing.Size(387, 434);
            this.rez.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(72, 430);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Afiseaza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(797, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.camp_n);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox camp_n;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Button button1;
    }
}

