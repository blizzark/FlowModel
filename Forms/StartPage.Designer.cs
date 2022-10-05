namespace FlowModel.Forms
{
    partial class StartPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.BLength = new System.Windows.Forms.TextBox();
            this.BDepth = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.BMeltingPoint = new System.Windows.Forms.TextBox();
            this.BSpecificHeat = new System.Windows.Forms.TextBox();
            this.BDensity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.BСoverTemperature = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.BCoverSpeed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.BStep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.BKHeatDissipation = new System.Windows.Forms.TextBox();
            this.BCurrentIndex = new System.Windows.Forms.TextBox();
            this.BCastTemperature = new System.Windows.Forms.TextBox();
            this.BKTemperature = new System.Windows.Forms.TextBox();
            this.BKConsistency = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.Material = new System.Windows.Forms.ComboBox();
            this.Tabl = new System.Windows.Forms.Button();
            this.Graf = new System.Windows.Forms.Button();
            this.ExitToAuth = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.ExitToAuth});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(269, 30);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info});
            this.помощьToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // Info
            // 
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(198, 30);
            this.Info.Text = "Разработчики";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Входные параметры:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.BLength);
            this.groupBox1.Controls.Add(this.BDepth);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.BWidth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Геометрические параметры:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(177, 126);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "м";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(177, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "м";
            // 
            // BLength
            // 
            this.BLength.Location = new System.Drawing.Point(101, 120);
            this.BLength.Name = "BLength";
            this.BLength.Size = new System.Drawing.Size(70, 23);
            this.BLength.TabIndex = 6;
            // 
            // BDepth
            // 
            this.BDepth.Location = new System.Drawing.Point(101, 83);
            this.BDepth.Name = "BDepth";
            this.BDepth.Size = new System.Drawing.Size(70, 23);
            this.BDepth.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(177, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 17);
            this.label16.TabIndex = 4;
            this.label16.Text = "м";
            // 
            // BWidth
            // 
            this.BWidth.Location = new System.Drawing.Point(101, 45);
            this.BWidth.Name = "BWidth";
            this.BWidth.Size = new System.Drawing.Size(70, 23);
            this.BWidth.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Глубина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ширина";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.BMeltingPoint);
            this.groupBox2.Controls.Add(this.BSpecificHeat);
            this.groupBox2.Controls.Add(this.BDensity);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(262, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 187);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры свойств материала:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(188, 148);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 17);
            this.label21.TabIndex = 13;
            this.label21.Text = "С";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(185, 98);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 17);
            this.label20.TabIndex = 12;
            this.label20.Text = "Дж/(кг*С)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(185, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 17);
            this.label19.TabIndex = 9;
            this.label19.Text = "кг/м^3";
            // 
            // BMeltingPoint
            // 
            this.BMeltingPoint.Location = new System.Drawing.Point(112, 145);
            this.BMeltingPoint.Name = "BMeltingPoint";
            this.BMeltingPoint.Size = new System.Drawing.Size(70, 23);
            this.BMeltingPoint.TabIndex = 11;
            // 
            // BSpecificHeat
            // 
            this.BSpecificHeat.Location = new System.Drawing.Point(112, 94);
            this.BSpecificHeat.Name = "BSpecificHeat";
            this.BSpecificHeat.Size = new System.Drawing.Size(70, 23);
            this.BSpecificHeat.TabIndex = 10;
            // 
            // BDensity
            // 
            this.BDensity.Location = new System.Drawing.Point(112, 42);
            this.BDensity.Name = "BDensity";
            this.BDensity.Size = new System.Drawing.Size(70, 23);
            this.BDensity.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 34);
            this.label7.TabIndex = 5;
            this.label7.Text = "Температура\r\nплавления";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "Удельная\r\nтеплоёмкость";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Плотность";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.BСoverTemperature);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.BCoverSpeed);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(16, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 126);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Режимные параметры процесса:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(201, 91);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 17);
            this.label23.TabIndex = 14;
            this.label23.Text = "С";
            // 
            // BСoverTemperature
            // 
            this.BСoverTemperature.Location = new System.Drawing.Point(125, 88);
            this.BСoverTemperature.Name = "BСoverTemperature";
            this.BСoverTemperature.Size = new System.Drawing.Size(70, 23);
            this.BСoverTemperature.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(201, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 17);
            this.label22.TabIndex = 9;
            this.label22.Text = "м/с";
            // 
            // BCoverSpeed
            // 
            this.BCoverSpeed.Location = new System.Drawing.Point(125, 39);
            this.BCoverSpeed.Name = "BCoverSpeed";
            this.BCoverSpeed.Size = new System.Drawing.Size(70, 23);
            this.BCoverSpeed.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 34);
            this.label9.TabIndex = 7;
            this.label9.Text = "Температура\r\nкрышки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 34);
            this.label8.TabIndex = 6;
            this.label8.Text = "Скорость\r\nкрышки";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.BStep);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(262, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(251, 117);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры метода решения модели:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(216, 60);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 17);
            this.label24.TabIndex = 9;
            this.label24.Text = "м";
            // 
            // BStep
            // 
            this.BStep.Location = new System.Drawing.Point(135, 57);
            this.BStep.Name = "BStep";
            this.BStep.Size = new System.Drawing.Size(70, 23);
            this.BStep.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 34);
            this.label10.TabIndex = 6;
            this.label10.Text = "Шаг расчёта\r\nпо длине канала";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.BKHeatDissipation);
            this.groupBox5.Controls.Add(this.BCurrentIndex);
            this.groupBox5.Controls.Add(this.BCastTemperature);
            this.groupBox5.Controls.Add(this.BKTemperature);
            this.groupBox5.Controls.Add(this.BKConsistency);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(519, 66);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(386, 319);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Эмпирические коэффициенты математической модели:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(304, 259);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(76, 17);
            this.label28.TabIndex = 23;
            this.label28.Text = "Вт/(м^2*С)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(304, 161);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(17, 17);
            this.label27.TabIndex = 14;
            this.label27.Text = "С";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(304, 107);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 17);
            this.label26.TabIndex = 22;
            this.label26.Text = "1/С";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(304, 57);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 17);
            this.label25.TabIndex = 17;
            this.label25.Text = "Па*с^n";
            // 
            // BKHeatDissipation
            // 
            this.BKHeatDissipation.Location = new System.Drawing.Point(228, 255);
            this.BKHeatDissipation.Name = "BKHeatDissipation";
            this.BKHeatDissipation.Size = new System.Drawing.Size(70, 23);
            this.BKHeatDissipation.TabIndex = 21;
            // 
            // BCurrentIndex
            // 
            this.BCurrentIndex.Location = new System.Drawing.Point(228, 208);
            this.BCurrentIndex.Name = "BCurrentIndex";
            this.BCurrentIndex.Size = new System.Drawing.Size(70, 23);
            this.BCurrentIndex.TabIndex = 20;
            // 
            // BCastTemperature
            // 
            this.BCastTemperature.Location = new System.Drawing.Point(228, 158);
            this.BCastTemperature.Name = "BCastTemperature";
            this.BCastTemperature.Size = new System.Drawing.Size(70, 23);
            this.BCastTemperature.TabIndex = 19;
            // 
            // BKTemperature
            // 
            this.BKTemperature.Location = new System.Drawing.Point(228, 104);
            this.BKTemperature.Name = "BKTemperature";
            this.BKTemperature.Size = new System.Drawing.Size(70, 23);
            this.BKTemperature.TabIndex = 18;
            // 
            // BKConsistency
            // 
            this.BKConsistency.Location = new System.Drawing.Point(228, 54);
            this.BKConsistency.Name = "BKConsistency";
            this.BKConsistency.Size = new System.Drawing.Size(70, 23);
            this.BKConsistency.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(215, 34);
            this.label15.TabIndex = 10;
            this.label15.Text = "Коэффициент теплоотдачи\r\nот крышки канала к материалу";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 34);
            this.label14.TabIndex = 9;
            this.label14.Text = "Индекс\r\nтечения";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 34);
            this.label13.TabIndex = 8;
            this.label13.Text = "Температура\r\nприведения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 34);
            this.label12.TabIndex = 7;
            this.label12.Text = "Температурный\r\nкоэффициент вызкости";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 34);
            this.label11.TabIndex = 6;
            this.label11.Text = "Коэффициент консинстенции\r\nпри температуре приведения";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(516, 39);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(87, 17);
            this.label29.TabIndex = 7;
            this.label29.Text = "Материал:";
            // 
            // Material
            // 
            this.Material.FormattingEnabled = true;
            this.Material.Location = new System.Drawing.Point(609, 38);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(208, 21);
            this.Material.TabIndex = 8;
            this.Material.SelectedIndexChanged += new System.EventHandler(this.Material_SelectedIndexChanged);
            // 
            // Tabl
            // 
            this.Tabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tabl.Location = new System.Drawing.Point(262, 391);
            this.Tabl.Name = "Tabl";
            this.Tabl.Size = new System.Drawing.Size(175, 55);
            this.Tabl.TabIndex = 9;
            this.Tabl.Text = "Показать таблицу";
            this.Tabl.UseVisualStyleBackColor = true;
            this.Tabl.Click += new System.EventHandler(this.Tabl_Click);
            // 
            // Graf
            // 
            this.Graf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Graf.Location = new System.Drawing.Point(443, 391);
            this.Graf.Name = "Graf";
            this.Graf.Size = new System.Drawing.Size(178, 55);
            this.Graf.TabIndex = 10;
            this.Graf.Text = "Показать графики\r";
            this.Graf.UseVisualStyleBackColor = true;
            this.Graf.Click += new System.EventHandler(this.Graf_Click);
            // 
            // ExitToAuth
            // 
            this.ExitToAuth.Name = "ExitToAuth";
            this.ExitToAuth.Size = new System.Drawing.Size(269, 30);
            this.ExitToAuth.Text = "Сменить пользователя";
            this.ExitToAuth.Click += new System.EventHandler(this.ExitToAuth_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(917, 453);
            this.Controls.Add(this.Graf);
            this.Controls.Add(this.Tabl);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "StartPage";
            this.Text = "Программный комплекс для исследования неизотермического течения аномально-вязких " +
    "материалов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox BLength;
        private System.Windows.Forms.TextBox BDepth;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox BWidth;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox BMeltingPoint;
        private System.Windows.Forms.TextBox BSpecificHeat;
        private System.Windows.Forms.TextBox BDensity;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox BСoverTemperature;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox BCoverSpeed;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox BStep;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox BKHeatDissipation;
        private System.Windows.Forms.TextBox BCurrentIndex;
        private System.Windows.Forms.TextBox BCastTemperature;
        private System.Windows.Forms.TextBox BKTemperature;
        private System.Windows.Forms.TextBox BKConsistency;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox Material;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Info;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.Button Tabl;
        private System.Windows.Forms.Button Graf;
        private System.Windows.Forms.ToolStripMenuItem ExitToAuth;
    }
}