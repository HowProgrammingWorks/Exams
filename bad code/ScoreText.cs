using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private string WhichScore;
    public SpawnManager SM;
    public Material material;
    public float SP1;
    public float SP2;
    public float SP3;
    public float SP4;
    // Start is called before the first frame update
    void Start()
    {
        WhichScore = this.gameObject.name;
        SM = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();

        Score();
        SP1 = PlayerPrefs.GetFloat("SP1");
        SP2 = PlayerPrefs.GetFloat("SP2");
        SP3 = PlayerPrefs.GetFloat("SP3");
        SP4 = PlayerPrefs.GetFloat("SP4");
    }

    // Update is called once per frame
    void Update()
    {
        if (SM.PlayersAlive <= 1)
        {
            Score();
        }
        
        if (WhichScore == "SP1")
        {
            if (SP1 > SP2 && SP1 > SP3 && SP1 > SP4 && SP1 != 0)
            {
                GetComponent<Text>().material = material;
                Debug.Log("SP1 Material Done");
            }
            //Debug.Log("SP1 Material Failed");
        }
        else if (WhichScore == "SP2")
        {
            if (SP2 > SP1 && SP2 > SP3 && SP2 > SP4 && SP2 != 0)
            {
                GetComponent<Text>().material = material;
                Debug.Log("SP1 Material Done");
            }
        }
        else if (WhichScore == "SP3")
        {
            if (SP3 > SP1 && SP3 > SP2 && SP3 > SP4 && SP3 != 0)
            {
                GetComponent<Text>().material = material;
                Debug.Log("SP1 Material Done");
            }
        }
        else if (WhichScore == "SP4")
        {
            if (SP4 > SP1 && SP4 > SP2 && SP4 > SP3 && SP4 != 0)
            {
                GetComponent<Text>().material = material;
                Debug.Log("SP1 Material Done");
            }
        }




    }

    void Score()
    {
        //if (SM.PlayersAlive <= 1)
        //{
        if (WhichScore == "SP1")
        {
            GetComponent<Text>().text = PlayerPrefs.GetFloat("SP1").ToString();
        }
        else if (WhichScore == "SP2")
        {
            GetComponent<Text>().text = PlayerPrefs.GetFloat("SP2").ToString();
        }
        else if (WhichScore == "SP3")
        {
            GetComponent<Text>().text = PlayerPrefs.GetFloat("SP3").ToString();
        }
        else if (WhichScore == "SP4")
        {
            GetComponent<Text>().text = PlayerPrefs.GetFloat("SP4").ToString();
        }
        SP1 = PlayerPrefs.GetFloat("SP1");
        SP2 = PlayerPrefs.GetFloat("SP2");
        SP3 = PlayerPrefs.GetFloat("SP3");
        SP4 = PlayerPrefs.GetFloat("SP4");
        //}

    }

}
