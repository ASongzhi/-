using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuManager : MonoBehaviour {

    public GameObject Menu;
    public GameObject gameInfo;
    public GameObject help;
    public GameObject setting;

    private bool flag = false;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (!flag)
            {
                Menu.SetActive(true);
                Time.timeScale = 0;
                flag = true;
                
            }
            else
            {
                Menu.SetActive(false);
                Time.timeScale = 1;
                flag = false;
            }
 
    }


    public void GameInfo()
    {
        gameInfo.SetActive(true);
    }

    public void Help()
    {
        help.SetActive(true);
    }

    public void Setting()
    {
        setting.SetActive(true);
    }

    private void OnDestroy()
    {
        Time.timeScale = 1;
       
    }



}
