using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data;

public class toolscene : MonoBehaviour {
    
    public void DeleteSaveData()
    {
        ES2.Delete(Function.mainpath);
    }

    public void CreatNewData()
    {
        Function.CreatSaveData();
    }
}
