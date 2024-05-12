using TMPro;
using UnityEngine;

public class MainButtonManager : MonoBehaviour
{
    [SerializeField] GameObject nameUI;
    [SerializeField] GameObject characterListUI;
    
    [SerializeField] TMP_InputField inputData;
    [SerializeField] CharacterInfoHandler characterInfoHandler;
    
    public void OpenNameUI()
    {
        nameUI.SetActive(true);
    }

    public void OpenCharacterListUI()
    {
        characterListUI.SetActive(true);
    }

    public void ChangeName()
    {
        if(inputData.text.Length > 0) 
        {
            characterInfoHandler.SetName(inputData.text);
            // inputData 초기화
            inputData.text = "";
            nameUI.SetActive(false);
        }
        else
        {
            inputData.text = "";
        }
    }
}
