using UnityEngine;

public class DestroyNewCircle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DestroyC()
    {
        GetComponent<Explodable>().explode();
    }

}
