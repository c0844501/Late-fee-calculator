using System;

namespace MarketLateFeeCalculator
{
    partial class frmmain
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
            this.btnNewReleases = new System.Windows.Forms.Button();
            this.btnlibrary = new System.Windows.Forms.Button();
            this.btnsystem = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnAddNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Enabled = false;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sonu\'s Late Fee Calculator";
            // 
            // btnNewReleases
            // 
            this.btnNewReleases.BackColor = System.Drawing.Color.Teal;
            this.btnNewReleases.Location = new System.Drawing.Point(86, 148);
            this.btnNewReleases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewReleases.Name = "btnNewReleases";
            this.btnNewReleases.Size = new System.Drawing.Size(170, 59);
            this.btnNewReleases.TabIndex = 1;
            this.btnNewReleases.Text = "New Release";
            this.btnNewReleases.UseVisualStyleBackColor = false;
            this.btnNewReleases.Click += new System.EventHandler(this.btnNewReleases_Click);
            // 
            // btnlibrary
            // 
            this.btnlibrary.BackColor = System.Drawing.Color.Teal;
            this.btnlibrary.Location = new System.Drawing.Point(351, 148);
            this.btnlibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlibrary.Name = "btnlibrary";
            this.btnlibrary.Size = new System.Drawing.Size(153, 59);
            this.btnlibrary.TabIndex = 2;
            this.btnlibrary.Text = "Library Games";
            this.btnlibrary.UseVisualStyleBackColor = false;
            this.btnlibrary.Click += new System.EventHandler(this.btnlibrary_Click);
            // 
            // btnsystem
            // 
            this.btnsystem.BackColor = System.Drawing.Color.Teal;
            this.btnsystem.Location = new System.Drawing.Point(586, 148);
            this.btnsystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsystem.Name = "btnsystem";
            this.btnsystem.Size = new System.Drawing.Size(145, 59);
            this.btnsystem.TabIndex = 3;
            this.btnsystem.Text = "Game Systems";
            this.btnsystem.UseVisualStyleBackColor = false;
            this.btnsystem.Click += new System.EventHandler(this.btnsystem_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Maroon;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Location = new System.Drawing.Point(578, 258);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(153, 49);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(239, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Late Fees";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTotal.Location = new System.Drawing.Point(444, 365);
            this.labelTotal.MaximumSize = new System.Drawing.Size(50, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(40, 20);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "0.00";
            // 
            // btnAddNewGame
            // 
            this.btnAddNewGame.BackColor = System.Drawing.Color.Teal;
            this.btnAddNewGame.Location = new System.Drawing.Point(219, 268);
            this.btnAddNewGame.Name = "btnAddNewGame";
            this.btnAddNewGame.Size = new System.Drawing.Size(140, 39);
            this.btnAddNewGame.TabIndex = 7;
            this.btnAddNewGame.Text = "Add New Game";
            this.btnAddNewGame.UseVisualStyleBackColor = false;
            this.btnAddNewGame.Click += new System.EventHandler(this.btnAddNewGame_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnAddNewGame);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsystem);
            this.Controls.Add(this.btnlibrary);
            this.Controls.Add(this.btnNewReleases);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mark\'s Late Fee Calculator";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlibrary;
        private System.Windows.Forms.Button btnsystem;
        private System.Windows.Forms.Button btnexit;
        protected internal System.Windows.Forms.Button btnNewReleases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnAddNewGame;
    }
}

