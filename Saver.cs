using System.Text.Json;
class Saver
{
    const string path = "items.json";

    public void ReadData(ref List<Item> items){
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

    public void SaveData(List<Item> items){
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(items, options);
        File.WriteAllText(path, jsonString);
    }
}