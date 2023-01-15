using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Localization.Settings;

public class CameraScript : MonoBehaviour
{
    //public SpawnManager SM;
    public int level = 1;
    public RuntimeAnimatorController LevelEndAnim;
    public float RandomLevels;
    public float HMRounds;
    public float HMRoundsPlayed = 0;
    public Joystick joy1;
    public Joystick joy2;
    public Joystick joy3;
    public Joystick joy4;
    public GameObject ScoreN1;
    public GameObject ScoreN2;
    public GameObject ScoreN3;
    public GameObject ScoreN4;
    public float LastWin;
    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    float rcard1;
    float rcard2;
    float rcard3;
    float rcard4;
    float rcard5;
    float rarity1;
    float rarity2;
    float rarity3;
    float rarity4;
    float rarity5;
    public CirclesMovement p1;
    public CirclesMovement p2;
    public CirclesMovement p3;
    public CirclesMovement p4;
    public GameObject Choose1;
    public GameObject Choose2;
    public GameObject Choose3;
    public GameObject Choose4;
    public bool isFinish;
    public Material text0;
    public float timeStart = 15;
    public Slider timeSlider;
    public Image timeColor;
    public bool NoSlider;
    float HMR = 3;
    CirclesMovement newVar;
    float HMPlayersF;
    public GameObject BackButton;
    public SpawnManager SM;
    public bool alreadyLevelEnd = false;
    public string Freezing;
    public string Energizer;
    public string Bouncy;
    public string Takealookaround;
    public string WaveSpeed;
    public float TripleTake;
    public float FriendOfGlass;
    public float HMRFreezing;
    public float HMREnergizer;
    public float HMRBouncy;
    public float HMRTakealookaround;
    public float HMRWaveSpeed;
    public float HMRTripleTake;
    //public float HMRFriendOfGlass;
    float MoneyBox;
    //public loca

    //float lastwin;
    //public Scene FinishPrefab;

