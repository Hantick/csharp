namespace PrzemyslawSzafranskiZaddom4
{
    partial class AddEvent
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
            this.components = new System.ComponentModel.Container();
            this.labelEventType = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.labelFuelCost = new System.Windows.Forms.Label();
            this.addEventButton = new System.Windows.Forms.Button();
            this.labelAmoutOfPeople = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.eventTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przemyslawSzafranskiSQLZD4DataSet = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSet();
            this.eventTypesTableAdapter = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventTypesTableAdapter();
            this.labelEventCost = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.textBoxFuelCost = new System.Windows.Forms.TextBox();
            this.textBoxAmoutOfPeople = new System.Windows.Forms.TextBox();
            this.textBoxEventCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEventType
            // 
            this.labelEventType.AutoSize = true;
            this.labelEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelEventType.Location = new System.Drawing.Point(12, 16);
            this.labelEventType.Name = "labelEventType";
            this.labelEventType.Size = new System.Drawing.Size(85, 17);
            this.labelEventType.TabIndex = 0;
            this.labelEventType.Text = "Typ imprezy";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelDistance.Location = new System.Drawing.Point(13, 39);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(101, 17);
            this.labelDistance.TabIndex = 1;
            this.labelDistance.Text = "Odległość [km]";
            // 
            // labelFuelCost
            // 
            this.labelFuelCost.AutoSize = true;
            this.labelFuelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelFuelCost.Location = new System.Drawing.Point(14, 62);
            this.labelFuelCost.Name = "labelFuelCost";
            this.labelFuelCost.Size = new System.Drawing.Size(93, 17);
            this.labelFuelCost.TabIndex = 2;
            this.labelFuelCost.Text = "Koszty paliwa";
            // 
            // addEventButton
            // 
            this.addEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.addEventButton.Location = new System.Drawing.Point(104, 151);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(75, 30);
            this.addEventButton.TabIndex = 6;
            this.addEventButton.Text = "OK";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // labelAmoutOfPeople
            // 
            this.labelAmoutOfPeople.AutoSize = true;
            this.labelAmoutOfPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelAmoutOfPeople.Location = new System.Drawing.Point(14, 91);
            this.labelAmoutOfPeople.Name = "labelAmoutOfPeople";
            this.labelAmoutOfPeople.Size = new System.Drawing.Size(84, 17);
            this.labelAmoutOfPeople.TabIndex = 8;
            this.labelAmoutOfPeople.Text = "Liczba osób";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.eventTypesBindingSource;
            this.listBox1.DisplayMember = "EventType";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(119, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 17);
            this.listBox1.TabIndex = 9;
            this.listBox1.ValueMember = "EventType";
            // 
            // eventTypesBindingSource
            // 
            this.eventTypesBindingSource.DataMember = "EventTypes";
            this.eventTypesBindingSource.DataSource = this.przemyslawSzafranskiSQLZD4DataSet;
            // 
            // przemyslawSzafranskiSQLZD4DataSet
            // 
            this.przemyslawSzafranskiSQLZD4DataSet.DataSetName = "PrzemyslawSzafranskiSQLZD4DataSet";
            this.przemyslawSzafranskiSQLZD4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventTypesTableAdapter
            // 
            this.eventTypesTableAdapter.ClearBeforeFill = true;
            // 
            // labelEventCost
            // 
            this.labelEventCost.AutoSize = true;
            this.labelEventCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelEventCost.Location = new System.Drawing.Point(14, 114);
            this.labelEventCost.Name = "labelEventCost";
            this.labelEventCost.Size = new System.Drawing.Size(99, 17);
            this.labelEventCost.TabIndex = 10;
            this.labelEventCost.Text = "Kwota imprezy";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(119, 36);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(45, 20);
            this.textBoxDistance.TabIndex = 11;
            // 
            // textBoxFuelCost
            // 
            this.textBoxFuelCost.Location = new System.Drawing.Point(119, 62);
            this.textBoxFuelCost.Name = "textBoxFuelCost";
            this.textBoxFuelCost.Size = new System.Drawing.Size(45, 20);
            this.textBoxFuelCost.TabIndex = 12;
            // 
            // textBoxAmoutOfPeople
            // 
            this.textBoxAmoutOfPeople.Location = new System.Drawing.Point(119, 88);
            this.textBoxAmoutOfPeople.Name = "textBoxAmoutOfPeople";
            this.textBoxAmoutOfPeople.Size = new System.Drawing.Size(45, 20);
            this.textBoxAmoutOfPeople.TabIndex = 13;
            // 
            // textBoxEventCost
            // 
            this.textBoxEventCost.Location = new System.Drawing.Point(119, 114);
            this.textBoxEventCost.Name = "textBoxEventCost";
            this.textBoxEventCost.Size = new System.Drawing.Size(60, 20);
            this.textBoxEventCost.TabIndex = 14;
            // 
            // AddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 185);
            this.Controls.Add(this.textBoxEventCost);
            this.Controls.Add(this.textBoxAmoutOfPeople);
            this.Controls.Add(this.textBoxFuelCost);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.labelEventCost);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelAmoutOfPeople);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.labelFuelCost);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.labelEventType);
            this.MaximizeBox = false;
            this.Name = "AddEvent";
            this.Text = "Dodawanie imprezy do bazy";
            this.Load += new System.EventHandler(this.AddEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEventType;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelFuelCost;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Label labelAmoutOfPeople;
        private System.Windows.Forms.ListBox listBox1;
        private PrzemyslawSzafranskiSQLZD4DataSet przemyslawSzafranskiSQLZD4DataSet;
        private System.Windows.Forms.BindingSource eventTypesBindingSource;
        private PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventTypesTableAdapter eventTypesTableAdapter;
        private System.Windows.Forms.Label labelEventCost;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.TextBox textBoxFuelCost;
        private System.Windows.Forms.TextBox textBoxAmoutOfPeople;
        private System.Windows.Forms.TextBox textBoxEventCost;
    }
}