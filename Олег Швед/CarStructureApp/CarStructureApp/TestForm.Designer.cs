namespace CarStructureApp
{
    partial class TestForm
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
            this.Answer1RadioButton = new System.Windows.Forms.RadioButton();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Answer2RadioButton = new System.Windows.Forms.RadioButton();
            this.Answer3RadioButton = new System.Windows.Forms.RadioButton();
            this.QuestionCounterLabel = new System.Windows.Forms.Label();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Answer1RadioButton
            // 
            this.Answer1RadioButton.AutoSize = true;
            this.Answer1RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1RadioButton.Location = new System.Drawing.Point(86, 294);
            this.Answer1RadioButton.Name = "Answer1RadioButton";
            this.Answer1RadioButton.Size = new System.Drawing.Size(88, 24);
            this.Answer1RadioButton.TabIndex = 0;
            this.Answer1RadioButton.TabStop = true;
            this.Answer1RadioButton.Text = "Ответ 1";
            this.Answer1RadioButton.UseVisualStyleBackColor = true;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(24, 229);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(64, 20);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Вопрос";
            // 
            // Answer2RadioButton
            // 
            this.Answer2RadioButton.AutoSize = true;
            this.Answer2RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2RadioButton.Location = new System.Drawing.Point(86, 343);
            this.Answer2RadioButton.Name = "Answer2RadioButton";
            this.Answer2RadioButton.Size = new System.Drawing.Size(88, 24);
            this.Answer2RadioButton.TabIndex = 2;
            this.Answer2RadioButton.TabStop = true;
            this.Answer2RadioButton.Text = "Ответ 2";
            this.Answer2RadioButton.UseVisualStyleBackColor = true;
            // 
            // Answer3RadioButton
            // 
            this.Answer3RadioButton.AutoSize = true;
            this.Answer3RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3RadioButton.Location = new System.Drawing.Point(86, 393);
            this.Answer3RadioButton.Name = "Answer3RadioButton";
            this.Answer3RadioButton.Size = new System.Drawing.Size(88, 24);
            this.Answer3RadioButton.TabIndex = 3;
            this.Answer3RadioButton.TabStop = true;
            this.Answer3RadioButton.Text = "Ответ 3";
            this.Answer3RadioButton.UseVisualStyleBackColor = true;
            // 
            // QuestionCounterLabel
            // 
            this.QuestionCounterLabel.AutoSize = true;
            this.QuestionCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionCounterLabel.Location = new System.Drawing.Point(374, 92);
            this.QuestionCounterLabel.Name = "QuestionCounterLabel";
            this.QuestionCounterLabel.Size = new System.Drawing.Size(183, 29);
            this.QuestionCounterLabel.TabIndex = 5;
            this.QuestionCounterLabel.Text = "Вопрос 1 из 10";
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.BackColor = System.Drawing.Color.PowderBlue;
            this.NextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextQuestionButton.Location = new System.Drawing.Point(403, 458);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(164, 66);
            this.NextQuestionButton.TabIndex = 6;
            this.NextQuestionButton.Text = "Вперед";
            this.NextQuestionButton.UseVisualStyleBackColor = false;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.PowderBlue;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HomeButton.Location = new System.Drawing.Point(379, 559);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(220, 93);
            this.HomeButton.TabIndex = 7;
            this.HomeButton.Text = "В главное меню";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.QuestionCounterLabel);
            this.Controls.Add(this.Answer3RadioButton);
            this.Controls.Add(this.Answer2RadioButton);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.Answer1RadioButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Answer1RadioButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.RadioButton Answer2RadioButton;
        private System.Windows.Forms.RadioButton Answer3RadioButton;
        private System.Windows.Forms.Label QuestionCounterLabel;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Button HomeButton;
    }
}