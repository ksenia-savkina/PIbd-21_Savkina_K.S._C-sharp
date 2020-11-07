namespace WindowsFormsCrane
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
            this.groupBoxTakeCrane = new System.Windows.Forms.GroupBox();
            this.buttonTakeCrane = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.labelNewLevelName = new System.Windows.Forms.Label();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonDelParking = new System.Windows.Forms.Button();
            this.buttonSetCrane = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTakeCrane.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1113, 900);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBoxTakeCrane
            // 
            this.groupBoxTakeCrane.Controls.Add(this.buttonTakeCrane);
            this.groupBoxTakeCrane.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTakeCrane.Controls.Add(this.labelPlace);
            this.groupBoxTakeCrane.Location = new System.Drawing.Point(1141, 447);
            this.groupBoxTakeCrane.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTakeCrane.Name = "groupBoxTakeCrane";
            this.groupBoxTakeCrane.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTakeCrane.Size = new System.Drawing.Size(137, 123);
            this.groupBoxTakeCrane.TabIndex = 3;
            this.groupBoxTakeCrane.TabStop = false;
            this.groupBoxTakeCrane.Text = "Забрать кран";
            // 
            // buttonTakeCrane
            // 
            this.buttonTakeCrane.Location = new System.Drawing.Point(15, 87);
            this.buttonTakeCrane.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTakeCrane.Name = "buttonTakeCrane";
            this.buttonTakeCrane.Size = new System.Drawing.Size(100, 28);
            this.buttonTakeCrane.TabIndex = 6;
            this.buttonTakeCrane.Text = "Забрать";
            this.buttonTakeCrane.UseVisualStyleBackColor = true;
            this.buttonTakeCrane.Click += new System.EventHandler(this.buttonTakeCrane_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(65, 46);
            this.maskedTextBoxPlace.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(48, 22);
            this.maskedTextBoxPlace.TabIndex = 5;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(8, 49);
            this.labelPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(53, 17);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "Место:";
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.ItemHeight = 16;
            this.listBoxParkings.Location = new System.Drawing.Point(1141, 102);
            this.listBoxParkings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(137, 100);
            this.listBoxParkings.TabIndex = 4;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(1141, 41);
            this.textBoxNewLevelName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(137, 22);
            this.textBoxNewLevelName.TabIndex = 5;
            // 
            // labelNewLevelName
            // 
            this.labelNewLevelName.AutoSize = true;
            this.labelNewLevelName.Location = new System.Drawing.Point(1179, 9);
            this.labelNewLevelName.Name = "labelNewLevelName";
            this.labelNewLevelName.Size = new System.Drawing.Size(67, 17);
            this.labelNewLevelName.TabIndex = 6;
            this.labelNewLevelName.Text = "Стоянки:";
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(1124, 69);
            this.buttonAddParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(164, 30);
            this.buttonAddParking.TabIndex = 7;
            this.buttonAddParking.Text = "Добавить стоянку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonDelParking
            // 
            this.buttonDelParking.Location = new System.Drawing.Point(1124, 208);
            this.buttonDelParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelParking.Name = "buttonDelParking";
            this.buttonDelParking.Size = new System.Drawing.Size(164, 30);
            this.buttonDelParking.TabIndex = 8;
            this.buttonDelParking.Text = "Удалить стоянку";
            this.buttonDelParking.UseVisualStyleBackColor = true;
            this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
            // 
            // buttonSetCrane
            // 
            this.buttonSetCrane.Location = new System.Drawing.Point(1129, 286);
            this.buttonSetCrane.Name = "buttonSetCrane";
            this.buttonSetCrane.Size = new System.Drawing.Size(149, 61);
            this.buttonSetCrane.TabIndex = 9;
            this.buttonSetCrane.Text = "Добавить кран";
            this.buttonSetCrane.UseVisualStyleBackColor = true;
            this.buttonSetCrane.Click += new System.EventHandler(this.buttonSetCrane_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 900);
            this.Controls.Add(this.buttonSetCrane);
            this.Controls.Add(this.buttonDelParking);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.labelNewLevelName);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.groupBoxTakeCrane);
            this.Controls.Add(this.pictureBoxParking);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.GroupBox groupBoxTakeCrane;
        private System.Windows.Forms.Button buttonTakeCrane;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label labelNewLevelName;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.Button buttonDelParking;
        private System.Windows.Forms.Button buttonSetCrane;
    }
}