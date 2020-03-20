namespace CharacterGenerator
{
    partial class AdventuresViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdventuresViewForm));
            this.label1 = new System.Windows.Forms.Label();
            this.leaderTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companionTxtBx = new System.Windows.Forms.TextBox();
            this.successful = new System.Windows.Forms.CheckBox();
            this.fatal = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.titleLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leader";
            // 
            // leaderTxtBx
            // 
            this.leaderTxtBx.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderTxtBx.Location = new System.Drawing.Point(125, 66);
            this.leaderTxtBx.Name = "leaderTxtBx";
            this.leaderTxtBx.ReadOnly = true;
            this.leaderTxtBx.Size = new System.Drawing.Size(245, 32);
            this.leaderTxtBx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Companions";
            // 
            // companionTxtBx
            // 
            this.companionTxtBx.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companionTxtBx.Location = new System.Drawing.Point(125, 104);
            this.companionTxtBx.Multiline = true;
            this.companionTxtBx.Name = "companionTxtBx";
            this.companionTxtBx.ReadOnly = true;
            this.companionTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.companionTxtBx.Size = new System.Drawing.Size(245, 122);
            this.companionTxtBx.TabIndex = 5;
            // 
            // successful
            // 
            this.successful.AutoSize = true;
            this.successful.BackColor = System.Drawing.Color.Transparent;
            this.successful.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successful.Location = new System.Drawing.Point(125, 232);
            this.successful.Name = "successful";
            this.successful.Size = new System.Drawing.Size(195, 26);
            this.successful.TabIndex = 0;
            this.successful.Text = "Adventure Successful";
            this.successful.UseVisualStyleBackColor = false;
            // 
            // fatal
            // 
            this.fatal.AutoSize = true;
            this.fatal.BackColor = System.Drawing.Color.Transparent;
            this.fatal.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatal.Location = new System.Drawing.Point(125, 264);
            this.fatal.Name = "fatal";
            this.fatal.Size = new System.Drawing.Size(72, 26);
            this.fatal.TabIndex = 7;
            this.fatal.Text = "Fatal";
            this.fatal.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(426, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Destination Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleLbl
            // 
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLbl.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(0, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(685, 360);
            this.titleLbl.TabIndex = 7;
            this.titleLbl.Text = "Adventure X";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(426, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Previous Adventure";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(426, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "Next Adventure";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdventuresViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 360);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fatal);
            this.Controls.Add(this.successful);
            this.Controls.Add(this.companionTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.leaderTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdventuresViewForm";
            this.Text = "AdventuresViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox leaderTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox companionTxtBx;
        private System.Windows.Forms.CheckBox successful;
        private System.Windows.Forms.CheckBox fatal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}