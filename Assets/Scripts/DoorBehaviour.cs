using UnityEngine;
using System.Collections;

public class DoorBehaviour : MonoBehaviour {

    private bool isOpen = false;
    public bool isLocked = true;

    public void ToggleOpenState() {
        if (isLocked)
            return;

        isOpen = !isOpen;
        if (isOpen)
            this.transform.RotateAround(transform.TransformPoint(new Vector3(-0.5f, 0, 0)), new Vector3(0, 1, 0), 90);
        else
            this.transform.RotateAround(transform.TransformPoint(new Vector3(-0.5f, 0, 0)), new Vector3(0, 1, 0), -90);
    }

    public void ToggleLockState() {
        isLocked = !isLocked;

        this.transform.GetChild(0).GetComponent<Renderer>().material = Resources.Load("Open Door") as Material;
        Debug.Log("Unlocked"); 
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }
}
