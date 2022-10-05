using System;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace FlowModel.Forms
{
    public partial class Authorization : Form
    {
        // объявляю базу
 

        public Authorization()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            String _login = Login.Text;
            String _pass = Pass.Text;
            // логин пароль, которые есть в базе
            //explorer 12345
            //admin admin

            //подключение к базе
            try
            {
                SQLiteConnection _db = new SQLiteConnection("Data source=AuthorizationBD.db; Version=3");
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                // таблица, в которую запишется всё, что нашлось
                DataTable table = new DataTable();
                // команда на поиск строк с логином и паролем
                SQLiteCommand _command = new SQLiteCommand("select * from Person where Name = @login and Pass = @pass", _db);
                // подмена заглушек (нужны для безопасности)
                _command.Parameters.Add("@login", DbType.AnsiString).Value = _login;
                _command.Parameters.Add("@pass", DbType.AnsiString).Value = _pass;
                // вызов команды
                adapter.SelectCommand = _command;
                adapter.Fill(table);

                // если таблица не пуста, значит был найден аккаунт
                if (table.Rows.Count > 0)
                {
                    // перебор всех строк таблицы
                    foreach (DataRow row in table.Rows)
                    {
                        var cells = row.ItemArray;
                        for (int i = 1; i < cells.Length; i++) // проверка с 1 ячейки, т.к. в 0 имена
                        {
                                if ((string)cells[i] == "ADM")
                                {
                                Login.Text = "";
                                Pass.Text = "";
                                // открытие формы
                                AdminPage admin = new AdminPage();
                                    this.Hide(); // скрывает авторизацию
                                    admin.ShowDialog();
                              
                                    this.Show(); // обязательно закрытие авторизации. Иначе прога будет висеть в задачах
                                    break;
                                }
                                else if ((string)cells[i] == "EXP")
                                {
                                Login.Text = "";
                                Pass.Text = "";
                                StartPage start = new StartPage();
                                    this.Hide();
                                    start.ShowDialog();
                              
                                this.Show();
                                    break;
                                }
                            
                        }
                    }
                }
                else// не удалось войти
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
            
            
           

        }
    }
}
