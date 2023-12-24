using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_TaskPulse
{
	public partial class CalendarMenu : UserControl
	{
		public CalendarMenu()
		{
			InitializeComponent();
		}
		int month, year;
		private void CalendarMenu_Load(object sender, EventArgs e)
		{
			displayDays();
		}
		public void displayDays()
		{
			DateTime now = DateTime.Now;
			month=now.Month;
			year=now.Year;
			String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
			LblMonthDate.Text = monthname + " " + year;
			DateTime startofthemonth = new DateTime(now.Year,now.Month,1);

			int days = DateTime.DaysInMonth(now.Year,now.Month);
			int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))-1;
			string str = startofthemonth.DayOfWeek.ToString("d");
			//days = o aydaki gün sayısı
			//dayoftheweek = salı ise 2 gibi, cuma = 5
			//toplamda 42 gün var, 7 ye bölünce tam sayı satır, kalan sütun değeri.
			int calendarDayNumber = 0;
			for (int i=dayoftheweek;i<dayoftheweek+days;i++)
			{

				calendarDayNumber++;
				int row = i / 7;
				int colomb = i% 7;
				CalendarDay _day = new CalendarDay();
				_day.label.Text = calendarDayNumber.ToString();
				tableLayoutPanel1.Controls.Add(_day,colomb,row+1);
				_day.Dock = DockStyle.Fill;
				
			}

		}
	}
}
