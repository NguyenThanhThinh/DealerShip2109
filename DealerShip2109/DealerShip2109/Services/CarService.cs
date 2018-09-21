using System;
using System.Collections.Generic;
using DealerShip2109.Data;
using DealerShip2109.ViewModels.Cars;
using Microsoft.AspNetCore.Http;

namespace DealerShip2109.Services
{
    public class CarService:ICarService
    {
        public IEnumerable<Car> All(string sort, string searchQuery, int page = 1, int pageSize = 6)
        {
            throw new NotImplementedException();
        }

        public void SendEMail(BuyCarFormModel personInfo, Car carToBuy)
        {
            throw new NotImplementedException();
        }

        public void Add(Car addCarFormModel, ICollection<IFormFile> images)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, Car editCarFormModel, ICollection<IFormFile> images)
        {
            throw new NotImplementedException();
        }

        public void Delete(int IdToRemove)
        {
            throw new NotImplementedException();
        }

        public void DeletePhoto(int photoId)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Car FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> SearchCars(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
