﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void stopatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopWatch stopwatchForm = new StopWatch();
            stopwatchForm.MdiParent = this;
            stopwatchForm.Show();
        }
      

        private void tIMERToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TIMER timerForm = new TIMER();
            timerForm.MdiParent = this;
            timerForm.Show();
        }
    }
}
