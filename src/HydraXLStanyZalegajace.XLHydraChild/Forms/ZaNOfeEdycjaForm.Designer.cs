
namespace HydraXLStanyZalegajace.XLHydraChild.Forms
{
    partial class ZaNOfeEdycjaForm
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
            System.Windows.Forms.BindingSource stanyZalegajaceBindingSource;
            this.dataGridViewStanyZalegajace = new System.Windows.Forms.DataGridView();
            this.ZaNOfeEdycjaPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            stanyZalegajaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStanyZalegajace)).BeginInit();
            this.ZaNOfeEdycjaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(stanyZalegajaceBindingSource)).BeginInit();
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
            this.barcodeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn});
            this.dataGridViewStanyZalegajace.DataSource = stanyZalegajaceBindingSource;
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
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barcodeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stanyZalegajaceBindingSource
            // 
            stanyZalegajaceBindingSource.AllowNew = false;
            stanyZalegajaceBindingSource.DataSource = typeof(HydraXLStanyZalegajace.XLHydraChild.Models.StanyZalegajace);
            // 
            // ZaNOfeEdycjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 353);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZaNOfeEdycjaPanel);
            this.Name = "ZaNOfeEdycjaForm";
            this.Text = "Stany zalegające";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStanyZalegajace)).EndInit();
            this.ZaNOfeEdycjaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(stanyZalegajaceBindingSource)).EndInit();
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
    }
}