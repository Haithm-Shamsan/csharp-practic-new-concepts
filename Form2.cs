using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practic_new_concepts
{
    public partial class Form2 : Form
    {
        public delegate void DataBackEventHandler(object sender,int PerosnID);

        public event DataBackEventHandler DataBack;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PersonID =int.Parse( txtPersonID.Text);

            DataBack?.Invoke(this, PersonID);
            this.Close();
        }
    }
}
