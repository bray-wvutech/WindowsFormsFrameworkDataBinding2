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
    public partial class ManualAddForm : Form
    {
        public string PersonName { get; set; }
        public string Age { get; set; }
        public ManualAddForm()
        {
            InitializeComponent();
        }

        private void ManualAddForm_Load(object sender, EventArgs e)
        {
            // you can set this programmatically as well 
            // as in properties
            this.button1.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonName = textBox1.Text;
            Age = textBox2.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
