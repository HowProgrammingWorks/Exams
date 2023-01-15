//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class MoneyFall : MonoBehaviour
{
    public float Speed;
    public float OneTime;
    public Transform Gem;
    public bool Menu;
    // Start is called before the first frame update
    void Start()
    {
        Speed = Random.Range(3, 8);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Menu)
        {
            Vector3 direction = transform.up;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, -Speed * Time.deltaTime);
        }
        Gem.Rotate(new Vector3(0, 30 * Time.deltaTime, 0));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!Menu)
        {
            if (collision.tag == "Player" && OneTime == 0)
            {
                float HMM = PlayerPrefs.GetFloat("Money");
                PlayerPrefs.SetFloat("Money", HMM + 1);
                Destroy(this.gameObject);
                OneTime++;
            }
        }
        
    }
}
