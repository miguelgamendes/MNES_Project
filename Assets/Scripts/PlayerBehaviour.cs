using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = new Ray(this.transform.GetComponentInChildren<Camera>().transform.position + this.transform.GetComponentInChildren<Camera>().transform.forward, this.transform.GetComponentInChildren<Camera>().transform.forward);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit, 2)) {
                if (hit.collider.transform.root.tag == "Door") {
                    hit.collider.transform.root.GetComponent<DoorBehaviour>().ToggleOpenState();
                    Debug.Log("CLICKED DOOR");
                } else if (hit.collider.transform.root.tag == "Interactable") {
                    hit.collider.transform.root.GetComponent<SwitchBehaviour>().Activate();
                    Debug.Log("CLICKED SWITCH");
                }

                Debug.Log(hit.collider.transform.root);
            }
        }
	}
}
