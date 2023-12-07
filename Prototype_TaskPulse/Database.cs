using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Prototype_TaskPulse
{
	internal class Database
	{
		// veri tabanı için dosya yolu ve isim ayarlama
		private const string veritabaniDosyaAdi = "veritabani.json";
		static string belgeKlasoru = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		string dosyaYolu = Path.Combine(belgeKlasoru, veritabaniDosyaAdi);

		//planları depolamak için plans listesi, plan id değerlerini tutmak için id listesi oluştur
		static List<int> Ids = new List<int>();
		static List<PlanClass> plans = new List<PlanClass>();

		public Database()
		{
			//database nesnesi oluşturulduğunda başta dosyayı kontrol et.
			if (!File.Exists(dosyaYolu))
			{
				File.Create(dosyaYolu).Close();
			}
		}
		private void SavePlansToJson()
		{
			string json = JsonConvert.SerializeObject(plans);
			File.WriteAllText(dosyaYolu, json);
		}
		private void LoadPlansFromJson()
		{
			string json = File.ReadAllText(dosyaYolu);

			if (!string.IsNullOrEmpty(json))
			{
				plans = JsonConvert.DeserializeObject<List<PlanClass>>(json) ?? new List<PlanClass>();
				Ids = plans.Select(p => p.PlanId).ToList();
			}
		}

		//planı database ye kaydet
		public void SavePlan(string planName, string planDescription, DateTime planDate, int planDegree, string planType, DateTime planCreationDate)
		{
			int newPlanID = SetId();
			PlanClass newPlan = new PlanClass();
			newPlan.setPlan(newPlanID,planName,planDescription,planDate,planDegree,planType,planCreationDate);

			plans.Add(newPlan);
			SavePlansToJson();
		}

		/**
		 * NOT: Database nesnesi için bir constructor gerekecek çünkü bazı değerleri doldurmak için o fonksiyonların çalışması lazım.
		 */

		//son satırı tespit edip ondan öncekileri okumamak için.
		protected string lastSatir;

		public List<PlanClass> GetPlans()
		{
			LoadPlansFromJson();
			return SortPlans(plans);
		}

		private int SetId()
		{
			int id = Ids.Count == 0 ? 1 : Ids.Max() + 1;
			Ids.Add(id);
			return id;
		}

		public List<PlanClass> SortPlans(List<PlanClass> plans)
		{
			return plans.OrderBy(p => p.PlanDate).ThenBy(p => p.PlanCreationDate).ToList();
		}

		public PlanClass getOnePlan(DateTime planCreationTime)
		{
			PlanClass onePlan = new PlanClass();
			onePlan = plans.Where(p => p.PlanCreationDate == planCreationTime).First();
			return onePlan;
		}
		public PlanClass getOnePlan(string planName, DateTime planDate, int planDegree, string planType)
		{
			PlanClass onePlan = new PlanClass();
			onePlan = plans.Where(p => p.PlanName == planName && p.PlanDate == planDate && p.PlanDegree == planDegree && p.PlanType == planType).First();
			return onePlan;
		}
		public PlanClass getOnePlan(int id)
		{
			PlanClass onePlan = new PlanClass();
			onePlan = plans.Where(p => p.PlanId == id).First();
			return onePlan;
		}

		public void DeletePlan(int planId)
		{
			plans.RemoveAll(p => p.PlanId == planId);
			SavePlansToJson();
		}

		public void UpdateSelectedPlan(int planId, string planName, string planDescription, DateTime planDate, int planDegree, string planType, DateTime planCreationDate)
		{
			PlanClass updatedPlan = plans.FirstOrDefault(p => p.PlanId == planId);
			
			if (updatedPlan != null)
			{
				updatedPlan.setPlan(planId, planName, planDescription, planDate, planDegree, planType, planCreationDate);
				SavePlansToJson();
			}
			else
			{
				MessageBox.Show("Plan Bulunamadı");
			}
		}

	}
}

