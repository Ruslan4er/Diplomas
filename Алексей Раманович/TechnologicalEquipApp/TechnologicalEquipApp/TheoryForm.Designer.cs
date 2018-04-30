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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.radPdfViewer1 = new Telerik.WinControls.UI.RadPdfViewer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(1350, 681);
            this.splitContainer1.SplitterDistance = 158;
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
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.radPdfViewer1);
            this.splitContainer2.Size = new System.Drawing.Size(1350, 519);
            this.splitContainer2.SplitterDistance = 597;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node5";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode1.Text = "Машина как объект производства";
            treeNode2.Name = "Node10";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode2.Text = "Машиностроительное предприятие";
            treeNode3.Name = "Node11";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode3.Text = "Способы получения и обработки заготовок";
            treeNode4.Name = "Node12";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode4.Text = "Структурные элементы технологической операции";
            treeNode5.Name = "Node13";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode5.Text = "Типы производства";
            treeNode6.Name = "Node0";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode6.Text = "Теоретические основы технологии машиностроения";
            treeNode7.Name = "Node15";
            treeNode7.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode7.Text = "Технологичность конструкций машин";
            treeNode8.Name = "Node16";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode8.Text = "Технологичность конструкций деталей";
            treeNode9.Name = "Node1";
            treeNode9.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode9.Text = "Технологичность конструкций изделий";
            treeNode10.Name = "Node18";
            treeNode10.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode10.Text = "Базы и принципы базирования в машиностроении";
            treeNode11.Name = "Node19";
            treeNode11.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode11.Text = "Точность изделий";
            treeNode12.Name = "Node20";
            treeNode12.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode12.Text = "Качество поверхностей деталей машин";
            treeNode13.Name = "Node21";
            treeNode13.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode13.Text = "Выбор способов обработки поверхностей";
            treeNode14.Name = "Node22";
            treeNode14.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode14.Text = "Заготовки деталей машин";
            treeNode15.Name = "Node23";
            treeNode15.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode15.Text = "Припуски на механическую обработку";
            treeNode16.Name = "Node2";
            treeNode16.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode16.Text = "Технологическое обеспечение качества изготовления машин";
            treeNode17.Name = "Node24";
            treeNode17.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode17.Text = "Общие сведения о сборке машин";
            treeNode18.Name = "Node25";
            treeNode18.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode18.Text = "Балансировка и досборочная обработка";
            treeNode19.Name = "Node26";
            treeNode19.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode19.Text = "Составление схемы сборки";
            treeNode20.Name = "Node27";
            treeNode20.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode20.Text = "Способы сборки типовых соединений";
            treeNode21.Name = "Node3";
            treeNode21.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode21.Text = "Структурные компоненты технологии сборки машин";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9,
            treeNode16,
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(595, 517);
            this.treeView1.TabIndex = 0;
            // 
            // radPdfViewer1
            // 
            this.radPdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPdfViewer1.EnableThumbnails = false;
            this.radPdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.radPdfViewer1.Name = "radPdfViewer1";
            this.radPdfViewer1.Size = new System.Drawing.Size(747, 517);
            this.radPdfViewer1.TabIndex = 0;
            this.radPdfViewer1.ThumbnailsScaleFactor = 0.15F;
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1364, 720);
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
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView1;
        private Telerik.WinControls.UI.RadPdfViewer radPdfViewer1;
    }
}