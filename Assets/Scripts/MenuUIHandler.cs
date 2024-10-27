using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void SavePlayerName()
    {
        if (nameInput != null && GameDataManager.Instance != null)
        {
            GameDataManager.Instance.PlayerName = nameInput.text;
            Debug.Log("Name entered: " + nameInput.text);
        }
    }
    
    // Start is called before the first frame update
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit(); // original code to quit Unity player
    #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
