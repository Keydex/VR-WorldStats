using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
    private int y_rotation;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(1 * Time.deltaTime , 2 * Time.deltaTime, 0);
    }
}
