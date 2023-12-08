
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public new Rigidbody2D rigidbody { get; private set; }
    public float speed = 700f;

    private void Awake()
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
        force.x = Random.Range(-1f, 1f);
        force.y = -1f;

        this.rigidbody.AddForce(force.normalized * this.speed);
    }
    

}
