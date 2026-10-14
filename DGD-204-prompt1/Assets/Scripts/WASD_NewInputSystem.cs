using UnityEngine;
using UnityEngine.InputSystem;

public class WASD_NewInputSystem : MonoBehaviour
{
    //Variables
    public float speed;

    private Vector3 position;

    public InputActionReference movement;

    public GameManager gm;

    private SpriteRenderer color;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        color = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //read the value of our movement to find the position we are in
        position = movement.action.ReadValue<Vector2>() * speed * Time.deltaTime;

        //tell the square to move
        transform.position += position;
    }

    //on collision change the color of our square
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //sends a message to the console
        Debug.Log("hit");
        //randomly changes color upon collision
        color.color = Random.ColorHSV();
    }

    //destroy the collectable on trigger enter
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //destroy whatever i run into
        Destroy(collision.gameObject);

        //recreate the object i just destroyed
        gm.Respawn();

        //randomly changes color upon collision
        color.color = Random.ColorHSV();
    }
}
