using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMVC.Models;

namespace VidlyMVC.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }

        public string Tilte
        {
             get
             {
                 if (Movie != null && Movie.Id != 0)
                     return "Edit Movie";
 
                 return "New Movie";
             }
            
        }

    }
}