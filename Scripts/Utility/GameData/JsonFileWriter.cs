using System.IO;
using UnityEngine;

public class JsonFileWriter<JsonData>
{
    public string Path;

    public JsonFileWriter(string path)
    {
        Path = path;
    }

    public void SerializeData(JsonData data)
    {
        string jsonDataString = JsonUtility.ToJson(data, true);

        File.WriteAllText(Path, jsonDataString);
        Debug.Log(Path);
    }

    public JsonData DeserializeData()
    {
        if (File.Exists(Path))
        {
            string loadedJsonDataString = File.ReadAllText(Path);

            return JsonUtility.FromJson<JsonData>(loadedJsonDataString);
        }
        Debug.Log("저장된 데이터 없음");
        return default(JsonData);
    }
}
