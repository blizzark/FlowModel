using System;
using System.Data;
using System.Data.SQLite;

namespace FlowModel.Classes
{
    /// <summary>
    /// Все данные в таблице
    /// </summary>
    class Materials  // по хорошему этот класс лучше разделить на много маленьких, но мне лень. (сделать в будущем)
    {
        private SQLiteConnection _db;
        private double width { get; set; } 
        private double depth { get; set; } 
        private double length { get; set; } 
        private double density { get; set; } 
        private double specificHeat { get; set; } 
        private double meltingPoint { get; set; } 
        private double coverSpeed { get; set; } 
        private double coverTemperature { get; set; }  
        private double step { get; set; } 
        private double kConsistency { get; set; } 
        private double kTemperature { get; set; } 
        private double castTemperature{ get; set; }  
        private double currentIndex { get; set; } 
        private double kHeatDissipation { get; set; }

        public Materials(int IDMat)
        {
            _db = new SQLiteConnection("Data source=AuthorizationBD.db; Version=3");
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            // таблица, в которую запишется всё, что нашлось
            DataTable table = new DataTable();
            // команда на поиск строк с логином и паролем
            SQLiteCommand _command = new SQLiteCommand("select * from ParamValue where IDMat = @Material", _db);
            // подмена заглушек (нужны для безопасности)
            _command.Parameters.Add("@Material", DbType.AnsiString).Value = IDMat;
            // вызов команды
            adapter.SelectCommand = _command;
            adapter.Fill(table);

            int indx = 0;


            if (table.Rows.Count >= 14)
            {
                foreach (DataRow row in table.Rows) // это просто отвратительно. Пока не знаю чем заменить.. Особенно магические цифры 1..14 мне нравятся..
                {
                    if (Convert.ToInt32(table.Rows[indx][2]) == 1)
                    {
                        this.Width = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 2)
                    {
                        this.Depth = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 3)
                    {
                        this.Length = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 4)
                    {
                        this.Density = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 5)
                    {
                        this.SpecificHeat = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 6)
                    {
                        this.MeltingPoint = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 7)
                    {
                        this.CoverSpeed = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 8)
                    {
                        this.СoverTemperature = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 9)
                    {
                        this.Step = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 10)
                    {
                        this.KConsistency = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 11)
                    {
                        this.KTemperature = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 12)
                    {
                        this.CastTemperature = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 13)
                    {
                        this.CurrentIndex = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    if (Convert.ToInt32(table.Rows[indx][2]) == 14)
                    {
                        this.KHeatDissipation = Convert.ToDouble(table.Rows[indx][0]);
                    }
                    indx++;
                }
            }
            else
            {
                throw new Exception("База неполная или данные некорректны!");
            }


           
        }

        // Конструктор, который принимает всё. Да, это неудобно, зато просто)
        public Materials(double Width, double Depth, double Length, double Density, double SpecificHeat,
            double MeltingPoint, double CoverSpeed, double СoverTemperature, double Step, double KConsistency,
            double KTemperature, double CastTemperature, double CurrentIndex, double KHeatDissipation)
        {
            this.Width = Width;
            this.Depth = Depth;
            this.Length = Length;
            this.Density = Density;
            this.SpecificHeat = SpecificHeat;
            this.MeltingPoint = MeltingPoint;
            this.CoverSpeed = CoverSpeed;
            this.СoverTemperature = СoverTemperature;
            this.Step = Step;
            this.KConsistency = KConsistency;
            this.KTemperature = KTemperature;
            this.CastTemperature = CastTemperature;
            this.CurrentIndex = CurrentIndex;
            this.KHeatDissipation = KHeatDissipation;
        }

        // Сделал это, потому что я не знаю какие границы и одинаковые ли они для всех параметров. Если надо подправь на нужные границы :з

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width 
        {
            get
            {
                return width;
            }
            set
            {
                if (value.GetType() == Width.GetType()) {
                    if (value > 0 && value < 10000)
                        width = value;
                    else
                        throw new ArgumentOutOfRangeException("0 < Ширина < 10000");

                    
                }
                else
                    throw new ArgumentException("Ширина указывается только числом!");  // было бы прикольно указывать на тексБокс, который введёт неверно. Для этого надо проверять это выше, а не тут. Лень.
            }
        }
        /// <summary>
        /// Глубина
        /// </summary>
        public double Depth 
        {
            get
            {
                return depth;
            }
            set
            {
                if (value > 0 && value < 10000)
                    depth = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Глубина < 10000");
            }
        }
        /// <summary>
        /// Длина
        /// </summary>
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0 && value < 10000)
                    length = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Длина < 10000");
            }
        }
        /// <summary>
        /// Плотность
        /// </summary>
        public double Density
        {
            get
            {
                return density;
            }
            set
            {
                if (value > 0 && value < 10000)
                    density = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Плотность < 10000");
            }
        }
        /// <summary>
        /// Удельная теплоёмкость
        /// </summary>
        public double SpecificHeat
        {
            get
            {
                return specificHeat;
            }
            set
            {
                if (value > 0 && value < 10000)
                    specificHeat = value;
                else
                    throw new ArgumentOutOfRangeException("0 <= Удельная теплоёмкость < 10000");
            }
        }
        /// <summary>
        /// Температура плавления
        /// </summary>
        public double MeltingPoint
        {
            get
            {
                return meltingPoint;
            }
            set
            {
                if (value >= 0 && value < 10000)
                    meltingPoint = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Температура плавления < 10000");
            }
        }
        /// <summary>
        /// Скорость кришки
        /// </summary>
        public double CoverSpeed
        {
            get
            {
                return coverSpeed;
            }
            set
            {
                if (value > 0 && value < 10000)
                    coverSpeed = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Скорость кришки < 10000");
            }
        }
        /// <summary>
        /// Температура крышки
        /// </summary>
        public double СoverTemperature
        {
            get
            {
                return coverTemperature;
            }
            set
            {
                if (value >= 0 && value < 10000)
                    coverTemperature = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Температура крышки < 10000");
            }
        }
        /// <summary>
        /// Шаг расчёта по длине канала
        /// </summary>
        public double Step
        {
            get
            {
                return step;
            }
            set
            {
                if (value > 0 && value < 10000)
                    step = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Шаг < 10000");
            }
        }
        /// <summary>
        /// Коэфф. консистенции при Температура приведения
        /// </summary>
        public double KConsistency
        {
            get
            {
                return kConsistency;
            }
            set
            {
                if (value > 0 && value < 100000)
                    kConsistency = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Коэфф. консистенции при температура приведения < 10000");
            }
        }
        /// <summary>
        ///  Температурный коэфф. вязкости
        /// </summary>
        public double KTemperature
        {
            get
            {
                return kTemperature;
            }
            set
            {
                if (value > 0 && value < 10000)
                    kTemperature = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Температурный коэфф. вязкости < 10000");
            }
        }
        /// <summary>
        /// Температура приведения
        /// </summary>
        public double CastTemperature
        {
            get
            {
                return castTemperature;
            }
            set
            {
                if (value > 0 && value < 10000)
                    castTemperature = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Температура приведения < 10000");
            }
        }
        /// <summary>
        /// Индекс течения
        /// </summary>
        public double CurrentIndex
        {
            get
            {
                return currentIndex;
            }
            set
            {
                if (value > 0 && value < 10000)
                    currentIndex = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Индекс течения < 10000");
            }
        }
        /// <summary>
        /// Коэфф. теплоотдачи от крышки канала к материалу
        /// </summary>
        public double KHeatDissipation
        {
            get
            {
                return kHeatDissipation;
            }
            set
            {
                if (value > 0 && value < 10000)
                    kHeatDissipation = value;
                else
                    throw new ArgumentOutOfRangeException("0 < Коэфф. теплоотдачи от крышки канала к материалу < 10000");
            }
        }
    }
}
