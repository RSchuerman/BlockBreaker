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

        public static Block dirt = new Block(11, 0.75, "shovel", 1, 0, "dirt.png");

        public static Block stone = new Block(12, 7.5, "pickaxe", 1, 1, "stone.png");
        public static Block ironOre = new Block(13, 15, "pickaxe", 1, 2, "ores/ironOre.png");
        public static Block coalOre = new Block(14, 15, "pickaxe", 1, 1, "ores/coalOre.png");
        public static Block goldOre = new Block(15, 15, "pickaxe", 1, 3, "ores/goldOre.png");
        public static Block diamondOre = new Block(16, 15, "pickaxe", 1, 3, "ores/diamondOre.png");
        public static Block lapisOre = new Block(17, 15, "pickaxe", -1, 2, "ores/lapisOre.png");
        public static Block redstoneOre = new Block(18, 15, "pickaxe", -1, 3, "ores/redstoneOre.png");
        public static Block emeraldOre = new Block(19, 15, "pickaxe", 1, 3, "ores/emeraldOre.png");

        public static Block oakLeaves = new Block(20, 1, "hoe", 1, 3, "oakLeaves.png");
        public static Block birchLeaves = new Block(21, 1, "hoe", 1, 3, "oakLeaves.png");
        public static Block spruceLeaves = new Block(22, 1, "hoe", 1, 3, "oakLeaves.png");
        public static Block jungleLeaves = new Block(23, 1, "hoe", 1, 3, "oakLeaves.png");
        public static Block acaciaLeaves = new Block(24, 1, "hoe", 1, 3, "oakLeaves.png");
        public static Block darkOakLeaves = new Block(25, 1, "hoe", 1, 3, "oakLeaves.png");
        public static Block haybale = new Block(26, 1, "hoe", 1, 3, "oakLeaves.png");

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

        Dictionary<string, Tool> tools = new Dictionary<string, Tool>()
        {
            {"pickaxe", pickaxe},
            {"axe", axe},
            {"shovel", shovel},
            {"hoe", hoe}
        };
        #endregion

        #region Initialize Items
        public static Item oakPlanks = new Item(27, "planks/oakPlanks.png");
        public static Item birchPlanks = new Item(28, "planks/birchPlanks.png");
        public static Item sprucePlanks = new Item(29, "planks/sprucePlanks.png");
        public static Item junglePlanks = new Item(30, "planks/junglePlanks.png");
        public static Item acaciaPlanks = new Item(31, "planks/acaciaPlanks.png");
        public static Item darkOakPlanks = new Item(32, "planks/darkOakPlanks.png");
        public static Item stick = new Item(33, "stick.png");
        public static Item wheat = new Item(34, "wheat.png");
        public static Item bread = new Item(35, "bread.png");
        public static Item cobblestone = new Item(36, "cobblestone.png");
        public static Item coal = new Item(37, "coal.png");
        public static Item ironIngot = new Item(38, "ironIngot.png");
        public static Item goldIngot = new Item(39, "goldIngot.png");
        public static Item diamond = new Item(40, "diamond.png");
        public static Item lapis = new Item(41, "lapis.png");
        public static Item redstone = new Item(42, "redstone.png");
        #endregion

        public Form_main()
        {
            InitializeComponent();
            updateBlocks();
            displayBlock();
            displayTools();
        }

        private void button_breakBlock_CLICK(object sender, EventArgs e)
        {
            breakBlock();
        }
        void displayBlock()
        {
            Random rnd = new Random();
            currentBlock = rnd.Next(availableBlocks.Count());
            button_breakBlock.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/blocks/" + availableBlocks[currentBlock].imageName);
            
        }
        void breakBlock()
        {
            //System.Timers.Timer timer = new System.Timers.Timer(availableBlocks[currentBlock].breakTime*1000);
            //timer.Start();
            
            
            if (availableBlocks[currentBlock].breakLevel == tools[availableBlocks[currentBlock].preferredTool].toolLevel)
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
                else
                    availableBlocks[currentBlock].amount += availableBlocks[currentBlock].dropAmount;
            }
            displayBlock();
        }
        void displayTools()
        {
            pictureBox_pickaxe.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/pickaxes/" + pickaxe.imageName);
            pictureBox_axe.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/axes/" + axe.imageName);
            pictureBox_shovel.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/shovels/" + shovel.imageName);
            pictureBox_hoe.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/hoes/" + hoe.imageName);
        }
        void updateBlocks()
        {
            #region Pickaxe Break Times
            if (pickaxe.toolLevel == 4)
            {
                stone.breakTime = 0.3;
                ironOre.breakTime = 0.6;
                coalOre.breakTime = 0.6;
                lapisOre.breakTime = 0.6;
                redstoneOre.breakTime = 0.6;
                diamondOre.breakTime = 0.6;
                emeraldOre.breakTime = 0.6;
                availableBlocks.Add(stone);
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
                ironOre.breakTime = 0.75;
                coalOre.breakTime = 0.75;
                lapisOre.breakTime = 0.75;
                redstoneOre.breakTime = 0.75;
                diamondOre.breakTime = 0.75;
                emeraldOre.breakTime = 0.75;
                availableBlocks.Add(stone);
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
                ironOre.breakTime = 1.15;
                coalOre.breakTime = 1.15;
                lapisOre.breakTime = 1.15;
                redstoneOre.breakTime = 3.75;
                diamondOre.breakTime = 3.75;
                emeraldOre.breakTime = 3.75;
                availableBlocks.Add(stone);
                availableBlocks.Add(coalOre);
                availableBlocks.Add(ironOre);
                availableBlocks.Add(lapisOre);
            }
            else if (pickaxe.toolLevel == 1)
            {
                stone.breakTime = 1.15;
                ironOre.breakTime = 7.5;
                coalOre.breakTime = 2.25;
                lapisOre.breakTime = 7.5;
                redstoneOre.breakTime = 7.5;
                diamondOre.breakTime = 7.5;
                emeraldOre.breakTime = 7.5;
                availableBlocks.Add(stone);
                availableBlocks.Add(coalOre);
            }
            else
            {
                stone.breakTime = 7.5;
                ironOre.breakTime = 15;
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
                birchLog.breakTime = 0.4;
                spruceLog.breakTime = 0.4;
                acaciaLog.breakTime = 0.4;
                jungleLog.breakTime = 0.4;
                darkOakLog.breakTime = 0.4;
            }
            else if (axe.toolLevel == 2)
            {
                oakLog.breakTime = 0.75;
                birchLog.breakTime = 0.4;
                spruceLog.breakTime = 0.4;
                acaciaLog.breakTime = 0.4;
                jungleLog.breakTime = 0.4;
                darkOakLog.breakTime = 0.4;
            }
            else if (axe.toolLevel == 1)
            {
                oakLog.breakTime = 1.5;
                birchLog.breakTime = 0.4;
                spruceLog.breakTime = 0.4;
                acaciaLog.breakTime = 0.4;
                jungleLog.breakTime = 0.4;
                darkOakLog.breakTime = 0.4;
            }
            else
            {
                oakLog.breakTime = 3;
                birchLog.breakTime = 0.4;
                spruceLog.breakTime = 0.4;
                acaciaLog.breakTime = 0.4;
                jungleLog.breakTime = 0.4;
                darkOakLog.breakTime = 0.4;
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
            }
            else if (shovel.toolLevel == 3)
            {
                dirt.breakTime = 0.15;
            }
            else if (shovel.toolLevel == 2)
            {
                dirt.breakTime = 0.2;
            }
            else if (shovel.toolLevel == 1)
            {
                dirt.breakTime = 0.4;
            }
            else
            {
                dirt.breakTime = 0.75;
            }
            availableBlocks.Add(dirt);
            #endregion

            #region Hoe Break Times
            if (hoe.toolLevel == 4)
            {
                haybale.breakTime = 0.1;
            }
            else if (hoe.toolLevel == 3)
            {
                haybale.breakTime = 0.15;
            }
            else if (hoe.toolLevel == 2)
            {
                haybale.breakTime = 0.2;
            }
            else if (hoe.toolLevel == 1)
            {
                haybale.breakTime = 0.4;
            }
            else
            {
                haybale.breakTime = 0.75;
            }
            #endregion
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
    }
}
