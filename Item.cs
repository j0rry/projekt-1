class Item
{
    public string Name { get; set; } = string.Empty;

    public string Tag { get; set;} = string.Empty;
    public int Damage { get; set; }

    public Item()
    {
        Damage = Random.Shared.Next(100);
    }

    public void ShowStats(){
        System.Console.WriteLine($"Item Name: {Name},  Damage: {Damage}");
    }
}