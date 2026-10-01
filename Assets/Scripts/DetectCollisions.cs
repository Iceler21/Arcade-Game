using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class DetectCollisions : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);

        ScoreManager.instance.AddPoint();
    }
}

/*
https://youtu.be/YUcvy9PHeXs
*/