namespace TechnologicalEquipApp
{
    partial class TheoryForm
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
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Машина как объект производства");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Машиностроительное предприятие");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Способы получения и обработки заготовок");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Структурные элементы технологической операции");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Типы производства");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Теоретические основы технологии машиностроения", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Технологичность конструкций машин");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Технологичность конструкций деталей");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Технологичность конструкций изделий", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Базы и принципы базирования в машиностроении");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Точность изделий");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Качество поверхностей деталей машин");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Выбор способов обработки поверхностей");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Заготовки деталей машин");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Припуски на механическую обработку");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Технологическое обеспечение качества изготовления машин", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Общие сведения о сборке машин");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Балансировка и досборочная обработка");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Составление схемы сборки");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Способы сборки типовых соединений");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Структурные компоненты технологии сборки машин", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ContentTreeView = new System.Windows.Forms.TreeView();
            this.TheoryPdfViewer = new Telerik.WinControls.UI.RadPdfViewer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TheoryPdfViewer)).BeginInit();
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
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
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
            this.splitContainer2.Panel2.Controls.Add(this.TheoryPdfViewer);
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
            treeNode22.Name = "Chapter1_1";
            treeNode22.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode22.Text = "Машина как объект производства";
            treeNode23.Name = "Chapter1_2";
            treeNode23.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode23.Text = "Машиностроительное предприятие";
            treeNode24.Name = "Chapter1_3";
            treeNode24.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode24.Text = "Способы получения и обработки заготовок";
            treeNode25.Name = "Chapter1_4";
            treeNode25.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode25.Text = "Структурные элементы технологической операции";
            treeNode26.Name = "Chapter1_5";
            treeNode26.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode26.Text = "Типы производства";
            treeNode27.Name = "Node0";
            treeNode27.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode27.Text = "Теоретические основы технологии машиностроения";
            treeNode28.Name = "Chapter2_1";
            treeNode28.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode28.Text = "Технологичность конструкций машин";
            treeNode29.Name = "Chapter2_2";
            treeNode29.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode29.Text = "Технологичность конструкций деталей";
            treeNode30.Name = "Node1";
            treeNode30.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode30.Text = "Технологичность конструкций изделий";
            treeNode31.Name = "Chapter3_1";
            treeNode31.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode31.Text = "Базы и принципы базирования в машиностроении";
            treeNode32.Name = "Chapter3_2";
            treeNode32.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode32.Text = "Точность изделий";
            treeNode33.Name = "Chapter3_3";
            treeNode33.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode33.Text = "Качество поверхностей деталей машин";
            treeNode34.Name = "Chapter3_4";
            treeNode34.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode34.Text = "Выбор способов обработки поверхностей";
            treeNode35.Name = "Chapter3_5";
            treeNode35.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode35.Text = "Заготовки деталей машин";
            treeNode36.Name = "Chapter3_6";
            treeNode36.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode36.Text = "Припуски на механическую обработку";
            treeNode37.Name = "Node2";
            treeNode37.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode37.Text = "Технологическое обеспечение качества изготовления машин";
            treeNode38.Name = "Chapter4_1";
            treeNode38.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode38.Text = "Общие сведения о сборке машин";
            treeNode39.Name = "Chapter4_2";
            treeNode39.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode39.Text = "Балансировка и досборочная обработка";
            treeNode40.Name = "Chapter4_3";
            treeNode40.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode40.Text = "Составление схемы сборки";
            treeNode41.Name = "Chapter4_4";
            treeNode41.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode41.Text = "Способы сборки типовых соединений";
            treeNode42.Name = "Node3";
            treeNode42.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode42.Text = "Структурные компоненты технологии сборки машин";
            this.ContentTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode30,
            treeNode37,
            treeNode42});
            this.ContentTreeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContentTreeView.Size = new System.Drawing.Size(565, 525);
            this.ContentTreeView.TabIndex = 0;
            this.ContentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ContentTreeView_AfterSelect);
            // 
            // TheoryPdfViewer
            // 
            this.TheoryPdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TheoryPdfViewer.EnableThumbnails = false;
            this.TheoryPdfViewer.Location = new System.Drawing.Point(0, 0);
            this.TheoryPdfViewer.Name = "TheoryPdfViewer";
            this.TheoryPdfViewer.Size = new System.Drawing.Size(777, 525);
            this.TheoryPdfViewer.TabIndex = 0;
            this.TheoryPdfViewer.ThumbnailsScaleFactor = 0.15F;
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 691);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "TheoryForm";
            this.Text = "TheoryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TheoryPdfViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView ContentTreeView;
        private Telerik.WinControls.UI.RadPdfViewer TheoryPdfViewer;
    }
}