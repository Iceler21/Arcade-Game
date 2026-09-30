using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class DetectCollisions : MonoBehaviour
{
    public static int Score = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Score++;
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

/*
https://youtu.be/YUcvy9PHeXs
*/