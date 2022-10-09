namespace Sonu_LateFeeCalulator
{
    partial class frmNewGame
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveNewGame = new System.Windows.Forms.Button();
            this.btnCancelNewGame = new System.Windows.Forms.Button();
            this.txtStockNumber = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(232, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(232, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(232, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rating :";
            // 
            // btnSaveNewGame
            // 
            this.btnSaveNewGame.Location = new System.Drawing.Point(273, 347);
            this.btnSaveNewGame.Name = "btnSaveNewGame";
            this.btnSaveNewGame.Size = new System.Drawing.Size(125, 32);
            this.btnSaveNewGame.TabIndex = 4;
            this.btnSaveNewGame.Text = "Save";
            this.btnSaveNewGame.UseVisualStyleBackColor = true;
            // 
            // btnCancelNewGame
            // 
            this.btnCancelNewGame.Location = new System.Drawing.Point(484, 347);
            this.btnCancelNewGame.Name = "btnCancelNewGame";
            this.btnCancelNewGame.Size = new System.Drawing.Size(129, 32);
            this.btnCancelNewGame.TabIndex = 5;
            this.btnCancelNewGame.Text = "Cancel";
            this.btnCancelNewGame.UseVisualStyleBackColor = true;
            this.btnCancelNewGame.Click += new System.EventHandler(this.btnCancelNewGame_Click);
            // 
            // txtStockNumber
            // 
            this.txtStockNumber.Location = new System.Drawing.Point(444, 112);
            this.txtStockNumber.Name = "txtStockNumber";
            this.txtStockNumber.Size = new System.Drawing.Size(196, 26);
            this.txtStockNumber.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(444, 181);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 26);
            this.txtDescription.TabIndex = 2;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(444, 244);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(196, 26);
            this.txtRating.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(606, 96);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add New Game";
            // 
            // frmNewGame
            // 
            this.AcceptButton = this.btnSaveNewGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelNewGame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtStockNumber);
            this.Controls.Add(this.btnCancelNewGame);
            this.Controls.Add(this.btnSaveNewGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNewGame";
            this.Text = "frmNewGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveNewGame;
        private System.Windows.Forms.Button btnCancelNewGame;
        private System.Windows.Forms.TextBox txtStockNumber;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label4;
    }
}