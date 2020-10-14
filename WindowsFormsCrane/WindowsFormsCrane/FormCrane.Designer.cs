namespace WindowsFormsCrane
{
    partial class FormCrane
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
            this.pictureBoxCrane = new System.Windows.Forms.PictureBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonCreateHoistingCrane = new System.Windows.Forms.Button();
            this.buttonCreateTrackedVehicle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrane)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCrane
            // 
            this.pictureBoxCrane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCrane.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCrane.Name = "pictureBoxCrane";
            this.pictureBoxCrane.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxCrane.TabIndex = 0;
            this.pictureBoxCrane.TabStop = false;
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.right;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(845, 419);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.left;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(773, 419);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(809, 382);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormsCrane.Properties.Resources.down;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(809, 419);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateHoistingCrane
            // 
            this.buttonCreateHoistingCrane.Location = new System.Drawing.Point(12, 52);
            this.buttonCreateHoistingCrane.Name = "buttonCreateHoistingCrane";
            this.buttonCreateHoistingCrane.Size = new System.Drawing.Size(167, 23);
            this.buttonCreateHoistingCrane.TabIndex = 6;
            this.buttonCreateHoistingCrane.Text = "Создать подъемный кран";
            this.buttonCreateHoistingCrane.UseVisualStyleBackColor = true;
            this.buttonCreateHoistingCrane.Click += new System.EventHandler(this.buttonCreateHoistingCrane_Click);
            // 
            // buttonCreateTrackedVehicle
            // 
            this.buttonCreateTrackedVehicle.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateTrackedVehicle.Name = "buttonCreateTrackedVehicle";
            this.buttonCreateTrackedVehicle.Size = new System.Drawing.Size(167, 23);
            this.buttonCreateTrackedVehicle.TabIndex = 7;
            this.buttonCreateTrackedVehicle.Text = "Создать гусеничную машину";
            this.buttonCreateTrackedVehicle.UseVisualStyleBackColor = true;
            this.buttonCreateTrackedVehicle.Click += new System.EventHandler(this.buttonCreateTrackedVehicle_Click);
            // 
            // FormCrane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonCreateTrackedVehicle);
            this.Controls.Add(this.buttonCreateHoistingCrane);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.pictureBoxCrane);
            this.Name = "FormCrane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подъемный кран";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCrane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCrane;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCreateHoistingCrane;
        private System.Windows.Forms.Button buttonCreateTrackedVehicle;
    }
}

