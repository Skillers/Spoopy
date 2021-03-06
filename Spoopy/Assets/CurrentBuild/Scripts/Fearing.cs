﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Fearing : MonoBehaviour {
    public List<GameObject> residents = new List<GameObject>();

    public List<GameObject>  interactions = new List<GameObject>();

    void Start()
    {

        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Resident"))
        {
            residents.Add(item);
        }
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("Interaction"))
        {
            interactions.Add(item);
        }
    }

	// Update is called once per frame
	void FixedUpdate () {


        foreach (GameObject interaction in interactions)
        {
            foreach (GameObject resident in residents)
            {
                if (checkif1isin2(resident, interaction))
                {
                    if (interaction.GetComponent<Interaction>().fearingOn)
                    {
                        resident.GetComponent<ResidentsFearBar>().fearBar.GetComponent<Fearhandler>().GetFearedBrother(interaction.GetComponent<Interaction>().fearamount);
                    }
                }
  
            }
        }

     
    }

    public bool checkif1isin2(GameObject sourceObject, GameObject targetObject)
    {
        if (sourceObject != null && targetObject != null)
        {
            Vector3 size = sourceObject.GetComponent<Collider>().bounds.size;
            Vector3 position = sourceObject.GetComponent<Collider>().bounds.center;
            Vector3 size2 = targetObject.GetComponent<Collider>().bounds.size;
            Vector3 position2 = targetObject.GetComponent<Collider>().bounds.center;
            if ((position.x + size.x / 2f) < (position2.x + size2.x / 2f) && (position.x - size.x / 2f) > (position2.x - size2.x / 2f))
            {

                if ((position.y + size.y / 2f) < (position2.y + size2.y / 2f) && (position.y - size.y / 2f) > (position2.y - size2.y / 2f))
                {

                    if ((position.z + size.z / 2f) < (position2.z + size2.z / 2f) && (position.z - size.z / 2f) > (position2.z - size2.z / 2f))
                    {
                        return true;
                    }
                }

            }


        }
        return false;
    }

}
