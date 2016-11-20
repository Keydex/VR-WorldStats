using UnityEngine;
using System.Collections;

public class HandleEarth : MonoBehaviour {
    GameObject[] bars;
    CountryData[] data;

	// Use this for initialization
    void Start() { 
        
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown("u"))
        {
            transform.localScale += new Vector3(0.03f, 0.03f, 0.03f);
        }
        if (Input.GetButtonDown("y"))
        {
            transform.localScale -= new Vector3(0.03f, 0.03f, 0.03f);
        }
        if (Input.GetButtonDown("a")) {
            transform.position += new Vector3(0.0f, 0.3f, 0.0f);
        }
        if (Input.GetButtonDown("b"))
        {
            transform.position -= new Vector3(0.0f, 0.3f, 0.0f);
        }
        if (Input.GetButtonDown("o"))
        {
            transform.Rotate(new Vector3(0.0f, 10.0f, 0.0f));
        }
        if (Input.GetButtonDown("p"))
        {
            transform.Rotate(new Vector3(0.0f, -10.0f, 0.0f));
        }
    }
}
