using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void CloseUIPanel(GameObject objecttoclose)
    {
        objecttoclose.SetActive(false);
    }
}
