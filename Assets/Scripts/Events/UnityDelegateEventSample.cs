using UnityEngine;
using TMPro;

public class MeetEvent
{
    public delegate void MeetEventHandler(string message);
    public event MeetEventHandler meethandler;

    public void Meet()
    {
        meethandler("Hello~~ Girl");
    }
}

public class UnityDelegateEventSample: MonoBehaviour
{

    MeetEvent meetEvent = new MeetEvent();
    public TextMeshProUGUI text;

    void Start()
    {
        meetEvent.meethandler += EventMessage;
        //meetEvent.meethandler += EventMessage1;
    }

    private void EventMessage(string value)
    {
        Debug.Log("삐융 ~~");
        Debug.Log($"{value}");
        text.text = value;
    }

    private void EventMessage1(string value)
    {
        Debug.Log("바붕~~");
    }
    public void OnMeetButton()
    {
        meetEvent.Meet();
    }
}