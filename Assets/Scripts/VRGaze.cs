using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRGaze : MonoBehaviour
{
    public Image pngGaze;
    public float totalTime = 2;
    bool gvrStatus;
    float gvrTimer;

    public int distanceOfRay = 10;
    private RaycastHit _hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            pngGaze.fillAmount = gvrTimer / totalTime;
        }
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        if(Physics.Raycast(ray,out _hit, distanceOfRay))
        {
            if(pngGaze.fillAmount == 1 && _hit.transform.CompareTag("AnimatedAnimal"))
            {
                _hit.transform.gameObject.GetComponent<PlayAnimation>().PlayAnim();
            }
        }
        
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        pngGaze.fillAmount = 0;
    }
}
