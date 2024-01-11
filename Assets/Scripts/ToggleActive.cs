using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleActive : MonoBehaviour
{
    [SerializeField] private GameObject[] gameObjects;
    
    public void Toggle()
    {
        foreach(GameObject g in gameObjects)
        {
            g.SetActive(!g.activeInHierarchy);
        }
    }

    public void ToggleWait(float time)
    {
        foreach(GameObject g in gameObjects)
        {
            g.SetActive(!g.activeInHierarchy);
        }

        Invoke("Toggle",time);
    }
    
}
