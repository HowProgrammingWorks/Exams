using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    Vector3 direction;
    public float PlayerShoot;
    bool Bcollision;
    public GameObject Circle;
    public List<GameObject> pieces;
    public float SpeedModifier;
    public float ScaleSpeedModifier;
    public string tagObject;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(WaitForCollison());
        direction = transform.right;
        transform.parent = null;
    }

    // Update is called once per frame
    IEnumerator WaitForCollison()
    {
        yield return new WaitForSeconds(0.01f);
        Bcollision = true;
    }
    void Update()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, 20 * SpeedModifier * Time.deltaTime);
        if (transform.localScale.x < 1.1)
        {
            transform.localScale = new Vector3(transform.localScale.x + (0.15f * ScaleSpeedModifier) * Time.deltaTime, transform.localScale.y + (0.15f * ScaleSpeedModifier) * Time.deltaTime, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if ((collision.tag == "Player"))
        //{
        //    if (collision.GetComponent<CirclesMovement>().Player != PlayerShoot)
        //    {
        //        Destroy(gameObject);
        //    }
        //}
        //else
        //{
        tagObject = collision.tag;
        if (tagObject != "Bullet" && tagObject != "polUp" && tagObject != "polRight")
        {
            foreach (var item in pieces)
            {
                item.SetActive(true);
                item.transform.parent = null;


            }
            Destroy(gameObject);
        }
            //Destroy(gameObject);
        //}
    }
}
