using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel.Forms
{
    public partial class OutputTables : Form
    {
        public OutputTables()
        {
            InitializeComponent();

            // Отчистка таблицы
            Grid.Rows.Clear();
            Grid.Columns.Clear();
            // Заполнение шапки
            Grid.Columns.Add("Coordinates", "Координата по длине канала, м");
            Grid.Columns.Add("Temperature", "Температура, С");
            Grid.Columns.Add("Viscosity", "Вязкость, Па*С");
            // Выставляю ширину столбцов
            Grid.Columns[0].Width = 240;
            Grid.Columns[1].Width = 240;
            Grid.Columns[2].Width = 240;

            double _step = 0;
            
            for (int i = 0; i < Classes.Calculate.Tp.Count; i++)
            {
                

                Grid.Rows.Add();
                Grid.Rows[i].Cells[0].Value = Math.Round(_step, 2);
                _step += Classes.Calculate.Steps;
                Grid.Rows[i].Cells[1].Value = Math.Round(Classes.Calculate.Tp[i], 2);
                Grid.Rows[i].Cells[2].Value = Math.Round(Classes.Calculate.hp[i], 2);
            }
            PerformanceLabel.Text = Convert.ToString(Math.Round(Classes.Calculate.OutQ, 2)) + " [кг/ч]";
            TempLabel.Text = Convert.ToString(Math.Round(Classes.Calculate.Tp[Classes.Calculate.Tp.Count - 1], 2)) + " [С]";
            ViscosityLabel.Text = Convert.ToString(Math.Round(Classes.Calculate.hp[Classes.Calculate.Tp.Count - 1], 2)) + " [Па*с]";
            TimerLabel.Text = Convert.ToString((Classes.Calculate.Timer)) + " [тактов таймера]";

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Graf_Click(object sender, EventArgs e)
        {
            // открытие формы таблица
            OutputGraf Graf = new OutputGraf();
            this.Hide();
            Graf.ShowDialog();
            this.Close();
        }
    }
}
