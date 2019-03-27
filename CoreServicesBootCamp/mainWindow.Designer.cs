namespace CoreServicesBootCamp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajBazęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażRaportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilośćZamówieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilośćZamówieńDlaKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.łToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaWszystkichZamówieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaZamówieńDlaKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniaWartośćZamówieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilośćZamówieńpoNazwieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.pokażRaportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajBazęToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // wczytajBazęToolStripMenuItem
            // 
            this.wczytajBazęToolStripMenuItem.Name = "wczytajBazęToolStripMenuItem";
            this.wczytajBazęToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.wczytajBazęToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.wczytajBazęToolStripMenuItem.Text = "Wczytaj bazę";
            this.wczytajBazęToolStripMenuItem.Click += new System.EventHandler(this.wczytajBazęToolStripMenuItem_Click);
            // 
            // pokażRaportToolStripMenuItem
            // 
            this.pokażRaportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilośćZamówieńToolStripMenuItem,
            this.ilośćZamówieńDlaKlientaToolStripMenuItem,
            this.cToolStripMenuItem,
            this.łToolStripMenuItem,
            this.listaWszystkichZamówieńToolStripMenuItem,
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
            // 
            // ilośćZamówieńDlaKlientaToolStripMenuItem
            // 
            this.ilośćZamówieńDlaKlientaToolStripMenuItem.Name = "ilośćZamówieńDlaKlientaToolStripMenuItem";
            this.ilośćZamówieńDlaKlientaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.ilośćZamówieńDlaKlientaToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.ilośćZamówieńDlaKlientaToolStripMenuItem.Text = "Ilość zamówień dla klienta...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientId,
            this.requestId,
            this.name,
            this.quantity,
            this.price});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(344, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // clientId
            // 
            this.clientId.HeaderText = "Client_Id";
            this.clientId.Name = "clientId";
            this.clientId.ReadOnly = true;
            // 
            // requestId
            // 
            this.requestId.HeaderText = "Request_id";
            this.requestId.Name = "requestId";
            this.requestId.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.cToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.cToolStripMenuItem.Text = "Łączna kwota zamówień";
            // 
            // łToolStripMenuItem
            // 
            this.łToolStripMenuItem.Name = "łToolStripMenuItem";
            this.łToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+D";
            this.łToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.łToolStripMenuItem.Text = "Łączna kwota zamówień dla klienta...";
            // 
            // listaWszystkichZamówieńToolStripMenuItem
            // 
            this.listaWszystkichZamówieńToolStripMenuItem.Name = "listaWszystkichZamówieńToolStripMenuItem";
            this.listaWszystkichZamówieńToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.listaWszystkichZamówieńToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.listaWszystkichZamówieńToolStripMenuItem.Text = "Lista wszystkich zamówień";
            // 
            // listaZamówieńDlaKlientaToolStripMenuItem
            // 
            this.listaZamówieńDlaKlientaToolStripMenuItem.Name = "listaZamówieńDlaKlientaToolStripMenuItem";
            this.listaZamówieńDlaKlientaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.listaZamówieńDlaKlientaToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.listaZamówieńDlaKlientaToolStripMenuItem.Text = "Lista zamówień dla klienta...";
            // 
            // średniaWartośćZamówieniaToolStripMenuItem
            // 
            this.średniaWartośćZamówieniaToolStripMenuItem.Name = "średniaWartośćZamówieniaToolStripMenuItem";
            this.średniaWartośćZamówieniaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.średniaWartośćZamówieniaToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.średniaWartośćZamówieniaToolStripMenuItem.Text = "Średnia wartość zamówienia";
            // 
            // średniaWartośćZamówieniaDlaKlientaToolStripMenuItem
            // 
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem.Name = "średniaWartośćZamówieniaDlaKlientaToolStripMenuItem";
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.średniaWartośćZamówieniaDlaKlientaToolStripMenuItem.Text = "Średnia wartość zamówienia dla klienta...";
            // 
            // ilośćZamówieńpoNazwieToolStripMenuItem
            // 
            this.ilośćZamówieńpoNazwieToolStripMenuItem.Name = "ilośćZamówieńpoNazwieToolStripMenuItem";
            this.ilośćZamówieńpoNazwieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ilośćZamówieńpoNazwieToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.ilośćZamówieńpoNazwieToolStripMenuItem.Text = "Ilość zamówień [po nazwie]";
            // 
            // ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem
            // 
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem.Name = "ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem";
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem.Text = "Ilość zamówień dla klienta... [po nazwie]";
            // 
            // zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem
            // 
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem.Name = "zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem";
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem.Text = "Zamówienia w podanym przedziale cenowym";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainWindow";
            this.Text = "Obsługa zamówień";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem listaWszystkichZamówieńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaZamówieńDlaKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniaWartośćZamówieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniaWartośćZamówieniaDlaKlientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilośćZamówieńpoNazwieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilośćZamówieńDlaKlientapoNazwieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamówieniaWPodanymPrzedzialeCenowymToolStripMenuItem;
    }
}

