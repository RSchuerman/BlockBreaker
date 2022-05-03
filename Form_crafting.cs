using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBreaker
{
    public partial class Form_crafting : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)/MSSQLLocalDB;AttachDbFilename=C:/Users/RSchuerman/source/repos/BlockBreaker/Database.mdf;Integrated Security=True;");
        
        public Form_crafting()
        {
            InitializeComponent();
            //conn.Open();
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

        #region Buttons
        #region Wood buttons
        private void button_oakPlanks_Click(object sender, EventArgs e)
        {
            if(Form_main.oakLog.amount > 0)
            {
                Form_main.oakPlanks.amount += 4;
                Form_main.oakLog.amount--;
            }
            updateLabels();
        }
        private void button_birchPlanks_Click(object sender, EventArgs e)
        {
            if (Form_main.birchLog.amount > 0)
            {
                Form_main.birchPlanks.amount += 4;
                Form_main.birchLog.amount--;
            }
            updateLabels();
        }
        private void button_sprucePlanks_Click(object sender, EventArgs e)
        {
            if (Form_main.spruceLog.amount > 0)
            {
                Form_main.sprucePlanks.amount += 4;
                Form_main.spruceLog.amount--;
            }
            updateLabels();
        }
        private void button_junglePlanks_Click(object sender, EventArgs e)
        {
            if (Form_main.jungleLog.amount > 0)
            {
                Form_main.junglePlanks.amount += 4;
                Form_main.jungleLog.amount--;
            }
            updateLabels();
        }
        private void button_acaciaPlanks_Click(object sender, EventArgs e)
        {
            if (Form_main.acaciaLog.amount > 0)
            {
                Form_main.acaciaPlanks.amount += 4;
                Form_main.acaciaLog.amount--;
            }
            updateLabels();
        }
        private void button_darkOakPlanks_Click(object sender, EventArgs e)
        {
            if (Form_main.darkOakLog.amount > 0)
            {
                Form_main.darkOakPlanks.amount += 4;
                Form_main.darkOakLog.amount--;
            }
            updateLabels();
        }
        private void button_stick_Click(object sender, EventArgs e)
        {
            if (Form_main.oakPlanks.amount >= 2)
            {
                Form_main.stick.amount += 4;
                Form_main.oakPlanks.amount -= 2;
            }
            else if (Form_main.birchPlanks.amount >= 2)
            {
                Form_main.stick.amount += 4;
                Form_main.birchPlanks.amount -= 2;
            }
            else if (Form_main.sprucePlanks.amount >= 2)
            {
                Form_main.stick.amount += 4;
                Form_main.sprucePlanks.amount -= 2;
            }
            else if (Form_main.junglePlanks.amount >= 2)
            {
                Form_main.stick.amount += 4;
                Form_main.junglePlanks.amount -= 2;
            }
            else if (Form_main.acaciaPlanks.amount >= 2)
            {
                Form_main.stick.amount += 4;
                Form_main.acaciaPlanks.amount -= 2;
            }
            else if (Form_main.darkOakPlanks.amount >= 2)
            {
                Form_main.stick.amount += 4;
                Form_main.darkOakPlanks.amount -= 2;
            }
            updateLabels();
        }
        #endregion

        #region Tools buttons
        #region Wood Tools buttons
        private void button_woodenPickaxe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.oakPlanks.amount >= 3)
            {
                Form_main.pickaxe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.oakPlanks.amount -= 3;
                if (Form_main.pickaxe.toolLevel == 0)
                    Form_main.pickaxe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.birchPlanks.amount >= 3)
            {
                Form_main.pickaxe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.birchPlanks.amount -= 3;
                if (Form_main.pickaxe.toolLevel == 0)
                    Form_main.pickaxe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.sprucePlanks.amount >= 3)
            {
                Form_main.pickaxe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.sprucePlanks.amount -= 3;
                if (Form_main.pickaxe.toolLevel == 0)
                    Form_main.pickaxe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.junglePlanks.amount >= 3)
            {
                Form_main.pickaxe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.junglePlanks.amount -= 3;
                if (Form_main.pickaxe.toolLevel == 0)
                    Form_main.pickaxe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.acaciaPlanks.amount >= 3)
            {
                Form_main.pickaxe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.acaciaPlanks.amount -= 3;
                if (Form_main.pickaxe.toolLevel == 0)
                    Form_main.pickaxe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.darkOakPlanks.amount >= 3)
            {
                Form_main.pickaxe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.darkOakPlanks.amount -= 3;
                if (Form_main.pickaxe.toolLevel == 0)
                    Form_main.pickaxe.toolLevel = 1;
            }
            updateLabels();
        }
        private void button_woodenAxe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.oakPlanks.amount >= 3)
            {
                Form_main.axe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.oakPlanks.amount -= 3;
                if (Form_main.axe.toolLevel == 0)
                    Form_main.axe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.birchPlanks.amount >= 3)
            {
                Form_main.axe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.birchPlanks.amount -= 3;
                if (Form_main.axe.toolLevel == 0)
                    Form_main.axe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.sprucePlanks.amount >= 3)
            {
                Form_main.axe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.sprucePlanks.amount -= 3;
                if (Form_main.axe.toolLevel == 0)
                    Form_main.axe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.junglePlanks.amount >= 3)
            {
                Form_main.axe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.junglePlanks.amount -= 3;
                if (Form_main.axe.toolLevel == 0)
                    Form_main.axe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.acaciaPlanks.amount >= 3)
            {
                Form_main.axe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.acaciaPlanks.amount -= 3;
                if (Form_main.axe.toolLevel == 0)
                    Form_main.axe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.darkOakPlanks.amount >= 3)
            {
                Form_main.axe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.darkOakPlanks.amount -= 3;
                if (Form_main.axe.toolLevel == 0)
                    Form_main.axe.toolLevel = 1;
            }
            updateLabels();
        }
        private void button_woodenShovel_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.oakPlanks.amount >= 1)
            {
                Form_main.shovel.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.oakPlanks.amount -= 1;
                if (Form_main.shovel.toolLevel == 0)
                    Form_main.shovel.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.birchPlanks.amount >= 1)
            {
                Form_main.shovel.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.birchPlanks.amount -= 1;
                if (Form_main.shovel.toolLevel == 0)
                    Form_main.shovel.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.sprucePlanks.amount >= 1)
            {
                Form_main.shovel.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.sprucePlanks.amount -= 1;
                if (Form_main.shovel.toolLevel == 0)
                    Form_main.shovel.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.junglePlanks.amount >= 1)
            {
                Form_main.shovel.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.junglePlanks.amount -= 1;
                if (Form_main.shovel.toolLevel == 0)
                    Form_main.shovel.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.acaciaPlanks.amount >= 1)
            {
                Form_main.shovel.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.acaciaPlanks.amount -= 1;
                if (Form_main.shovel.toolLevel == 0)
                    Form_main.shovel.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.darkOakPlanks.amount >= 1)
            {
                Form_main.shovel.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.darkOakPlanks.amount -= 1;
                if (Form_main.shovel.toolLevel == 0)
                    Form_main.shovel.toolLevel = 1;
            }
            updateLabels();
        }
        private void button_woodenHoe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.oakPlanks.amount >= 2)
            {
                Form_main.hoe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.oakPlanks.amount -= 2;
                if (Form_main.hoe.toolLevel == 0)
                    Form_main.hoe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.birchPlanks.amount >= 2)
            {
                Form_main.hoe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.birchPlanks.amount -= 2;
                if (Form_main.hoe.toolLevel == 0)
                    Form_main.hoe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.sprucePlanks.amount >= 2)
            {
                Form_main.hoe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.sprucePlanks.amount -= 2;
                if (Form_main.hoe.toolLevel == 0)
                    Form_main.hoe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.junglePlanks.amount >= 2)
            {
                Form_main.hoe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.junglePlanks.amount -= 2;
                if (Form_main.hoe.toolLevel == 0)
                    Form_main.hoe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.acaciaPlanks.amount >= 2)
            {
                Form_main.hoe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.acaciaPlanks.amount -= 2;
                if (Form_main.hoe.toolLevel == 0)
                    Form_main.hoe.toolLevel = 1;
            }
            else if (Form_main.stick.amount >= 2 && Form_main.darkOakPlanks.amount >= 2)
            {
                Form_main.hoe.durability += 59;
                Form_main.stick.amount -= 2;
                Form_main.darkOakPlanks.amount -= 2;
                if (Form_main.hoe.toolLevel == 0)
                    Form_main.hoe.toolLevel = 1;
            }
            updateLabels();
        }
        #endregion
        #region Stone Tools buttons
        private void button_stonePickaxe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.cobblestone.amount >= 3)
            {
                Form_main.pickaxe.durability += 131;
                Form_main.stick.amount -= 2;
                Form_main.cobblestone.amount -= 3;
                if (Form_main.pickaxe.toolLevel <= 1)
                    Form_main.pickaxe.toolLevel = 2;
            }
            updateLabels();
        }
        private void button_stoneAxe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.cobblestone.amount >= 3)
            {
                Form_main.axe.durability += 131;
                Form_main.stick.amount -= 2;
                Form_main.cobblestone.amount -= 3;
                if (Form_main.axe.toolLevel <= 1)
                    Form_main.axe.toolLevel = 2;
            }
            updateLabels();
        }
        private void button_stoneShovel_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.cobblestone.amount >= 1)
            {
                Form_main.shovel.durability += 131;
                Form_main.stick.amount -= 2;
                Form_main.cobblestone.amount -= 1;
                if (Form_main.shovel.toolLevel <= 1)
                    Form_main.shovel.toolLevel = 2;
            }
            updateLabels();
        }
        private void button_stoneHoe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.cobblestone.amount >= 2)
            {
                Form_main.hoe.durability += 131;
                Form_main.stick.amount -= 2;
                Form_main.cobblestone.amount -= 2;
                if (Form_main.hoe.toolLevel <= 1)
                    Form_main.hoe.toolLevel = 2;
            }
            updateLabels();
        }
        #endregion
        #region Iron Tools buttons
        private void button_ironPickaxe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.ironIngot.amount >= 3)
            {
                Form_main.pickaxe.durability += 250;
                Form_main.stick.amount -= 2;
                Form_main.ironIngot.amount -= 3;
                if (Form_main.pickaxe.toolLevel <= 2)
                    Form_main.pickaxe.toolLevel = 3;
            }
            updateLabels();
        }
        private void button_ironAxe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.ironIngot.amount >= 3)
            {
                Form_main.axe.durability += 250;
                Form_main.stick.amount -= 2;
                Form_main.ironIngot.amount -= 3;
                if (Form_main.axe.toolLevel <= 2)
                    Form_main.axe.toolLevel = 3;
            }
            updateLabels();
        }
        private void button_ironShovel_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.ironIngot.amount >= 1)
            {
                Form_main.shovel.durability += 250;
                Form_main.stick.amount -= 2;
                Form_main.ironIngot.amount -= 1;
                if (Form_main.shovel.toolLevel <= 2)
                    Form_main.shovel.toolLevel = 3;
            }
            updateLabels();
        }
        private void button_ironHoe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.ironIngot.amount >= 2)
            {
                Form_main.hoe.durability += 250;
                Form_main.stick.amount -= 2;
                Form_main.ironIngot.amount -= 2;
                if (Form_main.hoe.toolLevel <= 2)
                    Form_main.hoe.toolLevel = 3;
            }
            updateLabels();
        }
        #endregion
        #region Diamond Tools buttons
        private void button_diamondPickaxe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.diamond.amount >= 3)
            {
                Form_main.pickaxe.durability += 250;
                Form_main.stick.amount -= 2;
                Form_main.diamond.amount -= 3;
                if (Form_main.pickaxe.toolLevel <= 3)
                    Form_main.pickaxe.toolLevel = 4;
            }
            updateLabels();
        }
        private void button_diamondAxe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.diamond.amount >= 3)
            {
                Form_main.axe.durability += 250;
                Form_main.stick.amount -= 2;
                Form_main.diamond.amount -= 3;
                if (Form_main.axe.toolLevel <= 3)
                    Form_main.axe.toolLevel = 4;
            }
            updateLabels();
        }
        private void button_diamondShovel_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.diamond.amount >= 1)
            {
                Form_main.shovel.durability += 250;
                Form_main.stick.amount -= 2;
                Form_main.diamond.amount -= 1;
                if (Form_main.shovel.toolLevel <= 3)
                    Form_main.shovel.toolLevel = 4;
            }
            updateLabels();
        }
        private void button_diamondHoe_Click(object sender, EventArgs e)
        {
            if (Form_main.stick.amount >= 2 && Form_main.diamond.amount >= 2)
            {
                Form_main.hoe.durability += 250;
                Form_main.stick.amount -= 2;
                Form_main.diamond.amount -= 2;
                if (Form_main.hoe.toolLevel <= 3)
                    Form_main.hoe.toolLevel = 4;
            }
            updateLabels();
        }
        #endregion
        #endregion

        #region Wheat buttons
        private void button_haybale_Click(object sender, EventArgs e)
        {
            if (Form_main.wheat.amount >= 9)
            {
                Form_main.haybale.amount++;
                Form_main.wheat.amount -= 9;
            }
            updateLabels();
        }
        private void button_wheat_Click(object sender, EventArgs e)
        {
            if (Form_main.haybale.amount > 0)
            {
                Form_main.wheat.amount += 9;
                Form_main.haybale.amount--;
            }
            updateLabels();
        }
        private void button_bread_Click(object sender, EventArgs e)
        {
            if (Form_main.wheat.amount >= 3)
            {
                Form_main.bread.amount++;
                Form_main.wheat.amount -= 3;
            }
            updateLabels();
        }
        #endregion
        #endregion

        
        void updateLabels()
        {
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
            label_woodenPickaxe.Text = Form_main.pickaxe.durability.ToString();
            label_woodenAxe.Text = Form_main.axe.durability.ToString();
            label_woodenShovel.Text = Form_main.shovel.durability.ToString();
            label_woodenHoe.Text = Form_main.hoe.durability.ToString();
            label_stonePickaxe.Text = Form_main.pickaxe.durability.ToString();
            label_stoneAxe.Text = Form_main.axe.durability.ToString();
            label_stoneShovel.Text = Form_main.shovel.durability.ToString();
            label_stoneHoe.Text = Form_main.hoe.durability.ToString();
            label_ironPickaxe.Text = Form_main.pickaxe.durability.ToString();
            label_ironAxe.Text = Form_main.axe.durability.ToString();
            label_ironShovel.Text = Form_main.shovel.durability.ToString();
            label_ironHoe.Text = Form_main.hoe.durability.ToString();
            label_diamondPickaxe.Text = Form_main.pickaxe.durability.ToString();
            label_diamondAxe.Text = Form_main.axe.durability.ToString();
            label_diamondShovel.Text = Form_main.shovel.durability.ToString();
            label_diamondHoe.Text = Form_main.hoe.durability.ToString();
        }

    }
}
