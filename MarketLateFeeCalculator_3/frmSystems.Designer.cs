namespace MarketLateFeeCalculator
{
    partial class frmSystems
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
            this.gameSystem = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.txtlatefee = new System.Windows.Forms.TextBox();
            this.txtdayslate = new System.Windows.Forms.TextBox();
            this.txtcurrentdate = new System.Windows.Forms.TextBox();
            this.txtduedate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalGames = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameSystem
            // 
            this.gameSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameSystem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameSystem.Enabled = false;
            this.gameSystem.Font = new System.Drawing.Font("Bookman Old Style", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameSystem.Location = new System.Drawing.Point(36, 14);
            this.gameSystem.Name = "gameSystem";
            this.gameSystem.Size = new System.Drawing.Size(717, 68);
            this.gameSystem.TabIndex = 5;
            this.gameSystem.Text = "Game System $5 per day";
            this.gameSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Green;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(242, 408);
            this.btncalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(128, 38);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.Green;
            this.btnreturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Location = new System.Drawing.Point(430, 408);
            this.btnreturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(120, 38);
            this.btnreturn.TabIndex = 5;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // txtlatefee
            // 
            this.txtlatefee.Location = new System.Drawing.Point(280, 358);
            this.txtlatefee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlatefee.Name = "txtlatefee";
            this.txtlatefee.ReadOnly = true;
            this.txtlatefee.Size = new System.Drawing.Size(271, 26);
            this.txtlatefee.TabIndex = 14;
            this.txtlatefee.TabStop = false;
            // 
            // txtdayslate
            // 
            this.txtdayslate.Location = new System.Drawing.Point(280, 309);
            this.txtdayslate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdayslate.Name = "txtdayslate";
            this.txtdayslate.ReadOnly = true;
            this.txtdayslate.Size = new System.Drawing.Size(271, 26);
            this.txtdayslate.TabIndex = 11;
            this.txtdayslate.TabStop = false;
            // 
            // txtcurrentdate
            // 
            this.txtcurrentdate.Location = new System.Drawing.Point(280, 262);
            this.txtcurrentdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcurrentdate.Name = "txtcurrentdate";
            this.txtcurrentdate.ReadOnly = true;
            this.txtcurrentdate.Size = new System.Drawing.Size(271, 26);
            this.txtcurrentdate.TabIndex = 1;
            this.txtcurrentdate.TabStop = false;
            // 
            // txtduedate
            // 
            this.txtduedate.Location = new System.Drawing.Point(281, 138);
            this.txtduedate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtduedate.Name = "txtduedate";
            this.txtduedate.Size = new System.Drawing.Size(271, 26);
            this.txtduedate.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(165, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Late fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(159, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Days Late";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(141, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(163, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Due Date";
            // 
            // txtTotalGames
            // 
            this.txtTotalGames.Location = new System.Drawing.Point(280, 220);
            this.txtTotalGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalGames.Name = "txtTotalGames";
            this.txtTotalGames.ReadOnly = true;
            this.txtTotalGames.Size = new System.Drawing.Size(270, 26);
            this.txtTotalGames.TabIndex = 21;
            this.txtTotalGames.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(141, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total Games";
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Location = new System.Drawing.Point(280, 180);
            this.txtCustomerType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(270, 26);
            this.txtCustomerType.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(124, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Customer Type";
            // 
            // frmSystems
            // 
            this.AcceptButton = this.btncalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnreturn;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.txtCustomerType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalGames);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gameSystem);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.txtlatefee);
            this.Controls.Add(this.txtdayslate);
            this.Controls.Add(this.txtcurrentdate);
            this.Controls.Add(this.txtduedate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSystems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Systems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameSystem;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.TextBox txtlatefee;
        private System.Windows.Forms.TextBox txtdayslate;
        private System.Windows.Forms.TextBox txtcurrentdate;
        private System.Windows.Forms.TextBox txtduedate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalGames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.Label label7;
    }
}