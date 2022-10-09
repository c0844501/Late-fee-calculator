namespace MarketLateFeeCalculator
{
    partial class Frmnew
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
            this.newRelease = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtduedate = new System.Windows.Forms.TextBox();
            this.txtcurrentdate = new System.Windows.Forms.TextBox();
            this.txtdayslate = new System.Windows.Forms.TextBox();
            this.txtlatefee = new System.Windows.Forms.TextBox();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalGames = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newRelease
            // 
            this.newRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newRelease.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.newRelease.Enabled = false;
            this.newRelease.Font = new System.Drawing.Font("Bookman Old Style", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newRelease.Location = new System.Drawing.Point(80, 2);
            this.newRelease.Name = "newRelease";
            this.newRelease.Size = new System.Drawing.Size(664, 80);
            this.newRelease.TabIndex = 0;
            this.newRelease.Text = "New release $2 per day";
            this.newRelease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(163, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Due Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(140, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(160, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Days Late";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(165, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Late fees";
            // 
            // txtduedate
            // 
            this.txtduedate.Location = new System.Drawing.Point(281, 146);
            this.txtduedate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtduedate.Name = "txtduedate";
            this.txtduedate.Size = new System.Drawing.Size(271, 26);
            this.txtduedate.TabIndex = 1;
            // 
            // txtcurrentdate
            // 
            this.txtcurrentdate.Location = new System.Drawing.Point(281, 266);
            this.txtcurrentdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcurrentdate.Name = "txtcurrentdate";
            this.txtcurrentdate.ReadOnly = true;
            this.txtcurrentdate.Size = new System.Drawing.Size(271, 26);
            this.txtcurrentdate.TabIndex = 2;
            this.txtcurrentdate.TabStop = false;
            // 
            // txtdayslate
            // 
            this.txtdayslate.Location = new System.Drawing.Point(281, 302);
            this.txtdayslate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdayslate.Name = "txtdayslate";
            this.txtdayslate.ReadOnly = true;
            this.txtdayslate.Size = new System.Drawing.Size(271, 26);
            this.txtdayslate.TabIndex = 3;
            this.txtdayslate.TabStop = false;
            // 
            // txtlatefee
            // 
            this.txtlatefee.Location = new System.Drawing.Point(281, 341);
            this.txtlatefee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlatefee.Name = "txtlatefee";
            this.txtlatefee.ReadOnly = true;
            this.txtlatefee.Size = new System.Drawing.Size(271, 26);
            this.txtlatefee.TabIndex = 4;
            this.txtlatefee.TabStop = false;
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.Color.Green;
            this.btnreturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Location = new System.Drawing.Point(418, 391);
            this.btnreturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(114, 38);
            this.btnreturn.TabIndex = 5;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Green;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(230, 391);
            this.btncalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(124, 38);
            this.btncalculate.TabIndex = 4;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Location = new System.Drawing.Point(281, 185);
            this.txtCustomerType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(270, 26);
            this.txtCustomerType.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(125, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Customer Type";
            // 
            // txtTotalGames
            // 
            this.txtTotalGames.Location = new System.Drawing.Point(281, 225);
            this.txtTotalGames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalGames.Name = "txtTotalGames";
            this.txtTotalGames.ReadOnly = true;
            this.txtTotalGames.Size = new System.Drawing.Size(270, 26);
            this.txtTotalGames.TabIndex = 28;
            this.txtTotalGames.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(141, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Total Games";
            // 
            // Frmnew
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
            this.Controls.Add(this.newRelease);
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
            this.Name = "Frmnew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Releases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newRelease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtduedate;
        private System.Windows.Forms.TextBox txtcurrentdate;
        private System.Windows.Forms.TextBox txtdayslate;
        private System.Windows.Forms.TextBox txtlatefee;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalGames;
        private System.Windows.Forms.Label label6;
    }
}