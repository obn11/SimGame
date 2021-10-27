using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthControl : MonoBehaviour
{
    public GameObject reply;
    public TimelineController timelineController;
    bool done = false;
    bool done2 = false;

    // Start is called before the first frame update
    void Start()
    {
        timelineController = GameObject.Find("TimelineController").GetComponent<TimelineController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!done)
        {
            reply.SetActive(true);
            ShowEarth();
            done = true;
        }
        
        if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)) && !done2)
        {
            timelineController.Play(4);
            reply.SetActive(false);
            ReplyAnim();
            done2 = true;
        }
    }

    void ShowEarth()
    {
        Debug.Log("TODO: show earth");
    }

    void ReplyAnim()
    {
        Debug.Log("TODO: reply animation");
    }
}

   
