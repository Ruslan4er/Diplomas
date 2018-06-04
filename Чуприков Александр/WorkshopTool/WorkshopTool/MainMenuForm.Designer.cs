namespace WorkshopTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.EditClientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewClientButton = new System.Windows.Forms.Button();
            this.UsersDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
            this.TransactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.PrintReportButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.splitContainer1.Size = new System.Drawing.Size(1350, 681);
            this.splitContainer1.SplitterDistance = 99;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 578);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.DeleteClient);
            this.tabPage1.Controls.Add(this.EditClientButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AddNewClientButton);
            this.tabPage1.Controls.Add(this.UsersDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1342, 545);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.ToolTipText = "Информация о клиентах";
            // 
            // DeleteClient
            // 
            this.DeleteClient.Location = new System.Drawing.Point(109, 339);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(161, 68);
            this.DeleteClient.TabIndex = 5;
            this.DeleteClient.Text = "Удалить";
            this.DeleteClient.UseVisualStyleBackColor = true;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // EditClientButton
            // 
            this.EditClientButton.Location = new System.Drawing.Point(109, 251);
            this.EditClientButton.Name = "EditClientButton";
            this.EditClientButton.Size = new System.Drawing.Size(161, 68);
            this.EditClientButton.TabIndex = 4;
            this.EditClientButton.Text = "Редактировать";
            this.EditClientButton.UseVisualStyleBackColor = true;
            this.EditClientButton.Click += new System.EventHandler(this.EditClientButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(120, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Клиенты";
            // 
            // AddNewClientButton
            // 
            this.AddNewClientButton.Location = new System.Drawing.Point(109, 167);
            this.AddNewClientButton.Name = "AddNewClientButton";
            this.AddNewClientButton.Size = new System.Drawing.Size(161, 68);
            this.AddNewClientButton.TabIndex = 2;
            this.AddNewClientButton.Text = "Добавить";
            this.AddNewClientButton.UseVisualStyleBackColor = true;
            this.AddNewClientButton.Click += new System.EventHandler(this.AddNewClientButton_Click);
            // 
            // UsersDataGrid
            // 
            this.UsersDataGrid.AllowUserToAddRows = false;
            this.UsersDataGrid.AllowUserToDeleteRows = false;
            this.UsersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UsersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGrid.Location = new System.Drawing.Point(379, 6);
            this.UsersDataGrid.Name = "UsersDataGrid";
            this.UsersDataGrid.ReadOnly = true;
            this.UsersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGrid.Size = new System.Drawing.Size(960, 536);
            this.UsersDataGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.OrdersDataGridView);
            this.tabPage2.Controls.Add(this.DeleteOrderButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.AddOrderButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1342, 545);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказы";
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Location = new System.Drawing.Point(108, 254);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(161, 68);
            this.DeleteOrderButton.TabIndex = 9;
            this.DeleteOrderButton.Text = "Удалить";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Заказы";
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(108, 166);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(161, 68);
            this.AddOrderButton.TabIndex = 7;
            this.AddOrderButton.Text = "Добавить";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage3.Controls.Add(this.PrintReportButton);
            this.tabPage3.Controls.Add(this.TransactionsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1342, 545);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Транзакции";
            // 
            // OrdersDataGridView
            // 
            this.OrdersDataGridView.AllowUserToAddRows = false;
            this.OrdersDataGridView.AllowUserToDeleteRows = false;
            this.OrdersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OrdersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersDataGridView.Location = new System.Drawing.Point(376, 6);
            this.OrdersDataGridView.MultiSelect = false;
            this.OrdersDataGridView.Name = "OrdersDataGridView";
            this.OrdersDataGridView.ReadOnly = true;
            this.OrdersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrdersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersDataGridView.Size = new System.Drawing.Size(960, 536);
            this.OrdersDataGridView.TabIndex = 10;
            // 
            // TransactionsDataGridView
            // 
            this.TransactionsDataGridView.AllowUserToAddRows = false;
            this.TransactionsDataGridView.AllowUserToDeleteRows = false;
            this.TransactionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TransactionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsDataGridView.Location = new System.Drawing.Point(374, 9);
            this.TransactionsDataGridView.MultiSelect = false;
            this.TransactionsDataGridView.Name = "TransactionsDataGridView";
            this.TransactionsDataGridView.ReadOnly = true;
            this.TransactionsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TransactionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionsDataGridView.Size = new System.Drawing.Size(960, 536);
            this.TransactionsDataGridView.TabIndex = 11;
            // 
            // PrintReportButton
            // 
            this.PrintReportButton.Location = new System.Drawing.Point(95, 161);
            this.PrintReportButton.Name = "PrintReportButton";
            this.PrintReportButton.Size = new System.Drawing.Size(161, 68);
            this.PrintReportButton.TabIndex = 12;
            this.PrintReportButton.Text = "Печать отчета";
            this.PrintReportButton.UseVisualStyleBackColor = true;
            this.PrintReportButton.Click += new System.EventHandler(this.PrintReportButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainMenuForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.Button EditClientButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewClientButton;
        private System.Windows.Forms.DataGridView UsersDataGrid;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddOrderButton;
        #endregion

        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.DataGridView TransactionsDataGridView;
        private System.Windows.Forms.Button PrintReportButton;
        private System.Windows.Forms.Label label3;
    }
}