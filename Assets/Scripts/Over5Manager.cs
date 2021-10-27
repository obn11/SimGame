using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Over5Manager : MonoBehaviour
{
    public TimelineController timelineController;

    bool done = false;
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
            done = true;
            timelineController.Play(6);
        }
    }
}
