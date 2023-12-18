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
			//Sayfa açıldığında loading screen göster
			loadScreen();
			
			taskDetailsPanel.Visible = false;
			formatData();

			//yükleme işlemleri bittikten sonra loading screen gizle
			loadingScreen.Visible = false;
		}

		//Main Page sayfası başlatılırken yükleme görsellerini saklamak için LoadingScreen nesnesini çağır.
		public void loadScreen()
		{
			this.Controls.Add(loadingScreen);
			loadingScreen.Dock = DockStyle.Fill;
			loadingScreen.Visible = true;
		}
		LoadingScreen loadingScreen = new LoadingScreen();
		DateTime dateTimeToday = DateTime.Today;
		public void formatData()
		{
			
			setPlansForMainPage();
			dataGridView1.Rows.Clear();
			int i=0;
			foreach (PlanClass p in plans)
			{
				dataGridView1.Rows.Add(p.PlanName,  p.PlanDecription, p.PlanId.ToString());
				if(p.PlanDegree == 6)
				{
					dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0,153,0);
					dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.White;
				}
				if (p.PlanDegree == 5)
				{
					dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51,255,51);
					dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
				}
				if (p.PlanDegree == 4)
				{
					dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(102, 255, 178);
					dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 102, 102);
				}
				if (p.PlanDegree == 3)
				{
					dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
					dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
				}
				if (p.PlanDegree == 2)
				{
					dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(153, 204, 255);
					dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 153);
				}
				if (p.PlanDegree == 1)
				{
					dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(51, 153, 255);
					dataGridView1.Rows[i].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(204, 229, 255);
				}
				i++;
				//Çok Önemli  : 6
				//Önemli	  : 5
				//Az Önemli   : 4
				//Normal      : 3
				//Az Öncelikli: 2
				//Önemsiz     : 1
			}
		}
		public void setPlansForMainPage()
		{
			plans = database.SortPlans(database.GetPlans());
			plans = plans.Where (p => ((p.PlanType == "Haftalık Tekrarlı") && 
								(p.PlanDate.ToString("dddd") == dateTimeToday.ToString("dddd")) && (p.PlanDate.Date <= dateTimeToday.Date)) || 
								(p.PlanDate.Date == dateTimeToday.Date)).ToList();


		/**
		Haftalık Tekrarlı
		Aylık Tekrarlı
		Yıllık Tekrarlı
		Tek seferlik
		*/
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
