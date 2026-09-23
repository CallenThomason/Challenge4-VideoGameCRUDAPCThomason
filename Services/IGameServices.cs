using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenge4_VideoGameCRUDAPCThomason.Models;

namespace Challenge4_VideoGameCRUDAPCThomason.Services
{
    public interface IGameServices
    {
        List<GameSelection> GetAll(); 
        GameSelection GetById(int id); 
        List<GameSelection> GetAvailable(); 
        List<GameSelection> GetByGenre(string genre); 
        GameSelection AddGame(GameSelection game); 
        bool UpdateGame(int id, GameSelection game); 
        bool RemoveGame(int id); 

    }
}