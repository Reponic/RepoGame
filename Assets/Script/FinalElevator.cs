using UnityEngine;
using System.Collections;

public class FinalElevator : MonoBehaviour {

    // Use this for initialization
    public GameObject Elevator;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" && Elevator.gameObject.tag == "ElevatorLevel1")
        {
            Elevator.GetComponent<Animation>().Play("FinalElevator");
        }
    }   
}
