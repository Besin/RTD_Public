using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (Instance != this)
            {
                Destroy(gameObject);
            }
        }
    }
    private string pathToSaveData;
    private JsonFileWriter<TalentData> savePlayerData;

    public TalentData TalentData { get; private set; }

    private void Start()
    {
        pathToSaveData = Path.Combine(Application.persistentDataPath, "talentData.json");
        savePlayerData = new JsonFileWriter<TalentData>(pathToSaveData);
        TalentData = LoadTalentData();
        SetTalentData();
    }

    public void SetTalentData()
    {
        if (TalentData == null)
        {
            TalentData = new TalentData();
        }
    }
    public void Save(TalentData playerStatistics)
    {
        savePlayerData.SerializeData(playerStatistics);
    }
    public TalentData LoadTalentData()
    {
        Debug.Log(pathToSaveData);
        return savePlayerData.DeserializeData();

    }
}
