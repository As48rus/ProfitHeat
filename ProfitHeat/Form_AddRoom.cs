using CalculationProfitHeat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CalculationProfitHeat;

namespace ProfitHeat
{
	public partial class Form_AddRoom : Form
	{
        Room _room;
        List<Room> _rooms;

        public Form_AddRoom(List<Room> rooms)
		{
			InitializeComponent();
            _rooms = rooms;

            comboBox_TypeRoom.DataSource = WorkWithDatabase.GetAllTypeRooms();
            comboBox_typeRadiator.DataSource = WorkWithDatabase.GetAllTypeRadiator();
            //материал
            DataGridViewComboBoxColumn dgwCB = new DataGridViewComboBoxColumn();
            dgwCB.ValueMember = "Name";
            dgwCB.HeaderText = "Материал";
            dgwCB.Width = 200;
            dgwCB.DataSource = WorkWithDatabase.GetAllMaterials();

            dataGridView_wall.Columns.Add(dgwCB);
            dataGridView_door.Columns.Add((DataGridViewComboBoxColumn)dgwCB.Clone());
            dataGridView_floor.Columns.Add((DataGridViewComboBoxColumn)dgwCB.Clone());
            dataGridView_ceiling.Columns.Add((DataGridViewComboBoxColumn)dgwCB.Clone());
            //стеклопакет
            DataGridViewComboBoxColumn dgwCB2 = new DataGridViewComboBoxColumn();
            dgwCB2.ValueMember = "Name";
            dgwCB2.HeaderText = "Стеклопакет";
            dgwCB2.Width = 130;
            dgwCB2.DataSource = WorkWithDatabase.GetAllGlazedes();
            dataGridView_windows.Columns.Add(dgwCB2);
            //площадь профиля
            DataGridViewTextBoxColumn dgwTB = new DataGridViewTextBoxColumn();
            dgwTB.HeaderText = "Профиль (площадь)";
            dgwTB.Width = 70;
            dataGridView_windows.Columns.Add(dgwTB);
            //количество камер
            DataGridViewComboBoxColumn dgwCB1 = new DataGridViewComboBoxColumn();
            dgwCB1.ValueMember = "CountCameras";
            dgwCB1.HeaderText = "Количество камер";
            dgwCB1.Width = 70;
            dgwCB1.DataSource = WorkWithDatabase.GetAllWindowProfilesCountCameras();
            dataGridView_windows.Columns.Add(dgwCB1);
            //толщина
            DataGridViewComboBoxColumn dgwCB4 = new DataGridViewComboBoxColumn();
            dgwCB4.ValueMember = "Thickness";
            dgwCB4.HeaderText = "Толщина";
            dgwCB4.Width = 70;
            dgwCB4.DataSource = WorkWithDatabase.GetAllWindowProfilesThickness();
            dataGridView_windows.Columns.Add(dgwCB4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _room = new Room(textBox_name.Text, int.Parse(comboBox_level.Text), comboBox_TypeRoom.Text, comboBox_typeRadiator.Text);

            _room.Claddings.Add(GetAllCladding(dataGridView_wall));
            _room.Claddings.Add(GetAllCladding(dataGridView_floor));
            _room.Claddings.Add(GetAllCladding(dataGridView_ceiling));
            _room.Claddings.Add(GetAllCladding(dataGridView_door));

            _room.Windows = GetWindows(dataGridView_windows);

            _rooms.Add(_room);

            this.DialogResult = DialogResult.OK;
        }

        private Cladding GetAllCladding(DataGridView dgw)
        {
            double area = Convert.ToDouble(dgw[0, 0].Value);
            Cladding cladding = new Cladding(area);
            for (int i = 0; i < dgw.RowCount - 1; i++)
            {
                double thickness = Convert.ToDouble(dgw[1, i].Value);
                string nameMaterial = dgw[2, i].Value.ToString();
                cladding.Materials.Add(new Material(thickness, nameMaterial));
            }
            return cladding;
        }

        private List<Window> GetWindows(DataGridView dgw)
        {
            List<Window> windows = new List<Window>();
            for (int i = 0; i < dgw.RowCount -1; i++)
            {
                double area = Convert.ToDouble(dgw[0, i].Value);
                Glazed glazed = new Glazed(dgw[1,i].Value.ToString());
                WindowProfile wp = new WindowProfile(Convert.ToDouble(dgw[2, i].Value), Convert.ToInt32(dgw[3, i].Value), Convert.ToInt32(dgw[4, i].Value));
                windows.Add(new Window(area, glazed, wp));
            }
            return windows;
        }

    }
}
