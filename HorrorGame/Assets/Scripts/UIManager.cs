using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] TMP_Text[] dialogs;
    [SerializeField] Sprite[] lifesprites;
    [SerializeField] GameObject[] panelcontroller;


    private void Update()
    {
        if (panelcontroller[0] != null)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                panelcontroller[0].SetActive(true);
                Time.timeScale = 0;

            }
        }
    }

    public void QuitPause()
    {
        panelcontroller[0].SetActive(false);
        Time.timeScale = 1;
    }
    public void StarGame()
    {
        SceneManager.LoadScene(1);
    }


}
