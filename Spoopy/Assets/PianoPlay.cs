using UnityEngine;
using System.Collections;

public class PianoPlay : MonoBehaviour {
    public bool isPlaying = false;

    public  AudioSource pianoPlay;
    // Use this for initialization
    void Start () {
        pianoPlay = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

        if (isPlaying)
        {
            if (!pianoPlay.isPlaying)
            {
                pianoPlay.Play();
            }
        }else
        {
            pianoPlay.Stop();
        }
	}
}
