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
    public partial class Form_inventory : Form
    {
        public Form_inventory()
        {
            InitializeComponent();
            updateLabels();
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

        void updateLabels()
        {
            label_oakLog.Text = Form_main.oakLog.amount.ToString();
            label_birchLog.Text = Form_main.birchLog.amount.ToString();
            label_spruceLog.Text = Form_main.spruceLog.amount.ToString();
            label_jungleLog.Text = Form_main.jungleLog.amount.ToString();
            label_acaciaLog.Text = Form_main.acaciaLog.amount.ToString();
            label_darkOakLog.Text = Form_main.darkOakLog.amount.ToString();
            label_oakPlanks.Text = Form_main.oakPlanks.amount.ToString();
            label_birchPlanks.Text = Form_main.birchPlanks.amount.ToString();
            label_sprucePlanks.Text = Form_main.sprucePlanks.amount.ToString();
            label_junglePlanks.Text = Form_main.junglePlanks.amount.ToString();
            label_acaciaPlanks.Text = Form_main.acaciaPlanks.amount.ToString();
            label_darkOakPlanks.Text = Form_main.darkOakPlanks.amount.ToString();
            label_stick.Text = Form_main.stick.amount.ToString();
            label_haybale.Text = Form_main.haybale.amount.ToString();
            label_wheat.Text = Form_main.wheat.amount.ToString();
            label_bread.Text = Form_main.bread.amount.ToString();
            label_coal.Text = Form_main.coal.amount.ToString();
            label_diamond.Text = Form_main.diamond.amount.ToString();
            label_ironIngot.Text = Form_main.ironIngot.amount.ToString();
            label_ironOre.Text = Form_main.ironOre.amount.ToString();
            label_goldIngot.Text = Form_main.goldIngot.amount.ToString();
            label_goldOre.Text = Form_main.goldOre.amount.ToString();
            label_redstone.Text = Form_main.redstone.amount.ToString();
            label_lapis.Text = Form_main.lapis.amount.ToString();
            label_dirt.Text = Form_main.dirt.amount.ToString();
            label_gravel.Text = Form_main.gravel.amount.ToString();
            label_sand.Text = Form_main.sand.amount.ToString();
            label_cobblestone.Text = Form_main.cobblestone.amount.ToString();
            label_andesite.Text = Form_main.andesite.amount.ToString();
            label_granite.Text = Form_main.granite.amount.ToString();
            label_diorite.Text = Form_main.diorite.amount.ToString();
            label_pickaxe.Text = Form_main.pickaxe.durability.ToString();
            label_axe.Text = Form_main.axe.durability.ToString();
            label_shovel.Text = Form_main.shovel.durability.ToString();
            label_hoe.Text = Form_main.hoe.durability.ToString();
        }
    }
}
