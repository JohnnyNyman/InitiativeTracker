using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitiativeTrackerLibrary.Models;

namespace InitiativeTrackerLibrary

{
    public class TextConnection : IDataConnection
    {

        private const string CharactersFile = "CharacterChreationModels.csv"; // the value inside a const will never  change.

        public CharacterCreationModel SaveCharacter(CharacterCreationModel model)
        {
            // Load the textfile and convert the text to List<CharacterCreationModel>
            List<CharacterCreationModel> characters = CharactersFile.FullFilePath().LoadFile().ConvertToCharacterCreationModels();

            // Fin the max ID
            int currentId = 1;
            if(characters.Count > 0)
            {
                currentId = characters.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            //CODE ADDON currentId += 1; <--This code can be added if you want to write more than one record at the time to this List.


            // Add the new record with the new ID (max + 1)
            characters.Add(model);

            // Convert the prizes to list<string>
            // Save the list<string> to the text file
            characters.SaveToCharacterFile(CharactersFile);


            // The model is were we added the currentId to, and now, it's the CharacterCreationModel fully formed with that Id.
            return model;
        }
        //TODO Wire up the SaveCharacter for the text files.

        public List<CharacterCreationModel> GetCharacter_All()
        {
            return CharactersFile.FullFilePath().LoadFile().ConvertToCharacterCreationModels();
        }
    }
}
