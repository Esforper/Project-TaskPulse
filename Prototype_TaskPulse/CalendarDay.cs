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
	public partial class CalendarDay : UserControl
	{
		public CalendarDay()
		{
			InitializeComponent();
			label1.Text = Convert.ToString(day);
			label = label1;
		}
		private void CalendarDay_Load(object sender, EventArgs e)
		{

		}
		public Label label;
		public int day;

	}
}
