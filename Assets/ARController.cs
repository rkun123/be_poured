using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARController : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour trackableBehaviour;
    public GameObject undetectedARMarkerIndicator;
    private CanvasGroup undetectedARMarkerIndicatorCanvasGroup;
    // Start is called before the first frame update
    void Start()
    {
        trackableBehaviour = GetComponent<TrackableBehaviour>();
        undetectedARMarkerIndicatorCanvasGroup = undetectedARMarkerIndicator.GetComponent<CanvasGroup>();

        if(trackableBehaviour) trackableBehaviour.RegisterTrackableEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status prev, TrackableBehaviour.Status now) {
        Debug.Log(now);
        if(now == TrackableBehaviour.Status.DETECTED || now == TrackableBehaviour.Status.TRACKED || now == TrackableBehaviour.Status.EXTENDED_TRACKED) {
            // Don't show indicator
            undetectedARMarkerIndicatorCanvasGroup.alpha = 0;
        }else{
            // Show indicator
            undetectedARMarkerIndicatorCanvasGroup.alpha = 1;
        }
    }
}
