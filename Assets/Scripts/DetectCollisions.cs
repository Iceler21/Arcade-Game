using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;


public class DetectCollisions : MonoBehaviour
{
    [SerializeField] private ParticleSystem testParticleSystem = default;
    private bool isDestroyedMain;

    void OnTriggerEnter(Collider other)
    {
        isDestroyedMain = true;
        destroyAsteroid(other);
    }

    void Update()
    {
        Keyboard kb = Keyboard.current;
        if (kb.eKey.isPressed && kb.pKey.isPressed)
        {
            isDestroyedMain = false;
            destroyAsteroid(null);
        }
    }

    public void destroyAsteroid(UnityEngine.Collider other)
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
        if (isDestroyedMain)
        {
            Destroy(other.gameObject);
        }

        // 5. Add to score
        ScoreManager.instance.AddPoint();
    }
}