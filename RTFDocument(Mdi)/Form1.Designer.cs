namespace RTFDocument_Mdi_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButMDI = new System.Windows.Forms.RadioButton();
            this.radioButStandart = new System.Windows.Forms.RadioButton();
            this.groupBoxForm1 = new System.Windows.Forms.GroupBox();
            this.butCreate = new System.Windows.Forms.Button();
            this.groupBoxForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButMDI
            // 
            this.radioButMDI.AutoSize = true;
            this.radioButMDI.Location = new System.Drawing.Point(22, 41);
            this.radioButMDI.Name = "radioButMDI";
            this.radioButMDI.Size = new System.Drawing.Size(61, 24);
            this.radioButMDI.TabIndex = 1;
            this.radioButMDI.TabStop = true;
            this.radioButMDI.Text = "MDI";
            this.radioButMDI.UseVisualStyleBackColor = true;
            this.radioButMDI.CheckedChanged += new System.EventHandler(this.radioButMDI_CheckedChanged);
            // 
            // radioButStandart
            // 
            this.radioButStandart.AutoSize = true;
            this.radioButStandart.Location = new System.Drawing.Point(22, 86);
            this.radioButStandart.Name = "radioButStandart";
            this.radioButStandart.Size = new System.Drawing.Size(144, 24);
            this.radioButStandart.TabIndex = 2;
            this.radioButStandart.TabStop = true;
            this.radioButStandart.Text = "Стандартная";
            this.radioButStandart.UseVisualStyleBackColor = true;
            // 
            // groupBoxForm1
            // 
            this.groupBoxForm1.Controls.Add(this.radioButStandart);
            this.groupBoxForm1.Controls.Add(this.radioButMDI);
            this.groupBoxForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxForm1.Location = new System.Drawing.Point(30, 58);
            this.groupBoxForm1.Name = "groupBoxForm1";
            this.groupBoxForm1.Size = new System.Drawing.Size(200, 156);
            this.groupBoxForm1.TabIndex = 3;
            this.groupBoxForm1.TabStop = false;
            this.groupBoxForm1.Text = "Выберите вид  окна";
            // 
            // butCreate
            // 
            this.butCreate.Location = new System.Drawing.Point(30, 266);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(200, 23);
            this.butCreate.TabIndex = 4;
            this.butCreate.Text = "создать";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.groupBoxForm1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Редактор RTF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxForm1.ResumeLayout(false);
            this.groupBoxForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButMDI;
        private System.Windows.Forms.RadioButton radioButStandart;
        private System.Windows.Forms.GroupBox groupBoxForm1;
        private System.Windows.Forms.Button butCreate;
    }
}

