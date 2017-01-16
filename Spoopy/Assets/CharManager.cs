using UnityEngine;
using System.Collections;

public enum CharDescription
{
    ghost = 0,
    zombie = 1
};

public class CharManager : MonoBehaviour {


    public CharDescription chosenChar = CharDescription.ghost;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);        
    }	

   
}
