using UnityEngine;
using System.Collections;

public class PianoPlay : MonoBehaviour {
    public bool isPlaying = false;
    public float time;

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
            time -= Time.deltaTime;
        }else
        {
            pianoPlay.Stop();
            time = this.GetComponent<Interaction>().PianoTime;
            this.GetComponent<Interaction>().fearingOn = false;
        }

        if(time <= 0)
        {
            isPlaying = false;
        }
	}
}
