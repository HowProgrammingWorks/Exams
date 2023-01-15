using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Spawns;
    public GameObject[] FinishMoneySpawns;
    public float HMPlayers;
    public int PlayersAlive;
    //public int level = 1;
    public GameObject PL1;
    public GameObject PL2;
    public GameObject PL3;
    public GameObject PL4;
    public GameObject MCF1;
    public GameObject MCF2;
    public GameObject MCF3;
    public GameObject MCF4;
    public GameObject MC;
    public float SpawnNumber = 1;
    //public PhotonView PhotonView;
    public Transform Circles;
    bool firstTimeLevel = true;
    public GameObject Bot;
    //public RuntimeAnimatorController Shake;
    //public GameObject Camera;
    public string CurrentScene;
    public bool GameMonetu;
    float SpeedTime1;
    float SpeedTime2 = 20;
    public GameObject moneta;
    public GameObject monetaT;
    public bool TimerDone;
    public string gm;
    public GameObject PrefabTimerMonetu;
    public Canvas finishCanvas;
    public Transform FirstPlace;
    public Transform SecondPlace;
    public Transform ThirdPlace;
    public Transform FouthPlace;
    public GameObject ScoreOnFirst;
    public GameObject ScoreOnSecond;
    public GameObject ScoreOnThird;
    public GameObject Money;
    public float Money1;
    public float MoneyF;
    public bool firsttimeAddScore;
    public float difficulty;
    public float AddedBots;
    public List<GameObject> ListOfGameObjects = new List<GameObject>();
    //public GameObject ScoreOnFouth;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        //Time.fixedDeltaTime = 1f / 64;
        //Physics2D.IgnoreLayerCollision(7, 6, true);
        //Application.targetFrameRate = 60;
        CurrentScene = SceneManager.GetActiveScene().name;
        //PlayerPrefs.SetString("CurrentScene", CurrentScene);
        gm = PlayerPrefs.GetString("gm");
        
        PlayerPrefs.SetFloat("HMM1", 0);
        PlayerPrefs.SetFloat("HMM2", 0);
        PlayerPrefs.SetFloat("HMM3", 0);
        PlayerPrefs.SetFloat("HMM4", 0);
        HMPlayers = PlayerPrefs.GetFloat("HMPlayersF");
        if (HMPlayers == 0)
        {
            HMPlayers = 2;
            PlayerPrefs.SetFloat("HMPlayersF", 2);
        }

        difficulty = PlayerPrefs.GetFloat("difficulty");
        if (difficulty == 0)
        {
            difficulty = 1;
            PlayerPrefs.SetFloat("difficulty", 1);
        }
        else if (difficulty == 1)
        {

        }
        else if (difficulty == 2)
        {
            AddedBots = 3;
        }
        else if (difficulty == 3)
        {
            AddedBots = 5;
        }
        if (CurrentScene == "Menu")
        {
            firstTimeLevel = false;
        }
        else
        {
            HMPlayers = PlayerPrefs.GetFloat("HMPlayersF");
            if (HMPlayers == 0)
            {
                HMPlayers = 2;
            }
            if (HMPlayers == 1)
            {
                        MC = Instantiate(MCF1);
                        PL1 = GameObject.Find("circle1");
                        PL2 = GameObject.Find("Botcircle1");
                        PL3 = GameObject.Find("Botcircle2");
                        PL4 = GameObject.Find("Botcircle3");
                MC.GetComponent<CameraScript>().SM = this;
                        PL2.GetComponent<BotMovement>().ObstacleCheck.SetActive(true);
                        PL3.GetComponent<BotMovement>().ObstacleCheck.SetActive(true);
                        PL4.GetComponent<BotMovement>().ObstacleCheck.SetActive(true);
                        var randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                        var oldRandomPosition = randomPosition;
                        PL1.GetComponent<Transform>().position = randomPosition;
                        //randomPosition = null;
                        randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                        while (randomPosition == oldRandomPosition)
                        {
                            randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                        }
                        if (randomPosition != oldRandomPosition)
                        {
                            PL2.GetComponent<Transform>().position = randomPosition;
                        }
                        //else if (randomPosition == oldRandomPosition)
                        //{
                        //    //randomPosition = null;
                        //    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                        //    PL2.GetComponent<Transform>().position = randomPosition;
                        //}
                        var oldRandomPosition2 = randomPosition;
                        randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                        while (randomPosition == oldRandomPosition || randomPosition == oldRandomPosition2)
                        {
                            randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                        }
                        if (randomPosition != oldRandomPosition && randomPosition != oldRandomPosition2)
                        {
                            PL3.GetComponent<Transform>().position = randomPosition;

                        }
                        //else if (randomPosition == oldRandomPosition || randomPosition == oldRandomPosition2)
                        //{
                        //    //randomPosition = null;
                        //    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                        //    PL3.GetComponent<Transform>().position = randomPosition;
                        //}
                        var oldRandomPosition3 = randomPosition;
                        randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                        while (randomPosition == oldRandomPosition || randomPosition == oldRandomPosition2 || randomPosition == oldRandomPosition3)
                        {
                            randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                        }
                        if (randomPosition != oldRandomPosition && randomPosition != oldRandomPosition2 && randomPosition != oldRandomPosition3)
                        {
                            PL4.GetComponent<Transform>().position = randomPosition;

                        }
                PlayersAlive = 4;

            }
            else if (HMPlayers == 2)
            {
                MC = Instantiate(MCF2);
                //PL1 = GameObject.Find("CameraPL2(Clone)/circle1");
                //PL2 = GameObject.Find("CameraPL2(Clone)/circle2");
                PL1 = GameObject.Find("circle1");
                PL2 = GameObject.Find("circle2");
                MC.GetComponent<CameraScript>().SM = this;
                var randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                var oldRandomPosition = randomPosition;
                PL1.GetComponent<Transform>().position = randomPosition;
                //randomPosition = null;
                randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                while (randomPosition == oldRandomPosition)
                {
                    //randomPosition = null;
                    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                }
                if (randomPosition != oldRandomPosition)
                {
                    PL2.GetComponent<Transform>().position = randomPosition;
                    var oldRandomPosition2 = randomPosition;
                }
                //else if (randomPosition == oldRandomPosition)
                //{
                //    //randomPosition = null;
                //    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                //    PL2.GetComponent<Transform>().position = randomPosition;
                //    var oldRandomPosition2 = randomPosition;
                //}
                PlayersAlive = 2;
                //PL1.GetComponent<CirclesMovement>().p1 = PL2.GetComponent<CirclesMovement>();
                //PL2.GetComponent<CirclesMovement>().p1 = PL1.GetComponent<CirclesMovement>();
                //Camera = GameObject.Find("CameraPL2(Clone)");
            }
            else if (HMPlayers == 3)
            {
                MC = Instantiate(MCF3);
                //PL1 = GameObject.Find("CameraPL3(Clone)/circle1");
                //PL2 = GameObject.Find("CameraPL3(Clone)/circle2");
                //PL3 = GameObject.Find("CameraPL3(Clone)/circle3");
                PL1 = GameObject.Find("circle1");
                PL2 = GameObject.Find("circle2");
                PL3 = GameObject.Find("circle3");
                MC.GetComponent<CameraScript>().SM = this;
                var randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                var oldRandomPosition = randomPosition;
                PL1.GetComponent<Transform>().position = randomPosition;
                //randomPosition = null;
                randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                while (randomPosition == oldRandomPosition)
                {
                    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                }
                if (randomPosition != oldRandomPosition)
                {
                    PL2.GetComponent<Transform>().position = randomPosition;
                }
                //else if (randomPosition == oldRandomPosition)
                //{
                //    //randomPosition = null;
                //    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                //    PL2.GetComponent<Transform>().position = randomPosition;
                //}
                var oldRandomPosition2 = randomPosition;
                randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                while (randomPosition == oldRandomPosition || randomPosition == oldRandomPosition2)
                {
                    //randomPosition = null;
                    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                    //PL3.GetComponent<Transform>().position = randomPosition;
                }
                if (randomPosition != oldRandomPosition && randomPosition != oldRandomPosition2)
                {
                    PL3.GetComponent<Transform>().position = randomPosition;

                }
                //else if (randomPosition == oldRandomPosition || randomPosition == oldRandomPosition2)
                //{
                //    //randomPosition = null;
                //    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                //    PL3.GetComponent<Transform>().position = randomPosition;
                //}
                var oldRandomPosition3 = randomPosition;
                PlayersAlive = 3;
                //Camera = GameObject.Find("CameraPL3(Clone)");
                //PL1.GetComponent<CirclesMovement>().p1 = PL2.GetComponent<CirclesMovement>();
                //PL1.GetComponent<CirclesMovement>().p2 = PL3.GetComponent<CirclesMovement>();
                //PL2.GetComponent<CirclesMovement>().p1 = PL1.GetComponent<CirclesMovement>();
                //PL2.GetComponent<CirclesMovement>().p2 = PL3.GetComponent<CirclesMovement>();
                //PL3.GetComponent<CirclesMovement>().p1 = PL1.GetComponent<CirclesMovement>();
                //PL3.GetComponent<CirclesMovement>().p2 = PL2.GetComponent<CirclesMovement>();
            }
            else
            {
                MC = Instantiate(MCF4);
                PL1 = GameObject.Find("circle1");
                PL2 = GameObject.Find("circle2");
                PL3 = GameObject.Find("circle3");
                PL4 = GameObject.Find("circle4");
                var randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                var oldRandomPosition = randomPosition;
                PL1.GetComponent<Transform>().position = randomPosition;
                //randomPosition = null;
                randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                while (randomPosition == oldRandomPosition)
                {
                    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                }
                if (randomPosition != oldRandomPosition)
                {
                    PL2.GetComponent<Transform>().position = randomPosition;
                }
                //else if (randomPosition == oldRandomPosition)
                //{
                //    //randomPosition = null;
                //    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                //    PL2.GetComponent<Transform>().position = randomPosition;
                //}
                var oldRandomPosition2 = randomPosition;
                randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                while (randomPosition == oldRandomPosition || randomPosition == oldRandomPosition2)
                {
                    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                }
                if (randomPosition != oldRandomPosition && randomPosition != oldRandomPosition2)
                {
                    PL3.GetComponent<Transform>().position = randomPosition;

                }
                //else if (randomPosition == oldRandomPosition || randomPosition == oldRandomPosition2)
                //{
                //    //randomPosition = null;
                //    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                //    PL3.GetComponent<Transform>().position = randomPosition;
                //}
                var oldRandomPosition3 = randomPosition;
                randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                while (randomPosition == oldRandomPosition || randomPosition == oldRandomPosition2 || randomPosition == oldRandomPosition3)
                {
                    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                }
                if (randomPosition != oldRandomPosition && randomPosition != oldRandomPosition2 && randomPosition != oldRandomPosition3)
                {
                    PL4.GetComponent<Transform>().position = randomPosition;

                }
                //else if (randomPosition == oldRandomPosition || randomPosition == oldRandomPosition2 || randomPosition == oldRandomPosition3)
                //{
                //    //randomPosition = null;
                //    randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                //    PL4.GetComponent<Transform>().position = randomPosition;
                //}
                PlayersAlive = 4;
                //Camera = GameObject.Find("CameraPL4(Clone)");
                //PL1.GetComponent<CirclesMovement>().p1 = PL2.GetComponent<CirclesMovement>();
                //PL1.GetComponent<CirclesMovement>().p2 = PL3.GetComponent<CirclesMovement>();
                //PL1.GetComponent<CirclesMovement>().p3 = PL4.GetComponent<CirclesMovement>();
                //PL2.GetComponent<CirclesMovement>().p1 = PL1.GetComponent<CirclesMovement>();
                //PL2.GetComponent<CirclesMovement>().p2 = PL3.GetComponent<CirclesMovement>();
                //PL2.GetComponent<CirclesMovement>().p3 = PL4.GetComponent<CirclesMovement>();
                //PL3.GetComponent<CirclesMovement>().p1 = PL1.GetComponent<CirclesMovement>();
                //PL3.GetComponent<CirclesMovement>().p2 = PL2.GetComponent<CirclesMovement>();
                //PL3.GetComponent<CirclesMovement>().p3 = PL4.GetComponent<CirclesMovement>();
                //PL4.GetComponent<CirclesMovement>().p1 = PL1.GetComponent<CirclesMovement>();
                //PL4.GetComponent<CirclesMovement>().p2 = PL2.GetComponent<CirclesMovement>();
                //PL4.GetComponent<CirclesMovement>().p3 = PL3.GetComponent<CirclesMovement>();
            }
            if (CurrentScene != "Finish")
            {
                if (HMPlayers >= 2)
                {
                    if (gm == "all")
                    {

                        if (CurrentScene == "Level8" || CurrentScene == "Level9")
                        {

                            GameMonetu = true;
                            PrefabTimerMonetu = Instantiate(PrefabTimerMonetu);
                            PrefabTimerMonetu.GetComponent<Canvas>().worldCamera = MC.GetComponent<Camera>();
                            PrefabTimerMonetu.GetComponentInChildren<GameTime>().SM = this;
                            if (PL1 != null)
                            {
                                PL1.GetComponent<CirclesMovement>().gamemode = "monetu";
                            }

                            if (PL2 != null)
                            {
                                PL2.GetComponent<CirclesMovement>().gamemode = "monetu";
                            }

                            if (PL3 != null)
                            {
                                PL3.GetComponent<CirclesMovement>().gamemode = "monetu";
                            }

                            if (PL4 != null)
                            {
                                PL4.GetComponent<CirclesMovement>().gamemode = "monetu";
                            }

                            gm = "monetu";
                        }
                        else
                        {
                            if (PL1 != null)
                            {
                                PL1.GetComponent<CirclesMovement>().gamemode = "dm";
                            }

                            if (PL2 != null)
                            {
                                PL2.GetComponent<CirclesMovement>().gamemode = "dm";
                            }

                            if (PL3 != null)
                            {
                                PL3.GetComponent<CirclesMovement>().gamemode = "dm";
                            }

                            if (PL4 != null)
                            {
                                PL4.GetComponent<CirclesMovement>().gamemode = "dm";
                            }
                        }
                    }
                    else if (gm == "dm")
                    {
                        GameMonetu = false;

                        //if (CurrentScene == "Level9")
                        //{
                        //}

                        if (PL1 != null)
                        {
                            PL1.GetComponent<CirclesMovement>().gamemode = "dm";
                        }

                        if (PL2 != null)
                        {
                            PL2.GetComponent<CirclesMovement>().gamemode = "dm";
                        }

                        if (PL3 != null)
                        {
                            PL3.GetComponent<CirclesMovement>().gamemode = "dm";
                        }

                        if (PL4 != null)
                        {
                            PL4.GetComponent<CirclesMovement>().gamemode = "dm";
                        }

                    }
                    else if (gm == "monetu")
                    {

                        if (CurrentScene == "Level6" || CurrentScene == "Level11")
                        {
                            MC.GetComponent<CameraScript>().LevelEnd(true);
                        }
                        else
                        {
                            GameMonetu = true;

                            PrefabTimerMonetu = Instantiate(PrefabTimerMonetu);
                            PrefabTimerMonetu.GetComponent<Canvas>().worldCamera = MC.GetComponent<Camera>();
                            PrefabTimerMonetu.GetComponentInChildren<GameTime>().SM = this;
                            if (PL1 != null)
                            {
                                PL1.GetComponent<CirclesMovement>().gamemode = "monetu";
                            }

                            if (PL2 != null)
                            {
                                PL2.GetComponent<CirclesMovement>().gamemode = "monetu";
                            }

                            if (PL3 != null)
                            {
                                PL3.GetComponent<CirclesMovement>().gamemode = "monetu";
                            }

                            if (PL4 != null)
                            {
                                PL4.GetComponent<CirclesMovement>().gamemode = "monetu";
                            }
                        }
                    }
                }
                else if (HMPlayers == 1)
                {
                    if (CurrentScene == "Level9" || CurrentScene == "Level10")
                    {
                        MC.GetComponent<CameraScript>().LevelEnd(true);
                    }
                    GameMonetu = false;
                    if (PL1 != null)
                    {
                        PL1.GetComponent<CirclesMovement>().gamemode = "dm";
                    }

                    if (PL2 != null)
                    {
                        PL2.GetComponent<BotMovement>().gamemode = "dm";
                    }

                    if (PL3 != null)
                    {
                        PL3.GetComponent<BotMovement>().gamemode = "dm";
                    }

                    if (PL4 != null)
                    {
                        PL4.GetComponent<BotMovement>().gamemode = "dm";
                    }



                }

                if (CurrentScene == "Level7")
                {
                    if (PL1 != null)
                    {
                        PL1.GetComponent<Rigidbody2D>().gravityScale = 0f;
                    }

                    if (PL2 != null)
                    {
                        PL2.GetComponent<Rigidbody2D>().gravityScale = 0f;
                    }

                    if (PL3 != null)
                    {
                        PL3.GetComponent<Rigidbody2D>().gravityScale = 0f;
                    }

                    if (PL4 != null)
                    {
                        PL4.GetComponent<Rigidbody2D>().gravityScale = 0f;
                    }

                }

            }
            else
            {
                Finish();
            }
           

        }
        
        //PhotonView = GetComponent<PhotonView>();


    }

    // Update is called once per frame
    void Update()
    {
        //Time.timeScale = 1;
        if (firstTimeLevel)
        {
            if (PlayersAlive <= 1 && gm == "monetu")
            {
                MC.GetComponent<CameraScript>().LevelEnd(false);
                firstTimeLevel = false;
            }   
        }

        if (GameMonetu)
        {
            SpeedTime1 = SpeedTime1 + 20 * Time.deltaTime;
            if ((SpeedTime1 > SpeedTime2))
            {
                //SpeedTime2 = SpeedTime2 + 100f * Time.deltaTime;
                SpeedTime1 = 0;
                //randomPosition = 
                monetaT = Instantiate(moneta);
                monetaT.GetComponent<Transform>().position = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition + new Vector3(Random.Range(-2, 2), Random.Range(-2, 2), 0);
                monetaT.GetComponent<Moneta>().C1 = PL1;
                monetaT.GetComponent<Moneta>().C2 = PL2;
                if (PL3 != null)
                {
                    monetaT.GetComponent<Moneta>().C3 = PL3;
                }
                if (PL4 != null)
                {
                    monetaT.GetComponent<Moneta>().C4 = PL4;
                }
                //Instantiate
            }
        }

        if (TimerDone && !firsttimeAddScore)
        {
            PlayerPrefs.SetFloat("LastWin", 0);
            firsttimeAddScore = true;
            PL1.GetComponent<CirclesMovement>().AddScore();
            PL2.GetComponent<CirclesMovement>().AddScore();
            if (PL3 != null)
            {
                PL3.GetComponent<CirclesMovement>().AddScore();
            }
            if (PL4 != null)
            {
                PL4.GetComponent<CirclesMovement>().AddScore();
            }
            
            MC.GetComponent<CameraScript>().LevelEnd(false);
        }

        

    }

    

    public void SpawnBot(GameObject DestroyedBot)
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            GameObject Bot1 = Instantiate(Bot);
            Bot1.GetComponent<BotMovement>().Force = 2f;
            //var randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition + new Vector3(Random.Range(4, 8), Random.Range(4, 8), 0);
            Vector3 randomPosition = new Vector3(Random.Range(-6, 8), Random.Range(-2, 7), 0);
            //var oldRandomPosition = randomPosition;
            Bot1.transform.position = randomPosition;
        }
        else if (CurrentScene != "Menu" && CurrentScene != "")
        {
            //difficulty = PlayerPrefs.GetFloat("difficulty");
            //if (difficulty == 1 || difficulty == 0)
            //{

            //}
            //else if (difficulty == 2)
            //{

            //}
            if (DestroyedBot == PL2)
            {
                GameObject Bot1 = Instantiate(Bot);
                var Bot1S = Bot1.GetComponent<BotMovement>();
                PL2 = Bot1;
                var randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                Bot1.transform.position = randomPosition;
                Bot1S.CS = MC.GetComponent<CameraScript>();
                Bot1S.Player = PL1.GetComponent<CirclesMovement>();
            }
            else if (DestroyedBot == PL3)
            {
                GameObject Bot1 = Instantiate(Bot);
                var Bot1S = Bot1.GetComponent<BotMovement>();
                PL3 = Bot1;
                var randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                Bot1.transform.position = randomPosition;
                Bot1S.CS = MC.GetComponent<CameraScript>();
                Bot1S.Player = PL1.GetComponent<CirclesMovement>();
            }
            else if (DestroyedBot == PL4)
            {
                GameObject Bot1 = Instantiate(Bot);
                var Bot1S = Bot1.GetComponent<BotMovement>();
                PL4 = Bot1;
                var randomPosition = Spawns[(int)Mathf.Round(Random.Range(0, Spawns.Length))].transform.localPosition;
                Bot1.transform.position = randomPosition;
                Bot1S.CS = MC.GetComponent<CameraScript>();
                Bot1S.Player = PL1.GetComponent<CirclesMovement>();
            }
            
        }

    }

    public void GetActiveSceneForBot(BotMovement Bot)
    {
        CurrentScene = SceneManager.GetActiveScene().name;
        Bot.CurrentScene = CurrentScene;
        if (CurrentScene == "Menu")
        {
            Destroy(Bot.BA);
            Bot.Force = 2f;
        }
    }

    public void CameraShake()
    {
        //Camera.GetComponent<StressReceiver>().
        //if (Camera.GetComponent<Animator>().runtimeAnimatorController == null)
        //{
        //    Camera.GetComponent<Animator>().runtimeAnimatorController = Shake;
        //}    
    }

   

    void Finish()
    {
        gm = "";
        MC.GetComponent<CameraScript>().isFinish = true;
        if (CurrentScene == "Finish")
        {
            //float HMRounds = PlayerPrefs.GetFloat("HMRounds");
            //RandomLevels = PlayerPrefs.GetFloat("RandomLevels");
            float HMRoundsPlayed = PlayerPrefs.GetFloat("HMRoundsPlayed");
            if (HMRoundsPlayed > 49)
            {
                PlayerPrefs.SetFloat("SmileBuy", 1);
            }
            Destroy(MC.GetComponent<CameraScript>().card1);
            Destroy(MC.GetComponent<CameraScript>().card2);
            Destroy(MC.GetComponent<CameraScript>().card3);
            finishCanvas.worldCamera = MC.GetComponent<Camera>();
            HMPlayers = PlayerPrefs.GetFloat("HMPlayersF");
            float SP1 = PlayerPrefs.GetFloat("SP1");
            float SP2 = PlayerPrefs.GetFloat("SP2");
            float SP3 = PlayerPrefs.GetFloat("SP3");
            float SP4 = PlayerPrefs.GetFloat("SP4");
            //float HMM = PlayerPrefs.GetFloat("Money");
            float HMR = PlayerPrefs.GetFloat("HMRounds");
            float MM1 = PlayerPrefs.GetFloat("MoneyMultiplier1");
            float MM2 = PlayerPrefs.GetFloat("MoneyMultiplier2");
            float MM3 = PlayerPrefs.GetFloat("MoneyMultiplier3");
            float MM4 = PlayerPrefs.GetFloat("MoneyMultiplier4");
            float IsADS = PlayerPrefs.GetFloat("IsADS");

            if (IsADS == 1)
            {
                if (MM1 >= MM2 && MM1 >= MM3 && MM1 >= MM4)
                {
                    Money1 = 4 * HMR * MM1;
                }
                else if (MM2 >= MM1 && MM2 >= MM3 && MM2 >= MM4)
                {
                    Money1 = 4 * HMR * MM2;
                }
                else if (MM3 >= MM1 && MM3 >= MM4 && MM3 >= MM2)
                {
                    Money1 = 4 * HMR * 3;
                }
                else if (MM4 >= MM1 && MM4 >= MM3 && MM4 >= MM2)
                {
                    Money1 = 4 * HMR * MM4;
                    //Money1 = PlayerPrefs.GetFloat("Money");
                }
                while (Money1 > MoneyF)
                {
                    MoneyF++;
                    var M = Instantiate(Money);
                    M.transform.position = FinishMoneySpawns[Random.Range(0, Spawns.Length)].transform.localPosition + new Vector3(Random.Range(-3, 3), Random.Range(-4, 4), 0);
                }
            }
            
            if (HMPlayers == 0)
            {
                HMPlayers = 2;
            }
            else if (HMPlayers == 1)
            {
                PL1.transform.position = new Vector3(FirstPlace.position.x, FirstPlace.position.y, 0);
                ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                //Destroy(PL4);
                PL2.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = (HMRoundsPlayed - SP1).ToString();
                PL3.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = (HMRoundsPlayed - SP1).ToString();
                PL4.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
            }
            else if (HMPlayers == 2)
            {
                if (SP1 > SP2)
                {
                    PL1.transform.position = new Vector3(FirstPlace.position.x, FirstPlace.position.y, 0);
                    PL2.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                    ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                    ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                }
                else if (SP2 > SP1)
                {
                    PL2.transform.position = new Vector3(FirstPlace.position.x, FirstPlace.position.y, 0);
                    PL1.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                    ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                    ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                }
            }
            else if (HMPlayers == 3)
            {
                if (SP1 > SP2 && SP1 > SP3)
                {
                    PL1.transform.position = new Vector3(FirstPlace.position.x, FirstPlace.position.y, 0);
                    //PL2.transform.position = SecondPlace.position;

                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                    //ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                    if (SP2 > SP3)
                    {
                        PL2.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        PL3.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                    }
                    else if (SP3 > SP2)
                    {
                        PL2.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                        PL3.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                    }
                }
                else if (SP2 > SP1 && SP2 > SP3)
                {
                    PL2.transform.position = new Vector3(FirstPlace.position.x, FirstPlace.position.y, 0);
                    //PL2.transform.position = SecondPlace.position;

                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                    //ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                    if (SP1 > SP3)
                    {
                        PL1.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        PL3.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                    }
                    else if (SP3 > SP1)
                    {
                        PL1.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                        PL3.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                    }
                }
                else if (SP3 > SP1 && SP3 > SP2)
                {
                    PL3.transform.position = new Vector3(FirstPlace.position.x, FirstPlace.position.y, 0);
                    //PL2.transform.position = SecondPlace.position;

                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                    //ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                    if (SP1 > SP2)
                    {
                        PL1.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        PL2.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                    }
                    else if (SP2 > SP1)
                    {
                        PL1.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                        PL2.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                        ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                    }
                }
            }
            else if (HMPlayers == 4)
            {
                if (SP1 > SP2 && SP1 > SP3 && SP1 > SP4)
                {
                    PL1.transform.position = new Vector3(FirstPlace.position.x, FirstPlace.position.y, 0);
                    //PL2.transform.position = SecondPlace.position;

                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                    //ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                    if (SP2 > SP3 && SP2 > SP4)
                    {
                        PL2.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);

                        if (SP3 > SP4)
                        {
                            PL3.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            PL4.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP4.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                        }
                        else if (SP4 > SP3)
                        {
                            PL4.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP4.ToString();
                            PL3.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);
                        }
                    }
                    else if (SP3 > SP2 && SP3 > SP4)
                    {
                        PL3.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);

                        if (SP2 > SP4)
                        {
                            PL2.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            PL4.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP4.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                        }
                        else if (SP4 > SP2)
                        {
                            PL4.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP4.ToString();
                            PL2.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);
                        }
                    }
                    else if (SP4 > SP3 && SP4 > SP2)
                    {
                        PL4.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP4.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);

                        if (SP2 > SP3)
                        {
                            PL2.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            PL3.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                        }
                        else if (SP3 > SP2)
                        {
                            PL3.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            PL2.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                        }
                    }
                }
                else if (SP2 > SP1 && SP2 > SP3 && SP2 > SP4)
                {
                    PL2.transform.position = new Vector3(FirstPlace.position.x, FirstPlace.position.y, 0);
                    //PL2.transform.position = SecondPlace.position;

                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                    //ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                    if (SP1 > SP3 && SP1 > SP4)
                    {
                        PL1.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);

                        if (SP3 > SP4)
                        {
                            PL3.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            PL4.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP4.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                        }
                        else if (SP4 > SP3)
                        {
                            PL4.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP4.ToString();
                            PL3.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);
                        }
                    }
                    else if (SP3 > SP1 && SP3 > SP4)
                    {
                        PL3.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);

                        if (SP1 > SP4)
                        {
                            PL1.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            PL4.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP4.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                        }
                        else if (SP4 > SP1)
                        {
                            PL4.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP4.ToString();
                            PL1.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);
                        }
                    }
                    else if (SP4 > SP3 && SP4 > SP1)
                    {
                        PL4.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP4.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);

                        if (SP1 > SP3)
                        {
                            PL1.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            PL3.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                        }
                        else if (SP3 > SP1)
                        {
                            PL3.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            PL1.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                        }
                    }
                }
                else if (SP4 > SP1 && SP4 > SP2 && SP4 > SP3)
                {
                    PL4.transform.position = new Vector3(FirstPlace.position.x, FirstPlace.position.y, 0);
                    //PL2.transform.position = SecondPlace.position;

                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().text = SP4.ToString();
                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                    //ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                    if (SP1 > SP2 && SP1 > SP3)
                    {
                        PL1.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                        if (SP2 > SP3)
                        {
                            PL2.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            PL3.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                        }
                        else if (SP3 > SP2)
                        {
                            PL3.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            PL2.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                        }
                    }
                    else if (SP2 > SP1 && SP2 > SP3)
                    {
                        PL2.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);

                        if (SP1 > SP3)
                        {
                            PL1.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            PL3.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                        }
                        else if (SP3 > SP1)
                        {
                            PL3.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            PL1.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                        }
                    }
                    else if (SP3 > SP2 && SP3 > SP1)
                    {
                        PL3.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);

                        if (SP1 > SP2)
                        {
                            PL1.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            PL2.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                        }
                        else if (SP2 > SP1)
                        {
                            PL2.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            PL1.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                        }
                    }
                }
                else if (SP3 > SP1 && SP3 > SP2 && SP3 > SP4)
                {
                    PL3.transform.position = new Vector3(FirstPlace.position.x, FirstPlace.position.y, 0);
                    //PL2.transform.position = SecondPlace.position;

                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                    ScoreOnFirst.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                    //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                    //ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                    if (SP1 > SP2 && SP1 > SP3)
                    {
                        PL1.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);

                        if (SP2 > SP3)
                        {
                            PL2.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            PL3.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                        }
                        else if (SP3 > SP2)
                        {
                            PL3.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            PL2.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                        }
                    }
                    else if (SP2 > SP1 && SP2 > SP3)
                    {
                        PL2.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);

                        if (SP1 > SP3)
                        {
                            PL1.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            PL3.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                        }
                        else if (SP3 > SP1)
                        {
                            PL3.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                            PL1.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
                        }
                    }
                    else if (SP3 > SP2 && SP3 > SP1)
                    {
                        PL3.transform.position = new Vector3(SecondPlace.position.x, SecondPlace.position.y, 0);
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().text = SP3.ToString();
                        ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);

                        if (SP1 > SP2)
                        {
                            PL1.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            PL2.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 1);
                        }
                        else if (SP2 > SP1)
                        {
                            PL2.transform.position = new Vector3(ThirdPlace.position.x, ThirdPlace.position.y, 0);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().text = SP2.ToString();
                            PL1.transform.position = new Vector3(FouthPlace.position.x, FouthPlace.position.y, 0);
                            //ScoreOnFouth.GetComponent<UnityEngine.UI.Text>().text = SP1.ToString();
                            //ScoreOnSecond.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                            ScoreOnThird.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
                        }
                    }
                }
            }
            
        }
    }
    private void Awake()
    {

        //if (SpawnNumber == 1)
        //{
        
            
            
            //SpawnNumber = SpawnNumber + 1;
        //}
        //else if (SpawnNumber == 2)
        //{
        //    PhotonNetwork.Instantiate(Player.name, Spawns[2].transform.localPosition, Quaternion.identity);
        //    SpawnNumber = SpawnNumber + 1;
        //}
        //else if (SpawnNumber == 3)
        //{
        //    PhotonNetwork.Instantiate(Player.name, Spawns[3].transform.localPosition, Quaternion.identity);
        //    SpawnNumber = SpawnNumber + 1;
        //}
        //else if (SpawnNumber == 4)
        //{
        //    PhotonNetwork.Instantiate(Player.name, Spawns[4].transform.localPosition, Quaternion.identity);
        //    SpawnNumber = SpawnNumber + 1;
        //}
        //else if (SpawnNumber == 5)
        //{
        //    PhotonNetwork.Instantiate(Player.name, Spawns[5].transform.localPosition, Quaternion.identity);
        //    SpawnNumber = SpawnNumber + 1;
        //}
        //else if (SpawnNumber == 6)
        //{
        //    PhotonNetwork.Instantiate(Player.name, Spawns[6].transform.localPosition, Quaternion.identity);
        //    SpawnNumber = SpawnNumber + 1;
        //}
        //else if (SpawnNumber == 7)
        //{
        //    PhotonNetwork.Instantiate(Player.name, Spawns[7].transform.localPosition, Quaternion.identity);
        //    SpawnNumber = SpawnNumber + 1;
        //}
        //else if (SpawnNumber == 8)
        //{
        //    PhotonNetwork.Instantiate(Player.name, Spawns[8].transform.localPosition, Quaternion.identity);
        //    SpawnNumber = SpawnNumber + 1;
        //}
        //PhotonView.RPC("Send_Data", RpcTarget.AllBuffered, NewCircle);
    }
}
