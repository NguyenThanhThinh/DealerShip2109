using System.Collections.Generic;
using DealerShip2109.Data;
using DealerShip2109.ViewModels.Cars;
using Microsoft.AspNetCore.Http;

namespace DealerShip2109.Services
{
    public interface ICarService
    {
        IEnumerable<Car> All(string sort, string searchQuery, int page = 1, int pageSize = 6);

        void SendEMail(BuyCarFormModel personInfo, Car carToBuy);

        void Add(Car addCarFormModel, ICollection<IFormFile> images);

        void Edit(int id, Car editCarFormModel, ICollection<IFormFile> images);

        void Delete(int IdToRemove);

        void DeletePhoto(int photoId);

        bool Exists(int id);

        Car FindById(int id);

        IEnumerable<Car> SearchCars(string searchQuery);
    }
}