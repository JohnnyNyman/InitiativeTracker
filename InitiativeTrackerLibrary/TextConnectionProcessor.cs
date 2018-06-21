using InitiativeTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

// *Load the textfile
// *convert hte text to List<CharacterCreationModel>
// Fin the max ID
// Add the new record with the new ID (max + 1)
// Convert the prizes to list<string>
// Save the list<string> to the text file

namespace InitiativeTrackerLibrary
{
    public static class TextConnectionProcessor
    {
        public static string FullFilePath(this string fileName) // Extension Method
        {
            // C:\Users\JohnnyN\source\repos\InitiativeTracker\CharacterCreationModel.csv
            return $"{ConfigurationManager.AppSettings["filePath"] }\\{fileName}"; //Inside of a string the \ is a escape character. So we need another \. So \\ translates to one \ in this case.
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file)) // File is a built in to microsoft. System.IO Namespace
            {
                //If there is no list this is gonna return an empty linte of CharacterCreationModel.
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }


        //this is gonna take in a list of string from the lines from the text files. It's gonna spit out a list of CharacterCreationModel. Extension Method
        public static List<CharacterCreationModel> ConvertToCharacterCreationModels(this List<string> lines)
        {
            List<CharacterCreationModel> output = new List<CharacterCreationModel>(); // our output

            // This is gonna loop through every line in our text file. If there is no lines: "if (!File.Exists(file))" as above, it's gonna skip through the foreach loop.
            foreach (string line in lines)
            {
                string[] colums = line.Split(','); // for each line we are gonna have a comma seperate it. Split the line on line values and thats gonna put it in an array called colums.

                CharacterCreationModel cc = new CharacterCreationModel();
                cc.Id = int.Parse(colums[0]); // this is anly gonna take intergers, so if it's given anything else, it's gonna crash.
                cc.CharName = colums[1];
                cc.CharHealth = int.Parse(colums[2]);
                cc.CharIniMod = int.Parse(colums[3]);
                cc.CharNote = colums[4];
                output.Add(cc);
            }

            return output;
        }

        // This takes our models and our fileName convert them to a List of string, fileName to a FullFilePath and WriteAllLines.
        public static void SaveToCharacterFile(this List<CharacterCreationModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (CharacterCreationModel c in models)
            {
                lines.Add($" {c.Id},{c.CharName},{c.CharHealth},{c.CharIniMod},{c.CharNote}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
