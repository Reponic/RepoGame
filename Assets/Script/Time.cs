using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Time : MonoBehaviour {

    float TimeMSeg = 0, TimeSeg = 0, TimeMin = 0;
    public Text time;
	// Use this for initialization
	void Start ()
    {
        time.text = "Time: " + TimeMin + ":" + TimeSeg + "." + TimeMSeg;

    }
	
	// Update is called once per frame
	void Update ()
    {
        
        //TimeMSeg += UnityEngine.Time.deltaTime;
        TimeMSeg++;
        if(TimeMSeg == 60)
        {
            TimeSeg++;
            TimeMSeg = 0;
        }
        if(TimeSeg == 60)
        {
            TimeMin++;
            TimeSeg = 0;
        }
        if(TimeSeg >= 10 && TimeMin >= 10)
        {
            time.text = "Time: " + TimeMin + ":" + TimeSeg;
        }
        else if(TimeSeg >= 10 && TimeMin < 10)
        {
            time.text = "Time: 0" + TimeMin + ":" + TimeSeg;
        }
        else
        {
            time.text = "Time: 0" + TimeMin + ":0" + TimeSeg;
        }

    }
}
