using UnityEngine;
//using UnityEngine.Localization.Settings;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;
using System.Collections.Generic;
using System.Collections;
using TMPro;
using GoogleMobileAds.Api;
using System;
using UnityEngine.Video;
using Unity.VisualScripting;
using Delaunay.Geo;

public class MainMenu : MonoBehaviour
{
    private float HMPlayersF;
    public string gm;
    public GameObject GMButtonAll;
    public GameObject GMButtonDM;
    public GameObject GMButtonCoin;
    public GameObject N;
    public GameObject H;
    public GameObject HC;
    public float difficulty;
    public InputField RoundsInputField;
    public float RandomRounds;
    public float HMRounds;
    public float SpeedTime1;
    public float SpeedTime2 = 15;
    public bool AddRounds;
    public bool MinusRounds;
    public Toggle toggle;
    public RuntimeAnimatorController WardrobeAnimation;
    public RuntimeAnimatorController ExitWardrobeAnimation;
    public RuntimeAnimatorController ShopAnimation;
    public RuntimeAnimatorController ExitShopAnimation;
    public RuntimeAnimatorController ExitPlayAnimation;
    public RuntimeAnimatorController OtherSettingPanelAnim;
    public RuntimeAnimatorController OtherSettingPanelExitAnim;
    public GameObject Panel;
    public FlexibleColorPicker ColorPicker1;
    public FlexibleColorPicker ColorPicker2;
    public FlexibleColorPicker ColorPicker3;
    public FlexibleColorPicker ColorPicker4;
    public SpriteRenderer newCircle1;
    public SpriteRenderer newCircle2;
    public SpriteRenderer newCircle3;
    public SpriteRenderer newCircle4;
    public Text MoneyText;
    public Text MoneyTextShop;
    public float Money;
    public Animator Camera;
    public GameObject OtherSettingPanel;
    public SpriteRenderer LanguageFlag;
    public GameObject Flag;
    public TMP_Text Description;
    private RewardedAd rewardedAd;
    private RewardedAd rewardedAd2;
    public TMP_Text AdError;
    public GameObject PanelAdError;
    public TMP_Text AdError2;
    public GameObject Music;
    public static float isMusic = 0;
    public GameObject MusicI;
    public VideoClip dm;
    public VideoClip coins;
    public VideoClip solo;
    public VideoPlayer vp;
    public Shop shopOb;
    public GameObject Tutorial;
    float tutorialF;
    Color circle1Color = new Color(0, 1, 0);
    Color circle2Color = new Color((float)0.612, 0, 1);
    Color circle3Color = new Color(1, 0, (float)0.650);
    Color circle4Color = new Color((float)0.984, 0, 0);
    List<Circle> listC = new List<Circle>();
    List<string> listSave = new List<string>();
    List<GameObject> difficultyC = new List<GameObject>();
    List<GameObject> gmButtons = new List<GameObject>();
    public bool UpdateColorB = false;
    int save;
    Circle Circle1 = new Circle();
    Circle Circle2 = new Circle();
    Circle Circle3 = new Circle();
    Circle Circle4 = new Circle();


    public struct Circle
    {
        public Color circlecolor;
        public FlexibleColorPicker ColorPicker;
        public SpriteRenderer newCircle;
    }

    void AllText()
    {
        if (HMPlayersF > 1)
        switch (LocalizationSettings.SelectedLocale.Formatter.ToString())
        {
            case "uk":
                Description.text = "Вибрані всі режими гри circle";
                break;
            case "ru":
                Description.text = "Выбраны все режимы игры circle";
                break;
            default:
                Description.text = "All circle game modes are selected";
                break;
        }
    }

    void DMText()
    {
        if (HMPlayersF > 1)
        switch (LocalizationSettings.SelectedLocale.Formatter.ToString())
        {
            case "uk":
                Description.text = "Вибрано режим deathmatch. Останній, хто вижив, отримує очко.";
                break;
            case "ru":
                Description.text = "Выбран режим deathmatch. Последний выживший получает очко.";
                break;
            default:
                Description.text = "Deathmatch mode selected. The last survivor gets a point.";
                break;
        }
    }

    void CoinsText()
    {
        if (HMPlayersF > 1)
        switch (LocalizationSettings.SelectedLocale.Formatter.ToString())
        {
            case "uk":
                Description.text = "Вибрано режим coins. Отримує очко той, у кого після закінчення часу найбільше монет. Останній, хто вижив, не отримує очко.";
                break;
            case "ru":
                Description.text = "Выбран режим coins.Получает очко тот, у кого по истечении времени больше всего монет. Последний выживший не получает очко.";
                break;
            default:
                Description.text = "Coins mode selected. The point is awarded to the one who has the most coins at the end of the time. The last survivor does not receive a point.";
                break;
        }
    }

    void NormalText()
    {
        if (HMPlayersF == 1)
            vp.clip = solo;
        switch (LocalizationSettings.SelectedLocale.Formatter.ToString())
        {
            case "uk":
                Description.text = "Гра з ботами. Вибрано найлегшу складність";
                break;
            case "ru":
                Description.text = "Игра с ботами. Выбрана самая лёгкая сложность";
                break;
            default:
                Description.text = "Game with bots. The easiest difficulty is chosen";
                break;
        }
    }

