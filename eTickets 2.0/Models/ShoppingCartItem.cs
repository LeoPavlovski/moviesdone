using System.ComponentModel.DataAnnotations;

namespace eTickets_2._0.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public int Amount { get; set; }
        
        //cleaing up the shopping card

        public string ShoppingCartId { get; set; }

    }
}
