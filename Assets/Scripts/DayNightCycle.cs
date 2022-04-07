using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Start is called before the first frame update
    float minutesPerSecond=60f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angleTheFrame=Time.deltaTime/2*minutesPerSecond;
        transform.RotateAround(transform.position,Vector3.forward ,angleTheFrame);
        
    }
}
