namespace YTTA
{
    partial class TIMER
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
            txtMinutes = new TextBox();
            txtHours = new TextBox();
            txtSeconds = new TextBox();
            lblTime = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnReset = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // txtMinutes
            // 
            txtMinutes.Location = new Point(353, 244);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(100, 23);
            txtMinutes.TabIndex = 0;
            // 
            // txtHours
            // 
            txtHours.Location = new Point(228, 244);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(99, 23);
            txtHours.TabIndex = 1;
            // 
            // txtSeconds
            // 
            txtSeconds.Location = new Point(480, 244);
            txtSeconds.Name = "txtSeconds";
            txtSeconds.Size = new Size(93, 23);
            txtSeconds.TabIndex = 2;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 25F);
            lblTime.Location = new Point(338, 159);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(142, 46);
            lblTime.TabIndex = 3;
            lblTime.Text = "00:00:00";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(228, 303);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(79, 27);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(366, 305);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(498, 303);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 226);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 7;
            label1.Text = "JAM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 226);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 8;
            label2.Text = "MENIT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 226);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 9;
            label3.Text = "DETIK";
            // 
            // TIMER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblTime);
            Controls.Add(txtSeconds);
            Controls.Add(txtHours);
            Controls.Add(txtMinutes);
            Name = "TIMER";
            Text = "TIMER";
            Load += TIMER_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TextBox txtMinutes;
        private TextBox txtHours;
        private TextBox txtSeconds;
        private Label lblTime;
        private Button btnStart;
        private Button btnStop;
        private Button btnReset;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}