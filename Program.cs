using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockBreaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            #region Initialize Blocks
            //Blocks(BlockID, BreakTime, Tool, DropAmount, BreakLevel)
            //BreakLevel - 0=fist 1=wood 2=stone 3=iron 4=diamond
            //DropAmount - = amount or -1 if random in a range
            Blocks oakLog = new Blocks(1, 3, "Axe", 1, 0);
            Blocks stone = new Blocks(2, 7.5, "Pickaxe", 1, 1);
            Blocks dirt = new Blocks(3, 0.75, "Shovel", 1, 0);
            Blocks ironOre = new Blocks(4, 15, "Pickaxe", 1, 2);
            Blocks coalOre = new Blocks(5, 15, "Pickaxe", 1, 1);

            List<Blocks> blocks = new List<Blocks>();
            blocks.Add(oakLog);
            blocks.Add(stone);
            blocks.Add(dirt);
            blocks.Add(ironOre);
            blocks.Add(coalOre);
            #endregion
        }
    }
}
