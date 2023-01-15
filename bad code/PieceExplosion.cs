using UnityEngine;

public class PieceExplosion : MonoBehaviour
{
    public Transform circle;
    public float HMPieces;
    float SpeedTime1;
    float SpeedTime2 = 240;
    bool done;
    //string tag;
    string currentName;
    [SerializeField]bool isBot;
    //[SerializeField]bool isSteklo;
    float fpsF;
    private float deltaTime = 0.0f;
    public Renderer rend;
    public Rigidbody2D rb;
    float F;
    public bool NoExplosion;
    // Start is called before the first frame update
    void Awake()
    {
        //if (!isSteklo)
        //{
        if (!NoExplosion)
        {
            F = Random.Range(50f, 1000f);
            //Debug.Log(circle.GetComponent<CirclesMovement>().F);
            rb.AddExplosionForce(F, circle.position, 10f);
        }
        

            //if (this.gameObject.GetComponentInParent<BotMovement>().gameObject.tag == "Bot")
            //{
            //Physics.IgnoreCollision(this.GetComponent<Collider2D>());
            //}
        //}

    }

    void Start()
    {
        //HMPieces++;
        //currentName = this.gameObject.transform.parent.name;
        if (isBot)
        {
            rend.material.SetColor("_Color", new Color((float)0.114, (float)0.114, (float)0.114));
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (HMPieces > 100)
        //{
        //    Destroy(this.gameObject);
        //}
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        fpsF = 1.0f / deltaTime;
        if (fpsF < 30)
        {
            Destroy(this.gameObject);
        }
        if (isBot)
        {
            SpeedTime1 = SpeedTime1 + 20 * Time.deltaTime;
            if ((SpeedTime1 > SpeedTime2))
            {
                //done = true;
                //SpeedTime2 = SpeedTime2 + 100f * Time.deltaTime;
                //SpeedTime1 = SpeedTime1 + 20 * Time.deltaTime;
                //if ((SpeedTime1 > SpeedTime2))
                //{
                Destroy(this.gameObject);
                //}
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //if (col.gameObject.tag == "Player")
        //{
        //    Physics2D.IgnoreCollision(this.GetComponent<PolygonCollider2D>(), col.gameObject.transform.GetChild(1).GetComponent<CircleCollider2D>(), true);
        //}
    }

    public void Disable()
    {
        Destroy(this.gameObject);
    }


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Obstacle")
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}

}
