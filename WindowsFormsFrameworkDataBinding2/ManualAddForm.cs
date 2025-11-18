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
        public ManualAddForm()
        {
            InitializeComponent();
        }

        private void ManualAddForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonName = textBox1.Text;
            this.Close();
        }
    }
}
