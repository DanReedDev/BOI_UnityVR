using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GazeButton : MonoBehaviour
{
    public UnityEvent gazeClick;

    public Image imgLoadUI;

    bool GazeStatus;

    public float totalTime = 2f;
    public float GazeTimer;

    void Update()
    {
        if (GazeStatus)
        {
            GazeTimer += Time.deltaTime;
            imgLoadUI.fillAmount = GazeTimer / totalTime;
        }

        if (GazeTimer > totalTime)
        {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
    }
    public void GazeOn()
    {
        GazeStatus = true;
    }

    public void GazeOff()
    {
        GazeStatus = false;
        GazeTimer = 0;
        imgLoadUI.fillAmount = 0;
    }
}
