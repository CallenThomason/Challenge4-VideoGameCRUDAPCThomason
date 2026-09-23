

using Challenge4_VideoGameCRUDAPCThomason.Models;

namespace Challenge4_VideoGameCRUDAPCThomason.Services
{
    public class GameServices : IGameServices
    {
        private static List<GameSelection> _videoGames = [
            new GameSelection{Id = 1, Title = "God Of War", Rating = "M", Genre = "Action&Adventure", IsAvailable = true },
            new GameSelection{Id = 2, Title = "Spider Man", Rating = "T", Genre = "Action&Adventure", IsAvailable = true },
            new GameSelection{Id = 3, Title = "Marvel Rivals", Rating = "M", Genre = "PvP", IsAvailable = true },
            new GameSelection{Id = 4, Title = "Pokemon Red", Rating = "E", Genre = "RPG", IsAvailable = false },
            new GameSelection{Id = 5, Title = "Fortnite", Rating = "T", Genre = "Shooter", IsAvailable = true },
            new GameSelection{Id = 6, Title = "Minecraft", Rating = "E", Genre = "Action&Adventure", IsAvailable = false },
            new GameSelection{Id = 7, Title = "Enter the Gungeon", Rating = "T", Genre = "Rougelike", IsAvailable = true },
            new GameSelection{Id = 8, Title = "Call Of Duty Black Ops III", Rating = "M", Genre = "Shooter", IsAvailable = false },
            new GameSelection{Id = 9, Title = "Pokemon Legends ZA", Rating = "E", Genre = "RPG", IsAvailable = true },
            new GameSelection{Id = 10, Title = "Jedi: Fallen Order", Rating = "T", Genre = "Action&Adventure", IsAvailable = false }

        ];
        static int newId = 11; 

        public List<GameSelection> GetAll()
        {
            return _videoGames; 
        }

        public GameSelection GetById(int id)
        {
            GameSelection? game = _videoGames.FirstOrDefault(g => g.Id == id);
            return game; 
        }
        public List<GameSelection> GetAvailable()
        {
            IEnumerable<GameSelection> result = _videoGames; 
            result = result.Where(g => g.IsAvailable == true); 
            return result.ToList(); 
        }
        public List<GameSelection> GetByGenre(string genre)
        {
            IEnumerable<GameSelection> result = _videoGames; 
            result = result.Where(g => g.Genre == genre); 
            return result.ToList(); 
        }
        public GameSelection AddGame(GameSelection game)
        {
            game.Id = newId;
            newId++; 

            _videoGames.Add(game); 
            return game; 
        }
        public bool UpdateGame(int id, GameSelection game)
        {
            GameSelection? existing = _videoGames.FirstOrDefault(g => g.Id == id); 
            if(existing is null)
            {
                return false; 
            }
            existing.Title = game.Title; 
            existing.Rating = game.Rating;
            existing.Genre = game.Genre; 
            existing.IsAvailable = game.IsAvailable; 
            return true; 
        }
        
        public bool RemoveGame(int id)
        {
            GameSelection? existing  = _videoGames.FirstOrDefault(g => g.Id == id); 
             if(existing is null)
            {
                return false; 
            }
            _videoGames.Remove(existing); 
            return true; 
        }
            
        
    }//end of class
}//end of namespace