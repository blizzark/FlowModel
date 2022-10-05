using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Data.SQLite;
using System.Windows.Forms;

namespace FlowModel.Forms
{
    public partial class AdminPage : Form
    {
        private SQLiteConnection _db = new SQLiteConnection("Data source=AuthorizationBD.db; Version=3");
        DataTable tableAcc = new DataTable();
        DataTable tableMaterials = new DataTable();
        DataTable tableTable = new DataTable();


        public AdminPage() //////////////////////// Чёт этот конструктор теперь легко потерять
        {
            InitializeComponent();
            
            // тут всё по первой вкладке
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                SQLiteCommand _command = new SQLiteCommand("select * from Person", _db);
                // вызов команды
                adapter.SelectCommand = _command;
                adapter.Fill(tableAcc);
                Accs.Rows.Add();
                // перебор всех строк таблицы
                for (int i = 0; i < tableAcc.Rows.Count; i++)
                {
                    Accs.Rows.Add();
                    DataRow row = tableAcc.Rows[i];
                    for (int j = 0; j < tableAcc.Columns.Count - 2; j++)
                    {
                        Accs.Rows[i].Cells[j].Value = row[j + 1];

                    }

                }
                for (int i = 0; i < tableAcc.Rows.Count; i++) // изначально был план сделать выпадающее меню в ячейке. Но не сраслось. Хз как это сделать)
                {
                    DataRow row = tableAcc.Rows[i];
                    if ((string)row[3] == "ADM")
                        Accs.Rows[i].Cells[2].Value = true;
                    else
                        Accs.Rows[i].Cells[2].Value = false;
                }
                Accs.Rows.RemoveAt(Accs.Rows.Count - 1);
            }

            // тут всё по второй вкладке
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();

                SQLiteCommand _command = new SQLiteCommand("select * from Materials", _db);
                // вызов команды
                adapter.SelectCommand = _command;
                adapter.Fill(tableMaterials);
               
                // перебор всех строк таблицы
              
                for (int i = 0; i < tableMaterials.Rows.Count; i++)
                {
                    MatBD.Rows.Add();
                    DataRow row = tableMaterials.Rows[i];
                    for (int j = 0; j < tableMaterials.Columns.Count; j++)
                    {
                        MatBD.Rows[i].Cells[j].Value = row[j];

                    }

                }

            }

