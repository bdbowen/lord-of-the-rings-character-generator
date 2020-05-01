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
    public partial class LocationDataForm : Form
    {
        IEnumerable<Location> locations;
        LocationLogic locationLogic = new LocationLogic();
        Location currentLocation;
        int index;
        private bool newLocation = false;
        public LocationDataForm()
        {
            InitializeComponent();
        }
        public LocationDataForm(int number)
        {
            InitializeComponent();
            string path = Application.StartupPath + "\\..\\..\\..\\Media\\" + "backgroundOpt" + number.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(path);
            Size = BackgroundImage.Size;
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchIDBtn_Click(object sender, EventArgs e)
        {

        }

        private void LocationDataForm_Load(object sender, EventArgs e)
        {
            locations = locationLogic.GetAllLocations();
            index = 0;
            currentLocation = locations.First();
            Display();
        }

        private void Display()
        {
            label1.Focus();
            idTxtBx.Text = currentLocation.LocationID.ToString();
            TitleTxtBx.Text = currentLocation.Title;
            raceTxtBx.Text = currentLocation.InhabitantsPrimaryRace;
            quadrantTxtBx.Text = currentLocation.RelativeMapPosition.ToString();
            regionTxtBx.Text = currentLocation.Region;
            freeCheck.Checked = currentLocation.FreeLand;
        }

        private void ReadOnlyValues(bool value)
        {
            TitleTxtBx.ReadOnly = value;
            raceTxtBx.ReadOnly = value;
            quadrantTxtBx.ReadOnly = value;
            regionTxtBx.ReadOnly = value;
            freeCheck.AutoCheck = !value;
        }

        private void ChangeToEditMode(bool value)
        {
            EditBtn.Visible = !value;
            nextBtn.Visible = !value;
            prevBtn.Visible = !value;
            newBtn.Visible = !value;

            saveBtn.Visible = value;
            deleteBtn.Visible = value;
            cancelBtn.Visible = value;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(false);
            ChangeToEditMode(true);
            TitleTxtBx.Text = "";
            raceTxtBx.Text = "";
            quadrantTxtBx.Text = "";
            regionTxtBx.Text = "";
            freeCheck.Checked = false;
            newLocation = true;
            currentLocation = new Location();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(false);
            ChangeToEditMode(true);
        }
        private void Reload(int index)
        {
            locations = locationLogic.GetAllLocations();
            index = 0;
            currentLocation = locations.ElementAt(index);
            Display();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(true);
            ChangeToEditMode(false);
            currentLocation.Title = TitleTxtBx.Text;
            currentLocation.InhabitantsPrimaryRace = raceTxtBx.Text;
            currentLocation.RelativeMapPosition = quadrantTxtBx.Text;
            currentLocation.Region = regionTxtBx.Text;
            currentLocation.FreeLand = freeCheck.Checked;
            if (newLocation)
            {
                locationLogic.UpdateLocation();
            } else
            {
                locationLogic.AddLocation(currentLocation);
            }
            Reload(index);
            newLocation = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(true);
            ChangeToEditMode(false);
            TitleTxtBx.Text = currentLocation.Title;
            raceTxtBx.Text = currentLocation.InhabitantsPrimaryRace;
            quadrantTxtBx.Text = currentLocation.RelativeMapPosition;
            regionTxtBx.Text = currentLocation.Region;
            freeCheck.Checked = currentLocation.FreeLand;
            newLocation = false;
        }

        private void prevBtn_Click_1(object sender, EventArgs e)
        {
            index = (index + locations.Count() - 1) % locations.Count();
            currentLocation = locations.ElementAt(index);
            Display();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            index = (index + 1) % locations.Count();
            currentLocation = locations.ElementAt(index);
            Display();
        }
    }
}
