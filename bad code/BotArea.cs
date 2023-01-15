using UnityEngine;

public class BotArea : MonoBehaviour
{
    public BotMovement bot;
    public Collider2D thisCollider;
    public bool AreaOn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            bot.area = true;
            bot.GaObInArea(collision.gameObject);
        }
        else
        {
            Physics2D.IgnoreCollision(collision.GetComponent<Collider2D>(), thisCollider);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //if (collision.tag == "Player")
        //{
        //    bot.area = false;
        //}
    }
}
