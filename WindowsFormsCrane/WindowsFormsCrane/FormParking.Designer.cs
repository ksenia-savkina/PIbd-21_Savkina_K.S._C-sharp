﻿namespace WindowsFormsCrane
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetTrackedVehicle = new System.Windows.Forms.Button();
            this.buttonSetHoistingCrane = new System.Windows.Forms.Button();
            this.groupBoxTakeCrane = new System.Windows.Forms.GroupBox();
            this.buttonTakeCrane = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.labelNewLevelName = new System.Windows.Forms.Label();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonDelParking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeCrane.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(835, 731);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetTrackedVehicle
            // 
            this.buttonSetTrackedVehicle.Location = new System.Drawing.Point(856, 216);
            this.buttonSetTrackedVehicle.Name = "buttonSetTrackedVehicle";
            this.buttonSetTrackedVehicle.Size = new System.Drawing.Size(103, 50);
            this.buttonSetTrackedVehicle.TabIndex = 1;
            this.buttonSetTrackedVehicle.Text = "Припарковать гусеничную машину";
            this.buttonSetTrackedVehicle.UseVisualStyleBackColor = true;
            this.buttonSetTrackedVehicle.Click += new System.EventHandler(this.buttonSetTrackedVehicle_Click);
            // 
            // buttonSetHoistingCrane
            // 
            this.buttonSetHoistingCrane.Location = new System.Drawing.Point(856, 285);
            this.buttonSetHoistingCrane.Name = "buttonSetHoistingCrane";
            this.buttonSetHoistingCrane.Size = new System.Drawing.Size(103, 50);
            this.buttonSetHoistingCrane.TabIndex = 2;
            this.buttonSetHoistingCrane.Text = "Припарковать подъемный кран";
            this.buttonSetHoistingCrane.UseVisualStyleBackColor = true;
            this.buttonSetHoistingCrane.Click += new System.EventHandler(this.buttonSetHoistingCrane_Click);
            // 
            // groupBoxTakeCrane
            // 
            this.groupBoxTakeCrane.Controls.Add(this.buttonTakeCrane);
            this.groupBoxTakeCrane.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTakeCrane.Controls.Add(this.labelPlace);
            this.groupBoxTakeCrane.Location = new System.Drawing.Point(856, 363);
            this.groupBoxTakeCrane.Name = "groupBoxTakeCrane";
            this.groupBoxTakeCrane.Size = new System.Drawing.Size(103, 100);
            this.groupBoxTakeCrane.TabIndex = 3;
            this.groupBoxTakeCrane.TabStop = false;
            this.groupBoxTakeCrane.Text = "Забрать кран";
            // 
            // buttonTakeCrane
            // 
            this.buttonTakeCrane.Location = new System.Drawing.Point(11, 71);
            this.buttonTakeCrane.Name = "buttonTakeCrane";
            this.buttonTakeCrane.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeCrane.TabIndex = 6;
            this.buttonTakeCrane.Text = "Забрать";
            this.buttonTakeCrane.UseVisualStyleBackColor = true;
            this.buttonTakeCrane.Click += new System.EventHandler(this.buttonTakeCrane_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(49, 37);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(37, 20);
            this.maskedTextBoxPlace.TabIndex = 5;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 40);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "Место:";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(856, 83);
            this.listBoxParkings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(104, 82);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(856, 33);
            this.textBoxNewLevelName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(104, 20);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // labelNewLevelName
            // 
            this.labelNewLevelName.AutoSize = true;
            this.labelNewLevelName.Location = new System.Drawing.Point(884, 7);
            this.labelNewLevelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewLevelName.Name = "labelNewLevelName";
            this.labelNewLevelName.Size = new System.Drawing.Size(52, 13);
            this.labelNewLevelName.TabIndex = 6;
            this.labelNewLevelName.Text = "Стоянки:";
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(843, 56);
            this.buttonAddParking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(123, 24);
            this.buttonAddParking.TabIndex = 7;
            this.buttonAddParking.Text = "Добавить стоянку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(843, 169);
            this.buttonDelParking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(123, 24);
            this.buttonDelParking.TabIndex = 8;
            this.buttonDelParking.Text = "Удалить стоянку";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 731);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.labelNewLevelName);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBoxTakeCrane);
            this.Controls.Add(this.buttonSetHoistingCrane);
            this.Controls.Add(this.buttonSetTrackedVehicle);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTakeCrane.ResumeLayout(false);
            this.groupBoxTakeCrane.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetTrackedVehicle;
        private System.Windows.Forms.Button buttonSetHoistingCrane;
        private System.Windows.Forms.GroupBox groupBoxTakeCrane;
        private System.Windows.Forms.Button buttonTakeCrane;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label labelNewLevelName;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.Button buttonDelParking;
    }
}