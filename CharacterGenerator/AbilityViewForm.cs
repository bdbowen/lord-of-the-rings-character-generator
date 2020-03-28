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
    public partial class AbilityViewForm : Form
    {
        private string abilityType;
        private Ability[] abilities;
        private Ability CurrentAbility;
        private Mental[] mentals;
        private Mental CurrentMental;
        private Physical[] physicals;
        private Physical CurrentPhysical;
        private Magical[] spells;
        private Magical CurrentSpell;
        private int AbilityIndex;
        private int number;
        public AbilityViewForm()
        {
            InitializeComponent();
        }

        public AbilityViewForm(List<Mental> abilities, string caption, int number)
        {
            InitializeComponent();

            //initialize variables
            abilityType = "mental";
            mentals = abilities.ToArray();
            CurrentMental = mentals[0];
            AbilityIndex = 0;
            this.number = number;
            
            //set up gui for mental ability
            subAttr1Lbl.Text = "Subject";
            subAttr2Lbl.Text = "Race of Origin";
            subBool1Check.Text = "Requires Subject Mastery";
            LocationBtn.Text = "View School Location";
            subBool2Check.Visible = false;
            subBool3Check.Visible = false;
            Text = caption;
            subAttr2Lbl.Location = new Point(241, 98);
            subAttr1Lbl.Location = new Point(100, 136);

            //fill in information
            headingLbl.Text = "Field of Wisdom " + (AbilityIndex + 1).ToString() + ": " + CurrentAbility.Title;
            titleTxtBx.Text = CurrentAbility.Title;
            diffLvlTxtBx.Text = CurrentAbility.DifficultyLevel.ToString();
            subAttr1TxtBx.Text = CurrentMental.Subject;
            subAttr2TxtBx.Text = CurrentMental.RaceOfOrigin;
            descTxtBx.Text = CurrentAbility.Description;
            exhaustingCheck.Checked = CurrentAbility.Exhausting;
            subBool1Check.Checked = CurrentMental.RequiresSubjectMastery;

            //set background image
            string path = Application.StartupPath + "\\..\\..\\..\\Media\\" + "abBackgroundOpt" + number.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(path);
            Size = BackgroundImage.Size;
        }

        public AbilityViewForm(List<Magical> abilities, string caption, int number)
        {
            InitializeComponent();

            //initialize variables
            abilityType = "magical";
            spells = abilities.ToArray();
            CurrentSpell = spells[0];
            AbilityIndex = 0;
            this.number = number;

            //set up gui for magical ability
            subAttr1Lbl.Text = "Magic Type";
            subBool1Check.Text = "Light Magic";
            LocationBtn.Text = "View Archive Location";
            subAttr2Lbl.Visible = false;
            subAttr2TxtBx.Visible = false;
            subBool2Check.Visible = false;
            subBool3Check.Visible = false;
            Text = caption;
            subAttr1Lbl.Location = new Point(67, 136);

            //fill in information
            headingLbl.Text = "Magical Feat " + (AbilityIndex + 1).ToString() + ": " + CurrentAbility.Title;
            titleTxtBx.Text = CurrentAbility.Title;
            diffLvlTxtBx.Text = CurrentAbility.DifficultyLevel.ToString();
            subAttr1TxtBx.Text = CurrentSpell.MagicType;
            descTxtBx.Text = CurrentAbility.Description;
            exhaustingCheck.Checked = CurrentAbility.Exhausting;
            subBool1Check.Checked = CurrentSpell.LightMagic;

            //set background image
            string path = Application.StartupPath + "\\..\\..\\..\\Media\\" + "abBackgroundOpt" + number.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(path);
            Size = BackgroundImage.Size;
        }

        public AbilityViewForm(List<Physical> abilities, string caption, int number)
        {
            InitializeComponent();

            //initialize variables
            abilityType = "physical";
            physicals = abilities.ToArray();
            CurrentPhysical = physicals[0];
            AbilityIndex = 0;
            this.number = number;

            //set up gui for physical ability
            subAttr1Lbl.Text = "Tool Required";
            subAttr2Lbl.Text = "Race of Origin";
            subBool1Check.Text = "Requires Weapon Mastery";
            subBool2Check.Text = "Fighting";
            subBool3Check.Text = "Lethal";
            LocationBtn.Text = "View Training Location";
            Text = caption;
            subAttr1Lbl.Location = new Point(49, 136);
            subAttr2Lbl.Location = new Point(241, 98);

            //fill in information
            headingLbl.Text = "Physical Ability " + (AbilityIndex + 1).ToString() + ": " + CurrentAbility.Title;
            titleTxtBx.Text = CurrentAbility.Title;
            diffLvlTxtBx.Text = CurrentAbility.DifficultyLevel.ToString();
            subAttr1TxtBx.Text = CurrentPhysical.ToolRequired;
            subAttr2TxtBx.Text = CurrentPhysical.RaceOfOrigin;
            descTxtBx.Text = CurrentAbility.Description;
            exhaustingCheck.Checked = CurrentAbility.Exhausting;
            subBool1Check.Checked = CurrentPhysical.RequiresWeaponMastery;
            subBool2Check.Checked = CurrentPhysical.Fighting;
            subBool3Check.Checked = CurrentPhysical.Lethal;

            //set background image
            string path = Application.StartupPath + "\\..\\..\\..\\Media\\" + "abBackgroundOpt" + number.ToString() + ".jpg";
            BackgroundImage = Image.FromFile(path);
            Size = BackgroundImage.Size;
        }

        private void LocationBtn_Click_1(object sender, EventArgs e)
        {
            if (abilityType == "mental")
            {
                string caption = CurrentAbility.Title + "'s School Location";
                LocationViewForm myForm = new LocationViewForm(CurrentMental.Location, caption, number);
                myForm.ShowDialog();
            }
            else if (abilityType == "physical")
            {
                string caption = CurrentAbility.Title + "'s Training Location";
                LocationViewForm myForm = new LocationViewForm(CurrentPhysical.Location, caption, number);
                myForm.ShowDialog();
            }
            else if (abilityType == "magical")
            {
                string caption = CurrentAbility.Title + "'s Archive Location";
                LocationViewForm myForm = new LocationViewForm(CurrentSpell.Location, caption, number);
                myForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (abilityType == "mental")
            {
                AbilityIndex = (AbilityIndex + mentals.Length - 1) % mentals.Length;
                CurrentMental = mentals[AbilityIndex];
                
                headingLbl.Text = "Field of Wisdom " + (AbilityIndex + 1).ToString() + ": " + CurrentAbility.Title;
                titleTxtBx.Text = CurrentAbility.Title;
                diffLvlTxtBx.Text = CurrentAbility.DifficultyLevel.ToString();
                subAttr1TxtBx.Text = CurrentMental.Subject;
                subAttr2TxtBx.Text = CurrentMental.RaceOfOrigin;
                descTxtBx.Text = CurrentAbility.Description;
                exhaustingCheck.Checked = CurrentAbility.Exhausting;
                subBool1Check.Checked = CurrentMental.RequiresSubjectMastery;
            }
            if (abilityType == "magical")
            {
                AbilityIndex = (AbilityIndex + spells.Length - 1) % spells.Length;
                CurrentSpell = spells[AbilityIndex];

                headingLbl.Text = "Magical Feat " + (AbilityIndex + 1).ToString() + ": " + CurrentAbility.Title;
                titleTxtBx.Text = CurrentAbility.Title;
                diffLvlTxtBx.Text = CurrentAbility.DifficultyLevel.ToString();
                subAttr1TxtBx.Text = CurrentSpell.MagicType;
                descTxtBx.Text = CurrentAbility.Description;
                exhaustingCheck.Checked = CurrentAbility.Exhausting;
                subBool1Check.Checked = CurrentSpell.LightMagic;
            }
            if (abilityType == "physical")
            {
                AbilityIndex = (AbilityIndex + physicals.Length - 1) % physicals.Length;
                CurrentPhysical = physicals[AbilityIndex];

                headingLbl.Text = "Physical Ability " + (AbilityIndex + 1).ToString() + ": " + CurrentAbility.Title;
                titleTxtBx.Text = CurrentAbility.Title;
                diffLvlTxtBx.Text = CurrentAbility.DifficultyLevel.ToString();
                subAttr1TxtBx.Text = CurrentPhysical.ToolRequired;
                subAttr2TxtBx.Text = CurrentPhysical.RaceOfOrigin;
                descTxtBx.Text = CurrentAbility.Description;
                exhaustingCheck.Checked = CurrentAbility.Exhausting;
                subBool1Check.Checked = CurrentPhysical.RequiresWeaponMastery;
                subBool2Check.Checked = CurrentPhysical.Fighting;
                subBool3Check.Checked = CurrentPhysical.Lethal;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (abilityType == "mental")
            {
                AbilityIndex = (AbilityIndex + 1) % mentals.Length;
                CurrentMental = mentals[AbilityIndex];

                headingLbl.Text = "Field of Wisdom " + (AbilityIndex + 1).ToString() + ": " + CurrentAbility.Title;
                titleTxtBx.Text = CurrentAbility.Title;
                diffLvlTxtBx.Text = CurrentAbility.DifficultyLevel.ToString();
                subAttr1TxtBx.Text = CurrentMental.Subject;
                subAttr2TxtBx.Text = CurrentMental.RaceOfOrigin;
                descTxtBx.Text = CurrentAbility.Description;
                exhaustingCheck.Checked = CurrentAbility.Exhausting;
                subBool1Check.Checked = CurrentMental.RequiresSubjectMastery;
            }
            if (abilityType == "magical")
            {
                AbilityIndex = (AbilityIndex + 1) % spells.Length;
                CurrentSpell = spells[AbilityIndex];

                headingLbl.Text = "Magical Feat " + (AbilityIndex + 1).ToString() + ": " + CurrentAbility.Title;
                titleTxtBx.Text = CurrentAbility.Title;
                diffLvlTxtBx.Text = CurrentAbility.DifficultyLevel.ToString();
                subAttr1TxtBx.Text = CurrentSpell.MagicType;
                descTxtBx.Text = CurrentAbility.Description;
                exhaustingCheck.Checked = CurrentAbility.Exhausting;
                subBool1Check.Checked = CurrentSpell.LightMagic;
            }
            if (abilityType == "physical")
            {
                AbilityIndex = (AbilityIndex + 1) % physicals.Length;
                CurrentPhysical = physicals[AbilityIndex];

                headingLbl.Text = "Physical Ability " + (AbilityIndex + 1).ToString() + ": " + CurrentAbility.Title;
                titleTxtBx.Text = CurrentAbility.Title;
                diffLvlTxtBx.Text = CurrentAbility.DifficultyLevel.ToString();
                subAttr1TxtBx.Text = CurrentPhysical.ToolRequired;
                subAttr2TxtBx.Text = CurrentPhysical.RaceOfOrigin;
                descTxtBx.Text = CurrentAbility.Description;
                exhaustingCheck.Checked = CurrentAbility.Exhausting;
                subBool1Check.Checked = CurrentPhysical.RequiresWeaponMastery;
                subBool2Check.Checked = CurrentPhysical.Fighting;
                subBool3Check.Checked = CurrentPhysical.Lethal;
            }
        }
    }
}
