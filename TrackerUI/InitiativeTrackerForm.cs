using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InitiativeTrackerLibrary;
using InitiativeTrackerLibrary.Models;

namespace TrackerUI
{
    //TODO Wire up the saved text file to appear in drop down. Make an instance?
    public partial class InitiativeTrackerForm : Form
    {
        private List<CharacterCreationModel> availableCharacters = new List<CharacterCreationModel>();
        private List<CharacterCreationModel> selectedCharacters = new List<CharacterCreationModel>();

        public InitiativeTrackerForm()
        {
            InitializeComponent();

            //CreateSampleData();
            LoadUpCharactersData();
            WireUpList();
            displayCharacterStats();
        }

        private void CreateSampleData()
        {

            //availableCharacters.Add(new CharacterCreationModel { CharName = "Brefnord" });
            //availableCharacters.Add(new CharacterCreationModel { CharName = "Jash" });

            //selectedCharacters.Add(new CharacterCreationModel { CharName = "Myranda" });
        }

        private void LoadUpCharactersData()
        {
            TextConnection textcon = new TextConnection();
            availableCharacters = textcon.GetCharacter_All();
        }
        /* Mål är att medan man har selectat en karaktär i initiativeListBox så ska relevant data bli displayad under till.
         * Kanske måste jag göra en ny lista av datan i CharacterCreationModels eller avnända availableCharacter.
         * 
         */
        private void WireUpList()
        {
            // Is there a better way to refresh than using null?
            characterDropDown.DataSource = null;

            characterDropDown.DataSource = availableCharacters;
            characterDropDown.DisplayMember = "CharName";

            initiativeListBox.DataSource = null;

            initiativeListBox.DataSource = selectedCharacters;
            initiativeListBox.DisplayMember = "CharName";
        }


        private void noteLabel_Click(object sender, EventArgs e)
        {

        }

        private void addCharacterButton_Click(object sender, EventArgs e)
        {
            // This creates an instance of the selected character from CharacterCreationModel
            CharacterCreationModel c = (CharacterCreationModel)characterDropDown.SelectedItem;

            //This removes the instance c from the availableCharacters List and adds it to selectedCharacters List
            if (c != null)
            {
                availableCharacters.Remove(c);
                selectedCharacters.Add(c);

                WireUpList();
            }
        }

        private void removeCharacterButton_Click(object sender, EventArgs e)
        {
            CharacterCreationModel c = (CharacterCreationModel)initiativeListBox.SelectedItem;

            if (c != null)
            {
                selectedCharacters.Remove(c);
                availableCharacters.Add(c);

                WireUpList();
            }
        }


        /*
         * Har jag något på spåren?
         */
        private void displayCharacterStats()
        {
            CharacterCreationModel cdisplay = (CharacterCreationModel)initiativeListBox.SelectedItem;

            if (cdisplay != null)
            {
                characterName.Text = cdisplay.CharName;
                healthAmount.Text = cdisplay.CharHealth.ToString();
                notes.Text = cdisplay.CharNote;
                //effects.Text = NotImplementedYet

                WireUpList();
            }
        }
    }
}
