
using Challenge4_VideoGameCRUDAPCThomason.Models;
using Challenge4_VideoGameCRUDAPCThomason.Services;
using Microsoft.AspNetCore.Mvc;

namespace Challenge4_VideoGameCRUDAPCThomason.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameServices _games; 

        public GameController(IGameServices games)
        {
            _games = games; 
        }

        [HttpGet("GetAllGames")]
        public ActionResult GetAllGames()
        {
            return Ok(_games.GetAll()); 
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<GameSelection> GetById(int id)
        {
            GameSelection game = _games.GetById(id);
            if(game is null)
            {
                return NotFound($"The Id {id} is not available in out catalog"); 
            }//end if
            return Ok(game); 
        }//end of GetById

        [HttpGet("GetAvailable")]
        public ActionResult<GameSelection> GetAvailable()
        {
           List<GameSelection> game = _games.GetAvailable(); 
           return Ok(game);  
        }
         [HttpGet("GetGenre/{genre}")]
        public ActionResult<GameSelection> GetGenre(string genre)
        {
           List<GameSelection> game = _games.GetByGenre(genre); 
           return Ok(game);  
        }
        [HttpPost("AddGame")]
        public ActionResult<GameSelection> AddGame([FromBody] GameSelection game)
        {
            GameSelection newGame = _games.AddGame(game);
            return CreatedAtAction(
                nameof(GetById),
                new{id = newGame.Id},
                newGame
            );

        }
    //     {
    // "Id" : 1, 
    // "Title" : "God Of War",
    // "Rating" : "M" ,
    // "Genre" : "Action/Adventure",
    // "IsAvailable" : true 
    // }
    //FOR TESTING ^^^^^^^

    [HttpPut("UpdateGame/{id}")]
    public ActionResult<bool> Update(int id, GameSelection game)
        {
            bool update = _games.UpdateGame(id, game);
            if (!update)
            {
                return NotFound($"No Game was found with the Id {id} in our catalog");
            }//end if
            return NoContent(); 
        }//end of update

        [HttpDelete("RemoveGame/{id}")]
        public ActionResult<bool> RemoveGame(int id)
        {
            bool isRemoved = _games.RemoveGame(id);

            if (!isRemoved)
            {
                return NotFound($"No game with id {id} was found in our catalog");
            }
            return NoContent();
        }

    }
}