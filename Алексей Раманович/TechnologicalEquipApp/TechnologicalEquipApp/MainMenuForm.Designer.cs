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
            this.TheoryButton = new System.Windows.Forms.Button();
            this.TestsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TheoryButton
            // 
            this.TheoryButton.Location = new System.Drawing.Point(19, 83);
            this.TheoryButton.Name = "TheoryButton";
            this.TheoryButton.Size = new System.Drawing.Size(150, 106);
            this.TheoryButton.TabIndex = 2;
            this.TheoryButton.Text = "Теория";
            this.TheoryButton.UseVisualStyleBackColor = true;
            this.TheoryButton.Click += new System.EventHandler(this.TheoryButton_Click);
            // 
            // TestsButton
            // 
            this.TestsButton.Location = new System.Drawing.Point(186, 83);
            this.TestsButton.Name = "TestsButton";
            this.TestsButton.Size = new System.Drawing.Size(150, 106);
            this.TestsButton.TabIndex = 3;
            this.TestsButton.Text = "Тесты";
            this.TestsButton.UseVisualStyleBackColor = true;
            this.TestsButton.Click += new System.EventHandler(this.TestsButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 106);
            this.button2.TabIndex = 4;
            this.button2.Text = "Практика";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(537, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 106);
            this.button4.TabIndex = 5;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(256, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Главное меню";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TestsButton);
            this.Controls.Add(this.TheoryButton);
            this.Name = "MainMenuForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TheoryButton;
        private System.Windows.Forms.Button TestsButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

