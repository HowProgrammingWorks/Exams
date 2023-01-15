using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steklo : MonoBehaviour
{
    public List<GameObject> childrenList2 = new List<GameObject>();
    [SerializeField] AudioSource Audio;
    [SerializeField] SpriteRenderer ThisSpriteRenderer;
    [SerializeField] BoxCollider2D ThisBoxCollider2D;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GO(float F, Transform circle)
    {
        Audio.Play();
        ThisSpriteRenderer.enabled = false;
        ThisBoxCollider2D.enabled = false;
        foreach (GameObject childTrans in childrenList2)
        {
            //if (childTrans.tag == "Bullet")
            //{
            //childTrans.parent = null;
            //childTrans.gameObject.SetActive(true);
            //childTrans.GetComponent<Rigidbody2D>().AddExplosionForce(Random.Range(50f, 1000f), transform.position, 10f);
            childTrans.gameObject.SetActive(true);
            childTrans.GetComponent<Rigidbody2D>().AddExplosionForce(F * 10, circle.position, 10f);
            childTrans.GetComponent<Renderer>().material.SetColor("_Color", new Color((float)0.84, (float)0.84, (float)0.84, (float)0.45));

            //}
            //else if (childTrans.gameObject.name == "newCircle2")
            //{
            //	childTrans.parent = null;
            //}
        }
        //this.GetComponent<Collider2D>().enabled = false;
        //this.GetComponent<Explodable>().explode();
        //List<Transform> childrenList = new List<Transform>();
        //foreach (Transform childTrans in transform)
        //    childrenList.Add(childTrans);
        ////Goes through the list assigning parents
        //foreach (Transform childTrans in childrenList)
        //{
        //    if (childTrans.name == "piece")
        //    {
        //        //Debug.Log(circle.GetComponent<CirclesMovement>().F);
        //        childTrans.GetComponent<Rigidbody2D>().AddExplosionForce(F*10, circle.position, 10f);
        //        childTrans.GetComponent<Renderer>().material.SetColor("_Color", new Color((float)0.84, (float)0.84, (float)0.84, (float)0.45));
        //    }

        //}

    }
}
