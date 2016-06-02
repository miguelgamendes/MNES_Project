using UnityEngine;
using System.Collections;

public class SwitchBehaviour : MonoBehaviour {

    public GameObject unlockTarget;

    public GameObject disableTarget;

    public void Activate() {
        Debug.Log("Activated");
        if(unlockTarget)
            unlockTarget.GetComponent<DoorBehaviour>().ToggleLockState();
        if(disableTarget)
            disableTarget.SetActive(false);

        this.GetComponent<AudioSource>().Play();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
