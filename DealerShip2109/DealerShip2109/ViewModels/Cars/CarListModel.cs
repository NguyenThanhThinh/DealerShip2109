using System.Collections.Generic;
using DealerShip2109.Data;

namespace DealerShip2109.ViewModels.Cars
{
    public class CarListModel
    {
        public IEnumerable<Car> Cars { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public int PreviousPage => CurrentPage == 1 ? 1 : CurrentPage - 1;

        public int NextPage => CurrentPage == TotalPages ? TotalPages : CurrentPage + 1;

        public string SearchQuery { get; set; }

        public string Sort { get; set; }
    }
}