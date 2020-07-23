using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneFunction;
using Data;

public class titlescenemanager : MonoBehaviour {

    private void Awake()
    {
        SceneFunc.TitlesceneCheck();
    }
    void Start () {
        

	}
    public string name;
    public void NewGame()
    {
        ES2.Save(true,Function.temp+Function.t_iswrite);
        SceneFunc.LoadScene(3,name);
    }

    public void QuitGame()
    {
        SceneFunc.ExitGame();
    }
}
