using UnityEngine;
using System.Collections;

public class BarData : MonoBehaviour {
    public Transform object1;
    public Transform object2;
    public Transform object3;
    public Transform object4;
    public GameObject USA_Bar;
    public GameObject Brazil_Bar;
    public GameObject Mexico_Bar;
    public GameObject Canada_Bar;


    // Use this for initialization
    void Start () {
        //Assigns the transform of the first child of the Game Object this script is attached to.
        object1 = this.gameObject.transform.GetChild(0);
        object2 = this.gameObject.transform.GetChild(1);
        object3 = this.gameObject.transform.GetChild(2);
        object4 = this.gameObject.transform.GetChild(3);

        //Assigns the first child of the first child of the Game Object this script is attached to.
        USA_Bar = this.gameObject.transform.GetChild(0).GetChild(0).gameObject;
        Brazil_Bar = this.gameObject.transform.GetChild(1).GetChild(0).gameObject;
        Mexico_Bar = this.gameObject.transform.GetChild(2).GetChild(0).gameObject;
        Canada_Bar = this.gameObject.transform.GetChild(3).GetChild(0).gameObject;
    }
	
	// Update is called once per frame
	void Update () {
        USA_Bar.transform.localScale += new Vector3(0, 0.01F, 0);
        Mexico_Bar.transform.localScale += new Vector3(0, 0.05F, 0);
        Brazil_Bar.transform.localScale += new Vector3(0, -0.01F, 0);
        Canada_Bar.transform.localScale += new Vector3(0, 0.01F, 0);
        
    }
}
