namespace WindowsFormsApp1
{
    partial class User
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
            this.Exit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewWarehouse = new System.Windows.Forms.DataGridView();
            this.CheckLess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportContent = new System.Windows.Forms.TextBox();
            this.Report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(755, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 25);
            this.Exit.TabIndex = 27;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.BlueViolet;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(50, 327);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(189, 55);
            this.Search.TabIndex = 43;
            this.Search.Text = "Проверить товары";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 48);
            this.label1.TabIndex = 42;
            this.label1.Text = "Складской учёт";
            // 
            // dataGridViewWarehouse
            // 
            this.dataGridViewWarehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouse.Location = new System.Drawing.Point(27, 63);
            this.dataGridViewWarehouse.Name = "dataGridViewWarehouse";
            this.dataGridViewWarehouse.Size = new System.Drawing.Size(750, 257);
            this.dataGridViewWarehouse.TabIndex = 41;
            // 
            // CheckLess
            // 
            this.CheckLess.BackColor = System.Drawing.Color.BlueViolet;
            this.CheckLess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckLess.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckLess.FlatAppearance.BorderSize = 0;
            this.CheckLess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckLess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckLess.ForeColor = System.Drawing.Color.White;
            this.CheckLess.Location = new System.Drawing.Point(559, 327);
            this.CheckLess.Margin = new System.Windows.Forms.Padding(4);
            this.CheckLess.Name = "CheckLess";
            this.CheckLess.Size = new System.Drawing.Size(189, 55);
            this.CheckLess.TabIndex = 48;
            this.CheckLess.Text = "Показать недостающие товары";
            this.CheckLess.UseVisualStyleBackColor = false;
            this.CheckLess.Click += new System.EventHandler(this.CheckLess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(214, 396);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Сообщить о малом количестве товара:";
            // 
            // ReportContent
            // 
            this.ReportContent.BackColor = System.Drawing.Color.Silver;
            this.ReportContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportContent.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReportContent.ForeColor = System.Drawing.Color.Black;
            this.ReportContent.Location = new System.Drawing.Point(249, 429);
            this.ReportContent.Margin = new System.Windows.Forms.Padding(4);
            this.ReportContent.Name = "ReportContent";
            this.ReportContent.Size = new System.Drawing.Size(295, 24);
            this.ReportContent.TabIndex = 50;
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.BlueViolet;
            this.Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Report.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Report.FlatAppearance.BorderSize = 0;
            this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Report.ForeColor = System.Drawing.Color.GhostWhite;
            this.Report.Location = new System.Drawing.Point(249, 461);
            this.Report.Margin = new System.Windows.Forms.Padding(4);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(295, 35);
            this.Report.TabIndex = 51;
            this.Report.Text = "Сообщить";
            this.Report.UseVisualStyleBackColor = false;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.ReportContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckLess);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewWarehouse);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewWarehouse;
        private System.Windows.Forms.Button CheckLess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReportContent;
        private System.Windows.Forms.Button Report;
    }
}