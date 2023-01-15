using UnityEngine;

public class PlayerColliderTrigger : MonoBehaviour
{
    [SerializeField] string thisName;
    [SerializeField] CirclesMovement CM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = CM.transform.position;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != thisName && collision.tag == "PTrigger")
        {
            CM.ImpulsePlayers(collision.transform.parent.GetComponent<CircleCollider2D>(), "PTrigger");
            //collision.GetComponentInParent<CirclesMovement>().ImpulsePlayers(this.gameObject.transform.parent.GetComponent<CircleCollider2D>(), "PTrigger");
        }
        else if (collision.name != thisName && collision.tag == "Player")
        {
            //CM.PCT = true;
            CM.ImpulsePlayers(collision, "Player");
        }
        else if (collision.name != thisName && collision.tag == "Bot")
        {
            CM.ImpulsePlayers(collision.GetComponent<CircleCollider2D>(), "Bot");
        }
        
    }

}
