namespace CharacterGenerator
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dwarfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hobbitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elfToolStripMenuItem,
            this.dwarfToolStripMenuItem,
            this.wizardToolStripMenuItem,
            this.humanToolStripMenuItem,
            this.hobbitToolStripMenuItem});
            this.historyToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(160, 21);
            this.historyToolStripMenuItem.Text = "History of Generation";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // elfToolStripMenuItem
            // 
            this.elfToolStripMenuItem.Name = "elfToolStripMenuItem";
            this.elfToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.elfToolStripMenuItem.Text = "Elf";
            this.elfToolStripMenuItem.Click += new System.EventHandler(this.elfToolStripMenuItem_Click);
            // 
            // dwarfToolStripMenuItem
            // 
            this.dwarfToolStripMenuItem.Name = "dwarfToolStripMenuItem";
            this.dwarfToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dwarfToolStripMenuItem.Text = "Dwarf";
            this.dwarfToolStripMenuItem.Click += new System.EventHandler(this.dwarfToolStripMenuItem_Click);
            // 
            // wizardToolStripMenuItem
            // 
            this.wizardToolStripMenuItem.Name = "wizardToolStripMenuItem";
            this.wizardToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.wizardToolStripMenuItem.Text = "Wizard";
            this.wizardToolStripMenuItem.Click += new System.EventHandler(this.wizardToolStripMenuItem_Click);
            // 
            // humanToolStripMenuItem
            // 
            this.humanToolStripMenuItem.Name = "humanToolStripMenuItem";
            this.humanToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.humanToolStripMenuItem.Text = "Human";
            this.humanToolStripMenuItem.Click += new System.EventHandler(this.humanToolStripMenuItem_Click);
            // 
            // hobbitToolStripMenuItem
            // 
            this.hobbitToolStripMenuItem.Name = "hobbitToolStripMenuItem";
            this.hobbitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.hobbitToolStripMenuItem.Text = "Hobbit";
            this.hobbitToolStripMenuItem.Click += new System.EventHandler(this.hobbitToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationsToolStripMenuItem,
            this.rolesToolStripMenuItem});
            this.dataToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(175, 21);
            this.dataToolStripMenuItem.Text = "Data for Randomization";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.locationsToolStripMenuItem.Text = "Locations";
            this.locationsToolStripMenuItem.Click += new System.EventHandler(this.locationsToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 596);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Fantasy Character Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dwarfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hobbitToolStripMenuItem;
    }
}