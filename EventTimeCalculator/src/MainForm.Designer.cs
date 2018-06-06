namespace BladeAndSoul.EventTimeCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPredict = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxNextEventTimes = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.numericUpDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonPredict);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 121);
            this.panel1.TabIndex = 0;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numericUpDown.Location = new System.Drawing.Point(218, 78);
            this.numericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(69, 25);
            this.numericUpDown.TabIndex = 0;
            this.numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(215, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "顯示數量";
            // 
            // buttonPredict
            // 
            this.buttonPredict.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPredict.Location = new System.Drawing.Point(7, 55);
            this.buttonPredict.Name = "buttonPredict";
            this.buttonPredict.Size = new System.Drawing.Size(171, 48);
            this.buttonPredict.TabIndex = 2;
            this.buttonPredict.Text = "預測下次事件時間";
            this.buttonPredict.UseVisualStyleBackColor = true;
            this.buttonPredict.Click += new System.EventHandler(this.ShowNextEventTimes);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(162, 7);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(125, 25);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "上一次事件結束時間";
            // 
            // listBoxNextEventTimes
            // 
            this.listBoxNextEventTimes.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxNextEventTimes.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBoxNextEventTimes.FormattingEnabled = true;
            this.listBoxNextEventTimes.ItemHeight = 20;
            this.listBoxNextEventTimes.Location = new System.Drawing.Point(12, 148);
            this.listBoxNextEventTimes.Name = "listBoxNextEventTimes";
            this.listBoxNextEventTimes.Size = new System.Drawing.Size(309, 264);
            this.listBoxNextEventTimes.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 428);
            this.Controls.Add(this.listBoxNextEventTimes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "天之盆地事件時間計算機";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonPredict;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.ListBox listBoxNextEventTimes;
    }
}

