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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ContentTreeView = new System.Windows.Forms.TreeView();
            this.Answer1RadioButton = new System.Windows.Forms.RadioButton();
            this.Answer2RadioButton = new System.Windows.Forms.RadioButton();
            this.Answer3RadioButton = new System.Windows.Forms.RadioButton();
            this.QuestionCounterLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
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
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 691);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 1;
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
            treeNode1.Name = "Chapter1_1";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode1.Text = "Машина как объект производства";
            treeNode2.Name = "Chapter1_2";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode2.Text = "Машиностроительное предприятие";
            treeNode3.Name = "Chapter1_3";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode3.Text = "Способы получения и обработки заготовок";
            treeNode4.Name = "Chapter1_4";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode4.Text = "Структурные элементы технологической операции";
            treeNode5.Name = "Chapter1_5";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode5.Text = "Типы производства";
            treeNode6.Name = "Node0";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode6.Text = "Теоретические основы технологии машиностроения";
            treeNode7.Name = "Chapter2_1";
            treeNode7.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode7.Text = "Технологичность конструкций машин";
            treeNode8.Name = "Chapter2_2";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode8.Text = "Технологичность конструкций деталей";
            treeNode9.Name = "Node1";
            treeNode9.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode9.Text = "Технологичность конструкций изделий";
            treeNode10.Name = "Chapter3_1";
            treeNode10.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode10.Text = "Базы и принципы базирования в машиностроении";
            treeNode11.Name = "Chapter3_2";
            treeNode11.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode11.Text = "Точность изделий";
            treeNode12.Name = "Chapter3_3";
            treeNode12.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode12.Text = "Качество поверхностей деталей машин";
            treeNode13.Name = "Chapter3_4";
            treeNode13.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode13.Text = "Выбор способов обработки поверхностей";
            treeNode14.Name = "Chapter3_5";
            treeNode14.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode14.Text = "Заготовки деталей машин";
            treeNode15.Name = "Chapter3_6";
            treeNode15.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode15.Text = "Припуски на механическую обработку";
            treeNode16.Name = "Node2";
            treeNode16.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode16.Text = "Технологическое обеспечение качества изготовления машин";
            treeNode17.Name = "Chapter4_1";
            treeNode17.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode17.Text = "Общие сведения о сборке машин";
            treeNode18.Name = "Chapter4_2";
            treeNode18.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode18.Text = "Балансировка и досборочная обработка";
            treeNode19.Name = "Chapter4_3";
            treeNode19.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode19.Text = "Составление схемы сборки";
            treeNode20.Name = "Chapter4_4";
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
            // 
            // Answer1RadioButton
            // 
            this.Answer1RadioButton.AutoSize = true;
            this.Answer1RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer1RadioButton.Location = new System.Drawing.Point(55, 181);
            this.Answer1RadioButton.Name = "Answer1RadioButton";
            this.Answer1RadioButton.Size = new System.Drawing.Size(80, 22);
            this.Answer1RadioButton.TabIndex = 0;
            this.Answer1RadioButton.TabStop = true;
            this.Answer1RadioButton.Text = "Ответ 1";
            this.Answer1RadioButton.UseVisualStyleBackColor = true;
            // 
            // Answer2RadioButton
            // 
            this.Answer2RadioButton.AutoSize = true;
            this.Answer2RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer2RadioButton.Location = new System.Drawing.Point(55, 222);
            this.Answer2RadioButton.Name = "Answer2RadioButton";
            this.Answer2RadioButton.Size = new System.Drawing.Size(80, 22);
            this.Answer2RadioButton.TabIndex = 1;
            this.Answer2RadioButton.TabStop = true;
            this.Answer2RadioButton.Text = "Ответ 2";
            this.Answer2RadioButton.UseVisualStyleBackColor = true;
            // 
            // Answer3RadioButton
            // 
            this.Answer3RadioButton.AutoSize = true;
            this.Answer3RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer3RadioButton.Location = new System.Drawing.Point(55, 263);
            this.Answer3RadioButton.Name = "Answer3RadioButton";
            this.Answer3RadioButton.Size = new System.Drawing.Size(80, 22);
            this.Answer3RadioButton.TabIndex = 2;
            this.Answer3RadioButton.TabStop = true;
            this.Answer3RadioButton.Text = "Ответ 3";
            this.Answer3RadioButton.UseVisualStyleBackColor = true;
            // 
            // QuestionCounterLabel
            // 
            this.QuestionCounterLabel.AutoSize = true;
            this.QuestionCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionCounterLabel.Location = new System.Drawing.Point(360, 28);
            this.QuestionCounterLabel.Name = "QuestionCounterLabel";
            this.QuestionCounterLabel.Size = new System.Drawing.Size(112, 18);
            this.QuestionCounterLabel.TabIndex = 3;
            this.QuestionCounterLabel.Text = "Вопрос 1 из 10";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(52, 123);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(60, 18);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Вопрос";
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
    }
}