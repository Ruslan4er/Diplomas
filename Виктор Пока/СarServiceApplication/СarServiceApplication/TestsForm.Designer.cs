namespace СarServiceApplication
{
    partial class TestsForm
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
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.QuestionCounterLabel = new System.Windows.Forms.Label();
            this.Answer3RadioButton = new System.Windows.Forms.RadioButton();
            this.Answer2RadioButton = new System.Windows.Forms.RadioButton();
            this.Answer1RadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            this.radSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(1350, 681);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.NextQuestionButton);
            this.splitPanel1.Controls.Add(this.QuestionLabel);
            this.splitPanel1.Controls.Add(this.QuestionCounterLabel);
            this.splitPanel1.Controls.Add(this.Answer3RadioButton);
            this.splitPanel1.Controls.Add(this.Answer2RadioButton);
            this.splitPanel1.Controls.Add(this.Answer1RadioButton);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(1350, 529);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.2813885F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 191);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.button2);
            this.splitPanel2.Location = new System.Drawing.Point(0, 533);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(1350, 148);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.2813885F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -191);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(392, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 64);
            this.button2.TabIndex = 0;
            this.button2.Text = "В меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextQuestionButton.Location = new System.Drawing.Point(600, 403);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(126, 59);
            this.NextQuestionButton.TabIndex = 13;
            this.NextQuestionButton.Text = "Далее";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(208, 180);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(108, 20);
            this.QuestionLabel.TabIndex = 12;
            this.QuestionLabel.Text = "Текст вопроса";
            // 
            // QuestionCounterLabel
            // 
            this.QuestionCounterLabel.AutoSize = true;
            this.QuestionCounterLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionCounterLabel.Location = new System.Drawing.Point(543, 53);
            this.QuestionCounterLabel.Name = "QuestionCounterLabel";
            this.QuestionCounterLabel.Size = new System.Drawing.Size(163, 30);
            this.QuestionCounterLabel.TabIndex = 11;
            this.QuestionCounterLabel.Text = "Вопрос 1 из 10";
            // 
            // Answer3RadioButton
            // 
            this.Answer3RadioButton.AutoSize = true;
            this.Answer3RadioButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3RadioButton.Location = new System.Drawing.Point(378, 334);
            this.Answer3RadioButton.Name = "Answer3RadioButton";
            this.Answer3RadioButton.Size = new System.Drawing.Size(114, 24);
            this.Answer3RadioButton.TabIndex = 10;
            this.Answer3RadioButton.TabStop = true;
            this.Answer3RadioButton.Text = "radioButton3";
            this.Answer3RadioButton.UseVisualStyleBackColor = true;
            // 
            // Answer2RadioButton
            // 
            this.Answer2RadioButton.AutoSize = true;
            this.Answer2RadioButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2RadioButton.Location = new System.Drawing.Point(378, 302);
            this.Answer2RadioButton.Name = "Answer2RadioButton";
            this.Answer2RadioButton.Size = new System.Drawing.Size(114, 24);
            this.Answer2RadioButton.TabIndex = 9;
            this.Answer2RadioButton.TabStop = true;
            this.Answer2RadioButton.Text = "radioButton2";
            this.Answer2RadioButton.UseVisualStyleBackColor = true;
            // 
            // Answer1RadioButton
            // 
            this.Answer1RadioButton.AutoSize = true;
            this.Answer1RadioButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1RadioButton.Location = new System.Drawing.Point(378, 269);
            this.Answer1RadioButton.Name = "Answer1RadioButton";
            this.Answer1RadioButton.Size = new System.Drawing.Size(114, 24);
            this.Answer1RadioButton.TabIndex = 8;
            this.Answer1RadioButton.TabStop = true;
            this.Answer1RadioButton.Text = "radioButton1";
            this.Answer1RadioButton.UseVisualStyleBackColor = true;
            // 
            // TestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "TestsForm";
            this.Text = "TestsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.splitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label QuestionCounterLabel;
        private System.Windows.Forms.RadioButton Answer3RadioButton;
        private System.Windows.Forms.RadioButton Answer2RadioButton;
        private System.Windows.Forms.RadioButton Answer1RadioButton;
    }
}