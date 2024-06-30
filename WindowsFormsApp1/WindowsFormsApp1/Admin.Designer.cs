namespace WindowsFormsApp1
{
    partial class Admin
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KolvoItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditItem = new System.Windows.Forms.Button();
            this.CreateData = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.CheckReports = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.IdReport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(842, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 25);
            this.Exit.TabIndex = 27;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(78, 63);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(387, 260);
            this.dataGridViewEmployees.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 48);
            this.label1.TabIndex = 32;
            this.label1.Text = "Администрация";
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
            this.Search.Location = new System.Drawing.Point(78, 330);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(387, 35);
            this.Search.TabIndex = 39;
            this.Search.Text = "Проверить";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(72, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Добавить поступление товара:";
            // 
            // NameItem
            // 
            this.NameItem.BackColor = System.Drawing.Color.Silver;
            this.NameItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameItem.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameItem.ForeColor = System.Drawing.Color.Black;
            this.NameItem.Location = new System.Drawing.Point(78, 446);
            this.NameItem.Margin = new System.Windows.Forms.Padding(4);
            this.NameItem.Name = "NameItem";
            this.NameItem.Size = new System.Drawing.Size(295, 24);
            this.NameItem.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(73, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "Наименование";
            // 
            // KolvoItem
            // 
            this.KolvoItem.BackColor = System.Drawing.Color.Silver;
            this.KolvoItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KolvoItem.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KolvoItem.ForeColor = System.Drawing.Color.Black;
            this.KolvoItem.Location = new System.Drawing.Point(533, 446);
            this.KolvoItem.Margin = new System.Windows.Forms.Padding(4);
            this.KolvoItem.Name = "KolvoItem";
            this.KolvoItem.Size = new System.Drawing.Size(295, 24);
            this.KolvoItem.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(528, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 47;
            this.label4.Text = "Количество";
            // 
            // EditItem
            // 
            this.EditItem.BackColor = System.Drawing.Color.BlueViolet;
            this.EditItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EditItem.FlatAppearance.BorderSize = 0;
            this.EditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditItem.ForeColor = System.Drawing.Color.White;
            this.EditItem.Location = new System.Drawing.Point(643, 478);
            this.EditItem.Margin = new System.Windows.Forms.Padding(4);
            this.EditItem.Name = "EditItem";
            this.EditItem.Size = new System.Drawing.Size(185, 35);
            this.EditItem.TabIndex = 48;
            this.EditItem.Text = "Редактировать";
            this.EditItem.UseVisualStyleBackColor = false;
            this.EditItem.Click += new System.EventHandler(this.EditItem_Click);
            // 
            // CreateData
            // 
            this.CreateData.BackColor = System.Drawing.Color.BlueViolet;
            this.CreateData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateData.FlatAppearance.BorderSize = 0;
            this.CreateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateData.ForeColor = System.Drawing.Color.White;
            this.CreateData.Location = new System.Drawing.Point(364, 478);
            this.CreateData.Margin = new System.Windows.Forms.Padding(4);
            this.CreateData.Name = "CreateData";
            this.CreateData.Size = new System.Drawing.Size(185, 35);
            this.CreateData.TabIndex = 49;
            this.CreateData.Text = "Создать отчёт";
            this.CreateData.UseVisualStyleBackColor = false;
            this.CreateData.Click += new System.EventHandler(this.CreateData_Click);
            // 
            // AddItem
            // 
            this.AddItem.BackColor = System.Drawing.Color.BlueViolet;
            this.AddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddItem.FlatAppearance.BorderSize = 0;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddItem.ForeColor = System.Drawing.Color.White;
            this.AddItem.Location = new System.Drawing.Point(77, 478);
            this.AddItem.Margin = new System.Windows.Forms.Padding(4);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(185, 35);
            this.AddItem.TabIndex = 50;
            this.AddItem.Text = "Добавить";
            this.AddItem.UseVisualStyleBackColor = false;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(488, 63);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(340, 201);
            this.dataGridViewReport.TabIndex = 51;
            // 
            // CheckReports
            // 
            this.CheckReports.BackColor = System.Drawing.Color.BlueViolet;
            this.CheckReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckReports.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CheckReports.FlatAppearance.BorderSize = 0;
            this.CheckReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckReports.ForeColor = System.Drawing.Color.White;
            this.CheckReports.Location = new System.Drawing.Point(505, 330);
            this.CheckReports.Margin = new System.Windows.Forms.Padding(4);
            this.CheckReports.Name = "CheckReports";
            this.CheckReports.Size = new System.Drawing.Size(145, 35);
            this.CheckReports.TabIndex = 52;
            this.CheckReports.Text = "Поиск";
            this.CheckReports.UseVisualStyleBackColor = false;
            this.CheckReports.Click += new System.EventHandler(this.CheckReports_Click);
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.BlueViolet;
            this.Done.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Done.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Done.FlatAppearance.BorderSize = 0;
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Done.ForeColor = System.Drawing.Color.White;
            this.Done.Location = new System.Drawing.Point(658, 330);
            this.Done.Margin = new System.Windows.Forms.Padding(4);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(145, 35);
            this.Done.TabIndex = 53;
            this.Done.Text = "Выполнено";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // IdReport
            // 
            this.IdReport.BackColor = System.Drawing.Color.Silver;
            this.IdReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdReport.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdReport.ForeColor = System.Drawing.Color.Black;
            this.IdReport.Location = new System.Drawing.Point(505, 299);
            this.IdReport.Margin = new System.Windows.Forms.Padding(4);
            this.IdReport.Name = "IdReport";
            this.IdReport.Size = new System.Drawing.Size(298, 24);
            this.IdReport.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(503, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 55;
            this.label5.Text = "ID заявки";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 552);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IdReport);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.CheckReports);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.CreateData);
            this.Controls.Add(this.EditItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KolvoItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KolvoItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditItem;
        private System.Windows.Forms.Button CreateData;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Button CheckReports;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.TextBox IdReport;
        private System.Windows.Forms.Label label5;
    }
}