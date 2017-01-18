﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Interaction : MonoBehaviour {

    public bool fearingOn = false;
    public int fearamount = 1, fearScale = 1;


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
        Debug.Log(this.transform.parent.transform.parent.transform.parent.transform.GetChild(0).name);
        Debug.Log(this.transform.parent.transform.parent.transform.GetChild(0).name);
        if (this.transform.parent.transform.parent.transform.GetChild(0).name != "SingleDoor") {
            if (!this.transform.parent.transform.parent.transform.parent.transform.GetChild(0).GetComponent<LockDoor>().locked)
            {
                this.transform.parent.transform.parent.transform.parent.transform.GetChild(0).GetComponent<DoorScript>().open = !this.transform.parent.transform.parent.transform.parent.transform.GetChild(0).GetComponent<DoorScript>().open;
                this.transform.parent.transform.parent.transform.parent.transform.GetChild(0).GetComponent<DoorScript>().squeek();
            }
        }
        else
        {
            if (!this.transform.parent.transform.parent.transform.GetChild(0).GetComponent<LockDoor>().locked)
            {
                this.transform.parent.transform.parent.transform.GetChild(0).GetComponent<DoorScript>().open = !this.transform.parent.transform.parent.transform.GetChild(0).GetComponent<DoorScript>().open;
                this.transform.parent.transform.parent.transform.GetChild(0).GetComponent<DoorScript>().squeek();
            }
        }
    }

    public void BookcaseInteraction()
    {
        this.GetComponent<NewBookcaseScript>().activated = true;
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
        this.transform.parent.transform.parent.transform.parent.transform.GetChild(0).GetComponent<LockDoor>().activated = true;
    }

    public void CandleInteraction()
    {
        this.GetComponentInParent<CandleOnandOff>().Check();
    }
}
