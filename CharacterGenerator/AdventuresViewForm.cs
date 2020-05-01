using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Domain;

namespace CharacterGenerator
{
    public partial class AdventuresViewForm : Form
    {
        private Adventure[] AdventureOptions;
        private Adventure CurrentAdventure;
        private int adventureIndex;
        private int number;
        public AdventuresViewForm()
        {
            InitializeComponent();
        }
        

        public AdventuresViewForm(List<Adventure> adventures, string caption, int number)
        {
            InitializeComponent();
            AdventureOptions = adventures.ToArray();
            CurrentAdventure = AdventureOptions[0];
            adventureIndex = 0;
            leaderTxtBx.Text = CurrentAdventure.LeaderName;

            this.number = number;
            companionTxtBx.Lines = CurrentAdventure.CompanionNames.Split(',');
            successful.Checked = CurrentAdventure.Successful;
            fatal.Checked = CurrentAdventure.Fatal;
            titleLbl.Text = "Adventure " + (adventureIndex + 1).ToString() + ": Journey to " + CurrentAdventure.Location.Title;
            Text = caption;
            //set background image
            string path = Application.StartupPath + "\\..\\..\\..\\Media\\" + "advBackgroundOpt" + number.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(path);
            Size = BackgroundImage.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caption = titleLbl.Text + " Destination";
            LocationViewForm myForm = new LocationViewForm(CurrentAdventure.Location, caption, number);
            myForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adventureIndex = (adventureIndex + AdventureOptions.Length - 1) % AdventureOptions.Length;
            CurrentAdventure = AdventureOptions[adventureIndex];

            leaderTxtBx.Text = CurrentAdventure.LeaderName;
            companionTxtBx.Lines = CurrentAdventure.CompanionNames.Split(',');
            successful.Checked = CurrentAdventure.Successful;
            fatal.Checked = CurrentAdventure.Fatal;
            titleLbl.Text = "Adventure " + (adventureIndex + 1).ToString() + ": Journey to " + CurrentAdventure.Location.Title;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adventureIndex = (adventureIndex + 1) % AdventureOptions.Length;
            CurrentAdventure = AdventureOptions[adventureIndex];

            leaderTxtBx.Text = CurrentAdventure.LeaderName;
            companionTxtBx.Lines = CurrentAdventure.CompanionNames.Split(',');
            successful.Checked = CurrentAdventure.Successful;
            fatal.Checked = CurrentAdventure.Fatal;
            titleLbl.Text = "Adventure " + (adventureIndex + 1).ToString() + ": Journey to " + CurrentAdventure.Location.Title;
        }

        private void leaderTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void companionTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void successful_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fatal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
