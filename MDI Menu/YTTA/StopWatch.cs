using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YTTA
{
    public partial class StopWatch : Form
    {
        private int elapsedSeconds = 0; // Menyimpan waktu dalam detik
        private bool isRunning = false; // Status stopwatch

        public StopWatch()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            isRunning = true;
            btnStart.Enabled = false;  // Nonaktifkan tombol Start saat berjalan
            btnStop.Enabled = true;    // Aktifkan tombol Stop
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            int hours = elapsedSeconds / 3600;
            int minutes = (elapsedSeconds % 3600) / 60;
            int seconds = elapsedSeconds % 60;
            lblTime.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            elapsedSeconds = 0;
            lblTime.Text = "00:00:00";
            isRunning = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isRunning = false;
            btnStart.Enabled = true;   // Aktifkan Start agar bisa lanjut
            btnStop.Enabled = false;   // Nonaktifkan Stop saat tidak berjalan
        }

        private void StopWatch_Load(object sender, EventArgs e)
        {

        }
    }
}
