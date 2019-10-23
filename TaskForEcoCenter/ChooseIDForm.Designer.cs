namespace TaskForEcoCenter
{
    partial class ChooseIDForm
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
            this.IDChooseCB = new System.Windows.Forms.ComboBox();
            this.Apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите номер книги, которую хотите удалить";
            // 
            // IDChooseCB
            // 
            this.IDChooseCB.FormattingEnabled = true;
            this.IDChooseCB.Location = new System.Drawing.Point(16, 31);
            this.IDChooseCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDChooseCB.Name = "IDChooseCB";
            this.IDChooseCB.Size = new System.Drawing.Size(160, 24);
            this.IDChooseCB.TabIndex = 1;
            // 
            // Apply
            // 
            this.Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Apply.Location = new System.Drawing.Point(284, 75);
            this.Apply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(112, 28);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "Подтвердить";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // ChooseIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 118);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.IDChooseCB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChooseIDForm";
            this.Text = "ChooseIDForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IDChooseCB;
        private System.Windows.Forms.Button Apply;
    }
}