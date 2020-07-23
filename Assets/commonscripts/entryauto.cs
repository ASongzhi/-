using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SceneFunction;
using UnityEngine.SceneManagement;

public class entryauto : MonoBehaviour {
    public string _name;

    private void OnTriggerStay2D(Collider2D collision)
    {
        SceneManager.LoadScene(_name);
    }

}
