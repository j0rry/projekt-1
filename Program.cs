using System.Text.Json;


class Program
{

    const string path = "items.json";
    static void Main()
    {

        List<Item> items = new List<Item>();
        ReadData(ref items);
        SaveData(items);

        items.ForEach(item => System.Console.WriteLine(item.Name));

        Console.ReadLine();
    }

    static void ReadData(ref List<Item> items){
        if(File.Exists(path)){
            string jsonString = File.ReadAllText(path);
            items = JsonSerializer.Deserialize<List<Item>>(jsonString) ?? new List<Item>();
        } else {
            items = new List<Item>
            {
                new Item { Name = "Sword", Tag = "weapon" },
                new Item { Name = "Key", Tag = "key" }
            };
            
            SaveData(items);
        }
    }
    static void SaveData(List<Item> items){
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(items, options);
        File.WriteAllText(path, jsonString);
    }
}