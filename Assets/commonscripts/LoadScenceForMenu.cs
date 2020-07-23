using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneFunction;

public class LoadScenceForMenu : MonoBehaviour {

    public string scencename;

	public void LoadScence()
    {
            SceneFunc.LoadScene(PlayerPrefs.GetInt(SceneFunc.gamestate), scencename);
 
     }  
}
