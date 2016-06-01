using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = new Ray(this.transform.position, this.transform.GetComponentInChildren<Camera>().transform.forward);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit, 2)) {
                hit.collider.transform.root.GetComponent<DoorBehaviour>().Toggle();
            }
        }
	}
}