    void HardText()
    {
        if (HMPlayersF == 1)
            vp.clip = solo;
        switch (LocalizationSettings.SelectedLocale.Formatter.ToString())
        {
            case "uk":
                Description.text = "Гра з ботами. Вибрано складну складність. Кількість монет збільшено.";
                break;
            case "ru":
                Description.text = "Игра с ботами. Выбрана сложная сложность. Количество монет увеличено.";
                break;
            default:
                Description.text = "Game with bots. The hard difficulty is chosen. Number of coins increased.";
                break;
        }
    }

    void HardCoreText()
    {
        if (HMPlayersF == 1)
            vp.clip = solo;
        switch (LocalizationSettings.SelectedLocale.Formatter.ToString())
        {
            case "uk":
                Description.text = "Гра з ботами. Вибрано складну складність. Кількість монет сильно збільшена";
                break;
            case "ru":
                Description.text = "Игра с ботами. Выбрана очень сложная сложность. Количество монет сильно увеличено.";
                break;
            default:
                Description.text = "Game with bots. The hard difficulty is chosen. The number of coins has very increased";
                break;
        }
    }
    
    void StartDifficulty()
    {
        switch (difficulty) {
            case 1:
                N.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
                N.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
                NormalText();
                break;
            case 2:
                H.GetComponent<Image>().color = new Color32(255, 215, 22, 255);
                H.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
                HardText();
                break;
            case 3:
                HC.GetComponent<Image>().color = new Color32(142, 0, 0, 255);
                HC.GetComponentInChildren<Text>().color = new Color32(255, 255, 255, 255);
                HardCoreText();
                break; 
        }
    }

    void SetLoad()
    {
        //listSave.AddRange(new List<string>() { });
        tutorialF = PlayerPrefs.GetFloat("tutorialF");
        difficulty = PlayerPrefs.GetFloat("difficulty");
        HMRounds = PlayerPrefs.GetFloat("HMRounds");
        RandomRounds = PlayerPrefs.GetFloat("RandomLevels");
        Money = PlayerPrefs.GetFloat("Money");
        HMPlayersF = PlayerPrefs.GetFloat("HMPlayersF");
        MoneyText.text = Money.ToString();
        toggle.isOn = Convert.ToBoolean(RandomRounds);
        RoundsInputField.text = HMRounds.ToString();
        if (HMRounds == 0) {
            HMRounds = 10;
            PlayerPrefs.SetFloat("HMRounds", HMRounds);
            RoundsInputField.text = HMRounds.ToString();
        }
        if (tutorialF == 0) {
            Tutorial.SetActive(true);
            PlayerPrefs.SetFloat("tutorialF", 1f);
        }
    }

    void SaveLoad()
    {
        listSave.AddRange(new List<string>() { "SP", "HMM", "Bouncy", "BouncyForce", "BouncySelfForce", "Freezing", "FreezingTime", "Energizer", "MaxSpeed", "Acceleration", "FreezingMult", "FreezingColor", "Take a look around", "Take a look aroundTime", "Take a look aroundMaxSpeed", "Take a look aroundAcc", "WaveSpeed",
        "WaveSpeedModifier", "WaveScaleSpeedModifier", "TripleTake", "HMRLook around", "HMRBouncy", "HMREnergizer", "HMRFreezing", "HMRWaveSpeed", "HMRTripleTake", "MoneyMultiplier", "Friend of Glass"});
        foreach(string name in listSave) {
            if (name is "BouncyForce" or "BouncySelfForce" or "MaxSpeed" or "Acceleration" or "Take a look aroundTime" or "Take a look aroundMaxSpeed" or "Take a look aroundAcc" or "MoneyMultiplier")
            {save = 1;} else {save = 0;}
            for (int i = 1; i <= 4; i++) {
                PlayerPrefs.SetFloat(name + i.ToString(), save); } 
        }
        PlayerPrefs.SetInt("Level", 1);
        PlayerPrefs.SetFloat("HMRoundsPlayed", 0);
        PlayerPrefs.SetFloat("LastWin", 0);
        PlayerPrefs.SetFloat("CardsAfterMonetu", 0);
        PlayerPrefs.SetFloat("The Money Box Rarity", 0);
    }

    void CircleSet()
    {
        Circle1 = new Circle() {
            circlecolor = circle1Color,
            ColorPicker = ColorPicker1,
            newCircle = newCircle1
        };
        Circle2 = new Circle() {
            circlecolor = circle2Color,
            ColorPicker = ColorPicker2,
            newCircle = newCircle2
        };
        Circle3 = new Circle() {
            circlecolor = circle3Color,
            ColorPicker = ColorPicker3,
            newCircle = newCircle3
        };
        Circle4 = new Circle() {
            circlecolor = circle4Color,
            ColorPicker = ColorPicker4,
            newCircle = newCircle4
        };
    }

