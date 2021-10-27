using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearComputer : MonoBehaviour
{

    public TimelineController timelineController;
    public GameObject over2;
    bool done = false;

    private void Start()
    {
        timelineController = GameObject.Find("TimelineController").GetComponent<TimelineController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (over2.activeSelf && other.tag == "Player" && !done)
        {
            timelineController.Play(3);
            done = true;
        }
    }
}
