using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Will detect if the player can fire later.
    private bool canFire = true;

    public InputAction moveAction;
    public Vector2 moveInput;
    public float speed = 10.0f;
    public float xRange = 7.0f;
    public GameObject projectilePrefab;
    public InputAction fireAction;
    public InputAction quitAction;

    private bool notChangedSpeed = true;

    // Boolean Cooldown timer.
    public float cooldownTimer = 5f;
    
    void Start()
    {
        moveAction.Enable();
        fireAction.Enable();
        quitAction.Enable();
    }

    void Update()
    {
        // Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        moveInput = moveAction.ReadValue<Vector2>();

        transform.Translate(Vector3.right * moveInput.x * Time.deltaTime * speed);

        if (fireAction.triggered && canFire)
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            StartCoroutine(CooldownCoroutine());
        }
        
        if (quitAction.triggered)
        {
            Debug.Log("Quit the game!");
            Application.Quit();
        }

        if (ScoreManager.instance.GetScore() >= 50)
        {
            speed = 40.0f;
            canFire = true;
        }
    }

    private IEnumerator CooldownCoroutine()
    {
        // 1. Turn off the boolean
        canFire = false;
        Debug.Log("Boolean turned off. Starting timer...");

        // 2. Wait for the seconds.
        yield return new WaitForSeconds(cooldownTimer);

        // 3. Turn the boolean back on
        canFire = true;
        Debug.Log("Boolean turned ON again.");
    }
}
