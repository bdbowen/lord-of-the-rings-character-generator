using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterGenerator
{
    public partial class PositionViewForm : Form
    {
        public PositionViewForm()
        {
            InitializeComponent();
        }

        public PositionViewForm(Role myRole, string caption, int number)
        {
            InitializeComponent();
            titleTxtBx.Text = myRole.Title;
            descTxtBx.Text = myRole.Description;
            raceTxtBx.Text = myRole.PrimaryRace;
            lengthTxtBx.Text = myRole.LenthOfOccupancy.ToString();
            subsTxtBx.Text = myRole.NumberOfSubordinates.ToString();
            supreme.Checked = myRole.SupremeRole;

            label1.Focus();
            //set title
            Name = caption;

            //set background image
            string path = Application.StartupPath + "\\..\\..\\..\\Media\\" + "posBackgroundOpt" + number.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(path);
            Size = BackgroundImage.Size;
        }
    }
}
