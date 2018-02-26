namespace PrzemyslawSzafranskiZaddom1
{
    partial class resultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resultsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.congratulationsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newbornsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cowsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicksColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.newbornsColumn,
            this.personColumn,
            this.cowsColumn,
            this.clicksColumn});
            this.dataGridView1.Location = new System.Drawing.Point(34, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // congratulationsLabel
            // 
            this.congratulationsLabel.AutoSize = true;
            this.congratulationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.congratulationsLabel.Location = new System.Drawing.Point(12, 9);
            this.congratulationsLabel.Name = "congratulationsLabel";
            this.congratulationsLabel.Size = new System.Drawing.Size(494, 24);
            this.congratulationsLabel.TabIndex = 1;
            this.congratulationsLabel.Text = "Gratulacje! Udało Ci się zebrać wystarczającą ilość kupek!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Twój czas wynosi: "+mainAppForm.GetTotalTime()+" sekundy.";
            // 
            // newbornsColumn
            // 
            this.newbornsColumn.HeaderText = "Noworodki";
            this.newbornsColumn.Name = "newbornsColumn";
            this.newbornsColumn.ReadOnly = true;
            this.newbornsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // personColumn
            // 
            this.personColumn.HeaderText = "Ludzie";
            this.personColumn.Name = "personColumn";
            this.personColumn.ReadOnly = true;
            // 
            // cowsColumn
            // 
            this.cowsColumn.HeaderText = "Krowy";
            this.cowsColumn.Name = "cowsColumn";
            this.cowsColumn.ReadOnly = true;
            // 
            // clicksColumn
            // 
            this.clicksColumn.HeaderText = "Kliknięcia";
            this.clicksColumn.Name = "clicksColumn";
            this.clicksColumn.ReadOnly = true;
            // 
            // resultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.congratulationsLabel);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "resultsForm";
            this.Text = "Tabela wyników";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label congratulationsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn newbornsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cowsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicksColumn;
    }
}