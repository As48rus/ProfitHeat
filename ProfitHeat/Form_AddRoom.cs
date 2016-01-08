using CalculationProfitHeat;
using System;
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
		}

        private void button1_Click(object sender, EventArgs e)
        {
            _room = new Room(textBox_name.Text, int.Parse(comboBox_level.Text), comboBox_TypeRoom.Text, comboBox_typeRadiator.Text);

            _room.Claddings.Add(GetAllCladding(dataGridView_wall));
            _room.Claddings.Add(GetAllCladding(dataGridView_floor));
            _room.Claddings.Add(GetAllCladding(dataGridView_ceiling));
            _room.Claddings.Add(GetAllCladding(dataGridView_door));

            _room.Windows = GetWindows(dataGridView5);

            _rooms.Add(_room);

            this.Close();
        }

        private Cladding GetAllCladding(DataGridView dgw)
        {
            double area = (double)dgw[0, 0].Value;
            Cladding cladding = new Cladding(area);
            for (int i = 0; i < dgw.RowCount; i++)
            {
                double thickness = (double)dgw[1, i].Value;
                string nameMaterial = dgw[2, i].Value.ToString();
                cladding.Materials.Add(new Material(thickness, nameMaterial));
            }
            return cladding;
        }

        private List<Window> GetWindows(DataGridView dgw)
        {
            List<Window> windows = new List<Window>();
            for (int i = 0; i < dgw.RowCount; i++)
            {
                double area = (double)dgw[0, i].Value;
                Glazed glazed = new Glazed(dgw[1,i].Value.ToString());
                WindowProfile wp = new WindowProfile((double)dgw[2, i].Value, (int)dgw[3, i].Value);
                windows.Add(new Window(area, glazed, wp));
            }
            return windows;
        }
    }
}
