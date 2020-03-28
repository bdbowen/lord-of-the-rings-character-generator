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
    public partial class MainForm : Form
    {
        private PersonLogic personLogic = new PersonLogic();
        private ElfLogic elfLogic = new ElfLogic();
        private DwarfLogic dwarfLogic = new DwarfLogic();
        private HumanLogic humanLogic = new HumanLogic();
        private HobbitLogic hobbitLogic = new HobbitLogic();
        private WizardLogic wizardLogic = new WizardLogic();
        private Person person;
        
        private Elf elf;
        private Dwarf dwarf;
        private Hobbit hobbit;
        private Human human;
        private Wizard wizard;

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
                Random rand = new Random();
                elf = elfLogic.GenerateRandomElf(rand.Next(1, 7), rand.Next(1, 7), rand.Next(1, 7), rand);
                person = personLogic.GetPerson(elf.PersonID);
                
                //elf specific Attributes
                Attr1Lbl.Text = "Elf Type";
                Attr1TxtBx.Text = elf.ElfType;
                Attr1Lbl.Location = new Point(382, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new Point(625, 202);
                checkBox1.Location = new Point(625, 238);
                checkBox1.Text = "Elven Ring Bearer";
                checkBox1.Checked = elf.OwnsRingOfPower;
                checkBox1.Visible = true;
                checkBox2.Visible = false;

                mentalBtn.Visible = true;
                physicalBtn.Visible = true;
                magicBtn.Visible = true;
            }
            else if (isDwarfRadio.Checked)
            {
                Random rand = new Random();
                dwarf = dwarfLogic.GenerateRandomDwarf(rand.Next(1, 7), rand.Next(1, 7), rand);
                person = personLogic.GetPerson(dwarf.PersonID); 

                //elf specific Attributes
                Attr1Lbl.Text = "Dwarf Type";
                Attr1TxtBx.Text = dwarf.DwarfGroup;
                Attr1Lbl.Location = new Point(357, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new Point(625, 218);
                checkBox1.Visible = false;
                checkBox2.Visible = false;

                mentalBtn.Visible = true;
                physicalBtn.Visible = true;
                magicBtn.Visible = false;
            }
            else if (isWizardRadio.Checked)
            {
                Random rand = new Random();
                wizard = wizardLogic.GenerateRandomWizard(rand.Next(1, 7), rand.Next(1, 7), rand.Next(1, 7), rand);
                person = personLogic.GetPerson(wizard.PersonID);

                //elf specific Attributes
                Attr1Lbl.Text = "Primary Magic Type";
                Attr1TxtBx.Text = wizard.MagicType;
                Attr1Lbl.Location = new Point(291, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new Point(625, 218);
                checkBox1.Visible = false;
                checkBox2.Visible = false;

                mentalBtn.Visible = true;
                physicalBtn.Visible = true;
                magicBtn.Visible = true;
            }
            else if (isHumanRadio.Checked)
            {
                Random rand = new Random();
                human = humanLogic.GenerateRandomHuman(rand.Next(1, 7), rand.Next(1, 7), rand);
                person = personLogic.GetPerson(human.PersonID);

                //elf specific Attributes
                Attr1Lbl.Text = "Ancestral Line";
                Attr1TxtBx.Text = human.AncestralLine;
                Attr1Lbl.Location = new Point(333, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;
                
                isEvil.Location = new Point(625, 218);

                checkBox1.Visible = false;
                checkBox2.Visible = false;

                mentalBtn.Visible = true;
                physicalBtn.Visible = true;
                magicBtn.Visible = false;
            }
            else if (isHobbitRadio.Checked)
            {
                Random rand = new Random();
                hobbit = hobbitLogic.GenerateRandomHobbit(rand.Next(1, 7), rand);
                person = personLogic.GetPerson(hobbit.PersonID);

                //elf specific Attributes
                Attr1Lbl.Text = "Home Type";
                Attr1TxtBx.Text = hobbit.HomeType;
                Attr1Lbl.Location = new Point(363, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new Point(625, 184);
                checkBox1.Location = new Point(625, 218);
                checkBox2.Location = new Point(625, 253);
                checkBox1.Text = "The Ring Bearer";
                checkBox1.Checked = hobbit.OwnsOneRing;
                checkBox1.Visible = true;
                checkBox2.Text = "Adventurer";
                checkBox2.Checked = hobbit.IsAdventurer;
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
            LocationViewForm myForm = new LocationViewForm(person.Location, caption, number);
            myForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string caption = person.Name + "'s Position";
            PositionViewForm myForm = new PositionViewForm(person.Role, person.LengthOfRoleOccupancy, person.NumberOfSubordinates, caption, number);
            myForm.ShowDialog();
        }

        private void viewAdventures_Click(object sender, EventArgs e)
        {
            string caption = person.Name + "'s Adventures";
            AdventuresViewForm myForm = new AdventuresViewForm(person.Adventures.ToList(), caption, number);
            myForm.ShowDialog();
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

            isEvil.AutoCheck = true;
            checkBox1.AutoCheck = true;
            checkBox2.AutoCheck = true;

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

            isEvil.AutoCheck = false;
            checkBox1.AutoCheck = false;
            checkBox2.AutoCheck = false;

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
                Attr1TxtBx.Text = hobbit.HomeType;
                checkBox1.Checked = hobbit.OwnsOneRing;
                checkBox2.Checked = hobbit.IsAdventurer;

            }

            if (person.RaceType == "Elf")
            {
                Attr1TxtBx.Text = elf.ElfType;
                checkBox1.Checked = elf.OwnsRingOfPower;
            }

            if (person.RaceType == "Human")
            {
                Attr1TxtBx.Text = human.AncestralLine;
            }
            if (person.RaceType == "Dwarf")
            {
                Attr1TxtBx.Text = dwarf.DwarfGroup;
            }
            if (person.RaceType == "Wizard")
            {
                Attr1TxtBx.Text = wizard.MagicType;
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

            isEvil.AutoCheck = false;
            checkBox1.AutoCheck = false;
            checkBox2.AutoCheck = false;

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
            if (genderTxtBx.Text == "M" || genderTxtBx.Text == "F")
            {
                person.Gender = genderTxtBx.Text;
            } else
            {
                genderTxtBx.Text = person.Gender;
                MessageBox.Show("Gender must be a 'M' or 'F'! Tolkein's mythology only allows for two genders.", "Error!");
            }
            person.SkinComplexion = complexionTxtBx.Text;
            person.WeaponOfChoice = WoCTxtBx.Text;
            person.Evil = isEvil.Checked;

            if (person.RaceType == "Hobbit")
            {
                hobbit.HomeType = Attr1TxtBx.Text;
                hobbit.OwnsOneRing = checkBox1.Checked;
                hobbit.IsAdventurer = checkBox2.Checked;
                hobbitLogic.UpdateHobbit();
            }

            if (person.RaceType == "Elf")
            {
                elf.ElfType = Attr1TxtBx.Text;
                elf.OwnsRingOfPower = checkBox1.Checked;
                elfLogic.UpdateElf();
            }

            if (person.RaceType == "Human")
            {
                human.AncestralLine = Attr1TxtBx.Text;
                humanLogic.UpdateHuman();
            }
            if (person.RaceType == "Dwarf")
            {
                dwarf.DwarfGroup = Attr1TxtBx.Text;
                dwarfLogic.UpdateDwarf();
            }
            if (person.RaceType == "Wizard")
            {
                wizard.MagicType = Attr1TxtBx.Text;
                wizardLogic.UpdateWizard();
            }

            personLogic.UpdatePerson();
            //display buttons
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            editButton.Visible = true;
        }

        private void magicBtn_Click(object sender, EventArgs e)
        {
            string message = "Under Development!";
            string caption = "Error";

            //under development
            /*if (person.RaceType == "Elf")
            {
                caption = person.Name + "'s Magical Feats";
                AbilityViewForm myForm = new AbilityViewForm(temp.MagicalFeats, caption, number);
                myForm.ShowDialog();
            }

            if (person.RaceType == "Wizard")
            {
                caption = person.Name + "'s Magical Feats";
                AbilityViewForm myForm = new AbilityViewForm(temp.MagicalFeats, caption, number);
                myForm.ShowDialog();
            }*/
        }

        private void physicalBtn_Click(object sender, EventArgs e)
        {
            string message = "No Magical Abilities!";
            string caption = "Error";

            /*if (person.RaceType == "Elf")
            {
                Elf temp = (Elf)person;
               
                caption = temp.Name + "'s Physical Abilities";
                AbilityViewForm myForm = new AbilityViewForm(temp.PhysicalAbilities, caption, number);
                myForm.ShowDialog();

            }
            if (person.RaceType == "Hobbit")
            {
                Hobbit temp = (Hobbit)person;
                caption = temp.Name + "'s Physical Abilities";
                AbilityViewForm myForm = new AbilityViewForm(temp.PhysicalAbilities, caption, number);
                myForm.ShowDialog();

            }

            if (person.RaceType == "Human")
            {
                Human temp = (Human)person;

                caption = temp.Name + "'s Physical Abilities";
                AbilityViewForm myForm = new AbilityViewForm(temp.PhysicalAbilities, caption, number);
                myForm.ShowDialog();
            }
            if (person.RaceType == "Dwarf")
            {
                Dwarf temp = (Dwarf)person;
                caption = temp.Name + "'s Physical Abilities";
                AbilityViewForm myForm = new AbilityViewForm(temp.PhysicalAbilities, caption, number);
                myForm.ShowDialog();
            }
            if (person.RaceType == "Wizard")
            {
                Wizard temp = (Wizard)person;
                caption = temp.Name + "'s Physical Abilities";
                AbilityViewForm myForm = new AbilityViewForm(temp.PhysicalAbilities, caption, number);
                myForm.ShowDialog();
            }*/
        }

        private void mentalBtn_Click(object sender, EventArgs e)
        {
            string message = "No Mental Abilities!";
            string caption = person.Name + "'s Fields of Wisdom";

            /*if (person.RaceType == "Elf")
            {
                Elf temp = (Elf)person;
                AbilityViewForm myForm = new AbilityViewForm(temp.FieldsOfWisdom, caption, number);
                myForm.ShowDialog();

            }
            if (person.RaceType == "Human")
            {
                Human temp = (Human)person;
                AbilityViewForm myForm = new AbilityViewForm(temp.FieldsOfWisdom, caption, number);
                myForm.ShowDialog();

            }
            if (person.RaceType == "Dwarf")
            {
                Dwarf temp = (Dwarf)person;
                AbilityViewForm myForm = new AbilityViewForm(temp.FieldsOfWisdom, caption, number);
                myForm.ShowDialog();

            }
            if (person.RaceType == "Wizard")
            {
                Wizard temp = (Wizard)person;
                AbilityViewForm myForm = new AbilityViewForm(temp.FieldsOfWisdom, caption, number);
                myForm.ShowDialog();

            }*/
        }
    }
}