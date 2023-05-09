using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Input;

namespace ScreenReaderProject
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private ScreenReader screenReader;

        public Form1()
        {
            InitializeComponent();
            screenReader = new ScreenReader();
        }
        private void FormKeyEvent(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.CapsLock)
            {
                if (Control.IsKeyLocked(Keys.CapsLock))
                {
                    screenReader.ReadText("Caps Lock On");
                }
                else
                {
                    screenReader.ReadText("Caps Lock Off");
                }
            }

        }

        private void FormKeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                screenReader.ReadText("Space");
            }
            else
            {
                screenReader.ReadText(e.KeyChar.ToString());
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            screenReader.ReadText("TTS");
            screenReader.ReadText(richTextBox1.Text);
        }

        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormKeyPressEvent);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKeyEvent);

            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // Here RichTextBox
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 153);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            
            // label
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            
            // button
            this.button1.Location = new System.Drawing.Point(350, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "TTS";
            this.button1.Font = new Font("Arial", 16, FontStyle.Bold);
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 7F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Text To Speech(TTS)";
            this.button1.BackColor = Color.Gray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
