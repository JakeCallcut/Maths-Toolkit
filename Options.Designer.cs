namespace Maths_Toolkit
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.label1 = new System.Windows.Forms.Label();
            this.grpTheme = new System.Windows.Forms.GroupBox();
            this.rdbDark = new System.Windows.Forms.RadioButton();
            this.rdbLight = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Options";
            // 
            // grpTheme
            // 
            this.grpTheme.Controls.Add(this.rdbDark);
            this.grpTheme.Controls.Add(this.rdbLight);
            this.grpTheme.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpTheme.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpTheme.Location = new System.Drawing.Point(12, 84);
            this.grpTheme.Name = "grpTheme";
            this.grpTheme.Size = new System.Drawing.Size(145, 129);
            this.grpTheme.TabIndex = 1;
            this.grpTheme.TabStop = false;
            this.grpTheme.Text = "Theme";
            this.grpTheme.Enter += new System.EventHandler(this.grpTheme_Enter);
            // 
            // rdbDark
            // 
            this.rdbDark.AutoSize = true;
            this.rdbDark.Location = new System.Drawing.Point(21, 76);
            this.rdbDark.Name = "rdbDark";
            this.rdbDark.Size = new System.Drawing.Size(91, 34);
            this.rdbDark.TabIndex = 1;
            this.rdbDark.TabStop = true;
            this.rdbDark.Text = "Dark";
            this.rdbDark.UseVisualStyleBackColor = true;
            // 
            // rdbLight
            // 
            this.rdbLight.AutoSize = true;
            this.rdbLight.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdbLight.Location = new System.Drawing.Point(21, 36);
            this.rdbLight.Name = "rdbLight";
            this.rdbLight.Size = new System.Drawing.Size(94, 34);
            this.rdbLight.TabIndex = 0;
            this.rdbLight.TabStop = true;
            this.rdbLight.Text = "Light";
            this.rdbLight.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(169, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBack.Location = new System.Drawing.Point(12, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(443, 431);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpTheme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.grpTheme.ResumeLayout(false);
            this.grpTheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTheme;
        private System.Windows.Forms.RadioButton rdbDark;
        private System.Windows.Forms.RadioButton rdbLight;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}