using InitiativeTrackerLibrary;
using InitiativeTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CharacterListForm : Form
    {  
        private const string CharactersFile = "CharacterChreationModels.csv";
        private List<CharacterCreationModel> currentCharacters = new List<CharacterCreationModel>();
        public CharacterListForm()
        {
            InitializeComponent();

            LoadUpCharData();
            ListWireUp();
        }
        private void HandleRefreshRequest(object sender, EventArgs e)
        {
            LoadUpCharData();
            ListWireUp();
        }

        private void LoadUpCharData()
        {
            TextConnection textc = new TextConnection();
            currentCharacters = textc.GetCharacter_All();
        }

        private void ListWireUp()
        {
            characterListBox.DataSource = null;

            characterListBox.DataSource = currentCharacters;
            characterListBox.DisplayMember = "CharName";
        }

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createCharacterButton_Click(object sender, EventArgs e)
        {
            CharacterCreationForm settingform = new CharacterCreationForm();
            settingform.RefreshList += HandleRefreshRequest;
            settingform.Show();
            //Program.OpenFormOnClose = true;
            //this.Close();
        }

        private void startInitiativeButton_Click(object sender, EventArgs e)
        {
            InitiativeTrackerForm settingform = new InitiativeTrackerForm();

            settingform.Show();
        }

        private void deleteCharacterButton_Click(object sender, EventArgs e)
        {

            CharacterCreationModel selected = (CharacterCreationModel)characterListBox.SelectedItem;
            int i = currentCharacters.IndexOf(selected);

            currentCharacters.RemoveAt(i);
            currentCharacters.SaveToCharacterFile(CharactersFile);

            ListWireUp();
        }
    }
}
