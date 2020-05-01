namespace CharacterGenerator
{
    partial class AdventureHistoryForm
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
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.viewLocationBtn = new System.Windows.Forms.Button();
            this.fatal = new System.Windows.Forms.CheckBox();
            this.successful = new System.Windows.Forms.CheckBox();
            this.companionTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.leaderTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.personIDTxtBx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personNameLbl = new System.Windows.Forms.Label();
            this.advIDTxtBx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchById = new System.Windows.Forms.Button();
            this.findall = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nextBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(46, 240);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(174, 30);
            this.nextBtn.TabIndex = 19;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prevBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBtn.Location = new System.Drawing.Point(46, 203);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(174, 31);
            this.prevBtn.TabIndex = 18;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // viewLocationBtn
            // 
            this.viewLocationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewLocationBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLocationBtn.Location = new System.Drawing.Point(756, 133);
            this.viewLocationBtn.Name = "viewLocationBtn";
            this.viewLocationBtn.Size = new System.Drawing.Size(218, 31);
            this.viewLocationBtn.TabIndex = 17;
            this.viewLocationBtn.Text = "Destination Details";
            this.viewLocationBtn.UseVisualStyleBackColor = false;
            this.viewLocationBtn.Click += new System.EventHandler(this.viewLocationBtn_Click);
            // 
            // fatal
            // 
            this.fatal.AutoCheck = false;
            this.fatal.AutoSize = true;
            this.fatal.BackColor = System.Drawing.Color.Transparent;
            this.fatal.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatal.Location = new System.Drawing.Point(114, 316);
            this.fatal.Name = "fatal";
            this.fatal.Size = new System.Drawing.Size(72, 26);
            this.fatal.TabIndex = 16;
            this.fatal.Text = "Fatal";
            this.fatal.UseVisualStyleBackColor = false;
            // 
            // successful
            // 
            this.successful.AutoCheck = false;
            this.successful.AutoSize = true;
            this.successful.BackColor = System.Drawing.Color.Transparent;
            this.successful.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successful.Location = new System.Drawing.Point(114, 282);
            this.successful.Name = "successful";
            this.successful.Size = new System.Drawing.Size(195, 26);
            this.successful.TabIndex = 11;
            this.successful.Text = "Adventure Successful";
            this.successful.UseVisualStyleBackColor = false;
            // 
            // companionTxtBx
            // 
            this.companionTxtBx.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companionTxtBx.Location = new System.Drawing.Point(114, 149);
            this.companionTxtBx.Multiline = true;
            this.companionTxtBx.Name = "companionTxtBx";
            this.companionTxtBx.ReadOnly = true;
            this.companionTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.companionTxtBx.Size = new System.Drawing.Size(266, 122);
            this.companionTxtBx.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Companions";
            // 
            // leaderTxtBx
            // 
            this.leaderTxtBx.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderTxtBx.Location = new System.Drawing.Point(114, 73);
            this.leaderTxtBx.Name = "leaderTxtBx";
            this.leaderTxtBx.ReadOnly = true;
            this.leaderTxtBx.Size = new System.Drawing.Size(266, 32);
            this.leaderTxtBx.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Leader";
            // 
            // personIDTxtBx
            // 
            this.personIDTxtBx.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personIDTxtBx.Location = new System.Drawing.Point(114, 111);
            this.personIDTxtBx.Name = "personIDTxtBx";
            this.personIDTxtBx.ReadOnly = true;
            this.personIDTxtBx.Size = new System.Drawing.Size(54, 32);
            this.personIDTxtBx.TabIndex = 21;
            this.personIDTxtBx.TextChanged += new System.EventHandler(this.personIDTxtBx_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Person ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.personNameLbl);
            this.groupBox1.Controls.Add(this.leaderTxtBx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.personIDTxtBx);
            this.groupBox1.Controls.Add(this.fatal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.successful);
            this.groupBox1.Controls.Add(this.companionTxtBx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.titleLbl);
            this.groupBox1.Location = new System.Drawing.Point(309, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 359);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // personNameLbl
            // 
            this.personNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.personNameLbl.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNameLbl.Location = new System.Drawing.Point(174, 113);
            this.personNameLbl.Name = "personNameLbl";
            this.personNameLbl.Size = new System.Drawing.Size(206, 26);
            this.personNameLbl.TabIndex = 23;
            this.personNameLbl.Text = "Person Name";
            this.personNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // advIDTxtBx
            // 
            this.advIDTxtBx.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.advIDTxtBx.Location = new System.Drawing.Point(166, 81);
            this.advIDTxtBx.Name = "advIDTxtBx";
            this.advIDTxtBx.Size = new System.Drawing.Size(54, 32);
            this.advIDTxtBx.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Adventure ID";
            // 
            // searchById
            // 
            this.searchById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchById.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchById.Location = new System.Drawing.Point(46, 131);
            this.searchById.Name = "searchById";
            this.searchById.Size = new System.Drawing.Size(174, 30);
            this.searchById.TabIndex = 26;
            this.searchById.Text = "Find By ID";
            this.searchById.UseVisualStyleBackColor = false;
            this.searchById.Click += new System.EventHandler(this.searchById_Click);
            // 
            // findall
            // 
            this.findall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.findall.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findall.Location = new System.Drawing.Point(46, 167);
            this.findall.Name = "findall";
            this.findall.Size = new System.Drawing.Size(174, 30);
            this.findall.TabIndex = 27;
            this.findall.Text = "Find All";
            this.findall.UseVisualStyleBackColor = false;
            this.findall.Click += new System.EventHandler(this.findall_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLbl.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(3, 16);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(388, 340);
            this.titleLbl.TabIndex = 24;
            this.titleLbl.Text = "Journey to X";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1008, 606);
            this.label7.TabIndex = 28;
            this.label7.Text = "Adventure History";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.Location = new System.Drawing.Point(756, 207);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(218, 31);
            this.editBtn.TabIndex = 29;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBtn.Location = new System.Drawing.Point(756, 170);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(218, 31);
            this.newBtn.TabIndex = 30;
            this.newBtn.Text = "Generate New Adventure";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(812, 133);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(109, 31);
            this.saveBtn.TabIndex = 31;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Visible = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(812, 170);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(109, 31);
            this.deleteBtn.TabIndex = 32;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancelBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(812, 207);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(109, 31);
            this.cancelBtn.TabIndex = 33;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AdventureHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 606);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.findall);
            this.Controls.Add(this.searchById);
            this.Controls.Add(this.advIDTxtBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.viewLocationBtn);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdventureHistoryForm";
            this.Text = "AdventureHistoryForm";
            this.Load += new System.EventHandler(this.AdventureHistoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button viewLocationBtn;
        private System.Windows.Forms.CheckBox fatal;
        private System.Windows.Forms.CheckBox successful;
        private System.Windows.Forms.TextBox companionTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox leaderTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personIDTxtBx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label personNameLbl;
        private System.Windows.Forms.TextBox advIDTxtBx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button searchById;
        private System.Windows.Forms.Button findall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}