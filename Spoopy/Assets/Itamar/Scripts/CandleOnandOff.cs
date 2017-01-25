using UnityEngine;
using System.Collections;

public class CandleOnandOff : MonoBehaviour {
    // WARNING THIS SCRIPT IS NO LONGER USED.
    public GameObject Lighting;
    
    public void Check()
    {
        if(Lighting.activeSelf == true)
        {
            Off();
        }
        else
        {
            On();
        }
    }

    public void Off()
    {
       // Lighting.gameObject.SetActive(false);
    }

    public void On()
    {
        //Lighting.gameObject.SetActive(true);
    }
}
