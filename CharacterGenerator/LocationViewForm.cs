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
    public partial class LocationViewForm : Form
    {
        public LocationViewForm()
        {
            InitializeComponent();
        }
        public LocationViewForm(Location myLocation, string caption, int number)
        {
            InitializeComponent();
            label1.Focus();
            TitleTxtBx.Text = myLocation.Title;
            raceTxtBx.Text = myLocation.InhabitantsPrimaryRace;
            quadrantTxtBx.Text = myLocation.RelativeMapPosition.ToString();
            regionTxtBx.Text = myLocation.Region;
            freeCheck.Checked = myLocation.FreeLand;
            //set the title of the form to the caption
            Text = caption;
            
            //set background image
            string path = Application.StartupPath + "\\..\\..\\..\\Media\\" + "locBackgroundOpt" + number.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(path);
            Size = BackgroundImage.Size;
        }

        private void freeCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
