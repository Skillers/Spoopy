﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FacesScript : MonoBehaviour {

    public Image faceImage;
    public Sprite gTFO;
    public Sprite curious;
    public Sprite happy;
    public Sprite scared;
    public Sprite startled;

	void Start () {

	}
	
	void Update () {

	}

    public void ChangeFace(string face)
    {
        switch (face)
        {
            case "GTFO":
                faceImage.sprite = gTFO;
                break;
            case "curious":
                faceImage.sprite = curious;
                break;
            case "happy":
                faceImage.sprite = happy;
                break;
            case "scared":
                faceImage.sprite = scared;
                break;
            case "startled":
                faceImage.sprite = startled;
                break;
        }

    }
}
