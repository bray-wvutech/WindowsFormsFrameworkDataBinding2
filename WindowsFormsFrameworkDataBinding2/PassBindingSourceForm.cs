using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsFrameworkDataBinding2
{
    public partial class PassBindingSourceForm : Form
    {
        private BindingSource _bindingSource;

        public PassBindingSourceForm(BindingSource bindingSource)
        {
            _bindingSource = bindingSource;
            InitializeComponent();
        }

        private void PassBindingSourceForm_Load(object sender, EventArgs e)
        {
            textBox1.DataBindings.Add("Text", _bindingSource, "Name");
            // we could also do this in the form1 code instead
            _bindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this is ok button
            // we could also do this in form1 code instead
            _bindingSource.EndEdit();

            // use this for cancel button
            //_bindingSource.CancelEdit();
        }
    }
}
