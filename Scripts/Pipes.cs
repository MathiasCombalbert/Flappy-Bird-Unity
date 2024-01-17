using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        // Fill this line to make the pipes moove the the left at a certain speed
        // Your code here...

        if (transform.position.x < leftEdge) {
            // Fill this line to destroy the game object
            // Your code here...
        }
    }
}