namespace TechnologicalEquipApp
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Машина как объект производства");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Машиностроительное предприятие");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Способы получения и обработки заготовок");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Структурные элементы технологической операции");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Типы производства");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Теоретические основы технологии машиностроения", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Технологичность конструкций машин");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Технологичность конструкций деталей");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Технологичность конструкций изделий", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Базы и принципы базирования в машиностроении");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Точность изделий");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Качество поверхностей деталей машин");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Выбор способов обработки поверхностей");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Заготовки деталей машин");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Припуски на механическую обработку");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Технологическое обеспечение качества изготовления машин", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Общие сведения о сборке машин");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Балансировка и досборочная обработка");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Составление схемы сборки");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Способы сборки типовых соединений");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Структурные компоненты технологии сборки машин", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseAppButton = new System.Windows.Forms.Button();
            this.OpenUserProfileButton = new System.Windows.Forms.Button();
            this.OpenTestsForm = new System.Windows.Forms.Button();
            this.OpenTheoryFormButton = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ContentTreeView = new System.Windows.Forms.TreeView();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.QuestionCounterLabel = new System.Windows.Forms.Label();
            this.Answer3RadioButton = new System.Windows.Forms.RadioButton();
            this.Answer2RadioButton = new System.Windows.Forms.RadioButton();
            this.Answer1RadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 691);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(589, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Выход";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(371, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Личный кабинет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(239, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Тесты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Теория";
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.BackgroundImage = global::TechnologicalEquipApp.Properties.Resources.power;
            this.CloseAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseAppButton.Location = new System.Drawing.Point(562, 11);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Size = new System.Drawing.Size(126, 106);
            this.CloseAppButton.TabIndex = 14;
            this.CloseAppButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CloseAppButton.UseVisualStyleBackColor = true;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // OpenUserProfileButton
            // 
            this.OpenUserProfileButton.BackgroundImage = global::TechnologicalEquipApp.Properties.Resources.profle;
            this.OpenUserProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenUserProfileButton.Location = new System.Drawing.Point(388, 11);
            this.OpenUserProfileButton.Name = "OpenUserProfileButton";
            this.OpenUserProfileButton.Size = new System.Drawing.Size(126, 106);
            this.OpenUserProfileButton.TabIndex = 12;
            this.OpenUserProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenUserProfileButton.UseVisualStyleBackColor = true;
            this.OpenUserProfileButton.Click += new System.EventHandler(this.OpenUserProfileButton_Click_1);
            // 
            // OpenTestsForm
            // 
            this.OpenTestsForm.BackgroundImage = global::TechnologicalEquipApp.Properties.Resources.тесты;
            this.OpenTestsForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenTestsForm.Location = new System.Drawing.Point(220, 11);
            this.OpenTestsForm.Name = "OpenTestsForm";
            this.OpenTestsForm.Size = new System.Drawing.Size(126, 106);
            this.OpenTestsForm.TabIndex = 11;
            this.OpenTestsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenTestsForm.UseVisualStyleBackColor = true;
            // 
            // OpenTheoryFormButton
            // 
            this.OpenTheoryFormButton.BackgroundImage = global::TechnologicalEquipApp.Properties.Resources.теория;
            this.OpenTheoryFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenTheoryFormButton.Location = new System.Drawing.Point(48, 11);
            this.OpenTheoryFormButton.Name = "OpenTheoryFormButton";
            this.OpenTheoryFormButton.Size = new System.Drawing.Size(126, 106);
            this.OpenTheoryFormButton.TabIndex = 10;
            this.OpenTheoryFormButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenTheoryFormButton.UseVisualStyleBackColor = true;
            this.OpenTheoryFormButton.Click += new System.EventHandler(this.OpenTheoryFormButton_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ContentTreeView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.NextQuestionButton);
            this.splitContainer2.Panel2.Controls.Add(this.QuestionLabel);
            this.splitContainer2.Panel2.Controls.Add(this.QuestionCounterLabel);
            this.splitContainer2.Panel2.Controls.Add(this.Answer3RadioButton);
            this.splitContainer2.Panel2.Controls.Add(this.Answer2RadioButton);
            this.splitContainer2.Panel2.Controls.Add(this.Answer1RadioButton);
            this.splitContainer2.Size = new System.Drawing.Size(1350, 527);
            this.splitContainer2.SplitterDistance = 567;
            this.splitContainer2.TabIndex = 0;
            // 
            // ContentTreeView
            // 
            this.ContentTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTreeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContentTreeView.Location = new System.Drawing.Point(0, 0);
            this.ContentTreeView.Name = "ContentTreeView";
            treeNode1.Name = "1";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode1.Text = "Машина как объект производства";
            treeNode2.Name = "2";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode2.Text = "Машиностроительное предприятие";
            treeNode3.Name = "3";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode3.Text = "Способы получения и обработки заготовок";
            treeNode4.Name = "4";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode4.Text = "Структурные элементы технологической операции";
            treeNode5.Name = "5";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode5.Text = "Типы производства";
            treeNode6.Name = "Node0";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode6.Text = "Теоретические основы технологии машиностроения";
            treeNode7.Name = "6";
            treeNode7.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode7.Text = "Технологичность конструкций машин";
            treeNode8.Name = "7";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode8.Text = "Технологичность конструкций деталей";
            treeNode9.Name = "Node1";
            treeNode9.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode9.Text = "Технологичность конструкций изделий";
            treeNode10.Name = "8";
            treeNode10.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode10.Text = "Базы и принципы базирования в машиностроении";
            treeNode11.Name = "9";
            treeNode11.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode11.Text = "Точность изделий";
            treeNode12.Name = "10";
            treeNode12.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode12.Text = "Качество поверхностей деталей машин";
            treeNode13.Name = "11";
            treeNode13.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode13.Text = "Выбор способов обработки поверхностей";
            treeNode14.Name = "12";
            treeNode14.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode14.Text = "Заготовки деталей машин";
            treeNode15.Name = "13";
            treeNode15.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode15.Text = "Припуски на механическую обработку";
            treeNode16.Name = "Node2";
            treeNode16.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode16.Text = "Технологическое обеспечение качества изготовления машин";
            treeNode17.Name = "14";
            treeNode17.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode17.Text = "Общие сведения о сборке машин";
            treeNode18.Name = "15";
            treeNode18.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode18.Text = "Балансировка и досборочная обработка";
            treeNode19.Name = "16";
            treeNode19.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode19.Text = "Составление схемы сборки";
            treeNode20.Name = "17";
            treeNode20.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode20.Text = "Способы сборки типовых соединений";
            treeNode21.Name = "Node3";
            treeNode21.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode21.Text = "Структурные компоненты технологии сборки машин";
            this.ContentTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9,
            treeNode16,
            treeNode21});
            this.ContentTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContentTreeView.Size = new System.Drawing.Size(565, 525);
            this.ContentTreeView.TabIndex = 0;
            this.ContentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ContentTreeView_AfterSelect);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextQuestionButton.Location = new System.Drawing.Point(321, 324);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(151, 63);
            this.NextQuestionButton.TabIndex = 6;
            this.NextQuestionButton.Text = "Далее";
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(52, 123);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(599, 55);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Вопрос";
            // 
            // QuestionCounterLabel
            // 
            this.QuestionCounterLabel.AutoSize = true;
            this.QuestionCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionCounterLabel.Location = new System.Drawing.Point(318, 34);
            this.QuestionCounterLabel.Name = "QuestionCounterLabel";
            this.QuestionCounterLabel.Size = new System.Drawing.Size(112, 18);
            this.QuestionCounterLabel.TabIndex = 3;
            this.QuestionCounterLabel.Text = "Вопрос 1 из 10";
            // 
            // Answer3RadioButton
            // 
            this.Answer3RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3RadioButton.Location = new System.Drawing.Point(55, 263);
            this.Answer3RadioButton.Name = "Answer3RadioButton";
            this.Answer3RadioButton.Size = new System.Drawing.Size(648, 42);
            this.Answer3RadioButton.TabIndex = 2;
            this.Answer3RadioButton.TabStop = true;
            this.Answer3RadioButton.Text = "Ответ 3";
            this.Answer3RadioButton.UseVisualStyleBackColor = true;
            // 
            // Answer2RadioButton
            // 
            this.Answer2RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2RadioButton.Location = new System.Drawing.Point(55, 222);
            this.Answer2RadioButton.Name = "Answer2RadioButton";
            this.Answer2RadioButton.Size = new System.Drawing.Size(648, 42);
            this.Answer2RadioButton.TabIndex = 1;
            this.Answer2RadioButton.TabStop = true;
            this.Answer2RadioButton.Text = "Ответ 2";
            this.Answer2RadioButton.UseVisualStyleBackColor = true;
            // 
            // Answer1RadioButton
            // 
            this.Answer1RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1RadioButton.Location = new System.Drawing.Point(55, 181);
            this.Answer1RadioButton.Name = "Answer1RadioButton";
            this.Answer1RadioButton.Size = new System.Drawing.Size(648, 42);
            this.Answer1RadioButton.TabIndex = 0;
            this.Answer1RadioButton.TabStop = true;
            this.Answer1RadioButton.Text = "Ответ 1";
            this.Answer1RadioButton.UseVisualStyleBackColor = true;
            // 
            // TestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TestsForm";
            this.Text = "TestsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView ContentTreeView;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label QuestionCounterLabel;
        private System.Windows.Forms.RadioButton Answer3RadioButton;
        private System.Windows.Forms.RadioButton Answer2RadioButton;
        private System.Windows.Forms.RadioButton Answer1RadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseAppButton;
        private System.Windows.Forms.Button OpenUserProfileButton;
        private System.Windows.Forms.Button OpenTestsForm;
        private System.Windows.Forms.Button OpenTheoryFormButton;
    }
}