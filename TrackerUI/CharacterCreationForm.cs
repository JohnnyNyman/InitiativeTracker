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
    public partial class CharacterCreationForm : Form
    {
        public CharacterCreationForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveCharacterButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // This uses the overloaded constructor in CharacterCreationModel and aplying it to the text boxes in the form.
                CharacterCreationModel model = new CharacterCreationModel(
                    nameTextBox.Text,
                    healthTextBox.Text,
                    iniModTextBox.Text,
                    noteTextBox.Text);

                //TODO GlobalConfig.Connections.SaveCharacter(model);
               // GlobalConfig.Connections.SaveCharacter(model);
                foreach (IDataConnection db in GlobalConfig.Connections) //This creates a list of IDataConnection connections
                {
                    // This passes in model and returns a new model. Which can be saved or ignored.
                    db.SaveCharacter(model);
                }
                nameTextBox.Text = "";
                healthTextBox.Text = "0";
                iniModTextBox.Text = "0";
                noteTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("This form is invalid");
            }

        }

        private bool ValidateForm()
        {


            bool output = true;
            int healthNumber = 0;
            int iniModNumber = 0;

            if (nameTextBox.Text.Length == 0)
            {
                output = false;
            }

            // This checks if the text in healthTextBox can be converted into an interger. It also put the value of healthTextBox into the healthNumber variable(it does this with the "out" as it bring something out of the method instead of putting it in). 
            if (!int.TryParse(healthTextBox.Text, out healthNumber))
            {
                output = false;
            }

            if(!int.TryParse(iniModTextBox.Text, out iniModNumber))
            {
                output = false;
            }


            return output;
        }
    }
}
