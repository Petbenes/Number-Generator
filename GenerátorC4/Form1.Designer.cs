namespace GenerátorC4
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.btGeneruj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVysledek = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSeed
            // 
            this.txtSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSeed.Location = new System.Drawing.Point(92, 44);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(285, 29);
            this.txtSeed.TabIndex = 0;
            this.txtSeed.Text = "2213";
            // 
            // btGeneruj
            // 
            this.btGeneruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btGeneruj.Location = new System.Drawing.Point(542, 46);
            this.btGeneruj.Name = "btGeneruj";
            this.btGeneruj.Size = new System.Drawing.Size(198, 96);
            this.btGeneruj.TabIndex = 1;
            this.btGeneruj.Text = "Generate";
            this.btGeneruj.UseVisualStyleBackColor = true;
            this.btGeneruj.Click += new System.EventHandler(this.btGeneruj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seed:";
            // 
            // txtVysledek
            // 
            this.txtVysledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtVysledek.Location = new System.Drawing.Point(48, 168);
            this.txtVysledek.Multiline = true;
            this.txtVysledek.Name = "txtVysledek";
            this.txtVysledek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVysledek.Size = new System.Drawing.Size(692, 313);
            this.txtVysledek.TabIndex = 3;
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btClear.Location = new System.Drawing.Point(391, 108);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(101, 34);
            this.btClear.TabIndex = 4;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 505);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.txtVysledek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGeneruj);
            this.Controls.Add(this.txtSeed);
            this.Name = "Form1";
            this.Text = "Generátor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Button btGeneruj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVysledek;
        private System.Windows.Forms.Button btClear;
    }
}

