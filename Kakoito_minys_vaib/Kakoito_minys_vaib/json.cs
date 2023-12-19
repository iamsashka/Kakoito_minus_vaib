﻿using Newtonsoft.Json;

namespace MyApp;

public static class json
{
    public static void Serialize<J>(List<J> list, string path)
    {
        string json = JsonConvert.SerializeObject(list);
        File.WriteAllText(path, json);
    }

    public static List<J>? Deserialize<J>(string path)
    {
        string text = File.ReadAllText(path);
        List<J> result = JsonConvert.DeserializeObject<List<J>>(text);
        return result;
    }

    internal static void Save(List<Polzovatel> users)
    {
        throw new NotImplementedException();
    }

    internal static List<Polzovatel>? Load()
    {
        throw new NotImplementedException();
    }
}