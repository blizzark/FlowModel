namespace FlowModel.Forms
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteMat = new System.Windows.Forms.Button();
            this.AddMat = new System.Windows.Forms.Button();
            this.SaveMat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MatBD = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ExitToAuth = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.GroupBox();
            this.BDelete = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BSave = new System.Windows.Forms.Button();
            this.Accs = new System.Windows.Forms.DataGridView();
            this.BDLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDAccess = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeleteTab3 = new System.Windows.Forms.Button();
            this.SaveTab3 = new System.Windows.Forms.Button();
            this.FormBD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.AddTab3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatBD)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accs)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormBD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.MatBD);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(813, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Материал";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeleteMat);
            this.groupBox1.Controls.Add(this.AddMat);
            this.groupBox1.Controls.Add(this.SaveMat);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(339, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 246);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // DeleteMat
            // 
            this.DeleteMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteMat.Location = new System.Drawing.Point(14, 172);
            this.DeleteMat.Name = "DeleteMat";
            this.DeleteMat.Size = new System.Drawing.Size(443, 61);
            this.DeleteMat.TabIndex = 7;
            this.DeleteMat.Text = "Удалить выделеную строку";
            this.DeleteMat.UseVisualStyleBackColor = true;
            this.DeleteMat.Click += new System.EventHandler(this.DeleteMat_Click);
            // 
            // AddMat
            // 
            this.AddMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMat.Location = new System.Drawing.Point(14, 105);
            this.AddMat.Name = "AddMat";
            this.AddMat.Size = new System.Drawing.Size(443, 61);
            this.AddMat.TabIndex = 6;
            this.AddMat.Text = "Добавить";
            this.AddMat.UseVisualStyleBackColor = true;
            this.AddMat.Click += new System.EventHandler(this.AddMat_Click);
            // 
            // SaveMat
            // 
            this.SaveMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveMat.Location = new System.Drawing.Point(14, 38);
            this.SaveMat.Name = "SaveMat";
            this.SaveMat.Size = new System.Drawing.Size(443, 61);
            this.SaveMat.TabIndex = 1;
            this.SaveMat.Text = "Сохранить";
            this.SaveMat.UseVisualStyleBackColor = true;
            this.SaveMat.Click += new System.EventHandler(this.SaveMat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(115, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Жидкости";
            // 
            // MatBD
            // 
            this.MatBD.AllowUserToAddRows = false;
            this.MatBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatBD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NameMaterial});
            this.MatBD.Location = new System.Drawing.Point(9, 48);
            this.MatBD.Name = "MatBD";
            this.MatBD.RowHeadersVisible = false;
            this.MatBD.Size = new System.Drawing.Size(324, 344);
            this.MatBD.TabIndex = 17;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // NameMaterial
            // 
            this.NameMaterial.HeaderText = "Название жидкости";
            this.NameMaterial.Name = "NameMaterial";
            this.NameMaterial.Width = 270;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.progressBar3);
            this.tabPage1.Controls.Add(this.ExitToAuth);
            this.tabPage1.Controls.Add(this.Box);
            this.tabPage1.Controls.Add(this.Accs);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(813, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            // 
            // ExitToAuth
            // 
            this.ExitToAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitToAuth.Location = new System.Drawing.Point(345, 339);
            this.ExitToAuth.Name = "ExitToAuth";
            this.ExitToAuth.Size = new System.Drawing.Size(443, 61);
            this.ExitToAuth.TabIndex = 4;
            this.ExitToAuth.Text = "Сменить пользователя";
            this.ExitToAuth.UseVisualStyleBackColor = true;
            this.ExitToAuth.Click += new System.EventHandler(this.ExitToAuth_Click);
            // 
            // Box
            // 
            this.Box.Controls.Add(this.BDelete);
            this.Box.Controls.Add(this.BAdd);
            this.Box.Controls.Add(this.label3);
            this.Box.Controls.Add(this.BSave);
            this.Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Box.Location = new System.Drawing.Point(339, 18);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(463, 288);
            this.Box.TabIndex = 4;
            this.Box.TabStop = false;
            this.Box.Text = "Управление";
            // 
            // BDelete
            // 
            this.BDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BDelete.Location = new System.Drawing.Point(14, 214);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(443, 61);
            this.BDelete.TabIndex = 7;
            this.BDelete.Text = "Удалить выделеную строку";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BAdd
            // 
            this.BAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BAdd.Location = new System.Drawing.Point(14, 147);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(443, 61);
            this.BAdd.TabIndex = 6;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(448, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "В поле \"доступ\" галочка - админ, без галочки - исследователь\r\n";
            // 
            // BSave
            // 
            this.BSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSave.Location = new System.Drawing.Point(14, 80);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(443, 61);
            this.BSave.TabIndex = 1;
            this.BSave.Text = "Сохранить";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // Accs
            // 
            this.Accs.AllowUserToAddRows = false;
            this.Accs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Accs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BDLogin,
            this.BDPass,
            this.BDAccess});
            this.Accs.Location = new System.Drawing.Point(17, 18);
            this.Accs.Name = "Accs";
            this.Accs.RowHeadersVisible = false;
            this.Accs.Size = new System.Drawing.Size(303, 382);
            this.Accs.TabIndex = 0;
            // 
            // BDLogin
            // 
            this.BDLogin.HeaderText = "Логин";
            this.BDLogin.Name = "BDLogin";
            this.BDLogin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // BDPass
            // 
            this.BDPass.HeaderText = "Пароль";
            this.BDPass.Name = "BDPass";
            // 
            // BDAccess
            // 
            this.BDAccess.HeaderText = "Доступ";
            this.BDAccess.Name = "BDAccess";
            this.BDAccess.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BDAccess.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.progressBar1);
            this.tabPage3.Controls.Add(this.DeleteTab3);
            this.tabPage3.Controls.Add(this.SaveTab3);
            this.tabPage3.Controls.Add(this.FormBD);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.ComboBox);
            this.tabPage3.Controls.Add(this.AddTab3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(813, 426);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Таблицы";
            // 
            // DeleteTab3
            // 
            this.DeleteTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteTab3.Location = new System.Drawing.Point(602, 6);
            this.DeleteTab3.Name = "DeleteTab3";
            this.DeleteTab3.Size = new System.Drawing.Size(200, 31);
            this.DeleteTab3.TabIndex = 17;
            this.DeleteTab3.Text = "Удалить выделунную";
            this.DeleteTab3.UseVisualStyleBackColor = true;
            this.DeleteTab3.Click += new System.EventHandler(this.DeleteTab3_Click);
            // 
            // SaveTab3
            // 
            this.SaveTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveTab3.Location = new System.Drawing.Point(384, 6);
            this.SaveTab3.Name = "SaveTab3";
            this.SaveTab3.Size = new System.Drawing.Size(103, 30);
            this.SaveTab3.TabIndex = 16;
            this.SaveTab3.Text = "Сохранить";
            this.SaveTab3.UseVisualStyleBackColor = true;
            this.SaveTab3.Click += new System.EventHandler(this.SaveTab3_Click);
            // 
            // FormBD
            // 
            this.FormBD.AllowUserToAddRows = false;
            this.FormBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormBD.Location = new System.Drawing.Point(6, 43);
            this.FormBD.Name = "FormBD";
            this.FormBD.RowHeadersVisible = false;
            this.FormBD.Size = new System.Drawing.Size(801, 358);
            this.FormBD.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Выбор таблицы:";
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(138, 10);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(240, 26);
            this.ComboBox.TabIndex = 13;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged_1);
            // 
            // AddTab3
            // 
            this.AddTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTab3.Location = new System.Drawing.Point(493, 6);
            this.AddTab3.Name = "AddTab3";
            this.AddTab3.Size = new System.Drawing.Size(103, 31);
            this.AddTab3.TabIndex = 12;
            this.AddTab3.Text = "Добавить";
            this.AddTab3.UseVisualStyleBackColor = true;
            this.AddTab3.Click += new System.EventHandler(this.AddTab3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 405);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(801, 18);
            this.progressBar1.TabIndex = 18;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(3, 405);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(807, 18);
            this.progressBar2.TabIndex = 20;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(6, 405);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(801, 18);
            this.progressBar3.TabIndex = 19;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminPage";
            this.Text = "Администратор";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatBD)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accs)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Accs;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button ExitToAuth;
        private System.Windows.Forms.GroupBox Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDPass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BDAccess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteMat;
        private System.Windows.Forms.Button AddMat;
        private System.Windows.Forms.Button SaveMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView MatBD;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button DeleteTab3;
        private System.Windows.Forms.Button SaveTab3;
        private System.Windows.Forms.DataGridView FormBD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button AddTab3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMaterial;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}