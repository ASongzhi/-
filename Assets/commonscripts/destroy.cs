using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroy : MonoBehaviour
{

    public void OnClick()
    {
        this.gameObject.SetActive(false);

        Time.timeScale = 1;

    }
}
