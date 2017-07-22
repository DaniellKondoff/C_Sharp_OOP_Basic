using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private NationsBuilder builder;
    private bool isRunning;

    public Engine()
    {
        this.builder = new NationsBuilder();
        this.isRunning = true;
    }

    public void Run()
    {
        while (this.isRunning)
        {
            string inputCommands = this.ReadInput();
            List<string> cmdArgs = this.InputPars(inputCommands);
            ExecuteCommand(cmdArgs);
        }
    }

    private List<string> InputPars(string inputCommands)
    {
        return inputCommands.Split(' ').ToList();
    }

    private string ReadInput()
    {
        return Console.ReadLine();
    }

    public void ExecuteCommand(List<string> cmdArgs)
    {
        string command = cmdArgs[0];
        cmdArgs.Remove(command);

        switch (command)
        {
            case "Bender":
                this.builder.AssignBender(cmdArgs);
                break;

            case "Monument":
                this.builder.AssignMonument(cmdArgs);
                break;

            case "Status":
                string statusType = cmdArgs[0];
                string status = this.builder.GetStatus(statusType);
                this.OutputWriter(status);
                break;

            case "War":
                string war = cmdArgs[0];
                this.builder.IssueWar(war);
                break;

            case "Quit":
                string record = this.builder.GetWarsRecord();
                this.OutputWriter(record);
                this.isRunning = false;
                break;
        }
    }

    private void OutputWriter(string result)
    {
        Console.WriteLine(result);
    }
}