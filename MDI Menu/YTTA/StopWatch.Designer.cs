namespace YTTA
{
    partial class StopWatch
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 25F);
            lblTime.Location = new Point(322, 125);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(142, 46);
            lblTime.TabIndex = 0;
            lblTime.Text = "00:00:00";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(206, 239);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(92, 36);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(343, 239);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(100, 36);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(484, 239);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(99, 36);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // StopWatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 460);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTime);
            Name = "StopWatch";
            Text = "StopWatch";
            Load += StopWatch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblTime;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
    }
}