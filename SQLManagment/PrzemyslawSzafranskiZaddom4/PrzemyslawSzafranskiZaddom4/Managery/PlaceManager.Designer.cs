namespace PrzemyslawSzafranskiZaddom4
{
    partial class PlaceManager
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
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editPlaceButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableAdapterManager = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.TableAdapterManager();
            this.placesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKEventsPerformancePlacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsPerformanceTableAdapter = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventsPerformanceTableAdapter();
            this.placesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEventsPerformancePlacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource2)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
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
            this.addPlaceButton.Location = new System.Drawing.Point(313, 61);
            this.addPlaceButton.Name = "addPlaceButton";
            this.addPlaceButton.Size = new System.Drawing.Size(142, 77);
            this.addPlaceButton.TabIndex = 3;
            this.addPlaceButton.Text = "Dodaj salę";
            this.addPlaceButton.UseVisualStyleBackColor = true;
            this.addPlaceButton.Click += new System.EventHandler(this.addPlaceButton_Click);
            // 
            // removePlaceButton
            // 
            this.removePlaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.removePlaceButton.Location = new System.Drawing.Point(12, 60);
            this.removePlaceButton.Name = "removePlaceButton";
            this.removePlaceButton.Size = new System.Drawing.Size(142, 77);
            this.removePlaceButton.TabIndex = 2;
            this.removePlaceButton.Text = "Usuń salę";
            this.removePlaceButton.UseVisualStyleBackColor = true;
            this.removePlaceButton.Click += new System.EventHandler(this.removePlaceButton_Click);
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.placesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // editPlaceButton
            // 
            this.editPlaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.editPlaceButton.Location = new System.Drawing.Point(160, 61);
            this.editPlaceButton.Name = "editPlaceButton";
            this.editPlaceButton.Size = new System.Drawing.Size(147, 77);
            this.editPlaceButton.TabIndex = 4;
            this.editPlaceButton.Text = "Edytuj salę";
            this.editPlaceButton.UseVisualStyleBackColor = true;
            this.editPlaceButton.Click += new System.EventHandler(this.editPlaceButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(254, 35);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchTextBox.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(380, 33);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EventsPerformanceTableAdapter = this.eventsPerformanceTableAdapter;
            this.tableAdapterManager.EventsTableAdapter = null;
            this.tableAdapterManager.EventTypesTableAdapter = null;
            this.tableAdapterManager.PlacesTableAdapter = this.placesTableAdapter;
            this.tableAdapterManager.UpdateOrder = PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // placesBindingSource1
            // 
            this.placesBindingSource1.DataMember = "Places";
            this.placesBindingSource1.DataSource = this.przemyslawSzafranskiSQLZD4DataSet;
            // 
            // fKEventsPerformancePlacesBindingSource
            // 
            this.fKEventsPerformancePlacesBindingSource.DataMember = "FK_EventsPerformance_Places";
            this.fKEventsPerformancePlacesBindingSource.DataSource = this.placesBindingSource1;
            // 
            // eventsPerformanceTableAdapter
            // 
            this.eventsPerformanceTableAdapter.ClearBeforeFill = true;
            // 
            // placesBindingSource2
            // 
            this.placesBindingSource2.DataMember = "Places";
            this.placesBindingSource2.DataSource = this.przemyslawSzafranskiSQLZD4DataSet;
            // 
            // PlaceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(467, 461);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.editPlaceButton);
            this.Controls.Add(this.addPlaceButton);
            this.Controls.Add(this.removePlaceButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(483, 500);
            this.MinimumSize = new System.Drawing.Size(483, 311);
            this.Name = "PlaceManager";
            this.Text = "Menadżer sal by Hantick";
            this.Load += new System.EventHandler(this.PlaceManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKEventsPerformancePlacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placesBindingSource2)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editPlaceButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource placesBindingSource1;
        private PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventsPerformanceTableAdapter eventsPerformanceTableAdapter;
        private System.Windows.Forms.BindingSource fKEventsPerformancePlacesBindingSource;
        private System.Windows.Forms.BindingSource placesBindingSource2;
    }
}