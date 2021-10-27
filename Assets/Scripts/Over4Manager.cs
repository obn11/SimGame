using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Over4Manager : MonoBehaviour
{
    public GameObject replyUs;
    public TimelineController timelineController;
    bool done = false;
    bool done2 = false;
    public VideoPlayer videoPlayer;

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
            replyUs.SetActive(true);
            ShowRoom();
            done = true;
        }

        if ((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space)) && !done2)
        {
            timelineController.Play(5);
            replyUs.SetActive(false);
            ReplyAnim();
            done2 = true;
        }

        void ShowRoom()
        {
            Debug.Log("TODO: Show Room");
        }

        void ReplyAnim()
        {
            Debug.Log("TODO: Reply Aninimation");
        }
    }
}

