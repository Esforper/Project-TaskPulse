using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_TaskPulse
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			mainPanel.Controls.Clear();
			MainPage mainPage = new MainPage();
			mainPanel.Controls.Add(mainPage);
			mainPage.Dock = DockStyle.Fill;
			mainPage.BringToFront();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			mainPanel.Controls.Clear();
			DailyPlan dailyPlan = new DailyPlan();
			mainPanel.Controls.Add(dailyPlan);
			dailyPlan.Dock = DockStyle.Fill;
			dailyPlan.BringToFront();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			mainPanel.Controls.Clear();
			ReportPage reportPage = new ReportPage();
			mainPanel.Controls.Add(reportPage);
			reportPage.Dock = DockStyle.Fill;
			reportPage.BringToFront();
		}

		private void btnMainPage_Click(object sender, EventArgs e)
		{
			mainPanel.Controls.Clear();
			MainPage mainPage = new MainPage();
			mainPanel.Controls.Add(mainPage);
			mainPage.Dock = DockStyle.Fill;
			mainPage.BringToFront();
		}
	}
}
