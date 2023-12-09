
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int health { get; private set; }
    public SpriteRenderer spriteRender { get; private set; }
    public Color[] states; //ades a color array called states that will visulize the ehalth of the bricks
    public bool Unbreakable; 

    private void Awake()
    {
        this.spriteRender = GetComponent<SpriteRenderer>(); //grabs sprite renderer

    }
    private void Start()
    {
        if (!this.Unbreakable)
        {
            this.health = this.states.Length;
            this.spriteRender.color = this.states[this.health - 1];

        }
    }
    private void Hit() //dectects when the ball hits the bricks
    {
        if (this.Unbreakable)
        {
            return;
        }
        {
           
        }
        this.health--; //removes a point of health from brick

        if (this.health <= 0)
        {
            this.gameObject.SetActive(false); //removes brick when hit
        } else
        {
            this.spriteRender.color = this.states[this.health - 1]; //changes stae when hit 
        }

      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Hit(); // calls Hit evertime there is a collision 
        }
    }
}
