namespace TechnologicalEquipApp.Authorization
{
    partial class AuthorizationForm
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.OpenRegistrationFormButton = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(83, 79);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(138, 26);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(338, 79);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(149, 26);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(268, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пароль";
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationButton.Location = new System.Drawing.Point(9, 136);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(151, 48);
            this.AuthorizationButton.TabIndex = 2;
            this.AuthorizationButton.TabStop = false;
            this.AuthorizationButton.Text = "Войти";
            this.AuthorizationButton.UseVisualStyleBackColor = true;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // OpenRegistrationFormButton
            // 
            this.OpenRegistrationFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenRegistrationFormButton.Location = new System.Drawing.Point(178, 136);
            this.OpenRegistrationFormButton.Name = "OpenRegistrationFormButton";
            this.OpenRegistrationFormButton.Size = new System.Drawing.Size(151, 48);
            this.OpenRegistrationFormButton.TabIndex = 4;
            this.OpenRegistrationFormButton.TabStop = false;
            this.OpenRegistrationFormButton.Text = "Регистрация";
            this.OpenRegistrationFormButton.UseVisualStyleBackColor = true;
            this.OpenRegistrationFormButton.Click += new System.EventHandler(this.OpenRegistrationFormButton_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseFormButton.Location = new System.Drawing.Point(383, 136);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(151, 48);
            this.CloseFormButton.TabIndex = 5;
            this.CloseFormButton.TabStop = false;
            this.CloseFormButton.Text = "Выход";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(177, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Авторизация";
            // 
            // AuthorizationForm
            // 
            this.AcceptButton = this.AuthorizationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 197);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.OpenRegistrationFormButton);
            this.Controls.Add(this.AuthorizationButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "AuthorizationForm";
            this.Text = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.Button OpenRegistrationFormButton;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}