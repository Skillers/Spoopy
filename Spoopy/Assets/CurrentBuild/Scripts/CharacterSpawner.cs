using UnityEngine;
using System.Collections;

public class CharacterSpawner : MonoBehaviour {

    public GameObject zombie, ghost;
    public Vector3 spawnPosition;

	void OnEnable()
    {
        CharManager charM = FindObjectOfType<CharManager>();

        switch (charM.chosenChar)
        {
            case CharDescription.ghost:
                GameObject ghostOBJ =  (GameObject)Instantiate(ghost);
                ghostOBJ.transform.position = spawnPosition;
                break;

            case CharDescription.zombie:
                GameObject zombieOBJ = (GameObject)Instantiate(zombie);
                zombieOBJ.transform.position = spawnPosition;
                break;
        }
    }
}
