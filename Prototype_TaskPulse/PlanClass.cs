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
		protected int PlanId;
		protected string PlanName;
		protected string PlanDecription;
		protected DateTime PlanDate;
		protected int PlanDegree;
		protected string PlanType;
		protected bool error;
		protected DateTime PlanCreationDate;
		

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

		//--- get ---
		public bool geterror() { return error; }
		public string getPlanName() { return PlanName; }
		public string getPlanDecription() {  return PlanDecription; }
		public DateTime getPlanDate() {  return PlanDate; }
		public int getPlanDegree() {  return PlanDegree; }
		public string getPlanType() {  return PlanType; }
		public DateTime getPlanCreationDate() {  return PlanCreationDate; }
		public int getPlanId() { return PlanId; }
		//--- set ---
		public void setPlanName(string planName ) { PlanName = planName; }
		public void setPlanDecription(string planDecription) { PlanDecription = planDecription; }
		public void setPlanDate(DateTime planDate) { PlanDate = planDate; }
		public void setPlanDegree(int planDegree) { PlanDegree = planDegree; }
		public void setPlanType(string planType) { PlanType = planType; }
		public void setPlanCreationDate(DateTime planCreationDate) { PlanCreationDate = planCreationDate; }
		public void setPlanId(int planId) {  PlanId = planId; }
		//--- --- ---

		public void savePlan()
		{
			Database database = new Database();
			database.savePlan(PlanName, PlanDecription, PlanDate, PlanDegree, PlanType, PlanCreationDate);
		}
		


	}
}
