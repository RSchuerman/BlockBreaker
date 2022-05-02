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
        static Block oakLog = new Block(5, 3, "axe", 1, 0, "logs/oakLog.png");
        static Block birchLog = new Block(6, 3, "axe", 1, 0, "logs/birchLog.png");
        static Block spruceLog = new Block(7, 3, "axe", 1, 0, "logs/spruceLog.png");
        static Block acaciaLog = new Block(8, 3, "axe", 1, 0, "logs/acaciaLog.png");
        static Block jungleLog = new Block(9, 3, "axe", 1, 0, "logs/jungleLog.png");
        static Block darkOakLog = new Block(10, 3, "axe", 1, 0, "logs/darkOakLog.png");

        static Block dirt = new Block(11, 0.75, "shovel", 1, 0, "dirt.png");

        static Block stone = new Block(12, 7.5, "pickaxe", 1, 1, "stone.png");
        static Block ironOre = new Block(13, 15, "pickaxe", 1, 2, "ores/ironOre.png");
        static Block coalOre = new Block(14, 15, "pickaxe", 1, 1, "ores/coalOre.png");
        static Block goldOre = new Block(15, 15, "pickaxe", 1, 3, "ores/goldOre.png");
        static Block diamondOre = new Block(16, 15, "pickaxe", 1, 3, "ores/diamondOre.png");
        static Block lapisOre = new Block(17, 15, "pickaxe", -1, 2, "ores/lapisOre.png");
        static Block redstoneOre = new Block(18, 15, "pickaxe", -1, 3, "ores/redstoneOre.png");
        static Block emeraldOre = new Block(19, 15, "pickaxe", 1, 3, "ores/emeraldOre.png");

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
        static Tool pickaxe = new Tool(0, "pickaxe", 1);
        static Tool axe = new Tool(0, "axe", 2);
        static Tool shovel = new Tool(0, "shovel", 3);
        static Tool hoe = new Tool(0, "hoe", 4);

        Dictionary<string, Tool> tools = new Dictionary<string, Tool>()
        {
            {"pickaxe", pickaxe},
            {"axe", axe},
            {"shovel", shovel},
            {"hoe", hoe}
        };
        #endregion

        #region Initialize Items
        public static Item oakPlanks = new Item(20, "planks/oakPlanks.png");
        static Item birchPlanks = new Item(21, "planks/birchPlanks.png");
        static Item sprucePlanks = new Item(22, "planks/sprucePlanks.png");
        static Item junglePlanks = new Item(23, "planks/junglePlanks.png");
        static Item acaciaPlanks = new Item(24, "planks/acaciaPlanks.png");
        static Item darkOakPlanks = new Item(25, "planks/darkOakPlanks.png");
        static Item stick = new Item(26, "stick.png");
        static Item wheat = new Item(27, "wheat.png");
        static Item bread = new Item(28, "bread.png");
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
            textBox1.Text = (availableBlocks[currentBlock].amount).ToString();
        }
        void breakBlock()
        {
            //System.Timers.Timer timer = new System.Timers.Timer(availableBlocks[currentBlock].breakTime*1000);
            //timer.Start();
            
            textBox1.Text = (availableBlocks[currentBlock].amount).ToString();
            if (availableBlocks[currentBlock].breakLevel == tools[availableBlocks[currentBlock].preferredTool].toolLevel)
            {
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
            }
            else if (pickaxe.toolLevel == 3)
            {
                stone.breakTime = 0.4;
                ironOre.breakTime = 0.75;
                coalOre.breakTime = 0.75;
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
                availableBlocks.Add(stone);
                availableBlocks.Add(coalOre);
            }
            else
            {
                stone.breakTime = 7.5;
                ironOre.breakTime = 15;
                coalOre.breakTime = 15;
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
                oakLog.breakTime = 0.4;
                availableBlocks.Add(dirt);
            }
            else if (shovel.toolLevel == 3)
            {
                oakLog.breakTime = 0.5;
                availableBlocks.Add(dirt);
            }
            else if (shovel.toolLevel == 2)
            {
                oakLog.breakTime = 0.75;
                availableBlocks.Add(dirt);
            }
            else if (shovel.toolLevel == 1)
            {
                oakLog.breakTime = 1.5;
                availableBlocks.Add(dirt);
            }
            else
            {
                oakLog.breakTime = 3;
                availableBlocks.Add(dirt);
            }
            #endregion

            #region Hoe Break Times
            if (hoe.toolLevel == 4)
            {
                oakLog.breakTime = 0.4;
            }
            else if (hoe.toolLevel == 3)
            {
                oakLog.breakTime = 0.5;
            }
            else if (hoe.toolLevel == 2)
            {
                oakLog.breakTime = 0.75;
            }
            else if (hoe.toolLevel == 1)
            {
                oakLog.breakTime = 1.5;
            }
            else
            {
                oakLog.breakTime = 3;
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
    }
}
