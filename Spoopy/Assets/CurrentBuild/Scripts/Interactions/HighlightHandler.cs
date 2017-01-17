using UnityEngine;
using System.Collections;

public class HighlightHandler : MonoBehaviour {
    public float value;
    public Color valueC;
    public GameObject shadedObject;
    // Use this for initialization
<<<<<<< HEAD

    
    void Awake() {
        shadedObject = this.gameObject;
=======
    void Start () {
>>>>>>> Rick
        shadedObject.GetComponent<Renderer>().material.SetFloat("_Outline", value);
        shadedObject.GetComponent<Renderer>().material.SetColor("_OutlineColor", valueC);
    }
	
	// Update is called once per frame
	void Update () {
        shadedObject.GetComponent<Renderer>().material.SetFloat("_Outline", value);
        shadedObject.GetComponent<Renderer>().material.SetColor("_OutlineColor", valueC);
    }
}
