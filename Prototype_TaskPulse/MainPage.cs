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
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();
		}
		List<PlanClass> plans = new List<PlanClass>();  //planların tümü
		Database database = new Database();
		int selectedRowId;

		private void MainPage_Load(object sender, EventArgs e)
		{
			taskDetailsPanel.Visible = false;
			formatData();

		}
		public void formatData()
		{
			DateTime dateTimeToday = DateTime.Today;
			plans = database.SortPlans(database.GetPlans());
			plans = plans.Where(p => p.PlanDate >= dateTimeToday).ToList();
			dataGridView1.Rows.Clear();

			foreach (PlanClass p in plans)
			{
				dataGridView1.Rows.Add(p.PlanName,  p.PlanDecription, p.PlanId.ToString());
			}
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			PlanClass onePlan = new PlanClass();
			//-1 indexli satır veya sütun seçilmesini engelle
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				//dataGridView den seçili satır seçiliyor.
				DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
				if (e.ColumnIndex < selectedRow.Cells.Count)
				{
					//seçilen hücrenin boş olup olmadığını kontrol et
					DataGridViewCell selectedCell = selectedRow.Cells[e.ColumnIndex];
					if (selectedCell.Value != null)
					{
						selectedRowId = Convert.ToInt32(selectedRow.Cells[2].Value);
						onePlan = database.getOnePlan(selectedRowId);

						txtbxPlanName.Text = onePlan.PlanName;
						txtbxPlanDescription.Text = onePlan.PlanDecription;
						txtbxPlanDegree.Text = PlanDegreeReverseFunc(onePlan.PlanDegree);
						txtbxPlanType.Text = onePlan.PlanType;
					}
				}
			}
			taskDetailsPanel.Visible = true;
		}
		public int PlanDegreeFunc(string degreeName)
		{
			if (degreeName == "Çok Önemli") { return 6; }
			else if (degreeName == "Önemli") { return 5; }
			else if (degreeName == "Az Önemli") { return 4; }
			else if (degreeName == "Normal") { return 3; }
			else if (degreeName == "Az Öncelikli") { return 2; }
			else { return 1; }
		}
		public string PlanDegreeReverseFunc(int planDegree)
		{
			//plan degree değerine göre yazı çıkarıyor (veri -> bilgi)
			string degreeName = "hata";
			if (planDegree == 1) { degreeName = "Önemsiz"; }
			else if (planDegree == 2) { degreeName = "Az Öncelikli"; }
			else if (planDegree == 3) { degreeName = "Normal"; }
			else if (planDegree == 4) { degreeName = "Az Önemli"; }
			else if (planDegree == 5) { degreeName = "Önemli"; }
			else if (planDegree == 6) { degreeName = "Çok Önemli"; }
			return degreeName;
		}

		private void dataGridView1_Click(object sender, EventArgs e)
		{
			taskDetailsPanel.Visible = false;
		}
	}
}
