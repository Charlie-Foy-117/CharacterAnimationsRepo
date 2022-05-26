using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
    //unity editor variable
    public float goalTime; //number of seconds the object should live for

    //private variable
    private float startTime; //time stamp that our timer is starting at
    // Start is called before the first frame update
    void Start()
    {
        //Time.time = current time stamp (time since the game started)
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //declare a variable to contain our end timestamp to be used for comparisons
        float endTime;
        //the end timestamp is just the start timestamp plus how long the object should live
        endTime = startTime + goalTime;

        //check is our current time is greater or equal to our end time
        if (Time.time >= endTime)
        {
            //destroy this object
            Destroy(gameObject);
        }
    }
}
