
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.button_breakBlock = new System.Windows.Forms.Button();
            this.progressBar_breaking = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_hoe = new System.Windows.Forms.Label();
            this.label_shovel = new System.Windows.Forms.Label();
            this.label_axe = new System.Windows.Forms.Label();
            this.label_pickaxe = new System.Windows.Forms.Label();
            this.pictureBox_pickaxe = new System.Windows.Forms.PictureBox();
            this.pictureBox_axe = new System.Windows.Forms.PictureBox();
            this.pictureBox_shovel = new System.Windows.Forms.PictureBox();
            this.pictureBox_hoe = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_crafting = new System.Windows.Forms.Button();
            this.button_smelting = new System.Windows.Forms.Button();
            this.button_trading = new System.Windows.Forms.Button();
            this.button_end = new System.Windows.Forms.Button();
            this.label_plus1 = new System.Windows.Forms.Label();
            this.panel_plus1 = new System.Windows.Forms.Panel();
            this.pictureBox_plus1 = new System.Windows.Forms.PictureBox();
            this.progressBar_breaking2 = new System.Windows.Forms.ProgressBar();
            this.label_emerald = new System.Windows.Forms.Label();
            this.pictureBox_emerald = new System.Windows.Forms.PictureBox();
            this.button_inventory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pickaxe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_axe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_shovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hoe)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_plus1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_plus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emerald)).BeginInit();
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
            this.progressBar_breaking.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_hoe);
            this.panel1.Controls.Add(this.label_shovel);
            this.panel1.Controls.Add(this.label_axe);
            this.panel1.Controls.Add(this.label_pickaxe);
            this.panel1.Controls.Add(this.pictureBox_pickaxe);
            this.panel1.Controls.Add(this.pictureBox_axe);
            this.panel1.Controls.Add(this.pictureBox_shovel);
            this.panel1.Controls.Add(this.pictureBox_hoe);
            this.panel1.Location = new System.Drawing.Point(96, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 73);
            this.panel1.TabIndex = 12;
            // 
            // label_hoe
            // 
            this.label_hoe.AutoSize = true;
            this.label_hoe.Location = new System.Drawing.Point(264, 54);
            this.label_hoe.Name = "label_hoe";
            this.label_hoe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_hoe.Size = new System.Drawing.Size(13, 13);
            this.label_hoe.TabIndex = 10;
            this.label_hoe.Text = "0";
            // 
            // label_shovel
            // 
            this.label_shovel.AutoSize = true;
            this.label_shovel.Location = new System.Drawing.Point(195, 54);
            this.label_shovel.Name = "label_shovel";
            this.label_shovel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_shovel.Size = new System.Drawing.Size(13, 13);
            this.label_shovel.TabIndex = 9;
            this.label_shovel.Text = "0";
            // 
            // label_axe
            // 
            this.label_axe.AutoSize = true;
            this.label_axe.Location = new System.Drawing.Point(124, 53);
            this.label_axe.Name = "label_axe";
            this.label_axe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_axe.Size = new System.Drawing.Size(13, 13);
            this.label_axe.TabIndex = 8;
            this.label_axe.Text = "0";
            // 
            // label_pickaxe
            // 
            this.label_pickaxe.AutoSize = true;
            this.label_pickaxe.Location = new System.Drawing.Point(54, 54);
            this.label_pickaxe.Name = "label_pickaxe";
            this.label_pickaxe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_pickaxe.Size = new System.Drawing.Size(13, 13);
            this.label_pickaxe.TabIndex = 7;
            this.label_pickaxe.Text = "0";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.button_crafting);
            this.panel2.Controls.Add(this.button_smelting);
            this.panel2.Controls.Add(this.button_trading);
            this.panel2.Location = new System.Drawing.Point(33, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 279);
            this.panel2.TabIndex = 13;
            // 
            // button_crafting
            // 
            this.button_crafting.Image = ((System.Drawing.Image)(resources.GetObject("button_crafting.Image")));
            this.button_crafting.Location = new System.Drawing.Point(0, 3);
            this.button_crafting.Name = "button_crafting";
            this.button_crafting.Size = new System.Drawing.Size(64, 64);
            this.button_crafting.TabIndex = 8;
            this.button_crafting.UseVisualStyleBackColor = true;
            this.button_crafting.Click += new System.EventHandler(this.button_crafting_Click);
            // 
            // button_smelting
            // 
            this.button_smelting.Image = ((System.Drawing.Image)(resources.GetObject("button_smelting.Image")));
            this.button_smelting.Location = new System.Drawing.Point(0, 73);
            this.button_smelting.Name = "button_smelting";
            this.button_smelting.Size = new System.Drawing.Size(64, 64);
            this.button_smelting.TabIndex = 9;
            this.button_smelting.UseVisualStyleBackColor = true;
            this.button_smelting.Click += new System.EventHandler(this.button_smelting_Click);
            // 
            // button_trading
            // 
            this.button_trading.Image = ((System.Drawing.Image)(resources.GetObject("button_trading.Image")));
            this.button_trading.Location = new System.Drawing.Point(0, 143);
            this.button_trading.Name = "button_trading";
            this.button_trading.Size = new System.Drawing.Size(64, 128);
            this.button_trading.TabIndex = 10;
            this.button_trading.UseVisualStyleBackColor = true;
            this.button_trading.Click += new System.EventHandler(this.button_trading_Click);
            // 
            // button_end
            // 
            this.button_end.Location = new System.Drawing.Point(379, 12);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(41, 43);
            this.button_end.TabIndex = 15;
            this.button_end.Text = "END";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
            // 
            // label_plus1
            // 
            this.label_plus1.AutoSize = true;
            this.label_plus1.Location = new System.Drawing.Point(45, 66);
            this.label_plus1.Name = "label_plus1";
            this.label_plus1.Size = new System.Drawing.Size(19, 13);
            this.label_plus1.TabIndex = 16;
            this.label_plus1.Text = "+1";
            // 
            // panel_plus1
            // 
            this.panel_plus1.Controls.Add(this.pictureBox_plus1);
            this.panel_plus1.Controls.Add(this.label_plus1);
            this.panel_plus1.Location = new System.Drawing.Point(365, 209);
            this.panel_plus1.Name = "panel_plus1";
            this.panel_plus1.Size = new System.Drawing.Size(67, 80);
            this.panel_plus1.TabIndex = 18;
            // 
            // pictureBox_plus1
            // 
            this.pictureBox_plus1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox_plus1.Name = "pictureBox_plus1";
            this.pictureBox_plus1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_plus1.TabIndex = 17;
            this.pictureBox_plus1.TabStop = false;
            // 
            // progressBar_breaking2
            // 
            this.progressBar_breaking2.Location = new System.Drawing.Point(106, 306);
            this.progressBar_breaking2.Name = "progressBar_breaking2";
            this.progressBar_breaking2.Size = new System.Drawing.Size(256, 23);
            this.progressBar_breaking2.TabIndex = 19;
            this.progressBar_breaking2.Visible = false;
            // 
            // label_emerald
            // 
            this.label_emerald.AutoSize = true;
            this.label_emerald.Location = new System.Drawing.Point(416, 113);
            this.label_emerald.Name = "label_emerald";
            this.label_emerald.Size = new System.Drawing.Size(13, 13);
            this.label_emerald.TabIndex = 21;
            this.label_emerald.Text = "0";
            // 
            // pictureBox_emerald
            // 
            this.pictureBox_emerald.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_emerald.Image")));
            this.pictureBox_emerald.Location = new System.Drawing.Point(365, 62);
            this.pictureBox_emerald.Name = "pictureBox_emerald";
            this.pictureBox_emerald.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_emerald.TabIndex = 20;
            this.pictureBox_emerald.TabStop = false;
            this.pictureBox_emerald.Click += new System.EventHandler(this.pictureBox_emerald_Click);
            // 
            // button_inventory
            // 
            this.button_inventory.Image = ((System.Drawing.Image)(resources.GetObject("button_inventory.Image")));
            this.button_inventory.Location = new System.Drawing.Point(26, 353);
            this.button_inventory.Name = "button_inventory";
            this.button_inventory.Size = new System.Drawing.Size(64, 64);
            this.button_inventory.TabIndex = 7;
            this.button_inventory.UseVisualStyleBackColor = true;
            this.button_inventory.Click += new System.EventHandler(this.button_inventory_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 451);
            this.Controls.Add(this.label_emerald);
            this.Controls.Add(this.pictureBox_emerald);
            this.Controls.Add(this.progressBar_breaking2);
            this.Controls.Add(this.panel_plus1);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_inventory);
            this.Controls.Add(this.progressBar_breaking);
            this.Controls.Add(this.button_breakBlock);
            this.Name = "Form_main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pickaxe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_axe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_shovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hoe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_plus1.ResumeLayout(false);
            this.panel_plus1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_plus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_emerald)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Label label_hoe;
        private System.Windows.Forms.Label label_shovel;
        private System.Windows.Forms.Label label_axe;
        private System.Windows.Forms.Label label_pickaxe;
        private System.Windows.Forms.Label label_plus1;
        private System.Windows.Forms.PictureBox pictureBox_plus1;
        private System.Windows.Forms.Panel panel_plus1;
        private System.Windows.Forms.ProgressBar progressBar_breaking2;
        private System.Windows.Forms.PictureBox pictureBox_emerald;
        private System.Windows.Forms.Label label_emerald;
    }
}

