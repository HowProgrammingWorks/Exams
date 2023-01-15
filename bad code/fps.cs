using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fps : MonoBehaviour
{
    float fpsF;
    string text;
    private float deltaTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        fpsF = 1.0f / deltaTime;
        text = string.Format("{0:0,0.0000 FPS}", fpsF);
        GetComponent<UnityEngine.UI.Text>().text = text;
    }
}
