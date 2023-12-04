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
	public partial class DailyPlan : UserControl
	{
		public DailyPlan()
		{
			InitializeComponent();
		}

		List<PlanClass> plans = new List<PlanClass>();	//planların tümü
		Database database = new Database();

		private void addPlan_Click(object sender, EventArgs e)
		{
			PlanClass plan = new PlanClass();
			//plan nesnesinin içeriğini verilerle doldur.
			plan.addPlan(textBoxPlanName.Text, richTextBoxPlanDescription.Text, dateTimePickerPlanDate.Value, PlanDegreeFunc(comboBoxPlanDegree), comboBoxPlanType.Text);
			//herhangi bir yer boşsa error ver
			if (plan.geterror() == true) { labelError.Visible = true; }else { labelError.Visible = false; }
			
			updateDataGrid();
		}
		public bool checkBoxValue(CheckBox checkBox)
		{
			//checkbox durumuna göre çıktı veriyor.
			if(checkBox.Checked == true) { return true; }
			else { return false; }
		}
		public int PlanDegreeFunc(ComboBox comboBoxPlanDegree)
		{
			//seçilen duruma göre veriyi giriyor.
			if(comboBoxPlanDegree.SelectedIndex == 0) {  return 6; }
			else if(comboBoxPlanDegree.SelectedIndex == 1) { return 5; }
			else if (comboBoxPlanDegree.SelectedIndex == 2) { return 4; }
			else if (comboBoxPlanDegree.SelectedIndex == 3) { return 3; }
			else if (comboBoxPlanDegree.SelectedIndex == 4) { return 2; }
			else { return 1; }

			//Çok Önemli  : 6
			//Önemli	  : 5
			//Az Önemli   : 4
			//Normal      : 3
			//Az Öncelikli: 2
			//Önemsiz     : 1
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



		private void DailyPlan_Load(object sender, EventArgs e)
		{
			formClear();
			gridAyari();
			cmbxFiltDataGrid.SelectedIndex = 0;
			updateDataGrid();
			
		}

		void updateDataGrid()
		{
			
			plans = database.sortPlans(database.getPlans());
			dataGridView1.Rows.Clear();

			DateTime oneMonthLater = DateTime.Now.AddMonths(1);
			DateTime now = DateTime.Now;
			if (cmbxFiltDataGrid.SelectedIndex == 0)
			{
				plans = plans.Where(p => p.getPlanDate() < oneMonthLater && p.getPlanDate() > now).ToList();
			}
			else if(cmbxFiltDataGrid.SelectedIndex == 1)
			{
				plans = plans.Where(p => p.getPlanDate() > now).ToList();
			}
			foreach (PlanClass p in plans)
			{
				dataGridView1.Rows.Add(p.getPlanName(), p.getPlanDate().ToString("D"), PlanDegreeReverseFunc(p.getPlanDegree()), p.getPlanType() , p.getPlanId().ToString());
			}
		}

		void gridAyari()
		{
			dataGridView1.ReadOnly = true; // sadece okunabilir olması yani veri düzenleme kapalı
			dataGridView1.AllowUserToDeleteRows = false; // satırların silinmesi engelleniyor
			dataGridView1.ColumnCount = 5; //Kaç kolon olacağı belirleniyor…
			dataGridView1.Columns[0].Name = "Name";//Kolonların adı belirleniyor
			dataGridView1.Columns[1].Name = "Date";
			dataGridView1.Columns[2].Name = "Degree";
			dataGridView1.Columns[3].Name = "Type";
			dataGridView1.Columns[4].Name = "Id";
			dataGridView1.Columns[0].Width = dataGridView1.Width/4;
			dataGridView1.Columns[1].Width = dataGridView1.Width / 4; //belirlenen kolonların genişliği ayarlanıyor
			dataGridView1.Columns[2].Width = dataGridView1.Width / 4;
			dataGridView1.Columns[3].Width = dataGridView1.Width / 4;
			dataGridView1.Columns[4].Width = 0;
		}

		private void dataGridView1_SizeChanged(object sender, EventArgs e)
		{
			gridAyari();
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
						onePlan = database.getOnePlan(Convert.ToInt32 ( selectedRow.Cells[4].Value));

						//plan ile ilgili değerleri tabloya doldur
						textBoxPlanName.Text = onePlan.getPlanName();
						richTextBoxPlanDescription.Text = onePlan.getPlanDecription();
						dateTimePickerPlanDate.Value = onePlan.getPlanDate();
						comboBoxPlanDegree.Text = PlanDegreeReverseFunc(onePlan.getPlanDegree());
						comboBoxPlanType.Text = onePlan.getPlanType();

					}
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
		}

		private void cmbxFiltDataGrid_SelectedValueChanged(object sender, EventArgs e)
		{
			updateDataGrid();
		}

		private void btnformClear_Click(object sender, EventArgs e)
		{
			formClear();

		}
		public void formClear()
		{
			textBoxPlanName.Clear();
			richTextBoxPlanDescription.Clear();
			comboBoxPlanDegree.SelectedIndex = 3;
			comboBoxPlanType.SelectedIndex = 3;
			dateTimePickerPlanDate.Value = DateTime.Now;

		}

		private void btnDeletePlan_Click(object sender, EventArgs e)
		{

		}
	}
}
/**
 * Geliştirilme süreci adımlar
 * 
 * Plan Ekleme + Database
 * plan seçme
 * planları sıralama
 * 
 * Plan Düzenleme
 * Tekrarlı Plan Mekaniği
 *	Tekrarlı Plan Düzenleme
 * Plan silme
 *	Tekrarlı Plan silme 
 * 
 * 
 */
