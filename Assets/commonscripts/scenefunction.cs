using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Data;
using Fungus;

namespace  SceneFunction
{
    
    public static class SceneFunc{
        //用状态码来调控场景之间
        //直接将其定义为常量
        /*
         * 约定
         * 存档状态码
         * 新游戏----3
         * 存档1-----0---savedata0
         * 存档2-----1---savedata1
         * 存档3-----2---savedata2
         */
        public const string gamestate = "gamestate";
        public const int c_newgame=3;
        public const int c_save0 = 0;
        public const int c_save1 = 1;
        public const int c_save2 = 2;

        public const string t_playerposition = Function.elsedata + "?tag=playerposition";
        //通用载入场景
        public static void LoadScene(int state,string scenename)
        {
            PlayerPrefs.SetInt(gamestate,state);
            SceneManager.LoadScene(scenename);
        }
        //获取场景状态码
        public static int GetState()
        {
            return PlayerPrefs.GetInt(gamestate);
        }
        
        //标题菜单检查存档是否存在
        public static void TitlesceneCheck()
        {
            if (!Function.Is_exist_saveData())
            {
                Function.CreatSaveData();
            }
        }

        //记录角色当前位置
        public static void SaveCurrentTransform(Transform position)
        {
            ES2.Save<Transform>(position,t_playerposition);
        }
        public static Transform LoadCurrenTransform()
        {
            Transform temp = ES2.Load<Transform>(t_playerposition);
            return temp;
        }
        //退出游戏
        public static void ExitGame()
        {
            Function.Deletetemp();
            ES2.Delete(t_playerposition);
            Application.Quit();
        }

        

    }
	
    public static class TalkFunc
    {
        public static void ShowChat(int state,Flowchart[] flowchart)
        {
            flowchart[state].gameObject.SetActive(true);
        }
    }
}
