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
    public partial class RoleDataForm : Form
    {
        private IEnumerable<Role> roles;
        private Role currentRole;
        private int index;
        private RoleLogic roleLogic = new RoleLogic();
        private bool newRole = false;
        public RoleDataForm()
        {
            InitializeComponent();
        }

        public RoleDataForm(int number)
        {
            InitializeComponent();
            string path = Application.StartupPath + "\\..\\..\\..\\Media\\" + "backgroundOpt" + number.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(path);
            Size = BackgroundImage.Size;
        }
        private void newBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(false);
            ChangeToEditMode(true);
            deleteBtn.Visible = false;
            titleTxtBx.Text = "";
            raceTxtBx.Text = "";
            descTxtBx.Text = "";
            genderTxtBx.Text = "";
            supreme.Checked = false;
            newRole = true;
        }

        private void ReadOnlyValues(bool value)
        {
            titleTxtBx.ReadOnly = value;
            raceTxtBx.ReadOnly = value;
            descTxtBx.ReadOnly = value;
            genderTxtBx.ReadOnly = value;
            supreme.AutoCheck = !value;
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(false);
            ChangeToEditMode(true);
        }

        private void Reload()
        {
            roles = roleLogic.GetAllRoles();
            index = 0;
            currentRole = roles.First();
            Display();
        }

        private void RoleDataForm_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void Display()
        {
            label1.Focus();
            idTxtBx.Text = currentRole.RoleID.ToString();
            titleTxtBx.Text = currentRole.Title;
            raceTxtBx.Text = currentRole.PrimaryRace;
            descTxtBx.Text = currentRole.Description;
            genderTxtBx.Text = currentRole.GenderRole;
            supreme.Checked = currentRole.SupremeRole;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (titleTxtBx.Text == "" ||
                raceTxtBx.Text == "" ||
                descTxtBx.Text == "" ||
                genderTxtBx.Text == "")
            {
                MessageBox.Show("Please fill out all fields before submitting to the database!", "Invalid Data");

            } else if (raceTxtBx.Text.ToLower() != "elf" &&
                raceTxtBx.Text.ToLower() != "dwarf" &&
                raceTxtBx.Text.ToLower() != "wizard" &&
                raceTxtBx.Text.ToLower() != "hobbit" &&
                raceTxtBx.Text.ToLower() != "men"
                )
            {
                MessageBox.Show("Race must be set to 'elf', 'dwarf', 'hobbit', 'wizard', or 'men'!", "Invalid Data");
            }
            else if (genderTxtBx.Text.ToLower() != "m" && genderTxtBx.Text.ToLower() != "f")
            {
                MessageBox.Show("Gender must be set to 'M', or 'F'", "Invalid Data");
            }
            else
            {
                ReadOnlyValues(true);
                ChangeToEditMode(false);
                currentRole.Title = titleTxtBx.Text;
                currentRole.PrimaryRace = raceTxtBx.Text.ToLower();
                currentRole.Description = descTxtBx.Text;
                currentRole.GenderRole = genderTxtBx.Text;
                currentRole.SupremeRole = supreme.Checked;
                if (newRole)
                {
                    roleLogic.AddRole(currentRole);
                    MessageBox.Show("Successfully added a new Role.", "Success!");
                    Reload();
                }
                else
                {
                    roleLogic.UpdateRole();
                    MessageBox.Show("Successfully saved the Role.", "Success!");
                }

                newRole = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(true);
            ChangeToEditMode(false);
            if (newRole)
            {
                Reload();
            }
            else
            {
                titleTxtBx.Text = currentRole.Title;
                raceTxtBx.Text = currentRole.PrimaryRace;
                descTxtBx.Text = currentRole.Description;
                genderTxtBx.Text = currentRole.GenderRole;
                supreme.Checked = currentRole.SupremeRole;
            }
            newRole = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            ReadOnlyValues(true);
            ChangeToEditMode(false);
            roleLogic.DeleteRole(currentRole);
            MessageBox.Show("Role has been deleted", "Success");
            Reload();
        }

        private void searchIDBtn_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(idTxtBx.Text, out int result))
            {
                currentRole = roleLogic.GetRole(result);
                if (currentRole != null)
                {
                    Display();
                    prevBtn.Visible = false;
                    nextBtn.Visible = false;
                }
                else
                {
                    MessageBox.Show("Role not found!", "Error 404");
                }

            }
            else
            {
                MessageBox.Show("ID must be numeric!", "Error");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevBtn.Visible = true;
            nextBtn.Visible = true;
            Reload();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            index = (index + 1) % roles.Count();
            currentRole = roles.ElementAt(index);
            Display();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            index = (index + roles.Count() - 1) % roles.Count();
            currentRole = roles.ElementAt(index);
            Display();
        }
    }
}
