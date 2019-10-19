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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите ID книги, которую хотите удалить";
            // 
            // IDChooseCB
            // 
            this.IDChooseCB.FormattingEnabled = true;
            this.IDChooseCB.Location = new System.Drawing.Point(12, 25);
            this.IDChooseCB.Name = "IDChooseCB";
            this.IDChooseCB.Size = new System.Drawing.Size(121, 21);
            this.IDChooseCB.TabIndex = 1;
            // 
            // Apply
            // 
            this.Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Apply.Location = new System.Drawing.Point(213, 61);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(84, 23);
            this.Apply.TabIndex = 2;
            this.Apply.Text = "Подтвердить";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // ChooseIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 96);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.IDChooseCB);
            this.Controls.Add(this.label1);
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