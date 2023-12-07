namespace Prototype_TaskPulse
{
	partial class DailyPlan
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.testbtnTableRestart = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cmbxFiltDataGrid = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnDeletePlan = new System.Windows.Forms.Button();
			this.btnTableClear = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.labelError = new System.Windows.Forms.Label();
			this.comboBoxPlanType = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnformClear = new System.Windows.Forms.Button();
			this.addPlan = new System.Windows.Forms.Button();
			this.comboBoxPlanDegree = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePickerPlanDate = new System.Windows.Forms.DateTimePicker();
			this.richTextBoxPlanDescription = new System.Windows.Forms.RichTextBox();
			this.textBoxPlanName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panel1.Controls.Add(this.testbtnTableRestart);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.btnDeletePlan);
			this.panel1.Controls.Add(this.btnTableClear);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.dateTimePicker2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			this.panel1.Size = new System.Drawing.Size(1104, 565);
			this.panel1.TabIndex = 3;
			// 
			// testbtnTableRestart
			// 
			this.testbtnTableRestart.Location = new System.Drawing.Point(394, 449);
			this.testbtnTableRestart.Name = "testbtnTableRestart";
			this.testbtnTableRestart.Size = new System.Drawing.Size(164, 72);
			this.testbtnTableRestart.TabIndex = 14;
			this.testbtnTableRestart.Text = "<test> Tabloyu yenile";
			this.testbtnTableRestart.UseVisualStyleBackColor = true;
			this.testbtnTableRestart.Click += new System.EventHandler(this.testbtnTableRestart_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.cmbxFiltDataGrid);
			this.panel4.Controls.Add(this.dataGridView1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(20, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1064, 425);
			this.panel4.TabIndex = 13;
			// 
			// cmbxFiltDataGrid
			// 
			this.cmbxFiltDataGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbxFiltDataGrid.FormattingEnabled = true;
			this.cmbxFiltDataGrid.Items.AddRange(new object[] {
            "İleriki 1 ayı göster",
            "ileri tarihli hepsini göster",
            "Hepsini göster"});
			this.cmbxFiltDataGrid.Location = new System.Drawing.Point(18, 10);
			this.cmbxFiltDataGrid.Name = "cmbxFiltDataGrid";
			this.cmbxFiltDataGrid.Size = new System.Drawing.Size(304, 33);
			this.cmbxFiltDataGrid.TabIndex = 12;
			this.cmbxFiltDataGrid.SelectedValueChanged += new System.EventHandler(this.cmbxFiltDataGrid_SelectedValueChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 54);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1064, 371);
			this.dataGridView1.TabIndex = 11;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
			// 
			// btnDeletePlan
			// 
			this.btnDeletePlan.Location = new System.Drawing.Point(213, 449);
			this.btnDeletePlan.Name = "btnDeletePlan";
			this.btnDeletePlan.Size = new System.Drawing.Size(164, 72);
			this.btnDeletePlan.TabIndex = 10;
			this.btnDeletePlan.Text = "planı sil";
			this.btnDeletePlan.UseVisualStyleBackColor = true;
			this.btnDeletePlan.Click += new System.EventHandler(this.btnDeletePlan_Click);
			// 
			// btnTableClear
			// 
			this.btnTableClear.Location = new System.Drawing.Point(33, 449);
			this.btnTableClear.Name = "btnTableClear";
			this.btnTableClear.Size = new System.Drawing.Size(161, 72);
			this.btnTableClear.TabIndex = 9;
			this.btnTableClear.Text = "<test> tabloyu temizle";
			this.btnTableClear.UseVisualStyleBackColor = true;
			this.btnTableClear.Click += new System.EventHandler(this.btnTableClear_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(715, 525);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 25);
			this.label6.TabIndex = 7;
			this.label6.Text = "Tarih :";
			this.label6.Visible = false;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dateTimePicker2.Location = new System.Drawing.Point(800, 520);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(275, 30);
			this.dateTimePicker2.TabIndex = 6;
			this.dateTimePicker2.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1638, 79);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1638, 79);
			this.label1.TabIndex = 0;
			this.label1.Text = "Daily Plan Menu";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnUpdate);
			this.panel3.Controls.Add(this.labelError);
			this.panel3.Controls.Add(this.comboBoxPlanType);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.btnformClear);
			this.panel3.Controls.Add(this.addPlan);
			this.panel3.Controls.Add(this.comboBoxPlanDegree);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.dateTimePickerPlanDate);
			this.panel3.Controls.Add(this.richTextBoxPlanDescription);
			this.panel3.Controls.Add(this.textBoxPlanName);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 79);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(534, 565);
			this.panel3.TabIndex = 2;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(185, 472);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(225, 59);
			this.btnUpdate.TabIndex = 14;
			this.btnUpdate.Text = "planı düzenle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
			// 
			// labelError
			// 
			this.labelError.AutoSize = true;
			this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(116, 362);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(352, 25);
			this.labelError.TabIndex = 13;
			this.labelError.Text = "Lütfen Gerekli Tüm Alanları Doldurunuz";
			this.labelError.Visible = false;
			// 
			// comboBoxPlanType
			// 
			this.comboBoxPlanType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.comboBoxPlanType.FormattingEnabled = true;
			this.comboBoxPlanType.Items.AddRange(new object[] {
            "Haftalık Tekrarlı",
            "Aylık Tekrarlı",
            "Yıllık Tekrarlı",
            "Tek seferlik"});
			this.comboBoxPlanType.Location = new System.Drawing.Point(211, 288);
			this.comboBoxPlanType.Name = "comboBoxPlanType";
			this.comboBoxPlanType.Size = new System.Drawing.Size(304, 33);
			this.comboBoxPlanType.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(82, 291);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(103, 25);
			this.label7.TabIndex = 10;
			this.label7.Text = "Plan Türü:";
			// 
			// btnformClear
			// 
			this.btnformClear.Location = new System.Drawing.Point(385, 406);
			this.btnformClear.Name = "btnformClear";
			this.btnformClear.Size = new System.Drawing.Size(92, 60);
			this.btnformClear.TabIndex = 10;
			this.btnformClear.Text = "Formu temizle";
			this.btnformClear.UseVisualStyleBackColor = true;
			this.btnformClear.Click += new System.EventHandler(this.btnformClear_Click);
			// 
			// addPlan
			// 
			this.addPlan.Location = new System.Drawing.Point(94, 406);
			this.addPlan.Name = "addPlan";
			this.addPlan.Size = new System.Drawing.Size(285, 59);
			this.addPlan.TabIndex = 9;
			this.addPlan.Text = "Planı Belirtilen Tarihe Ekle";
			this.addPlan.UseVisualStyleBackColor = true;
			this.addPlan.Click += new System.EventHandler(this.addPlan_Click);
			// 
			// comboBoxPlanDegree
			// 
			this.comboBoxPlanDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.comboBoxPlanDegree.FormattingEnabled = true;
			this.comboBoxPlanDegree.Items.AddRange(new object[] {
            "Çok Önemli",
            "Önemli",
            "Az Önemli",
            "Normal",
            "Az Öncelikli",
            "Önemsiz"});
			this.comboBoxPlanDegree.Location = new System.Drawing.Point(211, 244);
			this.comboBoxPlanDegree.Name = "comboBoxPlanDegree";
			this.comboBoxPlanDegree.Size = new System.Drawing.Size(304, 33);
			this.comboBoxPlanDegree.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(54, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 25);
			this.label5.TabIndex = 6;
			this.label5.Text = "Plan Derecesi:";
			// 
			// dateTimePickerPlanDate
			// 
			this.dateTimePickerPlanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dateTimePickerPlanDate.Location = new System.Drawing.Point(211, 187);
			this.dateTimePickerPlanDate.Name = "dateTimePickerPlanDate";
			this.dateTimePickerPlanDate.Size = new System.Drawing.Size(304, 30);
			this.dateTimePickerPlanDate.TabIndex = 5;
			// 
			// richTextBoxPlanDescription
			// 
			this.richTextBoxPlanDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.richTextBoxPlanDescription.Location = new System.Drawing.Point(211, 54);
			this.richTextBoxPlanDescription.Name = "richTextBoxPlanDescription";
			this.richTextBoxPlanDescription.Size = new System.Drawing.Size(304, 115);
			this.richTextBoxPlanDescription.TabIndex = 4;
			this.richTextBoxPlanDescription.Text = "";
			// 
			// textBoxPlanName
			// 
			this.textBoxPlanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBoxPlanName.Location = new System.Drawing.Point(211, 13);
			this.textBoxPlanName.Name = "textBoxPlanName";
			this.textBoxPlanName.Size = new System.Drawing.Size(304, 30);
			this.textBoxPlanName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(82, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "Plan Tarihi:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(51, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 25);
			this.label3.TabIndex = 1;
			this.label3.Text = "Plan Açıklama:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(96, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Plan İsmi:";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(534, 79);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(1104, 565);
			this.panel5.TabIndex = 3;
			// 
			// DailyPlan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Name = "DailyPlan";
			this.Size = new System.Drawing.Size(1638, 644);
			this.Load += new System.EventHandler(this.DailyPlan_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPlanName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dateTimePickerPlanDate;
		private System.Windows.Forms.RichTextBox richTextBoxPlanDescription;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.ComboBox comboBoxPlanDegree;
		private System.Windows.Forms.Button btnDeletePlan;
		private System.Windows.Forms.Button btnTableClear;
		private System.Windows.Forms.ComboBox comboBoxPlanType;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnformClear;
		private System.Windows.Forms.Button addPlan;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label labelError;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.ComboBox cmbxFiltDataGrid;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button testbtnTableRestart;
		private System.Windows.Forms.Button btnUpdate;
	}
}