    void SetDefaultColors()
    {
        CircleSet();
        listC.AddRange(new List<Circle>() {Circle1, Circle2, Circle3, Circle4});
        for (int i = 0; i < 4; i++) {
            int isave = i++;
            Color result = (Color)listC[i].circlecolor;
            Color defaultC = (Color)listC[i].circlecolor;
            FlexibleColorPicker ColorPicker = (FlexibleColorPicker)listC[i].ColorPicker;
            SpriteRenderer newCircle = (SpriteRenderer)listC[i].newCircle;
            result.r = PlayerPrefs.GetFloat("Circle" + isave.ToString() + ".r");
            result.g = PlayerPrefs.GetFloat("Circle" + isave.ToString() + ".g");
            result.b = PlayerPrefs.GetFloat("Circle" + isave.ToString() + ".b");
            if (result.maxColorComponent == 0) {
                PlayerPrefs.SetFloat("Circle" + isave.ToString() + ".r", defaultC.r);
                PlayerPrefs.SetFloat("Circle" + isave.ToString() + ".g", defaultC.g);
                PlayerPrefs.SetFloat("Circle" + isave.ToString() + ".b", defaultC.b);
                ColorPicker.SetColor(defaultC);
                newCircle.color = defaultC; }
            else {
                ColorPicker.SetColor(result);
                newCircle.color = result; }
        }
    }

