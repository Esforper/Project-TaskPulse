using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_TaskPulse
{
	internal class ReportClass
	{
		public string ReportType;
		public string ReportName;
		public DateTime ReportDate;
		public short ReportPuan;
		public string ReportDescription;

		public List<Hours> ReportAllHours;
		
	}
	class Hours
	{
		public string HourName;
		public short HourLong;
	}
}
