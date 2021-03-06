﻿using System;
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
        private bool home = true;
        private bool history = false;
        private bool LocData = false;
        private bool RoleData = false;
        private bool adventureHistory = false;

        private HomeForm homeScreen;
        private HistoryForm historyScreen;
        private LocationDataForm locDataScreen;
        private RoleDataForm roleDataScreen;
        private AdventureHistoryForm advHistScreen;

        private int number;

        public MainForm()
        {
            Random rand = new Random();
            number = rand.Next(1, 5);
            InitializeComponent();
            this.IsMdiContainer = true;
            homeScreen = new HomeForm(number);
            homeScreen.MdiParent = this;
            homeScreen.Show();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!home)
            {
                CloseCurrentWindow();
                ResetViewBools();
                home = true;
                homeScreen = new HomeForm(number);
                homeScreen.MdiParent = this;
                homeScreen.Dock = DockStyle.Top;
                homeScreen.Show();
            }
            
        }

        private void ResetViewBools()
        {
            home = false;
            history = false;
            LocData = false;
            RoleData = false;
            adventureHistory = false;
        }

        private void dwarfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!history)
            {
                CloseCurrentWindow();
                ResetViewBools();
                history = true;
                historyScreen = new HistoryForm("dwarf", number);
                historyScreen.MdiParent = this;
                historyScreen.Dock = DockStyle.Top;
                historyScreen.Show();
            }
        }

        private void wizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!history)
            {
                CloseCurrentWindow();
                ResetViewBools();
                history = true;
                historyScreen = new HistoryForm("wizard", number);
                historyScreen.MdiParent = this;
                historyScreen.Dock = DockStyle.Top;
                historyScreen.Show();
            }
        }

        private void humanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!history)
            {
                CloseCurrentWindow();
                ResetViewBools();
                history = true;
                historyScreen = new HistoryForm("human", number);
                historyScreen.MdiParent = this;
                historyScreen.Dock = DockStyle.Top;
                historyScreen.Show();
            }
        }

        private void hobbitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!history)
            {
                CloseCurrentWindow();
                ResetViewBools();
                history = true;
                historyScreen = new HistoryForm("hobbit", number);
                historyScreen.MdiParent = this;
                historyScreen.Dock = DockStyle.Top;
                historyScreen.Show();
            }
        }
        private void CloseCurrentWindow()
        {
            if (home)
            {
                homeScreen.Close();
            }
            if (history)
            {
                historyScreen.Close();
            }
            if (LocData)
            {
                locDataScreen.Close();
            }
            if (RoleData)
            {
                roleDataScreen.Close();
            }
            if (adventureHistory)
            {
                advHistScreen.Close();
            }
        }

        private void elfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!history)
            {
                CloseCurrentWindow();
                ResetViewBools();
                history = true;
                historyScreen = new HistoryForm("elf", number);
                historyScreen.MdiParent = this;
                historyScreen.Dock = DockStyle.Top;
                historyScreen.Show();
            }
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LocData)
            {
                CloseCurrentWindow();
                ResetViewBools();
                LocData = true;
                locDataScreen = new LocationDataForm(number);
                locDataScreen.MdiParent = this;
                locDataScreen.Dock = DockStyle.Top;
                locDataScreen.Show();
            }
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!RoleData)
            {
                CloseCurrentWindow();
                ResetViewBools();
                RoleData = true;
                roleDataScreen = new RoleDataForm(number);
                roleDataScreen.MdiParent = this;
                roleDataScreen.Dock = DockStyle.Top;
                roleDataScreen.Show();
            }
        }

        private void allAdventuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!adventureHistory)
            {
                CloseCurrentWindow();
                ResetViewBools();
                adventureHistory = true;
                advHistScreen = new AdventureHistoryForm(number);
                advHistScreen.MdiParent = this;
                advHistScreen.Dock = DockStyle.Top;
                advHistScreen.Show();
            }
        }
    }
}
