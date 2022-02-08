
namespace Pierwsze_okno
{
    partial class Komunikat
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
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonNieZapisuj = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czy chcesz zapisać plik?";
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(65, 116);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(75, 23);
            this.buttonZapisz.TabIndex = 1;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonNieZapisuj
            // 
            this.buttonNieZapisuj.Location = new System.Drawing.Point(230, 116);
            this.buttonNieZapisuj.Name = "buttonNieZapisuj";
            this.buttonNieZapisuj.Size = new System.Drawing.Size(75, 23);
            this.buttonNieZapisuj.TabIndex = 2;
            this.buttonNieZapisuj.Text = "Nie zapisuj";
            this.buttonNieZapisuj.UseVisualStyleBackColor = true;
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(413, 116);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 3;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            // 
            // Komunikat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 174);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonNieZapisuj);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Komunikat";
            this.Text = "Komunikat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonNieZapisuj;
        private System.Windows.Forms.Button buttonAnuluj;
    }
}