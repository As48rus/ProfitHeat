namespace ProfitHeat
{
	partial class Form_User
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
            this.comboBox_sity = new System.Windows.Forms.ComboBox();
            this.AddRoom = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_power = new System.Windows.Forms.TextBox();
            this.textBox_diametr = new System.Windows.Forms.TextBox();
            this.textBox_capacity = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Sum = new System.Windows.Forms.Button();
            this.Comnaty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountSekciy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Город:";
            // 
            // comboBox_sity
            // 
            this.comboBox_sity.DisplayMember = "Name";
            this.comboBox_sity.FormattingEnabled = true;
            this.comboBox_sity.Location = new System.Drawing.Point(12, 28);
            this.comboBox_sity.Name = "comboBox_sity";
            this.comboBox_sity.Size = new System.Drawing.Size(131, 21);
            this.comboBox_sity.TabIndex = 2;
            this.comboBox_sity.ValueMember = "Name";
            // 
            // AddRoom
            // 
            this.AddRoom.Location = new System.Drawing.Point(12, 55);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(131, 38);
            this.AddRoom.TabIndex = 7;
            this.AddRoom.Text = "Добавить комнату";
            this.AddRoom.UseVisualStyleBackColor = true;
            this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Мощность котла";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Диаметр теплоносителя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Тип насоса";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "кВт";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "мм";
            // 
            // textBox_power
            // 
            this.textBox_power.Location = new System.Drawing.Point(176, 148);
            this.textBox_power.Name = "textBox_power";
            this.textBox_power.ReadOnly = true;
            this.textBox_power.Size = new System.Drawing.Size(100, 20);
            this.textBox_power.TabIndex = 14;
            // 
            // textBox_diametr
            // 
            this.textBox_diametr.Location = new System.Drawing.Point(176, 174);
            this.textBox_diametr.Name = "textBox_diametr";
            this.textBox_diametr.ReadOnly = true;
            this.textBox_diametr.Size = new System.Drawing.Size(100, 20);
            this.textBox_diametr.TabIndex = 15;
            // 
            // textBox_capacity
            // 
            this.textBox_capacity.Location = new System.Drawing.Point(176, 200);
            this.textBox_capacity.Name = "textBox_capacity";
            this.textBox_capacity.ReadOnly = true;
            this.textBox_capacity.Size = new System.Drawing.Size(100, 20);
            this.textBox_capacity.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Comnaty,
            this.CountSekciy});
            this.dataGridView1.Location = new System.Drawing.Point(12, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(295, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(93, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Результат:";
            // 
            // button_Sum
            // 
            this.button_Sum.Location = new System.Drawing.Point(154, 12);
            this.button_Sum.Name = "button_Sum";
            this.button_Sum.Size = new System.Drawing.Size(156, 81);
            this.button_Sum.TabIndex = 20;
            this.button_Sum.Text = "Рассчитать";
            this.button_Sum.UseVisualStyleBackColor = true;
            this.button_Sum.Click += new System.EventHandler(this.button_Sum_Click);
            // 
            // Comnaty
            // 
            this.Comnaty.HeaderText = "Комнаты";
            this.Comnaty.Name = "Comnaty";
            this.Comnaty.ReadOnly = true;
            this.Comnaty.Width = 150;
            // 
            // CountSekciy
            // 
            this.CountSekciy.HeaderText = "Количество секций";
            this.CountSekciy.Name = "CountSekciy";
            this.CountSekciy.ReadOnly = true;
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 390);
            this.Controls.Add(this.button_Sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_capacity);
            this.Controls.Add(this.textBox_diametr);
            this.Controls.Add(this.textBox_power);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddRoom);
            this.Controls.Add(this.comboBox_sity);
            this.Controls.Add(this.label1);
            this.Name = "Form_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пользователь";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox_sity;
		private System.Windows.Forms.Button AddRoom;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox_power;
		private System.Windows.Forms.TextBox textBox_diametr;
		private System.Windows.Forms.TextBox textBox_capacity;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountSekciy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comnaty;
    }
}