namespace BetterVersionOf21NiceM
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
            this.picCard2 = new System.Windows.Forms.PictureBox();
            this.picCard1 = new System.Windows.Forms.PictureBox();
            this.picCompCard1 = new System.Windows.Forms.PictureBox();
            this.picCompCard2 = new System.Windows.Forms.PictureBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblBet = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard2)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard2
            // 
            this.picCard2.Location = new System.Drawing.Point(467, 312);
            this.picCard2.Name = "picCard2";
            this.picCard2.Size = new System.Drawing.Size(72, 109);
            this.picCard2.TabIndex = 0;
            this.picCard2.TabStop = false;
            // 
            // picCard1
            // 
            this.picCard1.Location = new System.Drawing.Point(391, 312);
            this.picCard1.Name = "picCard1";
            this.picCard1.Size = new System.Drawing.Size(78, 109);
            this.picCard1.TabIndex = 1;
            this.picCard1.TabStop = false;
            // 
            // picCompCard1
            // 
            this.picCompCard1.Location = new System.Drawing.Point(350, 74);
            this.picCompCard1.Name = "picCompCard1";
            this.picCompCard1.Size = new System.Drawing.Size(90, 107);
            this.picCompCard1.TabIndex = 2;
            this.picCompCard1.TabStop = false;
            // 
            // picCompCard2
            // 
            this.picCompCard2.Location = new System.Drawing.Point(439, 74);
            this.picCompCard2.Name = "picCompCard2";
            this.picCompCard2.Size = new System.Drawing.Size(83, 107);
            this.picCompCard2.TabIndex = 3;
            this.picCompCard2.TabStop = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmount.Location = new System.Drawing.Point(384, 483);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(118, 42);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "label1";
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.Chartreuse;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(340, 621);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(100, 31);
            this.btnHit.TabIndex = 5;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            // 
            // btnStay
            // 
            this.btnStay.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(439, 621);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(100, 31);
            this.btnStay.TabIndex = 6;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = false;
            // 
            // txtBet
            // 
            this.txtBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.Location = new System.Drawing.Point(131, 407);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(100, 26);
            this.txtBet.TabIndex = 7;
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBet.Location = new System.Drawing.Point(32, 380);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(126, 24);
            this.lblBet.TabIndex = 8;
            this.lblBet.Text = "ENTER BET";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(676, 261);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BetterVersionOf21NiceM.Properties.Resources.single_deck_blackjack_netent_free2;
            this.ClientSize = new System.Drawing.Size(882, 650);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.picCompCard2);
            this.Controls.Add(this.picCompCard1);
            this.Controls.Add(this.picCard1);
            this.Controls.Add(this.picCard2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompCard2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCard2;
        private System.Windows.Forms.PictureBox picCard1;
        private System.Windows.Forms.PictureBox picCompCard1;
        private System.Windows.Forms.PictureBox picCompCard2;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Button btnPlay;
    }
}

