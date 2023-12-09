
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public new Rigidbody2D rigidbody { get; private set; }
    public Vector2 direction { get; private set; }
    public float speed = 30;
    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();


    }
    private void Update() //updates every frame
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){ // gets user input from the arrow keys and A, D
            this.direction = Vector2.left;
        } else if (Input.GetKey(KeyCode. D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.direction = Vector2.right;
        } else
        {
            this.direction = Vector2.zero;
        }



    }

    private void FixedUpdate()
    {

        if (this.direction != Vector2.zero) //adds speed and drirection to the rigidbody
        {
            this.rigidbody.AddForce(this.direction * this.speed);
        }
    }

    
}
