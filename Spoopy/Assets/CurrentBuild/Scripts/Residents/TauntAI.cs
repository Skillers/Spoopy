using UnityEngine;
using System.Collections;

public class TauntAI : MonoBehaviour {

	public void TriggerInvestigate(Vector3 target, System.Action callBack)
    {
        GetComponent<residentMovement>().investigate(target, callBack);
    }
}
