namespace PrzemyslawSzafranskiZaddom4
{
    partial class ClientManager
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
            this.placesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.przemyslawSzafranskiSQLZD4DataSet = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSet();
            this.placesTableAdapter = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.PlacesTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlaceButton = new System.Windows.Forms.Button();
            this.removePlaceButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKEventsPerformancePlacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsPerformanceTableAdapter = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventsPerformanceTableAdapter();
            this.clientsTableAdapter = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.ClientsTableAdapter();
            this.fKEventsPerformanceClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.editClientButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEventsPerformancePlacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEventsPerformanceClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // placesBindingSource
            // 
            this.placesBindingSource.DataMember = "Places";
            this.placesBindingSource.DataSource = this.przemyslawSzafranskiSQLZD4DataSet;
            // 
            // przemyslawSzafranskiSQLZD4DataSet
            // 
            this.przemyslawSzafranskiSQLZD4DataSet.DataSetName = "PrzemyslawSzafranskiSQLZD4DataSet";
            this.przemyslawSzafranskiSQLZD4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placesTableAdapter
            // 
            this.placesTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baseMenuItem
            // 
            this.baseMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem});
            this.baseMenuItem.Name = "baseMenuItem";
            this.baseMenuItem.Size = new System.Drawing.Size(43, 20);
            this.baseMenuItem.Text = "Baza";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveMenuItem.Text = "Zapisz";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // addPlaceButton
            // 
            this.addPlaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPlaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addPlaceButton.Location = new System.Drawing.Point(485, 69);
            this.addPlaceButton.Name = "addPlaceButton";
            this.addPlaceButton.Size = new System.Drawing.Size(217, 77);
            this.addPlaceButton.TabIndex = 3;
            this.addPlaceButton.Text = "Dodaj klienta";
            this.addPlaceButton.UseVisualStyleBackColor = true;
            this.addPlaceButton.Click += new System.EventHandler(this.addPlaceButton_Click);
            // 
            // removePlaceButton
            // 
            this.removePlaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.removePlaceButton.Location = new System.Drawing.Point(15, 69);
            this.removePlaceButton.Name = "removePlaceButton";
            this.removePlaceButton.Size = new System.Drawing.Size(217, 77);
            this.removePlaceButton.TabIndex = 2;
            this.removePlaceButton.Text = "Usuń klienta";
            this.removePlaceButton.UseVisualStyleBackColor = true;
            this.removePlaceButton.Click += new System.EventHandler(this.removePlaceButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 112);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 32;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 120;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 120;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.Width = 110;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.przemyslawSzafranskiSQLZD4DataSet;
            // 
            // fKEventsPerformancePlacesBindingSource
            // 
            this.fKEventsPerformancePlacesBindingSource.DataMember = "FK_EventsPerformance_Places";
            this.fKEventsPerformancePlacesBindingSource.DataSource = this.placesBindingSource;
            // 
            // eventsPerformanceTableAdapter
            // 
            this.eventsPerformanceTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // fKEventsPerformanceClientsBindingSource
            // 
            this.fKEventsPerformanceClientsBindingSource.DataMember = "FK_EventsPerformance_Clients";
            this.fKEventsPerformanceClientsBindingSource.DataSource = this.clientsBindingSource;
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.przemyslawSzafranskiSQLZD4DataSet;
            // 
            // editClientButton
            // 
            this.editClientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.editClientButton.Location = new System.Drawing.Point(238, 69);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(236, 77);
            this.editClientButton.TabIndex = 4;
            this.editClientButton.Text = "Edytuj klienta";
            this.editClientButton.UseVisualStyleBackColor = true;
            this.editClientButton.Click += new System.EventHandler(this.editClientButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(622, 40);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(496, 42);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchTextBox.TabIndex = 7;
            // 
            // ClientManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 276);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.editClientButton);
            this.Controls.Add(this.addPlaceButton);
            this.Controls.Add(this.removePlaceButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(730, 500);
            this.MinimumSize = new System.Drawing.Size(730, 311);
            this.Name = "ClientManager";
            this.Text = "Menadżer klientów by Hantick";
            this.Load += new System.EventHandler(this.PlaceManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEventsPerformancePlacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEventsPerformanceClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PrzemyslawSzafranskiSQLZD4DataSet przemyslawSzafranskiSQLZD4DataSet;
        private System.Windows.Forms.BindingSource placesBindingSource;
        private PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.PlacesTableAdapter placesTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.Button addPlaceButton;
        private System.Windows.Forms.Button removePlaceButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKEventsPerformancePlacesBindingSource;
        private PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventsPerformanceTableAdapter eventsPerformanceTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource fKEventsPerformanceClientsBindingSource;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button editClientButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}