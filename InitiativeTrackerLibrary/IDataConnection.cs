using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using InitiativeTrackerLibrary.Models;

namespace InitiativeTrackerLibrary
{
    public interface IDataConnection
    {
        CharacterCreationModel SaveCharacter(CharacterCreationModel model);


        List<CharacterCreationModel> GetCharacter_All();
    }
}
