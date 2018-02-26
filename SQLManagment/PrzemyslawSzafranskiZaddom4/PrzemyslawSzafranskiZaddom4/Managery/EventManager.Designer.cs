namespace PrzemyslawSzafranskiZaddom4
{
    partial class EventManager
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
            this.fKEventsPerformanceEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przemyslawSzafranskiSQLZD4DataSet = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSet();
            this.eventsTableAdapter = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventsTableAdapter();
            this.eventsPerformanceTableAdapter = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventsPerformanceTableAdapter();
            this.addEventButton = new System.Windows.Forms.Button();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.editEventButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eventsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.przemyslawSzafranskiSQLZD4DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fKEventsPerformanceEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fKEventsPerformanceEventsBindingSource
            // 
            this.fKEventsPerformanceEventsBindingSource.DataMember = "FK_EventsPerformance_Events";
            this.fKEventsPerformanceEventsBindingSource.DataSource = this.eventsBindingSource;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.przemyslawSzafranskiSQLZD4DataSet;
            // 
            // przemyslawSzafranskiSQLZD4DataSet
            // 
            this.przemyslawSzafranskiSQLZD4DataSet.DataSetName = "PrzemyslawSzafranskiSQLZD4DataSet";
            this.przemyslawSzafranskiSQLZD4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // eventsPerformanceTableAdapter
            // 
            this.eventsPerformanceTableAdapter.ClearBeforeFill = true;
            // 
            // addEventButton
            // 
            this.addEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addEventButton.Location = new System.Drawing.Point(430, 45);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(158, 77);
            this.addEventButton.TabIndex = 4;
            this.addEventButton.Text = "Dodaj imprezę";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.deleteEventButton.Location = new System.Drawing.Point(13, 45);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(155, 77);
            this.deleteEventButton.TabIndex = 5;
            this.deleteEventButton.Text = "Usuń imprezę";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // editEventButton
            // 
            this.editEventButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editEventButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.editEventButton.Location = new System.Drawing.Point(206, 45);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(185, 77);
            this.editEventButton.TabIndex = 6;
            this.editEventButton.Text = "Edytuj imprezę";
            this.editEventButton.UseVisualStyleBackColor = true;
            this.editEventButton.Click += new System.EventHandler(this.editEventButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 421);
            this.dataGridView1.TabIndex = 7;
            // 
            // eventsBindingSource1
            // 
            this.eventsBindingSource1.DataMember = "Events";
            this.eventsBindingSource1.DataSource = this.przemyslawSzafranskiSQLZD4DataSetBindingSource;
            // 
            // przemyslawSzafranskiSQLZD4DataSetBindingSource
            // 
            this.przemyslawSzafranskiSQLZD4DataSetBindingSource.DataSource = this.przemyslawSzafranskiSQLZD4DataSet;
            this.przemyslawSzafranskiSQLZD4DataSetBindingSource.Position = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(513, 16);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(387, 18);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchTextBox.TabIndex = 8;
            // 
            // EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 561);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editEventButton);
            this.Controls.Add(this.deleteEventButton);
            this.Controls.Add(this.addEventButton);
            this.MaximumSize = new System.Drawing.Size(616, 600);
            this.MinimumSize = new System.Drawing.Size(616, 272);
            this.Name = "EventManager";
            this.Text = "Menadżer imprez by Hantick";
            this.Load += new System.EventHandler(this.EventManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKEventsPerformanceEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PrzemyslawSzafranskiSQLZD4DataSet przemyslawSzafranskiSQLZD4DataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.BindingSource fKEventsPerformanceEventsBindingSource;
        private PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventsPerformanceTableAdapter eventsPerformanceTableAdapter;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.Button editEventButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eventsBindingSource1;
        private System.Windows.Forms.BindingSource przemyslawSzafranskiSQLZD4DataSetBindingSource;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}