using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GVRButton : MonoBehaviour
{
    public Image pngCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;

    public float gvrTimer;

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        pngCircle.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            pngCircle.fillAmount = gvrTimer / totalTime;
        }
        if(gvrTimer > totalTime)
        {
            GVRClick.Invoke();
        }
    }
}
