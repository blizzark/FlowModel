using System;
using System.Collections.Generic;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ICloneable;

namespace FlowModel.Forms
{
    public partial class OutputGraf : Form
    {
        public OutputGraf()
        {
            InitializeComponent();

            double _step = 0;
            for (int i = 0; i < Classes.Calculate.Tp.Count; i++)
            {
                GTemp.Series[0].Points.AddXY(_step, Classes.Calculate.Tp[i]);
                _step += Classes.Calculate.Steps;

                GViscosity.Series[0].Points.AddXY(_step, Classes.Calculate.hp[i]);
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

        private void Tabl_Click(object sender, EventArgs e)
        {
            // открытие формы таблица
            OutputTables Tabl = new OutputTables();
            this.Hide();
            Tabl.ShowDialog();
            this.Close();
        }
    }
}
