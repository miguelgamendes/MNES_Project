using UnityEngine;
using System.Collections;

public class SwitchBehaviour : MonoBehaviour {

    public GameObject unlockTarget;

    public void Activate() {
        Debug.Log("Activated");
        unlockTarget.GetComponent<DoorBehaviour>().ToggleLockState();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
