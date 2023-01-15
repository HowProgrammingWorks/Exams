using UnityEngine;

public class Wardrobe : MonoBehaviour
{
    public SpriteRenderer sprite1;
    public SpriteRenderer sprite2;
    public SpriteRenderer sprite3;
    public SpriteRenderer sprite4;
    public SpriteRenderer SRForUse;
    public float UkraineBuy;
    public float ZaezBuy;
    public float SmileBuy;
    public float KrytouSmileBuy;
    public float StetxemBuy;
    public float LikeBuy;
    public float DymaetBuy;
    public float MiluyBuy;
    public float PeaceBuy;
    public float VShokeBuy;
    public float skin1;
    public float skin2;
    public float skin3;
    public float skin4;
    public GameObject ButtonUp1;
    public GameObject ButtonUp2;
    public GameObject ButtonUp3;
    public GameObject ButtonUp4;
    public Sprite Ukraine;
    public Sprite Zaez;
    public Sprite Smile;
    public Sprite KrytouSmile;
    public Sprite Stetxem;
    public Sprite Like;
    public Sprite Dymaet;
    public Sprite Miluy;
    public Sprite Peace;
    public Sprite VShoke;
    public float MaxSkins = 10;

    // Start is called before the first frame update
    void Start()
    {
        skin1 = PlayerPrefs.GetFloat("skin1");
        skin2 = PlayerPrefs.GetFloat("skin2");
        skin3 = PlayerPrefs.GetFloat("skin3");
        skin4 = PlayerPrefs.GetFloat("skin4");
        ZaezBuy = PlayerPrefs.GetFloat("ZaezBuy");
        SmileBuy = PlayerPrefs.GetFloat("SmileBuy");
        KrytouSmileBuy = PlayerPrefs.GetFloat("KrytouSmileBuy");
        StetxemBuy = PlayerPrefs.GetFloat("StetxemBuy");
        LikeBuy = PlayerPrefs.GetFloat("LikeBuy");
        DymaetBuy = PlayerPrefs.GetFloat("DymaetBuy");
        MiluyBuy = PlayerPrefs.GetFloat("MiluyBuy");
        PeaceBuy = PlayerPrefs.GetFloat("PeaceBuy");
        VShokeBuy = PlayerPrefs.GetFloat("VShokeBuy");


        if (skin1 == 1)
        {
            sprite1.sprite = Zaez;
            sprite1.transform.localPosition = new Vector3((float)0, (float)3.53, 0);
            //ButtonUp1.SetActive(false);
        }
        else if (skin1 == 2)
        {
            sprite1.sprite = Smile;
            sprite1.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin1 == 3)
        {
            sprite1.sprite = KrytouSmile;
            sprite1.transform.localPosition = new Vector3((float)1.07, (float)0.25, 0);
        }
        else if (skin1 == 4)
        {
            sprite1.sprite = Ukraine;
            sprite1.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin1 == 5)
        {
            sprite1.sprite = Stetxem;
            sprite1.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin1 == 6)
        {
            sprite1.sprite = Like;
            sprite1.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin1 == 7)
        {
            sprite1.sprite = Dymaet;
            sprite1.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin1 == 8)
        {
            sprite1.sprite = Miluy;
            sprite1.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin1 == 9)
        {
            sprite1.sprite = Peace;
            sprite1.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin1 == 10)
        {
            sprite1.sprite = VShoke;
            sprite1.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        if (skin2 == 1)
        {
            sprite2.sprite = Zaez;
            sprite2.transform.localPosition = new Vector3((float)0, (float)3.53, 0);
            //ButtonUp2.SetActive(false);
        }
        else if (skin2 == 2)
        {
            sprite2.sprite = Smile;
            sprite2.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin2 == 3)
        {
            sprite2.sprite = KrytouSmile;
            sprite2.transform.localPosition = new Vector3((float)1.07, (float)0.25, 0);
        }
        else if (skin2 == 4)
        {
            sprite2.sprite = Ukraine;
            sprite2.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin2 == 5)
        {
            sprite2.sprite = Stetxem;
            sprite2.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin2 == 6)
        {
            sprite2.sprite = Like;
            sprite2.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin2 == 7)
        {
            sprite2.sprite = Dymaet;
            sprite2.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin2 == 8)
        {
            sprite2.sprite = Miluy;
            sprite2.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin2 == 9)
        {
            sprite2.sprite = Peace;
            sprite2.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin2 == 10)
        {
            sprite2.sprite = VShoke;
            sprite2.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        if (skin3 == 1)
        {
            sprite3.sprite = Zaez;
            sprite3.transform.localPosition = new Vector3((float)0, (float)3.53, 0);

            //ButtonUp3.SetActive(false);
        }
        else if (skin3 == 2)
        {
            sprite3.sprite = Smile; 
            sprite3.transform.localPosition = new Vector3((float)0, (float)0, 0);

        }
        else if (skin3 == 3)
        {
            sprite3.sprite = KrytouSmile;
            sprite3.transform.localPosition = new Vector3((float)1.07, (float)0.25, 0);
        }
        else if (skin3 == 4)
        {
            sprite3.sprite = Ukraine;
            sprite3.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin3 == 5)
        {
            sprite3.sprite = Stetxem;
            sprite3.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin3 == 6)
        {
            sprite3.sprite = Like;
            sprite3.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin3 == 7)
        {
            sprite3.sprite = Dymaet;
            sprite3.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin3 == 8)
        {
            sprite3.sprite = Miluy;
            sprite3.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin3 == 9)
        {
            sprite3.sprite = Peace;
            sprite3.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin3 == 10)
        {
            sprite3.sprite = VShoke;
            sprite3.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        if (skin4 == 1)
        {
            sprite4.sprite = Zaez;
            sprite4.transform.localPosition = new Vector3((float)0, (float)3.53, 0);
            //ButtonUp4.SetActive(false);
        }
        else if (skin4 == 2)
        {
            sprite4.sprite = Smile;
            sprite4.transform.localPosition = new Vector3((float)0, (float)0, 0);

        }
        else if (skin4 == 3)
        {
            sprite4.sprite = KrytouSmile;
            sprite4.transform.localPosition = new Vector3((float)1.07, (float)0.25, 0);
        }
        else if (skin4 == 4)
        {
            sprite4.sprite = Ukraine;
            sprite4.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin4 == 5)
        {
            sprite4.sprite = Stetxem;
            sprite4.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin4 == 6)
        {
            sprite4.sprite = Like;
            sprite4.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin4 == 7)
        {
            sprite4.sprite = Dymaet;
            sprite4.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin4 == 8)
        {
            sprite4.sprite = Miluy;
            sprite4.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin4 == 9)
        {
            sprite4.sprite = Peace;
            sprite4.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin4 == 10)
        {
            sprite4.sprite = VShoke;
            sprite4.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonUp(float player)
    {
        float skin = PlayerPrefs.GetFloat("skin" + player.ToString());
        float skins;
        UkraineBuy = PlayerPrefs.GetFloat("UkraineBuy");
        ZaezBuy = PlayerPrefs.GetFloat("ZaezBuy");
        SmileBuy = PlayerPrefs.GetFloat("SmileBuy");
        KrytouSmileBuy = PlayerPrefs.GetFloat("KrytouSmileBuy");
        StetxemBuy = PlayerPrefs.GetFloat("StetxemBuy");
        LikeBuy = PlayerPrefs.GetFloat("LikeBuy");
        DymaetBuy = PlayerPrefs.GetFloat("DymaetBuy");
        MiluyBuy = PlayerPrefs.GetFloat("MiluyBuy");
        PeaceBuy = PlayerPrefs.GetFloat("PeaceBuy");
        VShokeBuy = PlayerPrefs.GetFloat("VShokeBuy");
        skins = ZaezBuy + SmileBuy + KrytouSmileBuy + UkraineBuy + StetxemBuy + LikeBuy + DymaetBuy + MiluyBuy + PeaceBuy + VShokeBuy;
        if (skins > 0 && skin <= MaxSkins)
        {
            skin++;
            if (skin == 1)
            {
                if (ZaezBuy == 0)
                {
                    skin++;
                    if (SmileBuy == 0)
                    {
                        skin++;
                        if (KrytouSmileBuy == 0)
                        {
                            skin++;
                            if (UkraineBuy == 0)
                            {
                                skin++;
                                if (StetxemBuy == 0)
                                {
                                    skin++;
                                    if (LikeBuy == 0)
                                    {
                                        skin++;
                                        if (DymaetBuy == 0)
                                        {
                                            skin++;
                                            if (MiluyBuy == 0)
                                            {
                                                skin++;
                                                if (PeaceBuy == 0)
                                                {
                                                    skin++;
                                                    if (VShokeBuy == 0)
                                                    {

                                                        skin = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                    PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 2)
            {
                if (SmileBuy == 0)
                {
                        skin++;
                        if (KrytouSmileBuy == 0)
                        {
                            skin++;
                            if (UkraineBuy == 0)
                            {
                                skin++;
                                if (StetxemBuy == 0)
                                {
                                    skin++;
                                    if (LikeBuy == 0)
                                    {
                                        skin++;
                                        if (DymaetBuy == 0)
                                        {
                                            skin++;
                                            if (MiluyBuy == 0)
                                            {
                                                skin++;
                                                if (PeaceBuy == 0)
                                                {
                                                    skin++;
                                                    if (VShokeBuy == 0)
                                                    {

                                                        skin = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        
                        }
                }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 3)
            {
                if (KrytouSmileBuy == 0)
                {
                    skin++;
                    if (UkraineBuy == 0)
                    {
                        skin++;
                        if (StetxemBuy == 0)
                        {
                            skin++;
                            if (LikeBuy == 0)
                            {
                                skin++;
                                if (DymaetBuy == 0)
                                {
                                    skin++;
                                    if (MiluyBuy == 0)
                                    {
                                        skin++;
                                        if (PeaceBuy == 0)
                                        {
                                            skin++;
                                            if (VShokeBuy == 0)
                                            {

                                                skin = 0;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                    PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 4)
            {
                   if (UkraineBuy == 0)
                   {
                    skin++;
                                if (StetxemBuy == 0)
                                {
                                    skin++;
                                    if (LikeBuy == 0)
                                    {
                                        skin++;
                                        if (DymaetBuy == 0)
                                        {
                                            skin++;
                                            if (MiluyBuy == 0)
                                            {
                                                skin++;
                                                if (PeaceBuy == 0)
                                                {
                                                    skin++;
                                                    if (VShokeBuy == 0)
                                                    {

                                                        skin = 0;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                   }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 5)
            {
                    if (StetxemBuy == 0)
                    {
                        skin++;
                        if (LikeBuy == 0)
                        {
                            skin++;
                            if (DymaetBuy == 0)
                            {
                                skin++;
                                if (MiluyBuy == 0)
                                {
                                    skin++;
                                    if (PeaceBuy == 0)
                                    {
                                        skin++;
                                        if (VShokeBuy == 0)
                                        {

                                            skin = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 6)
            {
                    if (LikeBuy == 0)
                    {
                        skin++;
                        if (DymaetBuy == 0)
                        {
                            skin++;
                            if (MiluyBuy == 0)
                            {
                                skin++;
                                if (PeaceBuy == 0)
                                {
                                    skin++;
                                    if (VShokeBuy == 0)
                                    {

                                        skin = 0;
                                    }
                                }
                            }
                        }
                    }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 7)
            {
                
                    if (DymaetBuy == 0)
                    {
                        skin++;
                        if (MiluyBuy == 0)
                        {
                            skin++;
                            if (PeaceBuy == 0)
                            {
                                skin++;
                                if (VShokeBuy == 0)
                                {

                                    skin = 0;
                                }
                            }
                        }
                    }
                
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 8)
            {

                
                    if (MiluyBuy == 0)
                    {
                        skin++;
                        if (PeaceBuy == 0)
                        {
                            skin++;
                            if (VShokeBuy == 0)
                            {

                                skin = 0;
                            }
                        }
                    }
                

                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 9)
            {


            
                    if (PeaceBuy == 0)
                    {
                        skin++;
                        if (VShokeBuy == 0)
                        {

                            skin = 0;
                        }
                    }
                


                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 10)
            {



                
                    if (VShokeBuy == 0)
                    {

                        skin = 0;
                    }
                



                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin > MaxSkins)
            {
                skin = 0;
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
        }
        else
        {
            skin = 0;
        }

        SRForUse = (SpriteRenderer)this.GetType().GetField("sprite" + player.ToString()).GetValue(this);
        if (skin == 0)
        {
            SRForUse.sprite = null;
        }
        else if (skin == 1)
        {
            //this.GetType().GetField("sprite" + player.ToString()).GetValue(this) = Zaez;
            SRForUse.sprite = Zaez;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)3.53, 0);
        }
        else if (skin == 2)
        {
            SRForUse.sprite = Smile;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);

        }
        else if (skin == 3)
        {
            SRForUse.sprite = KrytouSmile;
            SRForUse.transform.localPosition = new Vector3((float)1.07, (float)0.25, 0);

        }
        else if (skin == 4)
        {
            SRForUse.sprite = Ukraine;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);

        }
        else if (skin == 5)
        {
            SRForUse.sprite = Stetxem;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin == 6)
        {
            SRForUse.sprite = Like;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin == 7)
        {
            SRForUse.sprite = Dymaet;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin == 8)
        {
            SRForUse.sprite = Miluy;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin == 9)
        {
            SRForUse.sprite = Peace;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin == 10)
        {
            SRForUse.sprite = VShoke;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        //    if (skin == 0)
        //    {
        //        if (ZaezBuy == 1)
        //        {
        //        skin = 1;
        //        PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
        //        }
        //        else
        //    {
        //        skin++;
        //    }
        //    }
        //if (skin == 1)
        //{
        //    if (ZaezBuy == 1)
        //    {
        //        skin = 1;
        //        PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
        //    }
        //    else
        //    {
        //        skin++;
        //    }
        //}
        //if (skin == skins)
        //    {
        //        skin = 0;
        //        PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
        //    }
        //switch (skin)
        //{
        //    case 1:
        //    if (ZaezBuy == 0)
        //    {
        //        skin++;
        //    }  
        //    if (SmileBuy == 0)
        //    {
        //        skin++;
        //    }  
        //    if (KrytouSmileBuy == 0)
        //    {
        //        skin = 0;
        //    }

        //    break;
        //case 2:
        //    if (SmileBuy == 0)
        //        skin++;
        //}
        //}
    }

    public void ButtonDown(float player)
    {

        float skin = PlayerPrefs.GetFloat("skin" + player.ToString());
        float skins;
        UkraineBuy = PlayerPrefs.GetFloat("UkraineBuy");
        ZaezBuy = PlayerPrefs.GetFloat("ZaezBuy");
        SmileBuy = PlayerPrefs.GetFloat("SmileBuy");
        KrytouSmileBuy = PlayerPrefs.GetFloat("KrytouSmileBuy");
        StetxemBuy = PlayerPrefs.GetFloat("StetxemBuy");
        LikeBuy = PlayerPrefs.GetFloat("LikeBuy");
        DymaetBuy = PlayerPrefs.GetFloat("DymaetBuy");
        MiluyBuy = PlayerPrefs.GetFloat("MiluyBuy");
        PeaceBuy = PlayerPrefs.GetFloat("PeaceBuy");
        VShokeBuy = PlayerPrefs.GetFloat("VShokeBuy");
        skins = ZaezBuy + SmileBuy + KrytouSmileBuy + UkraineBuy + StetxemBuy + LikeBuy + DymaetBuy + MiluyBuy + PeaceBuy + VShokeBuy;
        //if (player == 1)
        //{
        if (skin <= MaxSkins)
        {
            skin--;
            if (skin == -1)
            {
                skin = MaxSkins;
                if (VShokeBuy == 0)
                {
                    skin--;
                    if (PeaceBuy == 0)
                    {
                        skin--;
                        if (MiluyBuy == 0)
                        {
                            skin--;
                            if (DymaetBuy == 0)
                            {
                                skin--;
                                if (LikeBuy == 0)
                                {
                                    skin--;
                                    if (StetxemBuy == 0)
                                    {
                                        skin--;
                                        if (UkraineBuy == 0)
                                        {
                                            skin--;
                                            if (KrytouSmileBuy == 0)
                                            {
                                                skin--;
                                                if (SmileBuy == 0)
                                                {
                                                    skin--;
                                                    if (ZaezBuy == 0)
                                                    {
                                                        skin--;
                                                        //if (KrytouSmileBuy == 0)
                                                        //{
                                                        //    skin = 0;
                                                        //}
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 0)
            {
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 1)
            {
                if (ZaezBuy == 0)
                {
                    skin--;
                    //if (SmileBuy == 0)
                    //{
                    //    skin++;
                    //    if (KrytouSmileBuy == 0)
                    //    {
                    //        skin = 0;
                    //    }
                    //}
                }

                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 2)
            {
                if (SmileBuy == 0)
                {
                    skin--;
                    if (ZaezBuy == 0)
                    {
                        skin--;
                        //if (KrytouSmileBuy == 0)
                        //{
                        //    skin = 0;
                        //}
                    }
                }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 3)
            {
                if (KrytouSmileBuy == 0)
                {
                    skin--;
                    if (SmileBuy == 0)
                    {
                        skin--;
                        if (ZaezBuy == 0)
                        {
                            skin--;
                            //if (KrytouSmileBuy == 0)
                            //{
                            //    skin = 0;
                            //}
                        }
                    }
                }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 4)
            {
                if (UkraineBuy == 0)
                {
                    skin--;
                    if (KrytouSmileBuy == 0)
                    {
                        skin--;
                        if (SmileBuy == 0)
                        {
                            skin--;
                            if (ZaezBuy == 0)
                            {
                                skin--;
                                //if (KrytouSmileBuy == 0)
                                //{
                                //    skin = 0;
                                //}
                            }
                        }
                    }
                }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 5)
            {
                if (StetxemBuy == 0)
                {
                    skin--;
                    if (UkraineBuy == 0)
                    {
                        skin--;
                        if (KrytouSmileBuy == 0)
                        {
                            skin--;
                            if (SmileBuy == 0)
                            {
                                skin--;
                                if (ZaezBuy == 0)
                                {
                                    skin--;
                                    //if (KrytouSmileBuy == 0)
                                    //{
                                    //    skin = 0;
                                    //}
                                }
                            }
                        }
                    }
                }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 6)
            {
                if (LikeBuy == 0)
                {
                    skin--;
                    if (StetxemBuy == 0)
                    {
                        skin--;
                        if (UkraineBuy == 0)
                        {
                            skin--;
                            if (KrytouSmileBuy == 0)
                            {
                                skin--;
                                if (SmileBuy == 0)
                                {
                                    skin--;
                                    if (ZaezBuy == 0)
                                    {
                                        skin--;
                                        //if (KrytouSmileBuy == 0)
                                        //{
                                        //    skin = 0;
                                        //}
                                    }
                                }
                            }
                        }
                    }
                }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 7)
            {
                if (DymaetBuy == 0)
                {
                    skin--;
                    if (LikeBuy == 0)
                    {
                        skin--;
                        if (StetxemBuy == 0)
                        {
                            skin--;
                            if (UkraineBuy == 0)
                            {
                                skin--;
                                if (KrytouSmileBuy == 0)
                                {
                                    skin--;
                                    if (SmileBuy == 0)
                                    {
                                        skin--;
                                        if (ZaezBuy == 0)
                                        {
                                            skin--;
                                            //if (KrytouSmileBuy == 0)
                                            //{
                                            //    skin = 0;
                                            //}
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 8)
            {
                if (MiluyBuy == 0)
                {
                    skin--;
                    if (DymaetBuy == 0)
                    {
                        skin--;
                        if (LikeBuy == 0)
                        {
                            skin--;
                            if (StetxemBuy == 0)
                            {
                                skin--;
                                if (UkraineBuy == 0)
                                {
                                    skin--;
                                    if (KrytouSmileBuy == 0)
                                    {
                                        skin--;
                                        if (SmileBuy == 0)
                                        {
                                            skin--;
                                            if (ZaezBuy == 0)
                                            {
                                                skin--;
                                                //if (KrytouSmileBuy == 0)
                                                //{
                                                //    skin = 0;
                                                //}
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 9)
            {
                    if (PeaceBuy == 0)
                    {
                        skin--;
                        if (MiluyBuy == 0)
                        {
                            skin--;
                            if (DymaetBuy == 0)
                            {
                                skin--;
                                if (LikeBuy == 0)
                                {
                                    skin--;
                                    if (StetxemBuy == 0)
                                    {
                                        skin--;
                                        if (UkraineBuy == 0)
                                        {
                                            skin--;
                                            if (KrytouSmileBuy == 0)
                                            {
                                                skin--;
                                                if (SmileBuy == 0)
                                                {
                                                    skin--;
                                                    if (ZaezBuy == 0)
                                                    {
                                                        skin--;
                                                        //if (KrytouSmileBuy == 0)
                                                        //{
                                                        //    skin = 0;
                                                        //}
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin == 10)
            {
                if (VShokeBuy == 0)
                {
                    skin--;
                    if (PeaceBuy == 0)
                    {
                        skin--;
                        if (MiluyBuy == 0)
                        {
                            skin--;
                            if (DymaetBuy == 0)
                            {
                                skin--;
                                if (LikeBuy == 0)
                                {
                                    skin--;
                                    if (StetxemBuy == 0)
                                    {
                                        skin--;
                                        if (UkraineBuy == 0)
                                        {
                                            skin--;
                                            if (KrytouSmileBuy == 0)
                                            {
                                                skin--;
                                                if (SmileBuy == 0)
                                                {
                                                    skin--;
                                                    if (ZaezBuy == 0)
                                                    {
                                                        skin--;
                                                        //if (KrytouSmileBuy == 0)
                                                        //{
                                                        //    skin = 0;
                                                        //}
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
            else if (skin > MaxSkins)
            {
                skin = 0;
                PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
            }
        }
        else
        {
            //skin = 0;
        }

        //float skin = PlayerPrefs.GetFloat("skin" + player.ToString());
        //float skins;
        ////KrytouSmileBuy = PlayerPrefs.GetFloat("KrytouSmileBuy");
        //skins = ZaezBuy + SmileBuy + KrytouSmileBuy;
        ////if (player == 1)
        ////{

        //if (skin > 0)
        //{
        //    skin--;
        //    PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
        //}
        //else if (skin == 0)
        //{
        //    skin = skins;
        //    PlayerPrefs.SetFloat("skin" + player.ToString(), skin);
        //}

        SRForUse = (SpriteRenderer)this.GetType().GetField("sprite" + player.ToString()).GetValue(this);

            if (skin == 0)
            {
                SRForUse.sprite = null;
            }
            else if (skin == 1)
            {
                SRForUse.sprite = Zaez;
                SRForUse.transform.localPosition = new Vector3((float)0, (float)3.53, 0);
        }
            else if (skin == 2)
            {
                SRForUse.sprite = Smile;
                SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);

        }
        else if (skin == 3)
        {
            SRForUse.sprite = KrytouSmile;
            SRForUse.transform.localPosition = new Vector3((float)1.07, (float)0.25, 0);

        }
        else if (skin == 4)
        {
            SRForUse.sprite = Ukraine;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);

        }
        else if (skin == 5)
        {
            SRForUse.sprite = Stetxem;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin == 6)
        {
            SRForUse.sprite = Like;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin == 7)
        {
            SRForUse.sprite = Dymaet;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin == 8)
        {
            SRForUse.sprite = Miluy;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin == 9)
        {
            SRForUse.sprite = Peace;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        else if (skin == 10)
        {
            SRForUse.sprite = VShoke;
            SRForUse.transform.localPosition = new Vector3((float)0, (float)0, 0);
        }
        //}
    }

}
