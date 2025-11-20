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
            textBox2.DataBindings.Add("Text", _bindingSource, "Age");   
            // we could also do this in the form1 code instead
            // don't do this in both places
            // if you do this in main form don't do it here
            //_bindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this is ok button
            // we could also do this in form1 code instead
            // don't do this in both places
            // if you do this in main form don't do it here
            //_bindingSource.EndEdit();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // use this for cancel button
            // don't do this in both places
            // if you do this in main form don't do it here
            //_bindingSource.CancelEdit();

            this.Close();
        }
    }
}
