using UnityEngine;
using System.Collections;

public class CharButtonScript : MonoBehaviour {

    public void SetChar(int charDes)
    {
        CharManager charManager = FindObjectOfType<CharManager>();
        charManager.chosenChar = (CharDescription)charDes;
    }
}
