using Marvel.Application.Characters.Interfaces;
using Marvel.Domain.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marvel.Infraestructure.Characters
{
    public class CharacterRepository : ICharacterRepository
    {
        private List<Character> characters = new List<Character>();
        public List<Character> GetAllCharacters()
        {
            return characters;
        }
        

    }
}
