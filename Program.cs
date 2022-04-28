using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBreaker
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //    #region Initialize Blocks
            //    //Block(BlockID, BreakTime, Tool, DropAmount, BreakLevel)
            //    //BreakLevel - 0=fist 1=wood 2=stone 3=iron 4=diamond
            //    //DropAmount - = amount or -1 if random in a range
            //    Block oakLog = new Block(1, 3, "Axe", 1, 0);
            //    Block stone = new Block(2, 7.5, "Pickaxe", 1, 1);
            //    Block dirt = new Block(3, 0.75, "Shovel", 1, 0);
            //    Block ironOre = new Block(4, 15, "Pickaxe", 1, 2);
            //    Block coalOre = new Block(5, 15, "Pickaxe", 1, 1);

            //    Dictionary<int, Block> blocks = new Dictionary<int, Block>();
            //    blocks[oakLog.blockID] = oakLog;
            //    blocks[stone.blockID] = stone;
            //    blocks[dirt.blockID] = dirt;
            //    blocks[ironOre.blockID] = ironOre;
            //    blocks[coalOre.blockID] = coalOre;
            //    #endregion

            //    #region Initialize Tools
            //    //Tool(Durability, ToolType, ToolLevel)
            //    //ToolLevel - 0=fist 1=wood 2=stone 3=iron 4=diamond
            //    Tool pickaxe = new Tool(0, "Pickaxe", 0);
            //    Tool axe = new Tool(0, "Axe", 0);
            //    Tool shovel = new Tool(0, "Shovel", 0);
            //    Tool hoe = new Tool(0, "Hoe", 0);

            //    Dictionary<string, Tool> tools = new Dictionary<string, Tool>();
            //    tools["pickaxe"] = pickaxe;
            //    tools["axe"] = axe;
            //    tools["shovel"] = shovel;
            //    tools["hoe"] = hoe;
            //    #endregion



            //}

            //void BreakBlock()
            //{
            //    var currentBlock = button_breakBlock.
            //    Tool tool = tools[block.preferredTool]; 
            //    if (block.breakLevel == tool.toolLevel)
            //    {
            //        block.amount += block.dropAmount;
            //        tool.durability -= 1;
            //        //Display new block
            //    }
            //}
        }
    }
}
