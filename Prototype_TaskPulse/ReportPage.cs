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
		//Gün içi yapılan saatleri ve activiteler için bir liste oluştur
		List<Hours> HoursOfActivities = new List<Hours>();

		private void ReportPage_Load(object sender, EventArgs e)
		{
			//bu sayfa açılınca yanlardan 10 padding ekle
			this.Padding = new System.Windows.Forms.Padding(10);
		}

		private void AddHour_Click(object sender, EventArgs e)
		{
			//aktivitelerin kaydedileceği listeye aktiviteyi kaydet
			Hours Activity = new Hours();
			Activity.HourName = cmbxHourName.Text;
			Activity.HourLong = Convert.ToInt16(niHourLong.Text);
			HoursOfActivities.Add(Activity);

			//Aktiviteyi formda göster
			showActivities();
		}
		void showActivities()
		{
			HoursPanel.Controls.Clear();
            foreach (var item in HoursOfActivities)
            {
				//bir label, buton ve panel oluştur
                Label ActivityName = new Label();
				Button ActivityDelete = new Button();
				Panel ActivityPanel = new Panel();

				//panel ve label width değerini ayarla
				ActivityPanel.Height = ActivityName.Height;
				ActivityPanel.Width = HoursPanel.Width;
				ActivityName.Width = ActivityPanel.Width/2;

				//activity labelinin text değerini ayarla
				ActivityName.Text = item.HourName + " : " + item.HourLong;
				ActivityDelete.Text = "sil";

				//nesnelerini birbiriyle bağdaştır
				ActivityPanel.Controls.Add(ActivityName);
				ActivityPanel.Controls.Add(ActivityDelete);
				HoursPanel.Controls.Add(ActivityPanel);

            }
            
		}
	}
}
