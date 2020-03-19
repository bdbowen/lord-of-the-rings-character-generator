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
        private int number;
        public MainForm()
        {
            InitializeComponent();
            Random rand = new Random();
            number = rand.Next(1, 5);
            //set background image
            string path = Application.StartupPath + "\\..\\..\\..\\Media\\" + "backgroundOpt" + number.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(path);
            Size = BackgroundImage.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isElfRadio.Checked)
            {
                person = new Elf();
                Elf temp = (Elf)person;
                
                //elf specific Attributes
                Attr1Lbl.Text = "Elf Type";
                Attr1TxtBx.Text = temp.ElfType;
                Attr1Lbl.Location = new System.Drawing.Point(382, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new System.Drawing.Point(625, 202);
                checkBox1.Location = new System.Drawing.Point(625, 238);
                checkBox1.Text = "Elven Ring Bearer";
                checkBox1.Checked = temp.OwnsRingOfPower;
                checkBox1.Visible = true;
                checkBox2.Visible = false;

                mentalBtn.Visible = true;
                physicalBtn.Visible = true;
                magicBtn.Visible = true;
            }
            else if (isDwarfRadio.Checked)
            {
                person = new Dwarf();
                Dwarf temp = (Dwarf)person;

                //elf specific Attributes
                Attr1Lbl.Text = "Dwarf Type";
                Attr1TxtBx.Text = temp.DwarfGroup;
                Attr1Lbl.Location = new System.Drawing.Point(357, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new System.Drawing.Point(625, 218);
                checkBox1.Visible = false;
                checkBox2.Visible = false;

                mentalBtn.Visible = true;
                physicalBtn.Visible = true;
                magicBtn.Visible = false;
            }
            else if (isWizardRadio.Checked)
            {
                person = new Wizard();

                Wizard temp = (Wizard)person;

                //elf specific Attributes
                Attr1Lbl.Text = "Primary Magic Type";
                Attr1TxtBx.Text = temp.MagicType;
                Attr1Lbl.Location = new System.Drawing.Point(291, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new System.Drawing.Point(625, 218);
                checkBox1.Visible = false;
                checkBox2.Visible = false;

                mentalBtn.Visible = true;
                physicalBtn.Visible = true;
                magicBtn.Visible = true;
            }
            else if (isHumanRadio.Checked)
            {
                person = new Human();
                Human temp = (Human)person;

                //elf specific Attributes
                Attr1Lbl.Text = "Ancestral Line";
                Attr1TxtBx.Text = temp.AncestralLine;
                Attr1Lbl.Location = new System.Drawing.Point(333, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;
                
                isEvil.Location = new System.Drawing.Point(625, 218);

                checkBox1.Visible = false;
                checkBox2.Visible = false;

                mentalBtn.Visible = true;
                physicalBtn.Visible = true;
                magicBtn.Visible = false;
            }
            else if (isHobbitRadio.Checked)
            {
                person = new Hobbit();

                Hobbit temp = (Hobbit)person;

                //elf specific Attributes
                Attr1Lbl.Text = "Home Type";
                Attr1TxtBx.Text = temp.HomeType;
                Attr1Lbl.Location = new System.Drawing.Point(363, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new System.Drawing.Point(625, 184);
                checkBox1.Location = new System.Drawing.Point(625, 218);
                checkBox2.Location = new System.Drawing.Point(625, 253);
                checkBox1.Text = "The Ring Bearer";
                checkBox1.Checked = temp.OwnsOneRing;
                checkBox1.Visible = true;
                checkBox2.Text = "Adventurer";
                checkBox2.Checked = temp.IsAdventurer;
                checkBox2.Visible = true;

                mentalBtn.Visible = false;
                physicalBtn.Visible = true;
                magicBtn.Visible = false;
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

            editButton.Visible = true;
        }

        private void viewHome_Click(object sender, EventArgs e)
        {
            string caption = person.Name + "'s Hometown";
            LocationViewForm myForm = new LocationViewForm(person.HomeTown, caption, number);
            myForm.ShowDialog();
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

        private void eyeTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //make all fields editable
            NametxtBx.ReadOnly = false;
            ageTxtBx.ReadOnly = false;
            hairTxtBx.ReadOnly = false;
            eyeTxtBx.ReadOnly = false;
            genderTxtBx.ReadOnly = false;
            complexionTxtBx.ReadOnly = false;
            WoCTxtBx.ReadOnly = false;
            Attr1TxtBx.ReadOnly = false;

            saveBtn.Visible = true;
            cancelBtn.Visible = true;
            editButton.Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //make all fields read only
            NametxtBx.ReadOnly = true;
            ageTxtBx.ReadOnly = true;
            hairTxtBx.ReadOnly = true;
            eyeTxtBx.ReadOnly = true;
            genderTxtBx.ReadOnly = true;
            complexionTxtBx.ReadOnly = true;
            WoCTxtBx.ReadOnly = true;
            Attr1TxtBx.ReadOnly = true;

            NametxtBx.Text = person.Name;
            ageTxtBx.Text = person.Age.ToString();
            hairTxtBx.Text = person.HairColor;
            eyeTxtBx.Text = person.EyeColor;
            genderTxtBx.Text = person.Gender;
            complexionTxtBx.Text = person.SkinComplexion;
            WoCTxtBx.Text = person.WeaponOfChoice;
            isEvil.Checked = person.Evil;
            
            if(person.RaceType == "Hobbit")
            {
                Hobbit temp = (Hobbit)person;
                Attr1TxtBx.Text = temp.HomeType;
                checkBox1.Checked = temp.OwnsOneRing;
                checkBox2.Checked = temp.IsAdventurer;

            }

            if (person.RaceType == "Elf")
            {
                Elf temp = (Elf)person;
                Attr1TxtBx.Text = temp.ElfType;
                checkBox1.Checked = temp.OwnsRingOfPower;
            }

            if (person.RaceType == "Human")
            {
                Human temp = (Human)person;
                Attr1TxtBx.Text = temp.AncestralLine;
            }
            if (person.RaceType == "Dwarf")
            {
                Dwarf temp = (Dwarf)person;
                Attr1TxtBx.Text = temp.DwarfGroup;
            }
            if (person.RaceType == "Wizard")
            {
                Wizard temp = (Wizard)person;
                Attr1TxtBx.Text = temp.MagicType;
            }
            //display buttons
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            editButton.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int result;
            //make all fields editable
            NametxtBx.ReadOnly = true;
            ageTxtBx.ReadOnly = true;
            hairTxtBx.ReadOnly = true;
            eyeTxtBx.ReadOnly = true;
            genderTxtBx.ReadOnly = true;
            complexionTxtBx.ReadOnly = true;
            WoCTxtBx.ReadOnly = true;
            Attr1TxtBx.ReadOnly = true;

            person.Name = NametxtBx.Text;

            if (int.TryParse(ageTxtBx.Text, out result))
            {
                person.Age = result;
            } else
            {
                ageTxtBx.Text = person.Age.ToString();
                MessageBox.Show("Age must be a number! The previous age will be used.", "Error!");
            }
            person.HairColor = hairTxtBx.Text;
            person.EyeColor = eyeTxtBx.Text;
            if (genderTxtBx.Text.ToLower() == "male" || genderTxtBx.Text.ToLower() == "female")
            {
                person.Gender = genderTxtBx.Text;
            } else
            {
                genderTxtBx.Text = person.Gender;
                MessageBox.Show("Gender must be a 'male' or 'female'! Tolkein's mythology only allows for two genders.", "Error!");
            }
            person.SkinComplexion = complexionTxtBx.Text;
            person.WeaponOfChoice = WoCTxtBx.Text;
            person.Evil = isEvil.Checked;

            if (person.RaceType == "Hobbit")
            {
                Hobbit temp = (Hobbit)person;
                temp.HomeType = Attr1TxtBx.Text;
                temp.OwnsOneRing = checkBox1.Checked;
                temp.IsAdventurer = checkBox2.Checked;

            }

            if (person.RaceType == "Elf")
            {
                Elf temp = (Elf)person;
                temp.ElfType = Attr1TxtBx.Text;
                temp.OwnsRingOfPower = checkBox1.Checked;
            }

            if (person.RaceType == "Human")
            {
                Human temp = (Human)person;
                temp.AncestralLine = Attr1TxtBx.Text;
            }
            if (person.RaceType == "Dwarf")
            {
                Dwarf temp = (Dwarf)person;
                temp.DwarfGroup = Attr1TxtBx.Text;
            }
            if (person.RaceType == "Wizard")
            {
                Wizard temp = (Wizard)person;
                temp.MagicType = Attr1TxtBx.Text;
            }
            //display buttons
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            editButton.Visible = true;
        }

        private void magicBtn_Click(object sender, EventArgs e)
        {
            string message = "No Magical Abilities!";
            string caption = "Error";

            if (person.RaceType == "Elf")
            {
                Elf temp = (Elf)person;
                message = "";
                foreach (Magical ability in temp.MagicalFeats)
                {
                    message += ability.ToString() + "\n\n";
                }
                caption = temp.Name + "'s Magical Feats";
                
            }

            if (person.RaceType == "Wizard")
            {
                Wizard temp = (Wizard)person;
                message = "";
                foreach (Magical ability in temp.MagicalFeats)
                {
                    message += ability.ToString() + "\n";
                }
                caption = temp.Name + "'s Magical Feats";
            }

            MessageBox.Show(message, caption);
        }

        private void physicalBtn_Click(object sender, EventArgs e)
        {
            string message = "No Magical Abilities!";
            string caption = "Error";

            if (person.RaceType == "Elf")
            {
                Elf temp = (Elf)person;
                message = "";
                foreach (Physical ability in temp.PhysicalAbilities)
                {
                    message += ability.ToString() + "\n\n";
                }
                caption = temp.Name + "'s Physical Abilities";

            }
            if (person.RaceType == "Hobbit")
            {
                Hobbit temp = (Hobbit)person;
                message = "";
                foreach (Physical ability in temp.PhysicalAbilities)
                {
                    message += ability.ToString() + "\n\n";
                }
                caption = temp.Name + "'s Physical Abilities";

            }

            if (person.RaceType == "Human")
            {
                Human temp = (Human)person;
                message = "";
                foreach (Physical ability in temp.PhysicalAbilities)
                {
                    message += ability.ToString() + "\n\n";
                }
                caption = temp.Name + "'s Physical Abilities";
            }
            if (person.RaceType == "Dwarf")
            {
                Dwarf temp = (Dwarf)person;
                message = "";
                foreach (Physical ability in temp.PhysicalAbilities)
                {
                    message += ability.ToString() + "\n\n";
                }
                caption = temp.Name + "'s Physical Abilities";
            }
            if (person.RaceType == "Wizard")
            {
                Wizard temp = (Wizard)person;
                message = "";
                foreach (Physical ability in temp.PhysicalAbilities)
                {
                    message += ability.ToString() + "\n\n";
                }
                caption = temp.Name + "'s Physical Abilities";
            }

            MessageBox.Show(message, caption);
        }

        private void mentalBtn_Click(object sender, EventArgs e)
        {
            string message = "No Mental Abilities!";
            string caption = person.Name + "'s Fields of Wisdom";

            if (person.RaceType == "Elf")
            {
                Elf temp = (Elf)person;
                message = "";
                foreach (Mental ability in temp.FieldsOfWisdom)
                {
                    message += ability.ToString() + "\n\n";
                }

            }
            if (person.RaceType == "Human")
            {
                Human temp = (Human)person;
                message = "";
                foreach (Mental ability in temp.FieldsOfWisdom)
                {
                    message += ability.ToString() + "\n\n";
                }

            }
            if (person.RaceType == "Dwarf")
            {
                Dwarf temp = (Dwarf)person;
                message = "";
                foreach (Mental ability in temp.FieldsOfWisdom)
                {
                    message += ability.ToString() + "\n\n";
                }

            }
            if (person.RaceType == "Wizard")
            {
                Wizard temp = (Wizard)person;
                message = "";
                foreach (Mental ability in temp.FieldsOfWisdom)
                {
                    message += ability.ToString() + "\n\n";
                }
            
            }

            MessageBox.Show(message, caption);
        }
    }
}