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
using System.IO;

namespace CharacterGenerator
{
    
    public partial class HistoryForm : Form
    {
        private ElfLogic elfLogic = new ElfLogic();
        private DwarfLogic dwarfLogic = new DwarfLogic();
        private WizardLogic wizardLogic = new WizardLogic();
        private HumanLogic humanLogic = new HumanLogic();
        private HobbitLogic hobbitLogic = new HobbitLogic();
        private PersonLogic personLogic = new PersonLogic();

        private IEnumerable<Elf> elfHistories;
        private IEnumerable<Dwarf> dwarfHistories;
        private IEnumerable<Human> humanHistories;
        private IEnumerable<Wizard> wizardHistories;
        private IEnumerable<Hobbit> hobbitHistories;

        private Elf currentElf;
        private Dwarf currentDwarf;
        private Wizard currentWizard;
        private Hobbit currentHobbit;
        private Human currentHuman;
        private int index;
        private int number;
        private string currentRace;
        public HistoryForm()
        {
            InitializeComponent();
        }

        public HistoryForm(string raceType, int picNumber)
        {
            InitializeComponent();
            if (raceType == "elf")
            {
                isElfRadio.Checked = true;
            }
            if (raceType == "dwarf")
            {
                isDwarfRadio.Checked = true;
            }
            if (raceType == "wizard")
            {
                isWizardRadio.Checked = true;
            }
            if (raceType == "hobbit")
            {
                isHobbitRadio.Checked = true;
            }
            if (raceType == "human")
            {
                isHumanRadio.Checked = true;
            }

            //set background image
            number = picNumber;
            string path = Application.StartupPath + "\\..\\..\\..\\Media\\" + "backgroundOpt" + picNumber.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(path);
            Size = BackgroundImage.Size;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (currentRace == "elf")
            {
                index = (index + 1) % elfHistories.Count();
                currentElf = elfHistories.ElementAt(index);
            }
            if (currentRace == "dwarf")
            {
                index = (index + 1) % dwarfHistories.Count();
                currentDwarf = dwarfHistories.ElementAt(index);
            }
            if (currentRace == "wizard")
            {
                index = (index + 1) % wizardHistories.Count();
                currentWizard = wizardHistories.ElementAt(index);
            }
            if (currentRace == "human")
            {
                index = (index + 1) % humanHistories.Count();
                currentHuman = humanHistories.ElementAt(index);
            }
            if (currentRace == "hobbit")
            {
                index = (index + 1) % hobbitHistories.Count();
                currentHobbit = hobbitHistories.ElementAt(index);
            }
            Display();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            SearchRace();           
        }
        public void Display()
        {
            Person person;
            titleLbl.Text = currentRace.First().ToString().ToUpper() + currentRace.Substring(1) + " Generation History";
            if (currentRace == "elf")
            {
                person = currentElf;
                //elf specific Attributes
                Attr1Lbl.Text = "Elf Type";
                Attr1TxtBx.Text = currentElf.ElfType;
                Attr1Lbl.Location = new Point(382, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new Point(625, 202);
                checkBox1.Location = new Point(625, 238);
                checkBox1.Text = "Elven Ring Bearer";
                checkBox1.Checked = currentElf.OwnsRingOfPower;
                checkBox1.Visible = true;
                checkBox2.Visible = false;

                mentalBtn.Visible = true;
                physicalBtn.Visible = true;
                magicBtn.Visible = true;
            }
            else if (currentRace == "dwarf")
            {
                person= currentDwarf;

                Attr1Lbl.Text = "Dwarf Type";
                Attr1TxtBx.Text = currentDwarf.DwarfGroup;
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
            else if (currentRace == "wizard")
            {
                person = currentWizard;

                Attr1Lbl.Text = "Primary Magic Type";
                Attr1TxtBx.Text = currentWizard.MagicType;
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
            else if (currentRace == "human")
            {
                person = currentHuman;

                //elf specific Attributes
                Attr1Lbl.Text = "Ancestral Line";
                Attr1TxtBx.Text = currentHuman.AncestralLine;
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
            else if (currentRace == "hobbit")
            {
                person = currentHobbit;

                //elf specific Attributes
                Attr1Lbl.Text = "Home Type";
                Attr1TxtBx.Text = currentHobbit.HomeType;
                Attr1Lbl.Location = new Point(363, 297);
                Attr1TxtBx.Visible = true;
                Attr1Lbl.Visible = true;

                isEvil.Location = new Point(625, 184);
                checkBox1.Location = new Point(625, 218);
                checkBox2.Location = new Point(625, 253);
                checkBox1.Text = "The Ring Bearer";
                checkBox1.Checked = currentHobbit.OwnsOneRing;
                checkBox1.Visible = true;
                checkBox2.Text = "Adventurer";
                checkBox2.Checked = currentHobbit.IsAdventurer;
                checkBox2.Visible = true;

                mentalBtn.Visible = false;
                physicalBtn.Visible = true;
                magicBtn.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select one of the races!", "Error");
                return;
            }
            //show fields
            NametxtBx.Text = person.Name;
            nameLbl.Visible = true;
            NametxtBx.Visible = true;

            idTxtBx.Text = person.PersonID.ToString();

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

            exportBtn.Visible = true;
            editBtn.Visible = true;
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if (currentRace == "elf")
            {
                index = (index + elfHistories.Count() - 1) % elfHistories.Count();
                currentElf = elfHistories.ElementAt(index);
            }
            if (currentRace == "dwarf")
            {
                index = (index + dwarfHistories.Count() - 1) % dwarfHistories.Count();
                currentDwarf = dwarfHistories.ElementAt(index);
            }
            if (currentRace == "wizard")
            {
                index = (index + wizardHistories.Count() - 1) % wizardHistories.Count();
                currentWizard = wizardHistories.ElementAt(index);
            }
            if (currentRace == "human")
            {
                index = (index + humanHistories.Count() - 1) % humanHistories.Count();
                currentHuman = humanHistories.ElementAt(index);
            }
            if (currentRace == "hobbit")
            {
                index = (index + hobbitHistories.Count() - 1) % hobbitHistories.Count();
                currentHobbit = hobbitHistories.ElementAt(index);
            }
            Display();
        }

        private void SearchRace()
        {
            if (isElfRadio.Checked)
            {
                elfHistories = elfLogic.GetAllElves();
                index = 0;
                currentRace = "elf";
                currentElf = elfHistories.First();
                Display();
            }
            else if (isDwarfRadio.Checked)
            {
                dwarfHistories = dwarfLogic.GetAllDwarves();
                index = 0;
                currentRace = "dwarf";
                currentDwarf = dwarfHistories.First();
                Display();

            }
            else if (isWizardRadio.Checked)
            {
                wizardHistories = wizardLogic.GetAllWizards();
                index = 0;
                currentRace = "wizard";
                currentWizard = wizardHistories.First();
                Display();
            }
            else if (isHumanRadio.Checked)
            {
                humanHistories = humanLogic.GetAllHumans();
                index = 0;
                currentRace = "human";
                currentHuman = humanHistories.First();
                Display();
            }
            else if (isHobbitRadio.Checked)
            {
                hobbitHistories = hobbitLogic.GetAllHobbits();
                index = 0;
                currentRace = "hobbit";
                currentHobbit = hobbitHistories.First();
                Display();
            }
            else
            {
                MessageBox.Show("Please select one of the races!", "Error");
                return;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchRaceBtn_Click(object sender, EventArgs e)
        {
            PrevBtn.Visible = true;
            NextBtn.Visible = true;
            SearchRace();
        }

        private void searchIDBtn_Click(object sender, EventArgs e)
        {
            PrevBtn.Visible = false;
            NextBtn.Visible = false;

            if (Int32.TryParse(idTxtBx.Text, out int result))
            {
                Person person = personLogic.GetPerson(result);
                if (person == null)
                {
                    MessageBox.Show("Person with ID was not found", "404: Not Found");
                } else
                {
                    currentRace = person.RaceType.ToLower();

                    if (person.RaceType == "elf")
                    {
                        currentElf = elfLogic.GetElf(result);
                    }
                    if (person.RaceType == "dwarf")
                    {
                        currentDwarf = dwarfLogic.GetDwarf(result);
                    }
                    if (person.RaceType == "human")
                    {
                        currentHuman = humanLogic.GetHuman(result);
                    }
                    if (person.RaceType == "wizard")
                    {
                        currentWizard = wizardLogic.GetWizard(result);
                    }
                    if (person.RaceType.ToLower() == "hobbit")
                    {
                        currentHobbit = hobbitLogic.GetHobbit(result);
                    }
                    Display();
                    }
            } else
            {
                MessageBox.Show("ID must be a number!", "Error");
            }
            
        }

        private Person ReturnPerson()
        {
            if (currentRace == "elf")
            {
                return currentElf;
            }
            if (currentRace == "dwarf")
            {
                return currentDwarf;
            } 
            if (currentRace == "wizard")
            {
                return currentWizard;
            } 
            if (currentRace == "human")
            {
                return currentHuman;
            }
            if (currentRace == "hobbit")
            {
                return currentHobbit;
            }
            return null;
        }
        private void viewHome_Click(object sender, EventArgs e)
        {
            Person person = ReturnPerson();
            string caption = person.Name + "'s Hometown";
            LocationViewForm myForm = new LocationViewForm(person.Location, caption, number);
            myForm.ShowDialog();
        }

        private void viewPosition_Click(object sender, EventArgs e)
        {
            Person person = ReturnPerson();
            string caption = person.Name + "'s Position";
            PositionViewForm myForm = new PositionViewForm(person.Role, person.LengthOfRoleOccupancy, person.NumberOfSubordinates, caption, number);
            myForm.ShowDialog();
        }

        private void viewAdventures_Click(object sender, EventArgs e)
        {
            Person person = ReturnPerson();
            string caption = person.Name + "'s Adventures";
            AdventuresViewForm myForm = new AdventuresViewForm(person.Adventures.ToList(), caption, number);
            myForm.ShowDialog();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            Person person = ReturnPerson();
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
                            streamWriter.WriteLine("\tElf Type: " + currentElf.ElfType);
                            string ringBearer = currentElf.OwnsRingOfPower ? "Yes" : "No";
                            streamWriter.WriteLine("\tElven Ring Bearer: " + ringBearer);
                        }
                        else if (race == "Dwarf")
                        {
                            streamWriter.WriteLine("\tDwarf Type: " + currentDwarf.DwarfGroup);
                        }
                        else if (race == "Hobbit")
                        {
                            streamWriter.WriteLine("\tHome Type: " + currentHobbit.HomeType);
                            string ringBearer = currentHobbit.OwnsOneRing ? "Yes" : "No";
                            streamWriter.WriteLine("\tThe Ring Bearer: " + ringBearer);
                            string adventurer = currentHobbit.IsAdventurer ? "Yes" : "No";
                            streamWriter.WriteLine("\tAdventurer: " + adventurer);
                        }
                        else if (race == "Men")
                        {
                            streamWriter.WriteLine("\tAncestral Line: " + currentHuman.AncestralLine);
                        }
                        else if (race == "Wizard")
                        {
                            streamWriter.WriteLine("\tPrimary Magic Type: " + currentWizard.MagicType);
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

        private void editBtn_Click(object sender, EventArgs e)
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
            deleteBtn.Visible = true;
            editBtn.Visible = false;
            exportBtn.Visible = false;
            NextBtn.Visible = false;
            PrevBtn.Visible = false;
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
                Person person = ReturnPerson();
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

                if (currentRace == "hobbit")
                {
                    currentHobbit.HomeType = Attr1TxtBx.Text;
                    currentHobbit.OwnsOneRing = checkBox1.Checked;
                    currentHobbit.IsAdventurer = checkBox2.Checked;
                    hobbitLogic.UpdateHobbit();
                }

                if (currentRace == "elf")
                {
                    currentElf.ElfType = Attr1TxtBx.Text;
                    currentElf.OwnsRingOfPower = checkBox1.Checked;
                    elfLogic.UpdateElf();
                }

                if (currentRace == "human")
                {
                    currentHuman.AncestralLine = Attr1TxtBx.Text;
                    humanLogic.UpdateHuman();
                }
                if (currentRace == "dwarf")
                {
                    currentDwarf.DwarfGroup = Attr1TxtBx.Text;
                    dwarfLogic.UpdateDwarf();
                }
                if (currentRace == "wizard")
                {
                    currentWizard.MagicType = Attr1TxtBx.Text;
                    wizardLogic.UpdateWizard();
                }

                //display buttons
                saveBtn.Visible = false;
                cancelBtn.Visible = false;
                deleteBtn.Visible = false;
                editBtn.Visible = true;
                exportBtn.Visible = true;
                NextBtn.Visible = true;
                PrevBtn.Visible = true;

                MessageBox.Show("Changes have been saved", "Success");
            }
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
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
            Person person = ReturnPerson();

            NametxtBx.Text = person.Name;
            ageTxtBx.Text = person.Age.ToString();
            hairTxtBx.Text = person.HairColor;
            eyeTxtBx.Text = person.EyeColor;
            genderTxtBx.Text = person.Gender;
            complexionTxtBx.Text = person.SkinComplexion;
            WoCTxtBx.Text = person.WeaponOfChoice;
            isEvil.Checked = person.Evil;

            if (currentRace == "hobbit")
            {
                Attr1TxtBx.Text = currentHobbit.HomeType;
                checkBox1.Checked = currentHobbit.OwnsOneRing;
                checkBox2.Checked = currentHobbit.IsAdventurer;

            }

            if (currentRace == "elf")
            {
                Attr1TxtBx.Text = currentElf.ElfType;
                checkBox1.Checked = currentElf.OwnsRingOfPower;
            }

            if (currentRace == "human")
            {
                Attr1TxtBx.Text = currentHuman.AncestralLine;
            }
            if (currentRace == "dwarf")
            {
                Attr1TxtBx.Text = currentDwarf.DwarfGroup;
            }
            if (currentRace == "wizard")
            {
                Attr1TxtBx.Text = currentWizard.MagicType;
            }
            //display buttons
            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            deleteBtn.Visible = false;
            editBtn.Visible = true;
            exportBtn.Visible = true;
            NextBtn.Visible = true;
            PrevBtn.Visible = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (currentRace == "elf")
            {
                elfLogic.DeleteElf(currentElf);
                isElfRadio.Checked = true;
            }
            if (currentRace == "dwarf")
            {
                dwarfLogic.DeleteDwarf(currentDwarf);
                isDwarfRadio.Checked = true;
            }
            if (currentRace == "wizard")
            {
                wizardLogic.DeleteWizard(currentWizard);
                isWizardRadio.Checked = true;
            }
            if (currentRace == "human")
            {
                humanLogic.DeleteHuman(currentHuman);
                isHumanRadio.Checked = true;
            }
            if (currentRace == "hobbit")
            {
                hobbitLogic.DeleteHobbit(currentHobbit);
                isHobbitRadio.Checked = true;
            }
            MessageBox.Show("Entry has been deleted!", "Success");
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

            saveBtn.Visible = false;
            cancelBtn.Visible = false;
            deleteBtn.Visible = false;
            editBtn.Visible = true;
            exportBtn.Visible = true;
            NextBtn.Visible = true;
            PrevBtn.Visible = true;
            SearchRace();
        }
    }
}
