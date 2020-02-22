namespace ComputerConfigurator.WF
{
    partial class BasicForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.beginButton = new System.Windows.Forms.Button();
            this.presetsGroupBox = new System.Windows.Forms.GroupBox();
            this.notebookRadioButton = new System.Windows.Forms.RadioButton();
            this.forAPRadioButton = new System.Windows.Forms.RadioButton();
            this.homeRadioButton = new System.Windows.Forms.RadioButton();
            this.officeRadioButton = new System.Windows.Forms.RadioButton();
            this.gameRadioButton = new System.Windows.Forms.RadioButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.storageLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.motherboardLabel = new System.Windows.Forms.Label();
            this.caseComboBox = new System.Windows.Forms.ComboBox();
            this.PSUComboBox = new System.Windows.Forms.ComboBox();
            this.storageComboBox = new System.Windows.Forms.ComboBox();
            this.GPUComboBox = new System.Windows.Forms.ComboBox();
            this.memoryComboBox = new System.Windows.Forms.ComboBox();
            this.processorComboBox = new System.Windows.Forms.ComboBox();
            this.motherboardComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.startPanel.SuspendLayout();
            this.presetsGroupBox.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.startPanel.Controls.Add(this.label1);
            this.startPanel.Controls.Add(this.textBox1);
            this.startPanel.Controls.Add(this.beginButton);
            this.startPanel.Controls.Add(this.presetsGroupBox);
            this.startPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.startPanel.Location = new System.Drawing.Point(0, 0);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(470, 98);
            this.startPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Готов потратить:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(110, 67);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(100, 23);
            this.beginButton.TabIndex = 2;
            this.beginButton.Text = "Начать подбор";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // presetsGroupBox
            // 
            this.presetsGroupBox.Controls.Add(this.notebookRadioButton);
            this.presetsGroupBox.Controls.Add(this.forAPRadioButton);
            this.presetsGroupBox.Controls.Add(this.homeRadioButton);
            this.presetsGroupBox.Controls.Add(this.officeRadioButton);
            this.presetsGroupBox.Controls.Add(this.gameRadioButton);
            this.presetsGroupBox.Location = new System.Drawing.Point(4, 3);
            this.presetsGroupBox.Name = "presetsGroupBox";
            this.presetsGroupBox.Size = new System.Drawing.Size(456, 47);
            this.presetsGroupBox.TabIndex = 1;
            this.presetsGroupBox.TabStop = false;
            this.presetsGroupBox.Text = "Готовые сборки";
            // 
            // notebookRadioButton
            // 
            this.notebookRadioButton.AutoSize = true;
            this.notebookRadioButton.Location = new System.Drawing.Point(373, 19);
            this.notebookRadioButton.Name = "notebookRadioButton";
            this.notebookRadioButton.Size = new System.Drawing.Size(66, 17);
            this.notebookRadioButton.TabIndex = 4;
            this.notebookRadioButton.TabStop = true;
            this.notebookRadioButton.Text = "Ноутбук";
            this.notebookRadioButton.UseVisualStyleBackColor = true;
            // 
            // forAPRadioButton
            // 
            this.forAPRadioButton.AutoSize = true;
            this.forAPRadioButton.Location = new System.Drawing.Point(271, 19);
            this.forAPRadioButton.Name = "forAPRadioButton";
            this.forAPRadioButton.Size = new System.Drawing.Size(96, 17);
            this.forAPRadioButton.TabIndex = 3;
            this.forAPRadioButton.TabStop = true;
            this.forAPRadioButton.Text = "Для задач АП";
            this.forAPRadioButton.UseVisualStyleBackColor = true;
            // 
            // homeRadioButton
            // 
            this.homeRadioButton.AutoSize = true;
            this.homeRadioButton.Location = new System.Drawing.Point(187, 19);
            this.homeRadioButton.Name = "homeRadioButton";
            this.homeRadioButton.Size = new System.Drawing.Size(78, 17);
            this.homeRadioButton.TabIndex = 2;
            this.homeRadioButton.TabStop = true;
            this.homeRadioButton.Text = "Для Дома";
            this.homeRadioButton.UseVisualStyleBackColor = true;
            // 
            // officeRadioButton
            // 
            this.officeRadioButton.AutoSize = true;
            this.officeRadioButton.Location = new System.Drawing.Point(98, 19);
            this.officeRadioButton.Name = "officeRadioButton";
            this.officeRadioButton.Size = new System.Drawing.Size(83, 17);
            this.officeRadioButton.TabIndex = 1;
            this.officeRadioButton.TabStop = true;
            this.officeRadioButton.Text = "Для Офиса";
            this.officeRadioButton.UseVisualStyleBackColor = true;
            // 
            // gameRadioButton
            // 
            this.gameRadioButton.AutoSize = true;
            this.gameRadioButton.Location = new System.Drawing.Point(6, 19);
            this.gameRadioButton.Name = "gameRadioButton";
            this.gameRadioButton.Size = new System.Drawing.Size(86, 17);
            this.gameRadioButton.TabIndex = 0;
            this.gameRadioButton.TabStop = true;
            this.gameRadioButton.Text = "Игровой ПК";
            this.gameRadioButton.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.label11);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.comboBox7);
            this.mainPanel.Controls.Add(this.comboBox6);
            this.mainPanel.Controls.Add(this.comboBox5);
            this.mainPanel.Controls.Add(this.comboBox4);
            this.mainPanel.Controls.Add(this.comboBox3);
            this.mainPanel.Controls.Add(this.comboBox2);
            this.mainPanel.Controls.Add(this.comboBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 98);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(470, 270);
            this.mainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.storageLabel);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.motherboardLabel);
            this.panel1.Controls.Add(this.caseComboBox);
            this.panel1.Controls.Add(this.PSUComboBox);
            this.panel1.Controls.Add(this.storageComboBox);
            this.panel1.Controls.Add(this.GPUComboBox);
            this.panel1.Controls.Add(this.memoryComboBox);
            this.panel1.Controls.Add(this.processorComboBox);
            this.panel1.Controls.Add(this.motherboardComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 270);
            this.panel1.TabIndex = 17;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(343, 184);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 21);
            this.label26.TabIndex = 21;
            this.label26.Text = "Цена";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(343, 158);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 21);
            this.label24.TabIndex = 20;
            this.label24.Text = "Цена";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(343, 130);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(112, 21);
            this.label25.TabIndex = 19;
            this.label25.Text = "Цена";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(343, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 21);
            this.label22.TabIndex = 18;
            this.label22.Text = "Цена";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(343, 76);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 21);
            this.label23.TabIndex = 17;
            this.label23.Text = "Цена";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(343, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "Цена";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(343, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 21);
            this.label13.TabIndex = 15;
            this.label13.Text = "Цена";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(7, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 21);
            this.label15.TabIndex = 13;
            this.label15.Text = "Корпус:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(7, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 21);
            this.label16.TabIndex = 12;
            this.label16.Text = "Блок питания:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // storageLabel
            // 
            this.storageLabel.Location = new System.Drawing.Point(7, 130);
            this.storageLabel.Name = "storageLabel";
            this.storageLabel.Size = new System.Drawing.Size(127, 21);
            this.storageLabel.TabIndex = 11;
            this.storageLabel.Text = "Диск:";
            this.storageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(7, 103);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 21);
            this.label18.TabIndex = 10;
            this.label18.Text = "Видеокарта:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(7, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 21);
            this.label19.TabIndex = 9;
            this.label19.Text = "Оперативная память:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(7, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 21);
            this.label20.TabIndex = 8;
            this.label20.Text = "Процессор:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // motherboardLabel
            // 
            this.motherboardLabel.Location = new System.Drawing.Point(7, 22);
            this.motherboardLabel.Name = "motherboardLabel";
            this.motherboardLabel.Size = new System.Drawing.Size(127, 21);
            this.motherboardLabel.TabIndex = 7;
            this.motherboardLabel.Text = "Материнская плата:";
            this.motherboardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // caseComboBox
            // 
            this.caseComboBox.FormattingEnabled = true;
            this.caseComboBox.Location = new System.Drawing.Point(140, 184);
            this.caseComboBox.Name = "caseComboBox";
            this.caseComboBox.Size = new System.Drawing.Size(197, 21);
            this.caseComboBox.TabIndex = 6;
            // 
            // PSUComboBox
            // 
            this.PSUComboBox.FormattingEnabled = true;
            this.PSUComboBox.Location = new System.Drawing.Point(140, 157);
            this.PSUComboBox.Name = "PSUComboBox";
            this.PSUComboBox.Size = new System.Drawing.Size(197, 21);
            this.PSUComboBox.TabIndex = 5;
            // 
            // storageComboBox
            // 
            this.storageComboBox.FormattingEnabled = true;
            this.storageComboBox.Location = new System.Drawing.Point(140, 130);
            this.storageComboBox.Name = "storageComboBox";
            this.storageComboBox.Size = new System.Drawing.Size(197, 21);
            this.storageComboBox.TabIndex = 4;
            // 
            // GPUComboBox
            // 
            this.GPUComboBox.FormattingEnabled = true;
            this.GPUComboBox.Location = new System.Drawing.Point(140, 103);
            this.GPUComboBox.Name = "GPUComboBox";
            this.GPUComboBox.Size = new System.Drawing.Size(197, 21);
            this.GPUComboBox.TabIndex = 3;
            // 
            // memoryComboBox
            // 
            this.memoryComboBox.FormattingEnabled = true;
            this.memoryComboBox.Location = new System.Drawing.Point(140, 76);
            this.memoryComboBox.Name = "memoryComboBox";
            this.memoryComboBox.Size = new System.Drawing.Size(197, 21);
            this.memoryComboBox.TabIndex = 2;
            // 
            // processorComboBox
            // 
            this.processorComboBox.FormattingEnabled = true;
            this.processorComboBox.Location = new System.Drawing.Point(140, 49);
            this.processorComboBox.Name = "processorComboBox";
            this.processorComboBox.Size = new System.Drawing.Size(197, 21);
            this.processorComboBox.TabIndex = 1;
            // 
            // motherboardComboBox
            // 
            this.motherboardComboBox.FormattingEnabled = true;
            this.motherboardComboBox.Location = new System.Drawing.Point(140, 22);
            this.motherboardComboBox.Name = "motherboardComboBox";
            this.motherboardComboBox.Size = new System.Drawing.Size(197, 21);
            this.motherboardComboBox.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(331, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "Цена";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(331, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "Цена";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(328, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Цена";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Материнская плата:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Материнская плата:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Материнская плата:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Материнская плата:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Материнская плата:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Материнская плата:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Материнская плата:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(125, 184);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(197, 21);
            this.comboBox7.TabIndex = 6;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(125, 157);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(197, 21);
            this.comboBox6.TabIndex = 5;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(125, 130);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(197, 21);
            this.comboBox5.TabIndex = 4;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(125, 103);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(197, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(125, 76);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(197, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(197, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // BasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 368);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.startPanel);
            this.Name = "BasicForm";
            this.ShowIcon = false;
            this.Text = "Компьютерный конфигуратор";
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.presetsGroupBox.ResumeLayout(false);
            this.presetsGroupBox.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.GroupBox presetsGroupBox;
        private System.Windows.Forms.RadioButton notebookRadioButton;
        private System.Windows.Forms.RadioButton forAPRadioButton;
        private System.Windows.Forms.RadioButton homeRadioButton;
        private System.Windows.Forms.RadioButton officeRadioButton;
        private System.Windows.Forms.RadioButton gameRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label storageLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label motherboardLabel;
        private System.Windows.Forms.ComboBox caseComboBox;
        private System.Windows.Forms.ComboBox PSUComboBox;
        private System.Windows.Forms.ComboBox storageComboBox;
        private System.Windows.Forms.ComboBox GPUComboBox;
        private System.Windows.Forms.ComboBox memoryComboBox;
        private System.Windows.Forms.ComboBox processorComboBox;
        private System.Windows.Forms.ComboBox motherboardComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox7;
    }
}

