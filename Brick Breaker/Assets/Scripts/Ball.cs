
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public new Rigidbody2D rigidbody { get; private set; }
    public float speed = 1000f; //ball speed

    private void Awake() //gets rigidbody added to the ball
    {
        this.rigidbody = GetComponent<Rigidbody2D>();


    }

    private void Start()
    {
        Invoke(nameof(SetRandomTrajectory), 1f);
    }
    
        private void SetRandomTrajectory()
    {

        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f, 1f); //sets random dircetion
        force.y = -1f; //makes sure the ball moves down

        this.rigidbody.AddForce(force.normalized * this.speed);
    }
    

}
