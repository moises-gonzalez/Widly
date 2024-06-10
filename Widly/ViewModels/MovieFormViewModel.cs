using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using Widly.Models;

namespace Widly.ViewModels
{
    public class MovieFormViewModel
    {

        public IEnumerable<Genre> Genres { get; set; }

        public Movie Movie { get; set; }

        public string Title 
        { get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit Movie";

                return "New movie";
            } 
        }

    }
}