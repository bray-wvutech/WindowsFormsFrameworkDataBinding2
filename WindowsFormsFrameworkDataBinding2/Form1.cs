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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.database1DataSet.Person);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.database1DataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // manually passing values and adding them
            //var newRow = this.database1DataSet.Person.NewPersonRow();

            //ManualAddForm addForm = new ManualAddForm();            
            //addForm.ShowDialog();
            
            //newRow.Name = addForm.PersonName;
            //newRow.Age = "89";
            //this.database1DataSet.Person.AddPersonRow(newRow);
            //this.Validate();
            //personBindingSource.EndEdit();
            //this.tableAdapterManager1.UpdateAll(this.database1DataSet);

            PassBindingSourceForm addForm = new PassBindingSourceForm(this.personBindingSource);
            addForm.ShowDialog();
        }
    }
}
