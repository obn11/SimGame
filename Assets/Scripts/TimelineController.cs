using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public List<PlayableDirector> directors = new List<PlayableDirector>();

    public void Start()
    {
        // director = GameObject.Find("Timeline 2").GetComponent<PlayableDirector>();
    }

    public void Play(int index)
    {
        directors[index].Play();
    }
}
