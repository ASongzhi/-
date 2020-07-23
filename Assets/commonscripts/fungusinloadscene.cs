using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneFunction;
public class fungusinloadscene : MonoBehaviour {
    public string name;
	void Start () {
        SceneFunc.LoadScene(PlayerPrefs.GetInt(SceneFunc.gamestate),name);
	}
}
