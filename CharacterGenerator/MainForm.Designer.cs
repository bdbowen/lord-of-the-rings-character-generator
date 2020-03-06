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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isHobbitRadio = new System.Windows.Forms.RadioButton();
            this.isHumanRadio = new System.Windows.Forms.RadioButton();
            this.isWizardRadio = new System.Windows.Forms.RadioButton();
            this.isDwarfRadio = new System.Windows.Forms.RadioButton();
            this.isElfRadio = new System.Windows.Forms.RadioButton();
            this.generateBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.NametxtBx = new System.Windows.Forms.TextBox();
            this.ageTxtBx = new System.Windows.Forms.TextBox();
            this.ageLbl = new System.Windows.Forms.Label();
            this.hairTxtBx = new System.Windows.Forms.TextBox();
            this.hairLbl = new System.Windows.Forms.Label();
            this.eyeTxtBx = new System.Windows.Forms.TextBox();
            this.eyeLbl = new System.Windows.Forms.Label();
            this.complexionTxtBx = new System.Windows.Forms.TextBox();
            this.complexionLbl = new System.Windows.Forms.Label();
            this.viewHome = new System.Windows.Forms.Button();
            this.viewPosition = new System.Windows.Forms.Button();
            this.genderTxtBx = new System.Windows.Forms.TextBox();
            this.genderLbl = new System.Windows.Forms.Label();
            this.viewAdventures = new System.Windows.Forms.Button();
            this.isEvil = new System.Windows.Forms.CheckBox();
            this.WoCTxtBx = new System.Windows.Forms.TextBox();
            this.WoCLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isHobbitRadio);
            this.groupBox1.Controls.Add(this.isHumanRadio);
            this.groupBox1.Controls.Add(this.isWizardRadio);
            this.groupBox1.Controls.Add(this.isDwarfRadio);
            this.groupBox1.Controls.Add(this.isElfRadio);
            this.groupBox1.Location = new System.Drawing.Point(24, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Race:";
            // 
            // isHobbitRadio
            // 
            this.isHobbitRadio.AccessibleName = "";
            this.isHobbitRadio.AutoSize = true;
            this.isHobbitRadio.Location = new System.Drawing.Point(8, 142);
            this.isHobbitRadio.Margin = new System.Windows.Forms.Padding(4);
            this.isHobbitRadio.Name = "isHobbitRadio";
            this.isHobbitRadio.Size = new System.Drawing.Size(70, 21);
            this.isHobbitRadio.TabIndex = 4;
            this.isHobbitRadio.TabStop = true;
            this.isHobbitRadio.Text = "Hobbit";
            this.isHobbitRadio.UseVisualStyleBackColor = true;
            // 
            // isHumanRadio
            // 
            this.isHumanRadio.AccessibleName = "";
            this.isHumanRadio.AutoSize = true;
            this.isHumanRadio.Location = new System.Drawing.Point(8, 112);
            this.isHumanRadio.Margin = new System.Windows.Forms.Padding(4);
            this.isHumanRadio.Name = "isHumanRadio";
            this.isHumanRadio.Size = new System.Drawing.Size(74, 21);
            this.isHumanRadio.TabIndex = 3;
            this.isHumanRadio.TabStop = true;
            this.isHumanRadio.Text = "Human";
            this.isHumanRadio.UseVisualStyleBackColor = true;
            // 
            // isWizardRadio
            // 
            this.isWizardRadio.AccessibleName = "";
            this.isWizardRadio.AutoSize = true;
            this.isWizardRadio.Location = new System.Drawing.Point(8, 82);
            this.isWizardRadio.Margin = new System.Windows.Forms.Padding(4);
            this.isWizardRadio.Name = "isWizardRadio";
            this.isWizardRadio.Size = new System.Drawing.Size(73, 21);
            this.isWizardRadio.TabIndex = 2;
            this.isWizardRadio.TabStop = true;
            this.isWizardRadio.Text = "Wizard";
            this.isWizardRadio.UseVisualStyleBackColor = true;
            // 
            // isDwarfRadio
            // 
            this.isDwarfRadio.AccessibleName = "";
            this.isDwarfRadio.AutoSize = true;
            this.isDwarfRadio.Location = new System.Drawing.Point(8, 53);
            this.isDwarfRadio.Margin = new System.Windows.Forms.Padding(4);
            this.isDwarfRadio.Name = "isDwarfRadio";
            this.isDwarfRadio.Size = new System.Drawing.Size(65, 21);
            this.isDwarfRadio.TabIndex = 1;
            this.isDwarfRadio.TabStop = true;
            this.isDwarfRadio.Text = "Dwarf";
            this.isDwarfRadio.UseVisualStyleBackColor = true;
            // 
            // isElfRadio
            // 
            this.isElfRadio.AccessibleName = "";
            this.isElfRadio.AutoSize = true;
            this.isElfRadio.Location = new System.Drawing.Point(8, 23);
            this.isElfRadio.Margin = new System.Windows.Forms.Padding(4);
            this.isElfRadio.Name = "isElfRadio";
            this.isElfRadio.Size = new System.Drawing.Size(45, 21);
            this.isElfRadio.TabIndex = 0;
            this.isElfRadio.TabStop = true;
            this.isElfRadio.Text = "Elf";
            this.isElfRadio.UseVisualStyleBackColor = true;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(51, 250);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(173, 34);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Generate Character";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(394, 66);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(45, 17);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name";
            this.nameLbl.Visible = false;
            // 
            // NametxtBx
            // 
            this.NametxtBx.Location = new System.Drawing.Point(397, 89);
            this.NametxtBx.Name = "NametxtBx";
            this.NametxtBx.ReadOnly = true;
            this.NametxtBx.Size = new System.Drawing.Size(253, 22);
            this.NametxtBx.TabIndex = 3;
            this.NametxtBx.Visible = false;
            // 
            // ageTxtBx
            // 
            this.ageTxtBx.Location = new System.Drawing.Point(397, 148);
            this.ageTxtBx.Name = "ageTxtBx";
            this.ageTxtBx.ReadOnly = true;
            this.ageTxtBx.Size = new System.Drawing.Size(253, 22);
            this.ageTxtBx.TabIndex = 5;
            this.ageTxtBx.Visible = false;
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(394, 125);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(33, 17);
            this.ageLbl.TabIndex = 4;
            this.ageLbl.Text = "Age";
            this.ageLbl.Visible = false;
            // 
            // hairTxtBx
            // 
            this.hairTxtBx.Location = new System.Drawing.Point(395, 263);
            this.hairTxtBx.Name = "hairTxtBx";
            this.hairTxtBx.ReadOnly = true;
            this.hairTxtBx.Size = new System.Drawing.Size(253, 22);
            this.hairTxtBx.TabIndex = 7;
            this.hairTxtBx.Visible = false;
            // 
            // hairLbl
            // 
            this.hairLbl.AutoSize = true;
            this.hairLbl.Location = new System.Drawing.Point(392, 240);
            this.hairLbl.Name = "hairLbl";
            this.hairLbl.Size = new System.Drawing.Size(71, 17);
            this.hairLbl.TabIndex = 6;
            this.hairLbl.Text = "Hair Color";
            this.hairLbl.Visible = false;
            // 
            // eyeTxtBx
            // 
            this.eyeTxtBx.Location = new System.Drawing.Point(397, 326);
            this.eyeTxtBx.Name = "eyeTxtBx";
            this.eyeTxtBx.ReadOnly = true;
            this.eyeTxtBx.Size = new System.Drawing.Size(253, 22);
            this.eyeTxtBx.TabIndex = 9;
            this.eyeTxtBx.Visible = false;
            // 
            // eyeLbl
            // 
            this.eyeLbl.AutoSize = true;
            this.eyeLbl.Location = new System.Drawing.Point(394, 303);
            this.eyeLbl.Name = "eyeLbl";
            this.eyeLbl.Size = new System.Drawing.Size(69, 17);
            this.eyeLbl.TabIndex = 8;
            this.eyeLbl.Text = "Eye Color";
            this.eyeLbl.Visible = false;
            // 
            // complexionTxtBx
            // 
            this.complexionTxtBx.Location = new System.Drawing.Point(397, 388);
            this.complexionTxtBx.Name = "complexionTxtBx";
            this.complexionTxtBx.ReadOnly = true;
            this.complexionTxtBx.Size = new System.Drawing.Size(253, 22);
            this.complexionTxtBx.TabIndex = 11;
            this.complexionTxtBx.Visible = false;
            // 
            // complexionLbl
            // 
            this.complexionLbl.AutoSize = true;
            this.complexionLbl.Location = new System.Drawing.Point(394, 365);
            this.complexionLbl.Name = "complexionLbl";
            this.complexionLbl.Size = new System.Drawing.Size(111, 17);
            this.complexionLbl.TabIndex = 10;
            this.complexionLbl.Text = "Skin Complexion";
            this.complexionLbl.Visible = false;
            // 
            // viewHome
            // 
            this.viewHome.Location = new System.Drawing.Point(748, 83);
            this.viewHome.Name = "viewHome";
            this.viewHome.Size = new System.Drawing.Size(133, 34);
            this.viewHome.TabIndex = 12;
            this.viewHome.Text = "View Hometown";
            this.viewHome.UseVisualStyleBackColor = true;
            this.viewHome.Visible = false;
            this.viewHome.Click += new System.EventHandler(this.viewHome_Click);
            // 
            // viewPosition
            // 
            this.viewPosition.Location = new System.Drawing.Point(748, 135);
            this.viewPosition.Name = "viewPosition";
            this.viewPosition.Size = new System.Drawing.Size(133, 34);
            this.viewPosition.TabIndex = 13;
            this.viewPosition.Text = "View Position";
            this.viewPosition.UseVisualStyleBackColor = true;
            this.viewPosition.Visible = false;
            this.viewPosition.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // genderTxtBx
            // 
            this.genderTxtBx.Location = new System.Drawing.Point(397, 203);
            this.genderTxtBx.Name = "genderTxtBx";
            this.genderTxtBx.ReadOnly = true;
            this.genderTxtBx.Size = new System.Drawing.Size(253, 22);
            this.genderTxtBx.TabIndex = 15;
            this.genderTxtBx.Visible = false;
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Location = new System.Drawing.Point(394, 180);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(56, 17);
            this.genderLbl.TabIndex = 14;
            this.genderLbl.Text = "Gender";
            this.genderLbl.Visible = false;
            // 
            // viewAdventures
            // 
            this.viewAdventures.Location = new System.Drawing.Point(748, 180);
            this.viewAdventures.Name = "viewAdventures";
            this.viewAdventures.Size = new System.Drawing.Size(133, 34);
            this.viewAdventures.TabIndex = 16;
            this.viewAdventures.Text = "View Adventures";
            this.viewAdventures.UseVisualStyleBackColor = true;
            this.viewAdventures.Visible = false;
            this.viewAdventures.Click += new System.EventHandler(this.viewAdventures_Click);
            // 
            // isEvil
            // 
            this.isEvil.AutoSize = true;
            this.isEvil.Location = new System.Drawing.Point(395, 484);
            this.isEvil.Name = "isEvil";
            this.isEvil.Size = new System.Drawing.Size(52, 21);
            this.isEvil.TabIndex = 17;
            this.isEvil.Text = "Evil";
            this.isEvil.UseVisualStyleBackColor = true;
            this.isEvil.Visible = false;
            // 
            // WoCTxtBx
            // 
            this.WoCTxtBx.Location = new System.Drawing.Point(395, 444);
            this.WoCTxtBx.Name = "WoCTxtBx";
            this.WoCTxtBx.ReadOnly = true;
            this.WoCTxtBx.Size = new System.Drawing.Size(253, 22);
            this.WoCTxtBx.TabIndex = 19;
            this.WoCTxtBx.Visible = false;
            // 
            // WoCLbl
            // 
            this.WoCLbl.AutoSize = true;
            this.WoCLbl.Location = new System.Drawing.Point(392, 421);
            this.WoCLbl.Name = "WoCLbl";
            this.WoCLbl.Size = new System.Drawing.Size(124, 17);
            this.WoCLbl.TabIndex = 18;
            this.WoCLbl.Text = "Weapon of Choice";
            this.WoCLbl.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1028, 517);
            this.Controls.Add(this.WoCTxtBx);
            this.Controls.Add(this.WoCLbl);
            this.Controls.Add(this.isEvil);
            this.Controls.Add(this.viewAdventures);
            this.Controls.Add(this.genderTxtBx);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.viewPosition);
            this.Controls.Add(this.viewHome);
            this.Controls.Add(this.complexionTxtBx);
            this.Controls.Add(this.complexionLbl);
            this.Controls.Add(this.eyeTxtBx);
            this.Controls.Add(this.eyeLbl);
            this.Controls.Add(this.hairTxtBx);
            this.Controls.Add(this.hairLbl);
            this.Controls.Add(this.ageTxtBx);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.NametxtBx);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Fantasy Character Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.RadioButton isHobbitRadio;
        private System.Windows.Forms.RadioButton isHumanRadio;
        private System.Windows.Forms.RadioButton isWizardRadio;
        private System.Windows.Forms.RadioButton isDwarfRadio;
        private System.Windows.Forms.RadioButton isElfRadio;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox NametxtBx;
        private System.Windows.Forms.TextBox ageTxtBx;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.TextBox hairTxtBx;
        private System.Windows.Forms.Label hairLbl;
        private System.Windows.Forms.TextBox eyeTxtBx;
        private System.Windows.Forms.Label eyeLbl;
        private System.Windows.Forms.TextBox complexionTxtBx;
        private System.Windows.Forms.Label complexionLbl;
        private System.Windows.Forms.Button viewHome;
        private System.Windows.Forms.Button viewPosition;
        private System.Windows.Forms.TextBox genderTxtBx;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Button viewAdventures;
        private System.Windows.Forms.CheckBox isEvil;
        private System.Windows.Forms.TextBox WoCTxtBx;
        private System.Windows.Forms.Label WoCLbl;
    }
}

