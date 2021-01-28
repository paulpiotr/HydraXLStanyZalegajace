#region using

using System;
using System.Windows.Forms;

#endregion

namespace HydraXLStanyZalegajace.Forms.Forms
{
    public partial class StanyZalegajaceForm : Form
    {
        public StanyZalegajaceForm()
        {
            InitializeComponent();
        }

        public StanyZalegajaceForm(BindingSource bindingSource)
        {
            InitializeComponent();
            dataGridViewStanyZalegajace.DataSource = bindingSource;
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();
    }
}
