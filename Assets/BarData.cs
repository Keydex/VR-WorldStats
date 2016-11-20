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
    public GameObject Japan_Bar;
    public GameObject Austrailia_Bar;
    public GameObject Egypt_Bar;
    public GameObject Europe_Bar;
    public CSVData data;
    public float USA_Bar_size;
    public float Brazil_Bar_size;
    public float Mexico_Bar_size;
    public float Canada_Bar_size;
    public float Japan_Bar_size;
    public float Austrailia_Bar_size;
    public float Egypt_Bar_size;
    public float Europe_Bar_size;


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
        Japan_Bar = this.gameObject.transform.GetChild(4).GetChild(0).gameObject;
        Austrailia_Bar = this.gameObject.transform.GetChild(5).GetChild(0).gameObject;
        Egypt_Bar = this.gameObject.transform.GetChild(6).GetChild(0).gameObject; ;
        Europe_Bar = this.gameObject.transform.GetChild(7).GetChild(0).gameObject;
        GameObject temp = GameObject.Find("CSV");
        if (temp != null)
        {
            data = temp.GetComponent(typeof(CSVData)) as CSVData;
        } else
        {
            data = null;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (data != null && data.IsLoaded())
        {
            Debug.Log(data.IsLoaded());
            USA_Bar_size = float.Parse(data.Find_Country("United States").Change) * 100.0f;
            Canada_Bar_size = float.Parse(data.Find_Country("Canada").Change) * 100.0f;
            Mexico_Bar_size = float.Parse(data.Find_Country("Mexico").Change) * 100.0f;
            Brazil_Bar_size = float.Parse(data.Find_Country("Brazil").Change) * 100.0f;
            Japan_Bar_size = float.Parse(data.Find_Country("Japan").Change) * 100.0f; ;
            Austrailia_Bar_size = float.Parse(data.Find_Country("Australia").Change) * 100.0f; ;
            Egypt_Bar_size = float.Parse(data.Find_Country("Libya").Change) * 100.0f; ;
            Europe_Bar_size = float.Parse(data.Find_Country("Europe").Change) * 100.0f;
            if (USA_Bar.transform.localScale.y != USA_Bar_size)
            {
                if (USA_Bar.transform.localScale.y < USA_Bar_size)
                {
                    USA_Bar.transform.localScale += new Vector3(0, 0.01F, 0);
                }
                else
                {
                    USA_Bar.transform.localScale -= new Vector3(0, 0.01F, 0);
                }
            }
            if (Canada_Bar.transform.localScale.y != Canada_Bar_size)
            {
                Debug.Log(Canada_Bar.transform.localScale.y);
                if (Canada_Bar.transform.localScale.y < Canada_Bar_size)
                {
                    Canada_Bar.transform.localScale += new Vector3(0, 0.01F, 0);
                }
                else
                {
                    Canada_Bar.transform.localScale -= new Vector3(0, 0.01F, 0);
                }
            }
            if (Mexico_Bar.transform.localScale.y != Mexico_Bar_size)
            {
                if (Mexico_Bar.transform.localScale.y < USA_Bar_size)
                {
                    Mexico_Bar.transform.localScale += new Vector3(0, 0.01F, 0);
                }
                else
                {
                    Mexico_Bar.transform.localScale -= new Vector3(0, 0.01F, 0);
                }
            }
            if (Brazil_Bar.transform.localScale.y != Brazil_Bar_size)
            {
                if (Brazil_Bar.transform.localScale.y < Brazil_Bar_size)
                {
                    Brazil_Bar.transform.localScale += new Vector3(0, 0.01F, 0);
                }
                else
                {
                    Brazil_Bar.transform.localScale -= new Vector3(0, 0.01F, 0);
                }
            }
            if (Japan_Bar.transform.localScale.y != Japan_Bar_size)
            {
                if (Japan_Bar.transform.localScale.y < Brazil_Bar_size)
                {
                    Japan_Bar.transform.localScale += new Vector3(0, 0.01F, 0);
                }
                else
                {
                    Japan_Bar.transform.localScale -= new Vector3(0, 0.01F, 0);
                }
            }
            if (Austrailia_Bar.transform.localScale.y != Austrailia_Bar_size)
            {
                if (Austrailia_Bar.transform.localScale.y < Brazil_Bar_size)
                {
                    Austrailia_Bar.transform.localScale += new Vector3(0, 0.01F, 0);
                }
                else
                {
                    Austrailia_Bar.transform.localScale -= new Vector3(0, 0.01F, 0);
                }
            }
            if (Egypt_Bar.transform.localScale.y != Egypt_Bar_size)
            {
                if (Egypt_Bar.transform.localScale.y < Brazil_Bar_size)
                {
                    Egypt_Bar.transform.localScale += new Vector3(0, 0.01F, 0);
                }
                else
                {
                    Egypt_Bar.transform.localScale -= new Vector3(0, 0.01F, 0);
                }
            }
            if (Europe_Bar.transform.localScale.y != Europe_Bar_size)
            {
                if (Europe_Bar.transform.localScale.y < Brazil_Bar_size)
                {
                    Europe_Bar.transform.localScale += new Vector3(0, 0.01F, 0);
                }
                else
                {
                    Europe_Bar.transform.localScale -= new Vector3(0, 0.01F, 0);
                }
            }
        }
    }
}
