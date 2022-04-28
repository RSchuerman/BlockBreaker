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
    public partial class Form1 : Form
    {
        int currentBlock;

        #region Initialize Blocks
        //Block(BlockID, BreakTime, Tool, DropAmount, BreakLevel, imageName)
        //BreakLevel - 0=fist 1=wood 2=stone 3=iron 4=diamond
        //DropAmount - = amount or -1 if random in a range
        static Block oakLog = new Block(1, 3, "axe", 1, 0, "logs/oakLog.png");
        static Block stone = new Block(2, 7.5, "pickaxe", 1, 1, "stone.png");
        static Block dirt = new Block(3, 0.75, "shovel", 1, 0, "dirt.png");
        static Block ironOre = new Block(4, 15, "pickaxe", 1, 2, "ores/ironOre.png");
        static Block coalOre = new Block(5, 15, "pickaxe", 1, 1, "ores/coalOre.png");

        Dictionary<int, Block> blocks = new Dictionary<int, Block>()
        {
            {oakLog.blockID, oakLog},
            {stone.blockID, stone},
            {dirt.blockID, dirt},
            {ironOre.blockID, ironOre},
            {coalOre.blockID, coalOre}
        };
        #endregion

        #region Initialize Tools
        //Tool(Durability, ToolType, ToolLevel)
        //ToolLevel - 0=fist 1=wood 2=stone 3=iron 4=diamond
        static Tool pickaxe = new Tool(0, "pickaxe", 0);
        static Tool axe = new Tool(0, "axe", 0);
        static Tool shovel = new Tool(0, "shovel", 0);
        static Tool hoe = new Tool(0, "hoe", 0);

        Dictionary<string, Tool> tools = new Dictionary<string, Tool>()
        {
            {"pickaxe", pickaxe},
            {"axe", axe},
            {"shovel", shovel},
            {"hoe", hoe}
        };
        #endregion

        public Form1()
        {
            InitializeComponent();
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
            currentBlock = rnd.Next(1,6);
            Image currentBlockImage = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/blocks/" + blocks[currentBlock].imageName);
            button_breakBlock.Image = currentBlockImage;
            textBox1.Text = (blocks[currentBlock].amount).ToString();
        }
        void breakBlock()
        {
            textBox1.Text = (blocks[currentBlock].amount).ToString();
            if (blocks[currentBlock].breakLevel == tools[blocks[currentBlock].preferredTool].toolLevel)
            {
                blocks[currentBlock].amount += blocks[currentBlock].dropAmount;
            }
            textBox1.Text = (blocks[currentBlock].amount).ToString();
            displayBlock();
        }
        void displayTools()
        {
            pictureBox_pickaxe.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/pickaxes/" + pickaxe.imageName);
            pictureBox_axe.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/axes/" + axe.imageName);
            pictureBox_shovel.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/shovels/" + shovel.imageName);
            pictureBox_hoe.Image = Image.FromFile("C:/Users/RSchuerman/source/repos/BlockBreaker/images/tools/hoes/" + hoe.imageName);
        }

    }
}
