using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Garage
{
    public Garage()
    {
        this.ParkedCars = new List<int>();
    }

    public List<int> ParkedCars { get; set; }

    public void AddCar(int carId)
    {
        this.ParkedCars.Add(carId);
    }

    public void RemoveCar(int carId)
    {
        this.ParkedCars.Remove(carId);
    }
}

