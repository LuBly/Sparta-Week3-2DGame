using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonManager : MonoBehaviour
{
    [SerializeField] TMP_InputField inputData;
    [SerializeField] GameObject CharacterListUI;

    public void LoadMainScene()
    {
        if(inputData.text.Length > 0)
        {
            DataManager.Instance.playerInfo.name = inputData.text;
            SceneManager.LoadScene("MainScene");
        }
        else
            SceneManager.LoadScene("StartScene");
    }    

    public void OpenCharacterListUI()
    {
        CharacterListUI.SetActive(true);
    }
}
