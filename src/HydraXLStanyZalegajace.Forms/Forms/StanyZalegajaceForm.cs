#region using

using System;
using System.Windows.Forms;

#endregion

namespace HydraXLStanyZalegajace.Forms.Forms
{
    public partial class StanyZalegajaceForm : Form, IWin32Window
    {
        public StanyZalegajaceForm(BindingSource bindingSource)
        {
            InitializeComponent();
            dataGridViewStanyZalegajace.DataSource = bindingSource;
            dataGridViewStanyZalegajace.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewStanyZalegajace.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();
    }
}
