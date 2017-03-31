using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Enemie_Follow : MonoBehaviour {

    Transform Tr_player;
    public float RotSpeed, MovSpeed;

    void Start()
    {
        Tr_player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        //Look At Player.

        transform.rotation = Quaternion.Slerp(transform.rotation,
                                                Quaternion.LookRotation(Tr_player.position - transform.position),
                                                RotSpeed * UnityEngine.Time.deltaTime);

        //Move To The Player.

        transform.position += transform.forward * MovSpeed * UnityEngine.Time.deltaTime;
        
    }

/*#if

    public BoxCollider territory;
    GameObject player;
    bool playerInTerritory;

    public GameObject enemy;
    BasicEnemy basicenemy;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        basicenemy = enemy.GetComponent<BasicEnemy>();
        playerInTerritory = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInTerritory == true)
        {
            basicenemy.MoveToPlayer();
        }

        if (playerInTerritory == false)
        {
            basicenemy.Rest();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInTerritory = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerInTerritory = false;
        }
    }
}

public class BasicEnemy : MonoBehaviour
{
    public Transform target;
    public float speed = 3f;
    public float attack1Range = 1f;
    public int attack1Damage = 1;
    public float timeBetweenAttacks;


    // Use this for initialization
    void Start()
    {
        Rest();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveToPlayer()
    {
        //rotate to look at player
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);

        //move towards player
        if (Vector3.Distance(transform.position, target.position) > attack1Range)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }

    public void Rest()
    {

    }
#endif*/
}
