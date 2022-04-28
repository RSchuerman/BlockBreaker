
namespace BlockBreaker
{
    partial class Form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_breakBlock = new System.Windows.Forms.Button();
            this.progressBar_breaking = new System.Windows.Forms.ProgressBar();
            this.pictureBox_pickaxe = new System.Windows.Forms.PictureBox();
            this.pictureBox_axe = new System.Windows.Forms.PictureBox();
            this.pictureBox_shovel = new System.Windows.Forms.PictureBox();
            this.pictureBox_hoe = new System.Windows.Forms.PictureBox();
            this.button_inventory = new System.Windows.Forms.Button();
            this.button_crafting = new System.Windows.Forms.Button();
            this.button_smelting = new System.Windows.Forms.Button();
            this.button_trading = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pickaxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_axe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_shovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hoe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_breakBlock
            // 
            this.button_breakBlock.Location = new System.Drawing.Point(106, 33);
            this.button_breakBlock.Margin = new System.Windows.Forms.Padding(0);
            this.button_breakBlock.Name = "button_breakBlock";
            this.button_breakBlock.Size = new System.Drawing.Size(256, 256);
            this.button_breakBlock.TabIndex = 0;
            this.button_breakBlock.UseVisualStyleBackColor = true;
            this.button_breakBlock.Click += new System.EventHandler(this.button_breakBlock_CLICK);
            // 
            // progressBar_breaking
            // 
            this.progressBar_breaking.Location = new System.Drawing.Point(106, 306);
            this.progressBar_breaking.Name = "progressBar_breaking";
            this.progressBar_breaking.Size = new System.Drawing.Size(256, 23);
            this.progressBar_breaking.TabIndex = 2;
            // 
            // pictureBox_pickaxe
            // 
            this.pictureBox_pickaxe.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_pickaxe.Name = "pictureBox_pickaxe";
            this.pictureBox_pickaxe.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_pickaxe.TabIndex = 3;
            this.pictureBox_pickaxe.TabStop = false;
            // 
            // pictureBox_axe
            // 
            this.pictureBox_axe.Location = new System.Drawing.Point(73, 3);
            this.pictureBox_axe.Name = "pictureBox_axe";
            this.pictureBox_axe.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_axe.TabIndex = 4;
            this.pictureBox_axe.TabStop = false;
            // 
            // pictureBox_shovel
            // 
            this.pictureBox_shovel.Location = new System.Drawing.Point(143, 3);
            this.pictureBox_shovel.Name = "pictureBox_shovel";
            this.pictureBox_shovel.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_shovel.TabIndex = 5;
            this.pictureBox_shovel.TabStop = false;
            // 
            // pictureBox_hoe
            // 
            this.pictureBox_hoe.Location = new System.Drawing.Point(213, 3);
            this.pictureBox_hoe.Name = "pictureBox_hoe";
            this.pictureBox_hoe.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_hoe.TabIndex = 6;
            this.pictureBox_hoe.TabStop = false;
            // 
            // button_inventory
            // 
            this.button_inventory.Location = new System.Drawing.Point(26, 353);
            this.button_inventory.Name = "button_inventory";
            this.button_inventory.Size = new System.Drawing.Size(64, 64);
            this.button_inventory.TabIndex = 7;
            this.button_inventory.Text = "INVENTORY";
            this.button_inventory.UseVisualStyleBackColor = true;
            // 
            // button_crafting
            // 
            this.button_crafting.Location = new System.Drawing.Point(0, 3);
            this.button_crafting.Name = "button_crafting";
            this.button_crafting.Size = new System.Drawing.Size(64, 64);
            this.button_crafting.TabIndex = 8;
            this.button_crafting.Text = "CRAFTING";
            this.button_crafting.UseVisualStyleBackColor = true;
            this.button_crafting.Click += new System.EventHandler(this.button_crafting_Click);
            // 
            // button_smelting
            // 
            this.button_smelting.Location = new System.Drawing.Point(0, 73);
            this.button_smelting.Name = "button_smelting";
            this.button_smelting.Size = new System.Drawing.Size(64, 64);
            this.button_smelting.TabIndex = 9;
            this.button_smelting.Text = "SMELTING";
            this.button_smelting.UseVisualStyleBackColor = true;
            // 
            // button_trading
            // 
            this.button_trading.Location = new System.Drawing.Point(0, 143);
            this.button_trading.Name = "button_trading";
            this.button_trading.Size = new System.Drawing.Size(64, 64);
            this.button_trading.TabIndex = 10;
            this.button_trading.Text = "TRADING";
            this.button_trading.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 213);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 64);
            this.button6.TabIndex = 11;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox_pickaxe);
            this.panel1.Controls.Add(this.pictureBox_axe);
            this.panel1.Controls.Add(this.pictureBox_shovel);
            this.panel1.Controls.Add(this.pictureBox_hoe);
            this.panel1.Location = new System.Drawing.Point(96, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 73);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_crafting);
            this.panel2.Controls.Add(this.button_smelting);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button_trading);
            this.panel2.Location = new System.Drawing.Point(33, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 279);
            this.panel2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(369, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 451);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_inventory);
            this.Controls.Add(this.progressBar_breaking);
            this.Controls.Add(this.button_breakBlock);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pickaxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_axe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_shovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hoe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_breakBlock;
        private System.Windows.Forms.ProgressBar progressBar_breaking;
        private System.Windows.Forms.PictureBox pictureBox_pickaxe;
        private System.Windows.Forms.PictureBox pictureBox_axe;
        private System.Windows.Forms.PictureBox pictureBox_shovel;
        private System.Windows.Forms.PictureBox pictureBox_hoe;
        private System.Windows.Forms.Button button_inventory;
        private System.Windows.Forms.Button button_crafting;
        private System.Windows.Forms.Button button_smelting;
        private System.Windows.Forms.Button button_trading;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

