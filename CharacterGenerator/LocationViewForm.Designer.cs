namespace CharacterGenerator
{
    partial class LocationViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationViewForm));
            this.TitleTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.freeCheck = new System.Windows.Forms.CheckBox();
            this.regionTxtBx = new System.Windows.Forms.TextBox();
            this.raceTxtBx = new System.Windows.Forms.TextBox();
            this.quadrantTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TitleTxtBx
            // 
            this.TitleTxtBx.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTxtBx.Location = new System.Drawing.Point(240, 34);
            this.TitleTxtBx.Name = "TitleTxtBx";
            this.TitleTxtBx.ReadOnly = true;
            this.TitleTxtBx.Size = new System.Drawing.Size(234, 32);
            this.TitleTxtBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Region of Middle Earth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Primary Race of Inhabitants";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quadrant of the map";
            // 
            // freeCheck
            // 
            this.freeCheck.AutoSize = true;
            this.freeCheck.BackColor = System.Drawing.Color.Transparent;
            this.freeCheck.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeCheck.Location = new System.Drawing.Point(365, 149);
            this.freeCheck.Name = "freeCheck";
            this.freeCheck.Size = new System.Drawing.Size(109, 26);
            this.freeCheck.TabIndex = 5;
            this.freeCheck.Text = "Free Land";
            this.freeCheck.UseVisualStyleBackColor = false;
            this.freeCheck.CheckedChanged += new System.EventHandler(this.freeCheck_CheckedChanged);
            // 
            // regionTxtBx
            // 
            this.regionTxtBx.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionTxtBx.Location = new System.Drawing.Point(240, 72);
            this.regionTxtBx.Name = "regionTxtBx";
            this.regionTxtBx.ReadOnly = true;
            this.regionTxtBx.Size = new System.Drawing.Size(234, 32);
            this.regionTxtBx.TabIndex = 6;
            // 
            // raceTxtBx
            // 
            this.raceTxtBx.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceTxtBx.Location = new System.Drawing.Point(240, 110);
            this.raceTxtBx.Name = "raceTxtBx";
            this.raceTxtBx.ReadOnly = true;
            this.raceTxtBx.Size = new System.Drawing.Size(234, 32);
            this.raceTxtBx.TabIndex = 7;
            // 
            // quadrantTxtBx
            // 
            this.quadrantTxtBx.Font = new System.Drawing.Font("MV Boli", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadrantTxtBx.Location = new System.Drawing.Point(240, 148);
            this.quadrantTxtBx.Name = "quadrantTxtBx";
            this.quadrantTxtBx.ReadOnly = true;
            this.quadrantTxtBx.Size = new System.Drawing.Size(41, 32);
            this.quadrantTxtBx.TabIndex = 8;
            // 
            // LocationViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(496, 199);
            this.Controls.Add(this.quadrantTxtBx);
            this.Controls.Add(this.raceTxtBx);
            this.Controls.Add(this.regionTxtBx);
            this.Controls.Add(this.freeCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleTxtBx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocationViewForm";
            this.Text = "Hometown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox freeCheck;
        private System.Windows.Forms.TextBox regionTxtBx;
        private System.Windows.Forms.TextBox raceTxtBx;
        private System.Windows.Forms.TextBox quadrantTxtBx;
    }
}