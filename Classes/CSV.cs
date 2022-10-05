using System;
using System.IO;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace FlowModel.Classes
{
    /// <summary>
    /// Экспорт/Импорт в CSV формат
    /// </summary>
    class CSV
    {
        private static char separator = ';';
        /// <summary>
        /// Выгрузка в CSV файл
        /// </summary>
        public static bool ExportToCSV()
        {
            DataTable table = new DataTable();
            double step = 0;
    
            table.Columns.Add(Convert.ToString("Шаг"));
            table.Columns.Add(Convert.ToString("Температура"));
            table.Columns.Add(Convert.ToString("Вязкость"));

            DataRow row;
            
            for (int i = 0; i < Classes.Calculate.Tp.Count; i++)
            {
                row = table.NewRow();
                row["Шаг"] = step;
                row["Температура"] = Convert.ToString(Classes.Calculate.Tp[i]);
                row["Вязкость"] = Convert.ToString(Classes.Calculate.hp[i]);
                table.Rows.Add(row);

                step += Classes.Calculate.Steps;
            }


            string fileName;

            SaveFileDialog Ofd = new SaveFileDialog { Filter = "Описание файла|*.csv" };
            if (Ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (table != null)
                {
                    FileStream fs = null;
                    try
                    {
             
                        fileName = Ofd.FileName;
                        fs = File.OpenWrite(fileName);

                    }
                    catch
                    {
                        return false;
                    }
                    using (TextWriter tw = new StreamWriter(fs, Encoding.GetEncoding(1251)))
                    {
                        String line = "";
                        //Выводим имя таблицы
                        if (!String.IsNullOrEmpty(table.TableName))
                            tw.WriteLine(table.TableName);
                        //Вывод названий столбцов
                        foreach (DataColumn colName in table.Columns)
                        {
                            line += String.Format("\"{0}\"{1}", colName.ColumnName, separator);
                        }
                        tw.WriteLine(line.TrimEnd(separator));
                        //Вывод данных
                        foreach (DataRow dr in table.Rows)
                        {
                            line = "";
                            Array.ForEach(dr.ItemArray, obj => line += String.Format("\"{0}\"{1}", obj, separator));
                            tw.WriteLine(line.TrimEnd(separator));
                        }
                    }
                    fs.Close();
                    fs.Dispose();
                    return true;
                }
            }
            return false;
        }
    }
}
