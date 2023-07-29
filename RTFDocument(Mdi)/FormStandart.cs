using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RTFDocument_Mdi_
{
    public partial class FormStandart : Form
    {
        InstalledFontCollection inst = new InstalledFontCollection();
        
      
        public FormStandart()
        {
            InitializeComponent();
 
            foreach (var x in inst.Families)//заполнили comboBox шрифтами
            {
                comboBoxStyle.Items.Add(x.Name);
            }
            for (int i = 1; i < 50; i++)//заполнили comboBox размерами текста
            {
                comboBoxSize.Items.Add(i);
            }

        }
        
        private void FormStandart_Load(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 500;
         
        }
        private void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {//связали выбор в комбобокс с ричтекстбокс
            if (comboBoxStyle.SelectedIndex != -1)
                richTextBoxStandart.Font = new Font(inst.Families[comboBoxStyle.SelectedIndex], 10F, FontStyle.Bold);
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSize.SelectedIndex != -1 && comboBoxStyle.SelectedIndex != -1)
                richTextBoxStandart.Font = new Font(inst.Families[comboBoxStyle.SelectedIndex],int.Parse(comboBoxSize.SelectedItem.ToString()));
            
            
        }
        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;// расширенное окно для выбора цвета
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета 
            richTextBoxStandart.SelectionColor = colorDialog1.Color;
        }
       

        private void butSave_Click(object sender, EventArgs e)// сохраняет и перезаписывает файл, создает если нет файла
        {
            saveFileDialog1.FileName = "myRTFText";
            saveFileDialog1.DefaultExt = "rtf";//Расширение имени файла по умолчанию
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.CreatePrompt = true;//если указан не существующий файл, то будет отображаться сообщение о его создании
            saveFileDialog1.OverwritePrompt = false; //если указан существующий файл, то будет отображаться сообщение о том, что файл не будет перезаписан
            saveFileDialog1.InitialDirectory = @"D:/";//устанавливает каталог, который отображается при первом вызове окна
            saveFileDialog1.Title = "Сохраните свой файл здесь";
            saveFileDialog1.Filter = "RTF files (*.rtf)|*.rtf|Все файлы (*.*)|*.*";
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false))
                {
                    foreach (var item in richTextBoxStandart.Text)
                        sw.Write(item.ToString());
                    MessageBox.Show("Файл сохранен");
                }

            }
        }

        private void butOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                // получаем выбранный файл
                string filename = openFileDialog1.FileName;
                // читаем файл в строку
                string fileText = System.IO.File.ReadAllText(filename);
                richTextBoxStandart.Text = fileText;
                MessageBox.Show("Файл открыт");


            }
        }

        
    }
}
