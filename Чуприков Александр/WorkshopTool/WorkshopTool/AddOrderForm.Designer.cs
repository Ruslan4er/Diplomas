namespace WorkshopTool
{
    partial class AddOrderForm
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
            this.OrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientsComboBox = new System.Windows.Forms.ComboBox();
            this.AddNewClientСheckBox = new System.Windows.Forms.CheckBox();
            this.ClientMailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ClientAdressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClientPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientSecondNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OrderCostTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DevicePolomkaTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DeviceModelTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DeviceNumberTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DeviceTypeTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.CancelOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderDateTimePicker
            // 
            this.OrderDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateTimePicker.Location = new System.Drawing.Point(202, 329);
            this.OrderDateTimePicker.Name = "OrderDateTimePicker";
            this.OrderDateTimePicker.Size = new System.Drawing.Size(169, 26);
            this.OrderDateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(130, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добавление нового клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(89, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Клиент";
            // 
            // ClientsComboBox
            // 
            this.ClientsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientsComboBox.FormattingEnabled = true;
            this.ClientsComboBox.Location = new System.Drawing.Point(204, 94);
            this.ClientsComboBox.Name = "ClientsComboBox";
            this.ClientsComboBox.Size = new System.Drawing.Size(167, 28);
            this.ClientsComboBox.TabIndex = 7;
            this.ClientsComboBox.SelectedIndexChanged += new System.EventHandler(this.ClientsComboBox_SelectedIndexChanged);
            // 
            // AddNewClientСheckBox
            // 
            this.AddNewClientСheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewClientСheckBox.Location = new System.Drawing.Point(377, 71);
            this.AddNewClientСheckBox.Name = "AddNewClientСheckBox";
            this.AddNewClientСheckBox.Size = new System.Drawing.Size(228, 74);
            this.AddNewClientСheckBox.TabIndex = 8;
            this.AddNewClientСheckBox.Text = "Добавить нового клиента";
            this.AddNewClientСheckBox.UseVisualStyleBackColor = true;
            this.AddNewClientСheckBox.CheckedChanged += new System.EventHandler(this.AddNewClientСheckBox_CheckedChanged);
            // 
            // ClientMailTextBox
            // 
            this.ClientMailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientMailTextBox.Location = new System.Drawing.Point(202, 281);
            this.ClientMailTextBox.Name = "ClientMailTextBox";
            this.ClientMailTextBox.Size = new System.Drawing.Size(169, 26);
            this.ClientMailTextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Электронная почта";
            // 
            // ClientAdressTextBox
            // 
            this.ClientAdressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientAdressTextBox.Location = new System.Drawing.Point(202, 244);
            this.ClientAdressTextBox.Name = "ClientAdressTextBox";
            this.ClientAdressTextBox.Size = new System.Drawing.Size(169, 26);
            this.ClientAdressTextBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(96, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Адрес";
            // 
            // ClientPhoneNumberTextBox
            // 
            this.ClientPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientPhoneNumberTextBox.Location = new System.Drawing.Point(202, 206);
            this.ClientPhoneNumberTextBox.Name = "ClientPhoneNumberTextBox";
            this.ClientPhoneNumberTextBox.Size = new System.Drawing.Size(169, 26);
            this.ClientPhoneNumberTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Номер телефона";
            // 
            // ClientSecondNameTextBox
            // 
            this.ClientSecondNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientSecondNameTextBox.Location = new System.Drawing.Point(202, 170);
            this.ClientSecondNameTextBox.Name = "ClientSecondNameTextBox";
            this.ClientSecondNameTextBox.Size = new System.Drawing.Size(169, 26);
            this.ClientSecondNameTextBox.TabIndex = 15;
            this.ClientSecondNameTextBox.TextChanged += new System.EventHandler(this.ClientSecondNameTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(72, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Фамилия";
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientNameTextBox.Location = new System.Drawing.Point(202, 133);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(169, 26);
            this.ClientNameTextBox.TabIndex = 13;
            this.ClientNameTextBox.TextChanged += new System.EventHandler(this.ClientNameTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(113, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Имя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Дата получения заказа";
            // 
            // OrderDescriptionTextBox
            // 
            this.OrderDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDescriptionTextBox.Location = new System.Drawing.Point(202, 408);
            this.OrderDescriptionTextBox.Name = "OrderDescriptionTextBox";
            this.OrderDescriptionTextBox.Size = new System.Drawing.Size(169, 26);
            this.OrderDescriptionTextBox.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(70, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Описание";
            // 
            // OrderCostTextBox
            // 
            this.OrderCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderCostTextBox.Location = new System.Drawing.Point(202, 371);
            this.OrderCostTextBox.Name = "OrderCostTextBox";
            this.OrderCostTextBox.Size = new System.Drawing.Size(169, 26);
            this.OrderCostTextBox.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(70, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Стоимость";
            // 
            // DevicePolomkaTextBox
            // 
            this.DevicePolomkaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DevicePolomkaTextBox.Location = new System.Drawing.Point(202, 551);
            this.DevicePolomkaTextBox.Name = "DevicePolomkaTextBox";
            this.DevicePolomkaTextBox.Size = new System.Drawing.Size(169, 26);
            this.DevicePolomkaTextBox.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(73, 554);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Поломка";
            // 
            // DeviceModelTextBox
            // 
            this.DeviceModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceModelTextBox.Location = new System.Drawing.Point(202, 510);
            this.DeviceModelTextBox.Name = "DeviceModelTextBox";
            this.DeviceModelTextBox.Size = new System.Drawing.Size(169, 26);
            this.DeviceModelTextBox.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(70, 513);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Модель";
            // 
            // DeviceNumberTextBox
            // 
            this.DeviceNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceNumberTextBox.Location = new System.Drawing.Point(202, 477);
            this.DeviceNumberTextBox.Name = "DeviceNumberTextBox";
            this.DeviceNumberTextBox.Size = new System.Drawing.Size(169, 26);
            this.DeviceNumberTextBox.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(27, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Серийный номер";
            // 
            // DeviceTypeTextBox
            // 
            this.DeviceTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeviceTypeTextBox.Location = new System.Drawing.Point(202, 443);
            this.DeviceTypeTextBox.Name = "DeviceTypeTextBox";
            this.DeviceTypeTextBox.Size = new System.Drawing.Size(169, 26);
            this.DeviceTypeTextBox.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(28, 446);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Производитель";
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderButton.Location = new System.Drawing.Point(196, 614);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(181, 64);
            this.AddOrderButton.TabIndex = 35;
            this.AddOrderButton.Text = "Добавить";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // CancelOrderButton
            // 
            this.CancelOrderButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelOrderButton.Location = new System.Drawing.Point(406, 614);
            this.CancelOrderButton.Name = "CancelOrderButton";
            this.CancelOrderButton.Size = new System.Drawing.Size(187, 64);
            this.CancelOrderButton.TabIndex = 36;
            this.CancelOrderButton.Text = "Отмена";
            this.CancelOrderButton.UseVisualStyleBackColor = true;
            this.CancelOrderButton.Click += new System.EventHandler(this.CancelOrderButton_Click);
            // 
            // AddOrderForm
            // 
            this.AcceptButton = this.AddOrderButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.CancelOrderButton;
            this.ClientSize = new System.Drawing.Size(605, 690);
            this.Controls.Add(this.CancelOrderButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.DevicePolomkaTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DeviceModelTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DeviceNumberTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DeviceTypeTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.OrderDescriptionTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OrderCostTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ClientMailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClientAdressTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ClientPhoneNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClientSecondNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddNewClientСheckBox);
            this.Controls.Add(this.ClientsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderDateTimePicker);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker OrderDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ClientsComboBox;
        private System.Windows.Forms.CheckBox AddNewClientСheckBox;
        private System.Windows.Forms.TextBox ClientMailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ClientAdressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ClientPhoneNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClientSecondNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OrderDescriptionTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OrderCostTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DevicePolomkaTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DeviceModelTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DeviceNumberTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DeviceTypeTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button CancelOrderButton;
    }
}