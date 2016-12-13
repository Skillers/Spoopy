using UnityEngine;
using System.Collections;

public class AreaTaunt : MonoBehaviour {

    public bool TauntReady = false;
    //om dit te laten werken moet je eerst ergens deze callBack benoemen naar de resetmethode voor het gewenste object.
    public System.Action callBack;
    
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Resident")
        {
            if (TauntReady)
            {
                if(callBack != null)
                {
                    col.GetComponent<TauntAI>().TriggerInvestigate(this.transform.position, callBack);
                } 
            }
        }
    }
}
