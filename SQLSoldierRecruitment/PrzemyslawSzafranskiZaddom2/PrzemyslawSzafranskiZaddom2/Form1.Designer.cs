namespace PrzemyslawSzafranskiZaddom2
{
    partial class mainWindowForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindowForm));
            this.playerNewSoldierProgressBar = new System.Windows.Forms.ProgressBar();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.fasterProdButton = new System.Windows.Forms.Button();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.loadSQLButton = new System.Windows.Forms.Button();
            this.marineCostLabel = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.promoteButton = new System.Windows.Forms.Button();
            this.soldierCostLabel = new System.Windows.Forms.Label();
            this.CreateSoldierButton = new System.Windows.Forms.Button();
            this.coinBox = new System.Windows.Forms.PictureBox();
            this.SoldierNameLabel = new System.Windows.Forms.Label();
            this.SoldierNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.coinLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.aiPanel = new System.Windows.Forms.Panel();
            this.deleteSoldierButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MessageLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.przemyslawSzafranskiSQLZaddom2DataSet = new PrzemyslawSzafranskiZaddom2.PrzemyslawSzafranskiSQLZaddom2DataSet();
            this.przemyslawSzafranskiSQLZaddom2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soldiersAndMarinesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soldiersAndMarinesTableTableAdapter = new PrzemyslawSzafranskiZaddom2.PrzemyslawSzafranskiSQLZaddom2DataSetTableAdapters.SoldiersAndMarinesTableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.aiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZaddom2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZaddom2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldiersAndMarinesTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // playerNewSoldierProgressBar
            // 
            this.playerNewSoldierProgressBar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.playerNewSoldierProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playerNewSoldierProgressBar.Location = new System.Drawing.Point(7, 387);
            this.playerNewSoldierProgressBar.Maximum = 300;
            this.playerNewSoldierProgressBar.Name = "playerNewSoldierProgressBar";
            this.playerNewSoldierProgressBar.Size = new System.Drawing.Size(256, 23);
            this.playerNewSoldierProgressBar.TabIndex = 0;
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // fasterProdButton
            // 
            this.fasterProdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.fasterProdButton.Location = new System.Drawing.Point(3, 328);
            this.fasterProdButton.Name = "fasterProdButton";
            this.fasterProdButton.Size = new System.Drawing.Size(269, 53);
            this.fasterProdButton.TabIndex = 2;
            this.fasterProdButton.Text = "Przyspiesz produkcję!";
            this.fasterProdButton.UseVisualStyleBackColor = true;
            this.fasterProdButton.Click += new System.EventHandler(this.fasterProdButton_Click);
            // 
            // playerPanel
            // 
            this.playerPanel.Controls.Add(this.loadSQLButton);
            this.playerPanel.Controls.Add(this.marineCostLabel);
            this.playerPanel.Controls.Add(this.pictureBox5);
            this.playerPanel.Controls.Add(this.pictureBox4);
            this.playerPanel.Controls.Add(this.promoteButton);
            this.playerPanel.Controls.Add(this.soldierCostLabel);
            this.playerPanel.Controls.Add(this.CreateSoldierButton);
            this.playerPanel.Controls.Add(this.coinBox);
            this.playerPanel.Controls.Add(this.SoldierNameLabel);
            this.playerPanel.Controls.Add(this.SoldierNameTextBox);
            this.playerPanel.Controls.Add(this.pictureBox1);
            this.playerPanel.Controls.Add(this.playerNewSoldierProgressBar);
            this.playerPanel.Controls.Add(this.fasterProdButton);
            this.playerPanel.Location = new System.Drawing.Point(12, 12);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(275, 496);
            this.playerPanel.TabIndex = 4;
            // 
            // loadSQLButton
            // 
            this.loadSQLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.loadSQLButton.Location = new System.Drawing.Point(3, 456);
            this.loadSQLButton.Name = "loadSQLButton";
            this.loadSQLButton.Size = new System.Drawing.Size(269, 37);
            this.loadSQLButton.TabIndex = 12;
            this.loadSQLButton.Text = "Odśwież bazę SQL";
            this.loadSQLButton.UseVisualStyleBackColor = true;
            this.loadSQLButton.Click += new System.EventHandler(this.loadSQLButton_Click);
            // 
            // marineCostLabel
            // 
            this.marineCostLabel.AutoSize = true;
            this.marineCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.marineCostLabel.Location = new System.Drawing.Point(77, 298);
            this.marineCostLabel.Name = "marineCostLabel";
            this.marineCostLabel.Size = new System.Drawing.Size(40, 24);
            this.marineCostLabel.TabIndex = 11;
            this.marineCostLabel.Text = "80x";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(117, 298);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(21, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 243);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // promoteButton
            // 
            this.promoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.promoteButton.Location = new System.Drawing.Point(3, 184);
            this.promoteButton.Name = "promoteButton";
            this.promoteButton.Size = new System.Drawing.Size(269, 53);
            this.promoteButton.TabIndex = 9;
            this.promoteButton.Text = "Stwórz Marine";
            this.promoteButton.UseVisualStyleBackColor = true;
            this.promoteButton.Click += new System.EventHandler(this.promoteButton_Click);
            // 
            // soldierCostLabel
            // 
            this.soldierCostLabel.AutoSize = true;
            this.soldierCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.soldierCostLabel.Location = new System.Drawing.Point(77, 154);
            this.soldierCostLabel.Name = "soldierCostLabel";
            this.soldierCostLabel.Size = new System.Drawing.Size(40, 24);
            this.soldierCostLabel.TabIndex = 6;
            this.soldierCostLabel.Text = "40x";
            // 
            // CreateSoldierButton
            // 
            this.CreateSoldierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CreateSoldierButton.Location = new System.Drawing.Point(3, 40);
            this.CreateSoldierButton.Name = "CreateSoldierButton";
            this.CreateSoldierButton.Size = new System.Drawing.Size(269, 53);
            this.CreateSoldierButton.TabIndex = 5;
            this.CreateSoldierButton.Text = "Stwórz żołnierza";
            this.CreateSoldierButton.UseVisualStyleBackColor = true;
            this.CreateSoldierButton.Click += new System.EventHandler(this.CreateSoldierButton_Click);
            // 
            // coinBox
            // 
            this.coinBox.Image = ((System.Drawing.Image)(resources.GetObject("coinBox.Image")));
            this.coinBox.Location = new System.Drawing.Point(117, 154);
            this.coinBox.Name = "coinBox";
            this.coinBox.Size = new System.Drawing.Size(21, 24);
            this.coinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coinBox.TabIndex = 2;
            this.coinBox.TabStop = false;
            // 
            // SoldierNameLabel
            // 
            this.SoldierNameLabel.AutoSize = true;
            this.SoldierNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SoldierNameLabel.Location = new System.Drawing.Point(3, 8);
            this.SoldierNameLabel.Name = "SoldierNameLabel";
            this.SoldierNameLabel.Size = new System.Drawing.Size(156, 24);
            this.SoldierNameLabel.TabIndex = 4;
            this.SoldierNameLabel.Text = "Nazwa żołnierza:";
            // 
            // SoldierNameTextBox
            // 
            this.SoldierNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.SoldierNameTextBox.Location = new System.Drawing.Point(165, 8);
            this.SoldierNameTextBox.Name = "SoldierNameTextBox";
            this.SoldierNameTextBox.Size = new System.Drawing.Size(107, 26);
            this.SoldierNameTextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.coinLabel.Location = new System.Drawing.Point(298, 3);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(40, 24);
            this.coinLabel.TabIndex = 8;
            this.coinLabel.Text = "000";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(332, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // aiPanel
            // 
            this.aiPanel.Controls.Add(this.deleteSoldierButton);
            this.aiPanel.Controls.Add(this.pictureBox3);
            this.aiPanel.Controls.Add(this.coinLabel);
            this.aiPanel.Location = new System.Drawing.Point(293, 12);
            this.aiPanel.Name = "aiPanel";
            this.aiPanel.Size = new System.Drawing.Size(367, 59);
            this.aiPanel.TabIndex = 5;
            // 
            // deleteSoldierButton
            // 
            this.deleteSoldierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.deleteSoldierButton.Location = new System.Drawing.Point(4, 3);
            this.deleteSoldierButton.Name = "deleteSoldierButton";
            this.deleteSoldierButton.Size = new System.Drawing.Size(161, 53);
            this.deleteSoldierButton.TabIndex = 9;
            this.deleteSoldierButton.Text = "Usuń żołnierza";
            this.deleteSoldierButton.UseVisualStyleBackColor = true;
            this.deleteSoldierButton.Click += new System.EventHandler(this.deleteSoldierButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.MessageLabel.Location = new System.Drawing.Point(293, 484);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 24);
            this.MessageLabel.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.hPDataGridViewTextBoxColumn,
            this.dMGDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.soldiersAndMarinesTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(293, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(367, 345);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // przemyslawSzafranskiSQLZaddom2DataSet
            // 
            this.przemyslawSzafranskiSQLZaddom2DataSet.DataSetName = "PrzemyslawSzafranskiSQLZaddom2DataSet";
            this.przemyslawSzafranskiSQLZaddom2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // przemyslawSzafranskiSQLZaddom2DataSetBindingSource
            // 
            this.przemyslawSzafranskiSQLZaddom2DataSetBindingSource.DataSource = this.przemyslawSzafranskiSQLZaddom2DataSet;
            this.przemyslawSzafranskiSQLZaddom2DataSetBindingSource.Position = 0;
            // 
            // soldiersAndMarinesTableBindingSource
            // 
            this.soldiersAndMarinesTableBindingSource.DataMember = "SoldiersAndMarinesTable";
            this.soldiersAndMarinesTableBindingSource.DataSource = this.przemyslawSzafranskiSQLZaddom2DataSetBindingSource;
            // 
            // soldiersAndMarinesTableTableAdapter
            // 
            this.soldiersAndMarinesTableTableAdapter.ClearBeforeFill = true;
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hPDataGridViewTextBoxColumn
            // 
            this.hPDataGridViewTextBoxColumn.DataPropertyName = "HP";
            this.hPDataGridViewTextBoxColumn.HeaderText = "HP";
            this.hPDataGridViewTextBoxColumn.Name = "hPDataGridViewTextBoxColumn";
            this.hPDataGridViewTextBoxColumn.ReadOnly = true;
            this.hPDataGridViewTextBoxColumn.Width = 40;
            // 
            // dMGDataGridViewTextBoxColumn
            // 
            this.dMGDataGridViewTextBoxColumn.DataPropertyName = "DMG";
            this.dMGDataGridViewTextBoxColumn.HeaderText = "DMG";
            this.dMGDataGridViewTextBoxColumn.Name = "dMGDataGridViewTextBoxColumn";
            this.dMGDataGridViewTextBoxColumn.ReadOnly = true;
            this.dMGDataGridViewTextBoxColumn.Width = 50;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Kondycja";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Width = 102;
            // 
            // mainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.aiPanel);
            this.Controls.Add(this.playerPanel);
            this.Name = "mainWindowForm";
            this.Text = "Gra Przemysław Szafrański";
            this.Load += new System.EventHandler(this.mainWindowForm_Load);
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.aiPanel.ResumeLayout(false);
            this.aiPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZaddom2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przemyslawSzafranskiSQLZaddom2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldiersAndMarinesTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar playerNewSoldierProgressBar;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Button fasterProdButton;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Panel aiPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox coinBox;
        private System.Windows.Forms.Label SoldierNameLabel;
        private System.Windows.Forms.TextBox SoldierNameTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label soldierCostLabel;
        private System.Windows.Forms.Button CreateSoldierButton;
        private System.Windows.Forms.Button promoteButton;
        private System.Windows.Forms.Label coinLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label marineCostLabel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button deleteSoldierButton;
        private System.Windows.Forms.Button loadSQLButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource przemyslawSzafranskiSQLZaddom2DataSetBindingSource;
        private PrzemyslawSzafranskiSQLZaddom2DataSet przemyslawSzafranskiSQLZaddom2DataSet;
        private System.Windows.Forms.BindingSource soldiersAndMarinesTableBindingSource;
        private PrzemyslawSzafranskiSQLZaddom2DataSetTableAdapters.SoldiersAndMarinesTableTableAdapter soldiersAndMarinesTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
    }
}

