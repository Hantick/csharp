namespace PrzemyslawSzafranskiZaddom4
{
    partial class PerformanceManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addPerformanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przemyslawSzafranskiSQLZD4DataSet = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSet();
            this.eventsPerformanceTableAdapter = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventsPerformanceTableAdapter();
            this.tableAdapterManager = new PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.TableAdapterManager();
            this.editPerformanceButton = new System.Windows.Forms.Button();
            this.deletePerformanceButton = new System.Windows.Forms.Button();
            this.addPerformanceButton = new System.Windows.Forms.Button();
            this.eventsPerformanceDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventsPerformanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsPerformanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsPerformanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.baseMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileMenuItem.Text = "Umowa";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveMenuItem.Text = "Generuj";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // baseMenuItem
            // 
            this.baseMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlaceMenuItem,
            this.addClientMenuItem,
            this.toolStripSeparator1,
            this.addPerformanceMenuItem});
            this.baseMenuItem.Name = "baseMenuItem";
            this.baseMenuItem.Size = new System.Drawing.Size(43, 20);
            this.baseMenuItem.Text = "Baza";
            // 
            // addPlaceMenuItem
            // 
            this.addPlaceMenuItem.Name = "addPlaceMenuItem";
            this.addPlaceMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addPlaceMenuItem.Text = "Dodaj Salę";
            this.addPlaceMenuItem.Click += new System.EventHandler(this.addPlaceMenuItem_Click);
            // 
            // addClientMenuItem
            // 
            this.addClientMenuItem.Name = "addClientMenuItem";
            this.addClientMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addClientMenuItem.Text = "Dodaj Klienta";
            this.addClientMenuItem.Click += new System.EventHandler(this.addClientMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // addPerformanceMenuItem
            // 
            this.addPerformanceMenuItem.Name = "addPerformanceMenuItem";
            this.addPerformanceMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addPerformanceMenuItem.Text = "Dodaj imprezę";
            this.addPerformanceMenuItem.Click += new System.EventHandler(this.addPerformanceMenuItem_Click);
            // 
            // przemyslawSzafranskiSQLZD4DataSet
            // 
            this.przemyslawSzafranskiSQLZD4DataSet.DataSetName = "PrzemyslawSzafranskiSQLZD4DataSet";
            this.przemyslawSzafranskiSQLZD4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsPerformanceTableAdapter
            // 
            this.eventsPerformanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EventsPerformanceTableAdapter = this.eventsPerformanceTableAdapter;
            this.tableAdapterManager.EventsTableAdapter = null;
            this.tableAdapterManager.EventTypesTableAdapter = null;
            this.tableAdapterManager.PlacesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrzemyslawSzafranskiZaddom4.PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // editPerformanceButton
            // 
            this.editPerformanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPerformanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.editPerformanceButton.Location = new System.Drawing.Point(202, 75);
            this.editPerformanceButton.Name = "editPerformanceButton";
            this.editPerformanceButton.Size = new System.Drawing.Size(185, 77);
            this.editPerformanceButton.TabIndex = 9;
            this.editPerformanceButton.Text = "Edytuj zlecenie";
            this.editPerformanceButton.UseVisualStyleBackColor = true;
            this.editPerformanceButton.Click += new System.EventHandler(this.editPerformanceButton_Click);
            // 
            // deletePerformanceButton
            // 
            this.deletePerformanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePerformanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.deletePerformanceButton.Location = new System.Drawing.Point(12, 75);
            this.deletePerformanceButton.Name = "deletePerformanceButton";
            this.deletePerformanceButton.Size = new System.Drawing.Size(160, 77);
            this.deletePerformanceButton.TabIndex = 8;
            this.deletePerformanceButton.Text = "Usuń zlecenie";
            this.deletePerformanceButton.UseVisualStyleBackColor = true;
            this.deletePerformanceButton.Click += new System.EventHandler(this.deletePerformanceButton_Click);
            // 
            // addPerformanceButton
            // 
            this.addPerformanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPerformanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addPerformanceButton.Location = new System.Drawing.Point(422, 75);
            this.addPerformanceButton.Name = "addPerformanceButton";
            this.addPerformanceButton.Size = new System.Drawing.Size(162, 77);
            this.addPerformanceButton.TabIndex = 7;
            this.addPerformanceButton.Text = "Dodaj zlecenie";
            this.addPerformanceButton.UseVisualStyleBackColor = true;
            this.addPerformanceButton.Click += new System.EventHandler(this.addPerformanceButton_Click);
            // 
            // eventsPerformanceDataGridView
            // 
            this.eventsPerformanceDataGridView.AutoGenerateColumns = false;
            this.eventsPerformanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsPerformanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.eventIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.placeIDDataGridViewTextBoxColumn});
            this.eventsPerformanceDataGridView.DataSource = this.eventsPerformanceBindingSource;
            this.eventsPerformanceDataGridView.Location = new System.Drawing.Point(12, 158);
            this.eventsPerformanceDataGridView.Name = "eventsPerformanceDataGridView";
            this.eventsPerformanceDataGridView.Size = new System.Drawing.Size(572, 220);
            this.eventsPerformanceDataGridView.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventIDDataGridViewTextBoxColumn
            // 
            this.eventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID";
            this.eventIDDataGridViewTextBoxColumn.HeaderText = "EventID";
            this.eventIDDataGridViewTextBoxColumn.Name = "eventIDDataGridViewTextBoxColumn";
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // placeIDDataGridViewTextBoxColumn
            // 
            this.placeIDDataGridViewTextBoxColumn.DataPropertyName = "PlaceID";
            this.placeIDDataGridViewTextBoxColumn.HeaderText = "PlaceID";
            this.placeIDDataGridViewTextBoxColumn.Name = "placeIDDataGridViewTextBoxColumn";
            // 
            // eventsPerformanceBindingSource
            // 
            this.eventsPerformanceBindingSource.DataMember = "EventsPerformance";
            this.eventsPerformanceBindingSource.DataSource = this.przemyslawSzafranskiSQLZD4DataSet;
            // 
            // PerformanceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 390);
            this.Controls.Add(this.eventsPerformanceDataGridView);
            this.Controls.Add(this.editPerformanceButton);
            this.Controls.Add(this.deletePerformanceButton);
            this.Controls.Add(this.addPerformanceButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PerformanceManager";
            this.Text = "Generator umów DJ Hantick";
            this.Load += new System.EventHandler(this.PerformanceManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZD4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsPerformanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsPerformanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlaceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addPerformanceMenuItem;
        private PrzemyslawSzafranskiSQLZD4DataSet przemyslawSzafranskiSQLZD4DataSet;
        private PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.EventsPerformanceTableAdapter eventsPerformanceTableAdapter;
        private PrzemyslawSzafranskiSQLZD4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button editPerformanceButton;
        private System.Windows.Forms.Button deletePerformanceButton;
        private System.Windows.Forms.Button addPerformanceButton;
        private System.Windows.Forms.DataGridView eventsPerformanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource eventsPerformanceBindingSource;
    }
}

