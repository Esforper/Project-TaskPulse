﻿namespace Prototype_TaskPulse
{
	partial class MainPage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.planName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			this.taskDetailsPanel = new System.Windows.Forms.Panel();
			this.txtbxPlanDescription = new System.Windows.Forms.RichTextBox();
			this.txtbxPlanType = new System.Windows.Forms.TextBox();
			this.txtbxPlanDegree = new System.Windows.Forms.TextBox();
			this.txtbxPlanName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.taskDetailsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(4, 567);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1012, 145);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(22, 24);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel2.Size = new System.Drawing.Size(1020, 716);
			this.panel2.TabIndex = 1;
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planName,
            this.planDescription,
            this.planId});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(4, 54);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.RowHeadersWidth = 51;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(1012, 513);
			this.dataGridView1.TabIndex = 12;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// planName
			// 
			this.planName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.planName.Frozen = true;
			this.planName.HeaderText = "Name";
			this.planName.MinimumWidth = 30;
			this.planName.Name = "planName";
			this.planName.ReadOnly = true;
			this.planName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.planName.Width = 300;
			// 
			// planDescription
			// 
			this.planDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.planDescription.HeaderText = "Description";
			this.planDescription.MinimumWidth = 6;
			this.planDescription.Name = "planDescription";
			this.planDescription.ReadOnly = true;
			// 
			// planId
			// 
			this.planId.HeaderText = "Id";
			this.planId.MinimumWidth = 6;
			this.planId.Name = "planId";
			this.planId.ReadOnly = true;
			this.planId.Visible = false;
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(4, 4);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(1012, 50);
			this.label6.TabIndex = 1;
			this.label6.Text = "Today\'s Tasks";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// taskDetailsPanel
			// 
			this.taskDetailsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.taskDetailsPanel.Controls.Add(this.txtbxPlanDescription);
			this.taskDetailsPanel.Controls.Add(this.txtbxPlanType);
			this.taskDetailsPanel.Controls.Add(this.txtbxPlanDegree);
			this.taskDetailsPanel.Controls.Add(this.txtbxPlanName);
			this.taskDetailsPanel.Controls.Add(this.label5);
			this.taskDetailsPanel.Controls.Add(this.label4);
			this.taskDetailsPanel.Controls.Add(this.label3);
			this.taskDetailsPanel.Controls.Add(this.label2);
			this.taskDetailsPanel.Controls.Add(this.label1);
			this.taskDetailsPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.taskDetailsPanel.Location = new System.Drawing.Point(701, 24);
			this.taskDetailsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.taskDetailsPanel.Name = "taskDetailsPanel";
			this.taskDetailsPanel.Size = new System.Drawing.Size(341, 716);
			this.taskDetailsPanel.TabIndex = 0;
			// 
			// txtbxPlanDescription
			// 
			this.txtbxPlanDescription.BackColor = System.Drawing.SystemColors.Control;
			this.txtbxPlanDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtbxPlanDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtbxPlanDescription.Location = new System.Drawing.Point(94, 106);
			this.txtbxPlanDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtbxPlanDescription.Name = "txtbxPlanDescription";
			this.txtbxPlanDescription.ReadOnly = true;
			this.txtbxPlanDescription.Size = new System.Drawing.Size(222, 97);
			this.txtbxPlanDescription.TabIndex = 9;
			this.txtbxPlanDescription.Text = "<description>";
			// 
			// txtbxPlanType
			// 
			this.txtbxPlanType.BackColor = System.Drawing.SystemColors.Control;
			this.txtbxPlanType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtbxPlanType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtbxPlanType.Location = new System.Drawing.Point(94, 263);
			this.txtbxPlanType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtbxPlanType.Name = "txtbxPlanType";
			this.txtbxPlanType.ReadOnly = true;
			this.txtbxPlanType.Size = new System.Drawing.Size(221, 26);
			this.txtbxPlanType.TabIndex = 8;
			this.txtbxPlanType.Text = "<type>";
			// 
			// txtbxPlanDegree
			// 
			this.txtbxPlanDegree.BackColor = System.Drawing.SystemColors.Control;
			this.txtbxPlanDegree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtbxPlanDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtbxPlanDegree.Location = new System.Drawing.Point(94, 224);
			this.txtbxPlanDegree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtbxPlanDegree.Name = "txtbxPlanDegree";
			this.txtbxPlanDegree.ReadOnly = true;
			this.txtbxPlanDegree.Size = new System.Drawing.Size(221, 26);
			this.txtbxPlanDegree.TabIndex = 7;
			this.txtbxPlanDegree.Text = "<degree>";
			// 
			// txtbxPlanName
			// 
			this.txtbxPlanName.BackColor = System.Drawing.SystemColors.Control;
			this.txtbxPlanName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtbxPlanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtbxPlanName.Location = new System.Drawing.Point(94, 57);
			this.txtbxPlanName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtbxPlanName.Name = "txtbxPlanName";
			this.txtbxPlanName.ReadOnly = true;
			this.txtbxPlanName.Size = new System.Drawing.Size(221, 26);
			this.txtbxPlanName.TabIndex = 6;
			this.txtbxPlanName.Text = "<name>";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(41, 263);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 20);
			this.label5.TabIndex = 3;
			this.label5.Text = "Türü: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(14, 224);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 20);
			this.label4.TabIndex = 2;
			this.label4.Text = "Derecesi: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(12, 106);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Açıklama: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(33, 57);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(124, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Task Details";
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.taskDetailsPanel);
			this.Controls.Add(this.panel2);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainPage";
			this.Padding = new System.Windows.Forms.Padding(22, 24, 22, 24);
			this.Size = new System.Drawing.Size(1064, 764);
			this.Load += new System.EventHandler(this.MainPage_Load);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.taskDetailsPanel.ResumeLayout(false);
			this.taskDetailsPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel taskDetailsPanel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RichTextBox txtbxPlanDescription;
		private System.Windows.Forms.TextBox txtbxPlanType;
		private System.Windows.Forms.TextBox txtbxPlanDegree;
		private System.Windows.Forms.TextBox txtbxPlanName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn planName;
		private System.Windows.Forms.DataGridViewTextBoxColumn planDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn planId;
	}
}
