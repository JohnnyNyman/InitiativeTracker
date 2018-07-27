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
        private List<CharacterCreationModel> tempCharacters = new List<CharacterCreationModel>();

        public InitiativeTrackerForm()
        {
            InitializeComponent();

            //CreateSampleData();
            LoadUpCharactersData();
            WireUpList();
            //displayCharacterStats();
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


        /*private void displayCharacterStats()
        {
            CharacterCreationModel cdisplay = (CharacterCreationModel)initiativeListBox.SelectedItem;


            if (cdisplay != null)
            {
                characterName.Text = "-";
                healthAmount.Text = "-";
                notes.Text = "-";

                CheckCharacterData();
                WireUpList();


            }

            else
            {
                characterName.Text = "-";
                healthAmount.Text = "-";
                notes.Text = "-";
            }
        }

            TODO When adding damage the number of the damage is added to a secret number that starts with 0.
                 That number is then subtracted to the character health by:
                 healthAmount.Text = withdamage (int withdamage = cdisplay.CharHealth - secretnumber);
        */

        private void initiativeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterCreationModel cdisplay = (CharacterCreationModel)initiativeListBox.SelectedItem;
            
            if (cdisplay != null)
            {
                characterName.Text = cdisplay.CharName.ToString();
                healthAmount.Text = cdisplay.CharHealth.ToString();
                iniMod.Text = cdisplay.CharIniMod.ToString() + "+" + cdisplay.CharHiddenNr.ToString();
                notes.Text = cdisplay.CharNote.ToString();
            }

        }

        // Integer
        private void addDamageButton_Click(object sender, EventArgs e)
        {
            CharacterCreationModel damage = (CharacterCreationModel)initiativeListBox.SelectedItem;
            int x;
            if(damage != null)
            {
                if (validateForm())
                {
                    x = Int32.Parse(damageTextBox.Text);
                    // set CharHealth to ("currentHealth" - "CurrentDamage")
                    damage.CharHealth = (damage.CharHealth - x);
                    damageTextBox.Text = "0";

                    //initiativeListBox.Select();
                }
                

            }


            else
            {
                MessageBox.Show("This form is invalid");
            }
        }

        private bool validateForm()
        {
            bool output = true;
            int damageInput = 0;

            if (!int.TryParse(damageTextBox.Text,out damageInput))
            {
                output = false;
            }

            return output;
        }

        private void rollInitiativeButton_Click(object sender, EventArgs e)
        {

            /*
            * Sortera dem efter IniMod + en randomiserad integer. Kanske med dåld parameter i listbox objektet som börjar på 0.
            * För med dåld parameter kan jag göra en foreachloop.
            * foreach (object in initiativeListBox)
            * Random random = new Random();
            * int diceroll = random(1, 100)
            * dåldparameter = diceroll + IniMod
            * SortBy.dåldparameter
            * 
            * ALTERNATIVT
            * Ta bort föremålen i initiativeListBox samtidigt som jag lägger till dem i en temporär List<>.
            * Därefter gör jag en foreach-loop där IniMod + randomNumber får bestämma ordningen som de läggs in i 
            * initiativeListBox.
            */

            
            CharacterCreationModel Selected = (CharacterCreationModel)initiativeListBox.SelectedItem;
            //ListBox.ObjectCollection list = initiativeListBox.Items;
            int n = initiativeListBox.Items.Count;
            int y = initiativeListBox.Items.Count;
            Random rng = new Random();
            int x;
            int z = 0;


            /*
            if (this.initiativeListBox.Items.Count > 0)
            {
                this.initiativeListBox.SelectedIndex = 0;
            }
            */

            
            while(n > 0)
            {
                // This goes through all items in initiativeListBox and add a random number to CharHiddenNr based on CharIniMod.
                n--;
                CharacterCreationModel index = (CharacterCreationModel)initiativeListBox.Items[z];
                x = rng.Next(y + index.CharIniMod);
                index.CharHiddenNr = x;
                z++;


            }

        }

        private void sortByIniModButton_Click(object sender, EventArgs e)
        {
            string tempName;
            int tempHealth;
            int tempIniMod;
            string tempNote;
            int tempHiddenNr;



            for (int i = 0; i < selectedCharacters.Count; i++)
            {
                CharacterCreationModel index1 = (CharacterCreationModel)selectedCharacters[i];
                for (int q = i+1; q < selectedCharacters.Count; q++)
                {
                    
                    CharacterCreationModel index2 = (CharacterCreationModel)selectedCharacters[q];
                    int indexi = index1.CharIniMod + index1.CharHiddenNr;
                    int indexq = index2.CharIniMod + index2.CharHiddenNr;


                    if(indexi <= indexq)
                    {
                        if(indexi == indexq)
                        {
                            if (index1.CharIniMod < index2.CharIniMod)
                            {
                                tempName = selectedCharacters[i].CharName;
                                tempHealth = selectedCharacters[i].CharHealth;
                                tempIniMod = selectedCharacters[i].CharIniMod;
                                tempNote = selectedCharacters[i].CharNote;
                                tempHiddenNr = selectedCharacters[i].CharHiddenNr;

                                index1.CharName = selectedCharacters[q].CharName;
                                index1.CharHealth = selectedCharacters[q].CharHealth;
                                index1.CharIniMod = selectedCharacters[q].CharIniMod;
                                index1.CharNote = selectedCharacters[q].CharNote;
                                index1.CharHiddenNr = selectedCharacters[q].CharHiddenNr;

                                index2.CharName = tempName;
                                index2.CharHealth = tempHealth;
                                index2.CharIniMod = tempIniMod;
                                index2.CharNote = tempNote;
                                index2.CharHiddenNr = tempHiddenNr;
                            }
                        }
                        else
                        {
                            tempName = selectedCharacters[i].CharName;
                            tempHealth = selectedCharacters[i].CharHealth;
                            tempIniMod = selectedCharacters[i].CharIniMod;
                            tempNote = selectedCharacters[i].CharNote;
                            tempHiddenNr = selectedCharacters[i].CharHiddenNr;

                            index1.CharName = selectedCharacters[q].CharName;
                            index1.CharHealth = selectedCharacters[q].CharHealth;
                            index1.CharIniMod = selectedCharacters[q].CharIniMod;
                            index1.CharNote = selectedCharacters[q].CharNote;
                            index1.CharHiddenNr = selectedCharacters[q].CharHiddenNr;

                            index2.CharName = tempName;
                            index2.CharHealth = tempHealth;
                            index2.CharIniMod = tempIniMod;
                            index2.CharNote = tempNote;
                            index2.CharHiddenNr = tempHiddenNr;
                        }


                        WireUpList();
                    }
                }
            }

        }
    }
}
