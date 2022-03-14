
namespace PeselForms
{
    partial class OknoGlowne
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
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.labelPlec = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(202, 12);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 0;
            this.buttonSprawdz.Text = "Sprawdz";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            this.buttonSprawdz.Click += new System.EventHandler(this.buttonSprawdz_Click);
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.Location = new System.Drawing.Point(12, 12);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(167, 23);
            this.textBoxPesel.TabIndex = 1;
            this.textBoxPesel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPesel_KeyDown);
            // 
            // labelPlec
            // 
            this.labelPlec.AutoSize = true;
            this.labelPlec.Location = new System.Drawing.Point(12, 75);
            this.labelPlec.Name = "labelPlec";
            this.labelPlec.Size = new System.Drawing.Size(32, 15);
            this.labelPlec.TabIndex = 2;
            this.labelPlec.Text = "Płeć:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(15, 107);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(34, 15);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "Data:";
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPlec);
            this.Controls.Add(this.textBoxPesel);
            this.Controls.Add(this.buttonSprawdz);
            this.Name = "OknoGlowne";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.Label labelPlec;
        private System.Windows.Forms.Label labelData;
    }
}

