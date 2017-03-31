using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    public float speed;
    public Text PointsText;
    public uint Points;
    public GameObject Player;
    public Animator PlayerAnimator;
    public bool Elevator;
    public Animator Elevatorlvl1;
    public Text GameOver;
    public GameObject Camara;
    public bool PlayerMove = true;
    public Animator MovingWall;
    public Animator TriggerLetter;
    public GameObject TubeCamara;
    public GameObject DropTubesCamara;

    private Rigidbody rb;
    private Color PlayerColorStart;
    private Color PlayerColorEnd;
    private float duration;
    private float Horizontal;
    private float Vertical;
    private int CountColor;
    private bool PlayerMoveFoward = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PointsText.text = "Points: " + Points;
        PlayerColorStart = Player.GetComponent<Renderer>().material.color;
        PlayerColorEnd = Color.yellow;
        Elevator = false;
    }

    void Update()
    {
        PointsText.text = "Points: " + Points;
    }

    void FixedUpdate()
    {
        if(PlayerMove)
        {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(Horizontal, 0.0f, Vertical);
        rb.AddForce(movement * speed);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "ElevatorLevel1")
        {
            // = other.gameObject.GetComponent<Animator>();
            Elevatorlvl1.SetTrigger("Trigger");
        }

        if (other.gameObject.tag == "Trigger")
        {
            TriggerLetter.SetTrigger("Down");
            MovingWall.SetTrigger("Move");
        }

        if(other.gameObject.tag == "Points")
        {
            other.gameObject.SetActive(false);
            Points++;
        }

        if (other.gameObject.tag == "Fondo")
        {
            GameOver.gameObject.SetActive(true);
            speed = 0;
        }

        if (other.gameObject.tag == "ShortTube")
        {
            //PlayerMove = false;
            PlayerAnimator.SetTrigger("ShortTube1");
        }

        if (other.gameObject.tag == "Mug")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("Mug");
        }

        if (other.gameObject.tag == "PlataformLetter")
        {
            other.gameObject.GetComponent<Animator>().SetTrigger("PlataformLetter");
        }
        //else if(other.gameObject.tag != "ShortTube")
        //{
        //    PlayerMove = true;
        //}

        if (other.gameObject.tag == "STTUBE")
        {
            //PlayerMoveFoward = false;
            //Horizontal = Horizontal - 5;
            TubeCamara.SetActive(true);
            Camara.SetActive(false);
        }
        else if(other.gameObject.tag != "STTUBE")
        {
            //PlayerMoveFoward = true;
            TubeCamara.SetActive(false);
            Camara.SetActive(true);
        }

        if (other.gameObject.tag == "DropTube")
        {
            //PlayerMoveFoward = false;
            //Horizontal = Horizontal - 5;
            
            DropTubesCamara.SetActive(true);
            Camara.SetActive(false);
            DropTubesCamara.GetComponent<Animator>().SetTrigger("Move");
        }
        else if (other.gameObject.tag != "DropTube" && other.gameObject.tag != "STTUBE")
        {
            //PlayerMoveFoward = true;
            DropTubesCamara.SetActive(false);
            Camara.SetActive(true);
        }

        #region Enemies Collision Commented.
        /*
        if (other.gameObject.tag == "Enemie")
        {

            if (Points % 2 == 0)
            {
                SawpColor(PlayerColorStart, PlayerColorEnd);
                //CountColor++;
                //float lerp = Mathf.PingPong(UnityEngine.Time.time, duration) / duration;
                Player.GetComponent<Renderer>().material.color = Color.Lerp(PlayerColorStart, PlayerColorEnd, 10.0f);
            }
            //else
            //{
            //    Player.GetComponent<Renderer>().material.color = PlayerColorStart;
            //}
            if (Points > 0)
            {
                Points--;
                PointsText.text = "Points: " + Points;
            }
            else if (Points == 0)
            {
                Points = 0;
                //Player.GetComponent<Renderer>().material.color = PlayerColorEnd;
                PointsText.text = "Points: " + Points;
            }
        }
        */
        #endregion // 
    }

    void SawpColor(Color Start, Color End)
    {
        if(Points == 8)
        {
            PlayerColorStart = PlayerColorEnd;
            PlayerColorEnd = Color.blue;
        }
        else if(Points == 6)
        {
            PlayerColorStart = PlayerColorEnd;
            PlayerColorEnd = new Color(153, 50, 204);
        }
        else if(Points == 4)
        {
            PlayerColorStart = PlayerColorEnd;
            PlayerColorEnd = Color.cyan;
        }
        else if(Points == 2)
        {
            PlayerColorStart = PlayerColorEnd;
            PlayerColorEnd = Color.black /*new Color(199, 21, 112)*/;
        }
        else if(Points == 0)
        {
            PlayerColorStart = PlayerColorEnd;
            PlayerColorEnd = Color.red;
        }
        
    }
}
