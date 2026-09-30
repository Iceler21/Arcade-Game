using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    public Vector2 moveInput;
    public float speed = 10.0f;
    public float xRange = 7.0f;
    public GameObject projectilePrefab;
    public InputAction fireAction;
    public InputAction quitAction;
    
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

        if (fireAction.triggered)
        {
            Debug.Log("FIRE! FIIIIRRRRRRE!!!!!!!!!");

            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
        if (quitAction.triggered)
        {
            Debug.Log("Quit the game!");
            Application.Quit();
        }
    }
}

/*

MICAH WAS HERE

*/