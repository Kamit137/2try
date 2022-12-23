using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPaused : MonoBehaviour
{
    public GameObject menuPaused;
    [SerializeField] KeyCode keyMenuPaused;
    public bool isMenuPaused = false;
    public Player_Camera cam;
    private void Start()
    {
        menuPaused.SetActive(false);
    }

    private void Update()
    {
        ActiveMenu();
    }
    void ActiveMenu()
    {
        if (Input.GetKeyDown(keyMenuPaused))
        {
            isMenuPaused = !isMenuPaused;
        }

        if (isMenuPaused)
        {
            menuPaused.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            cam.enabled = false;
        }
        else
        {
            menuPaused.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
            cam.enabled = true;
        }
    }

    public void MunePausedContinue()
    {
        isMenuPaused = false;
    }

    public void MunePausedSettings()
    {
        Debug.Log("Настройки");
    }

    public void MunePausedMainMenu()
    {
        Debug.Log("Главное меню");
    }
}
