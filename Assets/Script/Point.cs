using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Point : MonoBehaviour {

    public GameObject Player;
    public GameObject Enemie;
    public Text points;
    int PointsValue;

	// Use this for initialization
	void Start ()
    {
        points.text = "Points: " + PointsValue;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	    
	}
    
}
