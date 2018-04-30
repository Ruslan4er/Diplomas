namespace CarStructureApp
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenChaptersFormLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OpenTestingFormLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OpenVideoFormLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 681);
            this.splitContainer1.SplitterDistance = 694;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OpenChaptersFormLinkLabel);
            this.panel1.Location = new System.Drawing.Point(209, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 293);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Теория";
            // 
            // OpenChaptersFormLinkLabel
            // 
            this.OpenChaptersFormLinkLabel.AutoSize = true;
            this.OpenChaptersFormLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenChaptersFormLinkLabel.Location = new System.Drawing.Point(101, 105);
            this.OpenChaptersFormLinkLabel.Name = "OpenChaptersFormLinkLabel";
            this.OpenChaptersFormLinkLabel.Size = new System.Drawing.Size(122, 29);
            this.OpenChaptersFormLinkLabel.TabIndex = 7;
            this.OpenChaptersFormLinkLabel.TabStop = true;
            this.OpenChaptersFormLinkLabel.Text = "Разделы";
            this.OpenChaptersFormLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenChaptersFormLinkLabel_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.OpenTestingFormLinkLabel);
            this.panel2.Controls.Add(this.OpenVideoFormLinkLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(142, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 293);
            this.panel2.TabIndex = 10;
            // 
            // OpenTestingFormLinkLabel
            // 
            this.OpenTestingFormLinkLabel.AutoSize = true;
            this.OpenTestingFormLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenTestingFormLinkLabel.Location = new System.Drawing.Point(93, 149);
            this.OpenTestingFormLinkLabel.Name = "OpenTestingFormLinkLabel";
            this.OpenTestingFormLinkLabel.Size = new System.Drawing.Size(192, 29);
            this.OpenTestingFormLinkLabel.TabIndex = 6;
            this.OpenTestingFormLinkLabel.TabStop = true;
            this.OpenTestingFormLinkLabel.Text = "Тестирование";
            this.OpenTestingFormLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenTestingFormLinkLabel_LinkClicked);
            // 
            // OpenVideoFormLinkLabel
            // 
            this.OpenVideoFormLinkLabel.AutoSize = true;
            this.OpenVideoFormLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenVideoFormLinkLabel.Location = new System.Drawing.Point(93, 105);
            this.OpenVideoFormLinkLabel.Name = "OpenVideoFormLinkLabel";
            this.OpenVideoFormLinkLabel.Size = new System.Drawing.Size(182, 29);
            this.OpenVideoFormLinkLabel.TabIndex = 5;
            this.OpenVideoFormLinkLabel.TabStop = true;
            this.OpenVideoFormLinkLabel.Text = "Видеоролики";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(92, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Практикум";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel OpenChaptersFormLinkLabel;
        private System.Windows.Forms.LinkLabel OpenTestingFormLinkLabel;
        private System.Windows.Forms.LinkLabel OpenVideoFormLinkLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}