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
using System.IO;

namespace CharacterGenerator
{
    public partial class HomeForm : Form
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

        public HomeForm()
        {
            InitializeComponent();
        }
        public HomeForm(int picNumber)
        {
            InitializeComponent();
            Random rand = new Random();
            number = picNumber;
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
                elf = elfLogic.Generate(rand, rand.Next(1, 7), rand.Next(1, 7), rand.Next(1, 7));
                person = elf;
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
            }
            else if (isDwarfRadio.Checked)
            {
                Random rand = new Random();
                dwarf = dwarfLogic.Generate(rand, rand.Next(1, 7), rand.Next(1, 7));
                person = dwarf;
                //elf specific Attributes
                Attr1Lbl.Text = "Dwarf Type";
                Attr1TxtBx.Text = dwarf.DwarfGroup;
                Attr1Lbl.Location = new Point(357, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new Point(625, 218);
                checkBox1.Visible = false;
                checkBox2.Visible = false;
            }
            else if (isWizardRadio.Checked)
            {
                Random rand = new Random();
                wizard = wizardLogic.Generate(rand, rand.Next(1, 7), rand.Next(1, 7), rand.Next(1, 7));
                person = wizard;
                //elf specific Attributes
                Attr1Lbl.Text = "Primary Magic Type";
                Attr1TxtBx.Text = wizard.MagicType;
                Attr1Lbl.Location = new Point(291, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new Point(625, 218);
                checkBox1.Visible = false;
                checkBox2.Visible = false;
            }
            else if (isHumanRadio.Checked)
            {
                Random rand = new Random();
                human = humanLogic.Generate(rand, rand.Next(1, 7), rand.Next(1, 7));
                person = human;
                //elf specific Attributes
                Attr1Lbl.Text = "Ancestral Line";
                Attr1TxtBx.Text = human.AncestralLine;
                Attr1Lbl.Location = new Point(333, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;
                
                isEvil.Location = new Point(625, 218);

                checkBox1.Visible = false;
                checkBox2.Visible = false;
            }
            else if (isHobbitRadio.Checked)
            {
                Random rand = new Random();
                hobbit = hobbitLogic.Generate(rand, rand.Next(1, 7));
                person = hobbit;
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
            }
            else
            {
                MessageBox.Show("Please select one of the races!");
                return;
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
            exportBtn.Visible = true;
        }

        private void viewHome_Click(object sender, EventArgs e)
        {
            LocationLogic locationLogic = new LocationLogic();
            string caption = person.Name + "'s Hometown";
            LocationViewForm myForm = new LocationViewForm(locationLogic.GetLocation(person.HomeTownLocationID), caption, number);
            myForm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RoleLogic roleLogic = new RoleLogic();
            string caption = person.Name + "'s Position";
            PositionViewForm myForm = new PositionViewForm(roleLogic.GetRole(person.PositionRoleID), person.LengthOfRoleOccupancy, person.NumberOfSubordinates, caption, number);
            myForm.ShowDialog();
        }

        private void viewAdventures_Click(object sender, EventArgs e)
        {
            AdventureLogic adventureLogic = new AdventureLogic();
            string caption = person.Name + "'s Adventures";
            AdventuresViewForm myForm = new AdventuresViewForm(adventureLogic.GetAllAdventuresByPersonID(person.PersonID).ToList(), caption, number);
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
            exportBtn.Visible = false;
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
            exportBtn.Visible = true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (NametxtBx.Text == "" ||
                ageTxtBx.Text == "" ||
                hairTxtBx.Text == "" ||
                eyeTxtBx.Text == "" ||
                genderTxtBx.Text == "" ||
                complexionTxtBx.Text == "" ||
                WoCTxtBx.Text == "" ||
                Attr1TxtBx.Text == ""
                )
            {
                MessageBox.Show("Please fill out all fields before saving to the database!", "Invalid Data");
            }
            else
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
                }
                else
                {
                    ageTxtBx.Text = person.Age.ToString();
                    MessageBox.Show("Age must be a number! The previous age will be used.", "Error!");
                }
                person.HairColor = hairTxtBx.Text;
                person.EyeColor = eyeTxtBx.Text;
                if (genderTxtBx.Text == "M" || genderTxtBx.Text == "F")
                {
                    person.Gender = genderTxtBx.Text;
                }
                else
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

                //display buttons
                saveBtn.Visible = false;
                cancelBtn.Visible = false;
                editButton.Visible = true;
                exportBtn.Visible = true;
                MessageBox.Show("Changes have been saved", "Success");
            }

        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            string name = person.Name.Replace(",", "");
            name = name.Replace(" ", "_");
            saveFileDialog1.FileName = name;
            saveFileDialog1.DefaultExt = "txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                if (fileName != null)
                {
                    streamWriter = new StreamWriter(fileName);
                    try
                    {
                        //Personal Information
                        streamWriter.WriteLine("PERSONAL INFORMATION");
                        streamWriter.WriteLine("\tName: " + person.Name);
                        streamWriter.WriteLine("\tAge: " + string.Format("{0:n0}", person.Age));
                        string gender = person.Gender == "M" ? "Male" : person.Gender == "F" ? "Female" : "Invalid";
                        streamWriter.WriteLine("\tGender: " + gender);
                        string race = person.RaceType.First().ToString().ToUpper() + person.RaceType.Substring(1);
                        streamWriter.WriteLine("\tRace: " + race);
                        string evil = person.Evil ? "Yes" : "No";
                        streamWriter.WriteLine("\tEvil: " + evil);
                        streamWriter.WriteLine("\tWeapon of Choice: " + person.WeaponOfChoice);

                        streamWriter.WriteLine("\nPHYSICAL DESCRIPTION");
                        streamWriter.WriteLine("\tHair Color: " + person.HairColor);
                        streamWriter.WriteLine("\tEye Color: " + person.EyeColor);
                        streamWriter.WriteLine("\tSkin Complexion: " + person.SkinComplexion);

                        streamWriter.WriteLine("\n" + race.ToUpper() + " INFORMATION");
                        if (race == "Elf")
                        {
                            streamWriter.WriteLine("\tElf Type: " + elf.ElfType);
                            string ringBearer = elf.OwnsRingOfPower ? "Yes" : "No";
                            streamWriter.WriteLine("\tElven Ring Bearer: " + ringBearer);
                        }
                        else if (race == "Dwarf")
                        {
                            streamWriter.WriteLine("\tDwarf Type: " + dwarf.DwarfGroup);
                        }
                        else if (race == "Hobbit")
                        {
                            streamWriter.WriteLine("\tHome Type: " + hobbit.HomeType);
                            string ringBearer = hobbit.OwnsOneRing ? "Yes" : "No";
                            streamWriter.WriteLine("\tThe Ring Bearer: " + ringBearer);
                            string adventurer = hobbit.IsAdventurer ? "Yes" : "No";
                            streamWriter.WriteLine("\tAdventurer: " + adventurer);
                        }
                        else if (race == "Men")
                        {
                            streamWriter.WriteLine("\tAncestral Line: " + human.AncestralLine);
                        }
                        else if (race == "Wizard")
                        {
                            streamWriter.WriteLine("\tPrimary Magic Type: " + wizard.MagicType);
                        }
                        else
                        {
                            streamWriter.WriteLine("\tNo information on this race!");
                        }

                        streamWriter.WriteLine("\nHOME TOWN INFORMATION");
                        streamWriter.WriteLine("\tName: " + person.Location.Title);
                        streamWriter.WriteLine("\tRegion: " + person.Location.Region);
                        streamWriter.WriteLine("\tQuadrant of Map: " + person.Location.RelativeMapPosition);
                        string freeland = person.Location.FreeLand ? "Yes" : "No";
                        streamWriter.WriteLine("\tFree Land: " + freeland);

                        streamWriter.WriteLine("\nPOSITION INFORMATION");
                        streamWriter.WriteLine("\tTitle: " + person.Role.Title);
                        streamWriter.WriteLine("\tDescription: " + person.Role.Description);
                        streamWriter.WriteLine("\tLength of Occupancy: " + string.Format("{0:n0}", person.LengthOfRoleOccupancy) + " years");
                        string plural = person.Role.PrimaryRace == "Elf" ? "elves" : person.Role.PrimaryRace == "Dwarf" ? "dwarves" : person.Role.PrimaryRace == "Men" ? "men" : person.Role.PrimaryRace == "Wizard" ? "wizards" : person.Role.PrimaryRace == "Hobbit" ? "hobbits" : "people";
                        streamWriter.WriteLine("\tNumber of Suboordinates: " + string.Format("{0:n0}", person.NumberOfSubordinates) + " " + plural);
                        string supreme = person.Role.SupremeRole ? "Yes" : "No";
                        streamWriter.WriteLine("\tSupreme Role: " + supreme);

                        streamWriter.WriteLine("\nADVENTURES INFORMATION");
                        int number = 1;
                        foreach (Adventure adventure in person.Adventures)
                        {
                            streamWriter.WriteLine("\tADVENTURE " + number.ToString() + ": Journey To " + adventure.Location.Title);
                            streamWriter.WriteLine("\t\tLeader Name: " + adventure.LeaderName);
                            string separator = "\n\t\t\t";
                            streamWriter.WriteLine("\t\tCompanion Names: \n\t\t\t" + string.Join(separator, adventure.CompanionNames.Split(',')));
                            streamWriter.WriteLine("\t\tWhere To:");
                            streamWriter.WriteLine("\t\t\tName: " + adventure.Location.Title);
                            streamWriter.WriteLine("\t\t\tRegion: " + adventure.Location.Region);
                            streamWriter.WriteLine("\t\t\tQuadrant of Map: " + adventure.Location.RelativeMapPosition);
                            freeland = adventure.Location.FreeLand ? "Yes" : "No";
                            streamWriter.WriteLine("\t\t\tFree Land: " + freeland);
                            string successful = adventure.Successful ? "Yes" : "No";
                            streamWriter.WriteLine("\t\tSuccessful: " + successful);
                            string fatal = adventure.Fatal ? "Yes" : "No";
                            streamWriter.WriteLine("\t\tFatal: " + fatal);
                            streamWriter.WriteLine();
                            number++;
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    finally
                    {
                        streamWriter.Close();
                    }
                }
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Attr1TxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void Attr1Lbl_Click(object sender, EventArgs e)
        {

        }

        private void WoCTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void WoCLbl_Click(object sender, EventArgs e)
        {

        }

        private void isEvil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void genderTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderLbl_Click(object sender, EventArgs e)
        {

        }

        private void complexionTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void complexionLbl_Click(object sender, EventArgs e)
        {

        }

        private void eyeLbl_Click(object sender, EventArgs e)
        {

        }

        private void hairTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void hairLbl_Click(object sender, EventArgs e)
        {

        }

        private void ageTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageLbl_Click(object sender, EventArgs e)
        {

        }

        private void NametxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLbl_Click(object sender, EventArgs e)
        {

        }
    }
}