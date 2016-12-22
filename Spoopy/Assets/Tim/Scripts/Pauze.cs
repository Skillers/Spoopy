using UnityEngine;
using System.Collections;

public class Pauze : MonoBehaviour {

    GameObject Menu;
    public bool paused;

	// Use this for initialization
	void Start () {
        Menu = transform.GetChild(0).gameObject;
        paused = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }

        if (paused)
        {
            Time.timeScale = 0;
            Menu.SetActive(true);
            AudioListener.pause = true;
            
            Cursor.visible = true;
          
        }
        else
        {
            Time.timeScale = 1;
            Menu.SetActive(false);
            AudioListener.pause = false;

            Cursor.visible = false;
           
        }
	}
}
