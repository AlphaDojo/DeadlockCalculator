using System.Net.Http.Json;

namespace DeadlockCalculator.Models
{
    public class CharacterService
    {
        private readonly HttpClient _http;
        private bool _isLoaded = false;
        public List<Character> CharacterList = new List<Character>();
        private Character? _selectedCharacter;

        public async Task LoadAsync()
        {
            if (_isLoaded)
            {
                return;
            } 

            var data = await _http.GetFromJsonAsync<List<Character>>("data/character.json");

            if (data != null)
            {
                CharacterList = data;
            }
                

            _isLoaded = true;
        }

        public CharacterService(HttpClient http)
        {
            _http = http;
        }

        public List<Character> GetAllCharacters() => CharacterList;


//fix this later
        public void SetSelected(Character c)
        {
            _selectedCharacter = new Character(c);
        }

        public Character? GetSelected()
        {
            return _selectedCharacter;
        }
    }
}