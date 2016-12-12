using UnityEngine;
using System.Collections;

public class PlayerInSight : MonoBehaviour {
    public Fearing methodgetter;
    public float distance;
    public GameObject Direction;
    public GameObject player;

    bool cleansing;
    float timer;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (cleansing) {
            timer -= Time.deltaTime;
            if (this.gameObject.GetComponent<residentMovement>().currentState != "investigate") ;
            this.gameObject.GetComponent<residentMovement>().investigate(this.transform.position);
        }
        else
        {
            timer = 3f;
        }

        if (timer <= 0)
        {
            if (methodgetter.checkif1isin2(player, this.gameObject))
            {
                Application.LoadLevel("GameOver");
            }

            cleansing = false;
        }


            if(this.GetComponent<FieldOfView>().visibleTargets.Count > 0)
        {
            cleansing = true;
        }
               

    }

}
