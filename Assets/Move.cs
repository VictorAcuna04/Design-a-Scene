using UnityEngine;

public class move_player : MonoBehaviour
{
    public float speed = 5.0f; // Adjust the speed as needed
    Vector3 originalPos;
    Vector3 newpos = new Vector3(-4.0f, 0.5f, -4.0f);
    bool movingTowardsNewPos = true;

    void Start()
    {
        // Store the original position at the start
        originalPos = transform.position;
    }

    void Update()
    {
        Vector3 targetPos = movingTowardsNewPos ? newpos : originalPos;

        // Calculate movement direction
        Vector3 movement = (targetPos - transform.position).normalized;

        // Update the position based on direction, speed, and delta time
        transform.position += movement * speed * Time.deltaTime;

        // Check if the object has reached the target position
        if (Vector3.Distance(transform.position, targetPos) < 0.01f)
        {
            // Toggle the direction flag
            movingTowardsNewPos = !movingTowardsNewPos;
        }
    }
}
