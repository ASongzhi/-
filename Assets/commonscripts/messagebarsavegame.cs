using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Data;
public class messagebarsavegame : MonoBehaviour {
    public int statecode;
    string path;
    public Text _name, round, money;

    void Start()
    {
        Check();
    }

    void Check()
    {
        switch (statecode)
        {
            case 0:
                path = Function.savedata0;
                break;
            case 1:
                path = Function.savedata1;
                break;
            case 2:
                path = Function.savedata2;
                break;
            default:
                path = Function.savedata0;
                break;
        }
        if (ES2.Load<bool>(path + Function.t_iswrite) == true)
        {
            _name.text = ES2.Load<string>(path + Function.t_name);
            round.text = ES2.Load<int>(path + Function.t_round) + " round";
            money.text = ES2.Load<int>(path + Function.t_money) + " piece";
        }
        else
        {
            _name.text = "none";
            round.text = "";
            money.text = "";
            
        }
    }

    public GameObject warning;
    void ShowSaveWarning()
    {
        warning.SetActive(true);
    }
    
    public void OverWrite()
    {
        SaveData temp = Function.LoadSaveData(3);
        temp.is_Data_Writed = true;
        Function.SaveToData(temp,statecode);
        warning.SetActive(false);
        Check();
    }

    public void SaveGame()
    {
        if (ES2.Load<bool>(path + Function.t_iswrite) == true)
        {
            ShowSaveWarning();
        }
        else
        {
            SaveData temp = Function.LoadSaveData(3);
            temp.is_Data_Writed = true;
            Function.SaveToData(temp,statecode);
            Check();
        }
    }
}
