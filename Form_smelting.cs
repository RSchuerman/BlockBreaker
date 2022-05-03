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
    public partial class Form_smelting : Form
    {
        public Form_smelting()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Form_main mainForm = new Form_main();
            mainForm.Show();
            this.Hide();
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button_ironIngot_Click(object sender, EventArgs e)
        {
            if (Form_main.ironOre.amount > 8 && Form_main.coal.amount > 1)
            {
                Form_main.ironIngot.amount += 8;
                Form_main.ironOre.amount -= 8;
                Form_main.coal.amount--;
                label_ironIngot.Text = Form_main.ironIngot.amount.ToString();
            }
        }

        private void button_goldIngot_Click(object sender, EventArgs e)
        {
            if (Form_main.goldOre.amount > 8 && Form_main.coal.amount > 1)
            {
                Form_main.goldIngot.amount += 8;
                Form_main.goldOre.amount -= 8;
                Form_main.coal.amount--;
                label_goldIngot.Text = Form_main.goldIngot.amount.ToString();
            }
        }
    }
}
