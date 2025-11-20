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
            // one way
            //BadWayForm badWayForm = new BadWayForm();
            //badWayForm.ShowDialog();


            // way number two
            // manually passing values and adding them
            ManualAddForm addForm = new ManualAddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                var newRow = this.database1DataSet.Person.NewPersonRow();
                newRow.Name = addForm.PersonName;
                newRow.Age = addForm.Age;
                this.database1DataSet.Person.AddPersonRow(newRow);
                this.Validate();
                personBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.database1DataSet);
            }

            // way number three
            //PassBindingSourceForm addForm = new PassBindingSourceForm(this.personBindingSource);
            //this.personBindingSource.AddNew();
            //if (addForm.ShowDialog() == DialogResult.OK)
            //{
            //    this.Validate();
            //    this.personBindingSource.EndEdit();
            //    this.tableAdapterManager1.UpdateAll(this.database1DataSet);
            //}
            //else
            //{
            //    this.personBindingSource.CancelEdit();
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personBindingSource.RemoveCurrent();
            this.tableAdapterManager1.UpdateAll(this.database1DataSet);
        }

        private void personBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.personTableAdapter.FillBy(this.database1DataSet.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
