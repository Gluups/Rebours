namespace Rebours
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.nudHeures = new System.Windows.Forms.NumericUpDown();
			this.nudMinutes = new System.Windows.Forms.NumericUpDown();
			this.nudSecondes = new System.Windows.Forms.NumericUpDown();
			this.btnStart = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblDiff = new System.Windows.Forms.Label();
			this.lblTimeStart = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.btnStop = new System.Windows.Forms.Button();
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.chkTimeTitle = new System.Windows.Forms.CheckBox();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn10 = new System.Windows.Forms.Button();
			this.btn40 = new System.Windows.Forms.Button();
			this.btn20mn = new System.Windows.Forms.Button();
			this.btn15mn = new System.Windows.Forms.Button();
			this.btn45mn = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn30mn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudHeures)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSecondes)).BeginInit();
			this.SuspendLayout();
			// 
			// nudHeures
			// 
			this.nudHeures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudHeures.Location = new System.Drawing.Point(37, 90);
			this.nudHeures.Name = "nudHeures";
			this.nudHeures.Size = new System.Drawing.Size(65, 30);
			this.nudHeures.TabIndex = 0;
			this.nudHeures.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// nudMinutes
			// 
			this.nudMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudMinutes.Location = new System.Drawing.Point(118, 90);
			this.nudMinutes.Name = "nudMinutes";
			this.nudMinutes.Size = new System.Drawing.Size(65, 30);
			this.nudMinutes.TabIndex = 1;
			this.nudMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// nudSecondes
			// 
			this.nudSecondes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nudSecondes.Location = new System.Drawing.Point(200, 90);
			this.nudSecondes.Name = "nudSecondes";
			this.nudSecondes.Size = new System.Drawing.Size(65, 30);
			this.nudSecondes.TabIndex = 2;
			this.nudSecondes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(290, 86);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 34);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblDiff
			// 
			this.lblDiff.AutoSize = true;
			this.lblDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDiff.Location = new System.Drawing.Point(51, 265);
			this.lblDiff.Name = "lblDiff";
			this.lblDiff.Size = new System.Drawing.Size(37, 40);
			this.lblDiff.TabIndex = 15;
			this.lblDiff.Text = "_";
			// 
			// lblTimeStart
			// 
			this.lblTimeStart.AutoSize = true;
			this.lblTimeStart.Location = new System.Drawing.Point(51, 153);
			this.lblTimeStart.Name = "lblTimeStart";
			this.lblTimeStart.Size = new System.Drawing.Size(18, 20);
			this.lblTimeStart.TabIndex = 13;
			this.lblTimeStart.Text = "_";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(51, 222);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(18, 20);
			this.lblTime.TabIndex = 14;
			this.lblTime.Text = "_";
			// 
			// timer2
			// 
			this.timer2.Interval = 5000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(682, 26);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 31);
			this.btnStop.TabIndex = 17;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Visible = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// timer3
			// 
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// chkTimeTitle
			// 
			this.chkTimeTitle.AutoSize = true;
			this.chkTimeTitle.Checked = true;
			this.chkTimeTitle.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTimeTitle.Location = new System.Drawing.Point(355, 446);
			this.chkTimeTitle.Name = "chkTimeTitle";
			this.chkTimeTitle.Size = new System.Drawing.Size(311, 24);
			this.chkTimeTitle.TabIndex = 16;
			this.chkTimeTitle.Text = "Compte à rebours dans la barre de titre";
			this.chkTimeTitle.UseVisualStyleBackColor = true;
			this.chkTimeTitle.CheckedChanged += new System.EventHandler(this.chkTimeTitle_CheckedChanged);
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(630, 355);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(75, 32);
			this.btn3.TabIndex = 12;
			this.btn3.Text = "3 mn";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// btn6
			// 
			this.btn6.Location = new System.Drawing.Point(630, 285);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(75, 32);
			this.btn6.TabIndex = 10;
			this.btn6.Text = "6 mn";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.btn6_Click);
			// 
			// btn10
			// 
			this.btn10.Location = new System.Drawing.Point(630, 251);
			this.btn10.Name = "btn10";
			this.btn10.Size = new System.Drawing.Size(75, 32);
			this.btn10.TabIndex = 9;
			this.btn10.Text = "10 mn";
			this.btn10.UseVisualStyleBackColor = true;
			this.btn10.Click += new System.EventHandler(this.btn10_Click);
			// 
			// btn40
			// 
			this.btn40.Location = new System.Drawing.Point(630, 110);
			this.btn40.Name = "btn40";
			this.btn40.Size = new System.Drawing.Size(75, 29);
			this.btn40.TabIndex = 5;
			this.btn40.Text = "40mn";
			this.btn40.UseVisualStyleBackColor = true;
			this.btn40.Click += new System.EventHandler(this.btn40_Click);
			// 
			// btn20mn
			// 
			this.btn20mn.Location = new System.Drawing.Point(630, 178);
			this.btn20mn.Name = "btn20mn";
			this.btn20mn.Size = new System.Drawing.Size(75, 32);
			this.btn20mn.TabIndex = 7;
			this.btn20mn.Text = "20mn";
			this.btn20mn.UseVisualStyleBackColor = true;
			this.btn20mn.Click += new System.EventHandler(this.btn20mn_Click);
			// 
			// btn15mn
			// 
			this.btn15mn.Location = new System.Drawing.Point(630, 215);
			this.btn15mn.Name = "btn15mn";
			this.btn15mn.Size = new System.Drawing.Size(75, 32);
			this.btn15mn.TabIndex = 8;
			this.btn15mn.Text = "15 mn";
			this.btn15mn.UseVisualStyleBackColor = true;
			this.btn15mn.Click += new System.EventHandler(this.btn15mn_Click);
			// 
			// btn45mn
			// 
			this.btn45mn.Location = new System.Drawing.Point(630, 75);
			this.btn45mn.Name = "btn45mn";
			this.btn45mn.Size = new System.Drawing.Size(75, 29);
			this.btn45mn.TabIndex = 4;
			this.btn45mn.Text = "45 mn";
			this.btn45mn.UseVisualStyleBackColor = true;
			this.btn45mn.Click += new System.EventHandler(this.btn45mn_Click);
			// 
			// btn5
			// 
			this.btn5.Location = new System.Drawing.Point(630, 320);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(75, 32);
			this.btn5.TabIndex = 11;
			this.btn5.Text = "5 mn";
			this.btn5.UseVisualStyleBackColor = true;
			this.btn5.Click += new System.EventHandler(this.btn5_Click);
			// 
			// btn30mn
			// 
			this.btn30mn.Location = new System.Drawing.Point(630, 144);
			this.btn30mn.Name = "btn30mn";
			this.btn30mn.Size = new System.Drawing.Size(75, 29);
			this.btn30mn.TabIndex = 6;
			this.btn30mn.Text = "30mn";
			this.btn30mn.UseVisualStyleBackColor = true;
			this.btn30mn.Click += new System.EventHandler(this.btn30mn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 509);
			this.Controls.Add(this.btn30mn);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn45mn);
			this.Controls.Add(this.btn15mn);
			this.Controls.Add(this.btn20mn);
			this.Controls.Add(this.btn40);
			this.Controls.Add(this.btn10);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.chkTimeTitle);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.lblTimeStart);
			this.Controls.Add(this.lblDiff);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.nudSecondes);
			this.Controls.Add(this.nudMinutes);
			this.Controls.Add(this.nudHeures);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Compte à rebours";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudHeures)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSecondes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.NumericUpDown nudHeures;
		private System.Windows.Forms.NumericUpDown nudMinutes;
		private System.Windows.Forms.NumericUpDown nudSecondes;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblDiff;
		private System.Windows.Forms.Label lblTimeStart;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.CheckBox chkTimeTitle;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn10;
		private System.Windows.Forms.Button btn40;
		private System.Windows.Forms.Button btn20mn;
		private System.Windows.Forms.Button btn15mn;
		private System.Windows.Forms.Button btn45mn;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn30mn;
	}
}

