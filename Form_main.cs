using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace BlockBreaker
{
    public partial class Form_main : Form
    {
        int currentBlock;
        List<Block> availableBlocks = new List<Block>();

        #region Initialize Blocks
        //Block(ItemID, BreakTime, Tool, DropAmount, BreakLevel, ImageName)
        //BreakLevel - 0=fist 1=wood 2=stone 3=iron 4=diamond
        //DropAmount - = amount or -1 if random in a range
        public static Block oakLog = new Block(5, 3, "axe", 1, 0, "logs/oakLog.png");
        public static Block birchLog = new Block(6, 3, "axe", 1, 0, "logs/birchLog.png");
        public static Block spruceLog = new Block(7, 3, "axe", 1, 0, "logs/spruceLog.png");
        public static Block acaciaLog = new Block(8, 3, "axe", 1, 0, "logs/acaciaLog.png");
        public static Block jungleLog = new Block(9, 3, "axe", 1, 0, "logs/jungleLog.png");
        public static Block darkOakLog = new Block(10, 3, "axe", 1, 0, "logs/darkOakLog.png");

        public static Block dirt = new Block(11, 0.75, "shovel", 1, 0, "soils/dirt.png");
        public static Block grassBlock = new Block(12, 0.9, "shovel", 1, 0, "soils/grassBlock.png");
        public static Block sand = new Block(13, 0.75, "shovel", 1, 0, "soils/sand.png");
        public static Block gravel = new Block(14, 0.9, "shovel", 1, 0, "soils/gravel.png");

        public static Block stone = new Block(15, 7.5, "pickaxe", 1, 1, "stones/stone.png");
        public static Block andesite = new Block(16, 7.5, "pickaxe", 1, 1, "stones/andesite.png");
        public static Block granite = new Block(17, 7.5, "pickaxe", 1, 1, "stones/granite.png");
        public static Block diorite = new Block(18, 7.5, "pickaxe", 1, 1, "stones/diorite.png");
        public static Block ironOre = new Block(19, 15, "pickaxe", 1, 2, "ores/ironOre.png");
        public static Block coalOre = new Block(20, 15, "pickaxe", 1, 1, "ores/coalOre.png");
        public static Block goldOre = new Block(21, 15, "pickaxe", 1, 3, "ores/goldOre.png");
        public static Block diamondOre = new Block(22, 15, "pickaxe", 1, 3, "ores/diamondOre.png");
        public static Block lapisOre = new Block(23, 15, "pickaxe", -1, 2, "ores/lapisOre.png");
        public static Block redstoneOre = new Block(24, 15, "pickaxe", -1, 3, "ores/redstoneOre.png");
        public static Block emeraldOre = new Block(25, 15, "pickaxe", 1, 3, "ores/emeraldOre.png");

        public static Block oakLeaves = new Block(26, 0.3, "hoe", 0, 0, "leaves/oakLeaves.png");
        public static Block birchLeaves = new Block(27, 0.3, "hoe", 0, 0, "leaves/birchLeaves.png");
        public static Block spruceLeaves = new Block(28, 0.3, "hoe", 0, 0, "leaves/spruceLeaves.png");
        public static Block jungleLeaves = new Block(29, 0.3, "hoe", 0, 0, "leaves/jungleLeaves.png");
        public static Block acaciaLeaves = new Block(30, 0.3, "hoe", 0, 0, "leaves/acaciaLeaves.png");
        public static Block darkOakLeaves = new Block(31, 0.3, "hoe", 0, 0, "leaves/darkOakLeaves.png");
        public static Block haybale = new Block(32, 0.75, "hoe", 1, 0, "haybale.png");

        Dictionary<int, Block> blocks = new Dictionary<int, Block>()
        {
            {oakLog.itemID, oakLog},
            {birchLog.itemID, birchLog},
            {spruceLog.itemID, spruceLog},
            {acaciaLog.itemID, acaciaLog},
            {jungleLog.itemID, jungleLog},
            {darkOakLog.itemID, darkOakLog},
            {stone.itemID, stone},
            {dirt.itemID, dirt},
            {ironOre.itemID, ironOre},
            {coalOre.itemID, coalOre},
            {goldOre.itemID, goldOre},
            {diamondOre.itemID, diamondOre},
            {lapisOre.itemID, lapisOre},
            {redstoneOre.itemID, redstoneOre},
            {emeraldOre.itemID, emeraldOre}
        };
        #endregion

        #region Initialize Tools
        //Tool(Durability, ToolType, ToolLevel)
        //ToolLevel - 0=fist 1=wood 2=stone 3=iron 4=diamond
        public static Tool pickaxe = new Tool(0, "pickaxe", 1);
        public static Tool axe = new Tool(0, "axe", 2);
        public static Tool shovel = new Tool(0, "shovel", 3);
        public static Tool hoe = new Tool(0, "hoe", 4);

        public static Dictionary<string, Tool> tools = new Dictionary<string, Tool>()
        {
            {"pickaxe", pickaxe},
            {"axe", axe},
            {"shovel", shovel},
            {"hoe", hoe}
        };
        #endregion

        #region Initialize Items
        public static Item oakPlanks = new Item(33, "planks/oakPlanks.png");
        public static Item birchPlanks = new Item(34, "planks/birchPlanks.png");
        public static Item sprucePlanks = new Item(35, "planks/sprucePlanks.png");
        public static Item junglePlanks = new Item(36, "planks/junglePlanks.png");
        public static Item acaciaPlanks = new Item(37, "planks/acaciaPlanks.png");
        public static Item darkOakPlanks = new Item(38, "planks/darkOakPlanks.png");
        public static Item stick = new Item(39, "stick.png");
        public static Item wheat = new Item(40, "wheat.png");
        public static Item bread = new Item(41, "bread.png");
        public static Item cobblestone = new Item(42, "cobblestone.png");
        public static Item coal = new Item(43, "coal.png");
        public static Item ironIngot = new Item(44, "ironIngot.png");
        public static Item goldIngot = new Item(45, "goldIngot.png");
        public static Item diamond = new Item(46, "diamond.png");
        public static Item lapis = new Item(47, "lapis.png");
        public static Item redstone = new Item(48, "redstone.png");
        public static Item emerald = new Item(49, "emerald.png");
        #endregion

        public Form_main()
        {
            InitializeComponent();
            updateBlocks();
            displayBlock();
            displayTools();
            panel_plus1.Visible = false;
            //progressBar_breaking.Visible = true;
        }

        private void button_breakBlock_CLICK(object sender, EventArgs e)
        {
            breakBlock();
        }
        void displayBlock()
        {
            progressBar_breaking2.Visible = false;
            Random rnd = new Random();
            currentBlock = rnd.Next(availableBlocks.Count());
            button_breakBlock.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/blocks/" + availableBlocks[currentBlock].imageName);
            
        }
        void breakBlock()
        {
            progressBar_breaking2.Visible = true;
            progressBar_breaking2.Maximum = (int)availableBlocks[currentBlock].breakTime;
            progressBar_breaking2.Minimum = 1;
            progressBar_breaking.Minimum = 0;
            progressBar_breaking.Maximum = 100;
            progressBar_breaking.Value = 0;
            progressBar_breaking2.Value = 1;
            while (progressBar_breaking2.Value != progressBar_breaking2.Maximum)
            {
                Thread.Sleep(1);
                progressBar_breaking2.Value++;
                progressBar_breaking.Value = (int)((progressBar_breaking2.Value / progressBar_breaking2.Maximum) * 100);
            }
            
            if (availableBlocks[currentBlock].breakLevel <= tools[availableBlocks[currentBlock].preferredTool].toolLevel)
            {
                if (availableBlocks[currentBlock] == stone)
                    cobblestone.amount += stone.dropAmount;
                else if (availableBlocks[currentBlock] == coalOre)
                    coal.amount += coalOre.dropAmount;
                else if (availableBlocks[currentBlock] == diamondOre)
                    diamond.amount += diamondOre.dropAmount;
                else if (availableBlocks[currentBlock] == lapisOre)
                    lapis.amount += lapisOre.dropAmount;
                else if (availableBlocks[currentBlock] == redstoneOre)
                    redstone.amount += redstoneOre.dropAmount;
                else if (availableBlocks[currentBlock] == grassBlock)
                    dirt.amount += dirt.dropAmount;
                else if (availableBlocks[currentBlock] == emeraldOre)
                    emerald.amount += emeraldOre.dropAmount;
                else
                    availableBlocks[currentBlock].amount += availableBlocks[currentBlock].dropAmount;
                if(tools[availableBlocks[currentBlock].preferredTool].toolLevel > 0)
                    tools[availableBlocks[currentBlock].preferredTool].durability--;
            }
            if (availableBlocks[currentBlock].dropAmount > 0)
            {
                pictureBox_plus1.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/plus1Images/" + availableBlocks[currentBlock].imageName);
                label_plus1.Text = "+" + availableBlocks[currentBlock].dropAmount;
                panel_plus1.Visible = true;
            }
            else
                panel_plus1.Visible = false;
            displayTools();
            updateBlocks();
            displayBlock();
            
        }
        void displayTools()
        {
            if (pickaxe.durability == 0)
                pickaxe.toolLevel = 0;
            if (axe.durability == 0)
                axe.toolLevel = 0;
            if (shovel.durability == 0)
                shovel.toolLevel = 0;
            if (hoe.durability == 0)
                hoe.toolLevel = 0;
            pictureBox_pickaxe.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/pickaxes/" + pickaxe.imageName);
            pictureBox_axe.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/axes/" + axe.imageName);
            pictureBox_shovel.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/shovels/" + shovel.imageName);
            pictureBox_hoe.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/hoes/" + hoe.imageName);
            label_pickaxe.Text = pickaxe.durability.ToString();
            label_axe.Text = axe.durability.ToString();
            label_shovel.Text = shovel.durability.ToString();
            label_hoe.Text = hoe.durability.ToString();
        }
        void updateBlocks()
        {
            availableBlocks.Clear();
            #region Pickaxe Break Times
            if (pickaxe.toolLevel == 4)
            {
                stone.breakTime = 0.3;
                andesite.breakTime = 0.3;
                granite.breakTime = 0.3;
                diorite.breakTime = 0.3;
                ironOre.breakTime = 0.6;
                goldOre.breakTime = 0.6;
                coalOre.breakTime = 0.6;
                lapisOre.breakTime = 0.6;
                redstoneOre.breakTime = 0.6;
                diamondOre.breakTime = 0.6;
                emeraldOre.breakTime = 0.6;
                availableBlocks.Add(stone);
                availableBlocks.Add(andesite);
                availableBlocks.Add(granite);
                availableBlocks.Add(diorite);
                availableBlocks.Add(coalOre);
                availableBlocks.Add(ironOre);
                availableBlocks.Add(goldOre);
                availableBlocks.Add(lapisOre);
                availableBlocks.Add(redstoneOre);
                availableBlocks.Add(diamondOre);
                availableBlocks.Add(emeraldOre);
            }
            else if (pickaxe.toolLevel == 3)
            {
                stone.breakTime = 0.4;
                andesite.breakTime = 0.4;
                granite.breakTime = 0.4;
                diorite.breakTime = 0.4;
                ironOre.breakTime = 0.75;
                goldOre.breakTime = 0.75;
                coalOre.breakTime = 0.75;
                lapisOre.breakTime = 0.75;
                redstoneOre.breakTime = 0.75;
                diamondOre.breakTime = 0.75;
                emeraldOre.breakTime = 0.75;
                availableBlocks.Add(stone);
                availableBlocks.Add(andesite);
                availableBlocks.Add(granite);
                availableBlocks.Add(diorite);
                availableBlocks.Add(coalOre);
                availableBlocks.Add(ironOre);
                availableBlocks.Add(goldOre);
                availableBlocks.Add(lapisOre);
                availableBlocks.Add(redstoneOre);
                availableBlocks.Add(diamondOre);
                availableBlocks.Add(emeraldOre);
            }
            else if (pickaxe.toolLevel == 2)
            {
                stone.breakTime = 0.6;
                andesite.breakTime = 0.6;
                granite.breakTime = 0.6;
                diorite.breakTime = 0.6;
                ironOre.breakTime = 1.15;
                goldOre.breakTime = 3.75;
                coalOre.breakTime = 1.15;
                lapisOre.breakTime = 1.15;
                redstoneOre.breakTime = 3.75;
                diamondOre.breakTime = 3.75;
                emeraldOre.breakTime = 3.75;
                availableBlocks.Add(stone);
                availableBlocks.Add(andesite);
                availableBlocks.Add(granite);
                availableBlocks.Add(diorite);
                availableBlocks.Add(coalOre);
                availableBlocks.Add(ironOre);
                availableBlocks.Add(lapisOre);
            }
            else if (pickaxe.toolLevel == 1)
            {
                stone.breakTime = 1.15;
                andesite.breakTime = 1.15;
                granite.breakTime = 1.15;
                diorite.breakTime = 1.15;
                ironOre.breakTime = 7.5;
                goldOre.breakTime = 7.5;
                coalOre.breakTime = 2.25;
                lapisOre.breakTime = 7.5;
                redstoneOre.breakTime = 7.5;
                diamondOre.breakTime = 7.5;
                emeraldOre.breakTime = 7.5;
                availableBlocks.Add(stone);
                availableBlocks.Add(andesite);
                availableBlocks.Add(granite);
                availableBlocks.Add(diorite);
                availableBlocks.Add(coalOre);
            }
            else
            {
                stone.breakTime = 7.5;
                andesite.breakTime = 7.5;
                granite.breakTime = 7.5;
                diorite.breakTime = 7.5;
                ironOre.breakTime = 15;
                goldOre.breakTime = 15;
                coalOre.breakTime = 15;
                lapisOre.breakTime = 15;
                redstoneOre.breakTime = 15;
                diamondOre.breakTime = 15;
                emeraldOre.breakTime = 15;
            }
            #endregion

            #region Axe Break Times
            if (axe.toolLevel == 4)
            {
                oakLog.breakTime = 0.4;
                birchLog.breakTime = 0.4;
                spruceLog.breakTime = 0.4;
                acaciaLog.breakTime = 0.4;
                jungleLog.breakTime = 0.4;
                darkOakLog.breakTime = 0.4;
                
            }
            else if (axe.toolLevel == 3)
            {
                oakLog.breakTime = 0.5;
                birchLog.breakTime = 0.5;
                spruceLog.breakTime = 0.5;
                acaciaLog.breakTime = 0.5;
                jungleLog.breakTime = 0.5;
                darkOakLog.breakTime = 0.5;
            }
            else if (axe.toolLevel == 2)
            {
                oakLog.breakTime = 0.75;
                birchLog.breakTime = 0.75;
                spruceLog.breakTime = 0.75;
                acaciaLog.breakTime = 0.75;
                jungleLog.breakTime = 0.75;
                darkOakLog.breakTime = 0.75;
            }
            else if (axe.toolLevel == 1)
            {
                oakLog.breakTime = 1.5;
                birchLog.breakTime = 1.5;
                spruceLog.breakTime = 1.5;
                acaciaLog.breakTime = 1.5;
                jungleLog.breakTime = 1.5;
                darkOakLog.breakTime = 1.5;
            }
            else
            {
                oakLog.breakTime = 3;
                birchLog.breakTime = 3;
                spruceLog.breakTime = 3;
                acaciaLog.breakTime = 3;
                jungleLog.breakTime = 3;
                darkOakLog.breakTime = 3;
            }
            availableBlocks.Add(oakLog);
            availableBlocks.Add(birchLog);
            availableBlocks.Add(spruceLog);
            availableBlocks.Add(acaciaLog);
            availableBlocks.Add(jungleLog);
            availableBlocks.Add(darkOakLog);
            #endregion

            #region Shovel Break Times
            if (shovel.toolLevel == 4)
            {
                dirt.breakTime = 0.1;
                grassBlock.breakTime = 0.15;
                sand.breakTime = 0.1;
                gravel.breakTime = 0.15;
            }
            else if (shovel.toolLevel == 3)
            {
                dirt.breakTime = 0.15;
                grassBlock.breakTime = 0.15;
                sand.breakTime = 0.15;
                gravel.breakTime = 0.15;
            }
            else if (shovel.toolLevel == 2)
            {
                dirt.breakTime = 0.2;
                grassBlock.breakTime = 0.25;
                sand.breakTime = 0.2;
                gravel.breakTime = 0.25;
            }
            else if (shovel.toolLevel == 1)
            {
                dirt.breakTime = 0.4;
                grassBlock.breakTime = 0.45;
                sand.breakTime = 0.4;
                gravel.breakTime = 0.45;
            }
            else
            {
                dirt.breakTime = 0.75;
                grassBlock.breakTime = 0.9;
                sand.breakTime = 0.75;
                gravel.breakTime = 0.9;
            }
            availableBlocks.Add(dirt);
            availableBlocks.Add(grassBlock);
            availableBlocks.Add(sand);
            availableBlocks.Add(gravel);
            #endregion

            #region Hoe Break Times
            if (hoe.toolLevel == 4)
            {
                haybale.breakTime = 0.1;
                oakLeaves.breakTime = 0.05;
                birchLeaves.breakTime = 0.05;
                spruceLeaves.breakTime = 0.05;
                jungleLeaves.breakTime = 0.05;
                acaciaLeaves.breakTime = 0.05;
                darkOakLeaves.breakTime = 0.05;
            }
            else if (hoe.toolLevel == 3)
            {
                haybale.breakTime = 0.15;
                oakLeaves.breakTime = 0.05;
                birchLeaves.breakTime = 0.05;
                spruceLeaves.breakTime = 0.05;
                jungleLeaves.breakTime = 0.05;
                acaciaLeaves.breakTime = 0.05;
                darkOakLeaves.breakTime = 0.05;
            }
            else if (hoe.toolLevel == 2)
            {
                haybale.breakTime = 0.2;
                oakLeaves.breakTime = 0.1;
                birchLeaves.breakTime = 0.1;
                spruceLeaves.breakTime = 0.1;
                jungleLeaves.breakTime = 0.1;
                acaciaLeaves.breakTime = 0.1;
                darkOakLeaves.breakTime = 0.1;
            }
            else if (hoe.toolLevel == 1)
            {
                haybale.breakTime = 0.4;
                oakLeaves.breakTime = 0.15;
                birchLeaves.breakTime = 0.15;
                spruceLeaves.breakTime = 0.15;
                jungleLeaves.breakTime = 0.15;
                acaciaLeaves.breakTime = 0.15;
                darkOakLeaves.breakTime = 0.15;
            }
            else
            {
                haybale.breakTime = 0.75;
                oakLeaves.breakTime = 0.3;
                birchLeaves.breakTime = 0.3;
                spruceLeaves.breakTime = 0.3;
                jungleLeaves.breakTime = 0.3;
                acaciaLeaves.breakTime = 0.3;
                darkOakLeaves.breakTime = 0.3;
            }
            availableBlocks.Add(haybale);
            availableBlocks.Add(oakLeaves);
            availableBlocks.Add(birchLeaves);
            availableBlocks.Add(spruceLeaves);
            availableBlocks.Add(jungleLeaves);
            availableBlocks.Add(acaciaLeaves);
            availableBlocks.Add(darkOakLeaves);
            #endregion
            label_emerald.Text = emerald.amount.ToString();
        }

        private void button_crafting_Click(object sender, EventArgs e)
        {
            Form_crafting craftingForm = new Form_crafting();
            craftingForm.Show();
            this.Hide();
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button_smelting_Click(object sender, EventArgs e)
        {
            Form_smelting smeltingForm = new Form_smelting();
            smeltingForm.Show();
            this.Hide();
        }

        private void button_inventory_Click(object sender, EventArgs e)
        {
            Form_inventory inventoryForm = new Form_inventory();
            inventoryForm.Show();
            this.Hide();
        }

        private void button_trading_Click(object sender, EventArgs e)
        {
            Form_trading tradingForm = new Form_trading();
            tradingForm.Show();
            this.Hide();
        }

        private void pictureBox_emerald_Click(object sender, EventArgs e)
        {
            emerald.amount++;
        }
    }
}
