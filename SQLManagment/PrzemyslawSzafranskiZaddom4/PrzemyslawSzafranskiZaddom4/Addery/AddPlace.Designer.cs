namespace PrzemyslawSzafranskiZaddom4
{
    partial class AddPlace
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
            this.labelPlaceName = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCityName = new System.Windows.Forms.TextBox();
            this.textBoxStreetName = new System.Windows.Forms.TextBox();
            this.textBoxPlaceName = new System.Windows.Forms.TextBox();
            this.addPlaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlaceName
            // 
            this.labelPlaceName.AutoSize = true;
            this.labelPlaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelPlaceName.Location = new System.Drawing.Point(12, 9);
            this.labelPlaceName.Name = "labelPlaceName";
            this.labelPlaceName.Size = new System.Drawing.Size(77, 17);
            this.labelPlaceName.TabIndex = 0;
            this.labelPlaceName.Text = "Nazwa Sali";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelStreet.Location = new System.Drawing.Point(12, 38);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(39, 17);
            this.labelStreet.TabIndex = 1;
            this.labelStreet.Text = "Ulica";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelCity.Location = new System.Drawing.Point(12, 67);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(86, 17);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "Miejscowość";
            // 
            // textBoxCityName
            // 
            this.textBoxCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxCityName.Location = new System.Drawing.Point(104, 64);
            this.textBoxCityName.Name = "textBoxCityName";
            this.textBoxCityName.Size = new System.Drawing.Size(177, 23);
            this.textBoxCityName.TabIndex = 3;
            // 
            // textBoxStreetName
            // 
            this.textBoxStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxStreetName.Location = new System.Drawing.Point(104, 35);
            this.textBoxStreetName.Name = "textBoxStreetName";
            this.textBoxStreetName.Size = new System.Drawing.Size(177, 23);
            this.textBoxStreetName.TabIndex = 4;
            // 
            // textBoxPlaceName
            // 
            this.textBoxPlaceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxPlaceName.Location = new System.Drawing.Point(104, 6);
            this.textBoxPlaceName.Name = "textBoxPlaceName";
            this.textBoxPlaceName.Size = new System.Drawing.Size(190, 23);
            this.textBoxPlaceName.TabIndex = 5;
            // 
            // addPlaceButton
            // 
            this.addPlaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.addPlaceButton.Location = new System.Drawing.Point(104, 93);
            this.addPlaceButton.Name = "addPlaceButton";
            this.addPlaceButton.Size = new System.Drawing.Size(75, 30);
            this.addPlaceButton.TabIndex = 6;
            this.addPlaceButton.Text = "OK";
            this.addPlaceButton.UseVisualStyleBackColor = true;
            this.addPlaceButton.Click += new System.EventHandler(this.addPlaceButton_Click);
            // 
            // AddPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 127);
            this.Controls.Add(this.addPlaceButton);
            this.Controls.Add(this.textBoxPlaceName);
            this.Controls.Add(this.textBoxStreetName);
            this.Controls.Add(this.textBoxCityName);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelPlaceName);
            this.MaximizeBox = false;
            this.Name = "AddPlace";
            this.Text = "Dodawanie sali do bazy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlaceName;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCityName;
        private System.Windows.Forms.TextBox textBoxStreetName;
        private System.Windows.Forms.TextBox textBoxPlaceName;
        private System.Windows.Forms.Button addPlaceButton;
    }
}