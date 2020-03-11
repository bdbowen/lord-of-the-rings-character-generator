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
        }
    }
}