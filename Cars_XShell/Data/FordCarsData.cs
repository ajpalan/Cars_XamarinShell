using System;
using System.Collections.Generic;
using Cars_XShell.Models;

namespace Cars_XShell.Data
{
    public static class FordCarsData
    {
        public static IList<Car> FordCars { get; private set; }

        static FordCarsData()
        {
            FordCars = new List<Car>();

            FordCars.Add(new Car() { CarName = "Ford Figo", ImageUrl = "https://stimg.cardekho.com/images/carexteriorimages/930x620/Ford/Figo/7594/1627023729889/front-left-side-47.jpg" });            
            FordCars.Add(new Car() { CarName = "Ford Ecosports", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWAVFAycWjXZkOzQeMlfdcG84NOTX9ZQhJuw&usqp=CAU" });

        }
    }
}
