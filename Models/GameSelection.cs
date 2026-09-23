using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge4_VideoGameCRUDAPCThomason.Models
{
    public class GameSelection
    {
        public int Id {get; set;}
        public string Title {get; set;}
        public string Rating{get; set;}
        public string Genre{get; set;}
        public bool IsAvailable{get; set;}
    }
}