    public void CardButton(GameObject ThisButton)
    {
        LocalizationSettings.SelectedLocale.Formatter.ToString();
        LastWin = PlayerPrefs.GetFloat("LastWin");
        HMR = 3;


        if (ThisButton.name == card1.name)
        {
            if (rcard1 == 1)
            {
                PlayerPrefs.SetFloat("Freezing" + LastWin.ToString(), int.Parse("1" + LastWin.ToString() + rarity1));
                PlayerPrefs.SetFloat("HMR" + "Freezing" + LastWin.ToString(), HMR);

                if (rarity1 == 1)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), 1);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.85);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.859);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n";

                }
                else if (rarity1 == 2)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.2);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.80);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.718);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+20% to freezing time";
                }
                else if (rarity1 == 3)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.4);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.70);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.577);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+40% to freezing time";
                }
                else if (rarity1 == 4)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.60);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.436);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+50% to freezing time";
                }
                else if (rarity1 == 5)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.6);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.50);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+60% to freezing time";
                }
                else if (rarity1 == 6)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)2);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.35);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.295);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+100% to freezing time";
                }
                else if (rarity1 == 7)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)3);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.20);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.013);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+200% to freezing time";
                }
            }
            else if (rcard1 == 2)
            {
                PlayerPrefs.SetFloat("Energizer" + LastWin.ToString(), int.Parse("2" + LastWin.ToString() + rarity1));
                PlayerPrefs.SetFloat("HMR" + "Energizer" + LastWin.ToString(), HMR);
                if (rarity1 == 1)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+5% to max speed\n";

                }
                else if (rarity1 == 2)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.1);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to max speed";
                }
                else if (rarity1 == 3)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to max speed\n+5% to acceleration";
                }
                else if (rarity1 == 4)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+15% to max speed\n+5% to acceleration";
                }
                else if (rarity1 == 5)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.20);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.1);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+20% to max speed\n+10% to acceleration";
                }
                else if (rarity1 == 6)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.30);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.15);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+30% to max speed\n+15% to acceleration";
                }
                else if (rarity1 == 7)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.25);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+50% to max speed\n+25% to acceleration";
                }
            }
            else if (rcard1 == 3)
            {
                PlayerPrefs.SetFloat("Bouncy" + LastWin.ToString(), int.Parse("3" + LastWin.ToString() + rarity1));
                PlayerPrefs.SetFloat("HMR" + "Bouncy" + LastWin.ToString(), HMR);
                if (rarity1 == 1)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to repulsions\n+5% to hit you";

                }
                else if (rarity1 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.07);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+15% to repulsions\n+7% to hit you";
                }
                else if (rarity1 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.2);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.1);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+20% to repulsions\n+10% to hit you";
                }
                else if (rarity1 == 4)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.35);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.17);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+35% to repulsions\n+17% to hit you";
                }
                else if (rarity1 == 5)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.25);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+50% to repulsions\n+25% to hit you";
                }
                else if (rarity1 == 6)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.7);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.30);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+70% to repulsions\n+30% to hit you";
                }
                else if (rarity1 == 7)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)2);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.4);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to repulsions\n+40% to hit you";
                }
            }
            else if (rcard1 == 4)
            {
                PlayerPrefs.SetFloat("Friend of Glass" + LastWin.ToString(), int.Parse("4" + LastWin.ToString() + rarity1));
                //PlayerPrefs.SetFloat("HMR" + "Friend of Glass" + LastWin.ToString(), HMR);
                //PlayerPrefs.SetFloat("Friend of Glass2" + LastWin.ToString(), 1);

                //PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.05);
                //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to repulsions\n+5% to hit you";
            }
            else if (rcard1 == 5)
            {
                PlayerPrefs.SetFloat("Take a look around" + LastWin.ToString(), int.Parse("5" + LastWin.ToString() + rarity1));
                PlayerPrefs.SetFloat("HMR" + "Look around" + LastWin.ToString(), HMR);
                if (rarity1 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), 1);
                }
                else if (rarity1 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.1);
                }
                else if (rarity1 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.15);
                }
                else if (rarity1 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.30);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.35);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.35);
                }
                else if (rarity1 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.35);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.40);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.40);
                }
                else if (rarity1 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.40);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.60);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.60);

                }
                else if (rarity1 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.50);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), 2);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), 2);

                }
                //PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.05);
                //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to repulsions\n+5% to hit you";
            }
            if (rcard1 == 6)
            {
                //rarity1 = Mathf.Round(Random.Range(1, (float)7.2));
                //card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "The Money Box";
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                //card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "More crystals at the end of the game";
                PlayerPrefs.SetFloat("The Money Box Rarity", rarity1);
                if (rarity1 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.10);
                }
                else if (rarity1 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.14);
                }
                else if (rarity1 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.18);
                }
                else if (rarity1 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.25);
                }
                else if (rarity1 == 5)
                {
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.35);
                }
                else if (rarity1 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.50);
                }
                else if (rarity1 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)2);
                }
            }
            if (rcard1 == 7)
            {
                PlayerPrefs.SetFloat("WaveSpeed" + LastWin.ToString(), int.Parse("7" + LastWin.ToString() + rarity1));
                PlayerPrefs.SetFloat("HMR" + "WaveSpeed" + LastWin.ToString(), HMR);

                if (rarity1 == 1)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)1);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.859);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n";

                }
                else if (rarity1 == 2)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)1);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.718);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+20% to freezing time";
                }
                else if (rarity1 == 3)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.20);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.90);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.577);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+40% to freezing time";
                }
                else if (rarity1 == 4)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.3);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.8);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.436);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+50% to freezing time";
                }
                else if (rarity1 == 5)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.6);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+60% to freezing time";
                }
                else if (rarity1 == 6)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.7);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.4);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.295);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+100% to freezing time";
                }
                else if (rarity1 == 7)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)2);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.5);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.013);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+200% to freezing time";
                }
            }
            if (rcard1 == 8)
            {
                PlayerPrefs.SetFloat("TripleTake" + LastWin.ToString(), int.Parse("8" + LastWin.ToString()));
                PlayerPrefs.SetFloat("HMR" + "TripleTake" + LastWin.ToString(), HMR);
            }
        }
        else if (ThisButton.name == card2.name)
        {
            if (rcard2 == 1)
            {
                PlayerPrefs.SetFloat("Freezing" + LastWin.ToString(), int.Parse("1" + LastWin.ToString() + rarity2));
                PlayerPrefs.SetFloat("HMR" + "Freezing" + LastWin.ToString(), HMR);


                if (rarity2 == 1)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), 1);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.85);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.859);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n";

                }
                else if (rarity2 == 2)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.2);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.80);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.718);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+20% to freezing time";
                }
                else if (rarity2 == 3)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.4);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.70);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.577);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+40% to freezing time";
                }
                else if (rarity2 == 4)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.60);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.436);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+50% to freezing time";
                }
                else if (rarity2 == 5)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.6);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.50);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+60% to freezing time";
                }
                else if (rarity2 == 6)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)2);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.35);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.295);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+100% to freezing time";
                }
                else if (rarity2 == 7)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)3);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.20);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.013);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+200% to freezing time";
                }
            }
            else if (rcard2 == 2)
            {
                PlayerPrefs.SetFloat("Energizer" + LastWin.ToString(), int.Parse("2" + LastWin.ToString() + rarity2));
                PlayerPrefs.SetFloat("HMR" + "Energizer" + LastWin.ToString(), HMR);

                if (rarity2 == 1)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+5% to max speed\n";

                }
                else if (rarity2 == 2)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.1);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to max speed";
                }
                else if (rarity2 == 3)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to max speed\n+5% to acceleration";
                }
                else if (rarity2 == 4)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+15% to max speed\n+5% to acceleration";
                }
                else if (rarity2 == 5)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.20);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.1);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+20% to max speed\n+10% to acceleration";
                }
                else if (rarity2 == 6)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.30);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.15);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+30% to max speed\n+15% to acceleration";
                }
                else if (rarity2 == 7)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.25);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+50% to max speed\n+25% to acceleration";
                }
            }
            else if (rcard2 == 3)
            {
                PlayerPrefs.SetFloat("Bouncy" + LastWin.ToString(), int.Parse("3" + LastWin.ToString() + rarity2));
                PlayerPrefs.SetFloat("HMR" + "Bouncy" + LastWin.ToString(), HMR);
                if (rarity2 == 1)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to repulsions\n+5% to hit you";

                }
                else if (rarity2 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.07);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+15% to repulsions\n+7% to hit you";
                }
                else if (rarity2 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.2);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.1);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+20% to repulsions\n+10% to hit you";
                }
                else if (rarity2 == 4)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.35);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.17);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+35% to repulsions\n+17% to hit you";
                }
                else if (rarity2 == 5)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.25);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+50% to repulsions\n+25% to hit you";
                }
                else if (rarity2 == 6)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.7);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.30);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+70% to repulsions\n+30% to hit you";
                }
                else if (rarity2 == 7)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)2);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.4);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to repulsions\n+40% to hit you";
                }
            }
            else if (rcard2 == 4)
            {
                PlayerPrefs.SetFloat("Friend of Glass" + LastWin.ToString(), int.Parse("4" + LastWin.ToString() + rarity2));
                //PlayerPrefs.SetFloat("Friend of Glass2" + LastWin.ToString(), 1);
                //PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.05);
                //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to repulsions\n+5% to hit you";
            }
            else if (rcard2 == 5)
            {
                PlayerPrefs.SetFloat("Take a look around" + LastWin.ToString(), int.Parse("5" + LastWin.ToString() + rarity2));
                PlayerPrefs.SetFloat("HMR" + "Look around" + LastWin.ToString(), HMR);

                if (rarity2 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), 1);
                }
                else if (rarity2 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.1);
                }
                else if (rarity2 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.15);
                }
                else if (rarity2 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.30);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.35);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.35);
                }
                else if (rarity2 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.35);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.40);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.40);
                }
                else if (rarity2 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.40);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.60);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.60);

                }
                else if (rarity2 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.50);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), 2);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), 2);

                }
                //PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.05);
                //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to repulsions\n+5% to hit you";
            }
            if (rcard2 == 6)
            {
                //rarity1 = Mathf.Round(Random.Range(1, (float)7.2));
                //card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "The Money Box";
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                //card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "More crystals at the end of the game";
                PlayerPrefs.SetFloat("The Money Box Rarity", rarity2);
                if (rarity2 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.10);
                }
                else if (rarity2 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.14);
                }
                else if (rarity2 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.18);
                }
                else if (rarity2 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.25);
                }
                else if (rarity2 == 5)
                {
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.35);
                }
                else if (rarity2 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.50);
                }
                else if (rarity2 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)2);
                }
            }
            if (rcard2 == 7)
            {
                PlayerPrefs.SetFloat("WaveSpeed" + LastWin.ToString(), int.Parse("7" + LastWin.ToString() + rarity2));
                PlayerPrefs.SetFloat("HMR" + "WaveSpeed" + LastWin.ToString(), HMR);

                if (rarity2 == 1)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)1);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.859);
                    //card2.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card2.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n";

                }
                else if (rarity2 == 2)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)1);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.718);
                    //card2.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card2.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+20% to freezing time";
                }
                else if (rarity2 == 3)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.20);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.90);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.577);
                    //card2.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card2.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+40% to freezing time";
                }
                else if (rarity2 == 4)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.3);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.8);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.436);
                    //card2.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card2.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+50% to freezing time";
                }
                else if (rarity2 == 5)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.6);
                    //card2.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card2.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+60% to freezing time";
                }
                else if (rarity2 == 6)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.7);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.4);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.295);
                    //card2.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card2.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+100% to freezing time";
                }
                else if (rarity2 == 7)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)2);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.5);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.013);
                    //card2.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card2.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+200% to freezing time";
                }
            }
            if (rcard2 == 8)
            {
                PlayerPrefs.SetFloat("TripleTake" + LastWin.ToString(), int.Parse("8" + LastWin.ToString()));
                PlayerPrefs.SetFloat("HMR" + "TripleTake" + LastWin.ToString(), HMR);
            }
        }
        else if (ThisButton.name == card3.name)
        {
            if (rcard3 == 1)
            {
                PlayerPrefs.SetFloat("Freezing" + LastWin.ToString(), int.Parse("1" + LastWin.ToString() + rarity3));
                PlayerPrefs.SetFloat("HMR" + "Freezing" + LastWin.ToString(), HMR);
                if (rarity3 == 1)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), 1);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.85);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.859);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n";

                }
                else if (rarity3 == 2)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.2);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.80);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.718);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+20% to freezing time";
                }
                else if (rarity3 == 3)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.4);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.70);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.577);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+40% to freezing time";
                }
                else if (rarity3 == 4)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.60);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.436);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+50% to freezing time";
                }
                else if (rarity1 == 5)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)1.6);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.50);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+60% to freezing time";
                }
                else if (rarity3 == 6)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)2);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.35);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.295);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+100% to freezing time";
                }
                else if (rarity3 == 7)
                {
                    PlayerPrefs.SetFloat("FreezingTime" + LastWin.ToString(), (float)3);
                    PlayerPrefs.SetFloat("FreezingMult" + LastWin.ToString(), (float)0.20);
                    PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.013);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+200% to freezing time";
                }
            }
            else if (rcard3 == 2)
            {
                PlayerPrefs.SetFloat("Energizer" + LastWin.ToString(), int.Parse("2" + LastWin.ToString() + rarity3));
                PlayerPrefs.SetFloat("HMR" + "Energizer" + LastWin.ToString(), HMR);
                if (rarity3 == 1)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+5% to max speed\n";

                }
                else if (rarity3 == 2)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.1);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to max speed";
                }
                else if (rarity3 == 3)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to max speed\n+5% to acceleration";
                }
                else if (rarity3 == 4)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+15% to max speed\n+5% to acceleration";
                }
                else if (rarity3 == 5)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.20);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.1);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+20% to max speed\n+10% to acceleration";
                }
                else if (rarity3 == 6)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.30);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.15);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+30% to max speed\n+15% to acceleration";
                }
                else if (rarity3 == 7)
                {
                    PlayerPrefs.SetFloat("MaxSpeed" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("Acceleration" + LastWin.ToString(), (float)1.25);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+50% to max speed\n+25% to acceleration";
                }
            }
            else if (rcard3 == 3)
            {
                PlayerPrefs.SetFloat("Bouncy" + LastWin.ToString(), int.Parse("3" + LastWin.ToString() + rarity3));
                PlayerPrefs.SetFloat("HMR" + "Bouncy" + LastWin.ToString(), HMR);
                if (rarity3 == 1)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.05);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to repulsions\n+5% to hit you";

                }
                else if (rarity3 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.07);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+15% to repulsions\n+7% to hit you";
                }
                else if (rarity3 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.2);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.1);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+20% to repulsions\n+10% to hit you";
                }
                else if (rarity3 == 4)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.35);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.17);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+35% to repulsions\n+17% to hit you";
                }
                else if (rarity3 == 5)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.25);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+50% to repulsions\n+25% to hit you";
                }
                else if (rarity3 == 6)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)1.7);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.30);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+70% to repulsions\n+30% to hit you";
                }
                else if (rarity3 == 7)
                {
                    PlayerPrefs.SetFloat("BouncyForce" + LastWin.ToString(), (float)2);
                    PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.4);
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card1.transform.GetChild(5).GetComponent<Text>().text = "+100% to repulsions\n+40% to hit you";
                }
            }
            else if (rcard3 == 4)
            {
                PlayerPrefs.SetFloat("Friend of Glass" + LastWin.ToString(), int.Parse("4" + LastWin.ToString() + rarity3));
                //PlayerPrefs.SetFloat("Friend of Glass2" + LastWin.ToString(), 1);
                //PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.05);
                //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to repulsions\n+5% to hit you";
            }
            else if (rcard3 == 5)
            {
                PlayerPrefs.SetFloat("Take a look around" + LastWin.ToString(), int.Parse("5" + LastWin.ToString() + rarity3));
                PlayerPrefs.SetFloat("HMR" + "Look around" + LastWin.ToString(), HMR);

                if (rarity3 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), 1);
                }
                else if (rarity3 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.1);
                }
                else if (rarity3 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.15);
                }
                else if (rarity3 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.30);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.35);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.35);
                }
                else if (rarity3 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.35);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.40);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.40);
                }
                else if (rarity3 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.40);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), (float)1.60);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), (float)1.60);

                }
                else if (rarity3 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    PlayerPrefs.SetFloat("Take a look aroundTime" + LastWin.ToString(), (float)1.50);
                    PlayerPrefs.SetFloat("Take a look aroundMaxSpeed" + LastWin.ToString(), 2);
                    PlayerPrefs.SetFloat("Take a look aroundAcc" + LastWin.ToString(), 2);

                }
            }
            if (rcard3 == 6)
            {
                //rarity1 = Mathf.Round(Random.Range(1, (float)7.2));
                //card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "The Money Box";
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                //card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "More crystals at the end of the game";
                PlayerPrefs.SetFloat("The Money Box Rarity", rarity3);
                if (rarity3 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.10);
                }
                else if (rarity3 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.14);
                }
                else if (rarity3 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.18);
                }
                else if (rarity3 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.25);
                }
                else if (rarity3 == 5)
                {
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.35);
                }
                else if (rarity3 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)1.50);
                }
                else if (rarity3 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    PlayerPrefs.SetFloat("MoneyMultiplier" + LastWin.ToString(), (float)2);
                }
            }
            if (rcard3 == 7)
            {
                PlayerPrefs.SetFloat("WaveSpeed" + LastWin.ToString(), int.Parse("7" + LastWin.ToString() + rarity3));
                PlayerPrefs.SetFloat("HMR" + "WaveSpeed" + LastWin.ToString(), HMR);

                if (rarity3 == 1)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.1);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)1);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.859);
                    //card3.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
                    //card3.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n";

                }
                else if (rarity3 == 2)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.15);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)1);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.718);
                    //card3.transform.GetChild(1).GetComponent<TextMesh>().text = "Standart";
                    //card3.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+20% to freezing time";
                }
                else if (rarity3 == 3)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.20);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.90);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.577);
                    //card3.transform.GetChild(1).GetComponent<TextMesh>().text = "Improved";
                    //card3.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+40% to freezing time";
                }
                else if (rarity3 == 4)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.3);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.8);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.436);
                    //card3.transform.GetChild(1).GetComponent<TextMesh>().text = "Rare";
                    //card3.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+50% to freezing time";
                }
                else if (rarity3 == 5)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.5);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.6);
                    //card3.transform.GetChild(1).GetComponent<TextMesh>().text = "Heroic";
                    //card3.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+60% to freezing time";
                }
                else if (rarity3 == 6)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)1.7);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.4);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.295);
                    //card3.transform.GetChild(1).GetComponent<TextMesh>().text = "Legendary";
                    //card3.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+100% to freezing time";
                }
                else if (rarity3 == 7)
                {
                    PlayerPrefs.SetFloat("WaveSpeedModifier" + LastWin.ToString(), (float)2);
                    PlayerPrefs.SetFloat("WaveScaleSpeedModifier" + LastWin.ToString(), (float)0.5);
                    //PlayerPrefs.SetFloat("FreezingColor" + LastWin.ToString(), (float)0.013);
                    //card3.transform.GetChild(1).GetComponent<TextMesh>().text = "Mythical";
                    //card3.transform.GetChild(5).GetComponent<Text>().text = "+100% to freezing\n+200% to freezing time";
                }
            }
            if (rcard3 == 8)
            {
                PlayerPrefs.SetFloat("TripleTake" + LastWin.ToString(), int.Parse("8" + LastWin.ToString()));
                PlayerPrefs.SetFloat("HMR" + "TripleTake" + LastWin.ToString(), HMR);
            }
        }
        //PlayerPrefs.SetFloat("BouncySelfForce" + LastWin.ToString(), (float)1.05);
        //card1.transform.GetChild(1).GetComponent<TextMesh>().text = "Basic";
        //card1.transform.GetChild(5).GetComponent<Text>().text = "+10% to repulsions\n+5% to hit you";

        NoSlider = true;
        Time.timeScale = 1;
        newVar.Cards(false);
        Destroy(card1);
        Destroy(card2);
        Destroy(card3);
        timeSlider.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
        Choose1.SetActive(false);
        
        ScoreN1.SetActive(true);
        
        joy1.gameObject.SetActive(true);
        
        if (Choose2 != null)
        {
            Choose2.SetActive(false);
            ScoreN2.SetActive(true);
            joy2.gameObject.SetActive(true);
        }
            if (Choose3 != null)
        {
            Choose3.SetActive(false);
            joy3.gameObject.SetActive(true);
            ScoreN3.SetActive(true);
        }
        if (Choose4 != null)
        {
            Choose4.SetActive(false);
            joy4.gameObject.SetActive(true);
            ScoreN4.SetActive(true);
        }
    }

    void Start()
    {
        LastWin = PlayerPrefs.GetFloat("LastWin");
        if (LastWin > 0)
        {
            newVar = (CirclesMovement)this.GetType().GetField("p" + LastWin.ToString()).GetValue(this);
        }
        SetColors();

        timeSlider.maxValue = timeStart;
        HMRounds = PlayerPrefs.GetFloat("HMRounds");
        RandomLevels = PlayerPrefs.GetFloat("RandomLevels");
        HMRoundsPlayed = PlayerPrefs.GetFloat("HMRoundsPlayed");
        switch (LastWin)
        {
            case 1:
                Choose1.SetActive(true);
                timeColor.color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"));
                break;
            case 2:
                Choose2.SetActive(true);
                timeColor.color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"));
                break;
            case 3:
                Choose3.GetComponent<RectTransform>().rotation = Quaternion.Euler(new Vector3(180, 180, 0));
                card1.GetComponent<RectTransform>().rotation = Quaternion.Euler(new Vector3(180, 180, 0));
                card2.GetComponent<RectTransform>().rotation = Quaternion.Euler(new Vector3(180, 180, 0));
                card3.GetComponent<RectTransform>().rotation = Quaternion.Euler(new Vector3(180, 180, 0));
                timeColor.color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"));
                //card4.GetComponent<RectTransform>().rotation = Quaternion.Euler(new Vector3(180, 180, 0));

                //float y = Choose3.GetComponent<RectTransform>().rotation.y;
                //x = 180;
                //y = 180;
                Choose3.SetActive(true);
                break;
            case 4:
                //float x4 = Choose4.GetComponent<RectTransform>().rotation.x;
                //float y4 = Choose4.GetComponent<RectTransform>().rotation.y;
                //x4 = 180;
                //y4 = 180;
                card1.GetComponent<RectTransform>().rotation = Quaternion.Euler(new Vector3(180, 180, 0));
                card2.GetComponent<RectTransform>().rotation = Quaternion.Euler(new Vector3(180, 180, 0));
                card3.GetComponent<RectTransform>().rotation = Quaternion.Euler(new Vector3(180, 180, 0));
                timeColor.color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"));
                //card4.GetComponent<RectTransform>().rotation = Quaternion.Euler(new Vector3(180, 180, 0));
                Choose4.SetActive(true);
                break;
        }

        if (LastWin > 0)
        {
            rcard1 = Mathf.Round(Random.Range((float)0.6, (float)8.4));
            if (rcard1 == 1)
            {
                rarity1 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Замораживание";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Заморожування";
                }
                else
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Freezing";
                }
                card1.transform.GetChild(2).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Замораживание оппонентов после столкновения с ними";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Заморожування опонентів після зіткнення з ними";
                }
                else
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Freezing opponents after a collision";
                }
                if (rarity1 == 1)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", 1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n-15% к скорости оппонента\n";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n-15% до швидкості опонента";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n-15% Opponent Speed";
                    }
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                }
                else if (rarity1 == 2)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.2);
                    //card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+20% to freezing time";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+20% длительность замораживания\n-20% к скорости оппонента\n";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+20% тривалість заморожування\n-20% до швидкості опонента";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+20% to freezing time\n-20% Opponent Speed";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color(0, 0, 0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity1 == 3)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.4);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+40% длительность замораживания\n-30% к скорости оппонента\n";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+40% тривалість заморожування\n-30% до швидкості опонента";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+40% to freezing time\n-30% Opponent Speed";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity1 == 4)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+50% длительность замораживания\n-40% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+50% тривалість заморожування\n-40% до швидкості опонента";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+50% to freezing time\n-40% Opponent Speed";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity1 == 5)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.6);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+60% длительность замораживания\n-50% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+60% тривалість заморожування\n-50% до швидкості опонента";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+60% to freezing time\n-50% Opponent Speed";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity1 == 6)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)2);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+100% длительность замораживания\n-65% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+100% тривалість заморожування\n-65% до швидкості опонента";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+100% to freezing time\n-65% Opponent Speed";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    //card1.GetComponent<Renderer>().material = text0;
                    //card1.GetComponent<Renderer>().material.SetInt("_UnscaledTime", 1);
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity1 == 7)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)3);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+200% длительность замораживания\n-80% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+200% тривалість заморожування\n-80% до швидкості опонента";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+200% to freezing time\n-80% Opponent Speed";
                    }

                    //card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    //card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.GetComponent<Button>().colors = colors;
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                Freezing = PlayerPrefs.GetFloat("Freezing" + LastWin.ToString()).ToString();
                HMRFreezing = PlayerPrefs.GetFloat("HMRFreezing" + LastWin.ToString());
                if (HMRFreezing <= 0)
                {
                    Freezing = "0";
                }
                if (Freezing == "0")
                {
                    card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity1 > float.Parse(Freezing.Remove(0, 2)))
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity1 < float.Parse(Freezing.Remove(0, 2)))
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }

            }
            if (rcard1 == 2)
            {
                rarity1 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Энерджайзер";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Енерджайзер";
                }
                else
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Energizer";
                }
                card1.transform.GetChild(8).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Energizer", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Вы заряжены неизвестной энергией и становитесь быстрее";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Ви заряджені невідомою енергіею і стаєте швидше";
                }
                else
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "You are energized and getting faster";
                }
                if (rarity1 == 1)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+5% к максимальной скорости";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+5% до максимальної швидкості";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+5% to max speed";
                    }
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);


                }
                else if (rarity1 == 2)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.1);
                    //card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к максимальной скорости";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до максимальної швидкості";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to max speed";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity1 == 3)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.1);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к максимальной скорости\n+5% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до максимальної швидкості\n+5% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to max speed\n+5% to acceleration";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity1 == 4)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.15);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к максимальной скорости\n+5% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до максимальної швидкості\n+5% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to max speed\n+5% to acceleration";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity1 == 5)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.20);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% to max speed\n+10% to acceleration";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity1 == 6)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.30);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% к максимальной скорости\n+15% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% до максимальної швидкості\n+15% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% to max speed\n+15% to acceleration";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity1 == 7)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.5);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.25);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к максимальной скорости\n+25% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до максимальної швидкості\n+25% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to max speed\n+25% to acceleration";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.GetComponent<Button>().colors = colors;
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                Energizer = PlayerPrefs.GetFloat("Energizer" + LastWin.ToString()).ToString();
                HMREnergizer = PlayerPrefs.GetFloat("HMREnergizer" + LastWin.ToString());
                if (HMREnergizer <= 0)
                {
                    Energizer = "0";
                }
                if (Energizer == "0")
                {
                    card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity1 > float.Parse(Energizer.Remove(0, 2)))
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity1 < float.Parse(Energizer.Remove(0, 2)))
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard1 == 3)
            {
                rarity1 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Попрыгунчик";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Пострибунчик";
                }
                else
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Bouncy";
                }
                card1.transform.GetChild(12).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Отталкивание игроков становяться сильнее";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Відштовхування гравців стає сильнішим";
                }
                else
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Repulsions from circles are stronger";
                }
                if (rarity1 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к отталкиванием\n+5% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до відштовхування\n+5% до відштовхуванням по вам";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to repulsions\n+5% to hit you";
                    }
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (rarity1 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к отталкиванием\n+7% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до відштовхування\n+7% до відштовхуванням по вам";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to repulsions\n+7% to hit you";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity1 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% к отталкиванием\n+10% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% до відштовхування\n+10% до відштовхуванням по вам";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% to repulsions\n+10% to hit you";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity1 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% к отталкиванием\n+17% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% до відштовхування\n+17% до відштовхуванням по вам";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% to repulsions\n+17% to hit you";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity1 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к отталкиванием\n+25% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до відштовхування\n+25% до відштовхуванням по вам";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to repulsions\n+25% to hit you";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity1 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% к отталкиванием\n+30% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% до відштовхування\n+30% до відштовхуванням по вам";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% to repulsions\n+30% to hit you";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity1 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к отталкиванием\n+40% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до відштовхування\n+40% до відштовхуванням по вам";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to repulsions\n+40% to hit you";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.GetComponent<Button>().colors = colors;
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                Bouncy = PlayerPrefs.GetFloat("Bouncy" + LastWin.ToString()).ToString();
                HMRBouncy = PlayerPrefs.GetFloat("HMRBouncy" + LastWin.ToString());
                if (HMRBouncy <= 0)
                {
                    Bouncy = "0";
                }
                if (Bouncy == "0")
                {
                    card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity1 > float.Parse(Bouncy.Remove(0, 2)))
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity1 < float.Parse(Bouncy.Remove(0, 2)))
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard1 == 4)
            {
                var colors = card1.GetComponent<Button>().colors;
                colors.normalColor = new Color((float)0.588, (float)0.82, (float)215);
                card1.GetComponent<Button>().colors = colors;
                //rarity2 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Друг стекла";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Друг скла";
                }
                else
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Friend of glass";
                }
                card1.transform.GetChild(10).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Вы больше не получаете отталкиваний от стекла на всю игру";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Ви більше не отримуєте відштовхувань від скла на всю гру";
                }
                else
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "You no longer get repulsion from glass walls for all game";
                }
                //////PlayerPrefs.SetFloat("FreezingTime", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Уникальная";
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "-100% к отталкиваниям от стекла";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Унікальна";
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "-100% до відштовхувань від скла";
                }
                else
                {
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Unique";
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "-100% to repulsion from glass walls";
                }
                //card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                FriendOfGlass = PlayerPrefs.GetFloat("Friend of Glass" + LastWin.ToString());
                if (FriendOfGlass == 0)
                {
                    card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            if (rcard1 == 5)
            {
                rarity1 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Осмотрись";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Оглянься";
                }
                else
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Look around";
                }
                card1.transform.GetChild(11).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Неуязвимость к отталкиванием от игроков, и на много больше скорости, в начале раунда";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Невразливість до відштовхування від гравців, і набагато більше швидкості, на початку раунду";
                }
                else
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Invulnerability to pushback from players, and much more speed at the beginning of the round";
                }
                if (rarity1 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to max speed\n+10% acceleration";
                    }
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (rarity1 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к времени неуязвимости\n+10% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до часу невразливості\n+10% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to time of invulnerability\n+10% to max speed\n+10% acceleration";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity1 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к времени неуязвимости\n+15% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до часу невразливості\n+15% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to time of invulnerability\n+15% to max speed\n+10% acceleration";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity1 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% к времени неуязвимости\n+35% к максимальной скорости\n+35% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% до часу невразливості\n+35% до максимальної швидкості\n+35% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% to time of invulnerability\n+35% to max speed\n+35% acceleration";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);

                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);

                }
                else if (rarity1 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% к времени неуязвимости\n+40% к максимальной скорости\n+40% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% до часу невразливості\n+40% до максимальної швидкості\n+40% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% to time of invulnerability\n+40% to max speed\n+40% acceleration";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity1 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+40% к времени неуязвимости\n+60% к максимальной скорости\n+60% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+40% до часу невразливості\n+60% до максимальної швидкості\n+60% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+40% to time of invulnerability\n+60% to max speed\n+60% acceleration";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);

                }
                else if (rarity1 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к времени неуязвимости\n+100% к максимальной скорости\n+100% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до часу невразливості\n+100% до максимальної швидкості\n+100% до прискорення";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to time of invulnerability\n+100% to max speed\n+100% acceleration";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.GetComponent<Button>().colors = colors;
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }

                Takealookaround = PlayerPrefs.GetFloat("Take a look around" + LastWin.ToString()).ToString();
                HMRTakealookaround = PlayerPrefs.GetFloat("HMRLook around" + LastWin.ToString());
                if (HMRTakealookaround <= 0)
                {
                    Takealookaround = "0";
                }
                if (Takealookaround == "0")
                {
                    card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity1 > float.Parse(Takealookaround.Remove(0, 2)))
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity1 < float.Parse(Takealookaround.Remove(0, 2)))
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard1 == 6)
            {
                rarity1 = Mathf.Round(Random.Range(1, (float)7.2));

                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Копилка";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Скарбничка";
                }
                else
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "The Money Box";
                }
                card1.transform.GetChild(9).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Больше кристаллов в конце игры. Эта карта не складывается с другими игроками. Применяется карта с лучшей редкостью.";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Більше кристалів наприкінці гри. Ця картка не складається з іншими гравцями. Застосовується карта з найкращою рідкістю.";
                }
                else
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "More crystals at the end of the game. This card does not stack with other players. The card with the best rarity applies";
                }
                if (rarity1 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до кристалів";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to time of invulnerability\n+100% to max speed\n+100% acceleration";
                    }
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (rarity1 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+14% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+14% до кристалів";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+14% to crystals";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);

                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity1 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+18% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+18% до кристалів";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+18% to crystals";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);

                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity1 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+25% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+25% до кристалів";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+25% to crystals";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);

                }
                else if (rarity1 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% до кристалів";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% to crystals";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity1 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до кристалів";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to crystals";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity1 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to crystals";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до кристалів";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to crystals";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.GetComponent<Button>().colors = colors;
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                MoneyBox = PlayerPrefs.GetFloat("The Money Box Rarity");
                if (MoneyBox == 0)
                {
                    card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity1 > MoneyBox)
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity1 < MoneyBox)
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }

            }
            //rcard1 = Mathf.Round(Random.Range((float)0.6, (float)7.4));
            if (rcard1 == 7)
            {
                //rarity1 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Скорость волны";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Швидкість хвилі";
                }
                else
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Wave speed";
                }
                //card1.transform.GetChild(2).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Прибавка к скорости волны";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Підвищення швидкості хвилі";
                }
                else
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Wave speed boost";
                }
                if (rarity1 == 1)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", 1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к скорости волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до швидкості хвилі";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to wave speed";
                    }
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                }
                else if (rarity1 == 2)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.2);
                    //card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                    //card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+20% to freezing time";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к скорости волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до швидкості хвилі";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to wave speed";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color(0, 0, 0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity1 == 3)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.4);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% к скорости волны\n-10% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% до швидкості хвилі\n-10% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% to wave speed\n-10% to the speed of wave increase";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity1 == 4)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% к скорости волны\n-20% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% до швидкості хвилі\n-20% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% to wave speed\n-20% to the speed of wave increase";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity1 == 5)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.6);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к скорости волны\n-40% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до швидкості хвилі\n-40% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to wave speed\n-40% to the speed of wave increase";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity1 == 6)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)2);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% к скорости волны\n-60% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% до швидкості хвилі\n-60% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% to wave speed\n-60% to the speed of wave increase";
                    }
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card1.GetComponent<Button>().colors = colors;
                    //card1.GetComponent<Renderer>().material = text0;
                    //card1.GetComponent<Renderer>().material.SetInt("_UnscaledTime", 1);
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity1 == 7)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)3);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к скорости волны\n-50% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до швидкості хвилі\n-50% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to wave speed\n-50% to the speed of wave increase";
                    }

                    //card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    //card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card1.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card1.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.GetComponent<Button>().colors = colors;
                    card1.GetComponent<Image>().material = text0;
                    card1.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                WaveSpeed = PlayerPrefs.GetFloat("WaveSpeed" + LastWin.ToString()).ToString();
                HMRWaveSpeed = PlayerPrefs.GetFloat("HMRWaveSpeed" + LastWin.ToString());
                if (HMRWaveSpeed <= 0)
                {
                    WaveSpeed = "0";
                }
                if (WaveSpeed == "0")
                {
                    card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity1 > float.Parse(WaveSpeed.Remove(0, 2)))
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity1 < float.Parse(WaveSpeed.Remove(0, 2)))
                    {
                        card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard1 == 8)
            {
                //rarity2 = Mathf.Round(Random.Range(1, (float)7.2));
                var colors = card1.GetComponent<Button>().colors;
                colors.normalColor = new Color((float)0.588, (float)0.82, (float)215);
                card1.GetComponent<Button>().colors = colors;
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Тройной еффект";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Потрійний ефект";
                }
                else
                {
                    card1.transform.GetChild(0).GetComponent<TMP_Text>().text = "Triple take";
                }
                //card1.transform.GetChild(10).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Вы выпускаете три волны вместо одной";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "Ви випускаєте три хвилі замість однієї";
                }
                else
                {
                    card1.transform.GetChild(3).GetComponent<TMP_Text>().text = "You release three waves instead of one";
                }
                //////PlayerPrefs.SetFloat("FreezingTime", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Уникальная";
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "-1000% к скорости увеличения волны";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Унікальна";
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "-1000% до швидкості збільшення хвилі";
                }
                else
                {
                    card1.transform.GetChild(1).GetComponent<TMP_Text>().text = "Unique";
                    card1.transform.GetChild(5).GetComponent<TMP_Text>().text = "-1000% to wave growth speed";
                }
                //card1.transform.GetChild(card1.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                TripleTake = PlayerPrefs.GetFloat("TripleTake" + LastWin.ToString());
                if (TripleTake == 0)
                {
                    card1.transform.GetChild(card1.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            rcard2 = Mathf.Round(Random.Range((float)0.6, (float)8.4));
            while (rcard2 == rcard1)
            {
                rcard2 = Mathf.Round(Random.Range((float)0.6, (float)8.4));
            }
            //rcard1 = Mathf.Round(Random.Range((float)0.6, (float)6.4));
            if (rcard2 == 1)
            {
                rarity2 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Замораживание";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Заморожування";
                }
                else
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Freezing";
                }
                card2.transform.GetChild(2).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Замораживание оппонентов после столкновения с ними";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Заморожування опонентів після зіткнення з ними";
                }
                else
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Freezing opponents after a collision";
                }
                if (rarity2 == 1)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", 1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n-15% к скорости оппонента\n";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n-15% до швидкості опонента";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n-15% Opponent Speed";
                    }
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                }
                else if (rarity2 == 2)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.2);
                    //card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                    //card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+20% to freezing time";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+20% длительность замораживания\n-20% к скорости оппонента\n";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+20% тривалість заморожування\n-20% до швидкості опонента";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+20% to freezing time\n-20% Opponent Speed";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color(0, 0, 0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity2 == 3)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.4);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+40% длительность замораживания\n-30% к скорости оппонента\n";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+40% тривалість заморожування\n-30% до швидкості опонента";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+40% to freezing time\n-30% Opponent Speed";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity2 == 4)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+50% длительность замораживания\n-40% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+50% тривалість заморожування\n-40% до швидкості опонента";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+50% to freezing time\n-40% Opponent Speed";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity2 == 5)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.6);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+60% длительность замораживания\n-50% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+60% тривалість заморожування\n-50% до швидкості опонента";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+60% to freezing time\n-50% Opponent Speed";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity2 == 6)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)2);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+100% длительность замораживания\n-65% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+100% тривалість заморожування\n-65% до швидкості опонента";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+100% to freezing time\n-65% Opponent Speed";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    //card2.GetComponent<Renderer>().material = text0;
                    //card2.GetComponent<Renderer>().material.SetInt("_UnscaledTime", 1);
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity2 == 7)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)3);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+200% длительность замораживания\n-80% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+200% тривалість заморожування\n-80% до швидкості опонента";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+200% to freezing time\n-80% Opponent Speed";
                    }

                    //card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    //card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.GetComponent<Button>().colors = colors;
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                Freezing = PlayerPrefs.GetFloat("Freezing" + LastWin.ToString()).ToString();
                HMRFreezing = PlayerPrefs.GetFloat("HMRFreezing" + LastWin.ToString());
                if (HMRFreezing <= 0)
                {
                    Freezing = "0";
                }
                if (Freezing == "0")
                {
                    card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity2 > float.Parse(Freezing.Remove(0, 2)))
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity2 < float.Parse(Freezing.Remove(0, 2)))
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }

            }
            if (rcard2 == 2)
            {
                rarity2 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Энерджайзер";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Енерджайзер";
                }
                else
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Energizer";
                }
                card2.transform.GetChild(8).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Energizer", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Вы заряжены неизвестной энергией и становитесь быстрее";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Ви заряджені невідомою енергіею і стаєте швидше";
                }
                else
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "You are energized and getting faster";
                }
                if (rarity2 == 1)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+5% к максимальной скорости";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+5% до максимальної швидкості";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+5% to max speed";
                    }
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);


                }
                else if (rarity2 == 2)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.1);
                    //card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к максимальной скорости";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до максимальної швидкості";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to max speed";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity2 == 3)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.1);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к максимальной скорости\n+5% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до максимальної швидкості\n+5% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to max speed\n+5% to acceleration";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity2 == 4)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.15);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к максимальной скорости\n+5% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до максимальної швидкості\n+5% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to max speed\n+5% to acceleration";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity2 == 5)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.20);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% to max speed\n+10% to acceleration";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity2 == 6)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.30);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% к максимальной скорости\n+15% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% до максимальної швидкості\n+15% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% to max speed\n+15% to acceleration";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity2 == 7)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.5);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.25);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к максимальной скорости\n+25% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до максимальної швидкості\n+25% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to max speed\n+25% to acceleration";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.GetComponent<Button>().colors = colors;
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                Energizer = PlayerPrefs.GetFloat("Energizer" + LastWin.ToString()).ToString();
                HMREnergizer = PlayerPrefs.GetFloat("HMREnergizer" + LastWin.ToString());
                if (HMREnergizer <= 0)
                {
                    Energizer = "0";
                }
                if (Energizer == "0")
                {
                    card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity2 > float.Parse(Energizer.Remove(0, 2)))
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity2 < float.Parse(Energizer.Remove(0, 2)))
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard2 == 3)
            {
                rarity2 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Попрыгунчик";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Пострибунчик";
                }
                else
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Bouncy";
                }
                card2.transform.GetChild(12).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Отталкивание игроков становяться сильнее";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Відштовхування гравців стає сильнішим";
                }
                else
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Repulsions from circles are stronger";
                }
                if (rarity2 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к отталкиванием\n+5% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до відштовхування\n+5% до відштовхуванням по вам";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to repulsions\n+5% to hit you";
                    }
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (rarity2 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к отталкиванием\n+7% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до відштовхування\n+7% до відштовхуванням по вам";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to repulsions\n+7% to hit you";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity2 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% к отталкиванием\n+10% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% до відштовхування\n+10% до відштовхуванням по вам";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% to repulsions\n+10% to hit you";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity2 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% к отталкиванием\n+17% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% до відштовхування\n+17% до відштовхуванням по вам";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% to repulsions\n+17% to hit you";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity2 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к отталкиванием\n+25% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до відштовхування\n+25% до відштовхуванням по вам";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to repulsions\n+25% to hit you";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity2 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% к отталкиванием\n+30% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% до відштовхування\n+30% до відштовхуванням по вам";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% to repulsions\n+30% to hit you";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity2 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к отталкиванием\n+40% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до відштовхування\n+40% до відштовхуванням по вам";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to repulsions\n+40% to hit you";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.GetComponent<Button>().colors = colors;
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                Bouncy = PlayerPrefs.GetFloat("Bouncy" + LastWin.ToString()).ToString();
                HMRBouncy = PlayerPrefs.GetFloat("HMRBouncy" + LastWin.ToString());
                if (HMRBouncy <= 0)
                {
                    Bouncy = "0";
                }
                if (Bouncy == "0")
                {
                    card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity2 > float.Parse(Bouncy.Remove(0, 2)))
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity2 < float.Parse(Bouncy.Remove(0, 2)))
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard2 == 4)
            {
                var colors = card2.GetComponent<Button>().colors;
                colors.normalColor = new Color((float)0.588, (float)0.82, (float)215);
                card2.GetComponent<Button>().colors = colors;
                //rarity2 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Друг стекла";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Друг скла";
                }
                else
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Friend of glass";
                }
                card2.transform.GetChild(10).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Вы больше не получаете отталкиваний от стекла на всю игру";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Ви більше не отримуєте відштовхувань від скла на всю гру";
                }
                else
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "You no longer get repulsion from glass walls for all game";
                }
                //////PlayerPrefs.SetFloat("FreezingTime", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Уникальная";
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "-100% к отталкиваниям от стекла";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Унікальна";
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "-100% до відштовхувань від скла";
                }
                else
                {
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Unique";
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "-100% to repulsion from glass walls";
                }
                //card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                FriendOfGlass = PlayerPrefs.GetFloat("Friend of Glass" + LastWin.ToString());
                if (FriendOfGlass == 0)
                {
                    card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            if (rcard2 == 5)
            {
                rarity2 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Осмотрись";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Оглянься";
                }
                else
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Look around";
                }
                card2.transform.GetChild(11).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Неуязвимость к отталкиванием от игроков, и на много больше скорости, в начале раунда";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Невразливість до відштовхування від гравців, і набагато більше швидкості, на початку раунду";
                }
                else
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Invulnerability to pushback from players, and much more speed at the beginning of the round";
                }
                if (rarity2 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to max speed\n+10% acceleration";
                    }
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (rarity2 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к времени неуязвимости\n+10% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до часу невразливості\n+10% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to time of invulnerability\n+10% to max speed\n+10% acceleration";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity2 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к времени неуязвимости\n+15% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до часу невразливості\n+15% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to time of invulnerability\n+15% to max speed\n+10% acceleration";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity2 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% к времени неуязвимости\n+35% к максимальной скорости\n+35% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% до часу невразливості\n+35% до максимальної швидкості\n+35% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% to time of invulnerability\n+35% to max speed\n+35% acceleration";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);

                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);

                }
                else if (rarity2 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% к времени неуязвимости\n+40% к максимальной скорости\n+40% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% до часу невразливості\n+40% до максимальної швидкості\n+40% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% to time of invulnerability\n+40% to max speed\n+40% acceleration";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity2 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+40% к времени неуязвимости\n+60% к максимальной скорости\n+60% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+40% до часу невразливості\n+60% до максимальної швидкості\n+60% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+40% to time of invulnerability\n+60% to max speed\n+60% acceleration";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);

                }
                else if (rarity2 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к времени неуязвимости\n+100% к максимальной скорости\n+100% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до часу невразливості\n+100% до максимальної швидкості\n+100% до прискорення";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to time of invulnerability\n+100% to max speed\n+100% acceleration";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.GetComponent<Button>().colors = colors;
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }

                Takealookaround = PlayerPrefs.GetFloat("Take a look around" + LastWin.ToString()).ToString();
                HMRTakealookaround = PlayerPrefs.GetFloat("HMRLook around" + LastWin.ToString());
                if (HMRTakealookaround <= 0)
                {
                    Takealookaround = "0";
                }
                if (Takealookaround == "0")
                {
                    card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity2 > float.Parse(Takealookaround.Remove(0, 2)))
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity2 < float.Parse(Takealookaround.Remove(0, 2)))
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard2 == 6)
            {
                rarity2 = Mathf.Round(Random.Range(1, (float)7.2));

                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Копилка";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Скарбничка";
                }
                else
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "The Money Box";
                }
                card2.transform.GetChild(9).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Больше кристаллов в конце игры. Эта карта не складывается с другими игроками. Применяется карта с лучшей редкостью.";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Більше кристалів наприкінці гри. Ця картка не складається з іншими гравцями. Застосовується карта з найкращою рідкістю.";
                }
                else
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "More crystals at the end of the game. This card does not stack with other players. The card with the best rarity applies";
                }
                if (rarity2 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до кристалів";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to time of invulnerability\n+100% to max speed\n+100% acceleration";
                    }
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (rarity2 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+14% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+14% до кристалів";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+14% to crystals";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);

                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity2 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+18% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+18% до кристалів";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+18% to crystals";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);

                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity2 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+25% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+25% до кристалів";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+25% to crystals";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);

                }
                else if (rarity2 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% до кристалів";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% to crystals";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity2 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до кристалів";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to crystals";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity2 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to crystals";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до кристалів";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to crystals";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.GetComponent<Button>().colors = colors;
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                MoneyBox = PlayerPrefs.GetFloat("The Money Box Rarity");
                if (MoneyBox == 0)
                {
                    card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity2 > MoneyBox)
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity2 < MoneyBox)
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard2 == 7)
            {
                //rarity2 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Скорость волны";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Швидкість хвилі";
                }
                else
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Wave speed";
                }
                //card2.transform.GetChild(2).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Прибавка к скорости волны";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Підвищення швидкості хвилі";
                }
                else
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Wave speed boost";
                }
                if (rarity2 == 1)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", 1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к скорости волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до швидкості хвилі";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to wave speed";
                    }
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                }
                else if (rarity2 == 2)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.2);
                    //card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                    //card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+20% to freezing time";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к скорости волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до швидкості хвилі";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to wave speed";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color(0, 0, 0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity2 == 3)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.4);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% к скорости волны\n-10% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% до швидкості хвилі\n-10% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% to wave speed\n-10% to the speed of wave increase";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity2 == 4)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% к скорости волны\n-20% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% до швидкості хвилі\n-20% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% to wave speed\n-20% to the speed of wave increase";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity2 == 5)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.6);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к скорости волны\n-40% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до швидкості хвилі\n-40% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to wave speed\n-40% to the speed of wave increase";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity2 == 6)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)2);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% к скорости волны\n-60% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% до швидкості хвилі\n-60% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% to wave speed\n-60% to the speed of wave increase";
                    }
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card2.GetComponent<Button>().colors = colors;
                    //card2.GetComponent<Renderer>().material = text0;
                    //card2.GetComponent<Renderer>().material.SetInt("_UnscaledTime", 1);
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity2 == 7)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)3);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к скорости волны\n-50% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до швидкості хвилі\n-50% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to wave speed\n-50% to the speed of wave increase";
                    }

                    //card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    //card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card2.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card2.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.GetComponent<Button>().colors = colors;
                    card2.GetComponent<Image>().material = text0;
                    card2.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                WaveSpeed = PlayerPrefs.GetFloat("WaveSpeed" + LastWin.ToString()).ToString();
                HMRWaveSpeed = PlayerPrefs.GetFloat("HMRWaveSpeed" + LastWin.ToString());
                if (HMRWaveSpeed <= 0)
                {
                    WaveSpeed = "0";
                }
                if (WaveSpeed == "0")
                {
                    card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity2 > float.Parse(WaveSpeed.Remove(0, 2)))
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity2 < float.Parse(WaveSpeed.Remove(0, 2)))
                    {
                        card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard2 == 8)
            {
                var colors = card2.GetComponent<Button>().colors;
                colors.normalColor = new Color((float)0.588, (float)0.82, (float)215);
                card2.GetComponent<Button>().colors = colors;
                //rarity2 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Тройной еффект";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Потрійний ефект";
                }
                else
                {
                    card2.transform.GetChild(0).GetComponent<TMP_Text>().text = "Triple take";
                }
                //card2.transform.GetChild(10).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Вы выпускаете три волны вместо одной";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "Ви випускаєте три хвилі замість однієї";
                }
                else
                {
                    card2.transform.GetChild(3).GetComponent<TMP_Text>().text = "You release three waves instead of one";
                }
                //////PlayerPrefs.SetFloat("FreezingTime", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Уникальная";
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "-1000% к скорости увеличения волны";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Унікальна";
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "-1000% до швидкості збільшення хвилі";
                }
                else
                {
                    card2.transform.GetChild(1).GetComponent<TMP_Text>().text = "Unique";
                    card2.transform.GetChild(5).GetComponent<TMP_Text>().text = "-1000% to wave growth speed";
                }
                //card2.transform.GetChild(card2.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                TripleTake = PlayerPrefs.GetFloat("TripleTake" + LastWin.ToString());
                if (TripleTake == 0)
                {
                    card2.transform.GetChild(card2.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            rcard3 = Mathf.Round(Random.Range((float)0.6, (float)8.4));
            while (rcard3 == rcard1 || rcard3 == rcard2)
            {
                rcard3 = Mathf.Round(Random.Range((float)0.6, (float)8.4));
            }
            if (rcard3 == 1)
            {
                rarity3 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Замораживание";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Заморожування";
                }
                else
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Freezing";
                }
                card3.transform.GetChild(2).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Замораживание оппонентов после столкновения с ними";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Заморожування опонентів після зіткнення з ними";
                }
                else
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Freezing opponents after a collision";
                }
                if (rarity3 == 1)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", 1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n-15% к скорости оппонента\n";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n-15% до швидкості опонента";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n-15% Opponent Speed";
                    }
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                }
                else if (rarity3 == 2)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.2);
                    //card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                    //card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+20% to freezing time";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+20% длительность замораживания\n-20% к скорости оппонента\n";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+20% тривалість заморожування\n-20% до швидкості опонента";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+20% to freezing time\n-20% Opponent Speed";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color(0, 0, 0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity3 == 3)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.4);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+40% длительность замораживания\n-30% к скорости оппонента\n";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+40% тривалість заморожування\n-30% до швидкості опонента";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+40% to freezing time\n-30% Opponent Speed";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity3 == 4)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+50% длительность замораживания\n-40% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+50% тривалість заморожування\n-40% до швидкості опонента";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+50% to freezing time\n-40% Opponent Speed";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity3 == 5)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.6);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+60% длительность замораживания\n-50% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+60% тривалість заморожування\n-50% до швидкості опонента";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+60% to freezing time\n-50% Opponent Speed";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity3 == 6)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)2);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+100% длительность замораживания\n-65% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+100% тривалість заморожування\n-65% до швидкості опонента";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+100% to freezing time\n-65% Opponent Speed";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    //card3.GetComponent<Renderer>().material = text0;
                    //card3.GetComponent<Renderer>().material.SetInt("_UnscaledTime", 1);
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity3 == 7)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)3);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к замораживанию\n+200% длительность замораживания\n-80% к скорости оппонента";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до заморожування\n+200% тривалість заморожування\n-80% до швидкості опонента";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+200% to freezing time\n-80% Opponent Speed";
                    }

                    //card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    //card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.GetComponent<Button>().colors = colors;
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                Freezing = PlayerPrefs.GetFloat("Freezing" + LastWin.ToString()).ToString();
                HMRFreezing = PlayerPrefs.GetFloat("HMRFreezing" + LastWin.ToString());
                if (HMRFreezing <= 0)
                {
                    Freezing = "0";
                }
                if (Freezing == "0")
                {
                    card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity3 > float.Parse(Freezing.Remove(0, 2)))
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity3 < float.Parse(Freezing.Remove(0, 2)))
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }

            }
            if (rcard3 == 2)
            {
                rarity3 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Энерджайзер";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Енерджайзер";
                }
                else
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Energizer";
                }
                card3.transform.GetChild(8).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Energizer", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Вы заряжены неизвестной энергией и становитесь быстрее";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Ви заряджені невідомою енергіею і стаєте швидше";
                }
                else
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "You are energized and getting faster";
                }
                if (rarity3 == 1)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+5% к максимальной скорости";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+5% до максимальної швидкості";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+5% to max speed";
                    }
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);


                }
                else if (rarity3 == 2)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.1);
                    //card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к максимальной скорости";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до максимальної швидкості";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to max speed";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity3 == 3)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.1);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к максимальной скорости\n+5% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до максимальної швидкості\n+5% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to max speed\n+5% to acceleration";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity3 == 4)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.15);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к максимальной скорости\n+5% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до максимальної швидкості\n+5% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to max speed\n+5% to acceleration";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity3 == 5)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.20);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% to max speed\n+10% to acceleration";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity3 == 6)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.30);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% к максимальной скорости\n+15% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% до максимальної швидкості\n+15% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% to max speed\n+15% to acceleration";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity3 == 7)
                {
                    //////PlayerPrefs.SetFloat("MaxSpeed", (float)1.5);
                    //////PlayerPrefs.SetFloat("Acceleration", (float)1.25);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к максимальной скорости\n+25% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до максимальної швидкості\n+25% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to max speed\n+25% to acceleration";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.GetComponent<Button>().colors = colors;
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                Energizer = PlayerPrefs.GetFloat("Energizer" + LastWin.ToString()).ToString();
                HMREnergizer = PlayerPrefs.GetFloat("HMREnergizer" + LastWin.ToString());
                if (HMREnergizer <= 0)
                {
                    Energizer = "0";
                }
                if (Energizer == "0")
                {
                    card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity3 > float.Parse(Energizer.Remove(0, 2)))
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity3 < float.Parse(Energizer.Remove(0, 2)))
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard3 == 3)
            {
                rarity3 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Попрыгунчик";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Пострибунчик";
                }
                else
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Bouncy";
                }
                card3.transform.GetChild(12).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Отталкивание игроков становяться сильнее";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Відштовхування гравців стає сильнішим";
                }
                else
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Repulsions from circles are stronger";
                }
                if (rarity3 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к отталкиванием\n+5% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до відштовхування\n+5% до відштовхуванням по вам";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to repulsions\n+5% to hit you";
                    }
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (rarity3 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к отталкиванием\n+7% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до відштовхування\n+7% до відштовхуванням по вам";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to repulsions\n+7% to hit you";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity3 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% к отталкиванием\n+10% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% до відштовхування\n+10% до відштовхуванням по вам";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% to repulsions\n+10% to hit you";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity3 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% к отталкиванием\n+17% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% до відштовхування\n+17% до відштовхуванням по вам";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% to repulsions\n+17% to hit you";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity3 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к отталкиванием\n+25% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до відштовхування\n+25% до відштовхуванням по вам";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to repulsions\n+25% to hit you";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity3 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% к отталкиванием\n+30% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% до відштовхування\n+30% до відштовхуванням по вам";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% to repulsions\n+30% to hit you";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity3 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к отталкиванием\n+40% к отталкиванием по вам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до відштовхування\n+40% до відштовхуванням по вам";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to repulsions\n+40% to hit you";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.GetComponent<Button>().colors = colors;
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                Bouncy = PlayerPrefs.GetFloat("Bouncy" + LastWin.ToString()).ToString();
                HMRBouncy = PlayerPrefs.GetFloat("HMRBouncy" + LastWin.ToString());
                if (HMRBouncy <= 0)
                {
                    Bouncy = "0";
                }
                if (Bouncy == "0")
                {
                    card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity3 > float.Parse(Bouncy.Remove(0, 2)))
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity3 < float.Parse(Bouncy.Remove(0, 2)))
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard3 == 4)
            {
                var colors = card3.GetComponent<Button>().colors;
                colors.normalColor = new Color((float)0.588, (float)0.82, (float)215);
                card3.GetComponent<Button>().colors = colors;
                //rarity3 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Друг стекла";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Друг скла";
                }
                else
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Friend of glass";
                }
                card3.transform.GetChild(10).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Вы больше не получаете отталкиваний от стекла на всю игру";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Ви більше не отримуєте відштовхувань від скла на всю гру";
                }
                else
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "You no longer get repulsion from glass walls for all game";
                }
                //////PlayerPrefs.SetFloat("FreezingTime", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Уникальная";
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "-100% к отталкиваниям от стекла";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Унікальна";
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "-100% до відштовхувань від скла";
                }
                else
                {
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Unique";
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "-100% to repulsion from glass walls";
                }
                //card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                FriendOfGlass = PlayerPrefs.GetFloat("Friend of Glass" + LastWin.ToString());
                if (FriendOfGlass == 0)
                {
                    card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
            }
            if (rcard3 == 5)
            {
                rarity3 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Осмотрись";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Оглянься";
                }
                else
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Look around";
                }
                card3.transform.GetChild(11).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Неуязвимость к отталкиванием от игроков, и на много больше скорости, в начале раунда";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Невразливість до відштовхування від гравців, і набагато більше швидкості, на початку раунду";
                }
                else
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Invulnerability to pushback from players, and much more speed at the beginning of the round";
                }
                if (rarity3 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to max speed\n+10% acceleration";
                    }
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (rarity3 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к времени неуязвимости\n+10% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до часу невразливості\n+10% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to time of invulnerability\n+10% to max speed\n+10% acceleration";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity3 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к времени неуязвимости\n+15% к максимальной скорости\n+10% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до часу невразливості\n+15% до максимальної швидкості\n+10% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to time of invulnerability\n+15% to max speed\n+10% acceleration";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity3 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% к времени неуязвимости\n+35% к максимальной скорости\n+35% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% до часу невразливості\n+35% до максимальної швидкості\n+35% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% to time of invulnerability\n+35% to max speed\n+35% acceleration";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);

                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);

                }
                else if (rarity3 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% к времени неуязвимости\n+40% к максимальной скорости\n+40% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% до часу невразливості\n+40% до максимальної швидкості\n+40% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% to time of invulnerability\n+40% to max speed\n+40% acceleration";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity3 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+40% к времени неуязвимости\n+60% к максимальной скорости\n+60% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+40% до часу невразливості\n+60% до максимальної швидкості\n+60% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+40% to time of invulnerability\n+60% to max speed\n+60% acceleration";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);

                }
                else if (rarity3 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к времени неуязвимости\n+100% к максимальной скорости\n+100% к ускорению";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до часу невразливості\n+100% до максимальної швидкості\n+100% до прискорення";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to time of invulnerability\n+100% to max speed\n+100% acceleration";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.GetComponent<Button>().colors = colors;
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }

                Takealookaround = PlayerPrefs.GetFloat("Take a look around" + LastWin.ToString()).ToString();
                HMRTakealookaround = PlayerPrefs.GetFloat("HMRLook around" + LastWin.ToString());
                if (HMRTakealookaround <= 0)
                {
                    Takealookaround = "0";
                }
                if (Takealookaround == "0")
                {
                    card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity3 > float.Parse(Takealookaround.Remove(0, 2)))
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity3 < float.Parse(Takealookaround.Remove(0, 2)))
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard3 == 6)
            {
                rarity3 = Mathf.Round(Random.Range(1, (float)7.2));

                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Копилка";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Скарбничка";
                }
                else
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "The Money Box";
                }
                card3.transform.GetChild(9).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Bouncy", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Больше кристаллов в конце игры. Эта карта не складывается с другими игроками. Применяется карта с лучшей редкостью.";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Більше кристалів наприкінці гри. Ця картка не складається з іншими гравцями. Застосовується карта з найкращою рідкістю.";
                }
                else
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "More crystals at the end of the game. This card does not stack with other players. The card with the best rarity applies";
                }
                if (rarity3 == 1)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.05);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до кристалів";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to time of invulnerability\n+100% to max speed\n+100% acceleration";
                    }
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                }
                else if (rarity3 == 2)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+14% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+14% до кристалів";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+14% to crystals";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);

                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity3 == 3)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+18% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+18% до кристалів";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+18% to crystals";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);

                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity3 == 4)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.15);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+25% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+25% до кристалів";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+25% to crystals";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);

                }
                else if (rarity3 == 5)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.20);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% до кристалів";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+35% to crystals";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity3 == 6)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.30);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до кристалів";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to crystals";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity3 == 7)
                {
                    //////PlayerPrefs.SetFloat("BouncyForce", (float)1.5);
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to crystals";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к кристаллам";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до кристалів";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to crystals";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.GetComponent<Button>().colors = colors;
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                MoneyBox = PlayerPrefs.GetFloat("The Money Box Rarity");
                if (MoneyBox == 0)
                {
                    card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity3 > MoneyBox)
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity3 < MoneyBox)
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard3 == 7)
            {
                //rarity3 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Скорость волны";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Швидкість хвилі";
                }
                else
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Wave speed";
                }
                //card3.transform.GetChild(2).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Прибавка к скорости волны";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Підвищення швидкості хвилі";
                }
                else
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Wave speed boost";
                }
                if (rarity3 == 1)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", 1);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базовая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% к скорости волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Базова";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% до швидкості хвилі";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Basic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+10% to wave speed";
                    }
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                }
                else if (rarity3 == 2)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.2);
                    //card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                    //card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to freezing\n+20% to freezing time";
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% к скорости волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Стандартна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% до швидкості хвилі";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Standart";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+15% to wave speed";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(0, 0, 0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color(0, 0, 0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0, (float)0.566, (float)0.090);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0, (float)0.566, (float)0.090);
                }
                else if (rarity3 == 3)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.4);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Улучшенная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% к скорости волны\n-10% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Покращена";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% до швидкості хвилі\n-10% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Improved";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+20% to wave speed\n-10% to the speed of wave increase";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.086, (float)0.114, (float)0.471);
                }
                else if (rarity3 == 4)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.5);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Редкая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% к скорости волны\n-20% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Рідкісна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% до швидкості хвилі\n-20% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Rare";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+30% to wave speed\n-20% to the speed of wave increase";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0, (float)0, (float)0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0, (float)0, (float)0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.298, (float)0.243, (float)0.463);
                }
                else if (rarity3 == 5)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)1.6);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% к скорости волны\n-40% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Героїчна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% до швидкості хвилі\n-40% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Heroic";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+50% to wave speed\n-40% to the speed of wave increase";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.933, (float)0.259, (float)0.259);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.784, (float)0.431, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.784, (float)0.431, (float)0);
                }
                else if (rarity3 == 6)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)2);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарная";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% к скорости волны\n-60% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Легендарна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% до швидкості хвилі\n-60% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Legendary";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+70% to wave speed\n-60% to the speed of wave increase";
                    }
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color((float)0.722, (float)0.525, (float)0.043);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)1, (float)0.843, (float)0);
                    card3.GetComponent<Button>().colors = colors;
                    //card3.GetComponent<Renderer>().material = text0;
                    //card3.GetComponent<Renderer>().material.SetInt("_UnscaledTime", 1);
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)1, (float)0.843, (float)0);
                }
                else if (rarity3 == 7)
                {
                    //////PlayerPrefs.SetFloat("FreezingTime", (float)3);
                    if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Мифическая";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% к скорости волны\n-50% к скорости увеличения волны";
                    }
                    else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Міфічна";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% до швидкості хвилі\n-50% до швидкості збільшення хвилі";
                    }
                    else
                    {
                        card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Mythical";
                        card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "+100% to wave speed\n-50% to the speed of wave increase";
                    }

                    //card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    //card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().color = new Color(1, 0, 0);
                    card3.transform.GetChild(4).GetComponent<Text>().color = new Color(1, 0, 0);
                    var colors = card3.GetComponent<Button>().colors;
                    colors.normalColor = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.GetComponent<Button>().colors = colors;
                    card3.GetComponent<Image>().material = text0;
                    card3.GetComponent<Image>().material.SetFloat("_UnscaledTime", 1);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).gameObject.SetActive(true);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(1).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(2).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(3).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(4).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(5).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                    card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(6).GetComponent<SpriteRenderer>().color = new Color((float)0.918, (float)0.329, (float)0.306);
                }
                WaveSpeed = PlayerPrefs.GetFloat("WaveSpeed" + LastWin.ToString()).ToString();
                HMRWaveSpeed = PlayerPrefs.GetFloat("HMRWaveSpeed" + LastWin.ToString());
                if (HMRWaveSpeed <= 0)
                {
                    WaveSpeed = "0";
                }
                if (WaveSpeed == "0")
                {
                    card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
                else
                {
                    if (rarity3 > float.Parse(WaveSpeed.Remove(0, 2)))
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else if (rarity3 < float.Parse(WaveSpeed.Remove(0, 2)))
                    {
                        card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(1).gameObject.SetActive(true);
                    }
                }
            }
            if (rcard3 == 8)
            {
                var colors = card3.GetComponent<Button>().colors;
                colors.normalColor = new Color((float)0.588, (float)0.82, (float)215);
                card3.GetComponent<Button>().colors = colors;
                //rarity2 = Mathf.Round(Random.Range(1, (float)7.2));
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Тройной еффект";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Потрійний ефект";
                }
                else
                {
                    card3.transform.GetChild(0).GetComponent<TMP_Text>().text = "Triple take";
                }
                //card3.transform.GetChild(10).gameObject.SetActive(true);
                //////PlayerPrefs.SetFloat("Freezing", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Вы выпускаете три волны вместо одной";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "Ви випускаєте три хвилі замість однієї";
                }
                else
                {
                    card3.transform.GetChild(3).GetComponent<TMP_Text>().text = "You release three waves instead of one";
                }
                //////PlayerPrefs.SetFloat("FreezingTime", 1);
                if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
                {
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Уникальная";
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "-1000% к скорости увеличения волны";
                }
                else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
                {
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Унікальна";
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "-1000% до швидкості збільшення хвилі";
                }
                else
                {
                    card3.transform.GetChild(1).GetComponent<TMP_Text>().text = "Unique";
                    card3.transform.GetChild(5).GetComponent<TMP_Text>().text = "-1000% to wave growth speed";
                }
                //card3.transform.GetChild(card3.transform.childCount - 1).transform.GetChild(0).gameObject.SetActive(true);

                TripleTake = PlayerPrefs.GetFloat("TripleTake" + LastWin.ToString());
                if (TripleTake == 0)
                {
                    card3.transform.GetChild(card3.transform.childCount - 2).transform.GetChild(0).gameObject.SetActive(true);
                }
            }

        }



            if (LastWin == 0 || SceneManager.GetActiveScene().name == "Finish")
        {
            Destroy(card1);
            Destroy(card2);
            Destroy(card3);
            timeSlider.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
            timeSlider.enabled = false;
            NoSlider = true;
            Choose1.SetActive(false);
            
            ScoreN1.SetActive(true);
            
            joy1.gameObject.SetActive(true);
            if (Choose2 != null)
            {
                joy2.gameObject.SetActive(true);
                ScoreN2.SetActive(true);
                Choose2.SetActive(false);
            }
            if (Choose3 != null)
            {
                Choose3.SetActive(false);
                joy3.gameObject.SetActive(true);
                ScoreN3.SetActive(true);
            }
            if (Choose4 != null)
            {
                Choose4.SetActive(false);
                joy4.gameObject.SetActive(true);
                ScoreN4.SetActive(true);
            }
            //newVar.Cards();
        }
        else if (SceneManager.GetActiveScene().name != "Finish" && SceneManager.GetActiveScene().name != "Menu")
        {
            Time.timeScale = 0;
        }

        if (SceneManager.GetActiveScene().name == "Finish")
        {
            BackButton.SetActive(true);
        }

        //SM = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        level = PlayerPrefs.GetInt("Level");
        while (this.transform.childCount > 1)
        {
            //if(transform.GetChild(0).gameObject.tag != "SecondCamera")
            
            transform.GetChild(1).gameObject.transform.parent = null;
            
        }

        

        if (RandomLevels == 1)
        {
            float oldLevel = level;
            level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
            if (level == oldLevel)
            {
                level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
            }
        }

    }
    void Awake()
    {
        
    }

    void Update()
    {
        if (!NoSlider)
        if (timeStart <= 0)
        {
            //SM.TimerDone = true;
            //timerText.text = "0:00";
            //SecondTimer.text = "0:00";
            Destroy(card1);
            Destroy(card2);
            Destroy(card3);
                timeSlider.enabled = false;
                timeSlider.GetComponent<RectTransform>().localScale = new Vector3(0, 0, 0);
                NoSlider = true;
                newVar.Cards(false);
                Time.timeScale = 1;
                Choose1.SetActive(false);
                
                ScoreN1.SetActive(true);
                
                joy1.gameObject.SetActive(true);
                
                if (Choose2 != null)
                {
                    Choose2.SetActive(false);
                    ScoreN2.SetActive(true);
                    joy2.gameObject.SetActive(true);
                }
                    if (Choose3 != null)
                {
                    Choose3.SetActive(false);
                    joy3.gameObject.SetActive(true);
                    ScoreN3.SetActive(true);
                }
                if (Choose4 != null)
                {
                    Choose4.SetActive(false);
                    joy4.gameObject.SetActive(true);
                    ScoreN4.SetActive(true);
                }

            }
            else
        {
            timeStart -= Time.unscaledDeltaTime;
            timeSlider.value = timeStart;
            //minute = Mathf.FloorToInt(timeStart / 60F);
            //second1 = Mathf.FloorToInt(timeStart - minute * 60);
            //timerText.text = string.Format("{0:0}:{1:00}", minute, second1);
            //SecondTimer.text = string.Format("{0:0}:{1:00}", minute, second1);
        }
    }

    public void LevelEnd(bool skip)
    {
        if (!alreadyLevelEnd || skip == true)
        {
            alreadyLevelEnd = true;

            //foreach (Transform child in GetComponent<Transform>())
            //{
            //    child.parent = null;
            //    // child = null;
            //}
            float SP1 = PlayerPrefs.GetFloat("SP1");
            float SP2 = PlayerPrefs.GetFloat("SP2");
            float SP3 = PlayerPrefs.GetFloat("SP3");
            float SP4 = PlayerPrefs.GetFloat("SP4");
            ScoreN1.GetComponent<Text>().text = SP1.ToString();
            if (ScoreN2 != null)
            {
                ScoreN2.GetComponent<Text>().text = SP2.ToString();
            }
            if (ScoreN3 != null)
            {
                ScoreN3.GetComponent<Text>().text = SP3.ToString();
            }
            if (ScoreN4 != null)
            {
                ScoreN4.GetComponent<Text>().text = SP4.ToString();
            }

            if (skip)
            {
                if (RandomLevels == 1)
                {
                    float oldLevel = level;
                    level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
                    if (level != oldLevel)
                    {
                        SceneManager.LoadScene(level);
                    }
                    else
                    {
                        level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
                        SceneManager.LoadScene(level);
                    }
                }
                else
                {
                    level++;
                    PlayerPrefs.SetInt("Level", level);
                    SceneManager.LoadScene(level);
                }
                //level = PlayerPrefs.GetInt("Level");
                //level++;
                //PlayerPrefs.SetInt("Level", level);
                //SceneManager.LoadScene(level);
            }
            else
            {
                HMRoundsPlayed++;
                PlayerPrefs.SetFloat("HMRoundsPlayed", HMRoundsPlayed);
                if (HMRoundsPlayed >= HMRounds)
                {

                    //lastwin = PlayerPrefs.GetFloat("")
                    HMPlayersF = PlayerPrefs.GetFloat("HMPlayersF");
                    if (HMPlayersF == 0)
                    {
                        HMPlayersF = 2;
                    }
                    switch (HMPlayersF)
                    {
                        case 1:
                            Finish();
                            break;
                        case 2:
                            if (SP1 == SP2)
                            {
                                float oldLevel = level;
                                level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
                                if (level != oldLevel)
                                {
                                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                                }
                                else
                                {
                                    level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
                                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                                }
                            }
                            else
                            {
                                Finish();
                            }
                            break;
                        case 3:
                            if (SP1 == SP2 || SP1 == SP3 || SP2 == SP3)
                            {
                                float oldLevel = level;
                                level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
                                if (level != oldLevel)
                                {
                                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                                }
                                else
                                {
                                    level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
                                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                                }
                            }
                            else
                            {
                                Finish();
                            }
                            break;
                        case 4:
                            if (SP1 == SP2 || SP1 == SP3 || SP1 == SP4 || SP2 == SP3 || SP2 == SP4 || SP3 == SP4)
                            {
                                float oldLevel = level;
                                level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
                                if (level != oldLevel)
                                {
                                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                                }
                                else
                                {
                                    level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
                                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                                }
                            }
                            else
                            {
                                Finish();
                            }
                            break;
                    }


                }
                else
                {
                    if (RandomLevels == 1)
                    {
                        float oldLevel = level;
                        level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
                        if (level != oldLevel)
                        {
                            GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                        }
                        else
                        {
                            level = (int)Mathf.Round(Random.Range(1, SceneManager.sceneCountInBuildSettings - 2));
                            GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                        }
                    }
                    else
                    {
                        level = PlayerPrefs.GetInt("Level");
                        level++;
                        PlayerPrefs.SetInt("Level", level);
                        if (level <= (SceneManager.sceneCountInBuildSettings - 2))
                        {
                            GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                        }
                        else
                        {
                            level = 1;
                            PlayerPrefs.SetInt("Level", level);
                            GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                        }
                    }
                }


            }
        }
    }

    public void AddScoreCircleAnim()
    {
        //////SW.PL1.GetComponent<runtimeAnimatorController> = ???;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(level);
    }

    public void EndAnimation()
    {
        GetComponent<Animator>().runtimeAnimatorController = null;
    }

    public void Finish()
    {
        SceneManager.LoadScene(SceneManager.sceneCountInBuildSettings-1);
    }

    void SetColors()
    {
        if (joy1 != null)
        {
            joy1.GetComponent<UnityEngine.UI.Image>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), (float)0.8);
            joy1.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), (float)0.8);
            Choose1.GetComponent<TMP_Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"));
            ScoreN1.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 135);
        }
        if (joy2 != null)
        {
            joy2.GetComponent<UnityEngine.UI.Image>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), (float)0.8);
            joy2.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), (float)0.8);
            ScoreN2.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 135);
            Choose2.GetComponent<TMP_Text>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"));
        }
        if (joy3 != null)
        {
            joy3.GetComponent<UnityEngine.UI.Image>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), (float)0.8);
            joy3.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), (float)0.8);
            ScoreN3.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
            Choose3.GetComponent<TMP_Text>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"));
        }
        if (joy4 != null)
        {
            joy4.GetComponent<UnityEngine.UI.Image>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), (float)0.8);
            joy4.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), (float)0.8);
            ScoreN4.GetComponent<UnityEngine.UI.Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 135);
            Choose4.GetComponent<TMP_Text>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"));

        }
        
    }

    public void BackButtonOnClick()
    {
        float SP1 = PlayerPrefs.GetFloat("SP1");
        float SP2 = PlayerPrefs.GetFloat("SP2");
        float SP3 = PlayerPrefs.GetFloat("SP3");
        float SP4 = PlayerPrefs.GetFloat("SP4");
        HMPlayersF = PlayerPrefs.GetFloat("HMPlayersF");
        if (HMPlayersF == 0)
        {
            HMPlayersF = 2;
        }
        switch (HMPlayersF)
        {
            case 1:
                //var SM = GameObject.Find("");
                SM.PL2.GetComponent<BotMovement>().Destroy();
                SM.PL3.GetComponent<BotMovement>().Destroy();
                SM.PL4.GetComponent<BotMovement>().Destroy();
                level = 0;
                GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                break;
            case 2:
                if (SP1 > SP2)
                {
                    p2.Destroy();
                    level = 0;
                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;          
                }
                else
                {
                    p1.Destroy();
                    level = 0;
                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                }
                break;
            case 3:
                if (SP1 > SP2 && SP1 > SP3)
                {
                    p2.Destroy();
                    p3.Destroy();
                    level = 0;
                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                }
                else if (SP2 > SP1 && SP2 > SP3)
                {
                    p1.Destroy();
                    p3.Destroy();
                    level = 0;
                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                }
                else if (SP3 > SP1 && SP3 > SP2)
                {
                    p1.Destroy();
                    p2.Destroy();
                    level = 0;
                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                }
                break;
            case 4:
                if (SP1 > SP2 && SP1 > SP3 && SP1 > SP4)
                {
                    p2.Destroy();
                    p3.Destroy();
                    p4.Destroy();
                    level = 0;
                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                }
                else if (SP2 > SP1 && SP2 > SP3 && SP2 > SP4)
                {
                    p1.Destroy();
                    p3.Destroy();
                    p4.Destroy();
                    level = 0;
                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                }
                else if (SP3 > SP1 && SP3 > SP2 && SP3 > SP4)
                {
                    p1.Destroy();
                    p2.Destroy();
                    p4.Destroy();
                    level = 0;
                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                }
                else if (SP4 > SP1 && SP4 > SP2 && SP4 > SP3)
                {
                    p1.Destroy();
                    p2.Destroy();
                    p3.Destroy();
                    level = 0;
                    GetComponent<Animator>().runtimeAnimatorController = LevelEndAnim;
                }
                break;
        }
    }

    public void ExitButton(GameObject Panel)
    {
        Panel.SetActive(true);
    }

    public void ExitButtonConfirm()
    {
        SceneManager.LoadScene(0);
    }
}
