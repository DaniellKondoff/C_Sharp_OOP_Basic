using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private CarManager manager;
    public Engine()
    {
        this.manager = new CarManager();
    }

    public void Run()
    {
        string command = string.Empty;

        while ((command = Console.ReadLine()) != "Cops Are Here")
        {
            var cmdArgs = command.Split(' ');
            ExecuteCommand(cmdArgs);
        }
    }

    public void ExecuteCommand(string[] cmdArgs)
    {
        switch (cmdArgs[0])
        {
            case "register":
                int id = int.Parse(cmdArgs[1]);
                string type = cmdArgs[2];
                string brand = cmdArgs[3];
                string model = cmdArgs[4];
                int yearOfProduction = int.Parse(cmdArgs[5]);
                int horsepower = int.Parse(cmdArgs[6]);
                int acceleration = int.Parse(cmdArgs[7]);
                int suspension = int.Parse(cmdArgs[8]);
                int durability = int.Parse(cmdArgs[9]);
                manager.Register(id, type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            case "check":
                Console.WriteLine(manager.Check(int.Parse(cmdArgs[1])));
                break;
            case "open":
                id = int.Parse(cmdArgs[1]);
                type = cmdArgs[2];
                int length = int.Parse(cmdArgs[3]);
                string route = cmdArgs[4];
                int prizePoo = int.Parse(cmdArgs[5]);
                manager.Open(id, type, length, route, prizePoo);
                break;
            case "participate":
                int carId = int.Parse(cmdArgs[1]);
                int raceId = int.Parse(cmdArgs[2]);
                manager.Participate(carId, raceId);
                break;
            case "start":
                raceId = int.Parse(cmdArgs[1]);
                Console.WriteLine(manager.Start(raceId));
                break;
            case "park":
                carId = int.Parse(cmdArgs[1]);
                manager.Park(carId);
                break;
            case "unpark":
                carId = int.Parse(cmdArgs[1]);
                manager.Unpark(carId);
                break;
            case "tune":
                int tuneIndex = int.Parse(cmdArgs[1]);
                string tuneAddOn = cmdArgs[2];
                manager.Tune(tuneIndex, tuneAddOn);
                break;
        }
    }
}

