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
            Telerik.WinControls.UI.CarouselEllipsePath carouselEllipsePath2 = new Telerik.WinControls.UI.CarouselEllipsePath();
            this.radCarousel1 = new Telerik.WinControls.UI.RadCarousel();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radPdfViewer1 = new Telerik.WinControls.UI.RadPdfViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radCarousel1
            // 
            carouselEllipsePath2.Center = new Telerik.WinControls.UI.Point3D(50D, 50D, 0D);
            carouselEllipsePath2.FinalAngle = -100D;
            carouselEllipsePath2.InitialAngle = -90D;
            carouselEllipsePath2.U = new Telerik.WinControls.UI.Point3D(-20D, -17D, -50D);
            carouselEllipsePath2.V = new Telerik.WinControls.UI.Point3D(30D, -25D, -60D);
            carouselEllipsePath2.ZScale = 500D;
            this.radCarousel1.CarouselPath = carouselEllipsePath2;
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
            this.radSplitContainer1.Size = new System.Drawing.Size(834, 438);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.pictureBox1);
            this.splitPanel1.Controls.Add(this.radPdfViewer1);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(834, 339);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.281106F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 122);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.button2);
            this.splitPanel2.Controls.Add(this.button1);
            this.splitPanel2.Location = new System.Drawing.Point(0, 343);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(834, 95);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.281106F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -122);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radPdfViewer1
            // 
            this.radPdfViewer1.Location = new System.Drawing.Point(430, 12);
            this.radPdfViewer1.Name = "radPdfViewer1";
            this.radPdfViewer1.Size = new System.Drawing.Size(392, 304);
            this.radPdfViewer1.TabIndex = 0;
            this.radPdfViewer1.ThumbnailsScaleFactor = 0.15F;
            this.radPdfViewer1.ViewerMode = Telerik.WinControls.UI.FixedDocumentViewerMode.TextSelection;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 263);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 438);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "TheoryForm";
            this.Text = "TheoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.radCarousel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPdfViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadCarousel radCarousel1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadPdfViewer radPdfViewer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}