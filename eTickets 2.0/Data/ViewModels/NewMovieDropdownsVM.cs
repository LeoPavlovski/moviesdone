using eTickets_2._0.Controllers;
using eTickets_2._0.Models;

namespace eTickets_2._0.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
            Producers = new List<Producer> ();
            Cinemas = new List<Cinema>();
            Actors = new List<Actor>();
            //Enum values are already created.

        }
        public List< Producer> Producers { get; set; }
        public List< Cinema> Cinemas { get; set; }
        public List<Actor> Actors { get; set; }

    }
}
