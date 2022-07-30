
namespace Blackjack
{
    partial class Game
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
            this.pictureTable = new System.Windows.Forms.PictureBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.buttonHit = new System.Windows.Forms.Button();
            this.buttonStand = new System.Windows.Forms.Button();
            this.buttonBet = new System.Windows.Forms.Button();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureTable
            // 
            this.pictureTable.Image = global::Blackjack.Properties.Resources.realistic_poker_table_d_rendered_scene_48173892;
            this.pictureTable.Location = new System.Drawing.Point(0, 0);
            this.pictureTable.Name = "pictureTable";
            this.pictureTable.Size = new System.Drawing.Size(1085, 614);
            this.pictureTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTable.TabIndex = 1;
            this.pictureTable.TabStop = false;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Indigo;
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRestart.ForeColor = System.Drawing.Color.White;
            this.buttonRestart.Location = new System.Drawing.Point(45, 558);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(201, 45);
            this.buttonRestart.TabIndex = 2;
            this.buttonRestart.Text = "Start the Hand";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.BackColor = System.Drawing.Color.Indigo;
            this.labelBalance.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalance.ForeColor = System.Drawing.Color.White;
            this.labelBalance.Location = new System.Drawing.Point(745, 21);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(170, 27);
            this.labelBalance.TabIndex = 3;
            this.labelBalance.Text = "Your Balance:";
            this.labelBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.Indigo;
            this.labelMoney.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMoney.ForeColor = System.Drawing.Color.White;
            this.labelMoney.Location = new System.Drawing.Point(956, 21);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(0, 27);
            this.labelMoney.TabIndex = 4;
            // 
            // buttonHit
            // 
            this.buttonHit.BackColor = System.Drawing.Color.Indigo;
            this.buttonHit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHit.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHit.ForeColor = System.Drawing.Color.White;
            this.buttonHit.Location = new System.Drawing.Point(699, 558);
            this.buttonHit.Name = "buttonHit";
            this.buttonHit.Size = new System.Drawing.Size(138, 45);
            this.buttonHit.TabIndex = 5;
            this.buttonHit.Text = "HIT";
            this.buttonHit.UseVisualStyleBackColor = false;
            // 
            // buttonStand
            // 
            this.buttonStand.BackColor = System.Drawing.Color.Indigo;
            this.buttonStand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStand.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStand.ForeColor = System.Drawing.Color.White;
            this.buttonStand.Location = new System.Drawing.Point(915, 558);
            this.buttonStand.Name = "buttonStand";
            this.buttonStand.Size = new System.Drawing.Size(138, 45);
            this.buttonStand.TabIndex = 6;
            this.buttonStand.Text = "STAND";
            this.buttonStand.UseVisualStyleBackColor = false;
            // 
            // buttonBet
            // 
            this.buttonBet.BackColor = System.Drawing.Color.Indigo;
            this.buttonBet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBet.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBet.ForeColor = System.Drawing.Color.White;
            this.buttonBet.Location = new System.Drawing.Point(45, 12);
            this.buttonBet.Name = "buttonBet";
            this.buttonBet.Size = new System.Drawing.Size(243, 45);
            this.buttonBet.TabIndex = 7;
            this.buttonBet.Text = "Choose your bet";
            this.buttonBet.UseVisualStyleBackColor = false;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.BackColor = System.Drawing.Color.Indigo;
            this.textBoxMoney.ForeColor = System.Drawing.Color.White;
            this.textBoxMoney.Location = new System.Drawing.Point(314, 25);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(100, 23);
            this.textBoxMoney.TabIndex = 8;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.buttonBet);
            this.Controls.Add(this.buttonStand);
            this.Controls.Add(this.buttonHit);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.pictureTable);
            this.Name = "Game";
            this.Text = "Blackjack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureTable;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button buttonHit;
        private System.Windows.Forms.Button buttonStand;
        private System.Windows.Forms.Button buttonBet;
        private System.Windows.Forms.TextBox textBoxMoney;
    }
}

