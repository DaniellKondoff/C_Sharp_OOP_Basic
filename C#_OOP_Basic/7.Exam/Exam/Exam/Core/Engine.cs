using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private DraftManager manager;
    private bool isRunning;

    public Engine()
    {
        this.manager = new DraftManager();
        this.isRunning = true;
    }
    public void Run()
    {
        while (this.isRunning)
        {
            string inputCommands = Console.ReadLine();
            List<string> cmdArgs = inputCommands.Split(' ').ToList();
            ExecuteCommand(cmdArgs);
        }
    }

    private void ExecuteCommand(List<string> cmdArgs)
    {
        string command = cmdArgs[0];
        cmdArgs.Remove(command);

        switch (command)
        {
            case "RegisterHarvester":
                var resultHarvester = this.manager.RegisterHarvester(cmdArgs);
                Console.WriteLine(resultHarvester);
                break;
            case "RegisterProvider":
                var resultProvider = this.manager.RegisterProvider(cmdArgs);
                Console.WriteLine(resultProvider);
                break;
            case "Day":
                var dayResult = this.manager.Day();
                Console.WriteLine(dayResult);
                break;
            case "Mode":
                var modeResult = this.manager.Mode(cmdArgs);
                Console.WriteLine(modeResult);
                break;
            case "Check":
                var checkResult = this.manager.Check(cmdArgs);
                Console.WriteLine(checkResult);
                break;
            case "Shutdown":
                var result = this.manager.ShutDown();
                Console.WriteLine(result);
                isRunning = false;
                break;
        }
    }
}

