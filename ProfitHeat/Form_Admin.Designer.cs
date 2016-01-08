namespace ProfitHeat
{
	partial class Form_Admin
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.NameMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.L = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.NameCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(657, 572);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(649, 546);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Материалы";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameMaterial,
            this.L});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(643, 540);
			this.dataGridView1.TabIndex = 0;
			// 
			// NameMaterial
			// 
			this.NameMaterial.HeaderText = "Название";
			this.NameMaterial.Name = "NameMaterial";
			this.NameMaterial.Width = 300;
			// 
			// L
			// 
			this.L.HeaderText = "Теплопроводность";
			this.L.Name = "L";
			this.L.Width = 300;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(649, 585);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Города";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCity,
            this.tMin});
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(3, 3);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(643, 579);
			this.dataGridView2.TabIndex = 0;
			// 
			// NameCity
			// 
			this.NameCity.HeaderText = "Название";
			this.NameCity.Name = "NameCity";
			this.NameCity.Width = 300;
			// 
			// tMin
			// 
			this.tMin.HeaderText = "Минимальная температура";
			this.tMin.Name = "tMin";
			this.tMin.Width = 300;
			// 
			// Form_Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 572);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form_Admin";
			this.Text = "Панель администратора";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameMaterial;
		private System.Windows.Forms.DataGridViewTextBoxColumn L;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn tMin;
	}
}

