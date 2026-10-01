using UnityEngine;

public class EnemyForward : MonoBehaviour
{
    private float baseSpeed = 10.0f;
    private float maxSpeed = 200.0f;
    private float speed;



    void Update()
    {
        if (ScoreManager.instance != null)
        {
            int currentScore = ScoreManager.instance.GetScore();
            speed = baseSpeed + (currentScore * 0.5f);
        }
        else
        {
            speed = baseSpeed;
        }

        speed = Mathf.Min(speed, maxSpeed);
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}