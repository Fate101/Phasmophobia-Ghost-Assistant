using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phasmophobia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbEvi1.SelectedIndex = 6;
            cbEvi2.SelectedIndex = 6;
            cbEvi3.SelectedIndex = 6;
            ghosts.Add(new Ghost("Spirit", 2, 3, 5));
            ghosts.Add(new Ghost("Wraith", 0, 2, 5));
            ghosts.Add(new Ghost("Phantom", 0, 1, 4));
            ghosts.Add(new Ghost("Poltergeist", 2, 4, 5));
            ghosts.Add(new Ghost("Banshee", 0, 1, 5));
            ghosts.Add(new Ghost("Jinn", 1, 2, 4));
            ghosts.Add(new Ghost("Mare", 0, 2, 4));
            ghosts.Add(new Ghost("Revenant", 1, 3, 5));
            ghosts.Add(new Ghost("Shade", 1, 3, 4));
            ghosts.Add(new Ghost("Demon", 0, 2, 3));
            ghosts.Add(new Ghost("Yurei", 0, 3, 4));
            ghosts.Add(new Ghost("Oni", 1, 2, 3));
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
                        txtMaybe1.Text = testingGhosts[0].name;
                        lblEvi1.Text = MissingEvidence(testingGhosts[0]);
                        txtMaybe2.Text = "";
                        lblEvi2.Text = "";
                        txtMaybe3.Text = "";
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