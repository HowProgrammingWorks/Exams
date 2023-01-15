using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblesHUD : MonoBehaviour
{
    [SerializeField] GameObject BubbleN1;
    [SerializeField] GameObject BubbleN2;
    [SerializeField] GameObject BubbleN3;
    [SerializeField] SpriteRenderer BubbleN1SpriteRend;
    [SerializeField] SpriteRenderer BubbleN2SpriteRend;
    [SerializeField] SpriteRenderer BubbleN3SpriteRend;
    [SerializeField] float HMRounds1;
    [SerializeField] float HMRounds2;
    [SerializeField] float HMRounds3;
    [SerializeField] float CurrentPlace = 1;
    [SerializeField] Material text0;
    [SerializeField] float x1;
    [SerializeField] float x2;
    [SerializeField] float x3;
    [SerializeField] Sprite odin;
    [SerializeField] Sprite DvaKTrem;
    [SerializeField] Sprite odinKTrem;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Bubble(float CardCode, float rarity, float HMRounds)
    {
        if (CurrentPlace == 1)
        {
            BubbleN1 = gameObject.transform.GetChild(0).gameObject;
            HMRounds1 = HMRounds;
            if (HMRounds == 2)
            {
                BubbleN1SpriteRend.sprite = DvaKTrem;
            }
            else if (HMRounds == 1)
            {
                BubbleN1SpriteRend.sprite = odinKTrem;
            }
            if (rarity == 2)
            {
                BubbleN1SpriteRend.color = new Color((float)0, (float)0.566, (float)0.090);
            }
            else if (rarity == 3)
            {
                BubbleN1SpriteRend.color = new Color((float)0.086, (float)0.114, (float)0.471);
            }
            else if (rarity == 4)
            {
                BubbleN1SpriteRend.color = new Color((float)0.298, (float)0.243, (float)0.463);
            }
            else if (rarity == 5)
            {
                BubbleN1SpriteRend.color = new Color((float)0.784, (float)0.431, (float)0);
            }
            else if (rarity == 6)
            {
                BubbleN1SpriteRend.color = new Color((float)1, (float)0.843, (float)0);
                BubbleN1SpriteRend.material = text0;
            }
            else if (rarity == 7)
            {
                BubbleN1SpriteRend.color = new Color((float)0.918, (float)0.329, (float)0.306);
                BubbleN1SpriteRend.material = text0;
            }

            switch (CardCode)
            {
                case 1:
                    
                    BubbleN1.transform.GetChild(0).gameObject.SetActive(true);
                    BubbleN1.SetActive(true);
                    break;
                case 2:

                    BubbleN1.transform.GetChild(1).gameObject.SetActive(true);
                    BubbleN1.SetActive(true);
                    break;
                case 3:

                    BubbleN1.transform.GetChild(2).gameObject.SetActive(true);
                    BubbleN1.SetActive(true);
                    break;
                case 5:

                    BubbleN1.transform.GetChild(4).gameObject.SetActive(true);
                    BubbleN1.SetActive(true);
                    break;
                case 7:

                    //BubbleN1.transform.GetChild(4).gameObject.SetActive(true);
                    BubbleN1.SetActive(true);
                    break;
                case 8:

                    //BubbleN1.transform.GetChild(4).gameObject.SetActive(true);
                    BubbleN1.SetActive(true);
                    break;
            }

            CurrentPlace++;
        }
        else if (CurrentPlace == 2)
        {
            BubbleN1 = gameObject.transform.GetChild(0).gameObject;
            BubbleN2 = gameObject.transform.GetChild(1).gameObject;
            HMRounds2 = HMRounds;
            if (HMRounds == 2)
            {
                BubbleN2SpriteRend.sprite = DvaKTrem;
            }
            else if (HMRounds == 1)
            {
                BubbleN2SpriteRend.sprite = odinKTrem;
            }
            if (HMRounds1 < HMRounds2)
            {
                float x1 = BubbleN1.transform.localPosition.x;
                float x2 = BubbleN2.transform.localPosition.x;
                BubbleN1.transform.localPosition = new Vector3(x2, BubbleN1.transform.localPosition.y, BubbleN1.transform.localPosition.z);
                BubbleN2.transform.localPosition = new Vector3(x1, BubbleN2.transform.localPosition.y, BubbleN2.transform.localPosition.z);
            }
            if (rarity == 2)
            {
                BubbleN2SpriteRend.color = new Color((float)0, (float)0.566, (float)0.090);
            }
            else if (rarity == 3)
            {
                BubbleN2SpriteRend.color = new Color((float)0.086, (float)0.114, (float)0.471);
            }
            else if (rarity == 4)
            {
                BubbleN2SpriteRend.color = new Color((float)0.298, (float)0.243, (float)0.463);
            }
            else if (rarity == 5)
            {
                BubbleN2SpriteRend.color = new Color((float)0.784, (float)0.431, (float)0);
            }
            else if (rarity == 6)
            {
                BubbleN2SpriteRend.color = new Color((float)1, (float)0.843, (float)0);
                BubbleN2SpriteRend.material = text0;
            }
            else if (rarity == 7)
            {
                BubbleN2SpriteRend.color = new Color((float)0.918, (float)0.329, (float)0.306);
                BubbleN2SpriteRend.material = text0;
            }

            switch (CardCode)
            {
                case 1:

                    BubbleN2.transform.GetChild(0).gameObject.SetActive(true);
                    BubbleN2.SetActive(true);
                    break;
                case 2:

                    BubbleN2.transform.GetChild(1).gameObject.SetActive(true);
                    BubbleN2.SetActive(true);
                    break;
                case 3:

                    BubbleN2.transform.GetChild(2).gameObject.SetActive(true);
                    BubbleN2.SetActive(true);
                    break;
                case 5:

                    BubbleN2.transform.GetChild(4).gameObject.SetActive(true);
                    BubbleN2.SetActive(true);
                    break;
                case 7:

                    //BubbleN2.transform.GetChild(4).gameObject.SetActive(true);
                    BubbleN2.SetActive(true);
                    break;
                case 8:

                    //BubbleN1.transform.GetChild(4).gameObject.SetActive(true);
                    BubbleN1.SetActive(true);
                    break;
            }
            CurrentPlace++;
        }
        else if (CurrentPlace == 3)
        {
            BubbleN1 = gameObject.transform.GetChild(0).gameObject;
            BubbleN2 = gameObject.transform.GetChild(1).gameObject;
            BubbleN3 = gameObject.transform.GetChild(2).gameObject;
            HMRounds3 = HMRounds;
            if (HMRounds == 2)
            {
                BubbleN3SpriteRend.sprite = DvaKTrem;
            }
            else if (HMRounds == 1)
            {
                BubbleN3SpriteRend.sprite = odinKTrem;
            }
            if (HMRounds1 < HMRounds3 && HMRounds3 > HMRounds2)
            {
                //float x1 = BubbleN1.transform.localPosition.x;
                //float x2 = BubbleN2.transform.localPosition.x;
                //float x3 = BubbleN3.transform.localPosition.x;
                //BubbleN1.transform.localPosition = new Vector3(x2, BubbleN1.transform.localPosition.y, BubbleN1.transform.localPosition.z);
                //BubbleN2.transform.localPosition = new Vector3(x1, BubbleN2.transform.localPosition.y, BubbleN2.transform.localPosition.z);
                BubbleN1.transform.localPosition = new Vector3(x2, BubbleN1.transform.localPosition.y, BubbleN1.transform.localPosition.z);
                BubbleN2.transform.localPosition = new Vector3(x3, BubbleN2.transform.localPosition.y, BubbleN2.transform.localPosition.z);
                if (HMRounds1 < HMRounds2)
                {
                    float x1 = BubbleN1.transform.localPosition.x;
                    float x2 = BubbleN2.transform.localPosition.x;
                    BubbleN1.transform.localPosition = new Vector3(x2, BubbleN1.transform.localPosition.y, BubbleN1.transform.localPosition.z);
                    BubbleN2.transform.localPosition = new Vector3(x1, BubbleN2.transform.localPosition.y, BubbleN2.transform.localPosition.z);
                }
                BubbleN3.transform.localPosition = new Vector3(x1, BubbleN3.transform.localPosition.y, BubbleN3.transform.localPosition.z);
            }
            if ((HMRounds1 < HMRounds3 && HMRounds3 < HMRounds2) || (HMRounds1 > HMRounds3 && HMRounds3 < HMRounds2))
            {
                BubbleN1.transform.localPosition = new Vector3(x1, BubbleN1.transform.localPosition.y, BubbleN1.transform.localPosition.z);
                BubbleN2.transform.localPosition = new Vector3(x3, BubbleN2.transform.localPosition.y, BubbleN2.transform.localPosition.z);
                if (HMRounds1 < HMRounds2)
                {
                    float x1 = BubbleN1.transform.localPosition.x;
                    float x2 = BubbleN2.transform.localPosition.x;
                    BubbleN1.transform.localPosition = new Vector3(x2, BubbleN1.transform.localPosition.y, BubbleN1.transform.localPosition.z);
                    BubbleN2.transform.localPosition = new Vector3(x1, BubbleN2.transform.localPosition.y, BubbleN2.transform.localPosition.z);
                }
                BubbleN3.transform.localPosition = new Vector3(x2, BubbleN3.transform.localPosition.y, BubbleN3.transform.localPosition.z);
            }

            if (rarity == 2)
            {
                BubbleN3SpriteRend.color = new Color((float)0, (float)0.566, (float)0.090);
            }
            else if (rarity == 3)
            {
                BubbleN3SpriteRend.color = new Color((float)0.086, (float)0.114, (float)0.471);
            }
            else if (rarity == 4)
            {
                BubbleN3SpriteRend.color = new Color((float)0.298, (float)0.243, (float)0.463);
            }
            else if (rarity == 5)
            {
                BubbleN3SpriteRend.color = new Color((float)0.784, (float)0.431, (float)0);
            }
            else if (rarity == 6)
            {
                BubbleN3SpriteRend.color = new Color((float)1, (float)0.843, (float)0);
                BubbleN3SpriteRend.material = text0;
            }
            else if (rarity == 7)
            {
                BubbleN3SpriteRend.color = new Color((float)0.918, (float)0.329, (float)0.306);
                BubbleN3SpriteRend.material = text0;
            }
            switch (CardCode)
            {
                case 1:

                    BubbleN3.transform.GetChild(0).gameObject.SetActive(true);
                    BubbleN3.SetActive(true);
                    break;
                case 2:

                    BubbleN3.transform.GetChild(1).gameObject.SetActive(true);
                    BubbleN3.SetActive(true);
                    break;
                case 3:

                    BubbleN3.transform.GetChild(2).gameObject.SetActive(true);
                    BubbleN3.SetActive(true);
                    break;
                case 5:

                    BubbleN3.transform.GetChild(4).gameObject.SetActive(true);
                    BubbleN3.SetActive(true);
                    break;
                case 7:

                    //BubbleN3.transform.GetChild(4).gameObject.SetActive(true);
                    BubbleN3.SetActive(true);
                    break;
                case 8:

                    //BubbleN1.transform.GetChild(4).gameObject.SetActive(true);
                    BubbleN1.SetActive(true);
                    break;
            }

            CurrentPlace++;

        }

    }
}
