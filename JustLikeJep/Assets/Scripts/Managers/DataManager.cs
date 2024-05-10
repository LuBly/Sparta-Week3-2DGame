using UnityEngine;

public class DataManager : MonoBehaviour
{
    private static DataManager instance;
    public PlayerInfoSO playerInfo;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public static DataManager Instance
    {
        get
        {
            if(instance == null)
            {
                return null;
            }
            return instance;
        }
    }

    public void SavePlayerInfo(string inputName)
    {
        playerInfo.name = inputName;
    }
}
