﻿namespace CoreServicesBootCamp
{
    partial class mainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajBazęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyczyśćBazęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażRaportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilośćZamówieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilośćZamówieńDlaKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.łToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaZamówieńDlaKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniaWartośćZamówieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilośćZamówieńpoNazwieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.pokażRaportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajBazęToolStripMenuItem,
            this.wyczyśćBazęToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // wczytajBazęToolStripMenuItem
            // 
            this.wczytajBazęToolStripMenuItem.Name = "wczytajBazęToolStripMenuItem";
            this.wczytajBazęToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.wczytajBazęToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.wczytajBazęToolStripMenuItem.Text = "Wczytaj pliki...";
            this.wczytajBazęToolStripMenuItem.Click += new System.EventHandler(this.wczytajBazęToolStripMenuItem_Click);
            // 
            // wyczyśćBazęToolStripMenuItem
            // 
            this.wyczyśćBazęToolStripMenuItem.Name = "wyczyśćBazęToolStripMenuItem";
            this.wyczyśćBazęToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.wyczyśćBazęToolStripMenuItem.Text = "Wyczyść bazę";
            this.wyczyśćBazęToolStripMenuItem.Click += new System.EventHandler(this.wyczyśćBazęToolStripMenuItem_Click);
            // 
            // pokażRaportToolStripMenuItem
            // 
            this.pokażRaportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilośćZamówieńToolStripMenuItem,
            this.ilośćZamówieńDlaKlientaToolStripMenuItem,
            this.cToolStripMenuItem,
            this.łToolStripMenuItem,
            this.listaZamówieńDlaKlientaToolStripMenuItem,
            this.średniaWartośćZamówieniaToolStripMenuItem,
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem,
            this.ilośćZamówieńpoNazwieToolStripMenuItem,
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem,
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem});
            this.pokażRaportToolStripMenuItem.Name = "pokażRaportToolStripMenuItem";
            this.pokażRaportToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pokażRaportToolStripMenuItem.Text = "Pokaż raport";
            // 
            // ilośćZamówieńToolStripMenuItem
            // 
            this.ilośćZamówieńToolStripMenuItem.Name = "ilośćZamówieńToolStripMenuItem";
            this.ilośćZamówieńToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ilośćZamówieńToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.ilośćZamówieńToolStripMenuItem.Text = "Ilość zamówień";
            this.ilośćZamówieńToolStripMenuItem.Click += new System.EventHandler(this.ilośćZamówieńToolStripMenuItem_Click);
            // 
            // ilośćZamówieńDlaKlientaToolStripMenuItem
            // 
            this.ilośćZamówieńDlaKlientaToolStripMenuItem.Name = "ilośćZamówieńDlaKlientaToolStripMenuItem";
            this.ilośćZamówieńDlaKlientaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.ilośćZamówieńDlaKlientaToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.ilośćZamówieńDlaKlientaToolStripMenuItem.Text = "Ilość zamówień dla klienta...";
            this.ilośćZamówieńDlaKlientaToolStripMenuItem.Click += new System.EventHandler(this.ilośćZamówieńDlaKlientaToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.cToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.cToolStripMenuItem.Text = "Łączna kwota zamówień";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // łToolStripMenuItem
            // 
            this.łToolStripMenuItem.Name = "łToolStripMenuItem";
            this.łToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
            this.łToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.łToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.łToolStripMenuItem.Text = "Łączna kwota zamówień dla klienta...";
            this.łToolStripMenuItem.Click += new System.EventHandler(this.łToolStripMenuItem_Click);
            // 
            // listaZamówieńDlaKlientaToolStripMenuItem
            // 
            this.listaZamówieńDlaKlientaToolStripMenuItem.Name = "listaZamówieńDlaKlientaToolStripMenuItem";
            this.listaZamówieńDlaKlientaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.listaZamówieńDlaKlientaToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.listaZamówieńDlaKlientaToolStripMenuItem.Text = "Lista zamówień dla klienta...";
            this.listaZamówieńDlaKlientaToolStripMenuItem.Click += new System.EventHandler(this.listaZamówieńDlaKlientaToolStripMenuItem_Click);
            // 
            // średniaWartośćZamówieniaToolStripMenuItem
            // 
            this.średniaWartośćZamówieniaToolStripMenuItem.Name = "średniaWartośćZamówieniaToolStripMenuItem";
            this.średniaWartośćZamówieniaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.średniaWartośćZamówieniaToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.średniaWartośćZamówieniaToolStripMenuItem.Text = "Średnia wartość zamówienia";
            this.średniaWartośćZamówieniaToolStripMenuItem.Click += new System.EventHandler(this.średniaWartośćZamówieniaToolStripMenuItem_Click);
            // 
            // średniaWartośćZamówieniaDlaKlientaToolStripMenuItem
            // 
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem.Name = "średniaWartośćZamówieniaDlaKlientaToolStripMenuItem";
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem.Text = "Średnia wartość zamówienia dla klienta...";
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem.Click += new System.EventHandler(this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem_Click);
            // 
            // ilośćZamówieńpoNazwieToolStripMenuItem
            // 
            this.ilośćZamówieńpoNazwieToolStripMenuItem.Name = "ilośćZamówieńpoNazwieToolStripMenuItem";
            this.ilośćZamówieńpoNazwieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ilośćZamówieńpoNazwieToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.ilośćZamówieńpoNazwieToolStripMenuItem.Text = "Ilość zamówień [po nazwie]";
            this.ilośćZamówieńpoNazwieToolStripMenuItem.Click += new System.EventHandler(this.ilośćZamówieńpoNazwieToolStripMenuItem_Click);
            // 
            // ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem
            // 
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem.Name = "ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem";
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem.Text = "Ilość zamówień dla klienta... [po nazwie]";
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem.Click += new System.EventHandler(this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem_Click);
            // 
            // zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem
            // 
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem.Name = "zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem";
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem.Text = "Zamówienia w podanym przedziale cenowym";
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem.Click += new System.EventHandler(this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientId,
            this.requestId,
            this.name,
            this.quantity,
            this.price});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.Location = new System.Drawing.Point(466, 62);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(390, 325);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clientId
            // 
            this.clientId.HeaderText = "Client_Id";
            this.clientId.Name = "clientId";
            this.clientId.ReadOnly = true;
            this.clientId.Width = 73;
            // 
            // requestId
            // 
            this.requestId.HeaderText = "Request_id";
            this.requestId.Name = "requestId";
            this.requestId.ReadOnly = true;
            this.requestId.Width = 86;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 60;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 71;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 56;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(609, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baza danych";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(320, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pokaż raport";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(81, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 50, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dostępne raporty";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ilość zamówień",
            "Ilość zamówień dla klienta...",
            "Łączna kwota zamówień",
            "Łączna kwota zamówień dla klienta...",
            "Lista zamówień dla klienta...",
            "Średnia wartość zamówienia",
            "Średnia wartość zamówienia dla klienta...",
            "Ilość zamówień [po nazwie]",
            "Ilość zamówień dla klienta... [po nazwie]",
            "Zamówienia w podanym przedziale cenowym"});
            this.comboBox1.Location = new System.Drawing.Point(12, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 27);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView2.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView2.Location = new System.Drawing.Point(12, 108);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(441, 279);
            this.dataGridView2.TabIndex = 9;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(868, 399);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.Text = "Obsługa zamówień";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajBazęToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.BindingSource inMemoryDatabaseBindingSource;
        private System.Windows.Forms.ToolStripMenuItem pokażRaportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilośćZamówieńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilośćZamówieńDlaKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem łToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaZamówieńDlaKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniaWartośćZamówieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniaWartośćZamówieniaDlaKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilośćZamówieńpoNazwieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem wyczyśćBazęToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

