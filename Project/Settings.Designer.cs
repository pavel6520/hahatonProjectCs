namespace Project
{
    partial class SettingsForm
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
            this.TBip = new System.Windows.Forms.TextBox();
            this.TBdatabase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBip
            // 
            this.TBip.Location = new System.Drawing.Point(108, 44);
            this.TBip.Name = "TBip";
            this.TBip.Size = new System.Drawing.Size(96, 20);
            this.TBip.TabIndex = 0;
            // 
            // TBdatabase
            // 
            this.TBdatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.TBdatabase.Location = new System.Drawing.Point(108, 79);
            this.TBdatabase.Name = "TBdatabase";
            this.TBdatabase.Size = new System.Drawing.Size(96, 20);
            this.TBdatabase.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP-адрес сервера:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя базы данных:";
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(91, 118);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 23);
            this.BSave.TabIndex = 4;
            this.BSave.Text = "Сохранить";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 180);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBdatabase);
            this.Controls.Add(this.TBip);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBip;
        private System.Windows.Forms.TextBox TBdatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BSave;
    }
}