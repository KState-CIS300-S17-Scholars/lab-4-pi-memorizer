namespace Lab4
{
    partial class uxForm
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
            this.uxNumberLabel = new System.Windows.Forms.Label();
            this.uxNumberBound = new System.Windows.Forms.TextBox();
            this.uxFindPrimes = new System.Windows.Forms.Button();
            this.uxPrimes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxNumberLabel
            // 
            this.uxNumberLabel.AutoSize = true;
            this.uxNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNumberLabel.Location = new System.Drawing.Point(13, 13);
            this.uxNumberLabel.Name = "uxNumberLabel";
            this.uxNumberLabel.Size = new System.Drawing.Size(239, 29);
            this.uxNumberLabel.TabIndex = 0;
            this.uxNumberLabel.Text = "Enter positive bound:";
            // 
            // uxNumberBound
            // 
            this.uxNumberBound.Location = new System.Drawing.Point(259, 19);
            this.uxNumberBound.Name = "uxNumberBound";
            this.uxNumberBound.Size = new System.Drawing.Size(165, 22);
            this.uxNumberBound.TabIndex = 1;
            // 
            // uxFindPrimes
            // 
            this.uxFindPrimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFindPrimes.Location = new System.Drawing.Point(118, 68);
            this.uxFindPrimes.Name = "uxFindPrimes";
            this.uxFindPrimes.Size = new System.Drawing.Size(196, 67);
            this.uxFindPrimes.TabIndex = 2;
            this.uxFindPrimes.Text = "Find Primes";
            this.uxFindPrimes.UseVisualStyleBackColor = true;
            this.uxFindPrimes.Click += new System.EventHandler(this.uxFindPrimes_Click);
            // 
            // uxPrimes
            // 
            this.uxPrimes.Location = new System.Drawing.Point(12, 160);
            this.uxPrimes.Multiline = true;
            this.uxPrimes.Name = "uxPrimes";
            this.uxPrimes.ReadOnly = true;
            this.uxPrimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxPrimes.Size = new System.Drawing.Size(420, 236);
            this.uxPrimes.TabIndex = 3;
            // 
            // uxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 408);
            this.Controls.Add(this.uxPrimes);
            this.Controls.Add(this.uxFindPrimes);
            this.Controls.Add(this.uxNumberBound);
            this.Controls.Add(this.uxNumberLabel);
            this.Name = "uxForm";
            this.Text = "Sieve of Eratosthenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxNumberLabel;
        private System.Windows.Forms.TextBox uxNumberBound;
        private System.Windows.Forms.Button uxFindPrimes;
        private System.Windows.Forms.TextBox uxPrimes;
    }
}

