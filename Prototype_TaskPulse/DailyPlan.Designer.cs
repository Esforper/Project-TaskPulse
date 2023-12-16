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
			this.panelDataGrid = new System.Windows.Forms.Panel();
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
			this.panelForm = new System.Windows.Forms.Panel();
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
			this.btnDataGridViewShowHide = new System.Windows.Forms.Button();
			this.panelDataGrid.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.panelForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelDataGrid
			// 
			this.panelDataGrid.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panelDataGrid.Controls.Add(this.testbtnTableRestart);
			this.panelDataGrid.Controls.Add(this.panel4);
			this.panelDataGrid.Controls.Add(this.btnDeletePlan);
			this.panelDataGrid.Controls.Add(this.btnTableClear);
			this.panelDataGrid.Controls.Add(this.label6);
			this.panelDataGrid.Controls.Add(this.dateTimePicker2);
			this.panelDataGrid.Controls.Add(this.btnDataGridViewShowHide);
			this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelDataGrid.Location = new System.Drawing.Point(417, 64);
			this.panelDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelDataGrid.Name = "panelDataGrid";
			this.panelDataGrid.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.panelDataGrid.Size = new System.Drawing.Size(811, 456);
			this.panelDataGrid.TabIndex = 3;
			// 
			// testbtnTableRestart
			// 
			this.testbtnTableRestart.Location = new System.Drawing.Point(376, 365);
			this.testbtnTableRestart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.testbtnTableRestart.Name = "testbtnTableRestart";
			this.testbtnTableRestart.Size = new System.Drawing.Size(123, 58);
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
			this.panel4.Location = new System.Drawing.Point(36, 0);
			this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(760, 345);
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
			this.cmbxFiltDataGrid.Location = new System.Drawing.Point(14, 8);
			this.cmbxFiltDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbxFiltDataGrid.Name = "cmbxFiltDataGrid";
			this.cmbxFiltDataGrid.Size = new System.Drawing.Size(229, 28);
			this.cmbxFiltDataGrid.TabIndex = 12;
			this.cmbxFiltDataGrid.SelectedValueChanged += new System.EventHandler(this.cmbxFiltDataGrid_SelectedValueChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 44);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(15, 2, 2, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(760, 301);
			this.dataGridView1.TabIndex = 11;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.dataGridView1.SizeChanged += new System.EventHandler(this.dataGridView1_SizeChanged);
			// 
			// btnDeletePlan
			// 
			this.btnDeletePlan.Location = new System.Drawing.Point(249, 365);
			this.btnDeletePlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDeletePlan.Name = "btnDeletePlan";
			this.btnDeletePlan.Size = new System.Drawing.Size(123, 58);
			this.btnDeletePlan.TabIndex = 10;
			this.btnDeletePlan.Text = "planı sil";
			this.btnDeletePlan.UseVisualStyleBackColor = true;
			this.btnDeletePlan.Click += new System.EventHandler(this.btnDeletePlan_Click);
			// 
			// btnTableClear
			// 
			this.btnTableClear.Location = new System.Drawing.Point(124, 365);
			this.btnTableClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnTableClear.Name = "btnTableClear";
			this.btnTableClear.Size = new System.Drawing.Size(121, 58);
			this.btnTableClear.TabIndex = 9;
			this.btnTableClear.Text = "<test> tabloyu temizle";
			this.btnTableClear.UseVisualStyleBackColor = true;
			this.btnTableClear.Click += new System.EventHandler(this.btnTableClear_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(521, 427);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "Tarih :";
			this.label6.Visible = false;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dateTimePicker2.Location = new System.Drawing.Point(600, 422);
			this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(207, 26);
			this.dateTimePicker2.TabIndex = 6;
			this.dateTimePicker2.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1228, 64);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1228, 64);
			this.label1.TabIndex = 0;
			this.label1.Text = "Daily Plan Menu";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelForm
			// 
			this.panelForm.Controls.Add(this.btnformClear);
			this.panelForm.Controls.Add(this.btnUpdate);
			this.panelForm.Controls.Add(this.labelError);
			this.panelForm.Controls.Add(this.comboBoxPlanType);
			this.panelForm.Controls.Add(this.label7);
			this.panelForm.Controls.Add(this.addPlan);
			this.panelForm.Controls.Add(this.comboBoxPlanDegree);
			this.panelForm.Controls.Add(this.label5);
			this.panelForm.Controls.Add(this.dateTimePickerPlanDate);
			this.panelForm.Controls.Add(this.richTextBoxPlanDescription);
			this.panelForm.Controls.Add(this.textBoxPlanName);
			this.panelForm.Controls.Add(this.label4);
			this.panelForm.Controls.Add(this.label3);
			this.panelForm.Controls.Add(this.label2);
			this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelForm.Location = new System.Drawing.Point(0, 64);
			this.panelForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelForm.Name = "panelForm";
			this.panelForm.Size = new System.Drawing.Size(417, 456);
			this.panelForm.TabIndex = 2;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUpdate.Location = new System.Drawing.Point(158, 382);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(160, 48);
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
			this.labelError.Location = new System.Drawing.Point(87, 294);
			this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(286, 20);
			this.labelError.TabIndex = 13;
			this.labelError.Text = "Lütfen Gerekli Tüm Alanları Doldurunuz";
			this.labelError.Visible = false;
			// 
			// comboBoxPlanType
			// 
			this.comboBoxPlanType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxPlanType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.comboBoxPlanType.FormattingEnabled = true;
			this.comboBoxPlanType.Items.AddRange(new object[] {
            "Haftalık Tekrarlı",
            "Aylık Tekrarlı",
            "Yıllık Tekrarlı",
            "Tek seferlik"});
			this.comboBoxPlanType.Location = new System.Drawing.Point(158, 234);
			this.comboBoxPlanType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBoxPlanType.Name = "comboBoxPlanType";
			this.comboBoxPlanType.Size = new System.Drawing.Size(235, 28);
			this.comboBoxPlanType.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(62, 236);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 20);
			this.label7.TabIndex = 10;
			this.label7.Text = "Plan Türü:";
			// 
			// btnformClear
			// 
			this.btnformClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnformClear.Location = new System.Drawing.Point(279, 329);
			this.btnformClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnformClear.Name = "btnformClear";
			this.btnformClear.Size = new System.Drawing.Size(84, 49);
			this.btnformClear.TabIndex = 10;
			this.btnformClear.Text = "Formu temizle";
			this.btnformClear.UseVisualStyleBackColor = true;
			this.btnformClear.Click += new System.EventHandler(this.btnformClear_Click);
			// 
			// addPlan
			// 
			this.addPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addPlan.Location = new System.Drawing.Point(70, 330);
			this.addPlan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.addPlan.Name = "addPlan";
			this.addPlan.Size = new System.Drawing.Size(205, 48);
			this.addPlan.TabIndex = 9;
			this.addPlan.Text = "Planı Belirtilen Tarihe Ekle";
			this.addPlan.UseVisualStyleBackColor = true;
			this.addPlan.Click += new System.EventHandler(this.addPlan_Click);
			// 
			// comboBoxPlanDegree
			// 
			this.comboBoxPlanDegree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxPlanDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.comboBoxPlanDegree.FormattingEnabled = true;
			this.comboBoxPlanDegree.Items.AddRange(new object[] {
            "Çok Önemli",
            "Önemli",
            "Az Önemli",
            "Normal",
            "Az Öncelikli",
            "Önemsiz"});
			this.comboBoxPlanDegree.Location = new System.Drawing.Point(158, 198);
			this.comboBoxPlanDegree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBoxPlanDegree.Name = "comboBoxPlanDegree";
			this.comboBoxPlanDegree.Size = new System.Drawing.Size(235, 28);
			this.comboBoxPlanDegree.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(40, 201);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(111, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "Plan Derecesi:";
			// 
			// dateTimePickerPlanDate
			// 
			this.dateTimePickerPlanDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimePickerPlanDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dateTimePickerPlanDate.Location = new System.Drawing.Point(158, 152);
			this.dateTimePickerPlanDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dateTimePickerPlanDate.Name = "dateTimePickerPlanDate";
			this.dateTimePickerPlanDate.Size = new System.Drawing.Size(235, 26);
			this.dateTimePickerPlanDate.TabIndex = 5;
			// 
			// richTextBoxPlanDescription
			// 
			this.richTextBoxPlanDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxPlanDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.richTextBoxPlanDescription.Location = new System.Drawing.Point(158, 44);
			this.richTextBoxPlanDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.richTextBoxPlanDescription.Name = "richTextBoxPlanDescription";
			this.richTextBoxPlanDescription.Size = new System.Drawing.Size(239, 94);
			this.richTextBoxPlanDescription.TabIndex = 4;
			this.richTextBoxPlanDescription.Text = "";
			// 
			// textBoxPlanName
			// 
			this.textBoxPlanName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPlanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBoxPlanName.Location = new System.Drawing.Point(158, 11);
			this.textBoxPlanName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxPlanName.Name = "textBoxPlanName";
			this.textBoxPlanName.Size = new System.Drawing.Size(239, 26);
			this.textBoxPlanName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(62, 156);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Plan Tarihi:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(38, 41);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Plan Açıklama:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(72, 13);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Plan İsmi:";
			// 
			// btnDataGridViewShowHide
			// 
			this.btnDataGridViewShowHide.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnDataGridViewShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDataGridViewShowHide.Location = new System.Drawing.Point(0, 0);
			this.btnDataGridViewShowHide.Name = "btnDataGridViewShowHide";
			this.btnDataGridViewShowHide.Size = new System.Drawing.Size(36, 456);
			this.btnDataGridViewShowHide.TabIndex = 15;
			this.btnDataGridViewShowHide.Text = ">";
			this.btnDataGridViewShowHide.UseVisualStyleBackColor = true;
			this.btnDataGridViewShowHide.Click += new System.EventHandler(this.btnDataGridViewShowHide_Click);
			// 
			// DailyPlan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelForm);
			this.Controls.Add(this.panelDataGrid);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "DailyPlan";
			this.Size = new System.Drawing.Size(1228, 520);
			this.Load += new System.EventHandler(this.DailyPlan_Load);
			this.panelDataGrid.ResumeLayout(false);
			this.panelDataGrid.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panelForm.ResumeLayout(false);
			this.panelForm.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelDataGrid;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelForm;
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
		private System.Windows.Forms.ComboBox cmbxFiltDataGrid;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button testbtnTableRestart;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDataGridViewShowHide;
	}
}
