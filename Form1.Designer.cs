
namespace cps_tracker
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CLICKPRZYCISK = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.czas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RESET = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CLICKPRZYCISK
            // 
            this.CLICKPRZYCISK.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CLICKPRZYCISK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CLICKPRZYCISK.Location = new System.Drawing.Point(0, 25);
            this.CLICKPRZYCISK.Name = "CLICKPRZYCISK";
            this.CLICKPRZYCISK.Size = new System.Drawing.Size(404, 164);
            this.CLICKPRZYCISK.TabIndex = 0;
            this.CLICKPRZYCISK.Text = "CLICK";
            this.CLICKPRZYCISK.UseVisualStyleBackColor = false;
            this.CLICKPRZYCISK.Click += new System.EventHandler(this.CLICKPRZYCISK_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(12, 216);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(39, 13);
            this.czas.TabIndex = 1;
            this.czas.Text = "TIME: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLICK PER SOCOND: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLICKS: 0";
            // 
            // RESET
            // 
            this.RESET.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RESET.Location = new System.Drawing.Point(0, 190);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(404, 23);
            this.RESET.TabIndex = 4;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = false;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 216);
            this.label3.MaximumSize = new System.Drawing.Size(22, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(403, 236);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.CLICKPRZYCISK);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(419, 275);
            this.MinimumSize = new System.Drawing.Size(419, 275);
            this.Name = "Form1";
            this.Text = "DUDEK-CPS TRACKER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CLICKPRZYCISK;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label czas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Label label3;
    }
}

