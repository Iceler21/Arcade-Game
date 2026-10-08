using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    void Start()
    {

    }

    void Update()
    {
        

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);

            LoadDeathScene();
        }
    }

    public void LoadDeathScene()
    {
        SceneManager.LoadScene("Death Screen");
    }
}
