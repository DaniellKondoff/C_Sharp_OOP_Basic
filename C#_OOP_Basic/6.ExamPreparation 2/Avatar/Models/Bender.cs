﻿public abstract class Bender
{
    private string name;
    private int power;

    protected Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public int Power
    {
        get
        {
            return this.power;
        }
        set
        {
            this.power = value;
        }
    }

    public abstract double GetPower();

    public override string ToString()
    {
        var name = this.GetType().Name;
        var index = name.IndexOf("Bender");
        name = name.Insert(index, " ");

        return $"###{name}: {this.Name}, Power: {this.Power},";
    }
}