namespace TechnologicalEquipApp
{
    partial class MainMenuForm
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
            this.OpenTestsFormButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenTheoryFormButton = new System.Windows.Forms.Button();
            this.OpenUserProfileForm = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenTestsFormButton
            // 
            this.OpenTestsFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenTestsFormButton.Image = global::TechnologicalEquipApp.Properties.Resources.тесты;
            this.OpenTestsFormButton.Location = new System.Drawing.Point(202, 100);
            this.OpenTestsFormButton.Name = "OpenTestsFormButton";
            this.OpenTestsFormButton.Size = new System.Drawing.Size(167, 188);
            this.OpenTestsFormButton.TabIndex = 3;
            this.OpenTestsFormButton.Text = "Тесты";
            this.OpenTestsFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenTestsFormButton.UseVisualStyleBackColor = true;
            this.OpenTestsFormButton.Click += new System.EventHandler(this.TestsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(286, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Главное меню";
            // 
            // OpenTheoryFormButton
            // 
            this.OpenTheoryFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenTheoryFormButton.Image = global::TechnologicalEquipApp.Properties.Resources.теория;
            this.OpenTheoryFormButton.Location = new System.Drawing.Point(28, 100);
            this.OpenTheoryFormButton.Name = "OpenTheoryFormButton";
            this.OpenTheoryFormButton.Size = new System.Drawing.Size(167, 188);
            this.OpenTheoryFormButton.TabIndex = 7;
            this.OpenTheoryFormButton.Text = "Теория";
            this.OpenTheoryFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenTheoryFormButton.UseVisualStyleBackColor = true;
            this.OpenTheoryFormButton.Click += new System.EventHandler(this.OpenTheoryFormButton_Click);
            // 
            // OpenUserProfileForm
            // 
            this.OpenUserProfileForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenUserProfileForm.Image = global::TechnologicalEquipApp.Properties.Resources.profle;
            this.OpenUserProfileForm.Location = new System.Drawing.Point(375, 100);
            this.OpenUserProfileForm.Name = "OpenUserProfileForm";
            this.OpenUserProfileForm.Size = new System.Drawing.Size(167, 188);
            this.OpenUserProfileForm.TabIndex = 8;
            this.OpenUserProfileForm.Text = "Личный кабинет";
            this.OpenUserProfileForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenUserProfileForm.UseVisualStyleBackColor = true;
            this.OpenUserProfileForm.Click += new System.EventHandler(this.OpenUserProfileForm_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Image = global::TechnologicalEquipApp.Properties.Resources.power;
            this.ExitButton.Location = new System.Drawing.Point(548, 100);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(167, 188);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Выход";
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 300);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OpenUserProfileForm);
            this.Controls.Add(this.OpenTheoryFormButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenTestsFormButton);
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OpenTestsFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenTheoryFormButton;
        private System.Windows.Forms.Button OpenUserProfileForm;
        private System.Windows.Forms.Button ExitButton;
    }
}

