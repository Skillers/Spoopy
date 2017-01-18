using UnityEngine;
using System.Collections;

public class spiegelActive : MonoBehaviour {


    public GameObject fearCollector;

    bool timer;
    int time;

    void start()
    {

        fearCollector = GameObject.Find("FearCollector");
        time = 0;
        timer = false;
    }

    public void FixedUpdate()
    {
        if (timer)
        {
            time++;
        }

        if (time > 100){
            fearCollector.GetComponent<Fearing>().interactions.Remove(gameObject);
            Destroy(gameObject);
        }

    }
    public void Break()
    {
        transform.FindChild("SpiegelShards").gameObject.SetActive(true);
        transform.FindChild("SpiegelHeel").gameObject.SetActive(false);

        timer = true;
    }

}
