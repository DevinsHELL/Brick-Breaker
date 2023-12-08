
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int health { get; private set; }
    public SpriteRenderer spriteRender { get; private set; }
    public Color[] states;
    public bool Unbreakable;

    private void Awake()
    {
        this.spriteRender = GetComponent<SpriteRenderer>();

    }
    private void Start()
    {
        if (!this.Unbreakable)
        {
            this.health = this.states.Length;
            this.spriteRender.color = this.states[this.health - 1];

        }
    }
    private void Hit()
    {
        if (this.Unbreakable)
        {
            return;
        }
        {
           
        }
        this.health--;

        if (this.health <= 0)
        {
            this.gameObject.SetActive(false);
        } else
        {
            this.spriteRender.color = this.states[this.health - 1];
        }

      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Hit();
        }
    }
}
