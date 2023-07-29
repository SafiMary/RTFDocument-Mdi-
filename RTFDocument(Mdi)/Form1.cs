using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTFDocument_Mdi_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButStandart.Checked = false;
            radioButMDI.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            this.Width = 800;
            this.Height = 800;
        }
        private void radioButMDI_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            if (radioButMDI.Checked)
            {
                
                FormMDI MDIForm = new FormMDI();
                MDIForm.MdiParent = this;
                MDIForm.Width = 500;
                MDIForm.Height = 500;
                MDIForm.Text = $"MDI форма ";
                MDIForm.Show();
            }
            else
            {
                if (radioButStandart.Checked)
                {
                    FormStandart StandartForm = new FormStandart();
                    StandartForm.Width = 500;
                    StandartForm.Height = 500;
                    StandartForm.Text = $"Стандартная форма ";
                    StandartForm.Show();
                }
            }
        }

        
    }
}
