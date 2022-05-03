
namespace BlockBreaker
{
    partial class Form_smelting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_smelting));
            this.button_end = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_ironIngot = new System.Windows.Forms.Button();
            this.label_ironIngot = new System.Windows.Forms.Label();
            this.label_goldIngot = new System.Windows.Forms.Label();
            this.button_goldIngot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_end
            // 
            this.button_end.Location = new System.Drawing.Point(254, 82);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(41, 43);
            this.button_end.TabIndex = 18;
            this.button_end.Text = "END";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button_end_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(231, 12);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(64, 64);
            this.button_exit.TabIndex = 17;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_ironIngot
            // 
            this.button_ironIngot.Image = ((System.Drawing.Image)(resources.GetObject("button_ironIngot.Image")));
            this.button_ironIngot.Location = new System.Drawing.Point(45, 31);
            this.button_ironIngot.Name = "button_ironIngot";
            this.button_ironIngot.Size = new System.Drawing.Size(64, 64);
            this.button_ironIngot.TabIndex = 19;
            this.button_ironIngot.UseVisualStyleBackColor = true;
            this.button_ironIngot.Click += new System.EventHandler(this.button_ironIngot_Click);
            // 
            // label_ironIngot
            // 
            this.label_ironIngot.AutoSize = true;
            this.label_ironIngot.Location = new System.Drawing.Point(96, 82);
            this.label_ironIngot.Name = "label_ironIngot";
            this.label_ironIngot.Size = new System.Drawing.Size(13, 13);
            this.label_ironIngot.TabIndex = 20;
            this.label_ironIngot.Text = "0";
            // 
            // label_goldIngot
            // 
            this.label_goldIngot.AutoSize = true;
            this.label_goldIngot.Location = new System.Drawing.Point(166, 82);
            this.label_goldIngot.Name = "label_goldIngot";
            this.label_goldIngot.Size = new System.Drawing.Size(13, 13);
            this.label_goldIngot.TabIndex = 22;
            this.label_goldIngot.Text = "0";
            // 
            // button_goldIngot
            // 
            this.button_goldIngot.Image = ((System.Drawing.Image)(resources.GetObject("button_goldIngot.Image")));
            this.button_goldIngot.Location = new System.Drawing.Point(115, 31);
            this.button_goldIngot.Name = "button_goldIngot";
            this.button_goldIngot.Size = new System.Drawing.Size(64, 64);
            this.button_goldIngot.TabIndex = 21;
            this.button_goldIngot.UseVisualStyleBackColor = true;
            this.button_goldIngot.Click += new System.EventHandler(this.button_goldIngot_Click);
            // 
            // Form_smelting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 149);
            this.Controls.Add(this.label_goldIngot);
            this.Controls.Add(this.button_goldIngot);
            this.Controls.Add(this.label_ironIngot);
            this.Controls.Add(this.button_ironIngot);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button_exit);
            this.Name = "Form_smelting";
            this.Text = "Smelting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_end;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_ironIngot;
        private System.Windows.Forms.Label label_ironIngot;
        private System.Windows.Forms.Label label_goldIngot;
        private System.Windows.Forms.Button button_goldIngot;
    }
}