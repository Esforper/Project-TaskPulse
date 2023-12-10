namespace Prototype_TaskPulse
{
	partial class ReportPage
	{
		/// <summary> 
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Bileşen Tasarımcısı üretimi kod

		/// <summary> 
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.HoursPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.cmbxHourName = new System.Windows.Forms.ComboBox();
			this.btnAddHour = new System.Windows.Forms.Button();
			this.niHourLong = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.cmbxReportType = new System.Windows.Forms.ComboBox();
			this.rtxbxReportDescription = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtbxReportName = new System.Windows.Forms.TextBox();
			this.niReportPuan = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpickReportDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label15 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.niHourLong)).BeginInit();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.niReportPuan)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1131, 77);
			this.label1.TabIndex = 0;
			this.label1.Text = "Report System";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel7);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 77);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(465, 567);
			this.panel1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.HoursPanel);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 290);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
			this.panel4.Size = new System.Drawing.Size(465, 277);
			this.panel4.TabIndex = 1;
			// 
			// HoursPanel
			// 
			this.HoursPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HoursPanel.Location = new System.Drawing.Point(0, 79);
			this.HoursPanel.Name = "HoursPanel";
			this.HoursPanel.Padding = new System.Windows.Forms.Padding(20, 2, 20, 20);
			this.HoursPanel.Size = new System.Drawing.Size(465, 178);
			this.HoursPanel.TabIndex = 10;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.cmbxHourName);
			this.panel6.Controls.Add(this.btnAddHour);
			this.panel6.Controls.Add(this.niHourLong);
			this.panel6.Controls.Add(this.label7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 20, 0);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new System.Windows.Forms.Padding(10, 10, 40, 5);
			this.panel6.Size = new System.Drawing.Size(465, 79);
			this.panel6.TabIndex = 9;
			// 
			// cmbxHourName
			// 
			this.cmbxHourName.Dock = System.Windows.Forms.DockStyle.Left;
			this.cmbxHourName.FormattingEnabled = true;
			this.cmbxHourName.Items.AddRange(new object[] {
            "Ders",
            "Kulüp",
            "Kişisel Proje",
            "Öğrenme",
            "Spor",
            "Kendini Geliştirme",
            "Uyku"});
			this.cmbxHourName.Location = new System.Drawing.Point(10, 33);
			this.cmbxHourName.Name = "cmbxHourName";
			this.cmbxHourName.Size = new System.Drawing.Size(247, 33);
			this.cmbxHourName.TabIndex = 11;
			// 
			// btnAddHour
			// 
			this.btnAddHour.Location = new System.Drawing.Point(347, 32);
			this.btnAddHour.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
			this.btnAddHour.Name = "btnAddHour";
			this.btnAddHour.Size = new System.Drawing.Size(91, 37);
			this.btnAddHour.TabIndex = 10;
			this.btnAddHour.Text = "Add";
			this.btnAddHour.UseVisualStyleBackColor = true;
			this.btnAddHour.Click += new System.EventHandler(this.AddHour_Click);
			// 
			// niHourLong
			// 
			this.niHourLong.Location = new System.Drawing.Point(263, 36);
			this.niHourLong.Name = "niHourLong";
			this.niHourLong.Size = new System.Drawing.Size(74, 30);
			this.niHourLong.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Top;
			this.label7.Location = new System.Drawing.Point(10, 10);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(415, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "Harcanan Saat";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.cmbxReportType);
			this.panel7.Controls.Add(this.rtxbxReportDescription);
			this.panel7.Controls.Add(this.label6);
			this.panel7.Controls.Add(this.label4);
			this.panel7.Controls.Add(this.txtbxReportName);
			this.panel7.Controls.Add(this.niReportPuan);
			this.panel7.Controls.Add(this.label5);
			this.panel7.Controls.Add(this.label2);
			this.panel7.Controls.Add(this.dtpickReportDate);
			this.panel7.Controls.Add(this.label3);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(465, 290);
			this.panel7.TabIndex = 1;
			// 
			// cmbxReportType
			// 
			this.cmbxReportType.FormattingEnabled = true;
			this.cmbxReportType.Items.AddRange(new object[] {
            "Günlük Rapor",
            "Haftalık Rapor",
            "Aylık Rapor"});
			this.cmbxReportType.Location = new System.Drawing.Point(154, 13);
			this.cmbxReportType.Name = "cmbxReportType";
			this.cmbxReportType.Size = new System.Drawing.Size(183, 33);
			this.cmbxReportType.TabIndex = 5;
			// 
			// rtxbxReportDescription
			// 
			this.rtxbxReportDescription.Location = new System.Drawing.Point(154, 160);
			this.rtxbxReportDescription.Name = "rtxbxReportDescription";
			this.rtxbxReportDescription.Size = new System.Drawing.Size(298, 96);
			this.rtxbxReportDescription.TabIndex = 9;
			this.rtxbxReportDescription.Text = "";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(45, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 25);
			this.label6.TabIndex = 8;
			this.label6.Text = "Açıklama: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(32, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 25);
			this.label4.TabIndex = 4;
			this.label4.Text = "Rapor Türü:";
			// 
			// txtbxReportName
			// 
			this.txtbxReportName.Location = new System.Drawing.Point(154, 52);
			this.txtbxReportName.Name = "txtbxReportName";
			this.txtbxReportName.Size = new System.Drawing.Size(172, 30);
			this.txtbxReportName.TabIndex = 1;
			// 
			// niReportPuan
			// 
			this.niReportPuan.Location = new System.Drawing.Point(154, 124);
			this.niReportPuan.Name = "niReportPuan";
			this.niReportPuan.Size = new System.Drawing.Size(76, 30);
			this.niReportPuan.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 126);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(108, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "< - > puan:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Rapor ismi:";
			// 
			// dtpickReportDate
			// 
			this.dtpickReportDate.Location = new System.Drawing.Point(154, 88);
			this.dtpickReportDate.Name = "dtpickReportDate";
			this.dtpickReportDate.Size = new System.Drawing.Size(298, 30);
			this.dtpickReportDate.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Rapor Tarihi:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(465, 77);
			this.panel2.Margin = new System.Windows.Forms.Padding(10);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(666, 567);
			this.panel2.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label15);
			this.panel5.Controls.Add(this.label13);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel5.Location = new System.Drawing.Point(0, 446);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(666, 121);
			this.panel5.TabIndex = 6;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label15.Location = new System.Drawing.Point(35, 49);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(184, 36);
			this.label15.TabIndex = 5;
			this.label15.Text = "Derslerle ilgili projeler ders \r\nkategrisine girmektedir";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label13.Location = new System.Drawing.Point(81, 26);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 18);
			this.label13.TabIndex = 3;
			this.label13.Text = "Notlar";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 63);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(666, 504);
			this.dataGridView1.TabIndex = 2;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dateTimePicker1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(666, 63);
			this.panel3.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 13);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(284, 30);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// ReportPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ReportPage";
			this.Size = new System.Drawing.Size(1131, 644);
			this.Load += new System.EventHandler(this.ReportPage_Load);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.niHourLong)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.niReportPuan)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dtpickReportDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtbxReportName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox cmbxReportType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RichTextBox rtxbxReportDescription;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown niReportPuan;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.FlowLayoutPanel HoursPanel;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.ComboBox cmbxHourName;
		private System.Windows.Forms.Button btnAddHour;
		private System.Windows.Forms.NumericUpDown niHourLong;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel4;
	}
}
