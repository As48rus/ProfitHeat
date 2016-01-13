using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculationProfitHeat;

namespace ProfitHeat
{
	public partial class Form_User : Form
	{
        List<Room> _rooms = new List<Room>();
        Result _result;

        public Form_User()
		{
			InitializeComponent();
            comboBox_sity.DataSource = WorkWithDatabase.GetAllSity();

        }

        private void button_Sum_Click(object sender, EventArgs e)
        {
            _result = new Result(comboBox_sity.Text, _rooms);

            textBox_power.Text = _result.GetBoilerOutput().ToString();
            textBox_diametr.Text = _result.GetDiameterCoolant().ToString();
            textBox_capacity.Text = _result.GetPumpCapacity();

            AddRowsDGW();
        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            Form_AddRoom addRoom = new Form_AddRoom(_rooms);
            if(addRoom.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Комната" + _rooms.Last().Name + "добавлена!");
        }
        private void AddRowsDGW()
        {
            for (int i = 0; i < _rooms.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.Rows.Add()];
                //row.HeaderCell.Value = name;
                row.Cells[0].Value = _rooms[i].Name;
                row.Cells[1].Value = _rooms[i].CountSections;
            }
        }

    }
}
