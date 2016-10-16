using UnityEngine;
using Vuforia;
using System.Collections;

public class PopupInfoScript : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    private bool mShowGUIButton = false;
    private Rect mButtonRect = new Rect(50, 50, 120, 60);
    
    public GameObject gameUI;  //The actual Game UI

    // Use this for initialization
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                TrackableBehaviour.Status previousStatus,
                                TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            mShowGUIButton = true;
        }
        else
        {
            mShowGUIButton = false;
        }
        gameUI.SetActive(mShowGUIButton); //hide or show the info panel
    }

    void OnGUI()
    {
        if (mShowGUIButton)
        {      
            // draw the GUI button
//            if (GUI.Button(mButtonRect, "Hello"))
//            {
                // do something on button click 
//            }
        }
    }
}
