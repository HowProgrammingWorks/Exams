using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimations : MonoBehaviour
{

    public RuntimeAnimatorController PlayButtonAnim;
    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        Camera = GameObject.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        Camera.GetComponent<Animator>().runtimeAnimatorController = PlayButtonAnim;
    }

}
