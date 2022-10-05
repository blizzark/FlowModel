using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModel.Forms
{
    public partial class StartPage : Form
    {
        // объявляю базу
        private SQLiteConnection _db;
        DataTable table = new DataTable();
       
        public StartPage()
        {
            InitializeComponent();


            // подключаюсь к базе
            _db = new SQLiteConnection("Data source=AuthorizationBD.db; Version=3");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            // таблица, в которую запишется всё, что нашлось
            
            // команда на поиск строк с логином и паролем
            SQLiteCommand _command = new SQLiteCommand("select * from Materials", _db);
 
            // вызов команды
            adapter.SelectCommand = _command;
            adapter.Fill(table);

            int indx = 0;
            foreach (DataRow row  in table.Rows)
            {
                Material.Items.Add(table.Rows[indx++][1]); // индекс увеличивается для прохода по колонкам. 1 обозначает вторую колонку, т.к. в первой ID.
                // Навереое, по хорошему лучше делать поиск нужной колонки по имени, хотя не знаю.

            }

         
        }

        private void Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            int IDMat = 0;
            int indx = 0;
            foreach (DataRow row in table.Rows)
            {
                if (Material.Text == (string)table.Rows[indx++][1])
                {
                    IDMat = Convert.ToInt32(table.Rows[--indx][0]);
                    break;
                }
            }
           
                Classes.Materials Substance = new Classes.Materials(IDMat);
           
            BWidth.Text = Convert.ToString(Substance.Width);
            BDepth.Text = Convert.ToString(Substance.Depth);
            BLength.Text = Convert.ToString(Substance.Length);
            BDensity.Text = Convert.ToString(Substance.Density);
            BSpecificHeat.Text = Convert.ToString(Substance.SpecificHeat);
            BMeltingPoint.Text = Convert.ToString(Substance.MeltingPoint);
            BCoverSpeed.Text = Convert.ToString(Substance.CoverSpeed);
            BСoverTemperature.Text = Convert.ToString(Substance.СoverTemperature);
            BStep.Text = Convert.ToString(Substance.Step);
            BKConsistency.Text = Convert.ToString(Substance.KConsistency);
            BKTemperature.Text = Convert.ToString(Substance.KTemperature);
            BCastTemperature.Text = Convert.ToString(Substance.CastTemperature);
            BCurrentIndex.Text = Convert.ToString(Substance.CurrentIndex);
            BKHeatDissipation.Text = Convert.ToString(Substance.KHeatDissipation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

    
        private void Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данную программу разработали студенты\nСПбГТИ(ТУ) факультета ИТиУ 475 группы:\nОвчинников Роман Сергеевич\nКараулова Полина Алексеевна", "Информация о разработчиках");
        }

        private void Tabl_Click(object sender, EventArgs e)
        {
            if (WorkAlgoritm())
            {
                // открытие формы таблица
                OutputTables Tabl = new OutputTables();
                this.Hide();
                Tabl.ShowDialog();
                this.Show();
            }
        }

        private void Graf_Click(object sender, EventArgs e)
        {

            if (WorkAlgoritm())
            {
                // открытие формы таблица
                OutputGraf Graf = new OutputGraf();
                this.Hide();
                Graf.ShowDialog();
                this.Show();
            }

            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (WorkAlgoritm())     
               Classes.CSV.ExportToCSV();

        }

        public bool WorkAlgoritm()
        {
            try
            {
                //Ввод
                Classes.Materials UserCustomization = new Classes.Materials(Convert.ToDouble(BWidth.Text), Convert.ToDouble(BDepth.Text),
                        Convert.ToDouble(BLength.Text), Convert.ToDouble(BDensity.Text), Convert.ToDouble(BSpecificHeat.Text),
                        Convert.ToDouble(BMeltingPoint.Text), Convert.ToDouble(BCoverSpeed.Text), Convert.ToDouble(BСoverTemperature.Text),
                        Convert.ToDouble(BStep.Text), Convert.ToDouble(BKConsistency.Text), Convert.ToDouble(BKTemperature.Text),
                        Convert.ToDouble(BCastTemperature.Text), Convert.ToDouble(BCurrentIndex.Text), Convert.ToDouble(BKHeatDissipation.Text));

                Classes.Calculate.SearchTemperatureAndViscosity(UserCustomization);
                return true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return false;
            }
        }

        private void ExitToAuth_Click(object sender, EventArgs e)
        {
            this.Close();
            /* Не понимаю как сделать так, чтобы при нажатии на эту кнопку открывалась форма авторизации,
             * а при закрытии формы она не появлялась. Можно сделать через доп. переменную bool типа,
             * но как по мне это костыль. Скорее всего нужно ловить событие закрытия и событие нажания на кнопку
             * в форме аторизация, т.к. та форма главная. Пока не понял и собсна понимать не хочу.
             */
        }
    }
}
