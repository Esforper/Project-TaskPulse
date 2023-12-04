using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Prototype_TaskPulse
{
	internal class Database
	{
		// veri tabanı için dosya yolu ve isim ayarlama
		private const string veritabaniDosyaAdi = "veritabani.txt";
		static string belgeKlasoru = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		string dosyaYolu = Path.Combine(belgeKlasoru, veritabaniDosyaAdi);

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

		//planı database ye kaydet
		public void savePlan(string planName, string planDescription, DateTime planDate, int planDegree, string planType, DateTime PlanCreationDate)
		{
			int newPlanID = setId();
			
			//en yüksek id değerini setId fonksiyonu ile verip database ye kaydediyor
			string text = newPlanID + "</>" + planName + "</>" + planDescription + "</>" + planDate.ToString("d") + "</>" + planDegree + "</>" + planType + "</>" + PlanCreationDate.ToString("d");

			using (StreamWriter writer = new StreamWriter(dosyaYolu, true))
			{
				writer.WriteLine(text);
			}
		}

		/**
		 * NOT: Database nesnesi için bir constructor gerekecek çünkü bazı değerleri doldurmak için o fonksiyonların çalışması lazım.
		 */

		//son satırı tespit edip ondan öncekileri okumamak için.
		protected string lastSatir;

		public List<PlanClass> getPlans()
		{
			using (StreamReader SW = new StreamReader(dosyaYolu))
			{
				string satir = "";
				int flag = 0;

				if (plans.Count == 0)
				{
					while ((satir = SW.ReadLine()) != null)
					{
						lastSatir = satir;
						PlanClass plan = new PlanClass();

						char[] ayrac = "<N/>".ToCharArray();
						string[] _satir = satir.Split(ayrac, StringSplitOptions.None);
						int a = _satir.Length;
						if (_satir.Length >= 6)
						{
							DateTime _planDate = Convert.ToDateTime(_satir[9]);
							DateTime _planCreationDate = Convert.ToDateTime(_satir[18]);
							plan.setPlan(int.Parse(_satir[0]), _satir[3], _satir[6], _planDate, int.Parse(_satir[12]), _satir[15], _planCreationDate);

							plans.Add(plan);
							Ids.Add(plan.getPlanId());
						}
					}
				}
				else
				{
					while ((satir = SW.ReadLine()) != null)
					{

						if (satir != lastSatir && flag == 0)
						{
							continue;
						}
						if (satir == lastSatir)
						{
							flag = 1;
							continue;
						}
						lastSatir = satir;
						PlanClass plan = new PlanClass();

						char[] ayrac = "<N/>".ToCharArray();
						string[] _satir = satir.Split(ayrac, StringSplitOptions.None);
						int a = _satir.Length;
						if (_satir.Length >= 6)
						{
							DateTime _planDate = Convert.ToDateTime(_satir[9]);
							DateTime _planCreationDate = Convert.ToDateTime(_satir[18]);
							plan.setPlan(int.Parse(_satir[0]), _satir[3], _satir[6], _planDate, int.Parse(_satir[12]), _satir[15], _planCreationDate);

							plans.Add(plan);

							Ids.Add(plan.getPlanId());
						}
					}
				}
			}


			return sortPlans(plans);
		}

		public int setId()
		{
			int id;
			if (Ids.Count == 0)
			{
				id = 1;
			}
			else
			{
				id = Ids.Max() + 1;
			}

			Ids.Add(id);
			return id;
		}





		public List<PlanClass> sortPlans(List<PlanClass> plans)
		{
			return plans.OrderBy(p => p.getPlanDate()).ThenBy(p => p.getPlanCreationDate()).ToList();

		}

		public PlanClass getOnePlan(DateTime planCreationTime)
		{
			PlanClass onePlan = new PlanClass();
			onePlan = plans.Where(p => p.getPlanCreationDate() == planCreationTime).First();
			return onePlan;
		}
		public PlanClass getOnePlan(string planName, DateTime planDate, int planDegree, string planType)
		{
			PlanClass onePlan = new PlanClass();
			onePlan = plans.Where(p => p.getPlanName() == planName && p.getPlanDate() == planDate && p.getPlanDegree() == planDegree && p.getPlanType() == planType).First();
			return onePlan;
		}
		public PlanClass getOnePlan(int id)
		{
			PlanClass onePlan = new PlanClass();
			onePlan = plans.Where(p => p.getPlanId() == id).First();
			return onePlan;
		}
	}
}

