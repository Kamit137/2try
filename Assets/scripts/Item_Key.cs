using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Item_Key : MonoBehaviour
{
    public bool GetKeys = false ;
    public GameObject key;
    public string texttrigger = "my text";
    public TMP_Text text;


    void Update()
    {
        if (GetKeys == true)
        {
            Destroy(key);
            text.text = texttrigger;
        }
    }
    public void Item()
    {
        GetKeys = true;
    }
}
