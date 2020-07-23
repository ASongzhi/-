using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneFunction;
using Fungus;
using Data;

public class hotelmanager : MonoBehaviour {
    public Flowchart[] flowchart;
	// Use this for initialization
	void Start () {
        int state = ES2.Load<int>(Function.temp + Function.t_chat_hotel);
        TalkFunc.ShowChat(state,flowchart);
        if (state==0)
        {
            ES2.Save(state+1, Function.temp + Function.t_chat_hotel);
        }
    }

    public string scene;
    public void Leave()
    {
        SceneFunc.LoadScene(SceneFunc.GetState(),scene);
    }
}
