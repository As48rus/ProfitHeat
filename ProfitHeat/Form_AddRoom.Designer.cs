namespace ProfitHeat
{
	partial class Form_AddRoom
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_TypeRoom = new System.Windows.Forms.ComboBox();
            this.comboBox_level = new System.Windows.Forms.ComboBox();
            this.comboBox_typeRadiator = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView_wall = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_floor = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView_ceiling = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView_door = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wall)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_floor)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ceiling)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_door)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Этаж";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип радиатора";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(180, 12);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // comboBox_TypeRoom
            // 
            this.comboBox_TypeRoom.FormattingEnabled = true;
            this.comboBox_TypeRoom.Location = new System.Drawing.Point(180, 38);
            this.comboBox_TypeRoom.Name = "comboBox_TypeRoom";
            this.comboBox_TypeRoom.Size = new System.Drawing.Size(121, 21);
            this.comboBox_TypeRoom.TabIndex = 5;
            // 
            // comboBox_level
            // 
            this.comboBox_level.FormattingEnabled = true;
            this.comboBox_level.Location = new System.Drawing.Point(180, 65);
            this.comboBox_level.Name = "comboBox_level";
            this.comboBox_level.Size = new System.Drawing.Size(121, 21);
            this.comboBox_level.TabIndex = 6;
            // 
            // comboBox_typeRadiator
            // 
            this.comboBox_typeRadiator.FormattingEnabled = true;
            this.comboBox_typeRadiator.Location = new System.Drawing.Point(180, 92);
            this.comboBox_typeRadiator.Name = "comboBox_typeRadiator";
            this.comboBox_typeRadiator.Size = new System.Drawing.Size(121, 21);
            this.comboBox_typeRadiator.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(8, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 219);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView_wall);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 193);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Стены";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView_wall.AllowUserToDeleteRows = false;
            this.dataGridView_wall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_wall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView_wall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_wall.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_wall.Name = "dataGridView1";
            this.dataGridView_wall.Size = new System.Drawing.Size(453, 187);
            this.dataGridView_wall.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_floor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 193);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пол";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView_floor.AllowUserToDeleteRows = false;
            this.dataGridView_floor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_floor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView_floor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_floor.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_floor.Name = "dataGridView2";
            this.dataGridView_floor.Size = new System.Drawing.Size(453, 187);
            this.dataGridView_floor.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView_ceiling);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(459, 193);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Потолок";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView_ceiling.AllowUserToDeleteRows = false;
            this.dataGridView_ceiling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ceiling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView_ceiling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ceiling.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ceiling.Name = "dataGridView3";
            this.dataGridView_ceiling.Size = new System.Drawing.Size(459, 193);
            this.dataGridView_ceiling.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView_door);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(459, 193);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Двери";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView_door.AllowUserToDeleteRows = false;
            this.dataGridView_door.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_door.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column15});
            this.dataGridView_door.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_door.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_door.Name = "dataGridView4";
            this.dataGridView_door.Size = new System.Drawing.Size(459, 193);
            this.dataGridView_door.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(459, 193);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Окна";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column4});
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(459, 193);
            this.dataGridView5.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Площадь";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Толщина";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Материал";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Площадь";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Толщина";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Материал";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Площадь";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Толщина";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Материал";
            this.Column11.Name = "Column11";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Площадь";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Толщина";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Материал";
            this.Column15.Name = "Column15";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Площадь";
            this.Column17.Name = "Column17";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Стеклопакет";
            this.Column18.Name = "Column18";
            this.Column18.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column19
            // 
            this.Column19.HeaderText = "Профиль (площадь)";
            this.Column19.Name = "Column19";
            this.Column19.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Профиль (количество камер)";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox_typeRadiator);
            this.Controls.Add(this.comboBox_level);
            this.Controls.Add(this.comboBox_TypeRoom);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_AddRoom";
            this.Text = "Комната";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wall)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_floor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ceiling)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_door)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_name;
		private System.Windows.Forms.ComboBox comboBox_TypeRoom;
		private System.Windows.Forms.ComboBox comboBox_level;
		private System.Windows.Forms.ComboBox comboBox_typeRadiator;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.DataGridView dataGridView_wall;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataGridView_floor;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGridView dataGridView_ceiling;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.DataGridView dataGridView_door;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.DataGridView dataGridView5;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
    }
}