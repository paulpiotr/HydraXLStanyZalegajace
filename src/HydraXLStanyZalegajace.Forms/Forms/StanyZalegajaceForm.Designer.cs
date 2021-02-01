
namespace HydraXLStanyZalegajace.Forms.Forms
{
    partial class StanyZalegajaceForm
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
            this.dataGridViewStanyZalegajace = new System.Windows.Forms.DataGridView();
            this.stanyZalegajaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ZaNOfeEdycjaPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.twZMagNumerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twZMagKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twZTwrNumerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Twr_Kod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Twr_Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TwZ_IlDok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStanyZalegajace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanyZalegajaceBindingSource)).BeginInit();
            this.ZaNOfeEdycjaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStanyZalegajace
            // 
            this.dataGridViewStanyZalegajace.AllowUserToAddRows = false;
            this.dataGridViewStanyZalegajace.AllowUserToDeleteRows = false;
            this.dataGridViewStanyZalegajace.AutoGenerateColumns = false;
            this.dataGridViewStanyZalegajace.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStanyZalegajace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStanyZalegajace.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewStanyZalegajace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStanyZalegajace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.twZMagNumerDataGridViewTextBoxColumn,
            this.twZMagKodDataGridViewTextBoxColumn,
            this.twZTwrNumerDataGridViewTextBoxColumn,
            this.Twr_Kod,
            this.Twr_Nazwa,
            this.TwZ_IlDok,
            this.Last});
            this.dataGridViewStanyZalegajace.DataSource = this.stanyZalegajaceBindingSource;
            this.dataGridViewStanyZalegajace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStanyZalegajace.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewStanyZalegajace.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStanyZalegajace.Margin = new System.Windows.Forms.Padding(8);
            this.dataGridViewStanyZalegajace.Name = "dataGridViewStanyZalegajace";
            this.dataGridViewStanyZalegajace.ReadOnly = true;
            this.dataGridViewStanyZalegajace.RowHeadersVisible = false;
            this.dataGridViewStanyZalegajace.RowHeadersWidth = 51;
            this.dataGridViewStanyZalegajace.RowTemplate.Height = 24;
            this.dataGridViewStanyZalegajace.Size = new System.Drawing.Size(599, 290);
            this.dataGridViewStanyZalegajace.TabIndex = 0;
            // 
            // stanyZalegajaceBindingSource
            // 
            this.stanyZalegajaceBindingSource.DataSource = typeof(HydraXLStanyZalegajace.Core.Models.StanyZalegajace);
            // 
            // ZaNOfeEdycjaPanel
            // 
            this.ZaNOfeEdycjaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZaNOfeEdycjaPanel.Controls.Add(this.dataGridViewStanyZalegajace);
            this.ZaNOfeEdycjaPanel.Location = new System.Drawing.Point(9, 54);
            this.ZaNOfeEdycjaPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ZaNOfeEdycjaPanel.Name = "ZaNOfeEdycjaPanel";
            this.ZaNOfeEdycjaPanel.Size = new System.Drawing.Size(599, 290);
            this.ZaNOfeEdycjaPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Powyżej znajduje się lista stanów zalegających na magazynach.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(156, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aby zakończyć pracę zamknij okno lub kliknij zakończ.";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CloseButton.FlatAppearance.BorderSize = 2;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(11, 15);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(141, 25);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Zakończ";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // twZMagNumerDataGridViewTextBoxColumn
            // 
            this.twZMagNumerDataGridViewTextBoxColumn.DataPropertyName = "TwZ_MagNumer";
            this.twZMagNumerDataGridViewTextBoxColumn.HeaderText = "Numer magazynu";
            this.twZMagNumerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.twZMagNumerDataGridViewTextBoxColumn.Name = "twZMagNumerDataGridViewTextBoxColumn";
            this.twZMagNumerDataGridViewTextBoxColumn.ReadOnly = true;
            this.twZMagNumerDataGridViewTextBoxColumn.Width = 125;
            // 
            // twZMagKodDataGridViewTextBoxColumn
            // 
            this.twZMagKodDataGridViewTextBoxColumn.DataPropertyName = "TwZ_MagKod";
            this.twZMagKodDataGridViewTextBoxColumn.HeaderText = "Kod magazynu";
            this.twZMagKodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.twZMagKodDataGridViewTextBoxColumn.Name = "twZMagKodDataGridViewTextBoxColumn";
            this.twZMagKodDataGridViewTextBoxColumn.ReadOnly = true;
            this.twZMagKodDataGridViewTextBoxColumn.Width = 125;
            // 
            // twZTwrNumerDataGridViewTextBoxColumn
            // 
            this.twZTwrNumerDataGridViewTextBoxColumn.DataPropertyName = "TwZ_TwrNumer";
            this.twZTwrNumerDataGridViewTextBoxColumn.HeaderText = "Numer towaru";
            this.twZTwrNumerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.twZTwrNumerDataGridViewTextBoxColumn.Name = "twZTwrNumerDataGridViewTextBoxColumn";
            this.twZTwrNumerDataGridViewTextBoxColumn.ReadOnly = true;
            this.twZTwrNumerDataGridViewTextBoxColumn.Width = 125;
            // 
            // Twr_Kod
            // 
            this.Twr_Kod.DataPropertyName = "Twr_Kod";
            this.Twr_Kod.HeaderText = "Kod towaru";
            this.Twr_Kod.MinimumWidth = 6;
            this.Twr_Kod.Name = "Twr_Kod";
            this.Twr_Kod.ReadOnly = true;
            this.Twr_Kod.Width = 125;
            // 
            // Twr_Nazwa
            // 
            this.Twr_Nazwa.DataPropertyName = "Twr_Nazwa";
            this.Twr_Nazwa.HeaderText = "Nazwa towaru";
            this.Twr_Nazwa.MinimumWidth = 6;
            this.Twr_Nazwa.Name = "Twr_Nazwa";
            this.Twr_Nazwa.ReadOnly = true;
            this.Twr_Nazwa.Width = 125;
            // 
            // TwZ_IlDok
            // 
            this.TwZ_IlDok.DataPropertyName = "TwZ_IlDok";
            this.TwZ_IlDok.HeaderText = "TwZ_IlDok";
            this.TwZ_IlDok.MinimumWidth = 6;
            this.TwZ_IlDok.Name = "TwZ_IlDok";
            this.TwZ_IlDok.ReadOnly = true;
            this.TwZ_IlDok.Width = 125;
            // 
            // Last
            // 
            this.Last.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Last.HeaderText = "";
            this.Last.MinimumWidth = 6;
            this.Last.Name = "Last";
            this.Last.ReadOnly = true;
            // 
            // StanyZalegajaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 353);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZaNOfeEdycjaPanel);
            this.Name = "StanyZalegajaceForm";
            this.Text = "Stany zalegające";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStanyZalegajace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stanyZalegajaceBindingSource)).EndInit();
            this.ZaNOfeEdycjaPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStanyZalegajace;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel ZaNOfeEdycjaPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn twrKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twrNazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twZIlDokDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stanyZalegajaceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn twZMagNumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twZMagKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn twZTwrNumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Twr_Kod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Twr_Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TwZ_IlDok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last;
    }
}
