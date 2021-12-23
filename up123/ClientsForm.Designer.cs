
namespace up123
{
    partial class ClientsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LastnameBox = new System.Windows.Forms.TextBox();
            this.PatronymicBox = new System.Windows.Forms.TextBox();
            this.BirthdayBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.ImageBTN = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(13, 13);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(79, 10);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(62, 20);
            this.IDBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(79, 48);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(176, 20);
            this.NameBox.TabIndex = 5;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // LastnameBox
            // 
            this.LastnameBox.Location = new System.Drawing.Point(79, 87);
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(176, 20);
            this.LastnameBox.TabIndex = 6;
            this.LastnameBox.TextChanged += new System.EventHandler(this.LastnameBox_TextChanged);
            // 
            // PatronymicBox
            // 
            this.PatronymicBox.Location = new System.Drawing.Point(79, 124);
            this.PatronymicBox.Name = "PatronymicBox";
            this.PatronymicBox.Size = new System.Drawing.Size(176, 20);
            this.PatronymicBox.TabIndex = 7;
            this.PatronymicBox.TextChanged += new System.EventHandler(this.PatronymicBox_TextChanged);
            // 
            // BirthdayBox
            // 
            this.BirthdayBox.Location = new System.Drawing.Point(117, 162);
            this.BirthdayBox.Name = "BirthdayBox";
            this.BirthdayBox.Size = new System.Drawing.Size(138, 20);
            this.BirthdayBox.TabIndex = 8;
            this.BirthdayBox.ValueChanged += new System.EventHandler(this.BirthdayBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(277, 51);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(32, 13);
            this.label123.TabIndex = 12;
            this.label123.Text = "Email";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(353, 48);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(176, 20);
            this.EmailBox.TabIndex = 13;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(277, 90);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Пол";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(353, 87);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(176, 20);
            this.PhoneBox.TabIndex = 16;
            this.PhoneBox.TextChanged += new System.EventHandler(this.PhoneBox_TextChanged);
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Location = new System.Drawing.Point(353, 119);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(40, 21);
            this.GenderBox.TabIndex = 17;
            this.GenderBox.SelectedValueChanged += new System.EventHandler(this.GenderBox_SelectedValueChanged);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.SaveBTN.Location = new System.Drawing.Point(16, 266);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(97, 43);
            this.SaveBTN.TabIndex = 18;
            this.SaveBTN.Text = "Сохранить";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(403, 169);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(126, 85);
            this.ImageBox.TabIndex = 19;
            this.ImageBox.TabStop = false;
            // 
            // ImageBTN
            // 
            this.ImageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            this.ImageBTN.Location = new System.Drawing.Point(403, 276);
            this.ImageBTN.Name = "ImageBTN";
            this.ImageBTN.Size = new System.Drawing.Size(126, 23);
            this.ImageBTN.TabIndex = 20;
            this.ImageBTN.Text = "Загрузить фото";
            this.ImageBTN.UseVisualStyleBackColor = false;
            this.ImageBTN.Click += new System.EventHandler(this.ImageBTN_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 322);
            this.Controls.Add(this.ImageBTN);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BirthdayBox);
            this.Controls.Add(this.PatronymicBox);
            this.Controls.Add(this.LastnameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.IDlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientsForm";
            this.Text = "Клиент";
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveBTN;
        public System.Windows.Forms.Label IDlabel;
        public System.Windows.Forms.TextBox IDBox;
        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.TextBox LastnameBox;
        public System.Windows.Forms.TextBox PatronymicBox;
        public System.Windows.Forms.DateTimePicker BirthdayBox;
        public System.Windows.Forms.TextBox EmailBox;
        public System.Windows.Forms.TextBox PhoneBox;
        public System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Button ImageBTN;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.PictureBox ImageBox;
    }
}