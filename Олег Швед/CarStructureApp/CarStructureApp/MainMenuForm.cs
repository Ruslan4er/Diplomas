using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarStructureApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void OpenChaptersFormLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new TheoryForm();
            frm.ShowDialog();
        }

        private void OpenTestingFormLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new TestingMenuForm();
            frm.ShowDialog();
        }
    }
}
