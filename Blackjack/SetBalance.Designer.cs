
namespace Blackjack
{
    partial class SetBalance
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
            this.labelSetBalance = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelAttention = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSetBalance
            // 
            this.labelSetBalance.AutoSize = true;
            this.labelSetBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSetBalance.Font = new System.Drawing.Font("Showcard Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSetBalance.Location = new System.Drawing.Point(33, 59);
            this.labelSetBalance.Name = "labelSetBalance";
            this.labelSetBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSetBalance.Size = new System.Drawing.Size(486, 21);
            this.labelSetBalance.TabIndex = 0;
            this.labelSetBalance.Text = "Please insert the sum of money you are going to play";
            this.labelSetBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.BackColor = System.Drawing.Color.Indigo;
            this.textBoxMoney.ForeColor = System.Drawing.Color.White;
            this.textBoxMoney.Location = new System.Drawing.Point(221, 115);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(100, 23);
            this.textBoxMoney.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Black;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(184, 183);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(173, 61);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelAttention
            // 
            this.labelAttention.AutoSize = true;
            this.labelAttention.BackColor = System.Drawing.Color.Indigo;
            this.labelAttention.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAttention.ForeColor = System.Drawing.Color.White;
            this.labelAttention.Location = new System.Drawing.Point(334, 333);
            this.labelAttention.Name = "labelAttention";
            this.labelAttention.Size = new System.Drawing.Size(212, 16);
            this.labelAttention.TabIndex = 3;
            this.labelAttention.Text = "We are not responsible for possible losses!!!";
            // 
            // SetBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(558, 358);
            this.Controls.Add(this.labelAttention);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.labelSetBalance);
            this.Name = "SetBalance";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSetBalance;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelAttention;
    }
}