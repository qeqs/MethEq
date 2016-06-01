namespace MethEq
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1Linear = new System.Windows.Forms.GroupBox();
            this.textBoxAlinear = new System.Windows.Forms.TextBox();
            this.textBoxBlinear = new System.Windows.Forms.TextBox();
            this.buttonGaus = new System.Windows.Forms.Button();
            this.buttonZeiv = new System.Windows.Forms.Button();
            this.panellinear = new System.Windows.Forms.Panel();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.groupBox1Linear.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1Linear
            // 
            this.groupBox1Linear.Controls.Add(this.panellinear);
            this.groupBox1Linear.Controls.Add(this.buttonZeiv);
            this.groupBox1Linear.Controls.Add(this.buttonGaus);
            this.groupBox1Linear.Controls.Add(this.textBoxBlinear);
            this.groupBox1Linear.Controls.Add(this.textBoxAlinear);
            this.groupBox1Linear.Location = new System.Drawing.Point(12, 12);
            this.groupBox1Linear.Name = "groupBox1Linear";
            this.groupBox1Linear.Size = new System.Drawing.Size(408, 277);
            this.groupBox1Linear.TabIndex = 0;
            this.groupBox1Linear.TabStop = false;
            this.groupBox1Linear.Text = "1)Линейные уравнения";
            // 
            // textBoxAlinear
            // 
            this.textBoxAlinear.Location = new System.Drawing.Point(6, 19);
            this.textBoxAlinear.Multiline = true;
            this.textBoxAlinear.Name = "textBoxAlinear";
            this.textBoxAlinear.Size = new System.Drawing.Size(175, 159);
            this.textBoxAlinear.TabIndex = 0;
            // 
            // textBoxBlinear
            // 
            this.textBoxBlinear.Location = new System.Drawing.Point(187, 19);
            this.textBoxBlinear.Name = "textBoxBlinear";
            this.textBoxBlinear.Size = new System.Drawing.Size(178, 20);
            this.textBoxBlinear.TabIndex = 1;
            // 
            // buttonGaus
            // 
            this.buttonGaus.Location = new System.Drawing.Point(6, 198);
            this.buttonGaus.Name = "buttonGaus";
            this.buttonGaus.Size = new System.Drawing.Size(75, 23);
            this.buttonGaus.TabIndex = 2;
            this.buttonGaus.Text = "Гаус";
            this.buttonGaus.UseVisualStyleBackColor = true;
            this.buttonGaus.Click += new System.EventHandler(this.buttonGaus_Click);
            // 
            // buttonZeiv
            // 
            this.buttonZeiv.Location = new System.Drawing.Point(6, 236);
            this.buttonZeiv.Name = "buttonZeiv";
            this.buttonZeiv.Size = new System.Drawing.Size(75, 23);
            this.buttonZeiv.TabIndex = 3;
            this.buttonZeiv.Text = "Зейдель";
            this.buttonZeiv.UseVisualStyleBackColor = true;
            this.buttonZeiv.Click += new System.EventHandler(this.buttonZeiv_Click);
            // 
            // panellinear
            // 
            this.panellinear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panellinear.Location = new System.Drawing.Point(187, 45);
            this.panellinear.Name = "panellinear";
            this.panellinear.Size = new System.Drawing.Size(178, 214);
            this.panellinear.TabIndex = 4;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(711, 0);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(25, 349);
            this.vScrollBar.TabIndex = 1;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 350);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.groupBox1Linear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Решатель контрольных";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1Linear.ResumeLayout(false);
            this.groupBox1Linear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1Linear;
        private System.Windows.Forms.Panel panellinear;
        private System.Windows.Forms.Button buttonZeiv;
        private System.Windows.Forms.Button buttonGaus;
        private System.Windows.Forms.TextBox textBoxBlinear;
        private System.Windows.Forms.TextBox textBoxAlinear;
        private System.Windows.Forms.VScrollBar vScrollBar;
    }
}

