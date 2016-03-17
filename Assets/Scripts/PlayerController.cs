using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject cam = gameObject.transform.FindChild("Main Camera").gameObject;
        if (Input.GetAxis("Vertical") > 0)
            gameObject.transform.position += cam.transform.forward / 10;
        else if (Input.GetAxis("Vertical") < 0)
            gameObject.transform.position -= cam.transform.forward / 10;
        else if (Input.GetAxis("Horizontal") > 0)
            gameObject.transform.position += cam.transform.right / 10;
        else if (Input.GetAxis("Horizontal") < 0)
            gameObject.transform.position -= cam.transform.right / 10; ;
    }
}
