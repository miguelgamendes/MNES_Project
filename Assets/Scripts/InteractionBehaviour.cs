using UnityEngine;
using System.Collections;

public class InteractionBehaviour : MonoBehaviour {

    public GameObject interactee;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    /*
    void OnTriggerEnter(Collider other) {
        Debug.Log("ENTER");
        if (other.gameObject.tag == "Door") {
            Debug.Log("COLL");
            interactee = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Door") {
            Debug.Log("EXIT");
            interactee = null;
        }
    }
    */
}
