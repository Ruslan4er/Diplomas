using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace СarServiceApplication
{
    public partial class VideoForm : Form
    {
        private bool isPlayed = false;

        public VideoForm(string path)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = path;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsMediaEnded)
                this.Close();
        }

        private void VideoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
