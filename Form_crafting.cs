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
        #region Initialize Items
        static Item oakPlank = new Item(1, "logs/oakPlank.png");
        #endregion
        public Form_crafting()
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

        #region Wood buttons
        private void button_oakPlanks_Click(object sender, EventArgs e)
        {

        }
        private void button_birchPlanks_Click(object sender, EventArgs e)
        {

        }
        private void button_sprucePlanks_Click(object sender, EventArgs e)
        {

        }
        private void button_junglePlanks_Click(object sender, EventArgs e)
        {

        }
        private void button_acaciaPlanks_Click(object sender, EventArgs e)
        {

        }
        private void button_darkOakPlanks_Click(object sender, EventArgs e)
        {

        }
        private void button_stick_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Tools buttons
        #region Wood Tools buttons
        private void button_woodenPickaxe_Click(object sender, EventArgs e)
        {

        }
        private void button_woodenAxe_Click(object sender, EventArgs e)
        {

        }
        private void button_woodenShovel_Click(object sender, EventArgs e)
        {

        }
        private void button_woodenHoe_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Stone Tools buttons
        private void button_stonePickaxe_Click(object sender, EventArgs e)
        {

        }
        private void button_stoneAxe_Click(object sender, EventArgs e)
        {

        }
        private void button_stoneShovel_Click(object sender, EventArgs e)
        {

        }
        private void button_stoneHoe_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Iron Tools buttons
        private void button_ironPickaxe_Click(object sender, EventArgs e)
        {

        }
        private void button_ironAxe_Click(object sender, EventArgs e)
        {

        }
        private void button_ironShovel_Click(object sender, EventArgs e)
        {

        }
        private void button_ironHoe_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Diamond Tools buttons
        private void button_diamondPickaxe_Click(object sender, EventArgs e)
        {

        }
        private void button_diamondAxe_Click(object sender, EventArgs e)
        {

        }
        private void button_diamondShovel_Click(object sender, EventArgs e)
        {

        }
        private void button_diamondHoe_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion

        #region Wheat buttons
        private void button_haybale_Click(object sender, EventArgs e)
        {

        }
        private void button_wheat_Click(object sender, EventArgs e)
        {

        }
        private void button_bread_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
