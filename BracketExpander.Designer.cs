﻿namespace Maths_Toolkit
{
    partial class BracketExpander
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BracketExpander));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.txtconst1 = new System.Windows.Forms.RichTextBox();
            this.txtcoeff2 = new System.Windows.Forms.RichTextBox();
            this.txtcoeff1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSign1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSign2 = new System.Windows.Forms.ComboBox();
            this.txtconst2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(277, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(401, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bracket Expander";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu.Location = new System.Drawing.Point(301, 375);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(114, 63);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Back To Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnExpand.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExpand.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExpand.Location = new System.Drawing.Point(421, 365);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(187, 73);
            this.btnExpand.TabIndex = 2;
            this.btnExpand.Text = "Expand";
            this.btnExpand.UseVisualStyleBackColor = false;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // txtconst1
            // 
            this.txtconst1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtconst1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtconst1.Location = new System.Drawing.Point(390, 191);
            this.txtconst1.MaxLength = 2;
            this.txtconst1.Name = "txtconst1";
            this.txtconst1.Size = new System.Drawing.Size(48, 50);
            this.txtconst1.TabIndex = 3;
            this.txtconst1.Text = "";
            // 
            // txtcoeff2
            // 
            this.txtcoeff2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtcoeff2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcoeff2.Location = new System.Drawing.Point(522, 195);
            this.txtcoeff2.MaxLength = 1;
            this.txtcoeff2.Name = "txtcoeff2";
            this.txtcoeff2.Size = new System.Drawing.Size(48, 50);
            this.txtcoeff2.TabIndex = 4;
            this.txtcoeff2.Text = "";
            // 
            // txtcoeff1
            // 
            this.txtcoeff1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtcoeff1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcoeff1.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtcoeff1.Location = new System.Drawing.Point(203, 194);
            this.txtcoeff1.MaxLength = 1;
            this.txtcoeff1.Name = "txtcoeff1";
            this.txtcoeff1.Size = new System.Drawing.Size(48, 47);
            this.txtcoeff1.TabIndex = 5;
            this.txtcoeff1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(257, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 67);
            this.label1.TabIndex = 6;
            this.label1.Text = "x";
            // 
            // cmbSign1
            // 
            this.cmbSign1.FormattingEnabled = true;
            this.cmbSign1.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbSign1.Location = new System.Drawing.Point(316, 206);
            this.cmbSign1.Name = "cmbSign1";
            this.cmbSign1.Size = new System.Drawing.Size(59, 33);
            this.cmbSign1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(576, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 67);
            this.label2.TabIndex = 6;
            this.label2.Text = "x";
            // 
            // cmbSign2
            // 
            this.cmbSign2.FormattingEnabled = true;
            this.cmbSign2.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cmbSign2.Location = new System.Drawing.Point(634, 206);
            this.cmbSign2.Name = "cmbSign2";
            this.cmbSign2.Size = new System.Drawing.Size(59, 33);
            this.cmbSign2.TabIndex = 7;
            // 
            // txtconst2
            // 
            this.txtconst2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.txtconst2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtconst2.Location = new System.Drawing.Point(699, 195);
            this.txtconst2.MaxLength = 2;
            this.txtconst2.Name = "txtconst2";
            this.txtconst2.Size = new System.Drawing.Size(48, 50);
            this.txtconst2.TabIndex = 3;
            this.txtconst2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(145, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 70);
            this.label3.TabIndex = 8;
            this.label3.Text = "(";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(436, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 70);
            this.label4.TabIndex = 9;
            this.label4.Text = ")(";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(753, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 70);
            this.label5.TabIndex = 10;
            this.label5.Text = ")";
            // 
            // BracketExpander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtconst2);
            this.Controls.Add(this.cmbSign2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSign1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcoeff1);
            this.Controls.Add(this.txtcoeff2);
            this.Controls.Add(this.txtconst1);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BracketExpander";
            this.Text = "Bracket Expander";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.RichTextBox txtconst1;
        private System.Windows.Forms.RichTextBox txtcoeff2;
        private System.Windows.Forms.RichTextBox txtcoeff1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSign1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSign2;
        private System.Windows.Forms.RichTextBox txtconst2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}