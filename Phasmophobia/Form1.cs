using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhasmophobiaGhostAssistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbEvi1.SelectedIndex = 6;
            cbEvi2.SelectedIndex = 6;
            cbEvi3.SelectedIndex = 6;
            ghosts.Add(new Ghost("Spirit","None","Smudge Sticks (Attack timer to 120 from 90)", 2, 3, 5));
            ghosts.Add(new Ghost("Wraith","Can't track footprints. Travel through walls and doors","Toxic against Salt. Stop attacking when touching salt", 0, 2, 5));
            ghosts.Add(new Ghost("Phantom","Looking at it lowers your sanity quicker","Photos make it disappear (Not stop a hunt)", 0, 1, 4));
            ghosts.Add(new Ghost("Poltergeist","Can touch multiple objects and shut multiple doors", "Ineffective in an empty room.", 2, 4, 5));
            ghosts.Add(new Ghost("Banshee", "Focus on one player at a time until it kills them", "Fears Crucifix (Hunt Stop range 5 meters instead of 3)", 0, 1, 5));
            ghosts.Add(new Ghost("Jinn", "Faster if its victim is far away", "Turning off the location's power source (Nulls fast speed)", 1, 2, 4));
            ghosts.Add(new Ghost("Mare","Increased chance to attack in the dark. It'll turn the power off.", "Turning on lights will lower chance of attack", 0, 2, 4));
            ghosts.Add(new Ghost("Revenant","Move faster during hunt. Will switch target freely during hunt","Hiding will make it move very slow", 1, 3, 5));
            ghosts.Add(new Ghost("Shade","Barely do anything when 2 or more people are around (Harder to detect)", "Will rarely start a Hunt when players are grouped together", 1, 3, 4));
            ghosts.Add(new Ghost("Demon", "Attack more often than any other ghost", "Successful questions on the Ouija Board won't lower the users' sanity", 0, 2, 3));
            ghosts.Add(new Ghost("Yurei", "Stronger effect on people's Sanity", "Smudge Stick will cause it to not wander around the location (90 Seconds)", 0, 3, 4));
            ghosts.Add(new Ghost("Oni", "More active when people are nearby. Moves objects at great speeds.", "Easier to find and identify due to activity", 1, 2, 3));
        }
        List<string> itemsName = new List<string>() { "Freezing Temperature", "EMF5", "Spirit Box", "Ghost Writing", "Ghost Orbs", "Fingerprints" };
        List<int> selectedItens = new List<int>() {6, 6, 6 };
        List<Ghost> ghosts = new List<Ghost>();
        List<Ghost> withTwoEvidences = new List<Ghost>();
        int evidenceCount;
        public void GhostFind(List<Ghost> ghosts)
        {
            List<Ghost> testingGhosts = new List<Ghost>();
            for (int i = 0; i < ghosts.Count; i++)
            {
                if (ghosts[i].requiredItems[0] == selectedItens[evidenceCount] || ghosts[i].requiredItems[1] == selectedItens[evidenceCount] || ghosts[i].requiredItems[2] == selectedItens[evidenceCount])
                    testingGhosts.Add(ghosts[i]);
            }
            evidenceCount++;
            if (evidenceCount < 3 && selectedItens[evidenceCount] != 6)
                GhostFind(testingGhosts);
            else if (testingGhosts.Count <= 3 && testingGhosts.Count > 0)
                switch (testingGhosts.Count)
                {
                    case 1:
                        txtMaybe1.Text = "Ghost: " + testingGhosts[0].name;
                        lblEvi1.Text = MissingEvidence(testingGhosts[0]);
                        txtMaybe2.Text = "Strength: " + testingGhosts[0].strength;
                        lblEvi2.Text = "";
                        txtMaybe3.Text = "Weakness: " + testingGhosts[0].weakness;
                        lblEvi3.Text = "";
                        break;
                    case 2:
                        txtMaybe1.Text = testingGhosts[0].name;
                        lblEvi1.Text = MissingEvidence(testingGhosts[0]);
                        txtMaybe2.Text = testingGhosts[1].name;
                        lblEvi2.Text = MissingEvidence(testingGhosts[1]);
                        txtMaybe3.Text = "";
                        lblEvi3.Text = "";
                        break;
                    case 3:
                        txtMaybe1.Text = testingGhosts[0].name;
                        lblEvi1.Text = MissingEvidence(testingGhosts[0]);
                        txtMaybe2.Text = testingGhosts[1].name;
                        lblEvi2.Text = MissingEvidence(testingGhosts[1]);
                        txtMaybe3.Text = testingGhosts[2].name;
                        lblEvi3.Text = MissingEvidence(testingGhosts[2]);
                        break;
                }
            else
            {
                txtMaybe1.Text = "";
                txtMaybe2.Text = "";
                txtMaybe3.Text = "";
                lblEvi1.Text = "";
                lblEvi2.Text = "";
                lblEvi3.Text = "";
            }
            evidenceCount = 0;
        }
        public string MissingEvidence(Ghost ghost)
        {
            for (int i = 0; i < 3; i++)
                if (selectedItens[i] != ghost.requiredItems[i])
                    return itemsName[ghost.requiredItems[i]];
            return "";
        }
        public void UpdateAndSort()
        {
            selectedItens[0] = cbEvi1.SelectedIndex;
            selectedItens[1] = cbEvi2.SelectedIndex;
            selectedItens[2] = cbEvi3.SelectedIndex;
            selectedItens.Sort();
        }
        private void CbEvi1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItens[0] = cbEvi1.SelectedIndex;
            UpdateAndSort();
            GhostFind(ghosts);
        }
        private void CbEvi2_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItens[1] = cbEvi2.SelectedIndex;
            UpdateAndSort();
            GhostFind(ghosts);
        }
        private void CbEvi3_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItens[2] = cbEvi3.SelectedIndex;
            UpdateAndSort();
            GhostFind(ghosts);
        }
    }
}