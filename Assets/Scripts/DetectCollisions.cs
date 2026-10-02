using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;


public class DetectCollisions : MonoBehaviour
{
    [SerializeField] private ParticleSystem testParticleSystem = default;

    void OnTriggerEnter(Collider other)
    {
        // 1. Unparent particles
        testParticleSystem.transform.parent = null;
        
        // 2. Play the particles
        testParticleSystem.Play();

        // 3. Tell the particles to destroy themselves when they finish
        var main = testParticleSystem.main;
        Destroy(testParticleSystem.gameObject, main.duration + main.startLifetime.constantMax);

        // 4. Destroy collision objects
        Destroy(gameObject);
        Destroy(other.gameObject);

        // 5. Add to score
        ScoreManager.instance.AddPoint();
    }
}