using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourChange : MonoBehaviour
{
    public Image image;

    public Color startColor;
    public Color endColor;

    public bool repeatable = false;

    public float speed = 1.0f;
    float startTime;

    void Start()
    {
        startTime = Time.time;

        image = GetComponent<Image>();
    }


    void Update()
    {
        if (!repeatable)
        {
            float t = (Time.time - startTime) * speed;
            image.color = Color.Lerp(startColor, endColor, t);
        }
        else
        {
            float t = (Mathf.Sin(Time.time - startTime) * speed);
            image.color = Color.Lerp(startColor, endColor, t);
        }
    }
}
