namespace Odev25
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
            this.Alfabe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Alfabe
            // 
            this.Alfabe.Location = new System.Drawing.Point(113, 66);
            this.Alfabe.Name = "Alfabe";
            this.Alfabe.Size = new System.Drawing.Size(183, 22);
            this.Alfabe.TabIndex = 2;
            this.Alfabe.TabStop = false;
            this.Alfabe.Text = "a, b, X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Σ=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "CFG :";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(113, 118);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(183, 22);
            this.inputBox.TabIndex = 2;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "S-->aa|bX|aXX, X-->ab|b";
            // 
            // Liste
            // 
            this.Liste.Location = new System.Drawing.Point(428, 66);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(263, 238);
            this.Liste.TabIndex = 6;
            this.Liste.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "KELİME ÜRET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Alfabe);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Alfabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.RichTextBox Liste;
        private System.Windows.Forms.Button button1;
    }
}

