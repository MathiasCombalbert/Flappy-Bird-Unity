using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite[] sprites;
    public float strength = 5f;
    public float gravity = -9.81f;
    public float tilt = 5f;

    private SpriteRenderer spriteRenderer;
    private Vector3 direction;
    private int spriteIndex;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        //Fix the AnimateSprite function before uncomenting this (you can do that last)
        // InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            //Fill this Line to make the player go up every click
            // direction = ?;
        }

        // Apply gravity
        direction.y += gravity * Time.deltaTime;
        //Fill this line to Update the position
        // transform.position ?

        // Tilt the bird based on the direction
        Vector3 rotation = transform.eulerAngles;
        rotation.z = direction.y * tilt;
        //Fill this line to make the player tilt (hint: euleurAngles)
        // ? = rotation;
    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length) {
            spriteIndex = 0;
        }

        if (spriteIndex < sprites.Length && spriteIndex >= 0) {
            //Fill this line to change the sprite of the player
        }
    }

    //Wait for the collision part to uncoment this
    // private void OnTriggerEnter2D(Collider2D other)
    // {
    // }
}