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
            this.Attr1TxtBx = new System.Windows.Forms.TextBox();
            this.Attr1Lbl = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.isHobbitRadio);
            this.groupBox1.Controls.Add(this.isHumanRadio);
            this.groupBox1.Controls.Add(this.isWizardRadio);
            this.groupBox1.Controls.Add(this.isDwarfRadio);
            this.groupBox1.Controls.Add(this.isElfRadio);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Race:";
            // 
            // isHobbitRadio
            // 
            this.isHobbitRadio.AccessibleName = "";
            this.isHobbitRadio.AutoSize = true;
            this.isHobbitRadio.Location = new System.Drawing.Point(6, 115);
            this.isHobbitRadio.Name = "isHobbitRadio";
            this.isHobbitRadio.Size = new System.Drawing.Size(72, 22);
            this.isHobbitRadio.TabIndex = 4;
            this.isHobbitRadio.TabStop = true;
            this.isHobbitRadio.Text = "Hobbit";
            this.isHobbitRadio.UseVisualStyleBackColor = true;
            // 
            // isHumanRadio
            // 
            this.isHumanRadio.AccessibleName = "";
            this.isHumanRadio.AutoSize = true;
            this.isHumanRadio.Location = new System.Drawing.Point(6, 91);
            this.isHumanRadio.Name = "isHumanRadio";
            this.isHumanRadio.Size = new System.Drawing.Size(73, 22);
            this.isHumanRadio.TabIndex = 3;
            this.isHumanRadio.TabStop = true;
            this.isHumanRadio.Text = "Human";
            this.isHumanRadio.UseVisualStyleBackColor = true;
            // 
            // isWizardRadio
            // 
            this.isWizardRadio.AccessibleName = "";
            this.isWizardRadio.AutoSize = true;
            this.isWizardRadio.Location = new System.Drawing.Point(6, 67);
            this.isWizardRadio.Name = "isWizardRadio";
            this.isWizardRadio.Size = new System.Drawing.Size(76, 22);
            this.isWizardRadio.TabIndex = 2;
            this.isWizardRadio.TabStop = true;
            this.isWizardRadio.Text = "Wizard";
            this.isWizardRadio.UseVisualStyleBackColor = true;
            // 
            // isDwarfRadio
            // 
            this.isDwarfRadio.AccessibleName = "";
            this.isDwarfRadio.AutoSize = true;
            this.isDwarfRadio.Location = new System.Drawing.Point(6, 43);
            this.isDwarfRadio.Name = "isDwarfRadio";
            this.isDwarfRadio.Size = new System.Drawing.Size(70, 22);
            this.isDwarfRadio.TabIndex = 1;
            this.isDwarfRadio.TabStop = true;
            this.isDwarfRadio.Text = "Dwarf";
            this.isDwarfRadio.UseVisualStyleBackColor = true;
            // 
            // isElfRadio
            // 
            this.isElfRadio.AccessibleName = "";
            this.isElfRadio.AutoSize = true;
            this.isElfRadio.Location = new System.Drawing.Point(6, 19);
            this.isElfRadio.Name = "isElfRadio";
            this.isElfRadio.Size = new System.Drawing.Size(48, 22);
            this.isElfRadio.TabIndex = 0;
            this.isElfRadio.TabStop = true;
            this.isElfRadio.Text = "Elf";
            this.isElfRadio.UseVisualStyleBackColor = true;
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.generateBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Location = new System.Drawing.Point(96, 193);
            this.generateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(130, 28);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.Text = "Generate Character";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(405, 62);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(54, 22);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name";
            this.nameLbl.Visible = false;
            // 
            // NametxtBx
            // 
            this.NametxtBx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NametxtBx.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NametxtBx.Location = new System.Drawing.Point(463, 60);
            this.NametxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NametxtBx.Name = "NametxtBx";
            this.NametxtBx.ReadOnly = true;
            this.NametxtBx.Size = new System.Drawing.Size(305, 29);
            this.NametxtBx.TabIndex = 3;
            this.NametxtBx.Visible = false;
            // 
            // ageTxtBx
            // 
            this.ageTxtBx.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTxtBx.Location = new System.Drawing.Point(463, 104);
            this.ageTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ageTxtBx.Name = "ageTxtBx";
            this.ageTxtBx.ReadOnly = true;
            this.ageTxtBx.Size = new System.Drawing.Size(65, 29);
            this.ageTxtBx.TabIndex = 5;
            this.ageTxtBx.Visible = false;
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.BackColor = System.Drawing.Color.Transparent;
            this.ageLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.Location = new System.Drawing.Point(419, 106);
            this.ageLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(40, 22);
            this.ageLbl.TabIndex = 4;
            this.ageLbl.Text = "Age";
            this.ageLbl.Visible = false;
            // 
            // hairTxtBx
            // 
            this.hairTxtBx.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hairTxtBx.Location = new System.Drawing.Point(604, 144);
            this.hairTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hairTxtBx.Name = "hairTxtBx";
            this.hairTxtBx.ReadOnly = true;
            this.hairTxtBx.Size = new System.Drawing.Size(164, 29);
            this.hairTxtBx.TabIndex = 7;
            this.hairTxtBx.Visible = false;
            // 
            // hairLbl
            // 
            this.hairLbl.AutoSize = true;
            this.hairLbl.BackColor = System.Drawing.Color.Transparent;
            this.hairLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hairLbl.Location = new System.Drawing.Point(554, 149);
            this.hairLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hairLbl.Name = "hairLbl";
            this.hairLbl.Size = new System.Drawing.Size(46, 22);
            this.hairLbl.TabIndex = 6;
            this.hairLbl.Text = "Hair";
            this.hairLbl.Visible = false;
            // 
            // eyeTxtBx
            // 
            this.eyeTxtBx.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyeTxtBx.Location = new System.Drawing.Point(604, 104);
            this.eyeTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eyeTxtBx.Name = "eyeTxtBx";
            this.eyeTxtBx.ReadOnly = true;
            this.eyeTxtBx.Size = new System.Drawing.Size(164, 29);
            this.eyeTxtBx.TabIndex = 9;
            this.eyeTxtBx.Visible = false;
            this.eyeTxtBx.TextChanged += new System.EventHandler(this.eyeTxtBx_TextChanged);
            // 
            // eyeLbl
            // 
            this.eyeLbl.AutoSize = true;
            this.eyeLbl.BackColor = System.Drawing.Color.Transparent;
            this.eyeLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyeLbl.Location = new System.Drawing.Point(560, 106);
            this.eyeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eyeLbl.Name = "eyeLbl";
            this.eyeLbl.Size = new System.Drawing.Size(40, 22);
            this.eyeLbl.TabIndex = 8;
            this.eyeLbl.Text = "Eye";
            this.eyeLbl.Visible = false;
            // 
            // complexionTxtBx
            // 
            this.complexionTxtBx.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complexionTxtBx.Location = new System.Drawing.Point(463, 195);
            this.complexionTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.complexionTxtBx.Name = "complexionTxtBx";
            this.complexionTxtBx.ReadOnly = true;
            this.complexionTxtBx.Size = new System.Drawing.Size(137, 29);
            this.complexionTxtBx.TabIndex = 11;
            this.complexionTxtBx.Visible = false;
            // 
            // complexionLbl
            // 
            this.complexionLbl.AutoSize = true;
            this.complexionLbl.BackColor = System.Drawing.Color.Transparent;
            this.complexionLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complexionLbl.Location = new System.Drawing.Point(321, 197);
            this.complexionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.complexionLbl.Name = "complexionLbl";
            this.complexionLbl.Size = new System.Drawing.Size(141, 22);
            this.complexionLbl.TabIndex = 10;
            this.complexionLbl.Text = "Skin Complexion";
            this.complexionLbl.Visible = false;
            // 
            // viewHome
            // 
            this.viewHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewHome.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewHome.Location = new System.Drawing.Point(787, 71);
            this.viewHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewHome.Name = "viewHome";
            this.viewHome.Size = new System.Drawing.Size(140, 28);
            this.viewHome.TabIndex = 12;
            this.viewHome.Text = "View Hometown";
            this.viewHome.UseVisualStyleBackColor = false;
            this.viewHome.Visible = false;
            this.viewHome.Click += new System.EventHandler(this.viewHome_Click);
            // 
            // viewPosition
            // 
            this.viewPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewPosition.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPosition.Location = new System.Drawing.Point(787, 143);
            this.viewPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewPosition.Name = "viewPosition";
            this.viewPosition.Size = new System.Drawing.Size(140, 28);
            this.viewPosition.TabIndex = 13;
            this.viewPosition.Text = "View Position";
            this.viewPosition.UseVisualStyleBackColor = false;
            this.viewPosition.Visible = false;
            this.viewPosition.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // genderTxtBx
            // 
            this.genderTxtBx.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTxtBx.Location = new System.Drawing.Point(463, 149);
            this.genderTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.genderTxtBx.Name = "genderTxtBx";
            this.genderTxtBx.ReadOnly = true;
            this.genderTxtBx.Size = new System.Drawing.Size(65, 29);
            this.genderTxtBx.TabIndex = 15;
            this.genderTxtBx.Visible = false;
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.BackColor = System.Drawing.Color.Transparent;
            this.genderLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.Location = new System.Drawing.Point(397, 149);
            this.genderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(65, 22);
            this.genderLbl.TabIndex = 14;
            this.genderLbl.Text = "Gender";
            this.genderLbl.Visible = false;
            // 
            // viewAdventures
            // 
            this.viewAdventures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewAdventures.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAdventures.Location = new System.Drawing.Point(787, 208);
            this.viewAdventures.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewAdventures.Name = "viewAdventures";
            this.viewAdventures.Size = new System.Drawing.Size(140, 28);
            this.viewAdventures.TabIndex = 16;
            this.viewAdventures.Text = "View Adventures";
            this.viewAdventures.UseVisualStyleBackColor = false;
            this.viewAdventures.Visible = false;
            this.viewAdventures.Click += new System.EventHandler(this.viewAdventures_Click);
            // 
            // isEvil
            // 
            this.isEvil.AutoSize = true;
            this.isEvil.BackColor = System.Drawing.Color.Transparent;
            this.isEvil.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isEvil.Location = new System.Drawing.Point(625, 184);
            this.isEvil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.isEvil.Name = "isEvil";
            this.isEvil.Size = new System.Drawing.Size(63, 26);
            this.isEvil.TabIndex = 17;
            this.isEvil.Text = "Evil";
            this.isEvil.UseVisualStyleBackColor = false;
            this.isEvil.Visible = false;
            // 
            // WoCTxtBx
            // 
            this.WoCTxtBx.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WoCTxtBx.Location = new System.Drawing.Point(463, 245);
            this.WoCTxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WoCTxtBx.Name = "WoCTxtBx";
            this.WoCTxtBx.ReadOnly = true;
            this.WoCTxtBx.Size = new System.Drawing.Size(137, 29);
            this.WoCTxtBx.TabIndex = 19;
            this.WoCTxtBx.Visible = false;
            // 
            // WoCLbl
            // 
            this.WoCLbl.AutoSize = true;
            this.WoCLbl.BackColor = System.Drawing.Color.Transparent;
            this.WoCLbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WoCLbl.Location = new System.Drawing.Point(310, 247);
            this.WoCLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WoCLbl.Name = "WoCLbl";
            this.WoCLbl.Size = new System.Drawing.Size(149, 22);
            this.WoCLbl.TabIndex = 18;
            this.WoCLbl.Text = "Weapon of Choice";
            this.WoCLbl.Visible = false;
            // 
            // Attr1TxtBx
            // 
            this.Attr1TxtBx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Attr1TxtBx.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attr1TxtBx.Location = new System.Drawing.Point(463, 295);
            this.Attr1TxtBx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Attr1TxtBx.Name = "Attr1TxtBx";
            this.Attr1TxtBx.ReadOnly = true;
            this.Attr1TxtBx.Size = new System.Drawing.Size(305, 29);
            this.Attr1TxtBx.TabIndex = 21;
            this.Attr1TxtBx.Visible = false;
            // 
            // Attr1Lbl
            // 
            this.Attr1Lbl.AutoSize = true;
            this.Attr1Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Attr1Lbl.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attr1Lbl.Location = new System.Drawing.Point(340, 297);
            this.Attr1Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Attr1Lbl.Name = "Attr1Lbl";
            this.Attr1Lbl.Size = new System.Drawing.Size(122, 22);
            this.Attr1Lbl.TabIndex = 20;
            this.Attr1Lbl.Text = "SubClassAttr1";
            this.Attr1Lbl.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(625, 218);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(143, 26);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "SubClassBool1";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(625, 253);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(143, 26);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "SubClassBool2";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(992, 567);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Attr1TxtBx);
            this.Controls.Add(this.Attr1Lbl);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox Attr1TxtBx;
        private System.Windows.Forms.Label Attr1Lbl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

