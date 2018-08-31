﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemindMe
{
    public partial class TimerPopup : Form
    {
        public TimerPopup()
        {            
            InitializeComponent();            
            this.Opacity = 0;            
            tmrFadeIn.Start();

            tbTime.KeyUp += TimerPopup_KeyUp;
            tbNote.KeyUp += TimerPopup_KeyUp;
            this.KeyUp += TimerPopup_KeyUp;
        }

        private void TimerPopup_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                UCTimer ucTimer = Form1.Instance.ucTimer;

                TimeSpan time = TimeSpan.FromSeconds(Convert.ToInt32(tbTime.Text) * 60);
                                                

                ucTimer.numSeconds.Value = Math.Ceiling((decimal)time.Seconds / 60);
                
                ucTimer.numMinutes.Value = Math.Ceiling((decimal)time.Minutes % 60);

                ucTimer.numHours.Value = Math.Ceiling((decimal)time.Hours / 60);

                ucTimer.timerNote = tbNote.Text;
                
                ucTimer.ToggleTimer();

                if(!ucTimer.tmrCountdown.Enabled)
                    ucTimer.ToggleTimer();

                this.Dispose();
            }
        }

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (this.Opacity >= 1)
            {
                tmrFadeIn.Stop();
                this.TopMost = true; //Popup will be always on top. no matter what you are doing, playing a game, watching a video, you will ALWAYS see the popup.
                this.TopLevel = true;
                this.ActiveControl = tbTime;
                this.Activate();
                
            }
        }

        private void TimerPopup_Load(object sender, EventArgs e)
        {           
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.DarkRed;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Transparent;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Dispose();            
        }
    }
}