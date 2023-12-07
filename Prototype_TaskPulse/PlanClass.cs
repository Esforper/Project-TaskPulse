using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_TaskPulse
{
	internal class PlanClass
	{
		public int PlanId;
		public string PlanName;
		public string PlanDecription;
		public DateTime PlanDate;
		public int PlanDegree;
		public string PlanType;
		public bool error;
		public DateTime PlanCreationDate;
		

		//yeni plan oluşturulduğu zaman kaydetmeye yarıyor
		public void addPlan(String planName,String planDecription, DateTime planDate, int planDegree, string planType) {
			 if(planName != null || planDecription != null || planDate!=null || planDegree!=null || planType!=null) {
				PlanName = planName;
				PlanDecription = planDecription;
				PlanDate = planDate;
				PlanDegree = planDegree;
				PlanType = planType;
				PlanCreationDate = DateTime.Now;
				error = false;
			}
			else{ error = true;	}

			savePlan();
		}

		//id değerini de çekebilmek için
		public void setPlan(int id,String planName, String planDecription, DateTime planDate, int planDegree, string planType, DateTime planCreationDate)
		{
			if (id != null || planName != null || planDecription != null || planDate != null || planDegree != null || planType != null || planCreationDate != null)
			{
				PlanId = id;
				PlanName = planName;
				PlanDecription = planDecription;
				PlanDate = planDate;
				PlanDegree = planDegree;
				PlanType = planType;
				PlanCreationDate = planCreationDate;
				error = false;
			}
			else { error = true; }
		}

		public void savePlan()
		{
			Database database = new Database();
			database.SavePlan(PlanName, PlanDecription, PlanDate, PlanDegree, PlanType, PlanCreationDate);
		}
		


	}
}
