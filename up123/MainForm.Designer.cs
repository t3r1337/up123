
namespace up123
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GridClients = new System.Windows.Forms.DataGridView();
            this.CBRow = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PreviousBTN = new System.Windows.Forms.Button();
            this.NextBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstnameBox = new System.Windows.Forms.TextBox();
            this.LastnameBox = new System.Windows.Forms.TextBox();
            this.PatronymicBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrentCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AllCount = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TelephoneBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FilterM = new System.Windows.Forms.Button();
            this.FilterF = new System.Windows.Forms.Button();
            this.ResetBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.LastnameBTN = new System.Windows.Forms.Button();
            this.DateBTN = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.VisitsBTN = new System.Windows.Forms.Button();
            this.VisitsLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridClients)).BeginInit();
            this.SuspendLayout();
            // 
            // GridClients
            // 
            this.GridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClients.Location = new System.Drawing.Point(12, 12);
            this.GridClients.Name = "GridClients";
            this.GridClients.Size = new System.Drawing.Size(1062, 573);
            this.GridClients.TabIndex = 0;
            this.GridClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridClients_CellContentClick);
            // 
            // CBRow
            // 
            this.CBRow.FormattingEnabled = true;
            this.CBRow.Location = new System.Drawing.Point(15, 611);
            this.CBRow.Name = "CBRow";
            this.CBRow.Size = new System.Drawing.Size(170, 21);
            this.CBRow.TabIndex = 1;
            this.CBRow.SelectedIndexChanged += new System.EventHandler(this.CBRow_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество выводимых записей";
            // 
            // PreviousBTN
            // 
            this.PreviousBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.PreviousBTN.Location = new System.Drawing.Point(540, 602);
            this.PreviousBTN.Name = "PreviousBTN";
            this.PreviousBTN.Size = new System.Drawing.Size(149, 37);
            this.PreviousBTN.TabIndex = 3;
            this.PreviousBTN.Text = "Предыдущая страница";
            this.PreviousBTN.UseVisualStyleBackColor = false;
            this.PreviousBTN.Click += new System.EventHandler(this.PreviousBTN_Click);
            // 
            // NextBTN
            // 
            this.NextBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.NextBTN.Location = new System.Drawing.Point(747, 602);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Size = new System.Drawing.Size(149, 37);
            this.NextBTN.TabIndex = 4;
            this.NextBTN.Text = "Следующая страница";
            this.NextBTN.UseVisualStyleBackColor = false;
            this.NextBTN.Click += new System.EventHandler(this.NextBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1133, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Поиск по имени";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1126, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поиск по фамилии";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1127, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Поиск по отчеству";
            // 
            // FirstnameBox
            // 
            this.FirstnameBox.Location = new System.Drawing.Point(1090, 40);
            this.FirstnameBox.Name = "FirstnameBox";
            this.FirstnameBox.Size = new System.Drawing.Size(186, 20);
            this.FirstnameBox.TabIndex = 8;
            this.FirstnameBox.TextChanged += new System.EventHandler(this.FirstnameBox_TextChanged);
            // 
            // LastnameBox
            // 
            this.LastnameBox.Location = new System.Drawing.Point(1090, 108);
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(186, 20);
            this.LastnameBox.TabIndex = 9;
            this.LastnameBox.TextChanged += new System.EventHandler(this.LastnameBox_TextChanged);
            // 
            // PatronymicBox
            // 
            this.PatronymicBox.Location = new System.Drawing.Point(1090, 182);
            this.PatronymicBox.Name = "PatronymicBox";
            this.PatronymicBox.Size = new System.Drawing.Size(186, 20);
            this.PatronymicBox.TabIndex = 10;
            this.PatronymicBox.TextChanged += new System.EventHandler(this.PatronymicBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(916, 619);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Показано";
            // 
            // CurrentCount
            // 
            this.CurrentCount.AutoSize = true;
            this.CurrentCount.Location = new System.Drawing.Point(979, 619);
            this.CurrentCount.Name = "CurrentCount";
            this.CurrentCount.Size = new System.Drawing.Size(12, 13);
            this.CurrentCount.TabIndex = 12;
            this.CurrentCount.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1010, 619);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "записей из";
            // 
            // AllCount
            // 
            this.AllCount.AutoSize = true;
            this.AllCount.Location = new System.Drawing.Point(1081, 619);
            this.AllCount.Name = "AllCount";
            this.AllCount.Size = new System.Drawing.Size(12, 13);
            this.AllCount.TabIndex = 14;
            this.AllCount.Text = "y";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(1090, 263);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(186, 20);
            this.EmailBox.TabIndex = 16;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1133, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Поиск по E-mail";
            // 
            // TelephoneBox
            // 
            this.TelephoneBox.Location = new System.Drawing.Point(1090, 340);
            this.TelephoneBox.Name = "TelephoneBox";
            this.TelephoneBox.Size = new System.Drawing.Size(186, 20);
            this.TelephoneBox.TabIndex = 18;
            this.TelephoneBox.TextChanged += new System.EventHandler(this.TelephoneBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1133, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Поиск по телефон";
            // 
            // FilterM
            // 
            this.FilterM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.FilterM.Location = new System.Drawing.Point(1129, 377);
            this.FilterM.Name = "FilterM";
            this.FilterM.Size = new System.Drawing.Size(28, 23);
            this.FilterM.TabIndex = 19;
            this.FilterM.Text = "М";
            this.FilterM.UseVisualStyleBackColor = false;
            this.FilterM.Click += new System.EventHandler(this.FilterM_Click);
            // 
            // FilterF
            // 
            this.FilterF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.FilterF.Location = new System.Drawing.Point(1205, 377);
            this.FilterF.Name = "FilterF";
            this.FilterF.Size = new System.Drawing.Size(28, 23);
            this.FilterF.TabIndex = 20;
            this.FilterF.Text = "Ж";
            this.FilterF.UseVisualStyleBackColor = false;
            this.FilterF.Click += new System.EventHandler(this.FilterF_Click);
            // 
            // ResetBTN
            // 
            this.ResetBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.ResetBTN.Location = new System.Drawing.Point(1142, 509);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.Size = new System.Drawing.Size(75, 23);
            this.ResetBTN.TabIndex = 21;
            this.ResetBTN.Text = "СБРОС";
            this.ResetBTN.UseVisualStyleBackColor = false;
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1136, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Сортировка по";
            // 
            // LastnameBTN
            // 
            this.LastnameBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.LastnameBTN.Location = new System.Drawing.Point(1090, 444);
            this.LastnameBTN.Name = "LastnameBTN";
            this.LastnameBTN.Size = new System.Drawing.Size(75, 38);
            this.LastnameBTN.TabIndex = 23;
            this.LastnameBTN.Text = "Фамилии";
            this.LastnameBTN.UseVisualStyleBackColor = false;
            this.LastnameBTN.Click += new System.EventHandler(this.LastnameBTN_Click);
            // 
            // DateBTN
            // 
            this.DateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.DateBTN.Location = new System.Drawing.Point(1201, 444);
            this.DateBTN.Name = "DateBTN";
            this.DateBTN.Size = new System.Drawing.Size(75, 38);
            this.DateBTN.TabIndex = 24;
            this.DateBTN.Text = "Дате посещения";
            this.DateBTN.UseVisualStyleBackColor = false;
            this.DateBTN.Click += new System.EventHandler(this.DateBTN_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.AddButton.Location = new System.Drawing.Point(1090, 549);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 36);
            this.AddButton.TabIndex = 25;
            this.AddButton.Text = "Добавить клиента";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.EditButton.Location = new System.Drawing.Point(1192, 549);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(94, 36);
            this.EditButton.TabIndex = 26;
            this.EditButton.Text = "Редактировать клиента";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.DeleteButton.Location = new System.Drawing.Point(1139, 596);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 36);
            this.DeleteButton.TabIndex = 27;
            this.DeleteButton.Text = "Удалить клиента";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // VisitsBTN
            // 
            this.VisitsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.VisitsBTN.Location = new System.Drawing.Point(202, 602);
            this.VisitsBTN.Name = "VisitsBTN";
            this.VisitsBTN.Size = new System.Drawing.Size(149, 37);
            this.VisitsBTN.TabIndex = 28;
            this.VisitsBTN.Text = "Посещения";
            this.VisitsBTN.UseVisualStyleBackColor = false;
            this.VisitsBTN.Click += new System.EventHandler(this.VisitsBTN_Click);
            // 
            // VisitsLabel
            // 
            this.VisitsLabel.AutoSize = true;
            this.VisitsLabel.Location = new System.Drawing.Point(485, 614);
            this.VisitsLabel.Name = "VisitsLabel";
            this.VisitsLabel.Size = new System.Drawing.Size(12, 13);
            this.VisitsLabel.TabIndex = 29;
            this.VisitsLabel.Text = "x";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 614);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Количество посещений:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1298, 651);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VisitsLabel);
            this.Controls.Add(this.VisitsBTN);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DateBTN);
            this.Controls.Add(this.LastnameBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.FilterF);
            this.Controls.Add(this.FilterM);
            this.Controls.Add(this.TelephoneBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AllCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CurrentCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PatronymicBox);
            this.Controls.Add(this.LastnameBox);
            this.Controls.Add(this.FirstnameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextBTN);
            this.Controls.Add(this.PreviousBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBRow);
            this.Controls.Add(this.GridClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.GridClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridClients;
        private System.Windows.Forms.ComboBox CBRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PreviousBTN;
        private System.Windows.Forms.Button NextBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstnameBox;
        private System.Windows.Forms.TextBox LastnameBox;
        private System.Windows.Forms.TextBox PatronymicBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CurrentCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AllCount;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TelephoneBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button FilterM;
        private System.Windows.Forms.Button FilterF;
        private System.Windows.Forms.Button ResetBTN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button LastnameBTN;
        private System.Windows.Forms.Button DateBTN;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button VisitsBTN;
        private System.Windows.Forms.Label VisitsLabel;
        private System.Windows.Forms.Label label10;
    }
}

