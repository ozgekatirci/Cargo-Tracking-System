
namespace KargoTakip
{
    partial class UserCargoSend
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCargoSend = new System.Windows.Forms.Button();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDeliveryType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGonderilenIl = new System.Windows.Forms.ComboBox();
            this.comboBoxAlinanIl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTrackNo = new System.Windows.Forms.Label();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReceiver = new System.Windows.Forms.TextBox();
            this.comboBoxCargoType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Gönderilecek Tarih";
            // 
            // buttonCargoSend
            // 
            this.buttonCargoSend.Location = new System.Drawing.Point(524, 128);
            this.buttonCargoSend.Name = "buttonCargoSend";
            this.buttonCargoSend.Size = new System.Drawing.Size(117, 35);
            this.buttonCargoSend.TabIndex = 19;
            this.buttonCargoSend.Text = "Kargo Yolla";
            this.buttonCargoSend.UseVisualStyleBackColor = true;
            this.buttonCargoSend.Click += new System.EventHandler(this.buttonCargoSend_Click);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(158, 217);
            this.textBoxAdress.Multiline = true;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(184, 75);
            this.textBoxAdress.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alıcı Adres";
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Items.AddRange(new object[] {
            "Gönderici",
            "Alıcı"});
            this.comboBoxPaymentType.Location = new System.Drawing.Point(158, 114);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(184, 24);
            this.comboBoxPaymentType.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ödeme Tipi";
            // 
            // comboBoxDeliveryType
            // 
            this.comboBoxDeliveryType.FormattingEnabled = true;
            this.comboBoxDeliveryType.Items.AddRange(new object[] {
            "Şubeye Teslim",
            "Adrese Teslim"});
            this.comboBoxDeliveryType.Location = new System.Drawing.Point(158, 71);
            this.comboBoxDeliveryType.Name = "comboBoxDeliveryType";
            this.comboBoxDeliveryType.Size = new System.Drawing.Size(184, 24);
            this.comboBoxDeliveryType.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Teslim Tipi";
            // 
            // comboBoxGonderilenIl
            // 
            this.comboBoxGonderilenIl.FormattingEnabled = true;
            this.comboBoxGonderilenIl.Items.AddRange(new object[] {
            "Ankara",
            "Denizli",
            "Eskişehir",
            "Malatya"});
            this.comboBoxGonderilenIl.Location = new System.Drawing.Point(158, 312);
            this.comboBoxGonderilenIl.Name = "comboBoxGonderilenIl";
            this.comboBoxGonderilenIl.Size = new System.Drawing.Size(184, 24);
            this.comboBoxGonderilenIl.TabIndex = 22;
            // 
            // comboBoxAlinanIl
            // 
            this.comboBoxAlinanIl.FormattingEnabled = true;
            this.comboBoxAlinanIl.Items.AddRange(new object[] {
            "Ankara",
            "Denizli",
            "Eskişehir",
            "Malatya"});
            this.comboBoxAlinanIl.Location = new System.Drawing.Point(158, 364);
            this.comboBoxAlinanIl.Name = "comboBoxAlinanIl";
            this.comboBoxAlinanIl.Size = new System.Drawing.Size(184, 24);
            this.comboBoxAlinanIl.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Gönderilen İl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Alınacak İl";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Kargo Takip Numarası";
            // 
            // labelTrackNo
            // 
            this.labelTrackNo.AutoSize = true;
            this.labelTrackNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTrackNo.Location = new System.Drawing.Point(432, 416);
            this.labelTrackNo.Name = "labelTrackNo";
            this.labelTrackNo.Size = new System.Drawing.Size(0, 20);
            this.labelTrackNo.TabIndex = 28;
            // 
            // buttonPrice
            // 
            this.buttonPrice.Location = new System.Drawing.Point(522, 55);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(119, 36);
            this.buttonPrice.TabIndex = 29;
            this.buttonPrice.Text = "Fiyat Hesapla";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Alıcı";
            // 
            // textBoxReceiver
            // 
            this.textBoxReceiver.Location = new System.Drawing.Point(158, 170);
            this.textBoxReceiver.Name = "textBoxReceiver";
            this.textBoxReceiver.Size = new System.Drawing.Size(172, 22);
            this.textBoxReceiver.TabIndex = 31;
            // 
            // comboBoxCargoType
            // 
            this.comboBoxCargoType.FormattingEnabled = true;
            this.comboBoxCargoType.Items.AddRange(new object[] {
            "Zarf",
            "Paket"});
            this.comboBoxCargoType.Location = new System.Drawing.Point(158, 420);
            this.comboBoxCargoType.Name = "comboBoxCargoType";
            this.comboBoxCargoType.Size = new System.Drawing.Size(184, 24);
            this.comboBoxCargoType.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Kargo Tipi";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(158, 482);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(184, 22);
            this.textBoxWeight.TabIndex = 35;
            this.textBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWeight_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 34;
            this.label10.Text = "Ağırlık(kg)";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(672, 69);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 17);
            this.labelPrice.TabIndex = 36;
            // 
            // UserCargoSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxCargoType);
            this.Controls.Add(this.textBoxReceiver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.labelTrackNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxAlinanIl);
            this.Controls.Add(this.comboBoxGonderilenIl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCargoSend);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPaymentType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDeliveryType);
            this.Controls.Add(this.label1);
            this.Name = "UserCargoSend";
            this.Text = "UserCargoSend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCargoSend;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDeliveryType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGonderilenIl;
        private System.Windows.Forms.ComboBox comboBoxAlinanIl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTrackNo;
        private System.Windows.Forms.Button buttonPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxReceiver;
        private System.Windows.Forms.ComboBox comboBoxCargoType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelPrice;
    }
}