    void adInitialize()
    {
        MobileAds.Initialize(initStatus => { });
        rewardedAd = new RewardedAd("ca-app-pub-1713143637407054/9631591596");
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request);
    }

    void SetMusic()
    {
        isMusic++;
        if (isMusic < 2) {
            MusicI = Instantiate<GameObject>(Music);
            DontDestroyOnLoad(MusicI);
        }
        else {
            MusicI = GameObject.Find("Music(Clone)");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        Application.targetFrameRate = 60;
        SetDefaultColors();
        SaveLoad();
        SetLoad();
        if (difficulty == 0) {
            difficulty = 1;
            PlayerPrefs.SetFloat("difficulty", 1);
            gm = "all";
            PlayerPrefs.SetString("gm", gm);
        }
        StartDifficulty();
        //HMPlayersF = PlayerPrefs.GetFloat("HMPlayersF");
        gmButtons.AddRange(new List<GameObject>() { GMButtonAll, GMButtonDM, GMButtonCoin });
        gmChange();
        SetMusic();
        adInitialize();
        difficultyC.AddRange(new List<GameObject>() { N, H, HC });
        //float c1r = PlayerPrefs.GetFloat("Circle1.r");
        //float c1g = PlayerPrefs.GetFloat("Circle1.g");
        //float c1b = PlayerPrefs.GetFloat("Circle1.b");
        //float c2r = PlayerPrefs.GetFloat("Circle2.r");
        //float c2g = PlayerPrefs.GetFloat("Circle2.g");
        //float c2b = PlayerPrefs.GetFloat("Circle2.b");
        //float c3r = PlayerPrefs.GetFloat("Circle3.r");
        //float c3g = PlayerPrefs.GetFloat("Circle3.g");
        //float c3b = PlayerPrefs.GetFloat("Circle3.b");
        //float c4r = PlayerPrefs.GetFloat("Circle4.r");
        //float c4g = PlayerPrefs.GetFloat("Circle4.g");
        //float c4b = PlayerPrefs.GetFloat("Circle4.b");
        //if (c1r == 0 && c1g == 0 && c1b == 0)
        //{
        //    ColorPicker1.SetColor(new Color(0, 1, 0));
        //    newCircle1.color = new Color(0, 1, 0);
        //    PlayerPrefs.SetFloat("Circle1.r", 0);
        //    PlayerPrefs.SetFloat("Circle1.g", 1);
        //    PlayerPrefs.SetFloat("Circle1.b", 0);
        //}
        //else
        //{
        //    ColorPicker1.SetColor(new Color(c1r, c1g, c1b, 1));
        //    newCircle1.color = new Color(c1r, c1g, c1b, 1);
        //}
        //if (c2r == 0 && c2g == 0 && c2b == 0)
        //{
        //    ColorPicker2.SetColor(new Color((float)0.612, 0, (float)1));
        //    newCircle2.color = new Color((float)0.612, 0, (float)1);
        //    PlayerPrefs.SetFloat("Circle2.r", (float)0.612);
        //    PlayerPrefs.SetFloat("Circle2.g", 0);
        //    PlayerPrefs.SetFloat("Circle2.b", 1);
        //}
        //else
        //{
        //    ColorPicker2.SetColor(new Color(c2r, c2g, c2b, 1));
        //    newCircle2.color = new Color(c2r, c2g, c2b, 1);
        //}
        //if (c3r == 0 && c3g == 0 && c3b == 0)
        //{
        //    ColorPicker3.SetColor(new Color((float)1, 0, (float)0.650));
        //    newCircle3.color = new Color((float)1, 0, (float)0.650);
        //    PlayerPrefs.SetFloat("Circle3.r", 1);
        //    PlayerPrefs.SetFloat("Circle3.g", 0);
        //    PlayerPrefs.SetFloat("Circle3.b", (float)0.650);
        //}
        //else
        //{
        //    ColorPicker3.SetColor(new Color(c3r, c3g, c3b, 255));
        //    newCircle3.color = new Color(c3r, c3g, c3b, 255);
        //}
        //if (c4r == 0 && c4g == 0 && c4b == 0)
        //{
        //    ColorPicker4.SetColor(new Color((float)0.984, (float)1, 0));
        //    newCircle4.color = new Color((float)0.984, (float)1, 0);
        //    PlayerPrefs.SetFloat("Circle4.r", (float)0.984);
        //    PlayerPrefs.SetFloat("Circle4.g", 1);
        //    PlayerPrefs.SetFloat("Circle4.b", 0);
        //}
        //else
        //{
        //    ColorPicker4.SetColor(new Color(c4r, c4g, c4b, 255));
        //    newCircle4.color = new Color(c4r, c4g, c4b, 255);
        //}
        //RoundsInputField.onValueChanged.AddListener(delegate { OnInputFieldChanged(); });


        //PlayerPrefs.SetFloat("SP1", 0);
        //PlayerPrefs.SetFloat("SP2", 0);
        //PlayerPrefs.SetFloat("SP3", 0);
        //PlayerPrefs.SetFloat("SP4", 0);
        //PlayerPrefs.SetFloat("HMM1", 0);
        //PlayerPrefs.SetFloat("HMM2", 0);
        //PlayerPrefs.SetFloat("HMM3", 0);
        //PlayerPrefs.SetFloat("HMM4", 0);
        //PlayerPrefs.SetInt("Level", 1);
        //PlayerPrefs.SetFloat("HMRoundsPlayed", 0);
        //PlayerPrefs.SetFloat("LastWin", 0);
        //PlayerPrefs.SetFloat("Bouncy1", 0);
        //PlayerPrefs.SetFloat("BouncyForce1", 1);
        //PlayerPrefs.SetFloat("BouncySelfForce1", 1);
        //PlayerPrefs.SetFloat("Freezing1", 0);
        //PlayerPrefs.SetFloat("FreezingTime1", 0);
        //PlayerPrefs.SetFloat("Energizer1", 0);
        //PlayerPrefs.SetFloat("MaxSpeed1", 1);
        //PlayerPrefs.SetFloat("Acceleration1", 1);
        //PlayerPrefs.SetFloat("Bouncy2", 0);
        //PlayerPrefs.SetFloat("BouncyForce2", 1);
        //PlayerPrefs.SetFloat("BouncySelfForce2", 1);
        //PlayerPrefs.SetFloat("Freezing2", 0);
        //PlayerPrefs.SetFloat("FreezingTime2", 0);
        //PlayerPrefs.SetFloat("Energizer2", 0);
        //PlayerPrefs.SetFloat("MaxSpeed2", 1);
        //PlayerPrefs.SetFloat("Acceleration2", 1);
        //PlayerPrefs.SetFloat("Bouncy3", 0);
        //PlayerPrefs.SetFloat("BouncyForce3", 1);
        //PlayerPrefs.SetFloat("BouncySelfForce3", 1);
        //PlayerPrefs.SetFloat("Freezing3", 0);
        //PlayerPrefs.SetFloat("FreezingTime3", 0);
        //PlayerPrefs.SetFloat("Energizer3", 0);
        //PlayerPrefs.SetFloat("MaxSpeed3", 1);
        //PlayerPrefs.SetFloat("Acceleration3", 1);
        //PlayerPrefs.SetFloat("Bouncy4", 0);
        //PlayerPrefs.SetFloat("BouncyForce4", 1);
        //PlayerPrefs.SetFloat("BouncySelfForce4", 1);
        //PlayerPrefs.SetFloat("Freezing4", 0);
        //PlayerPrefs.SetFloat("FreezingTime4", 0);
        //PlayerPrefs.SetFloat("Energizer4", 0);
        //PlayerPrefs.SetFloat("MaxSpeed4", 1);
        //PlayerPrefs.SetFloat("Acceleration4", 1);
        //PlayerPrefs.SetFloat("FreezingMult1", 0);
        //PlayerPrefs.SetFloat("FreezingColor1", 0);
        //PlayerPrefs.SetFloat("FreezingMult2", 0);
        //PlayerPrefs.SetFloat("FreezingColor2", 0);
        //PlayerPrefs.SetFloat("FreezingMult3", 0);
        //PlayerPrefs.SetFloat("FreezingColor3", 0);
        //PlayerPrefs.SetFloat("FreezingMult4", 0);
        //PlayerPrefs.SetFloat("FreezingColor4", 0);
        //PlayerPrefs.SetFloat("Take a look around1", 0);
        //PlayerPrefs.SetFloat("Take a look aroundTime1", 1);
        //PlayerPrefs.SetFloat("Take a look aroundMaxSpeed1", 1);
        //PlayerPrefs.SetFloat("Take a look aroundAcc1", 1);
        //PlayerPrefs.SetFloat("Take a look around2", 0);
        //PlayerPrefs.SetFloat("Take a look aroundTime2", 1);
        //PlayerPrefs.SetFloat("Take a look aroundMaxSpeed2", 1);
        //PlayerPrefs.SetFloat("Take a look aroundAcc2", 1);
        //PlayerPrefs.SetFloat("Take a look around3", 0);
        //PlayerPrefs.SetFloat("Take a look aroundTime3", 1);
        //PlayerPrefs.SetFloat("Take a look aroundMaxSpeed3", 1);
        //PlayerPrefs.SetFloat("Take a look aroundAcc3", 1);
        //PlayerPrefs.SetFloat("Take a look around4", 0);
        //PlayerPrefs.SetFloat("Take a look aroundTime4", 1);
        //PlayerPrefs.SetFloat("Take a look aroundMaxSpeed4", 1);
        //PlayerPrefs.SetFloat("Take a look aroundAcc4", 1);
        //PlayerPrefs.SetFloat("WaveSpeed1", 0);
        //PlayerPrefs.SetFloat("WaveSpeed2", 0);
        //PlayerPrefs.SetFloat("WaveSpeed3", 0);
        //PlayerPrefs.SetFloat("WaveSpeed4", 0);
        //PlayerPrefs.SetFloat("WaveSpeedModifier1", 0);
        //PlayerPrefs.SetFloat("WaveSpeedModifier2", 0);
        //PlayerPrefs.SetFloat("WaveSpeedModifier3", 0);
        //PlayerPrefs.SetFloat("WaveSpeedModifier4", 0);
        //PlayerPrefs.SetFloat("WaveScaleSpeedModifier1", 0);
        //PlayerPrefs.SetFloat("WaveScaleSpeedModifier2", 0);
        //PlayerPrefs.SetFloat("WaveScaleSpeedModifier3", 0);
        //PlayerPrefs.SetFloat("WaveScaleSpeedModifier4", 0);
        //PlayerPrefs.SetFloat("TripleTake1", 0);
        //PlayerPrefs.SetFloat("TripleTake2", 0);
        //PlayerPrefs.SetFloat("TripleTake3", 0);
        //PlayerPrefs.SetFloat("TripleTake4", 0);

        //PlayerPrefs.SetFloat("HMRLook around1", 0);
        //PlayerPrefs.SetFloat("HMRLook around2", 0);
        //PlayerPrefs.SetFloat("HMRLook around3", 0);
        //PlayerPrefs.SetFloat("HMRLook around4", 0);
        //PlayerPrefs.SetFloat("HMRBouncy1", 0);
        //PlayerPrefs.SetFloat("HMRBouncy2", 0);
        //PlayerPrefs.SetFloat("HMRBouncy3", 0);
        //PlayerPrefs.SetFloat("HMRBouncy4", 0); 
        //PlayerPrefs.SetFloat("HMREnergizer1", 0);
        //PlayerPrefs.SetFloat("HMREnergizer2", 0);
        //PlayerPrefs.SetFloat("HMREnergizer3", 0);
        //PlayerPrefs.SetFloat("HMREnergizer4", 0); 
        //PlayerPrefs.SetFloat("HMRFreezing1", 0);
        //PlayerPrefs.SetFloat("HMRFreezing2", 0);
        //PlayerPrefs.SetFloat("HMRFreezing3", 0);
        //PlayerPrefs.SetFloat("HMRFreezing4", 0);
        //PlayerPrefs.SetFloat("HMRWaveSpeed1", 0);
        //PlayerPrefs.SetFloat("HMRWaveSpeed2", 0);
        //PlayerPrefs.SetFloat("HMRWaveSpeed3", 0);
        //PlayerPrefs.SetFloat("HMRWaveSpeed4", 0);
        //PlayerPrefs.SetFloat("HMRTripleTake1", 0);
        //PlayerPrefs.SetFloat("HMRTripleTake2", 0);
        //PlayerPrefs.SetFloat("HMRTripleTake3", 0);
        //PlayerPrefs.SetFloat("HMRTripleTake4", 0);

        //PlayerPrefs.SetFloat("MoneyMultiplier1", 1);
        //PlayerPrefs.SetFloat("MoneyMultiplier2", 1);
        //PlayerPrefs.SetFloat("MoneyMultiplier3", 1);
        //PlayerPrefs.SetFloat("MoneyMultiplier4", 1);

        //PlayerPrefs.SetFloat("CardsAfterMonetu", 0);

        //PlayerPrefs.SetFloat("The Money Box Rarity", 0);

        //PlayerPrefs.SetFloat("Friend of Glass1", 0);
        //PlayerPrefs.SetFloat("Friend of Glass2", 0);
        //PlayerPrefs.SetFloat("Friend of Glass3", 0);
        //PlayerPrefs.SetFloat("Friend of Glass4", 0);

        //tutorialF = PlayerPrefs.GetFloat("tutorialF");
        //difficulty = PlayerPrefs.GetFloat("difficulty");

        //HMRounds = PlayerPrefs.GetFloat("HMRounds");
        //RandomRounds = PlayerPrefs.GetFloat("RandomLevels");
        //Money = PlayerPrefs.GetFloat("Money");
        //MoneyText.text = Money.ToString();

        //if (RandomRounds == 0)
        //{
        //    toggle.isOn = false;
        //}
        //else if (RandomRounds == 1)
        //{
        //    toggle.isOn = true;
        //}
        //RoundsInputField.text = HMRounds.ToString();
        //switch (LocalizationSettings.SelectedLocale.Formatter.ToString())
        //{
        //    case "uk":
        //        DifficultyString = "Гра з ботами. Вибрано найлегшу складність";
        //        break;
        //    case "ru":
        //        DifficultyString = "Игра с ботами. Выбрана самая лёгкая сложность";
        //        break;
        //    default:
        //        DifficultyString = "Game with bots. The easiest difficulty is chosen";
        //        break;
        //}
        //break;
    }

    public void Awake()
    {
        StartCoroutine(ChangeToSavedLanguage());
    }
    IEnumerator ChangeToSavedLanguage()
    {
        yield return new WaitForSecondsRealtime(2);
        if (PlayerPrefs.GetFloat("LanguageChangeManualy") == 0)
        {
            switch (Application.systemLanguage)
            {
                case SystemLanguage.Ukrainian:
                    LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[2];
                    break;
                case SystemLanguage.Russian:
                    LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
                    break;
                default:
                    LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
                    break;
            }
        }
        else
        {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[(int)PlayerPrefs.GetFloat("LanguageChangeManualy")];
        }
        gmChange();
        StartDifficulty();
        //if (difficulty == 0)
        //{
        //    if (HMPlayersF == 1)
        //    {
        //        vp.clip = solo;
        //        if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
        //        {
        //            Description.text = "Игра с ботами. Выбрана самая лёгкая сложность";
        //        }
        //        else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
        //        {
        //            Description.text = "Гра з ботами. Вибрано найлегшу складність";
        //        }
        //        else
        //        {
        //            Description.text = "Game with bots. The easiest difficulty is chosen";
        //        }
        //    }
        //}
        //else if (difficulty == 1)
        //{
        //    if (HMPlayersF == 1)
        //    {
        //        vp.clip = solo;
        //        if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
        //        {
        //            Description.text = "Игра с ботами. Выбрана самая лёгкая сложность";
        //        }
        //        else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
        //        {
        //            Description.text = "Гра з ботами. Вибрано найлегшу складність";
        //        }
        //        else
        //        {
        //            Description.text = "Game with bots. The easiest difficulty is chosen";
        //        }
        //    }
        //}
        //else if (difficulty == 2)
        //{
        //    if (HMPlayersF == 1)
        //    {
        //        vp.clip = solo;
        //        if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
        //        {
        //            Description.text = "Игра с ботами. Выбрана сложная сложность. Количество монет увеличено.";
        //        }
        //        else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
        //        {
        //            Description.text = "Гра з ботами. Вибрано складну складність. Кількість монет збільшено.";
        //        }
        //        else
        //        {
        //            Description.text = "Game with bots. The hard difficulty is chosen. Number of coins increased.";
        //        }
        //    }
        //}
        //else if (difficulty == 3)
        //{
        //    if (HMPlayersF == 1)
        //    {
        //        vp.clip = solo;
        //        if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru")
        //        {
        //            Description.text = "Игра с ботами. Выбрана очень сложная сложность. Количество монет сильно увеличено.";
        //        }
        //        else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk")
        //        {
        //            Description.text = "Гра з ботами. Вибрано складну складність. Кількість монет сильно збільшена";
        //        }
        //        else
        //        {
        //            Description.text = "Game with bots. The hard difficulty is chosen. The number of coins has very increased";
        //        }
        //    }
        //}
    }
    // Update is called once per frame
    void Update()
    {
        UpdateColor();
        AddRoundsVoid();
        MinusRoundsVoid();
        if (!AddRounds && !MinusRounds)
        {
            SpeedTime2 = 50;
            SpeedTime1 = 0;
        }
    }

    void AddRoundsVoid()
    {
        if (AddRounds)
        {
            SpeedTime1 = SpeedTime1 + 40 * Time.deltaTime;
            if (SpeedTime2 > 8)
            {
                SpeedTime2 = SpeedTime2 - 15 * Time.deltaTime;
            }
            if ((SpeedTime1 > SpeedTime2))
            {
                SpeedTime1 = 0;
                HMRounds = float.Parse(RoundsInputField.text);
                HMRounds++;
                RoundsInputField.text = HMRounds.ToString();
            }
        }
    }

    void MinusRoundsVoid()
    {
        if (MinusRounds && HMRounds > 0) {
            SpeedTime1 = SpeedTime1 + 40 * Time.deltaTime;
            if (SpeedTime2 > 8) {
                SpeedTime2 = SpeedTime2 - 15 * Time.deltaTime;
            }
            if ((SpeedTime1 > SpeedTime2)) {
                SpeedTime1 = 0;
                HMRounds = float.Parse(RoundsInputField.text);
                HMRounds--;
                RoundsInputField.text = HMRounds.ToString();
            }
        }
    }

    void GMButtonsColor()
    {
        for (int i = 0; i < 3; i++) {
            gmButtons[i].GetComponent<Image>().color = Color.white;
            gmButtons[i].GetComponentInChildren<Text>().color = Color.black;
        }
    }

    public void GMButtonClickAll()
    {
        vp.clip = dm;
        gm = "all";
        PlayerPrefs.SetString("gm", gm);
        GMButtonsColor();
        GMButtonAll.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
        GMButtonAll.GetComponentInChildren<Text>().color = Color.white;
        AllText();
    }
    public void GMButtonClickDM() {
        vp.clip = dm;
        gm = "dm";
        PlayerPrefs.SetString("gm", gm);
        GMButtonsColor();
        GMButtonDM.GetComponent<Image>().color = new Color32(142, 0, 0, 255);
        GMButtonDM.GetComponentInChildren<Text>().color = Color.white;
        DMText();
    }
    public void GMButtonClickMonetu() {
        vp.clip = coins;
        gm = "monetu";
        PlayerPrefs.SetString("gm", gm);
        GMButtonsColor();
        GMButtonCoin.GetComponent<Image>().color = new Color32(255, 215, 22, 255);
        GMButtonCoin.GetComponentInChildren<Text>().color = Color.white;
        CoinsText();
    }

    void DifficultyButtonsColor()
    {
        for (int i = 0; i < 3; i++) {
            difficultyC[i].GetComponent<Image>().color = Color.white;
            difficultyC[i].GetComponentInChildren<Text>().color = Color.black;
        }
    }

    public void NClick()
    {
        difficulty = 1;
        PlayerPrefs.SetFloat("difficulty", 1);
        DifficultyButtonsColor();
        N.GetComponent<Image>().color = new Color32(22, 22, 22, 255);
        N.GetComponentInChildren<Text>().color = Color.white;
        NormalText();
    }
    public void HClick()
    {
        difficulty = 2;
        PlayerPrefs.SetFloat("difficulty", 2);
        DifficultyButtonsColor();
        H.GetComponent<Image>().color = new Color32(255, 215, 22, 255);
        H.GetComponentInChildren<Text>().color = Color.black;
        HardText();
    }
    public void HCClick()
    {
        difficulty = 3;
        PlayerPrefs.SetFloat("difficulty", 3);
        DifficultyButtonsColor();
        HC.GetComponent<Image>().color = new Color32(142, 0, 0, 255);
        HC.GetComponentInChildren<Text>().color = Color.white;
        HardCoreText();
    }
    public void PlayButtonClick(bool IsADS)
    {
        //MusicI.GetComponent<AudioSource>().Play();
        if (MusicI != null) {
            MusicI.GetComponent<AudioSource>().UnPause();
        }
        if (IsADS) {
            PlayerPrefs.SetFloat("IsADS", 1);
        }
        else if (!IsADS) {
            PlayerPrefs.SetFloat("IsADS", 0);
        }
        HMPlayersF = PlayerPrefs.GetFloat("HMPlayersF");  
        if (RandomRounds == 0) {
            SceneManager.LoadScene(1);
        }
        else if (RandomRounds == 1) {
            SceneManager.LoadScene((int)Mathf.Round(UnityEngine.Random.Range(1, SceneManager.sceneCountInBuildSettings)));
        }
    }

    public void RoundsAddButtonClick()
    {
        AddRounds = true;
    }

    public void RoundsAddButtonUp()
    {
        AddRounds = false;
    }

    public void AnotherRoundsAddButtonOnCLick()
    {
        HMRounds = float.Parse(RoundsInputField.text);
        HMRounds++;
        RoundsInputField.text = HMRounds.ToString();
    }

    public void RoundsMinusButtonClick()
    {
        MinusRounds = true;
    }

    public void RoundsMinusButtonUp()
    {
        MinusRounds = false;
    }

    public void AnotherRoundsMinusButtonOnCLick()
    {
        HMRounds = float.Parse(RoundsInputField.text);
        HMRounds--;
        RoundsInputField.text = HMRounds.ToString();
    }

    public void OnInputFieldChanged()
    {
        if (RoundsInputField.text == "") {
            HMRounds = 0;
        }
        else {
            HMRounds = float.Parse(RoundsInputField.text);
        }
        if (HMRounds == 0) {
            HMRounds = 10;
            RoundsInputField.text = 10.ToString();
        }
        PlayerPrefs.SetFloat("HMRounds", HMRounds);
    }

    public void RandomLevels(bool RL)
    {
        if (RL) {
            RandomRounds = 1;
        }
        else if (!RL) {
            RandomRounds = 0;
        }
        PlayerPrefs.SetFloat("RandomLevels", RandomRounds);
    }

    public void WardrobeButtonOnClick()
    {
        UpdateColorB = true;
        Panel.GetComponent<Animator>().runtimeAnimatorController = WardrobeAnimation;
        Panel.GetComponent<Wardrobe>().enabled = true;
    }

    public void ShopButtonOnClick()
    {
        Camera.runtimeAnimatorController = ShopAnimation;
    }

    public void UpdateColor()
    {
        if (UpdateColorB)
        {
            newCircle1.color = ColorPicker1.GetColor();
            newCircle2.color = ColorPicker2.GetColor();
            newCircle3.color = ColorPicker3.GetColor();
            newCircle4.color = ColorPicker4.GetColor();
        }
    }

    public void ButtonExitWardrobeOnClick()
    {
        UpdateColorB = false;
        Panel.GetComponent<Animator>().runtimeAnimatorController = ExitWardrobeAnimation;
        for (int i = 0; i <= 4; i++) {
            int isave = i++;
            FlexibleColorPicker result = (FlexibleColorPicker)listC[i].ColorPicker;
            PlayerPrefs.SetFloat("Circle"+ isave.ToString()+".r", result.GetColor().r);
            PlayerPrefs.SetFloat("Circle"+ isave.ToString()+".g", result.GetColor().g);
            PlayerPrefs.SetFloat("Circle"+ isave.ToString()+".b", result.GetColor().b);
        }
        Panel.GetComponent<Wardrobe>().enabled = false;
    }

    public void ButtonExitShopOnClick()
    {
        Camera.GetComponent<Animator>().runtimeAnimatorController = ExitShopAnimation;
    }

    public void ButtonExitPlay()
    {
        Camera.GetComponent<Animator>().runtimeAnimatorController = ExitPlayAnimation;
    }

    public void ButtonOtherSettings()
    {
        OtherSettingPanel.GetComponent<Animator>().runtimeAnimatorController = OtherSettingPanelAnim;
    }

    public void ButtonOtherSettingsExit()
    {
        OtherSettingPanel.GetComponent<Animator>().runtimeAnimatorController = OtherSettingPanelExitAnim;
    }

    public void ChangeLanguageOnClick()
    {
        Debug.Log("LanguageChange");
        if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "ru") {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[2];
            PlayerPrefs.SetFloat("LanguageChangeManualy", 2);
        }
        else if (LocalizationSettings.SelectedLocale.Formatter.ToString() == "uk") {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[0];
            PlayerPrefs.SetFloat("LanguageChangeManualy", 0);
        }
        else {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[1];
            PlayerPrefs.SetFloat("LanguageChangeManualy", 1);
        }
        gmChange();
        StartDifficulty();
    }

    public void gmChange()
    {
        gm = PlayerPrefs.GetString("gm");
        switch (gm)
        {
            case "" or "all":
                GMButtonClickAll();
                break;
            case "dm":
                GMButtonClickDM();
                break;
            case "monetu":
                GMButtonClickMonetu();
                break;
        }
    }

    public void FirstPlayButton(GameObject Panel) {
            Panel.SetActive(true);
    }

    public void SecondPlayButton()
    {
        this.rewardedAd = new RewardedAd("ca-app-pub-1713143637407054/9631591596");
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        if (this.rewardedAd.IsLoaded()) {
            MusicI = GameObject.Find("Music(Clone)");
            MusicI.GetComponent<AudioSource>().Pause();
            this.rewardedAd.Show();
        }
        else {
            AdRequest request = new AdRequest.Builder().Build();
            this.rewardedAd.LoadAd(request);
        }
    }

    public void OnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        LoadAdError loadAdError = args.LoadAdError;
        string domain = loadAdError.GetDomain();
        int code = loadAdError.GetCode();
        string message = loadAdError.GetMessage();
        AdError underlyingError = loadAdError.GetCause();
        Debug.Log("Load error string: " + loadAdError.ToString());
        Debug.Log("Load ad error code:" + code.ToString());
        Debug.Log("Load ad error message:" + message);
        ResponseInfo responseInfo = loadAdError.GetResponseInfo();
        Debug.Log("Response info: " + responseInfo.ToString());
    }

    public void ShowADSShop()
    {
        rewardedAd2 = new RewardedAd("ca-app-pub-1713143637407054/1251420577");
        AdRequest request2 = new AdRequest.Builder().Build();
        this.rewardedAd2.OnAdLoaded += HandleRewardedAdLoaded2;
        this.rewardedAd2.OnUserEarnedReward += HandleUserEarnedReward2;
        this.rewardedAd2.LoadAd(request2);
    }

    public void HandleUserEarnedReward2(object sender, Reward args)
    {
        MusicI = GameObject.Find("Music(Clone)");
        MusicI.GetComponent<AudioSource>().UnPause();
        PlayerPrefs.SetFloat("Money", PlayerPrefs.GetFloat("Money") + 25);
        MoneyText.text = PlayerPrefs.GetFloat("Money").ToString();
        shopOb.MoneyText.text = PlayerPrefs.GetFloat("Money").ToString();
        shopOb.MoneyTextInShop.text = PlayerPrefs.GetFloat("Money").ToString();

    }

    public void HandleRewardedAdLoaded2(object sender, EventArgs args)
    {
        if (this.rewardedAd2.IsLoaded()) {
            //MusicI = GameObject.Find("Music");
            MusicI = GameObject.Find("Music(Clone)");
            MusicI.GetComponent<AudioSource>().Pause();
            this.rewardedAd2.Show();
        }
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MusicI = GameObject.Find("Music(Clone)");
        MusicI.GetComponent<AudioSource>().UnPause();
        AdError.gameObject.SetActive(true);
        AdError.text = "Ad was closed";
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        float IsADS = PlayerPrefs.GetFloat("IsADS");
        if (IsADS == 0) {
            AdError.gameObject.SetActive(true);
            AdError.text = "Ad Error:" + args.LoadAdError;
        }
        else {
            PanelAdError.SetActive(true);
            AdError2.gameObject.SetActive(true);
            AdError2.text = "Ad Error:" + args.LoadAdError;
        }
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MusicI = GameObject.Find("Music(Clone)");
        MusicI.GetComponent<AudioSource>().UnPause();
        float IsADS = PlayerPrefs.GetFloat("IsADS");
        if (IsADS == 0) {
            AdError.gameObject.SetActive(true);
            AdError.text = "Ad Error:" + args.Message;
        }
        else {
            PanelAdError.SetActive(true);
            AdError2.gameObject.SetActive(true);
            AdError2.text = "Ad Error:" + args.Message;
        }
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        //MonoBehaviour.print("HandleRewardedAdLoaded event received");
        if (this.rewardedAd.IsLoaded()) {
            MusicI = GameObject.Find("Music(Clone)");
            //MusicI = GameObject.Find("Music");
            MusicI.GetComponent<AudioSource>().Pause();
            this.rewardedAd.Show();
        }
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        MusicI = GameObject.Find("Music(Clone)");
        MusicI.GetComponent<AudioSource>().UnPause();
        PlayButtonClick(true);
    }

    //public void OnApplicationFocus(bool focus)
    //{
    //    MusicI = GameObject.Find("Music(Clone)");
    //    MusicI.GetComponent<AudioSource>().UnPause();
    //}

    //public void OnApplicationPause(bool focus)
    //{
    //    MusicI = GameObject.Find("Music(Clone)");
    //    MusicI.GetComponent<AudioSource>().UnPause();
    //}

}
