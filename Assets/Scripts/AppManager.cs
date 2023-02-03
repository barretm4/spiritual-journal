using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public GameObject NewEntryPrefab;
    public Transform PanelLocation;

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

    public void OpenEntry (GameObject JournalEntry)
    {
        Instantiate(JournalEntry, PanelLocation);
    }
}
