using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellicopterCalling : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip audioClip;
    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Help"))
        {
            print("Calling Helicopter");
            audioSource.Play();
        }
    }

   
}
