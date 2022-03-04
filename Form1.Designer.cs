namespace TP_KPL_MOD2
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
            this.TombolSubmitNama = new System.Windows.Forms.Button();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TombolSubmitNama
            // 
            this.TombolSubmitNama.Location = new System.Drawing.Point(279, 173);
            this.TombolSubmitNama.Name = "TombolSubmitNama";
            this.TombolSubmitNama.Size = new System.Drawing.Size(203, 29);
            this.TombolSubmitNama.TabIndex = 0;
            this.TombolSubmitNama.Text = "Submit";
            this.TombolSubmitNama.UseVisualStyleBackColor = true;
            this.TombolSubmitNama.Click += new System.EventHandler(this.button1_Click);
            this.TombolSubmitNama.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TombolSubmitNama_MouseClick);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(283, 120);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.PlaceholderText = "Masukkan namamu disini";
            this.TextBoxInput.Size = new System.Drawing.Size(199, 27);
            this.TextBoxInput.TabIndex = 1;
            this.TextBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nanti ada sapa keluar dari sini :)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.TombolSubmitNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button TombolSubmitNama;
        private TextBox TextBoxInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
    }
}