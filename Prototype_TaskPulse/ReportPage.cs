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
	public partial class ReportPage : UserControl
	{
		public ReportPage()
		{
			InitializeComponent();
		}
		List<Hours> HoursOfActivities = new List<Hours>();

		private void ReportPage_Load(object sender, EventArgs e)
		{
			this.Padding = new System.Windows.Forms.Padding(10);
		}

		private void AddHour_Click(object sender, EventArgs e)
		{
			Hours Activity = new Hours();
			Activity.HourName = cmbxHourName.Text;
			Activity.HourLong = Convert.ToInt16(niHourLong.Text);
			HoursOfActivities.Add(Activity);
			showActivities();
		}
		void showActivities()
		{
			HoursPanel.Controls.Clear();
            foreach (var item in HoursOfActivities)
            {
                Label ActivityName = new Label();
				Button ActivityDelete = new Button();
				Panel ActivityPanel = new Panel();
				ActivityPanel.Height = ActivityName.Height;
				ActivityPanel.Width = HoursPanel.Width;
				ActivityName.Width = ActivityPanel.Width/2;

				ActivityName.Text = item.HourName + " : " + item.HourLong;
				ActivityDelete.Text = "sil";

				ActivityPanel.Controls.Add(ActivityName);
				ActivityPanel.Controls.Add(ActivityDelete);

				HoursPanel.Controls.Add(ActivityPanel);

            }
            
		}
	}
}
