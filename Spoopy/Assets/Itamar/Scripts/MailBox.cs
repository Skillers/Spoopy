using UnityEngine;
using System.Collections;

public class MailBox : MonoBehaviour {

    public bool Activated;

    public void Activate()
    {
        if(!Activated)
        {
            this.transform.Rotate(0f, 0f, 90f);
            Activated = true;
        }
        else if(Activated)
        {
            this.transform.Rotate(0f, 0f, -90f);
            Activated = false;
        }
        //code to bring le residents
    }
}
