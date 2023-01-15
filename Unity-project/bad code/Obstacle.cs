using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public CirclesMovement cm;
    public SpawnManager SM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Collision with obstacle");
        if (this.gameObject.tag == "Obstacle" && (other.gameObject.tag == "Player"))
        {
            //if (!phView.IsMine)
            //{
            //    // Not our local player - ignore
            //    return;
            //}
            other.GetComponent<CirclesMovement>().Destroy();

            //Debug.Log("Destroy from obstacle");
        }
        else if (this.gameObject.tag == "Obstacle" && (other.gameObject.tag == "Bot"))
        other.GetComponent<BotMovement>().Destroy();


    }
}
