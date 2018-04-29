namespace СarServiceApplication
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
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath1 = new Telerik.WinControls.UI.CarouselEllipsePath();
            this.radCarousel1 = new Telerik.WinControls.UI.RadCarousel();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BackPicButton = new System.Windows.Forms.Button();
            this.NextPicButton = new System.Windows.Forms.Button();
            this.TheoryPictureBox = new System.Windows.Forms.PictureBox();
            this.TheoryPdfViewer = new Telerik.WinControls.UI.RadPdfViewer();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TheoryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheoryPdfViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radCarousel1
            // 
            carouselEllipsePath1.Center = new Telerik.WinControls.UI.Point3D(50D, 50D, 0D);
            carouselEllipsePath1.FinalAngle = -100D;
            carouselEllipsePath1.InitialAngle = -90D;
            carouselEllipsePath1.U = new Telerik.WinControls.UI.Point3D(-20D, -17D, -50D);
            carouselEllipsePath1.V = new Telerik.WinControls.UI.Point3D(30D, -25D, -60D);
            carouselEllipsePath1.ZScale = 500D;
            this.radCarousel1.CarouselPath = carouselEllipsePath1;
            this.radCarousel1.Location = new System.Drawing.Point(281, 118);
            this.radCarousel1.Name = "radCarousel1";
            this.radCarousel1.Size = new System.Drawing.Size(240, 150);
            this.radCarousel1.TabIndex = 0;
            this.radCarousel1.Text = "radCarousel1";
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
            this.splitPanel1.Controls.Add(this.splitContainer1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(1350, 529);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.281106F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 122);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BackPicButton);
            this.splitContainer1.Panel1.Controls.Add(this.NextPicButton);
            this.splitContainer1.Panel1.Controls.Add(this.TheoryPictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TheoryPdfViewer);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 529);
            this.splitContainer1.SplitterDistance = 523;
            this.splitContainer1.TabIndex = 0;
            // 
            // BackPicButton
            // 
            this.BackPicButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackPicButton.Location = new System.Drawing.Point(54, 449);
            this.BackPicButton.Name = "BackPicButton";
            this.BackPicButton.Size = new System.Drawing.Size(150, 54);
            this.BackPicButton.TabIndex = 3;
            this.BackPicButton.Text = "Назад";
            this.BackPicButton.UseVisualStyleBackColor = true;
            this.BackPicButton.Click += new System.EventHandler(this.BackPicButton_Click);
            // 
            // NextPicButton
            // 
            this.NextPicButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextPicButton.Location = new System.Drawing.Point(299, 449);
            this.NextPicButton.Name = "NextPicButton";
            this.NextPicButton.Size = new System.Drawing.Size(150, 54);
            this.NextPicButton.TabIndex = 2;
            this.NextPicButton.Text = "Вперед";
            this.NextPicButton.UseVisualStyleBackColor = true;
            this.NextPicButton.Click += new System.EventHandler(this.NextPicButton_Click);
            // 
            // TheoryPictureBox
            // 
            this.TheoryPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TheoryPictureBox.Location = new System.Drawing.Point(12, 12);
            this.TheoryPictureBox.Name = "TheoryPictureBox";
            this.TheoryPictureBox.Size = new System.Drawing.Size(501, 422);
            this.TheoryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TheoryPictureBox.TabIndex = 0;
            this.TheoryPictureBox.TabStop = false;
            // 
            // TheoryPdfViewer
            // 
            this.TheoryPdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TheoryPdfViewer.Location = new System.Drawing.Point(0, 0);
            this.TheoryPdfViewer.Name = "TheoryPdfViewer";
            this.TheoryPdfViewer.Size = new System.Drawing.Size(823, 529);
            this.TheoryPdfViewer.TabIndex = 0;
            this.TheoryPdfViewer.ThumbnailsScaleFactor = 0.15F;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.MainMenuButton);
            this.splitPanel2.Controls.Add(this.TestButton);
            this.splitPanel2.Location = new System.Drawing.Point(0, 533);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(1350, 148);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.281106F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -122);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuButton.Location = new System.Drawing.Point(280, 33);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(208, 78);
            this.MainMenuButton.TabIndex = 0;
            this.MainMenuButton.Text = "В меню";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // TestButton
            // 
            this.TestButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestButton.Location = new System.Drawing.Point(737, 33);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(208, 78);
            this.TestButton.TabIndex = 1;
            this.TestButton.Text = "Пройти тест";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "TheoryForm";
            this.Text = "TheoryForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TheoryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheoryPdfViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadCarousel radCarousel1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox TheoryPictureBox;
        private Telerik.WinControls.UI.RadPdfViewer TheoryPdfViewer;
        private System.Windows.Forms.Button BackPicButton;
        private System.Windows.Forms.Button NextPicButton;
    }
}