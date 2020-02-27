using ComputerConfigurator.BL.Controller;
using ComputerConfigurator.BL.Model;
using System;
using System.Windows.Forms;

namespace ComputerConfigurator.WF
{
    public partial class BasicForm : Form
    {
        public BasicForm()
        {
            InitializeComponent();
            
            fillComboBoxes();  
        }


        private void BasicForm_Load(object sender, EventArgs e)
        {
            Price pr = new Price();
            minPriceLabel.Text = String.Format("{0:C}", pr.LowPrice);
        }



        tableForm newForm;
        ComputerController computer = new ComputerController("null", 0);
        PartController partctrl = new PartController();

        /// <summary>
        /// Начало сборки ПК с ценой не выше чем задана пользователем. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void beginButton_Click(object sender, EventArgs e)
        {
            double result;
            if (Double.TryParse(budgetTextBox.Text,out result))
            {
                computer.CurrentPC.wantedPrice = result;
                computer.setPreset("forPrice");
                
                showPC();
            }
            else
            {
                MessageBox.Show("Число введено неправильно или отсутствует.");
            }
        }

        /// <summary>
        /// Метод для вывода полной информации о текущей сборки ПК.
        /// </summary>
        public void showPC()
        {
            motherboardComboBox.Text = computer.CurrentPC.Parts.Motherboard.Name;
            processorComboBox.Text   = computer.CurrentPC.Parts.Processor.Name;
            memoryComboBox.Text      = computer.CurrentPC.Parts.Memory.Name;
            GPUComboBox.Text         = computer.CurrentPC.Parts.GPU.Name;
            storageComboBox.Text     = computer.CurrentPC.Parts.Storage.Name;
            PSUComboBox.Text         = computer.CurrentPC.Parts.PSU.Name;
            caseComboBox.Text        = computer.CurrentPC.Parts.Case.Name;

            mbPriceLabel.Text   = String.Format("{0:C}", computer.CurrentPC.Parts.Motherboard.Price);
            prPriceLabel.Text   = String.Format("{0:C}", computer.CurrentPC.Parts.Processor.Price);
            memPriceLabel.Text  = String.Format("{0:C}", computer.CurrentPC.Parts.Memory.Price);
            gpuPricelabel.Text  = String.Format("{0:C}", computer.CurrentPC.Parts.GPU.Price);
            strPriceLabel.Text  = String.Format("{0:C}", computer.CurrentPC.Parts.Storage.Price);
            psuPriceLabel.Text  = String.Format("{0:C}", computer.CurrentPC.Parts.PSU.Price);
            casePriceLabel.Text = String.Format("{0:C}", computer.CurrentPC.Parts.Case.Price);

            sumLabel.Text       = String.Format("{0:C}", computer.CurrentPC.Price);

        }

        #region Обработка combobox'ов.
       
        /// <summary>
        /// Заполняет ячейки данными.
        /// </summary>
        private void fillComboBoxes()
        {

            var parts = Part.getList();

            //check = false;

            foreach (var part in parts)
            {
                switch (part.Type.ToLower())
                {
                    case "motherboard":
                        motherboardComboBox.Items.Add(part.Name);
                        break;

                    case "processor":
                        processorComboBox.Items.Add(part.Name);
                        break;

                    case "memory":
                        memoryComboBox.Items.Add(part.Name);
                        break;

                    case "gpu":
                        GPUComboBox.Items.Add(part.Name);
                        break;

                    case "storage":
                        storageComboBox.Items.Add(part.Name);
                        break;

                    case "psu":
                        PSUComboBox.Items.Add(part.Name);
                        break;

                    case "case":
                        caseComboBox.Items.Add(part.Name);
                        break;
                }
            }
        }

        /// <summary>
        /// Обрабатывает изменение в комбобоксах. Меняет текущий компонент сборки на выбранный. 
        /// </summary>
        /// <param name="sender">Комбобокс</param>
        /// <param name="e">Смена элемента</param>
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (((ComboBox)sender).Name)
            {
                case "motherboardComboBox":
                    computer.CurrentPC.Parts.Motherboard = partctrl.getSelectedPart(motherboardComboBox.Text);
                    break;
                case "processorComboBox":
                    computer.CurrentPC.Parts.Processor   = partctrl.getSelectedPart(processorComboBox.Text);
                    break;
                case "memoryComboBox":
                    computer.CurrentPC.Parts.Memory      = partctrl.getSelectedPart(memoryComboBox.Text);
                    break;
                case "GPUComboBox":
                    computer.CurrentPC.Parts.GPU         = partctrl.getSelectedPart(GPUComboBox.Text);
                    break;
                case "storageComboBox":
                    computer.CurrentPC.Parts.Storage     = partctrl.getSelectedPart(storageComboBox.Text);
                    break;
                case "PSUComboBox":
                    computer.CurrentPC.Parts.PSU         = partctrl.getSelectedPart(PSUComboBox.Text);
                    break;
                case "caseComboBox":
                    computer.CurrentPC.Parts.Case        = partctrl.getSelectedPart(caseComboBox.Text);
                    break;
            }

            computer.update();
            showPC();
        }

        #endregion

        #region Обработка radioButton'ов.
        /// <summary>
        /// Обработка переключения радиобаттонов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            budgetTextBox.Enabled = false;
            beginButton.Enabled   = false;

            checkPresets();
        }
        public void checkPresets()
        {
            if (gameRadioButton.Checked)
            {
                computer.setPreset("Game");
            }

            if (officeRadioButton.Checked)
            {
                computer.setPreset("Office");
            }

            if (homeRadioButton.Checked)
            {
                computer.setPreset("home");
            }

            if (forAPRadioButton.Checked)
            {
                computer.setPreset("task");
            }

            if (forPriceRadioButton.Checked)
            {

                budgetTextBox.Enabled = true;
                beginButton.Enabled = true;
            }

            showPC();
        }

        #endregion

        /// <summary>
        /// Оформление заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format(
                          $"Код трекера: {computer.CurrentPC.Name}.\n" +
                          $"\t К оплате: {String.Format("{0:C}",computer.CurrentPC.Price)}\n"+
                          $"\t Доставка: Пункт выдачи м. Шаболовская.\n"+
                          $"\t Примерная дата доставки: {DateTime.Now.AddDays(7).ToString().Substring(0,10)}"),
                          "Информация о заказе"
                          );
        }

        /// <summary>
        /// Показывает в новом окне все детали доступные в программе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showAllPartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (newForm != null && !newForm.IsDisposed && newForm.Visible)
                return;

            if (newForm == null)
                newForm = new tableForm();

            if (newForm.IsDisposed)
                newForm = new tableForm();

            newForm.Show();

             
            //newForm.Show();
        }
    }

}
