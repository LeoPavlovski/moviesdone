using eTickets_2._0.Data.Base;
using eTickets_2._0.Data.ViewModels;
using eTickets_2._0.Models;

namespace eTickets_2._0.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
    }
}
