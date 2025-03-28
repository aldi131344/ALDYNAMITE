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
    public partial class TIMER : Form
    {
        private int totalSeconds; // Menyimpan total waktu dalam detik
        private bool isPaused = false; // Status untuk tombol Stop

        public TIMER()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                if (totalSeconds > 0)
                {
                    totalSeconds--;
                    int hours = totalSeconds / 3600;
                    int minutes = (totalSeconds % 3600) / 60;
                    int seconds = totalSeconds % 60;
                    lblTime.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Waktu Habis!", "Timer");
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                }
            }


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isPaused) // Jika tidak dalam status pause, ambil input baru
            {
                int hours, minutes, seconds;

                if (!int.TryParse(txtHours.Text, out hours)) hours = 0;
                if (!int.TryParse(txtMinutes.Text, out minutes)) minutes = 0;
                if (!int.TryParse(txtSeconds.Text, out seconds)) seconds = 0;

                totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            }

            if (totalSeconds > 0)
            {
                timer1.Start();
                btnStart.Enabled = false;  // Nonaktifkan Start saat timer berjalan
                btnStop.Enabled = true;    // Aktifkan Stop
                btnReset.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isPaused = true;
            btnStart.Enabled = true;  // Mengizinkan lanjut timer
            btnStop.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            totalSeconds = 0;
            lblTime.Text = "00:00:00";
            txtHours.Text = "0";
            txtMinutes.Text = "0";
            txtSeconds.Text = "0";
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            isPaused = false;
        }

        private void TIMER_Load(object sender, EventArgs e)
        {

        }
    }

}
