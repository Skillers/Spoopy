using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Interaction : MonoBehaviour {

    public bool fearingOn = false;
    public int fearamount = 1;


    public void Taunt()
    {
        List<TauntAI> AI = GameObject.FindObjectsOfType<TauntAI>().ToList<TauntAI>();
        foreach (TauntAI TAI in AI)
        {
            if (Vector3.Distance(this.transform.position, TAI.transform.position) <= 40.0f)
            {
                TAI.TriggerInvestigate(this.transform.position, () => { });
            }
        }
    }



    // interaction method for each interaction
    public void SinkInteraction()
    {
        this.GetComponent<waterTapScript>().isTurnedOn = !this.GetComponent<waterTapScript>().isTurnedOn;
        fearingOn = !fearingOn;
    }

    public void TVInteraction()
    {
        this.GetComponent<TVScript>().isTurnedOn = !this.GetComponent<TVScript>().isTurnedOn;
        fearingOn = !fearingOn;
    }

    public void ChandelierInteraction()
    {
        this.GetComponent<chandelierCrash>().isFalling = true;
        fearingOn = true;
    }

    public void PianoInteraction()
    {
        this.GetComponent<PianoPlay>().isPlaying = !this.GetComponent<PianoPlay>().isPlaying;
        fearingOn = !fearingOn;
    }

    public void VaseInteraction()
    {
        this.GetComponentInParent<VaseScript>().Push();
        fearingOn = true;
    }

    public void DoorInteraction()
    {
        if (!this.transform.root.transform.GetChild(0).GetComponent<LockDoor>().locked)
        {
            this.transform.root.transform.GetChild(0).GetComponent<DoorScript>().open = !this.transform.root.transform.GetChild(0).GetComponent<DoorScript>().open;
            this.transform.root.transform.GetChild(0).GetComponent<DoorScript>().squeek();
        }
    }

    public void BookCaseInteraction()
    {
        this.GetComponent<BookCaseScript>().activated = true;
        fearingOn = true;

    }

    public void WindowInteraction()
    {
        this.GetComponent<HandleWindow>().ExecuteWindow();
    }

    public void DoorBellInteraction()
    {
        AudioSource doorBellAudio = GetComponent<AudioSource>();
        doorBellAudio.Play();
    }


    public void SpiegelInteraction()
    {
        this.GetComponentInParent<spiegelActive>().Break();
    }


    // locking doors
    public void DoorLock()
    {
        this.transform.root.transform.GetChild(0).GetComponent<LockDoor>().activated = true;
    }
}
