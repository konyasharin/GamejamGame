using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject panel;
    public GameObject btnPlay;
    public GameObject btnPause;
    public Image image;

    public void play()
    {
        Time.timeScale = 1f;
        image.enabled = false;
    }
    public void pause()
    {
        Time.timeScale = 0f;
        image.enabled = true;
    }
}
