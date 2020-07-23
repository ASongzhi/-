using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {

    private void CostMoney()
    {
        string temp1 = this.transform.Find("Money/Text").GetComponent<Text>().text;
        int money = int.Parse(temp1);
        var button = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        string temp2 = button.transform.Find("cost").GetComponent<Text>().text;
        int cost = int.Parse(temp2);
        if (money >= cost)
        {
            money = money - cost;
            Debug.Log(money);
            button.SetActive(false);
        }
        else
        {
            
        }
        this.transform.Find("Money/Text").GetComponent<Text>().text = money.ToString();


    }

}
