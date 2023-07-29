namespace RTFDocument_Mdi_
{
    partial class FormStandart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStandart));
            this.grBoxStyleText = new System.Windows.Forms.GroupBox();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.grBoxSizeText = new System.Windows.Forms.GroupBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.grBoxColourText = new System.Windows.Forms.GroupBox();
            this.butOpen = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.richTextBoxStandart = new System.Windows.Forms.RichTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grBoxStyleText.SuspendLayout();
            this.grBoxSizeText.SuspendLayout();
            this.grBoxColourText.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBoxStyleText
            // 
            this.grBoxStyleText.Controls.Add(this.comboBoxStyle);
            this.grBoxStyleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxStyleText.Location = new System.Drawing.Point(32, 32);
            this.grBoxStyleText.Name = "grBoxStyleText";
            this.grBoxStyleText.Size = new System.Drawing.Size(200, 100);
            this.grBoxStyleText.TabIndex = 0;
            this.grBoxStyleText.TabStop = false;
            this.grBoxStyleText.Text = "Выберите стиль текста";
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(7, 54);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(187, 28);
            this.comboBoxStyle.TabIndex = 0;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            // 
            // grBoxSizeText
            // 
            this.grBoxSizeText.Controls.Add(this.comboBoxSize);
            this.grBoxSizeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxSizeText.Location = new System.Drawing.Point(280, 32);
            this.grBoxSizeText.Name = "grBoxSizeText";
            this.grBoxSizeText.Size = new System.Drawing.Size(200, 100);
            this.grBoxSizeText.TabIndex = 1;
            this.grBoxSizeText.TabStop = false;
            this.grBoxSizeText.Text = "Выберите размер текста";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(17, 54);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(177, 28);
            this.comboBoxSize.TabIndex = 0;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // grBoxColourText
            // 
            this.grBoxColourText.Controls.Add(this.buttonColor);
            this.grBoxColourText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxColourText.Location = new System.Drawing.Point(557, 32);
            this.grBoxColourText.Name = "grBoxColourText";
            this.grBoxColourText.Size = new System.Drawing.Size(200, 100);
            this.grBoxColourText.TabIndex = 2;
            this.grBoxColourText.TabStop = false;
            this.grBoxColourText.Text = "Выберите цвет текста";
            // 
            // butOpen
            // 
            this.butOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butOpen.Location = new System.Drawing.Point(32, 350);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(123, 57);
            this.butOpen.TabIndex = 3;
            this.butOpen.Text = "открыть";
            this.butOpen.UseVisualStyleBackColor = true;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // butSave
            // 
            this.butSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(634, 350);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(123, 57);
            this.butSave.TabIndex = 3;
            this.butSave.Text = "сохранить";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // richTextBoxStandart
            // 
            this.richTextBoxStandart.Location = new System.Drawing.Point(32, 159);
            this.richTextBoxStandart.Name = "richTextBoxStandart";
            this.richTextBoxStandart.Size = new System.Drawing.Size(725, 185);
            this.richTextBoxStandart.TabIndex = 4;
            this.richTextBoxStandart.Text = "";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(6, 54);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(188, 28);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormStandart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxStandart);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butOpen);
            this.Controls.Add(this.grBoxColourText);
            this.Controls.Add(this.grBoxSizeText);
            this.Controls.Add(this.grBoxStyleText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStandart";
            this.Text = "Форма Standart";
            this.Load += new System.EventHandler(this.FormStandart_Load);
            this.grBoxStyleText.ResumeLayout(false);
            this.grBoxSizeText.ResumeLayout(false);
            this.grBoxColourText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grBoxStyleText;
        private System.Windows.Forms.GroupBox grBoxSizeText;
        private System.Windows.Forms.GroupBox grBoxColourText;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.RichTextBox richTextBoxStandart;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}