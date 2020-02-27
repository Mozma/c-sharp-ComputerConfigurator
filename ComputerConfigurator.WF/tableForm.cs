using ComputerConfigurator.BL.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerConfigurator.WF
{
    public partial class tableForm : Form
    {
        public tableForm()
        {
            InitializeComponent();
        }

        PartController partctrl = new PartController(); 

        private void tableForm_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = PartController.parts;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