            // тут всё по третьей вкладке
            {
                ComboBox.Items.Add("Param");
                ComboBox.Items.Add("ParamValue");
                ComboBox.Items.Add("TypeParam");
                ComboBox.Items.Add("Unit");
            }
        }


        private void BSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Accs.Rows.Count; i++)
                {
                    for (int j = 0; j < Accs.Columns.Count - 1; j++)
                    {
                        if (Accs.Rows[i].Cells[j].Value == null)
                        {
                            throw new Exception("Поля не могут быть пустыми!");
                        }
                    }
                }
                bool admin = false;

                for (int i = 0; i < Accs.Rows.Count; i++)
                {
                    if ((bool)Accs.Rows[i].Cells[2].Value == true)
                    {
                        admin = true;
                        break;
                    }

                }
                if (!admin)
                    throw new Exception("Должен быть хотя бы один администратор!");

                string baseName = "AuthorizationBD.db";
                using (var connection = new SQLiteConnection())
                {
                    connection.ConnectionString = "Data Source = " + baseName;
                    connection.Open();
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = new SQLiteCommand(" DELETE FROM Person ", connection);
                    sqlite_cmd.ExecuteNonQuery();
                    progressBar3.Maximum = Accs.Rows.Count;
                    progressBar3.Value = 0;
                    for (int i = 0; i < Accs.Rows.Count; i++)
                    {
                        sqlite_cmd = new SQLiteCommand("insert into Person(id, Name, Pass, Access) values(@id, @Name, @Pass, @Access)", connection);

                        sqlite_cmd.Parameters.AddWithValue("@id", i + 1);
                        sqlite_cmd.Parameters.AddWithValue("@Name", Convert.ToString(Accs.Rows[i].Cells[0].Value));
                        sqlite_cmd.Parameters.AddWithValue("@Pass", Convert.ToString(Accs.Rows[i].Cells[1].Value));

                        string Access = "";
                        if ((bool)Accs.Rows[i].Cells[2].Value == true)
                            Access = "ADM";
                        else
                            Access = "EXP";

                        sqlite_cmd.Parameters.AddWithValue("@Access", Access);
                        sqlite_cmd.ExecuteNonQuery();
                        progressBar3.Value += 1;
                    }
                    MessageBox.Show("Успешно сохранено!", "Успех!");
                    progressBar3.Value = 0;
                    connection.Close();
                }
            }
            catch (Exception ex) // чересчур уж большой try/catch.. хотя, мб и придераюсь :з
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            Accs.Rows.Add();
            Accs.Rows[Accs.Rows.Count - 1].Cells[2].Value = false;
        }

        private void BDelete_Click(object sender, EventArgs e) // бывает, что нужно удалить не последнюю строку.. Надо будет исправить
        {
            if (Accs.Rows.Count < 3)
            {
                MessageBox.Show("К сожалению, я не могу Вам это позволить.\nДолжно оставаться минимум 2 пользователя.\nХотя бы один из них должен быть админом.", "Удаление главных пользователей");
            }
            else
            {
                // Accs.Rows.RemoveAt(Accs.Rows.Count - 1);
                int delet = Accs.SelectedCells[0].RowIndex;
                Accs.Rows.RemoveAt(delet);
            }
        }

        private void ComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            tableTable.Rows.Clear();  tableTable.Columns.Clear(); tableTable.Clear(); // на всякий.. Почему-то просто клир не работает нормально)
            FormBD.Rows.Clear();
            FormBD.Columns.Clear();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            SQLiteCommand _command = new SQLiteCommand("select * from " + ComboBox.Text, _db);
           
            // вызов команды
            adapter.SelectCommand = _command;
            
            adapter.Fill(tableTable);
            for (int i = 0; i < tableTable.Columns.Count; i++)
            {
                
                FormBD.Columns.Add(Convert.ToString(i), Convert.ToString(tableTable.Columns[i]));
            }
            FormBD.Columns[0].Width = 150;
            FormBD.Columns[1].Width = 448;

            for (int i = 0; i < tableTable.Rows.Count; i++)
            {
                FormBD.Rows.Add();
                DataRow rows = tableTable.Rows[i];
                for (int j = 0; j < tableTable.Columns.Count; j++)
                {

                    FormBD.Rows[i].Cells[j].Value = rows[j];

                }

            }
        }

        private void SaveMat_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < MatBD.Rows.Count; i++)
                {
                    for (int j = 0; j < MatBD.Columns.Count; j++)
                    {
                        if (MatBD.Rows[i].Cells[j].Value == null)
                        {
                            throw new Exception("Поля не могут быть пустыми!");
                        }
                    }
                }

              


                try
                {
                    for (int i = 0; i < MatBD.Rows.Count; i++)
                    {
                        int a = Convert.ToInt32(MatBD.Rows[i].Cells[0].Value);
                    }
                }
                catch
                {
                    throw new Exception("id может быть только числом!:");
                }

                for (int i = 0; i < MatBD.Rows.Count; i++)
                {
                    int tmp = Convert.ToInt32(MatBD.Rows[i].Cells[0].Value);

                    for (int j = 0; j < MatBD.Rows.Count; j++)
                    {
                        if(tmp == Convert.ToInt32(MatBD.Rows[j].Cells[0].Value) && i != j)
                            throw new Exception("id не должны совпадать!");
                    }
                }

                string baseName = "AuthorizationBD.db";
                using (var connection = new SQLiteConnection())
                {
                    connection.ConnectionString = "Data Source = " + baseName;
                    connection.Open();
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = new SQLiteCommand(" DELETE FROM Materials ", connection);
                    sqlite_cmd.ExecuteNonQuery();
                    progressBar2.Maximum = MatBD.Rows.Count;
                    progressBar2.Value = 0;
                    for (int i = 0; i < MatBD.Rows.Count; i++)
                    {
                        sqlite_cmd = new SQLiteCommand("insert into Materials(IDMat, TypeMat) values(@id, @Name)", connection);

                        sqlite_cmd.Parameters.AddWithValue("@id", MatBD.Rows[i].Cells[0].Value);
                        sqlite_cmd.Parameters.AddWithValue("@Name", MatBD.Rows[i].Cells[1].Value);
                        sqlite_cmd.ExecuteNonQuery();
                        progressBar2.Value += 1;
                    }
                    MessageBox.Show("Успешно сохранено!", "Успех!");
                    progressBar2.Value = 0;
                    connection.Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

        }

        private void AddMat_Click(object sender, EventArgs e)
        {
           MatBD.Rows.Add();
        }

        private void DeleteMat_Click(object sender, EventArgs e)
        {
                int delet = MatBD.SelectedCells[0].RowIndex;
            MatBD.Rows.RemoveAt(delet);
        }

        private void ExitToAuth_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveTab3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < FormBD.Rows.Count; i++)
                {
                    for (int j = 0; j < FormBD.Columns.Count; j++)
                    {
                        if (j == 3)
                        {
                            continue;
                        }
                        if (FormBD.Rows[i].Cells[j].Value == null)
                        {
                            throw new Exception("Поля не могут быть пустыми!");
                        }
                    }
                }
                try
                {
                    if (ComboBox.Text != "ParamValue") {
                        for (int j = 0; j < FormBD.Columns.Count; j++)
                        {
                            for (int i = 0; i < FormBD.Rows.Count; i++)
                            {
                                if (j == 1 || j == 3)
                                    continue;
                                int a = Convert.ToInt32(FormBD.Rows[i].Cells[j].Value);
                            }
                        }
                        if (FormBD.Columns.Count == 4) //  можно объединить с верхним. Проверка на целочисленность и пустоту ячейки (т.е. мб пустой)
                        {
                            for (int i = 0; i < FormBD.Rows.Count; i++)
                            {

                                if (Convert.ToString(FormBD.Rows[i].Cells[3].Value) == "")
                                {
                                    continue;
                                }
                                else
                                {
                                    int a = Convert.ToInt32(FormBD.Rows[i].Cells[3].Value);
                                    
                                }

                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < FormBD.Rows.Count; i++)
                        {
                            double a = Convert.ToDouble(FormBD.Rows[i].Cells[0].Value);
                            int b = Convert.ToInt32(FormBD.Rows[i].Cells[1].Value);
                            int c = Convert.ToInt32(FormBD.Rows[i].Cells[2].Value);
                        }
 
                    }
                }
                catch
                {
                    throw new Exception("В поле id или num можно вводить только числа!");
                }

                if (ComboBox.Text != "ParamValue")
                {
                    for (int i = 0; i < FormBD.Rows.Count; i++)
                    {
                        int tmp = Convert.ToInt32(FormBD.Rows[i].Cells[0].Value);

                        for (int j = 0; j < FormBD.Rows.Count; j++)
                        {
                            if (tmp == Convert.ToInt32(FormBD.Rows[j].Cells[0].Value) && i != j)
                                throw new Exception("id не должны совпадать!");
                        }
                    }
                }


                string baseName = "AuthorizationBD.db";
                using (var connection = new SQLiteConnection()) // да, костыль (удаление всего и запись того, что в таблице), но работает же :з
                {
                    connection.ConnectionString = "Data Source = " + baseName;
                    connection.Open();
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = new SQLiteCommand(" DELETE FROM " + ComboBox.Text, connection);
                    sqlite_cmd.ExecuteNonQuery();



                    string colum = Convert.ToString(tableTable.Columns[0]);
                    for (int i = 1; i < tableTable.Columns.Count; i++)
                    {
                        colum += ", " + Convert.ToString(tableTable.Columns[i]);
                    }

                    string value = "@" + Convert.ToString(tableTable.Columns[0]);
                    for (int i = 1; i < tableTable.Columns.Count; i++)
                    {
                        value += ", @" + Convert.ToString(tableTable.Columns[i]);
                    }
                    progressBar1.Maximum = FormBD.Rows.Count;
                    progressBar1.Value = 0;
                    for (int i = 0; i < FormBD.Rows.Count; i++)
                    {
                        sqlite_cmd = new SQLiteCommand("insert into "+ ComboBox.Text + "(" + colum + ") values("+ value +")", connection);
                        for (int k = 0; k < tableTable.Columns.Count; k++)
                        {
                            sqlite_cmd.Parameters.AddWithValue("@" + Convert.ToString(tableTable.Columns[k]), FormBD.Rows[i].Cells[k].Value); 
                        }
                        progressBar1.Value += 1;
                        sqlite_cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Успешно сохранено!", "Успех!");
                    progressBar1.Value = 0;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }

        }

        private void AddTab3_Click(object sender, EventArgs e)
        {
            FormBD.Rows.Add();
        }

        private void DeleteTab3_Click(object sender, EventArgs e)
        {
            int delet = FormBD.SelectedCells[0].RowIndex;
            FormBD.Rows.RemoveAt(delet);
        }
    }
}

