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
    public partial class MainForm : Form
    {
        private Person person;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isElfRadio.Checked)
            {
                person = new Elf();
            }
            else if (isDwarfRadio.Checked)
            {
                person = new Dwarf();
            }
            else if (isWizardRadio.Checked)
            {
                person = new Wizard();
            }
            else if (isHumanRadio.Checked)
            {
                person = new Human();
            }
            else if (isHobbitRadio.Checked)
            {
                person = new Hobbit();
            }
            else
            {
                MessageBox.Show("Please select one of the races!");
            }
            //show fields
            NametxtBx.Text = person.Name;
            nameLbl.Visible = true;
            NametxtBx.Visible = true;

            ageTxtBx.Text = person.Age.ToString();
            ageLbl.Visible = true;
            ageTxtBx.Visible = true;

            genderTxtBx.Text = person.Gender;
            genderLbl.Visible = true;
            genderTxtBx.Visible = true;

            hairTxtBx.Text = person.HairColor;
            hairLbl.Visible = true;
            hairTxtBx.Visible = true;

            eyeTxtBx.Text = person.EyeColor;
            eyeLbl.Visible = true;
            eyeTxtBx.Visible = true;

            complexionTxtBx.Text = person.SkinComplexion;
            complexionLbl.Visible = true;
            complexionTxtBx.Visible = true;

            WoCTxtBx.Text = person.WeaponOfChoice;
            WoCLbl.Visible = true;
            WoCTxtBx.Visible = true;

            isEvil.Checked = person.Evil;
            isEvil.Visible = true;

            viewHome.Visible = true;
            viewPosition.Visible = true;
            viewAdventures.Visible = true;
        }

        private void viewHome_Click(object sender, EventArgs e)
        {
            string caption = person.Name + "'s Hometown";
            MessageBox.Show(person.HomeTown.ToString(), caption);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string caption = person.Name + "'s Position";
            MessageBox.Show(person.Position.ToString(), caption);
        }

        private void viewAdventures_Click(object sender, EventArgs e)
        {
            string adventures = "";
            foreach (Adventure adven in person.Adventures)
            {
                adventures += adven + "\n\n";
            }
            string caption = person.Name + "'s Adventures";

            MessageBox.Show(adventures, caption);
        }
    }
}