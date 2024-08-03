    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Playables;
    using UnityEngine.Timeline;
    using UnityEngine.Events;

public class TimelineManager : MonoBehaviour
{
   public List<PlayableDirector> timelines = new List<PlayableDirector>();
   public List<GameObject> timelineGameObjects = new List<GameObject>();
   private int currentTimelineIndex = 0;

    void OnEnable()
    {
        foreach (var timeline in timelines)
        {
            if (timeline != null)
            {
                timeline.stopped += OnTimelineStopped;
            }
        }
    }

    void OnDisable()
    {
        foreach (var timeline in timelines)
        {
            if (timeline != null)
            {
                timeline.stopped -= OnTimelineStopped;
            }
        }
    }

     private void OnTimelineStopped(PlayableDirector director)
    {
        if (currentTimelineIndex < timelineGameObjects.Count)
        {
            // Disable the current GameObject
            timelineGameObjects[currentTimelineIndex].SetActive(false);
        }

        currentTimelineIndex++;

        if (currentTimelineIndex < timelines.Count && timelines[currentTimelineIndex] != null)
        {
            // Enable the next GameObject
            if (currentTimelineIndex < timelineGameObjects.Count)
            {
                timelineGameObjects[currentTimelineIndex].SetActive(true);
            }

            timelines[currentTimelineIndex].Play();
        }
    }

    public void PlayTimelines()
    {
        currentTimelineIndex = 0;

        if (timelines.Count > 0 && timelines[0] != null)
        {
            // Enable the first GameObject
            if (timelineGameObjects.Count > 0)
            {
                timelineGameObjects[0].SetActive(true);
            }

            timelines[0].Play();
        }
    }

    public void StopTimelines()
    {
        foreach (var timeline in timelines)
        {
            if (timeline != null)
            {
                timeline.Stop();
            }
        }

        // Optionally, disable all GameObjects when stopping
        foreach (var go in timelineGameObjects)
        {
            if (go != null)
            {
                go.SetActive(false);
            }
        }
    }
    
}
