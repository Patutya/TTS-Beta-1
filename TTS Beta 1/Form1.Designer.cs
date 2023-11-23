namespace TTS_Beta_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.noVoice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noVoice
            // 
            this.noVoice.Location = new System.Drawing.Point(21, 196);
            this.noVoice.Multiline = true;
            this.noVoice.Name = "noVoice";
            this.noVoice.Size = new System.Drawing.Size(1098, 407);
            this.noVoice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "TTS BETA V0.1 ეს პროგრამა ჯერჯერობით არის ტესტირების ფაზაში და ჯერკიდევ დახვეწა ჭ" +
    "ირდება\r\nგთხოვთ გაითვალისწინოთ რომ ეს არ არის საბოლოო ვერსია.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(918, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 175);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(866, 64);
            this.label3.TabIndex = 3;
            this.label3.Text = "ჩასართავად ჩაწერეთ ქვემოთ მოცემულ ტექსტურ ყუთში სასურველი \r\nწინადადება და ამის შე" +
    "მდეგ დააჭირეთ ხმის ჩართვას.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1218, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "ხმის \r\nჩართვა";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noVoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox noVoice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}