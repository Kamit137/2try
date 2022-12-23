using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sense : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {

        TP();
    }
    void TP()
    {
        SceneManager.LoadScene("ESCAPE1", LoadSceneMode.Single);
    }

}
