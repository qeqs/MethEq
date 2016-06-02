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
            this.clockControl = new Clock.ClockControl();
            this.SuspendLayout();
            // 
            // clockControl
            // 
            this.clockControl.Location = new System.Drawing.Point(12, 0);
            this.clockControl.Name = "clockControl";
            this.clockControl.Size = new System.Drawing.Size(490, 309);
            this.clockControl.TabIndex = 0;
            this.clockControl.TypeofClock = Clock.ClockControl.ClockType.ClockFace;
            this.clockControl.UTC = System.TimeSpan.Parse("03:00:00");
            this.clockControl.TimeChanged += new System.EventHandler(this.clockControl_TimeChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 294);
            this.Controls.Add(this.clockControl);
            this.Name = "FormMain";
            this.Text = "Часы";
            this.ResumeLayout(false);

        }

        #endregion

        private Clock.ClockControl clockControl;
    }
}

