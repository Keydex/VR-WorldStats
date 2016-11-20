using UnityEngine;
using System.Collections;

public class reticle : MonoBehaviour {
    public Camera CameraFacing;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = CameraFacing.transform.position
         //   + CameraFacing.transform.rotation * Vector3.forward;
        //transform.LookAt(CameraFacing.transform.position);
        //transform.Rotate(0.0f, 180.0f, 0.0f);
	}
}
