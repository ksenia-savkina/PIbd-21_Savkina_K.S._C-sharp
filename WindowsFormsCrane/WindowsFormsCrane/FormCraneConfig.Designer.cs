namespace WindowsFormsCrane
{
    partial class FormCraneConfig
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
			this.groupBoxAssembly = new System.Windows.Forms.GroupBox();
			this.labelHoistingCrane = new System.Windows.Forms.Label();
			this.labelTrackedVehicle = new System.Windows.Forms.Label();
			this.groupBoxOptions = new System.Windows.Forms.GroupBox();
			this.checkBoxCounterweight = new System.Windows.Forms.CheckBox();
			this.checkBoxArrow = new System.Windows.Forms.CheckBox();
			this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
			this.labelWeight = new System.Windows.Forms.Label();
			this.labelMaxSpeed = new System.Windows.Forms.Label();
			this.pictureBoxCrane = new System.Windows.Forms.PictureBox();
			this.panelCrane = new System.Windows.Forms.Panel();
			this.groupBoxColors = new System.Windows.Forms.GroupBox();
			this.panelBlue = new System.Windows.Forms.Panel();
			this.panelPurple = new System.Windows.Forms.Panel();
			this.panelGray = new System.Windows.Forms.Panel();
			this.panelAqua = new System.Windows.Forms.Panel();
			this.panelGreen = new System.Windows.Forms.Panel();
			this.panelYellow = new System.Windows.Forms.Panel();
			this.panelOrange = new System.Windows.Forms.Panel();
			this.panelPink = new System.Windows.Forms.Panel();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelMainColor = new System.Windows.Forms.Label();
			this.labelDopColor = new System.Windows.Forms.Label();
			this.groupBoxAssembly.SuspendLayout();
			this.groupBoxOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrane)).BeginInit();
			this.panelCrane.SuspendLayout();
			this.groupBoxColors.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxAssembly
			// 
			this.groupBoxAssembly.Controls.Add(this.labelHoistingCrane);
			this.groupBoxAssembly.Controls.Add(this.labelTrackedVehicle);
			this.groupBoxAssembly.Location = new System.Drawing.Point(26, 20);
			this.groupBoxAssembly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxAssembly.Name = "groupBoxAssembly";
			this.groupBoxAssembly.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxAssembly.Size = new System.Drawing.Size(148, 100);
			this.groupBoxAssembly.TabIndex = 0;
			this.groupBoxAssembly.TabStop = false;
			this.groupBoxAssembly.Text = "Тип сборки";
			// 
			// labelHoistingCrane
			// 
			this.labelHoistingCrane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelHoistingCrane.Location = new System.Drawing.Point(4, 64);
			this.labelHoistingCrane.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelHoistingCrane.Name = "labelHoistingCrane";
			this.labelHoistingCrane.Size = new System.Drawing.Size(118, 26);
			this.labelHoistingCrane.TabIndex = 2;
			this.labelHoistingCrane.Text = "Подъемный кран";
			this.labelHoistingCrane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelHoistingCrane_MouseDown);
			// 
			// labelTrackedVehicle
			// 
			this.labelTrackedVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelTrackedVehicle.Location = new System.Drawing.Point(4, 24);
			this.labelTrackedVehicle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTrackedVehicle.Name = "labelTrackedVehicle";
			this.labelTrackedVehicle.Size = new System.Drawing.Size(118, 27);
			this.labelTrackedVehicle.TabIndex = 1;
			this.labelTrackedVehicle.Text = "Гусеничная машина";
			this.labelTrackedVehicle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrackedVehicle_MouseDown);
			// 
			// groupBoxOptions
			// 
			this.groupBoxOptions.Controls.Add(this.checkBoxCounterweight);
			this.groupBoxOptions.Controls.Add(this.checkBoxArrow);
			this.groupBoxOptions.Controls.Add(this.numericUpDownWeight);
			this.groupBoxOptions.Controls.Add(this.numericUpDownMaxSpeed);
			this.groupBoxOptions.Controls.Add(this.labelWeight);
			this.groupBoxOptions.Controls.Add(this.labelMaxSpeed);
			this.groupBoxOptions.Location = new System.Drawing.Point(26, 134);
			this.groupBoxOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxOptions.Name = "groupBoxOptions";
			this.groupBoxOptions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxOptions.Size = new System.Drawing.Size(242, 109);
			this.groupBoxOptions.TabIndex = 1;
			this.groupBoxOptions.TabStop = false;
			this.groupBoxOptions.Text = "Параметры";
			// 
			// checkBoxCounterweight
			// 
			this.checkBoxCounterweight.AutoSize = true;
			this.checkBoxCounterweight.Location = new System.Drawing.Point(157, 48);
			this.checkBoxCounterweight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.checkBoxCounterweight.Name = "checkBoxCounterweight";
			this.checkBoxCounterweight.Size = new System.Drawing.Size(87, 17);
			this.checkBoxCounterweight.TabIndex = 5;
			this.checkBoxCounterweight.Text = "Противовес";
			this.checkBoxCounterweight.UseVisualStyleBackColor = true;
			// 
			// checkBoxArrow
			// 
			this.checkBoxArrow.AutoSize = true;
			this.checkBoxArrow.Location = new System.Drawing.Point(157, 18);
			this.checkBoxArrow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.checkBoxArrow.Name = "checkBoxArrow";
			this.checkBoxArrow.Size = new System.Drawing.Size(62, 17);
			this.checkBoxArrow.TabIndex = 4;
			this.checkBoxArrow.Text = "Стрела";
			this.checkBoxArrow.UseVisualStyleBackColor = true;
			// 
			// numericUpDownWeight
			// 
			this.numericUpDownWeight.Location = new System.Drawing.Point(9, 78);
			this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownWeight.Name = "numericUpDownWeight";
			this.numericUpDownWeight.Size = new System.Drawing.Size(36, 20);
			this.numericUpDownWeight.TabIndex = 3;
			this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDownMaxSpeed
			// 
			this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(9, 34);
			this.numericUpDownMaxSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
			this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(36, 20);
			this.numericUpDownMaxSpeed.TabIndex = 2;
			this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// labelWeight
			// 
			this.labelWeight.AutoSize = true;
			this.labelWeight.Location = new System.Drawing.Point(4, 62);
			this.labelWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelWeight.Name = "labelWeight";
			this.labelWeight.Size = new System.Drawing.Size(59, 13);
			this.labelWeight.TabIndex = 1;
			this.labelWeight.Text = "Вес крана";
			// 
			// labelMaxSpeed
			// 
			this.labelMaxSpeed.AutoSize = true;
			this.labelMaxSpeed.Location = new System.Drawing.Point(7, 18);
			this.labelMaxSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMaxSpeed.Name = "labelMaxSpeed";
			this.labelMaxSpeed.Size = new System.Drawing.Size(134, 13);
			this.labelMaxSpeed.TabIndex = 0;
			this.labelMaxSpeed.Text = "Максимальная скорость";
			// 
			// pictureBoxCrane
			// 
			this.pictureBoxCrane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxCrane.Location = new System.Drawing.Point(20, 19);
			this.pictureBoxCrane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBoxCrane.Name = "pictureBoxCrane";
			this.pictureBoxCrane.Size = new System.Drawing.Size(269, 446);
			this.pictureBoxCrane.TabIndex = 2;
			this.pictureBoxCrane.TabStop = false;
			// 
			// panelCrane
			// 
			this.panelCrane.AllowDrop = true;
			this.panelCrane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCrane.Controls.Add(this.pictureBoxCrane);
			this.panelCrane.Location = new System.Drawing.Point(283, 10);
			this.panelCrane.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelCrane.Name = "panelCrane";
			this.panelCrane.Size = new System.Drawing.Size(308, 484);
			this.panelCrane.TabIndex = 3;
			this.panelCrane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCrane_DragDrop);
			this.panelCrane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCrane_DragEnter);
			// 
			// groupBoxColors
			// 
			this.groupBoxColors.Controls.Add(this.labelMainColor);
			this.groupBoxColors.Controls.Add(this.labelDopColor);
			this.groupBoxColors.Controls.Add(this.panelBlue);
			this.groupBoxColors.Controls.Add(this.panelPurple);
			this.groupBoxColors.Controls.Add(this.panelGray);
			this.groupBoxColors.Controls.Add(this.panelAqua);
			this.groupBoxColors.Controls.Add(this.panelGreen);
			this.groupBoxColors.Controls.Add(this.panelYellow);
			this.groupBoxColors.Controls.Add(this.panelOrange);
			this.groupBoxColors.Controls.Add(this.panelPink);
			this.groupBoxColors.Location = new System.Drawing.Point(609, 20);
			this.groupBoxColors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxColors.Name = "groupBoxColors";
			this.groupBoxColors.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBoxColors.Size = new System.Drawing.Size(179, 189);
			this.groupBoxColors.TabIndex = 4;
			this.groupBoxColors.TabStop = false;
			this.groupBoxColors.Text = "Цвета";
			// 
			// panelBlue
			// 
			this.panelBlue.BackColor = System.Drawing.Color.Blue;
			this.panelBlue.Location = new System.Drawing.Point(141, 154);
			this.panelBlue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelBlue.Name = "panelBlue";
			this.panelBlue.Size = new System.Drawing.Size(24, 25);
			this.panelBlue.TabIndex = 11;
			// 
			// panelPurple
			// 
			this.panelPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.panelPurple.Location = new System.Drawing.Point(98, 153);
			this.panelPurple.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelPurple.Name = "panelPurple";
			this.panelPurple.Size = new System.Drawing.Size(24, 25);
			this.panelPurple.TabIndex = 10;
			// 
			// panelGray
			// 
			this.panelGray.BackColor = System.Drawing.Color.Gray;
			this.panelGray.Location = new System.Drawing.Point(55, 154);
			this.panelGray.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelGray.Name = "panelGray";
			this.panelGray.Size = new System.Drawing.Size(24, 25);
			this.panelGray.TabIndex = 9;
			// 
			// panelAqua
			// 
			this.panelAqua.BackColor = System.Drawing.Color.Aqua;
			this.panelAqua.Location = new System.Drawing.Point(11, 154);
			this.panelAqua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelAqua.Name = "panelAqua";
			this.panelAqua.Size = new System.Drawing.Size(24, 25);
			this.panelAqua.TabIndex = 8;
			// 
			// panelGreen
			// 
			this.panelGreen.BackColor = System.Drawing.Color.Lime;
			this.panelGreen.Location = new System.Drawing.Point(141, 115);
			this.panelGreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelGreen.Name = "panelGreen";
			this.panelGreen.Size = new System.Drawing.Size(24, 25);
			this.panelGreen.TabIndex = 7;
			// 
			// panelYellow
			// 
			this.panelYellow.BackColor = System.Drawing.Color.Yellow;
			this.panelYellow.Location = new System.Drawing.Point(98, 114);
			this.panelYellow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelYellow.Name = "panelYellow";
			this.panelYellow.Size = new System.Drawing.Size(24, 25);
			this.panelYellow.TabIndex = 6;
			// 
			// panelOrange
			// 
			this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panelOrange.Location = new System.Drawing.Point(55, 115);
			this.panelOrange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelOrange.Name = "panelOrange";
			this.panelOrange.Size = new System.Drawing.Size(24, 25);
			this.panelOrange.TabIndex = 5;
			// 
			// panelPink
			// 
			this.panelPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.panelPink.Location = new System.Drawing.Point(11, 115);
			this.panelPink.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panelPink.Name = "panelPink";
			this.panelPink.Size = new System.Drawing.Size(24, 25);
			this.panelPink.TabIndex = 4;
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(609, 229);
			this.buttonOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(94, 28);
			this.buttonOk.TabIndex = 5;
			this.buttonOk.Text = "Добавить";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(708, 229);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(69, 28);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// labelMainColor
			// 
			this.labelMainColor.AllowDrop = true;
			this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelMainColor.Location = new System.Drawing.Point(11, 36);
			this.labelMainColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMainColor.Name = "labelMainColor";
			this.labelMainColor.Size = new System.Drawing.Size(73, 45);
			this.labelMainColor.TabIndex = 2;
			this.labelMainColor.Text = "Основной цвет";
			this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
			this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
			// 
			// labelDopColor
			// 
			this.labelDopColor.AllowDrop = true;
			this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelDopColor.Location = new System.Drawing.Point(99, 36);
			this.labelDopColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDopColor.Name = "labelDopColor";
			this.labelDopColor.Size = new System.Drawing.Size(61, 45);
			this.labelDopColor.TabIndex = 3;
			this.labelDopColor.Text = "Доп. цвет";
			this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
			// 
			// FormCraneConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 514);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.panelCrane);
			this.Controls.Add(this.groupBoxOptions);
			this.Controls.Add(this.groupBoxAssembly);
			this.Controls.Add(this.groupBoxColors);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FormCraneConfig";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Выбор крана";
			this.groupBoxAssembly.ResumeLayout(false);
			this.groupBoxOptions.ResumeLayout(false);
			this.groupBoxOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrane)).EndInit();
			this.panelCrane.ResumeLayout(false);
			this.groupBoxColors.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAssembly;
        private System.Windows.Forms.Label labelHoistingCrane;
        private System.Windows.Forms.Label labelTrackedVehicle;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxArrow;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxCounterweight;
        private System.Windows.Forms.PictureBox pictureBoxCrane;
        private System.Windows.Forms.Panel panelCrane;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.Label labelMainColor;
	}
}