public abstract class Monument
{
    private string name;

    protected Monument(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public abstract int GetAffinity();

    public override string ToString()
    {
        var name = this.GetType().Name;
        var index = name.IndexOf("Monument");
        name = name.Insert(index, " ");

        return $"###{name}: {this.Name},";
    }
}