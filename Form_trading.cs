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
    public partial class Form_trading : Form
    {
        string selectedTool = null;
        string selectedEnchant = null;

        public Form_trading()
        {
            InitializeComponent();
        }

        #region tool buttons
        private void button_shovel_Click(object sender, EventArgs e)
        {
            selectedTool = "shovel";
            label_emeraldEfficiency.Text = (1 + Form_main.shovel.efficiencyLevel).ToString();
            label_emeraldFortune.Text = (1 + Form_main.shovel.fortuneLevel).ToString();
            label_emeraldUnbreaking.Text = (1 + Form_main.shovel.unbreakingLevel).ToString();
            changeVisibility();
        }

        private void button_pickaxe_Click(object sender, EventArgs e)
        {
            selectedTool = "pickaxe";
            label_emeraldEfficiency.Text = (1 + Form_main.pickaxe.efficiencyLevel).ToString();
            label_emeraldFortune.Text = (1 + Form_main.pickaxe.fortuneLevel).ToString();
            label_emeraldUnbreaking.Text = (1 + Form_main.pickaxe.unbreakingLevel).ToString();
            changeVisibility();
        }

        private void button_hoe_Click(object sender, EventArgs e)
        {
            selectedTool = "hoe";
            label_emeraldEfficiency.Text = (1 + Form_main.hoe.efficiencyLevel).ToString();
            label_emeraldFortune.Text = (1 + Form_main.hoe.fortuneLevel).ToString();
            label_emeraldUnbreaking.Text = (1 + Form_main.hoe.unbreakingLevel).ToString();
            changeVisibility();
        }

        private void button_axe_Click(object sender, EventArgs e)
        {
            selectedTool = "axe";
            label_emeraldEfficiency.Text = (1 + Form_main.axe.efficiencyLevel).ToString();
            label_emeraldFortune.Text = (1 + Form_main.axe.fortuneLevel).ToString();
            label_emeraldUnbreaking.Text = (1 + Form_main.axe.unbreakingLevel).ToString();
            changeVisibility();
        }
        #endregion

        #region enchantment buttons
        private void button_fortune_Click(object sender, EventArgs e)
        {
            selectedEnchant = "fortune";
            Form_main.tools[selectedTool].fortuneLevel++;
            Form_main.emerald.amount -= int.Parse(label_emeraldFortune.Text);
        }

        private void button_unbreaking_Click(object sender, EventArgs e)
        {
            selectedEnchant = "unbreaking";
            Form_main.tools[selectedTool].unbreakingLevel++;
            Form_main.emerald.amount -= int.Parse(label_emeraldUnbreaking.Text);
        }

        private void button_efficiency_Click(object sender, EventArgs e)
        {
            selectedEnchant = "efficiency";
            Form_main.tools[selectedTool].efficiencyLevel++;
            Form_main.emerald.amount -= int.Parse(label_emeraldEfficiency.Text);
        }
        #endregion

        private void button_back_Click(object sender, EventArgs e)
        {
            button_fortune.Visible = false;
            button_unbreaking.Visible = false;
            button_efficiency.Visible = false;

            label_emeraldEfficiency.Visible = false;
            label_emeraldFortune.Visible = false;
            label_emeraldUnbreaking.Visible = false;

            pictureBox_emeraldEfficiency.Visible = false;
            pictureBox_emeraldFortune.Visible = false;
            pictureBox_emeraldUnbreaking.Visible = false;

            button_shovel.Visible = true;
            button_pickaxe.Visible = true;
            button_axe.Visible = true;
            button_hoe.Visible = true;
            button_back.Visible = false;
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

        private void changeVisibility()
        {
            if (Form_main.tools[selectedTool].fortuneLevel == 2)
            {
                button_fortune.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/enchants/fortune3.png");
                button_fortune.Visible = true;
                label_emeraldFortune.Visible = true;
                pictureBox_emeraldFortune.Visible = true;
            }
            else if (Form_main.tools[selectedTool].fortuneLevel == 1)
            {
                button_fortune.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/enchants/fortune2.png");
                button_fortune.Visible = true;
                label_emeraldFortune.Visible = true;
                pictureBox_emeraldFortune.Visible = true;
            }
            else
            {
                button_fortune.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/enchants/fortune1.png");
                button_fortune.Visible = true;
                label_emeraldFortune.Visible = true;
                pictureBox_emeraldFortune.Visible = true;
            }


            if (Form_main.tools[selectedTool].unbreakingLevel == 2)
            {
                button_unbreaking.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/enchants/unbreaking3.png");
                button_unbreaking.Visible = true;
                label_emeraldUnbreaking.Visible = true;
                pictureBox_emeraldUnbreaking.Visible = true;
            }
            else if (Form_main.tools[selectedTool].unbreakingLevel == 1)
            {
                button_unbreaking.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/enchants/unbreaking2.png");
                button_unbreaking.Visible = true;
                label_emeraldUnbreaking.Visible = true;
                pictureBox_emeraldUnbreaking.Visible = true;
            }
            else
            {
                button_unbreaking.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/enchants/unbreaking1.png");
                button_unbreaking.Visible = true;
                label_emeraldUnbreaking.Visible = true;
                pictureBox_emeraldUnbreaking.Visible = true;
            }


            if (Form_main.tools[selectedTool].efficiencyLevel == 4)
            {
                button_efficiency.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/enchants/efficiency5.png");
                button_efficiency.Visible = true;
                label_emeraldEfficiency.Visible = true;
                pictureBox_emeraldEfficiency.Visible = true;
            }
            else if (Form_main.tools[selectedTool].efficiencyLevel == 3)
            {
                button_efficiency.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/enchants/efficiency4.png");
                button_efficiency.Visible = true;
                label_emeraldEfficiency.Visible = true;
                pictureBox_emeraldEfficiency.Visible = true;
            }
            else if (Form_main.tools[selectedTool].efficiencyLevel == 2)
            {
                button_efficiency.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/enchants/efficiency3.png");
                button_efficiency.Visible = true;
                label_emeraldEfficiency.Visible = true;
                pictureBox_emeraldEfficiency.Visible = true;
            }
            else if (Form_main.tools[selectedTool].efficiencyLevel == 1)
            {
                button_efficiency.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/enchants/efficiency2.png");
                button_efficiency.Visible = true;
                label_emeraldEfficiency.Visible = true;
                pictureBox_emeraldEfficiency.Visible = true;
            }
            else
            {
                button_efficiency.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/enchants/efficiency1.png");
                button_efficiency.Visible = true;
                label_emeraldEfficiency.Visible = true;
                pictureBox_emeraldEfficiency.Visible = true;
            }

            button_shovel.Visible = false;
            button_pickaxe.Visible = false;
            button_axe.Visible = false;
            button_hoe.Visible = false;
            button_back.Visible = true;
        }

    }
}
