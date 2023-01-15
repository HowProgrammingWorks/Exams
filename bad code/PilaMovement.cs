using UnityEngine;

public class PilaMovement : MonoBehaviour
{
    float SpeedTime1;
    float SpeedTime2;
    float Speed;
    public bool isRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpeedTime1 = SpeedTime1 + 1 * Time.deltaTime;
        if ((SpeedTime1 > SpeedTime2))
        {
            SpeedTime2 = SpeedTime2 + 350f * Time.deltaTime;
            Speed = Speed + 15f * Time.deltaTime;
        }

        Vector3 direction = transform.up;
        if (!isRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, Speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, Speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Pila done1" + " " + collision.gameObject.tag);
        if (collision.gameObject.tag == "pila")
        {
            //Debug.Log("Pila done");
            this.enabled = false;
            
        }
    }

}
