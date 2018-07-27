using System;
using System.Collections.Generic;
using System.Text;

namespace InitiativeTrackerLibrary.Models
{
    public class CharacterCreationModel
    {
        //The unique identifier for the character.
        public int Id { get; set; }

        public string CharName { get; set; }
        public int CharHealth { get; set; }
        public int CharIniMod { get; set; }
        public string CharNote { get; set; }
        public int CharHiddenNr { get; set; }

        //This is an constructor
        public CharacterCreationModel()
        {

        }

        //This is an overloaded constructor
        public CharacterCreationModel(string charName, string charHealth, string charIniMod, string charNote, string charHiddenNr)
        {
            // This place the charName parimiter and placing it in the CharName property. 
            CharName = charName;


            //This does the same with charHealth and CharHealth, but also tries if it's a interger.
            int charHealthValue = 0;
            int.TryParse(charHealth, out charHealthValue);
            CharHealth = charHealthValue;

            int charIniModValue = 0;
            int.TryParse(charIniMod, out charIniModValue);
            CharIniMod = charIniModValue;

            CharNote = charNote;

            int charHiddenNrValue = 0;
            int.TryParse(charHiddenNr, out charHiddenNrValue);
            CharHiddenNr = charHiddenNrValue;

        }
    }
}
