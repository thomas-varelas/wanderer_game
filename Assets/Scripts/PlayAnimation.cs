using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    //public GameObject player;

    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (anim.isPlaying)
        {
            return;
        }
    }

    public void PlayAnim()
    {
        anim.Play("Howl");
        Debug.Log("PLAYED ANIM");
    }
}
