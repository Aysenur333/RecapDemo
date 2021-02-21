using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.ModelYear + " " + car.Description);
            }
            Console.WriteLine("-------------------------------------");

            foreach (var car in carManager.GetById(5))
            {
                Console.WriteLine(car.CarId + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.ModelYear + " " + car.Description);
            }
            Console.WriteLine("-------------------------------------");


            



            ICarDal carDal = new InMemoryCarDal();
            Car car1 = new Car { CarId=6,BrandId=6,ColorId=1,DailyPrice=2000,ModelYear=2021,Description="Yeni eklendi"};
            

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId + " " + car.BrandId + " " + car.ColorId + " " + car.DailyPrice + " " + car.ModelYear + " " + car.Description);
            }

            Console.ReadLine();
        }
    }
}
