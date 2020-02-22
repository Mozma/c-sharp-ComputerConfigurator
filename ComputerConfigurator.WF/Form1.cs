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
        }


        ComputerController computer;
        PartController partctrl;

        public void beginButton_Click(object sender, EventArgs e)
        {
            computer = new ComputerController("Игровой", 50000);
            partctrl = new PartController();

            fillComboBoxes();

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

            showPC();
        }


        public void showPC()
        {
            motherboardComboBox.Text = computer.CurrentPC.Parts.Motherboard.Name;
            processorComboBox.Text   = computer.CurrentPC.Parts.Processor.Name;
            memoryComboBox.Text      = computer.CurrentPC.Parts.Memory.Name;
            GPUComboBox.Text         = computer.CurrentPC.Parts.GPU.Name;
            storageComboBox.Text     = computer.CurrentPC.Parts.Storage.Name;
            PSUComboBox.Text         = computer.CurrentPC.Parts.PSU.Name;
            caseComboBox.Text        = computer.CurrentPC.Parts.Case.Name;
        }


        /// <summary>
        /// Заполняет ячейки данными.
        /// </summary>
        private void fillComboBoxes()
        {

            var parts = Part.getList();
            
            
            
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


            //foreach (var part in partctrl.getAllPartsOfOneType("motherboard"))
            //    motherboardvComboBox.Items.Add(part.Name);
            //foreach (var part in partctrl.getAllPartsOfOneType("processor"))
            //    processorComboBox.Items.Add(part.Name);
            //foreach (var part in partctrl.getAllPartsOfOneType("memory"))
            //    memoryComboBox.Items.Add(part.Name);
            //foreach (var part in partctrl.getAllPartsOfOneType("gpu"))
            //    GPUComboBox.Items.Add(part.Name);
            //foreach (var part in partctrl.getAllPartsOfOneType("storage"))
            //    storageComboBox.Items.Add(part.Name);
            //foreach (var part in partctrl.getAllPartsOfOneType("psu"))
            //    PSUComboBox.Items.Add(part.Name);
            //foreach (var part in partctrl.getAllPartsOfOneType("case"))
            //    caseComboBox.Items.Add(part.Name);
        }
    }
}
