using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Play Game from Main Menu
    public void OnPlayClick()
    {
        Debug.Log("Play Game");
    }

    //Exit Game from Main Menu
    public void OnQuitClick()
    {
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }
}
