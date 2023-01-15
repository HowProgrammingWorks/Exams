//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Moneta : MonoBehaviour
{

    public GameObject C1;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    public Transform Gem;
    //public float monetu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gem.Rotate(new Vector3(0, 30 * Time.deltaTime, 0));
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.name == "circle1")
            {
                C1.GetComponent<CirclesMovement>().HMM = C1.GetComponent<CirclesMovement>().HMM + 1;
                C1.GetComponent<SpriteRenderer>().color = new Color(1, 1, (C1.GetComponent<SpriteRenderer>().color.b - 0.07f), 1);
                PlayerPrefs.SetFloat("HMM1", C1.GetComponent<CirclesMovement>().HMM);
                this.transform.parent = C1.transform;
                this.gameObject.SetActive(false);
            }
            else if (collision.name == "circle2")
            {
                C2.GetComponent<CirclesMovement>().HMM = C2.GetComponent<CirclesMovement>().HMM + 1;
                C2.GetComponent<SpriteRenderer>().color = new Color(1, 1, (C2.GetComponent<SpriteRenderer>().color.b - 0.07f), 1);
                PlayerPrefs.SetFloat("HMM2", C2.GetComponent<CirclesMovement>().HMM);
                this.transform.parent = C2.transform;
                this.gameObject.SetActive(false);
            }
            else if (collision.name == "circle3")
            {
                C3.GetComponent<CirclesMovement>().HMM = C3.GetComponent<CirclesMovement>().HMM + 1;
                C3.GetComponent<SpriteRenderer>().color = new Color(1, 1, (C3.GetComponent<SpriteRenderer>().color.b - 0.07f), 1);
                PlayerPrefs.SetFloat("HMM3", C3.GetComponent<CirclesMovement>().HMM);
                this.transform.parent = C3.transform;
                this.gameObject.SetActive(false);
            }
            else if (collision.name == "circle4")
            {
                C4.GetComponent<CirclesMovement>().HMM = C4.GetComponent<CirclesMovement>().HMM + 1;
                C4.GetComponent<SpriteRenderer>().color = new Color(1, 1, (C4.GetComponent<SpriteRenderer>().color.b - 0.07f), 1);
                PlayerPrefs.SetFloat("HMM4", C4.GetComponent<CirclesMovement>().HMM);
                this.transform.parent = C4.transform;
                this.gameObject.SetActive(false);
            }
        }
    }

}
