namespace ClockPresentator
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
            this.clockControl1 = new Clock.ClockControl();
            this.buttonMeh = new System.Windows.Forms.Button();
            this.buttonElectro = new System.Windows.Forms.Button();
            this.buttonNotify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockControl1
            // 
            this.clockControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clockControl1.Location = new System.Drawing.Point(12, 12);
            this.clockControl1.Name = "clockControl1";
            this.clockControl1.Size = new System.Drawing.Size(301, 273);
            this.clockControl1.TabIndex = 1;
            this.clockControl1.TypeofClock = Clock.ClockControl.ClockType.ClockFace;
            this.clockControl1.UTC = System.TimeSpan.Parse("03:00:00");
            this.clockControl1.TimeChanged += new System.EventHandler(this.clockControl1_TimeChanged);
            // 
            // buttonMeh
            // 
            this.buttonMeh.Enabled = false;
            this.buttonMeh.Location = new System.Drawing.Point(340, 26);
            this.buttonMeh.Name = "buttonMeh";
            this.buttonMeh.Size = new System.Drawing.Size(113, 33);
            this.buttonMeh.TabIndex = 2;
            this.buttonMeh.Text = "Механические";
            this.buttonMeh.UseVisualStyleBackColor = true;
            this.buttonMeh.Click += new System.EventHandler(this.buttonMeh_Click);
            // 
            // buttonElectro
            // 
            this.buttonElectro.Location = new System.Drawing.Point(340, 80);
            this.buttonElectro.Name = "buttonElectro";
            this.buttonElectro.Size = new System.Drawing.Size(113, 34);
            this.buttonElectro.TabIndex = 3;
            this.buttonElectro.Text = "Электронные";
            this.buttonElectro.UseVisualStyleBackColor = true;
            this.buttonElectro.Click += new System.EventHandler(this.buttonElectro_Click);
            // 
            // buttonNotify
            // 
            this.buttonNotify.Location = new System.Drawing.Point(340, 133);
            this.buttonNotify.Name = "buttonNotify";
            this.buttonNotify.Size = new System.Drawing.Size(113, 37);
            this.buttonNotify.TabIndex = 4;
            this.buttonNotify.Text = "Отключить оповещения";
            this.buttonNotify.UseVisualStyleBackColor = true;
            this.buttonNotify.Click += new System.EventHandler(this.buttonNotify_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 294);
            this.Controls.Add(this.buttonNotify);
            this.Controls.Add(this.buttonElectro);
            this.Controls.Add(this.buttonMeh);
            this.Controls.Add(this.clockControl1);
            this.Name = "FormMain";
            this.Text = "Часы";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Clock.ClockControl clockControl1;
        private System.Windows.Forms.Button buttonMeh;
        private System.Windows.Forms.Button buttonElectro;
        private System.Windows.Forms.Button buttonNotify;
    }
}

