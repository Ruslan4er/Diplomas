namespace TechnologicalEquipApp
{
    partial class UserProfileForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseAppButton = new System.Windows.Forms.Button();
            this.OpenUserProfileButton = new System.Windows.Forms.Button();
            this.OpenTestsForm = new System.Windows.Forms.Button();
            this.OpenTheoryFormButton = new System.Windows.Forms.Button();
            this.TestResultGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestResultGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.CloseAppButton);
            this.splitContainer1.Panel1.Controls.Add(this.OpenUserProfileButton);
            this.splitContainer1.Panel1.Controls.Add(this.OpenTestsForm);
            this.splitContainer1.Panel1.Controls.Add(this.OpenTheoryFormButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TestResultGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 681);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(597, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Выход";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(372, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Личный кабинет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(247, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Тесты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Теория";
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.BackgroundImage = global::TechnologicalEquipApp.Properties.Resources.power;
            this.CloseAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseAppButton.Location = new System.Drawing.Point(566, 11);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Size = new System.Drawing.Size(126, 106);
            this.CloseAppButton.TabIndex = 24;
            this.CloseAppButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CloseAppButton.UseVisualStyleBackColor = true;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // OpenUserProfileButton
            // 
            this.OpenUserProfileButton.BackgroundImage = global::TechnologicalEquipApp.Properties.Resources.profle;
            this.OpenUserProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenUserProfileButton.Location = new System.Drawing.Point(396, 11);
            this.OpenUserProfileButton.Name = "OpenUserProfileButton";
            this.OpenUserProfileButton.Size = new System.Drawing.Size(126, 106);
            this.OpenUserProfileButton.TabIndex = 22;
            this.OpenUserProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenUserProfileButton.UseVisualStyleBackColor = true;
            this.OpenUserProfileButton.Click += new System.EventHandler(this.OpenUserProfileButton_Click);
            // 
            // OpenTestsForm
            // 
            this.OpenTestsForm.BackgroundImage = global::TechnologicalEquipApp.Properties.Resources.тесты;
            this.OpenTestsForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenTestsForm.Location = new System.Drawing.Point(228, 11);
            this.OpenTestsForm.Name = "OpenTestsForm";
            this.OpenTestsForm.Size = new System.Drawing.Size(126, 106);
            this.OpenTestsForm.TabIndex = 21;
            this.OpenTestsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenTestsForm.UseVisualStyleBackColor = true;
            this.OpenTestsForm.Click += new System.EventHandler(this.OpenTestsForm_Click);
            // 
            // OpenTheoryFormButton
            // 
            this.OpenTheoryFormButton.BackgroundImage = global::TechnologicalEquipApp.Properties.Resources.теория;
            this.OpenTheoryFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenTheoryFormButton.Location = new System.Drawing.Point(56, 11);
            this.OpenTheoryFormButton.Name = "OpenTheoryFormButton";
            this.OpenTheoryFormButton.Size = new System.Drawing.Size(126, 106);
            this.OpenTheoryFormButton.TabIndex = 20;
            this.OpenTheoryFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenTheoryFormButton.UseVisualStyleBackColor = true;
            this.OpenTheoryFormButton.Click += new System.EventHandler(this.OpenTheoryFormButton_Click);
            // 
            // TestResultGridView
            // 
            this.TestResultGridView.AllowUserToAddRows = false;
            this.TestResultGridView.AllowUserToDeleteRows = false;
            this.TestResultGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TestResultGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestResultGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TestResultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TestResultGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TestResultGridView.Location = new System.Drawing.Point(196, 38);
            this.TestResultGridView.Name = "TestResultGridView";
            this.TestResultGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TestResultGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TestResultGridView.Size = new System.Drawing.Size(633, 403);
            this.TestResultGridView.TabIndex = 0;
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserProfileForm";
            this.Text = "UserProfileForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestResultGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseAppButton;
        private System.Windows.Forms.Button OpenUserProfileButton;
        private System.Windows.Forms.Button OpenTestsForm;
        private System.Windows.Forms.Button OpenTheoryFormButton;
        private System.Windows.Forms.DataGridView TestResultGridView;
    }
}