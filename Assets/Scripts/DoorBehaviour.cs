using UnityEngine;
using System.Collections;

public class DoorBehaviour : MonoBehaviour {

    private bool isOpen = false;

    public void Toggle() {
        isOpen = !isOpen;
        if (isOpen)
            this.transform.RotateAround(transform.TransformPoint(new Vector3(-0.5f, 0, 0)), new Vector3(0, 1, 0), 90);
        else
            this.transform.RotateAround(transform.TransformPoint(new Vector3(-0.5f, 0, 0)), new Vector3(0, 1, 0), -90);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
