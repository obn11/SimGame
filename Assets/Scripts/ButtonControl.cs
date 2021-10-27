using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public Light light;
    public GameObject startOver;
    public TimelineController timelineController;
    bool done = false;
    float ind = 0f;

    private void Start()
    {
        timelineController = GameObject.Find("TimelineController").GetComponent<TimelineController>();
    }

    void OnTriggerStay(Collider button)
    {
        if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space)) && startOver.activeSelf && !done)
        {
            light.enabled = true;
            timelineController.Play(2);
            done = true;
        }

        
        
    }

    private void Update()
    {
        if (light.enabled == true)
        {
            ind++;
            light.intensity = (0.5f) * (float)(Math.Sin((ind/110f))) + 1f;
        }
    }
}
