using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal cardal;
        public CarManager(ICarDal cardal)
        {
            this.cardal = cardal;
        }
        public void Add(Car car)
        {
            this.cardal.Add(car);
        }

        public void Delete(Car car)
        {
            this.cardal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return this.cardal.GetAll();
        }

        public void Update(Car car)
        {
            this.cardal.Update(car);
        }
    }
}
