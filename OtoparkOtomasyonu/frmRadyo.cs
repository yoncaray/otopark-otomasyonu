using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyonu
{
    public partial class frmRadyo : Form
    {
        public frmRadyo()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Number1 
            axWindowsMediaPlayer1.URL = "http://n10101m.mediatriple.net/videoonlylive/mtkgeuihrlfwlive/u_stream_5c9e2f95dcb16_1/playlist.m3u8";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // Metro FM
            axWindowsMediaPlayer1.URL = "https://17703.live.streamtheworld.com/METRO_FM.mp3";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // Kral Pop
            axWindowsMediaPlayer1.URL = "http://46.20.3.201:80/";
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            // Best FM
            axWindowsMediaPlayer1.URL = "http://46.20.7.126/;stream.mp3";
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            // Süper FM
            axWindowsMediaPlayer1.URL = "https://17733.live.streamtheworld.com/SUPER_FM.mp3";
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            // PowerTürk FM
            axWindowsMediaPlayer1.URL = "https://listen.powerapp.com.tr/powerturk/abr/powerturk/128/playlist.m3u8";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            // Alem FM
            axWindowsMediaPlayer1.URL = "http://scturkmedya.radyotvonline.com/stream/80/";
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            // TRT FM
            axWindowsMediaPlayer1.URL = "https://radio-trtfm.live.trt.com.tr/master.m3u8";
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            // Radyo D
            axWindowsMediaPlayer1.URL = "https://radyo.duhnet.tv/radyod";
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            // Power FM
            axWindowsMediaPlayer1.URL = "http://powerfm.listenpowerapp.com/powerfm/mpeg/icecast.audio";
        }
    }
}
