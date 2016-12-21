using UnityEngine;
using System.Collections;

public class BearTrapScript : MonoBehaviour {
    private float effectTimer;
    public float effectDuration = 5;

    GameObject target;
    private bool triggered;
	// Use this for initialization
	void Start () {
        effectTimer = 0;
        triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (triggered)
        {
            effectTimer += Time.deltaTime;
            target.GetComponent<NavMeshAgent>().Stop();
            if (effectTimer >= effectDuration)
            {
                target.GetComponent<NavMeshAgent>().Resume();
                Destroy(gameObject);
                effectTimer = 0;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Resident")
        {
            target = other.gameObject;
            triggered = true;
        }

    }
}
