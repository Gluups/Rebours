using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApi;

namespace Rebours
{
	public partial class Form1 : Form
	{
		private const uint SW_RESTORE = 0x09;
		TimeSpan sp = new TimeSpan();
		DateTime dt;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{ 
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			lblTimeStart.Text = DateTime.Now.ToString();
			dt = DateTime.Now.AddHours((double)nudHeures.Value).AddMinutes((double)nudMinutes.Value).AddSeconds((double)nudSecondes.Value);
			lblDiff.Visible = true;
			timer1.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			sp = dt.Subtract(DateTime.Now);
			lblTime.Text = dt.ToString();
			sp.ToString().Substring(0, 8);   //?
			lblDiff.Text = sp.ToString().Substring(0, 8);
			if (chkTimeTitle.Checked)
			{
				this.Text = lblDiff.Text + " - " + "Compte à rebours";
			}
			else
			{
				this.Text = "Compte à rebours";
			}
			if (sp.Ticks < 1000)
			{
				timer2.Enabled = true;
				lblDiff.Visible = false;			timer1.Enabled = false;
				timer2_Tick(this, new EventArgs());

				//MessageBox.Show("Fin");
				this.Focus();
				this.WindowState = FormWindowState.Normal;
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
			this.WindowState = FormWindowState.Normal;
			this.BringToFront();
			this.Focus();
			System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
			soundPlayer.SoundLocation = @"C:\Windows\Media\Alarm02.wav";
			soundPlayer.Play();
			btnStop.Visible = true;
			this.Text = "Compte à rebours";
			WinApi.winapi.SetActiveWindow(this.Handle);
			WinApi.winapi.SetForegroundWindow(this.Handle);
			WinApi.winapi.BringWindowToTop(this.Handle);
			WinApi.winapi.SetCursorPos(this.Left + btnStop.Left + (btnStop.Width / 2) + 13,
				this.Top + btnStop.Top + (btnStop.Height / 2) + 33);
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			timer2.Enabled = false;
			timer3.Enabled = true;
		}

		private void timer3_Tick(object sender, EventArgs e)
		{
			btnStop.Visible = false;
			timer3.Enabled = false;
		}

		private void chkTimeTitle_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			nudHeures.Value = 0;
			nudMinutes.Value = 3;
			nudSecondes.Value = 1;
			btnStart_Click(this, new EventArgs());
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			nudHeures.Value = 0;
			nudMinutes.Value = 6;
			nudSecondes.Value = 1;
			btnStart_Click(this, new EventArgs());
		}

		private void btn10_Click(object sender, EventArgs e)
		{
			nudHeures.Value = 0;
			nudMinutes.Value = 10;
			nudSecondes.Value = 1;
			btnStart_Click(this, new EventArgs());
		}

		private void btn40_Click(object sender, EventArgs e)
		{
			nudHeures.Value = 0;
			nudMinutes.Value = 40;
			nudSecondes.Value = 1;
			btnStart_Click(this, new EventArgs());
		}

		private void btn20mn_Click(object sender, EventArgs e)
		{
			nudHeures.Value = 0;
			nudMinutes.Value = 20;
			nudSecondes.Value = 1;
			btnStart_Click(this, new EventArgs());
		}

		private void btn15mn_Click(object sender, EventArgs e)
		{
			nudHeures.Value = 0;
			nudMinutes.Value = 15;
			nudSecondes.Value = 1;
			btnStart_Click(this, new EventArgs());
		}

		private void btn45mn_Click(object sender, EventArgs e)
		{
			nudHeures.Value = 0;
			nudMinutes.Value = 45;
			nudSecondes.Value = 1;
			btnStart_Click(this, new EventArgs());

		}

		private void btn5_Click(object sender, EventArgs e)
		{
			nudHeures.Value = 0;
			nudMinutes.Value = 5;
			nudSecondes.Value = 1;
			btnStart_Click(this, new EventArgs());
		}

		private void btn30mn_Click(object sender, EventArgs e)
		{
			nudHeures.Value = 0;
			nudMinutes.Value = 30;
			nudSecondes.Value = 1;
			btnStart_Click(this, new EventArgs());
		}
	}
}
