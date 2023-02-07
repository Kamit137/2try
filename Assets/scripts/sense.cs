using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sense : MonoBehaviour
{
    public string nameSence;
    private void OnTriggerEnter(Collider other)
    {

        TP();
    }
    void TP()
    {
        SceneManager.LoadScene(nameSence, LoadSceneMode.Single);
    }

}
