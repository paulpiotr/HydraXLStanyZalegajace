#region using

using System;
using System.Windows.Forms;

#endregion

namespace HydraXLStanyZalegajace.XLHydraChild.Forms
{
    public partial class ZaNOfeEdycjaForm : Form
    {
        public ZaNOfeEdycjaForm()
        {
            InitializeComponent();
        }

        public ZaNOfeEdycjaForm(BindingSource bindingSource)
        {
            InitializeComponent();
            dataGridViewStanyZalegajace.DataSource = bindingSource;
        }

        private void CloseButton_Click(object sender, EventArgs e) => Close();
    }
}
