﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private List<int> racesClosed;
    private Garage garage;
    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        garage = new Garage();
        this.racesClosed = new List<int>();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
    {
        if (type == "Performance")
        {
            this.cars.Add(id, new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension,durability));
        }
        else
        {
            this.cars.Add(id, new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
        }
    }
    public string Check(int id)
    {
        return this.cars[id].ToString();
    }
    public void Open(int id, string type, int length, string route, int prizePool)
    {
        switch (type)
        {
            case "Casual":
                this.races.Add(id, new CasualRace(length, route, prizePool));
                break;
            case "Drag":
                this.races.Add(id, new DragRace(length, route, prizePool));
                break;
            case "Drift":
                this.races.Add(id, new DriftRace(length, route, prizePool));
                break;
        }
    }
    public void Participate(int carId, int raceId)
    {
        if (!garage.ParkedCars.Contains(carId))
        {
            if (!racesClosed.Contains(carId))
            {
                this.races[raceId].Participants.Add(carId, cars[carId]);
            }
        }
    }
    public string Start(int id)
    {
        if (races[id].Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }
        var result = this.races[id].StartRace();
        this.racesClosed.Add(id);
        return result;
    }
    public void Park(int id)
    {
        foreach (var race in this.races.Where(r=>!racesClosed.Contains(r.Key)))
        {
            if (race.Value.Participants.ContainsKey(id))
            {
                return;
            }
        }
        this.garage.AddCar(id);
    }
    public void Unpark(int id)
    {
        this.garage.RemoveCar(id);
    }
    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var id in this.garage.ParkedCars)
        {
            var car = cars[id];
            car.Tune(tuneIndex, addOn);
        }
    }
}

