using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeCamara : MonoBehaviour {

    public GameObject Player;

    private Vector3 CamaraPosition;
	// Use this for initialization
	void Start ()
    {
        CamaraPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update ()
    {
        CamaraPosition = new Vector3(Player.transform.position.x, Player.transform.position.y + 3, Player.transform.position.z - 20);
        transform.position = CamaraPosition;
	}
}
