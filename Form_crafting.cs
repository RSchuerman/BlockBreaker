using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBreaker
{
    public partial class Form_crafting : Form
    {
        public Form_crafting()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Form_main mainForm = new Form_main();
            mainForm.Show();
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
