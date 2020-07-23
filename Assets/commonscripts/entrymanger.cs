using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneFunction;

/// <summary>
/// 这个是进入某场景的脚本，要手动输入场景名称
/// </summary>
public class entrymanger : MonoBehaviour {
    public string scenename;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("OnTriggerStay2D OK");
        if (Input.GetKey("e"))
        {
            Debug.Log("Fire3 OK");
            SceneFunc.SaveCurrentTransform(collision.transform);
            SceneFunc.LoadScene(PlayerPrefs.GetInt(SceneFunc.gamestate),scenename);
        }
    }
}
