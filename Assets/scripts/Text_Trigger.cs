using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Text_Trigger : MonoBehaviour
{
    public string texttrigger = "my text";
    public TMP_Text text;

    private void OnTriggerEnter(Collider other)
    {
        text.text = texttrigger;
    }
}