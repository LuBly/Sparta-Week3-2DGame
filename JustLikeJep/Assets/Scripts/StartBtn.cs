using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputData;

    public void LoadMainScene()
    {
        if(inputData.text.Length > 0)
        {
            DataManager.Instance.SavePlayerInfo(inputData.text);
            SceneManager.LoadScene("MainScene");
        }
        else
            SceneManager.LoadScene("StartScene");
        
    }    
}
