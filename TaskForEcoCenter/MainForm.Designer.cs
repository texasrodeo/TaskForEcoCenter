namespace TaskForEcoCenter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainDGV = new System.Windows.Forms.DataGridView();
            this.OpenXMLButton = new System.Windows.Forms.Button();
            this.SaveXMLButton = new System.Windows.Forms.Button();
            this.HTMLReport = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDGV
            // 
            this.MainDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDGV.Location = new System.Drawing.Point(12, 41);
            this.MainDGV.Name = "MainDGV";
            this.MainDGV.Size = new System.Drawing.Size(507, 150);
            this.MainDGV.TabIndex = 0;
            // 
            // OpenXMLButton
            // 
            this.OpenXMLButton.Location = new System.Drawing.Point(12, 12);
            this.OpenXMLButton.Name = "OpenXMLButton";
            this.OpenXMLButton.Size = new System.Drawing.Size(108, 23);
            this.OpenXMLButton.TabIndex = 1;
            this.OpenXMLButton.Text = "Открыть XML";
            this.OpenXMLButton.UseVisualStyleBackColor = true;
            this.OpenXMLButton.Click += new System.EventHandler(this.OpenXMLButton_Click);
            // 
            // SaveXMLButton
            // 
            this.SaveXMLButton.Location = new System.Drawing.Point(126, 12);
            this.SaveXMLButton.Name = "SaveXMLButton";
            this.SaveXMLButton.Size = new System.Drawing.Size(110, 23);
            this.SaveXMLButton.TabIndex = 2;
            this.SaveXMLButton.Text = "Сохранить XML";
            this.SaveXMLButton.UseVisualStyleBackColor = true;
            this.SaveXMLButton.Click += new System.EventHandler(this.SaveXMLButton_Click);
            // 
            // HTMLReport
            // 
            this.HTMLReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HTMLReport.Location = new System.Drawing.Point(299, 12);
            this.HTMLReport.Name = "HTMLReport";
            this.HTMLReport.Size = new System.Drawing.Size(220, 23);
            this.HTMLReport.TabIndex = 3;
            this.HTMLReport.Text = "Отчет о текущем состоянии в HTML";
            this.HTMLReport.UseVisualStyleBackColor = true;
            this.HTMLReport.Click += new System.EventHandler(this.HTMLReport_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteRecordButton.Location = new System.Drawing.Point(12, 197);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(128, 23);
            this.DeleteRecordButton.TabIndex = 4;
            this.DeleteRecordButton.Text = "Удалить книгу по ID";
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddRecordButton.Location = new System.Drawing.Point(161, 197);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(106, 23);
            this.AddRecordButton.TabIndex = 5;
            this.AddRecordButton.Text = "Добавить книгу";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 230);
            this.Controls.Add(this.AddRecordButton);
            this.Controls.Add(this.DeleteRecordButton);
            this.Controls.Add(this.HTMLReport);
            this.Controls.Add(this.SaveXMLButton);
            this.Controls.Add(this.OpenXMLButton);
            this.Controls.Add(this.MainDGV);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.MainDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MainDGV;
        private System.Windows.Forms.Button OpenXMLButton;
        private System.Windows.Forms.Button SaveXMLButton;
        private System.Windows.Forms.Button HTMLReport;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.Button AddRecordButton;
    }
}

