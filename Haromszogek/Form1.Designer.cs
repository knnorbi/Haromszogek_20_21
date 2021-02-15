
namespace Haromszogek
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
            this.button1 = new System.Windows.Forms.Button();
            this.haromszogek = new System.Windows.Forms.ListBox();
            this.hibaLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adatok betoltese";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // haromszogek
            // 
            this.haromszogek.FormattingEnabled = true;
            this.haromszogek.Location = new System.Drawing.Point(12, 252);
            this.haromszogek.Name = "haromszogek";
            this.haromszogek.Size = new System.Drawing.Size(230, 186);
            this.haromszogek.TabIndex = 1;
            this.haromszogek.SelectedIndexChanged += new System.EventHandler(this.haromszogek_SelectedIndexChanged);
            // 
            // hibaLb
            // 
            this.hibaLb.AutoSize = true;
            this.hibaLb.Location = new System.Drawing.Point(13, 42);
            this.hibaLb.Name = "hibaLb";
            this.hibaLb.Size = new System.Drawing.Size(35, 13);
            this.hibaLb.TabIndex = 2;
            this.hibaLb.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hibaLb);
            this.Controls.Add(this.haromszogek);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox haromszogek;
        private System.Windows.Forms.Label hibaLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

