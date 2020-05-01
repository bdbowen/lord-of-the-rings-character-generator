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
    public partial class AdventureHistoryForm : Form
    {
        Adventure currentAdventure;
        AdventureLogic adventureLogic = new AdventureLogic();
        IEnumerable<Adventure> adventures;
        int number;
        int index;
        public AdventureHistoryForm()
        {
            InitializeComponent();
        }
        public AdventureHistoryForm(int myNumber)
        {
            InitializeComponent();
            number = myNumber;
            string path = Application.StartupPath + "\\..\\..\\..\\Media\\" + "backgroundOpt" + number.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(path);
            Size = BackgroundImage.Size;
        }

        private void viewLocationBtn_Click(object sender, EventArgs e)
        {
            string caption = "Destination Details";
            LocationViewForm myForm = new LocationViewForm(currentAdventure.Location, caption, number);
            myForm.ShowDialog();
        }



        private void newBtn_Click(object sender, EventArgs e)
        {
            PersonLogic personLogic = new PersonLogic();
            LocationLogic locationLogic = new LocationLogic();
            Random rand = new Random();
            currentAdventure = adventureLogic.Generate(rand.Next(1,20), personLogic.GetRandomID(rand), rand);
            currentAdventure.Person = personLogic.GetPerson(currentAdventure.MainPersonID);
            currentAdventure.Location = locationLogic.GetLocation(currentAdventure.WhereToLocationID);
            Display();
        }

        private void ReadOnlyValues(bool value)
        {
            personIDTxtBx.ReadOnly = value;
            leaderTxtBx.ReadOnly = value;
            companionTxtBx.ReadOnly = value;
            fatal.AutoCheck = !value;
            successful.AutoCheck = !value;
        }

        private void ChangeToEditMode(bool value)
        {
            editBtn.Visible = !value;
            nextBtn.Visible = !value;
            prevBtn.Visible = !value;
            newBtn.Visible = !value;
            viewLocationBtn.Visible = !value;

            saveBtn.Visible = value;
            deleteBtn.Visible = value;
            cancelBtn.Visible = value;
        }

        private void Reload()
        {
            adventures = adventureLogic.GetAllAdventures();
            index = 0;
            currentAdventure = adventures.First();
            Display();
        }
        private void Display()
        {
            personIDTxtBx.Text = currentAdventure.MainPersonID.ToString();
            advIDTxtBx.Text = currentAdventure.AdventureID.ToString();
            titleLbl.Text = "Journey to " + currentAdventure.Location.Title;
            personNameLbl.Text = currentAdventure.Person.Name;
            
            leaderTxtBx.Text = currentAdventure.LeaderName;
            companionTxtBx.Lines = currentAdventure.CompanionNames.Split(',');
            fatal.Checked = currentAdventure.Fatal;
            successful.Checked = currentAdventure.Successful;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(false);
            ChangeToEditMode(true);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(true);
            ChangeToEditMode(false);
            Display();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(true);
            ChangeToEditMode(false);
            adventureLogic.DeleteAdventure(currentAdventure);
            MessageBox.Show("Adventure has been deleted", "Success");
            Reload();
        }

        private void AdventureHistoryForm_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            PersonLogic personLogic = new PersonLogic();
            if (personIDTxtBx.Text == "" ||
                leaderTxtBx.Text == "" ||
                companionTxtBx.Lines.Length == 0) {
                MessageBox.Show("Please fill out all fields before saving to the database", "Invalid Data");
            } else if (!Int32.TryParse(personIDTxtBx.Text, out int result)) {
                MessageBox.Show("ID must be a number!", "Invalid Data");
            }
            else if (personLogic.GetPerson(result) == null) {
                MessageBox.Show("Please select a valid person ID", "Invalid Data");
            } else
            {
                ReadOnlyValues(true);
                ChangeToEditMode(false);
                currentAdventure.MainPersonID = result;
                currentAdventure.LeaderName = leaderTxtBx.Text;
                currentAdventure.CompanionNames = string.Join(",", companionTxtBx.Lines.ToArray());
                currentAdventure.Fatal = fatal.Checked;
                currentAdventure.Successful = successful.Checked;

                adventureLogic.UpdateAdventure();
                MessageBox.Show("Successfully saved the Role.", "Success!");
            }
                    
        }

        private void personIDTxtBx_TextChanged(object sender, EventArgs e)
        {
            PersonLogic personLogic = new PersonLogic();
            if(Int32.TryParse(personIDTxtBx.Text, out int result))
            {
                Person person = personLogic.GetPerson(result);

                if (person == null)
                {
                    personNameLbl.Text = "INVALID";
                } else
                {
                    personNameLbl.Text = person.Name;
                }
            } else
            {
                MessageBox.Show("This field must be numbers only!", "Invalid Data");
            }
        }

        private void searchById_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(advIDTxtBx.Text, out int result))
            {
                currentAdventure = adventureLogic.GetAdventure(result);
                if (currentAdventure != null)
                {
                    Display();
                    prevBtn.Visible = false;
                    nextBtn.Visible = false;
                }
                else
                {
                    MessageBox.Show("Adventure not found!", "Error 404");
                }

            }
            else
            {
                MessageBox.Show("ID must be numeric!", "Error");

            }
        }

        private void findall_Click(object sender, EventArgs e)
        {
            Reload();
            prevBtn.Visible = true;
            nextBtn.Visible = true;
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            index = (index + adventures.Count() - 1) % adventures.Count();
            currentAdventure = adventures.ElementAt(index);
            Display();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            index = (index + 1) % adventures.Count();
            currentAdventure = adventures.ElementAt(index);
            Display();
        }
    }
}
