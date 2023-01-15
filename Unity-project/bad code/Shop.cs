using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shop : MonoBehaviour
{

    public Text MoneyText;
    public Text MoneyTextInShop;
    public float HMMoney;
    public GameObject ButtonUkraine;
    public GameObject ButtonZaez;
    public GameObject ButtonSmile;
    public GameObject ButtonKrytouSmile;
    public GameObject ButtonStetxem;
    public GameObject ButtonLike;
    public GameObject ButtonDymaet;
    public GameObject ButtonMiluy;
    public GameObject ButtonPeace;
    public GameObject ButtonVShoke;
    float UkraineBuy;
    float ZaezBuy;
    float SmileBuy;
    float KrytouSmileBuy;
    float StetxemBuy;
    float LikeBuy;
    float DymaetBuy;
    float MiluyBuy;
    float PeaceBuy;
    float VShokeBuy;
    //float KrytouSmileBuy;
    [SerializeField] GameObject ZaezKristal;
    [SerializeField] GameObject KrytouSmileKristal;
    [SerializeField] GameObject UkraineKristal;
    [SerializeField] GameObject StetxemKristal;
    [SerializeField] GameObject LikeKristal;
    [SerializeField] GameObject DymaetKristal;
    [SerializeField] GameObject MiluyKristal;
    [SerializeField] GameObject PeaceKristal;
    [SerializeField] GameObject VShokeKristal;

    // Start is called before the first frame update
    void Start()
    {
        HMMoney = PlayerPrefs.GetFloat("Money");
        UkraineBuy = PlayerPrefs.GetFloat("UkraineBuy");
        ZaezBuy = PlayerPrefs.GetFloat("ZaezBuy");
        SmileBuy = PlayerPrefs.GetFloat("SmileBuy");
        StetxemBuy = PlayerPrefs.GetFloat("StetxemBuy");
        LikeBuy = PlayerPrefs.GetFloat("LikeBuy");
        DymaetBuy = PlayerPrefs.GetFloat("DymaetBuy");
        MiluyBuy = PlayerPrefs.GetFloat("MiluyBuy");
        PeaceBuy = PlayerPrefs.GetFloat("PeaceBuy");
        VShokeBuy = PlayerPrefs.GetFloat("VShokeBuy");
        KrytouSmileBuy = PlayerPrefs.GetFloat("KrytouSmileBuy");
        MoneyTextInShop.text = HMMoney.ToString();
        if (ZaezBuy == 1)
        {
            ButtonZaez.GetComponent<Button>().enabled = false;
            ButtonZaez.GetComponentInChildren<Text>().text = "Purchased";
            ButtonZaez.GetComponentInChildren<SpriteRenderer>().enabled = false;
            if (ZaezKristal != null)
            {
                Destroy(ZaezKristal);
            }
        }
        if (SmileBuy == 1)
        {
            ButtonSmile.GetComponent<Button>().enabled = false;
            ButtonSmile.GetComponentInChildren<TMP_Text>().text = "Purchased";
            //ButtonSmile.GetComponentInChildren<SpriteRenderer>().enabled = false;
        }
        if (KrytouSmileBuy == 1)
        {
            ButtonKrytouSmile.GetComponent<Button>().enabled = false;
            ButtonKrytouSmile.GetComponentInChildren<Text>().text = "Purchased";
            ButtonKrytouSmile.GetComponentInChildren<SpriteRenderer>().enabled = false;
            if (KrytouSmileKristal != null)
            {
                Destroy(KrytouSmileKristal);
            }
        }
        if (UkraineBuy == 1)
        {
            ButtonUkraine.GetComponent<Button>().enabled = false;
            ButtonUkraine.GetComponentInChildren<Text>().text = "Purchased";
            ButtonUkraine.GetComponentInChildren<SpriteRenderer>().enabled = false;
            if (UkraineKristal != null)
            {
                Destroy(UkraineKristal);
            }
            //ButtonSmile.GetComponentInChildren<SpriteRenderer>().enabled = false;
        }
        if (StetxemBuy == 1)
        {
            ButtonStetxem.GetComponent<Button>().enabled = false;
            ButtonStetxem.GetComponentInChildren<Text>().text = "Purchased";
            ButtonUkraine.GetComponentInChildren<SpriteRenderer>().enabled = false;
            if (StetxemKristal != null)
            {
                Destroy(StetxemKristal);
            }
            //ButtonSmile.GetComponentInChildren<SpriteRenderer>().enabled = false;
        }
        if (LikeBuy == 1)
        {
            ButtonLike.GetComponent<Button>().enabled = false;
            ButtonLike.GetComponentInChildren<Text>().text = "Purchased";
            ButtonLike.GetComponentInChildren<SpriteRenderer>().enabled = false;
            if (LikeKristal != null)
            {
                Destroy(LikeKristal);
            }
            //ButtonSmile.GetComponentInChildren<SpriteRenderer>().enabled = false;
        }
        if (VShokeBuy == 1)
        {
            ButtonVShoke.GetComponent<Button>().enabled = false;
            ButtonVShoke.GetComponentInChildren<Text>().text = "Purchased";
            ButtonVShoke.GetComponentInChildren<SpriteRenderer>().enabled = false;
            if (VShokeKristal != null)
            {
                Destroy(VShokeKristal);
            }
            //ButtonSmile.GetComponentInChildren<SpriteRenderer>().enabled = false;
        }
        if (PeaceBuy == 1)
        {
            ButtonPeace.GetComponent<Button>().enabled = false;
            ButtonPeace.GetComponentInChildren<Text>().text = "Purchased";
            ButtonPeace.GetComponentInChildren<SpriteRenderer>().enabled = false;
            if (PeaceKristal != null)
            {
                Destroy(PeaceKristal);
            }
            //ButtonSmile.GetComponentInChildren<SpriteRenderer>().enabled = false;
        }
        if (MiluyBuy == 1)
        {
            ButtonMiluy.GetComponent<Button>().enabled = false;
            ButtonMiluy.GetComponentInChildren<Text>().text = "Purchased";
            ButtonMiluy.GetComponentInChildren<SpriteRenderer>().enabled = false;
            if (MiluyKristal != null)
            {
                Destroy(MiluyKristal);
            }
            //ButtonSmile.GetComponentInChildren<SpriteRenderer>().enabled = false;
        }
        if (DymaetBuy == 1)
        {
            ButtonDymaet.GetComponent<Button>().enabled = false;
            ButtonDymaet.GetComponentInChildren<Text>().text = "Purchased";
            ButtonDymaet.GetComponentInChildren<SpriteRenderer>().enabled = false;
            if (DymaetKristal != null)
            {
                Destroy(DymaetKristal);
            }
            //ButtonSmile.GetComponentInChildren<SpriteRenderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void BuySmile()
    //{
    //    //////HMMoney = PlayerPrefs.GetFloat("Money");
    //    SmileBuy = PlayerPrefs.GetFloat("SmileBuy");

    //    if (SmileBuy == 0)
    //    {
    //        if (HMMoney >= float.Parse(ButtonSmile.GetComponentInChildren<Text>().text))
    //        {
    //            PlayerPrefs.SetFloat("SmileBuy", 1);
    //            //PlayerPrefs.SetFloat("Skin", 1);
    //            ButtonSmile.GetComponentInChildren<SpriteRenderer>().enabled = false;
    //            HMMoney = HMMoney - float.Parse(ButtonSmile.GetComponentInChildren<Text>().text);
    //            PlayerPrefs.SetFloat("Money", HMMoney);
    //            ButtonSmile.GetComponentInChildren<Text>().text = "Purchased";
    //            MoneyText.text = HMMoney.ToString();
    //            MoneyTextInShop.text = HMMoney.ToString();
    //        }
    //    }
    //}

    public void BuySkinUkraine()
    {
        HMMoney = PlayerPrefs.GetFloat("Money");
        UkraineBuy = PlayerPrefs.GetFloat("UkraineBuy");

        if (UkraineBuy == 0)
        {
            if (HMMoney >= float.Parse(ButtonUkraine.GetComponentInChildren<Text>().text))
            {
                PlayerPrefs.SetFloat("UkraineBuy", 1);
                //PlayerPrefs.SetFloat("Skin", 1);
                ButtonUkraine.GetComponentInChildren<SpriteRenderer>().enabled = false;
                HMMoney = HMMoney - float.Parse(ButtonUkraine.GetComponentInChildren<Text>().text);
                ButtonUkraine.GetComponentInChildren<Text>().text = "Purchased";
                Destroy(UkraineKristal);
                PlayerPrefs.SetFloat("Money", HMMoney);
                MoneyText.text = HMMoney.ToString();
                MoneyTextInShop.text = HMMoney.ToString();
            }
        }
    }

    public void BuyZaez()
    {
        HMMoney = PlayerPrefs.GetFloat("Money");
        ZaezBuy = PlayerPrefs.GetFloat("ZaezBuy");

        if (ZaezBuy == 0)
        {
            if (HMMoney >= float.Parse(ButtonZaez.GetComponentInChildren<Text>().text))
            {
                PlayerPrefs.SetFloat("ZaezBuy", 1);
                //PlayerPrefs.SetFloat("Skin", 1);
                ButtonZaez.GetComponentInChildren<SpriteRenderer>().enabled = false;
                HMMoney = HMMoney - float.Parse(ButtonZaez.GetComponentInChildren<Text>().text);
                ButtonZaez.GetComponentInChildren<Text>().text = "Purchased";
                Destroy(ZaezKristal);
                PlayerPrefs.SetFloat("Money", HMMoney);
                MoneyText.text = HMMoney.ToString();
                MoneyTextInShop.text = HMMoney.ToString();
            }
        }
    }

    public void BuyKrytouSmile()
    {
        HMMoney = PlayerPrefs.GetFloat("Money");
        KrytouSmileBuy = PlayerPrefs.GetFloat("KrytouSmileBuy");

        if (KrytouSmileBuy == 0)
        {
            if (HMMoney >= float.Parse(ButtonKrytouSmile.GetComponentInChildren<Text>().text))
            {
                PlayerPrefs.SetFloat("KrytouSmileBuy", 1);
                //PlayerPrefs.SetFloat("Skin", 1);
                ButtonKrytouSmile.GetComponentInChildren<SpriteRenderer>().enabled = false;
                HMMoney = HMMoney - float.Parse(ButtonKrytouSmile.GetComponentInChildren<Text>().text);
                ButtonKrytouSmile.GetComponentInChildren<Text>().text = "Purchased";
                Destroy(KrytouSmileKristal);
                PlayerPrefs.SetFloat("Money", HMMoney);
                MoneyText.text = HMMoney.ToString();
                MoneyTextInShop.text = HMMoney.ToString();
            }
        }
    }

    public void BuyStetxem()
    {
        HMMoney = PlayerPrefs.GetFloat("Money");
        StetxemBuy = PlayerPrefs.GetFloat("StetxemBuy");

        if (StetxemBuy == 0)
        {
            if (HMMoney >= float.Parse(ButtonStetxem.GetComponentInChildren<Text>().text))
            {
                PlayerPrefs.SetFloat("StetxemBuy", 1);
                //PlayerPrefs.SetFloat("Skin", 1);
                ButtonStetxem.GetComponentInChildren<SpriteRenderer>().enabled = false;
                HMMoney = HMMoney - float.Parse(ButtonStetxem.GetComponentInChildren<Text>().text);
                ButtonStetxem.GetComponentInChildren<Text>().text = "Purchased";
                Destroy(StetxemKristal);
                PlayerPrefs.SetFloat("Money", HMMoney);
                MoneyText.text = HMMoney.ToString();
                MoneyTextInShop.text = HMMoney.ToString();
            }
        }
    }

    public void BuyLike()
    {
        HMMoney = PlayerPrefs.GetFloat("Money");
        LikeBuy = PlayerPrefs.GetFloat("LikeBuy");

        if (LikeBuy == 0)
        {
            if (HMMoney >= float.Parse(ButtonLike.GetComponentInChildren<Text>().text))
            {
                PlayerPrefs.SetFloat("LikeBuy", 1);
                //PlayerPrefs.SetFloat("Skin", 1);
                ButtonLike.GetComponentInChildren<SpriteRenderer>().enabled = false;
                HMMoney = HMMoney - float.Parse(ButtonLike.GetComponentInChildren<Text>().text);
                ButtonLike.GetComponentInChildren<Text>().text = "Purchased";
                Destroy(LikeKristal);
                PlayerPrefs.SetFloat("Money", HMMoney);
                MoneyText.text = HMMoney.ToString();
                MoneyTextInShop.text = HMMoney.ToString();
            }
        }
    }

    public void BuyVShoke()
    {
        HMMoney = PlayerPrefs.GetFloat("Money");
        VShokeBuy = PlayerPrefs.GetFloat("VShokeBuy");

        if (VShokeBuy == 0)
        {
            if (HMMoney >= float.Parse(ButtonVShoke.GetComponentInChildren<Text>().text))
            {
                PlayerPrefs.SetFloat("VShokeBuy", 1);
                //PlayerPrefs.SetFloat("Skin", 1);
                ButtonVShoke.GetComponentInChildren<SpriteRenderer>().enabled = false;
                HMMoney = HMMoney - float.Parse(ButtonVShoke.GetComponentInChildren<Text>().text);
                ButtonVShoke.GetComponentInChildren<Text>().text = "Purchased";
                Destroy(VShokeKristal);
                PlayerPrefs.SetFloat("Money", HMMoney);
                MoneyText.text = HMMoney.ToString();
                MoneyTextInShop.text = HMMoney.ToString();
            }
        }
    }

    public void BuyPeace()
    {
        HMMoney = PlayerPrefs.GetFloat("Money");
        PeaceBuy = PlayerPrefs.GetFloat("PeaceBuy");

        if (PeaceBuy == 0)
        {
            if (HMMoney >= float.Parse(ButtonPeace.GetComponentInChildren<Text>().text))
            {
                PlayerPrefs.SetFloat("PeaceBuy", 1);
                //PlayerPrefs.SetFloat("Skin", 1);
                ButtonPeace.GetComponentInChildren<SpriteRenderer>().enabled = false;
                HMMoney = HMMoney - float.Parse(ButtonPeace.GetComponentInChildren<Text>().text);
                ButtonPeace.GetComponentInChildren<Text>().text = "Purchased";
                Destroy(PeaceKristal);
                PlayerPrefs.SetFloat("Money", HMMoney);
                MoneyText.text = HMMoney.ToString();
                MoneyTextInShop.text = HMMoney.ToString();
            }
        }
    }

    public void BuyMiluy()
    {
        HMMoney = PlayerPrefs.GetFloat("Money");
        MiluyBuy = PlayerPrefs.GetFloat("MiluyBuy");

        if (MiluyBuy == 0)
        {
            if (HMMoney >= float.Parse(ButtonMiluy.GetComponentInChildren<Text>().text))
            {
                PlayerPrefs.SetFloat("MiluyBuy", 1);
                //PlayerPrefs.SetFloat("Skin", 1);
                ButtonMiluy.GetComponentInChildren<SpriteRenderer>().enabled = false;
                HMMoney = HMMoney - float.Parse(ButtonMiluy.GetComponentInChildren<Text>().text);
                ButtonMiluy.GetComponentInChildren<Text>().text = "Purchased";
                Destroy(MiluyKristal);
                PlayerPrefs.SetFloat("Money", HMMoney);
                MoneyText.text = HMMoney.ToString();
                MoneyTextInShop.text = HMMoney.ToString();
            }
        }
    }

    public void BuyDymaet()
    {
        HMMoney = PlayerPrefs.GetFloat("Money");
        DymaetBuy = PlayerPrefs.GetFloat("DymaetBuy");

        if (DymaetBuy == 0)
        {
            if (HMMoney >= float.Parse(ButtonDymaet.GetComponentInChildren<Text>().text))
            {
                PlayerPrefs.SetFloat("DymaetBuy", 1);
                //PlayerPrefs.SetFloat("Skin", 1);
                ButtonDymaet.GetComponentInChildren<SpriteRenderer>().enabled = false;
                HMMoney = HMMoney - float.Parse(ButtonDymaet.GetComponentInChildren<Text>().text);
                ButtonDymaet.GetComponentInChildren<Text>().text = "Purchased";
                Destroy(DymaetKristal);
                PlayerPrefs.SetFloat("Money", HMMoney);
                MoneyText.text = HMMoney.ToString();
                MoneyTextInShop.text = HMMoney.ToString();
            }
        }
    }

}
