﻿using System;
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

        private void searchIDBtn_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(idTxtBx.Text, out int result))
            {
                currentLocation = locationLogic.GetLocation(result);
                if (currentLocation != null)
                {
                    Display();
                    prevBtn.Visible = false;
                    nextBtn.Visible = false;
                } else
                {
                    MessageBox.Show("Location not found!", "Error 404");
                }

            } else
            {
                MessageBox.Show("ID must be numeric!", "Error");

            }

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
            deleteBtn.Visible = false;
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
        private void Reload()
        {
            locations = locationLogic.GetAllLocations();
            index = 0;
            currentLocation = locations.First();
            Display();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (TitleTxtBx.Text == "" ||
                raceTxtBx.Text == "" ||
                quadrantTxtBx.Text == "" ||
                regionTxtBx.Text == "")
            {
                MessageBox.Show("Please fill out all fields before submitting to the database!", "Invalid Data");

            }
            else if (raceTxtBx.Text.ToLower() != "elf" &&
                raceTxtBx.Text.ToLower() != "dwarf" &&
                raceTxtBx.Text.ToLower() != "wizard" &&
                raceTxtBx.Text.ToLower() != "hobbit" &&
                raceTxtBx.Text.ToLower() != "men"
                )
            {
                MessageBox.Show("Race must be set to 'elf', 'dwarf', 'hobbit', 'wizard', or 'men'!", "Invalid Data");
            }
            else
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
                    locationLogic.AddLocation(currentLocation);
                    MessageBox.Show("Successfully added a new Location", "Success!");

                    Reload();
                }
                else
                {
                    locationLogic.UpdateLocation();
                    MessageBox.Show("Successfully saved the Location.", "Success!");
                }

                newLocation = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(true);
            ChangeToEditMode(false);
            if (newLocation)
            {
                Reload();
            } else
            {
                TitleTxtBx.Text = currentLocation.Title;
                raceTxtBx.Text = currentLocation.InhabitantsPrimaryRace;
                quadrantTxtBx.Text = currentLocation.RelativeMapPosition;
                regionTxtBx.Text = currentLocation.Region;
                freeCheck.Checked = currentLocation.FreeLand;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
            prevBtn.Visible = true;
            nextBtn.Visible = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(true);
            ChangeToEditMode(false);
            AdventureLogic adventureLogic = new AdventureLogic();

            foreach (Adventure adventure in currentLocation.Adventures)
            {
                Adventure myAdventure = adventureLogic.GetAdventure(adventure.AdventureID);
                adventureLogic.DeleteAdventure(myAdventure);
            }

            locationLogic.DeleteLocation(currentLocation);
            MessageBox.Show("Location has been deleted", "Success");
            Reload();
        }
    }
}
