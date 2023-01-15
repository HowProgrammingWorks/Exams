//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
//using UnityEngine.EventSystems;
//using UnityEngine.UI; 
//using UnityEngine.Diagnostics;

public class CirclesMovement : MonoBehaviour
{
	public int Player;
	public float normalSpeed = 10f;
	public float normalSpeedUp = 10f;
	[SerializeField] float h;
	[SerializeField] float v;
	[SerializeField] float hss = 0f;
	[SerializeField] float hssu = 0f;
	float vs;
	float vsU;
	private float ygol;
	float XvelI;
	float YvelI;
	Rigidbody2D rb;
	Transform T;
	//private Rigidbody2D rbO;
	[SerializeField] private float playerID;
	//public GameObject Camera;
	public CirclesMovement scriptPlayerController;
	//private bool isMine;
	public float PublicCircle;
	[SerializeField] float circle;
	[SerializeField] bool rightCollision = true;
	float ns;
	float nsU;
	float SpeedTime1;
	float SpeedTime2 = 0;
	[SerializeField] private Joystick joystick;
	[SerializeField] bool alreadyImpulse;
	public bool alreadyImpulsePlayer;
	float vsYgol;
	float vsUYgol;
	public SpawnManager SM;
	bool ImpulsePolAfter;
	public float SP1;
	public float SP2;
	public float SP3;
	public float SP4;
	public bool Alive = true;
	bool alreadyScore = false;
	bool Yskoritel;
	[SerializeField] private GameObject DNC;
	//public float F;
	public float HMM;
	public string gamemode;
	public CirclesMovement p1;
	public CirclesMovement p2;
	public CirclesMovement p3;
	public GameObject ScoreN;
	public string LastName;
	public GameObject PTrigger;
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
	public SpriteRenderer SkinRender;
	public GameObject Trail;
	public float Freezing;
	public float Energizer;
	public float Bouncy;
	public float Takealookaround;
	public float FriendOfGlass;
	public float WaveSpeed;
	public float TripleTake;
	public float HMRFreezing;
	public float HMREnergizer;
	public float HMRBouncy;
	public float HMRTakealookaround;
	public float HMRFriendOfGlass;
	public float HMRWaveSpeed;
	public float HMRTripleTake;
	//public float FriendOfGlass;
	public float FreezingTime = (float)0.5;
	public float FreezingMult = 1;
	public float FreezingMultSaved = 1;
	public float FreezingColor = 1;
	public float MaxSpeed = 1;
	public float Acceleration = 1;
	public float BouncyForce = 1;
	public float BouncySelfForce = 1;
	public float TakealookaroundTime = 1;
	public float TakealookaroundMaxSpeed = 1;
	public float TakealookaroundAcc = 1;
	public float WaveSpeedModifier = 1;
	public float WaveScaleSpeedModifier = 1;
	Shoot currentShootScript;

	float coroutine;
	public bool FreezingBool;
	public float velocityXAfter;
	public float velocityYAfter;
	public CameraScript CS;
	public List<GameObject> childrenList2 = new List<GameObject>();
	[SerializeField] SpriteRenderer ThisSpriteRendrer;
	[SerializeField] CircleCollider2D ThisCircleCollider2D;
	public float HMPlayersF;
	float CardsAfterMonetu;
	public FrostEffect FrostEffectScript;
	public BubblesHUD Bubbles;
	public GameObject Shoot;
	public GameObject ShootTransform;
	public GameObject Shoot2Transform;
	public GameObject Shoot3Transform;
	public float ShootTime;
	public bool ShootOneTime = false;
	public Rigidbody2D ShootRB;
	public UnityEngine.UI.Slider Slider;
	public UnityEngine.UI.Image SliderFill;

	public Color color;
	//public float HMM;
	//public Transform[] childrenList;
	//public bool PCT;
	//public Rigidbody2D PCTG;
	//public RGear
	//RaycastHit2D[] hits;
	//public Collider2D playerCollider;
	//public ContactFilter2D filter;
	//public GameObject MyCircle;
	//public GameObject gameObject;
	// Start is called before the first frame update
	void Start()
	{
		CardsAfterMonetu = PlayerPrefs.GetFloat("CardsAfterMonetu");
		if (CardsAfterMonetu == 1)
        {
			Cards(true);
        }
		HMPlayersF = PlayerPrefs.GetFloat("HMPlayersF");
		if (HMPlayersF == 0)
		{
			HMPlayersF = 2;
			PlayerPrefs.SetFloat("HMPlayersF", 2);
		}

		List<Transform> childrenList = new List<Transform>();
		foreach (Transform childTrans in transform)
			childrenList.Add(childTrans);
		//Goes through the list assigning parents
		foreach (Transform childTrans in childrenList)
		{
			if (childTrans.tag == "Bullet")
			{
				childTrans.GetComponent<PieceExplosion>().rb = childTrans.GetComponent<Rigidbody2D>();
			}
			//else if (childTrans.gameObject.name == "newCircle2")
			//{
			//	childTrans.parent = null;
			//}
		}
		//Physics.IgnoreLayerCollision(6, 7, true);
		MaxSpeed = 1;
		Acceleration = 1;
		BouncyForce = 1;
		BouncySelfForce = 1;
		TakealookaroundTime = 1;
		TakealookaroundMaxSpeed = 1;
		TakealookaroundAcc = 1;
		FreezingMult = 1;
	//Trail = GetComponent<TrailRenderer>();
		float skin = PlayerPrefs.GetFloat("skin" + Player.ToString());
		if (skin == 1)
        {
			SkinRender.sprite = Zaez;
			SkinRender.flipX = true;
			SkinRender.transform.localPosition = new Vector3((float)-3.48, (float)0, 0);
        }
		else if (skin == 2)
        {
			SkinRender.sprite = Smile;
			SkinRender.flipX = false;
			SkinRender.transform.localPosition = new Vector3((float)0, (float)0, 0);
			//SkinRender.transform.position = this.transform.position;
		}
		else if (skin == 3)
		{
			SkinRender.sprite = KrytouSmile;
			SkinRender.flipX = false;
			SkinRender.transform.localPosition = new Vector3((float)-0.34, (float)1.12, 0);

			//SkinRender.transform.position = this.transform.position;
		}
		else if (skin == 4)
		{
			SkinRender.sprite = Ukraine;
			SkinRender.flipX = false;
			SkinRender.transform.localPosition = new Vector3((float)0, (float)0, 0);

			//SkinRender.transform.position = this.transform.position;
		}
		else if (skin == 5)
		{
			SkinRender.sprite = Stetxem;
			SkinRender.flipX = false;
			SkinRender.transform.localPosition = new Vector3((float)0, (float)0, 0);
		}
		else if (skin == 6)
		{
			SkinRender.sprite = Like;
			SkinRender.flipX = true;
			SkinRender.transform.localPosition = new Vector3((float)0, (float)0, 0);
		}
		else if (skin == 7)
		{
			SkinRender.sprite = Dymaet;
			SkinRender.flipX = true;
			SkinRender.transform.localPosition = new Vector3((float)0, (float)0, 0);
		}
		else if (skin == 8)
		{
			SkinRender.sprite = Miluy;
			SkinRender.flipX = true;
			SkinRender.transform.localPosition = new Vector3((float)0, (float)0, 0);
		}
		else if (skin == 9)
		{
			SkinRender.sprite = Peace;
			SkinRender.flipX = false;
			SkinRender.transform.localPosition = new Vector3((float)0, (float)0, 0);
		}
		else if (skin == 10)
		{
			SkinRender.sprite = VShoke;
			SkinRender.flipX = false;
			SkinRender.transform.localPosition = new Vector3((float)0, (float)0, 0);
		}

		//if (Player == 1)
		//{
		color = new Color(PlayerPrefs.GetFloat("Circle" + Player.ToString() + ".r"), PlayerPrefs.GetFloat("Circle" + Player.ToString() + ".g"), PlayerPrefs.GetFloat("Circle" + Player.ToString() + ".b"), 1);
			DNC.GetComponent<SpriteRenderer>().color = color;
			ScoreN.GetComponent<SpriteRenderer>().color = color;
			SliderFill.color = color;
		Gradient gradient = new Gradient();
			gradient.SetKeys(
				new GradientColorKey[] { new GradientColorKey(new Color(PlayerPrefs.GetFloat("Circle" + Player.ToString() + ".r"), PlayerPrefs.GetFloat("Circle" + Player.ToString() + ".g"), PlayerPrefs.GetFloat("Circle" + Player.ToString() + ".b"), 1), 0.0f), new GradientColorKey(Color.black, 1.0f) },
				new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(1, 1.0f) }
			);
			Trail.GetComponent<TrailRenderer>().colorGradient = gradient;
			//joystick.GetComponent<Unity.UI.Ima>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 135);
			//joystick.transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle1.r"), PlayerPrefs.GetFloat("Circle1.g"), PlayerPrefs.GetFloat("Circle1.b"), 135);
		//}
		//else if (Player == 2)
		//{
		//	DNC.GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
		//	ScoreN.GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1);
		//	Gradient gradient = new Gradient();
		//	gradient.SetKeys(
		//		new GradientColorKey[] { new GradientColorKey(new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 1), 0.0f), new GradientColorKey(Color.black, 1.0f) },
		//		new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(1, 1.0f) }
		//	);
		//	Trail.GetComponent<TrailRenderer>().colorGradient = gradient;
		//	//joystick.GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 135);
		//	//joystick.transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle2.r"), PlayerPrefs.GetFloat("Circle2.g"), PlayerPrefs.GetFloat("Circle2.b"), 135);
		//}
		//else if (Player == 3)
		//{
		//	DNC.GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
		//	ScoreN.GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1);
		//	Gradient gradient = new Gradient();
		//	gradient.SetKeys(
		//		new GradientColorKey[] { new GradientColorKey(new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 1), 0.0f), new GradientColorKey(Color.black, 1.0f) },
		//		new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(1, 1.0f) }
		//	);
		//	Trail.GetComponent<TrailRenderer>().colorGradient = gradient;
		//	//joystick.GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 135);
		//	//joystick.transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle3.r"), PlayerPrefs.GetFloat("Circle3.g"), PlayerPrefs.GetFloat("Circle3.b"), 135);
		//}
		//else if (Player == 4)
		//{
		//	DNC.GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);
		//	ScoreN.GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1);
		//	Gradient gradient = new Gradient();
		//	gradient.SetKeys(
		//		new GradientColorKey[] { new GradientColorKey(new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 1), 0.0f), new GradientColorKey(Color.black, 1.0f) },
		//		new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(1, 1.0f) }
		//	);
		//	Trail.GetComponent<TrailRenderer>().colorGradient = gradient;
		//	//joystick.GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 135);
		//	//joystick.transform.GetChild(0).GetComponent<SpriteRenderer>().color = new Color(PlayerPrefs.GetFloat("Circle4.r"), PlayerPrefs.GetFloat("Circle4.g"), PlayerPrefs.GetFloat("Circle4.b"), 135);
		//}

		//Cards();
	}
	private void Awake()
    {
		rb = GetComponent<Rigidbody2D>();
		T = GetComponent<Transform>();
		//SM = (SpawnManager)FindObjectOfType(typeof(SpawnManager));
		SM = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
		SP1 = PlayerPrefs.GetFloat("SP1");
		SP2 = PlayerPrefs.GetFloat("SP2");
		SP3 = PlayerPrefs.GetFloat("SP3");
		SP4 = PlayerPrefs.GetFloat("SP4");
		
		//F = Random.Range(50f, 1000f);
		//playerCollider = GetComponent<CircleCollider2D>();
	}

    private void LateUpdate()
    {
		alreadyImpulse = false;
		//alreadyImpulsePlayer = false;
		Yskoritel = true;
		//PCT = false;
	}

	IEnumerator TakeaLookAround()
	{
		//print(Time.time);
		//coroutine = 0;
		yield return new WaitForSeconds(5*TakealookaroundTime);
		Takealookaround = 0;
		TakealookaroundAcc = 1;
		TakealookaroundMaxSpeed = 1;
		TakealookaroundTime = 1;
		//Trail.SetActive(false);
		//print(Time.time);

	}

	IEnumerator Example()
	{
		//print(Time.time);
		coroutine = 0;
		yield return new WaitForSeconds(1);
		Trail.SetActive(false);
		//print(Time.time);
		
	}

	public IEnumerator Freeze(float ft, CirclesMovement cm, float fms, float color)
	{
		//cm.FreezingBool = true;
		//if (cm.FreezingBool == false)
        //{
			cm.FreezingMult = fms;
			cm.hss = cm.hss / (float)2*(fms+1);
			cm.hssu = cm.hssu / (float)2*(fms+1);
			cm.gameObject.GetComponent<SpriteRenderer>().color = new Color(color, 255, 255, 255);
			FrostEffectScript.FrostAmount = (1 - (float)color) * (float)0.7;
			FrostEffectScript.enabled = true;
			yield return new WaitForSeconds(ft);
			cm.FreezingMult = 1;
			cm.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
			FrostEffectScript.FrostAmount = 0;
			FrostEffectScript.enabled = false;
			cm.FreezingBool = false;
		//}
		
		
		
		//cm.FreezingBool = false;
	}

	// Update is called once per frame
	void Update()
    {

		//if (FreezingBool)
		//      {
		//	normalSpeed = 0f;
		//	normalSpeed = 0f;
		//}

		//Debug.DrawLine(transform.position, new Vector2(ns, nsU));
		if (Slider.value < 0.1f)
        {
			Slider.gameObject.SetActive(false);
        }
		else
        {
			Slider.gameObject.SetActive(true);
		}

		if (ShootTime <= 5f)
        {
			Slider.value = ShootTime;
			SliderFill.color = color;
		}
		else
        {
			SliderFill.color = new Color(1, 0.843f, 0); 

		}

		if (hss == 0 && hssu == 0  && rb.velocity == new Vector2(0, 0) && ShootTime > 5f && ShootOneTime == false)
        {
			ShootOneTime = true;
			ShootTime = ShootTime - 5f;

			if (TripleTake == 0)
			{
				GameObject SH = Instantiate(Shoot, ShootTransform.transform);
				currentShootScript = SH.GetComponent<Shoot>();
				currentShootScript.SpeedModifier = WaveSpeedModifier;
				currentShootScript.ScaleSpeedModifier = WaveScaleSpeedModifier;

				Physics2D.IgnoreCollision(SH.GetComponent<BoxCollider2D>(), ThisCircleCollider2D);
				Physics2D.IgnoreCollision(SH.GetComponent<BoxCollider2D>(), DNC.GetComponent<CircleCollider2D>());
			}
			else if (TripleTake > 0)
			{

				GameObject SH = Instantiate(Shoot, ShootTransform.transform);
				SH.GetComponent<Rigidbody2D>().isKinematic = true;
				currentShootScript = SH.GetComponent<Shoot>();
				currentShootScript.SpeedModifier = WaveSpeedModifier;
				//currentShootScript.ScaleSpeedModifier = 0;
				Physics2D.IgnoreCollision(SH.GetComponent<BoxCollider2D>(), ThisCircleCollider2D);
				Physics2D.IgnoreCollision(SH.GetComponent<BoxCollider2D>(), DNC.GetComponent<CircleCollider2D>());

				GameObject SH2 = Instantiate(Shoot, Shoot2Transform.transform);
				SH2.GetComponent<Rigidbody2D>().isKinematic = true;
				//SH2.transform.rotation = Quaternion.Euler(0, 0, SH2.transform.rotation.z - 25);
				currentShootScript = SH2.GetComponent<Shoot>();
				currentShootScript.SpeedModifier = WaveSpeedModifier;
				//currentShootScript.ScaleSpeedModifier = 0;
				Physics2D.IgnoreCollision(SH2.GetComponent<BoxCollider2D>(), ThisCircleCollider2D);
				Physics2D.IgnoreCollision(SH2.GetComponent<BoxCollider2D>(), DNC.GetComponent<CircleCollider2D>());

				GameObject SH3 = Instantiate(Shoot, Shoot3Transform.transform);
				SH3.GetComponent<Rigidbody2D>().isKinematic = true;
				//SH3.transform.rotation = Quaternion.Euler(0, 0, SH3.transform.rotation.z + 25);
				currentShootScript = SH3.GetComponent<Shoot>();
				currentShootScript.SpeedModifier = WaveSpeedModifier;
				//currentShootScript.ScaleSpeedModifier = 0;
				Physics2D.IgnoreCollision(SH3.GetComponent<BoxCollider2D>(), ThisCircleCollider2D);
				Physics2D.IgnoreCollision(SH3.GetComponent<BoxCollider2D>(), DNC.GetComponent<CircleCollider2D>());

				Physics2D.IgnoreCollision(SH.GetComponent<BoxCollider2D>(), SH2.GetComponent<BoxCollider2D>());
				Physics2D.IgnoreCollision(SH2.GetComponent<BoxCollider2D>(), SH3.GetComponent<BoxCollider2D>());
				Physics2D.IgnoreCollision(SH.GetComponent<BoxCollider2D>(), SH3.GetComponent<BoxCollider2D>());

				SH.GetComponent<Rigidbody2D>().isKinematic = false;
				SH2.GetComponent<Rigidbody2D>().isKinematic = false;
				SH3.GetComponent<Rigidbody2D>().isKinematic = false;

			}
			//SH.GetComponent<Shoot>().PlayerShoot = Player;
		}

		if ((normalSpeed > 4f || normalSpeedUp > 4f || normalSpeed < 4f || normalSpeedUp < 4f) && (normalSpeed != 0 || normalSpeedUp != 0))
        {
			ShootTime = ShootTime + 1.5f * Time.deltaTime;
			ShootOneTime = false;

		}

		if (((((joystick.Horizontal > 0f || joystick.Horizontal < 0f) || (joystick.Vertical > 0f || joystick.Vertical < 0f)) && hss < (15f * MaxSpeed * TakealookaroundMaxSpeed * FreezingMult) && hssu < (15f * MaxSpeed * TakealookaroundMaxSpeed * FreezingMult))) && (hss > 6f && hssu > 6f))
        {
			SpeedTime1 = SpeedTime1 + 1 * Time.deltaTime;
			if ((SpeedTime1 > SpeedTime2))
			{
				SpeedTime2 = SpeedTime2 + 10f * Time.deltaTime;
				//SpeedTime2 = SpeedTime2 * Acceleration;
				hss = hss + 25f * Acceleration * TakealookaroundAcc * FreezingMult * Time.deltaTime;
				hssu = hssu + 25f * Acceleration * TakealookaroundAcc * FreezingMult * Time.deltaTime;
			}
		}
		else if (((joystick.Horizontal > 0f || joystick.Horizontal < 0f) || (joystick.Vertical > 0f || joystick.Vertical < 0f)) && (hss <= 6f && hssu <= 6f))
        {
			SpeedTime1 = SpeedTime1 + 1 * Time.deltaTime;
			if ((SpeedTime1 > SpeedTime2))
			{
				SpeedTime2 = SpeedTime2 + 10f * Time.deltaTime;
				//SpeedTime2 = SpeedTime2 * Acceleration;
				hss = hss + 100f * Acceleration * TakealookaroundAcc * FreezingMult * Time.deltaTime;
				hssu = hssu + 100f * Acceleration * TakealookaroundAcc * FreezingMult * Time.deltaTime;
			}
		}

		if (hss > 14f && hssu > 14f && Alive)
        {
			//GetComponent<TrailRenderer>().enabled = true;
			Trail.transform.position = transform.position;
			Trail.SetActive(true);
			if (coroutine == 0)
            {
				coroutine = 1;
			}
		}
		else
        {
			if (coroutine == 1)
            {
				StartCoroutine(Example());
			}


		}
		//else if (Trail.)
  //      {
		//	GetComponent<TrailRenderer>().enabled = false;
		//}

		if (((joystick.Horizontal == 0f || joystick.Horizontal == 0f) && (joystick.Vertical == 0f || joystick.Vertical == 0f)))
		{
			hss = 0f;
			hssu = 0f;
		}

		//if (T.position.x > 15 || T.position.x < -15 || T.position.y > 9 || T.position.y < -9)
  //      {
		//	Destroy();
  //      }

		

		//if (isMine)
		//{
		RunPC();
		
		//AddScore();
		//}
		//if (ns > 0f || nsU > 0f)
		//      {
		//	if (ns > 0f && nsU == 0f)
		//	{
		//		rb.AddForce(transform.right * ns * 10, ForceMode2D.Impulse);
		//	}
		//	else if (nsU > 0f && ns == 0f)
		//	{
		//		rb.AddForce(transform.up * nsU * 10, ForceMode2D.Impulse);
		//	}
		//	else if (ns < 0f && nsU == 0f)
		//	{
		//		rb.AddForce(transform.right * ns * 10, ForceMode2D.Impulse);
		//	}
		//	else if (nsU < 0f && ns == 0f)
		//	{
		//		rb.AddForce(transform.up * nsU * 10, ForceMode2D.Impulse);
		//	}
		//	else if (ns > 0f && nsU > 0f)
		//	{
		//		rb.AddForce(transform.right * ns * 10, ForceMode2D.Impulse);
		//		rb.AddForce(transform.up * nsU * 10, ForceMode2D.Impulse);
		//	}
		//	else if (ns < 0f && nsU < 0f)
		//	{
		//		rb.AddForce(transform.right * -(Mathf.Abs(ns)) * 10, ForceMode2D.Impulse);
		//		rb.AddForce(transform.up * -(Mathf.Abs(nsU)) * 10, ForceMode2D.Impulse);
		//	}
		//	else if (ns > 0f && nsU < 0f)
		//	{
		//		rb.AddForce(transform.right * (Mathf.Abs(ns)) * 10, ForceMode2D.Impulse);
		//		rb.AddForce(transform.up * -(Mathf.Abs(nsU)) * 10, ForceMode2D.Impulse);
		//	}
		//	else if (ns < 0f && nsU > 0f)
		//	{
		//		rb.AddForce(transform.right * -(Mathf.Abs(ns)) * 10, ForceMode2D.Impulse);
		//		rb.AddForce(transform.up * (Mathf.Abs(nsU)) * 10, ForceMode2D.Impulse);
		//		//rb.AddForce(new Vector3(-(Mathf.Abs(ns)), (Mathf.Abs(nsU)), 0f), ForceMode2D.Impulse);
		//	}
		//}

	}

	private void RunPC()
	{
		Vector3 direction = transform.right;
		Vector3 directionUp = transform.up;
		if ((rb.velocity.x < 3f && rb.velocity.x > -3f && rb.velocity.y < 3f && rb.velocity.y > -3f)) //&& !FreezingBool)
        {
			if (rb.velocity.x < 1f && rb.velocity.x > -1f && rb.velocity.y < 1f && rb.velocity.y > -1f)
			{
				vs = 0;
				vsU = 0;
			}
			velocityXAfter = 0;
			velocityYAfter = 0;
			alreadyImpulsePlayer = false;
			LastName = "";
			//ImpulsePolAfter = false;
			h = joystick.Horizontal;
			v = joystick.Vertical;
			normalSpeed = hss * h;
			normalSpeedUp = hssu * v;
			//if (rb.velocity.x == 0f && rb.velocity.y == 0f)
			//{
			
			transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, normalSpeed * Time.deltaTime);
			transform.position = Vector3.MoveTowards(transform.position, transform.position + directionUp, (normalSpeedUp) * Time.deltaTime);
			//PCTG.rotation = Quaternion.LookRotation(new Vector2(joystick.Horizontal, joystick.Vertical));

			//if (joystick.Horizontal > 0)
			//{
			//PCTG.MoveRotation(Quaternion.LookRotation(new Vector2(joystick.Horizontal, joystick.Vertical)));
			//var q = Quaternion.Euler(0.0f, 15 * Time.deltaTime, 0.0f);
			//PCTG.transform.rotation = Quaternion.LookRotation(Vector2.MoveTowards(new Vector2(0, 0), new Vector2(joystick.Horizontal, joystick.Vertical), 10 * Time.deltaTime));
			/////////PCTG.transform.rotation = Quaternion.LookRotation(new Vector2(joystick.Horizontal, joystick.Vertical));
			//PCTG.MoveRotation(Quaternion.LookRotation(new Vector2(joystick.Horizontal, joystick.Vertical)) * q);
			//}
			//else
			//{
			//PCTG.MoveRotation(Quaternion.LookRotation(new Vector2(joystick.Horizontal, joystick.Vertical) * Time.deltaTime));
			//}
			//Quaternion deltaRotation = Quaternion.Euler(ns * Time.fixedDeltaTime);
			//if (normalSpeed > 0)
			// {
			//Quaternion.Euler(new Vector2(normalSpeed, normalSpeedUp) * Time.deltaTime
			//Quaternion deltaRotation = Quaternion.Euler(new Vector2(normalSpeed, normalSpeedUp) * Time.fixedDeltaTime);
			//PCTG.MoveRotation(Quaternion.LookRotation(new Vector2(normalSpeed, normalSpeedUp)));
			//vector3 upDirection = PathToFollow.path_objs[currentWaypointID].position - transform.position;
			//var a = new Vector2(joystick.Horizontal, joystick.Vertical);
			//float heading = Mathf.Atan2(a, joystick.Vertical);
			//PCTG.transform.rotation = Quaternion.Euler(0f, 0f, heading * Mathf.Rad2Deg);
			//joystick.DeadZone
			//float heading = Mathf.Atan2(joystick.Horizontal, joystick.Vertical) * Mathf.Rad2Deg;
			//float angle = heading - PCTG.transform.rotation.y;
			//PCTG.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, angle, 0f), Time.deltaTime * 1f);
			//PCTG.rotation = PCTG.rotation * Quaternion.AngleAxis(joystick.Horizontal * 10, Vector2.z)
			//float rotValue = new Vector2(joystick.Horizontal, joystick.Vertical).sqrMagnitude;
			//if (rotValue >= joystick.DeadZone)
			//{
			//	if (RGear.R == false)
			//	{

			//		float heading = Mathf.Atan2(moveJoystick.LHorizontal,
			//									 moveJoystick.LVertical) * Mathf.Rad2Deg;
			//		float angle = heading - transform.rotation.y;
			//		transform.rotation = Quaternion.Slerp(transform.rotation,
			//								  Quaternion.Euler(0f, angle, 0f), Time.deltaTime * lerpTime);
			//		////Debug.Log("Calcul = " + (heading - transform.rotation.y));
			//		////Debug.Log("HEADING = " + heading);
			//	}
			//	if (RGear.R == true)
			//	{
			//		float heading = Mathf.Atan2(moveJoystick.LHorizontal, -moveJoystick.LVertical) * Mathf.Rad2Deg;

			//		transform.rotation = Quaternion.Slerp(transform.rotation,
			//								  Quaternion.Euler(0f, -heading, 0f), Time.deltaTime * lerpTime);

			//	}
			//}
			//var rotation = Quaternion.LookRotation(new Vector2(normalSpeed, normalSpeedUp));
			//PCTG.MoveRotation(Quaternion.RotateTowards(transform.rotation, rotation, Time.deltaTime * 360));
			//}
			//else if (normalSpeed < 0)
			//         {
			//	PCTG.MoveRotation(Quaternion.LookRotation(new Vector2(normalSpeed, normalSpeedUp)));
			//}
			//Vector3 m_Input = new Vector3(h, v, 0);
			//rb.MovePosition(transform.position + m_Input * Time.deltaTime * hss);
			//rb.velocity = new Vector2(0, 0);
			//if ((rb.velocity.x < 1f && rb.velocity.x > -1f && rb.velocity.y > -1f && rb.velocity.y < 1f) && (normalSpeed > 0f || normalSpeedUp > 0f || normalSpeed < 0f || normalSpeedUp < 0f))

			//if ((normalSpeed * normalSpeedUp) == 0)
			//         {
			//	Vector2 engineForceVector = new Vector2(h, v) * (normalSpeed * normalSpeedUp*10);
			//	rb.AddForce(engineForceVector, ForceMode2D.Force);
			//}

			if ((normalSpeed > 0f || normalSpeedUp > 0f || normalSpeed < 0f || normalSpeedUp < 0f))
			{
				PTrigger.SetActive(true);
				rb.velocity = new Vector2(0, 0);
				

				//Debug.Log("1");
			//normalSpeed = normalSpeed / 10;
			//normalSpeedUp = normalSpeedUp / 10;
			}
			else
            {
				PTrigger.SetActive(false);
			}
		}
		else
        {
			PTrigger.SetActive(false);
			hss = 0f;
			hssu = 0f;
			h = 0f;
			v = 0f;
			normalSpeed = 0f;
			normalSpeedUp = 0f;

		}

		//else if (rb.velocity.x <= 0f || rb.velocity.x >= 0f || rb.velocity.y >= 0f || rb.velocity.y <= 0f)
		//{
		//	if (rb.velocity.x <= 0f)
		//   {
		//		vx = rb.velocity.x + (Mathf.Abs(normalSpeed));			
		//	}
		//	else if (rb.velocity.x >= 0f)
		//    {
		//		vx = rb.velocity.x - (Mathf.Abs(normalSpeed));
		//	}
		//	if (rb.velocity.y <= 0f)
		//	{
		//		vy = rb.velocity.y + (Mathf.Abs(normalSpeed));
		//	}
		//	else if (rb.velocity.y >= 0f)
		//	{
		//		vy = rb.velocity.y - (Mathf.Abs(normalSpeed));
		//	}

			//if (rb.velocity.y < 0f)
			//{
			//	vy = rb.velocity.y + (normalSpeedUp / 10f)
			//	rb.velocity = new Vector2(vx, vy);
			//}
			//else if (rb.velocity.y > 0f)
			//{
			//
			//}


			//	if (!(rb.velocity.x > -1f && rb.velocity.x < 1f) && !(rb.velocity.y > -1f && rb.velocity.y < 1f))
			//   {
			//		rb.velocity = new Vector2(vx, vy);
			//	}
			//	else if ((rb.velocity.x > -1f && rb.velocity.x < 1f) && (rb.velocity.y > -1f && rb.velocity.y < 1f))
			//    {
			//		rb.velocity = new Vector2(0, 0);
			//	}
			//}
			//if ((rb.velocity.x < 0f || rb.velocity.x > 0f || rb.velocity.y > 0f || rb.velocity.y < 0f) && (normalSpeed > 0f || normalSpeedUp > 0f || normalSpeed < 0f || normalSpeedUp < 0f))
			//{
			//	//rb.velocity = new Vector2(0, 0);
			//	normalSpeed = normalSpeed / 10;
			//	normalSpeedUp = normalSpeedUp / 10;
			//}
			//}


	}

	//public void DestroyCircle()
	//{
	//	if (view.IsMine)
	//	{
	//		Destroy(GetComponent<GameObject>());
	//	}
	//}
	public void OnTriggerEnter2D(Collider2D otherE)
	{

        if (otherE.tag == "Bullet")
        {
            GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Discrete;
        }
        else
        {
            GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        }

        ns = normalSpeed;
		nsU = normalSpeedUp;
		if (Takealookaround == 0 && Freezing != 0)
		{
			if (otherE.tag == "Player")
			{
				//var oR = otherE.GetComponent<Rigidbody2D>();
				var cm = otherE.GetComponent<CirclesMovement>();
				if (cm.FreezingBool == false)
				{
					cm.FreezingBool = true;
					cm.StartCoroutine(Freeze((float)FreezingTime, (CirclesMovement)otherE.GetComponent<CirclesMovement>(), FreezingMultSaved, FreezingColor));
				}
			}
			else if (otherE.tag == "Bot")
			{
				var bm = otherE.GetComponent<BotMovement>();
				if (bm.FreezingBool == false)
				{
					bm.FreezingBool = true;
					bm.FreezeBot((float)FreezingTime, (BotMovement)otherE.GetComponent<BotMovement>(), FreezingColor, FreezingMultSaved, FrostEffectScript);
				}
			}
		}
		
		
		//if (otherE.GetComponent<Collider2D>().GetType == PolygonCollider2D)
		Collider2D collider = otherE.GetComponent<Collider2D>();
		//Debug.Log("ColliderEnter");
		//if (otherE.gameObject.tag == "piece")
		//Physics2D.IgnoreLayerCollision()
		//if (otherE.gameObject.tag == "Player" && LastName != otherE.gameObject.name)
		//{
		//	var o = otherE.gameObject;
		//	var oC = o.GetComponent<CirclesMovement>();
		//	var oR = o.GetComponent<Rigidbody2D>();
		//	if (((oC.normalSpeed <= 0 && rb.velocity.x > 0) || (oC.normalSpeed >= 0 && rb.velocity.x < 0) || (oC.normalSpeedUp >= 0 && rb.velocity.y < 0) || (oC.normalSpeedUp <= 0 && rb.velocity.y > 0)) || ((oC.normalSpeed <= 0 && rb.velocity.x > 0) || (oC.normalSpeed >= 0 && rb.velocity.x < 0) || (oC.normalSpeedUp >= 0 && rb.velocity.y < 0) || (oC.normalSpeedUp <= 0 && rb.velocity.y > 0)))//((ns == 0 || nsU == 0) && (vs != 0 || vsU !=0) && ImpulsePolAfter)
		//	{
		//		//vs = rb.velocity.x;
		//		//vsU = rb.velocity.y;
		//		//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
		//		//otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(vs * 2, vsU * 2, 0f);
		//		//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * vs, ForceMode2D.Impulse);
		//		//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * vsU, ForceMode2D.Impulse);
		//		//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * vs*2, ForceMode2D.Impulse);
		//		//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * vsU*2, ForceMode2D.Impulse);
		//		//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * vs * 2, ForceMode2D.Force);
		//		//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * vsU * 2, ForceMode2D.Force);
		//		if (vs != 0 || vsU != 0)
  //              {
		//			oR.velocity = new Vector3(vs, vsU, 0f);
					
		//		}
  //              else
  //              {
		//			oR.velocity = new Vector3(rb.velocity.x, rb.velocity.y, 0f);
		//		}
		//		if ((oR.velocity.x > 3 || oR.velocity.y > 3 || oR.velocity.x < -3 || oR.velocity.y < -3) && (((oR.velocity.x <= 0 && vs > 0) || (oR.velocity.x >= 0 && vs < 0) || (oR.velocity.y >= 0 && vsU < 0) || (oR.velocity.y <= 0 && vsU > 0)) || ((oR.velocity.x <= 0 && rb.velocity.x > 0) || (oR.velocity.x >= 0 && rb.velocity.x < 0) || (oR.velocity.y >= 0 && rb.velocity.y < 0) || (oR.velocity.y <= 0 && rb.velocity.y > 0))))
  //              {
		//			rb.velocity = new Vector2(oR.velocity.x, oR.velocity.y);
  //              }

		//		//Debug.Log("vs impulse player" + " " + vs + " " + vsU + " " + this.gameObject.name);

		//		//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
		//		vs = 0;
		//		vsU = 0;
		//		//ns = 0;
		//		//nsU = 0;
		//		//if ((vs > 0f || vsU > 0f))
		//		//{

		//		//	//rb.AddForce(transform.right * -XvelI * 10f, ForceMode2D.Impulse);
		//		//	//rb.AddForce(transform.up * YvelI * 10f, ForceMode2D.Impulse);
		//		//	otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(vs, vsU, 0f);
		//		//	//Debug.Log("1)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

		//		//}
		//		//else if ((vs < 0f || vsU < 0f))
		//		//{
		//		//	//rb.AddForce(transform.right * XvelI * 10f, ForceMode2D.Impulse);

		//		//	//rb.AddForce(transform.up * -YvelI * 10f, ForceMode2D.Impulse);
		//		//	otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(vs, vsU, 0f);
		//		//	//Debug.Log("2)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

		//		//}
		//		//else if (!rightCollision && YvelI > 0f)
		//		//{
		//		//	//rb.AddForce(transform.right * -XvelI * 10f, ForceMode2D.Impulse);
		//		//	//rb.AddForce(transform.up * YvelI * 10f, ForceMode2D.Impulse);
		//		//	rb.velocity = new Vector2(-XvelI, YvelI);
		//		//	//Debug.Log("3)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

		//		//}
		//		//else if (rightCollision && XvelI > 0f)
		//		//{
		//		//	//rb.AddForce(transform.right * XvelI * 10f, ForceMode2D.Impulse);
		//		//	//rb.AddForce(transform.up * -YvelI * 10f, ForceMode2D.Impulse);
		//		//	rb.velocity = new Vector2(XvelI, -YvelI);
		//		//	//Debug.Log("4)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

		//		//}
		//	}
		//}




		//if (vs > 0f || vs < 0f || vsU > 0f || vsU < 0f)
		//{
		//}

		//GetComponent<Rigidbody2D>().AddForce(new Vector3(ns+ normalSpeed, nsU+ normalSpeedUp, 0f), ForceMode2D.Impulse);
		//rbO = otherE.gameObject.GetComponent<Rigidbody2D>();
		//this.photonView.RPC("Impulse", RpcTarget.All, normalSpeed, normalSpeedUp);
		//float SendNs = normalSpeed;
		//float SendNsUp = normalSpeedUp;
		//photonView.RPC("Impulse");
		// if ns>0	



		if (otherE.gameObject.tag == "Shoot")
        {
			if (otherE.GetComponent<Shoot>().PlayerShoot != Player)
            {
				if (Takealookaround == 0)
                {
					rb.AddForce(otherE.GetComponent<Transform>().right * 100, ForceMode2D.Impulse);
				}
			}
		}
		if (otherE.gameObject.tag == "polYgol")
		{
			LastName = "";
			ygol = otherE.GetComponent<Transform>().rotation.z;
			//if (vsYgol < rb.velocity.x)
            //{
				vsYgol = rb.velocity.x;
			//}
			//if (vsUYgol < rb.velocity.y)
            //{
				vsUYgol = rb.velocity.y;
			//}
			if (vsUYgol == 0 && velocityYAfter != 0)
			{
				vsUYgol = velocityYAfter;
			}
			if (vsYgol == 0 && velocityXAfter != 0)
			{
				vsYgol = velocityXAfter;
			}
			ns = normalSpeed;
			nsU = normalSpeedUp;
			//if (ygol == 45)
			//{
			//	rb.AddForce(transform.right * -normalSpeedUp * 10, ForceMode2D.Impulse);
			//	rb.AddForce(transform.up * -normalSpeed * 10, ForceMode2D.Impulse);
			//}



			//rb.velocity = new Vector3(-ycomponent, -xcomponent, 0);
			if (!alreadyImpulse)
			{

				//if (rb.gravityScale != 0)
				//            {
				//	if (normalSpeed != 0 || normalSpeedUp != 0)	
				//	{
				//		float xcomponent = Mathf.Cos(Mathf.Abs(ygol) * Mathf.PI / 180) * ns * 2;
				//		float ycomponent = Mathf.Cos(Mathf.Abs(ygol) * Mathf.PI / 180) * nsU * 2;
				//		if ((ygol < 0))
				//		{
				//			rb.velocity = new Vector3(ycomponent, xcomponent, 0);
				//			//rb.AddForce(transform.right * ycomponent * 10f, ForceMode2D.Impulse);
				//			//rb.AddForce(transform.up * xcomponent * 10f, ForceMode2D.Impulse);
				//			//Debug.Log("impulse ygol<90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
				//		}
				//		else if (ygol > 0)
				//		{
				//			rb.velocity = new Vector3(-ycomponent, -xcomponent, 0);
				//			//rb.AddForce(transform.right * -ycomponent * 10f, ForceMode2D.Impulse);
				//			//rb.AddForce(transform.up * -xcomponent * 10f, ForceMode2D.Impulse);
				//			//Debug.Log("impulse ygol>90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
				//		}
				//		ImpulsePolAfter = true;
				//	}
				//	else if (vsYgol != 0 || vsUYgol != 0)
				//	{
				//		float xcomponent = Mathf.Cos(ygol * Mathf.PI / 180) * vsYgol * 2;
				//		float ycomponent = Mathf.Cos(ygol * Mathf.PI / 180) * vsUYgol * 2;
				//		if ((ygol < 0))
				//		{
				//			rb.velocity = new Vector3(ycomponent, xcomponent, 0);

				//			//Debug.Log("impulse ygol<90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
				//		}
				//		else if (ygol > 0)
				//		{
				//			rb.velocity = new Vector3(-ycomponent, -xcomponent, 0);
				//			//Debug.Log("impulse ygol>90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
				//		}
				//		ImpulsePolAfter = true;
				//	}

				//	alreadyImpulse = true;
				//}
				if (normalSpeed != 0 || normalSpeedUp != 0)
				{
					float xcomponent = Mathf.Cos(Mathf.Abs(ygol) * Mathf.PI / 180) * ns * 2;
					float ycomponent = Mathf.Cos(Mathf.Abs(ygol) * Mathf.PI / 180) * nsU * 2;
					if ((ygol < 0))
					{
						rb.velocity = new Vector3(ycomponent, xcomponent, 0);
						//rb.AddForce(transform.right * ycomponent * 10f, ForceMode2D.Impulse);
						//rb.AddForce(transform.up * xcomponent * 10f, ForceMode2D.Impulse);
						//Debug.Log("impulse ygol<90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
					}
					else if (ygol > 0)
					{
						rb.velocity = new Vector3(-ycomponent, -xcomponent, 0);
						//rb.AddForce(transform.right * -ycomponent * 10f, ForceMode2D.Impulse);
						//rb.AddForce(transform.up * -xcomponent * 10f, ForceMode2D.Impulse);
						//Debug.Log("impulse ygol>90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
					}
					ImpulsePolAfter = true;
				}
				else if (vsYgol != 0 || vsUYgol != 0)
				{
					float xcomponent = Mathf.Cos(ygol * Mathf.PI / 180) * vsYgol * 2;
					float ycomponent = Mathf.Cos(ygol * Mathf.PI / 180) * vsUYgol * 2;
					if ((ygol < 0))
					{
						rb.velocity = new Vector3(ycomponent, xcomponent, 0);

						//Debug.Log("impulse ygol<90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
					}
					else if (ygol > 0)
					{
						rb.velocity = new Vector3(-ycomponent, -xcomponent, 0);
						//Debug.Log("impulse ygol>90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
					}
					ImpulsePolAfter = true;
				}

				alreadyImpulse = true;
			}



			//ygol *= Mathf.Deg2Rad;
			//float xComponent = Mathf.Cos(ygol) * normalSpeed;
			//float yComponent = Mathf.Sin(ygol) * normalSpeedUp;
			//Vector3 forceApplied = new Vector3(xComponent, yComponent, 0);
			//rb.velocity = forceApplied;
			////Debug.Log("1)" + " " + (Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeed) + " " + (Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeedUp));
			////float xComponent = Mathf.Cos(ygol) * normalSpeed;
			////float yComponent = Mathf.Sin(ygol) * normalSpeedUp;
			////Vector3 forceApplied = new Vector3(xComponent, yComponent, 0);

			//if (rightCollision && (joystick.Horizontal == 0f || joystick.Vertical == 0f))
			//{
			//	//rb.AddForce(Mathf.Cos(ygol * Mathf.PI / 180) * transform.right * -10, ForceMode2D.Impulse);
			//	//rb.AddForce(transform.up * 10, ForceMode2D.Impulse);
			//	rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * -10, Mathf.Cos(ygol * Mathf.PI / 180) * 10), ForceMode2D.Impulse);
			//}
			//else if (!rightCollision && (joystick.Vertical == 0f || joystick.Horizontal == 0f))
			//{
			//	//rb.AddForce(transform.right * 10, ForceMode2D.Impulse);

			//	//rb.AddForce(transform.up * -10, ForceMode2D.Impulse);
			//	rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * 10, Mathf.Cos(ygol * Mathf.PI / 180) * -10), ForceMode2D.Impulse);
			//}
			//else if (rightCollision && (joystick.Horizontal > 0f || joystick.Horizontal < 0f))
			//{
			//	//rb.AddForce(transform.right * -normalSpeed * 10, ForceMode2D.Impulse);
			//	//rb.AddForce(transform.up * normalSpeedUp * 10, ForceMode2D.Impulse);
			//	//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeedUp), ForceMode2D.Impulse);
			//	float xComponent = Mathf.Cos(ygol) * -normalSpeed;
			//	float yComponent = Mathf.Sin(ygol) * normalSpeedUp;
			//	Vector3 forceApplied = new Vector3(xComponent, yComponent, 0);
			//	rb.velocity = forceApplied;
			//	//Debug.Log("1)" + " " + (Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeed) + " " + (Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeedUp));
			//}
			//else if (!rightCollision && (joystick.Vertical > 0f || joystick.Vertical < 0f))
			//{
			//	//rb.AddForce(transform.right * normalSpeed * 10, ForceMode2D.Impulse);

			//	//rb.AddForce(transform.up * -normalSpeedUp * 10, ForceMode2D.Impulse);
			//	rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeedUp), ForceMode2D.Impulse);
			//}
			//else if (!rightCollision && joystick.Vertical > 0f && joystick.Vertical < 0.2f)
			//{
			//	//rb.AddForce(transform.right * -normalSpeed * 10, ForceMode2D.Impulse);
			//	//rb.AddForce(transform.up * normalSpeedUp * 10, ForceMode2D.Impulse);
			//	rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeedUp), ForceMode2D.Impulse);
			//}
			//else if (rightCollision && joystick.Horizontal > 0f && joystick.Horizontal < 0.2f)
			//{
			//	//rb.AddForce(transform.right * normalSpeed * 10, ForceMode2D.Impulse);
			//	//rb.AddForce(transform.up * -normalSpeedUp * 10, ForceMode2D.Impulse);
			//	rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeedUp), ForceMode2D.Impulse);

			//}
		}

		if (otherE.gameObject.tag == "polUp")
		{
			rightCollision = false;
			XvelI = rb.velocity.x;
			YvelI = rb.velocity.y;
			//vsYgol = rb.velocity.x;
			//vsUYgol = rb.velocity.y;
		}
		else if (otherE.gameObject.tag == "polRight")
		{
			rightCollision = true;
			XvelI = rb.velocity.x;
			YvelI = rb.velocity.y;
			//vsYgol = rb.velocity.x;
            //vsUYgol = rb.velocity.y;
		}
		//rb.AddForce(new Vector2(0, 10000f), ForceMode2D.Impulse);
		if (otherE.gameObject.tag == "pol")
		{
			PolImpulse();
		}
		else if (otherE.gameObject.tag == "Steklo")
        {
			if (normalSpeed > 0 || rb.velocity.x > 0)
            {
				otherE.GetComponent<Steklo>().GO((normalSpeed + normalSpeedUp + rb.velocity.x + rb.velocity.y), this.transform);
			}
			else if (normalSpeed < 0 || rb.velocity.x < 0)
            {
				otherE.GetComponent<Steklo>().GO(-(normalSpeed + normalSpeedUp + rb.velocity.x + rb.velocity.y), this.transform);
			}
			if (FriendOfGlass == 0)
            {
				//PolImpulse();
				Transform Scale = otherE.transform;
				if (Scale.rotation.z > 0 || Scale.rotation.z < 0)
				{
					rb.velocity = new Vector2(ns + rb.velocity.x * 2f, -nsU + rb.velocity.y * 2f);
				}
				else
                {
					rb.velocity = new Vector2(-ns + rb.velocity.x * 2f, nsU + rb.velocity.y * 2f);
				}

			}
		}
		//else if (otherE.gameObject.tag == "Money")
		//{
			
		//	Destroy(otherE.gameObject);
		//	//otherE.GetComponent<MoneyFall>()
		//}
	}
    private void OnTriggerStay2D(Collider2D otherE)
    {
		if (otherE.gameObject.tag == "polUp")
        {
			XvelI = rb.velocity.x;
			YvelI = rb.velocity.y;
		}
		else if (otherE.gameObject.tag == "polRight")
        {
			XvelI = rb.velocity.x;
			YvelI = rb.velocity.y;
		}
        else if (otherE.gameObject.tag == "pol")
        {
            LastName = "";
            if (rightCollision && (((normalSpeed > 0f && normalSpeed < 3f) && (normalSpeedUp > 0f && normalSpeedUp < 0.3f)) || ((normalSpeedUp < 0f && normalSpeedUp > -0.3f) && (normalSpeed < 0f && normalSpeed > -0.3f)) || ((normalSpeedUp < 0f && normalSpeedUp > -0.3f) && (normalSpeed > 0f && normalSpeed < 0.3f)) || ((normalSpeedUp > 0f && normalSpeedUp < 0.3f) && (normalSpeed < 0f && normalSpeed > -0.3f))))
            {
                if (normalSpeed < 0f)
                {
                    rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
                    //Debug.Log("2");
                }
                else if (normalSpeed > 0f)
                {
                    rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
                    //Debug.Log("3");
                }
                //if (normalSpeedUp < 0f)
                //{
                //	rb.AddForce(transform.up * -50, ForceMode2D.Impulse);
                //}
                //else if (normalSpeedUp > 0f)
                //{
                //	rb.AddForce(transform.up * 50, ForceMode2D.Impulse);
                //}

                //rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * -10, Mathf.Cos(ygol * Mathf.PI / 180) * 10), ForceMode2D.Impulse);
                //Debug.Log("<3 Impulse1");
            }
            else if (!rightCollision && (((joystick.Horizontal > 0f && joystick.Horizontal < 0.3f) && (joystick.Vertical > 0f && joystick.Vertical < 0.3f)) || ((joystick.Vertical < 0f && joystick.Vertical > -0.3f) && (joystick.Horizontal < 0f && joystick.Horizontal > -0.3f)) || ((joystick.Vertical < 0f && joystick.Vertical > -0.3f) && (joystick.Horizontal > 0f && joystick.Horizontal < 0.3f)) || ((joystick.Vertical > 0f && joystick.Vertical < 0.3f) && (joystick.Horizontal < 0f && joystick.Horizontal > -0.3f))))
            {
                //if (normalSpeed < 0f)
                //{
                //	rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
                //}
                //else if (normalSpeed > 0f)
                //{
                //	rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
                //}
                if (normalSpeedUp < 0f)
                {
                    rb.AddForce(transform.up * 50, ForceMode2D.Impulse);
                    //Debug.Log("4");
                }
                else if (normalSpeedUp > 0f)
                {
                    rb.AddForce(transform.up * -50, ForceMode2D.Impulse);
                    //Debug.Log("5");
                }
                //Debug.Log("<3 Impulse2" + " " + ns + " " + nsU);
                //rb.AddForce(transform.right * 50, ForceMode2D.Impulse);

                //rb.AddForce(transform.up * -nsU * 50, ForceMode2D.Impulse);
                //rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * 10, Mathf.Cos(ygol * Mathf.PI / 180) * -10), ForceMode2D.Impulse);
            }
        }

		
		else if (otherE.gameObject.tag == "polYgol")
        {
            LastName = "";
            ygol = otherE.GetComponent<Transform>().rotation.z;
            vsYgol = rb.velocity.x;
            vsUYgol = rb.velocity.y;
            ns = normalSpeed;
            nsU = normalSpeedUp;
            //if (ygol == 45)
            //{
            //	rb.AddForce(transform.right * -normalSpeedUp * 10, ForceMode2D.Impulse);
            //	rb.AddForce(transform.up * -normalSpeed * 10, ForceMode2D.Impulse);
            //}



            //rb.velocity = new Vector3(-ycomponent, -xcomponent, 0);

            float xcomponent = Mathf.Cos(ygol * Mathf.PI / 180) * ns * 2;
            float ycomponent = Mathf.Cos(ygol * Mathf.PI / 180) * nsU * 2;
            if ((ygol < 0.5))
            {
                //rb.velocity = new Vector3(-ycomponent, -xcomponent, 0);
                //Debug.Log("impulse ygol<90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
                //if (((joystick.Horizontal > 0f && joystick.Horizontal < 0.3f) && (joystick.Vertical > 0f && joystick.Vertical < 0.3f)) || ((joystick.Vertical < 0f && joystick.Vertical > -0.3f) && (joystick.Horizontal < 0f && joystick.Horizontal > -0.3f)))
                if (((joystick.Horizontal > 0f && joystick.Horizontal < 0.3f) && (joystick.Vertical > 0f && joystick.Vertical < 0.3f)) || ((joystick.Vertical < 0f && joystick.Vertical > -0.3f) && (joystick.Horizontal < 0f && joystick.Horizontal > -0.3f)) || ((joystick.Vertical < 0f && joystick.Vertical > -0.3f) && (joystick.Horizontal > 0f && joystick.Horizontal < 0.3f)) || ((joystick.Vertical > 0f && joystick.Vertical < 0.3f) && (joystick.Horizontal < 0f && joystick.Horizontal > -0.3f)))
                {

                    if (nsU < 0f)
                    {
                        //rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
                        rb.velocity = new Vector3(10, -xcomponent, 0);
                        //Debug.Log("6");
                        //rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
                    }
                    else if (nsU > 0f)
                    {
                        //rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
                        rb.velocity = new Vector3(-10, -xcomponent, 0);
                        //Debug.Log("7");
                        //rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
                    }
                    //Debug.Log("if impulse1");
                }
            }
            else if (ygol > 0.5)
            {
                if (((joystick.Horizontal > 0f && joystick.Horizontal < 0.3f) && (joystick.Vertical > 0f && joystick.Vertical < 0.3f)) || ((joystick.Vertical < 0f && joystick.Vertical > -0.3f) && (joystick.Horizontal < 0f && joystick.Horizontal > -0.3f)) || ((joystick.Vertical < 0f && joystick.Vertical > -0.3f) && (joystick.Horizontal > 0f && joystick.Horizontal < 0.3f)) || ((joystick.Vertical > 0f && joystick.Vertical < 0.3f) && (joystick.Horizontal < 0f && joystick.Horizontal > -0.3f)))
                {

                    if (nsU < 0f)
                    {
                        //rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
                        rb.velocity = new Vector3(-10, -xcomponent, 0);
                        //Debug.Log("8");
                        //rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
                    }
                    else if (nsU > 0f)
                    {
                        //rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
                        rb.velocity = new Vector3(10, -xcomponent, 0);
                        //Debug.Log("9");
                        //rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
                    }
                    //Debug.Log("if impulse2");
                }
                //Debug.Log("impulse ygol>90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
            }
            ImpulsePolAfter = true;




        }

        else if (otherE.gameObject.tag == "polYskoritel")
        {
			//if (FriendOfGlass == 0)
            //{
				LastName = "";
				rb.AddForce(transform.right * normalSpeed * 15f, ForceMode2D.Impulse);
				rb.AddForce(transform.up * normalSpeedUp * 15f, ForceMode2D.Impulse);
			//rb.velocity = new Vector3(normalSpeed * 10f, normalSpeedUp * 10f, 0);
			//}
			//Yskoritel = true;
			//rb.drag = 0;
		}

		

    }
    //private void OnTriggerStay2D(Collider2D other)
    //{
    //	Collider2D collider = other.GetComponent<Collider2D>();
    //	//Debug.Log("ColliderEnter");
    //	if (other.gameObject.tag == "polUp" && rightCollision)
    //       {
    //		rightCollision = false;

    //	}
    //	else if (other.gameObject.tag == "polRight" && !rightCollision)
    //       {
    //		rightCollision = true;
    //	}
    //	//rb.AddForce(new Vector2(0, 10000f), ForceMode2D.Impulse);
    //	if (other.gameObject.tag == "pol")
    //       {


    //			//Vector3 contactPoint = other.contacts[0].point;
    //			//Vector3 center = collider.bounds.center;

    //			//bool right = contactPoint.x > center.x;
    //			//bool top = contactPoint.y > center.y;

    //           if (rightCollision && (joystick.Horizontal > 0f || joystick.Horizontal < 0f))
    //           {
    //               rb.AddForce(transform.right * -normalSpeed * 10, ForceMode2D.Impulse);
    //               rb.AddForce(transform.up * normalSpeedUp * 10, ForceMode2D.Impulse);
    //           }
    //           else if (!rightCollision && (joystick.Vertical > 0f || joystick.Vertical < 0f))
    //           {
    //			rb.AddForce(transform.right * normalSpeed * 10, ForceMode2D.Impulse);

    //               rb.AddForce(transform.up * -normalSpeedUp * 10, ForceMode2D.Impulse);
    //           }
    //           else if (!rightCollision && joystick.Vertical > 0f && joystick.Vertical < 0.2f)
    //           {
    //               rb.AddForce(transform.right * -normalSpeed * 10, ForceMode2D.Impulse);
    //               rb.AddForce(transform.up * normalSpeedUp * 10, ForceMode2D.Impulse);
    //           }
    //           else if (rightCollision && joystick.Horizontal > 0f && joystick.Horizontal < 0.2f)
    //           {
    //               rb.AddForce(transform.right * normalSpeed * 10, ForceMode2D.Impulse);
    //               rb.AddForce(transform.up * -normalSpeedUp * 10, ForceMode2D.Impulse);
    //           }
    //           //else if (rightCollision && normalSpeed > 0f || normalSpeed < 0f)
    //           // {
    //           //	rb.AddForce(transform.right * -normalSpeed * 10, ForceMode2D.Impulse);
    //           //	rb.AddForce(transform.up * normalSpeedUp * 10, ForceMode2D.Impulse);
    //           //	//rightCollision = false;
    //           //}
    //           //else if (!rightCollision && normalSpeedUp > 0f || normalSpeedUp < 0f)
    //           //{
    //           //	rb.AddForce(transform.right * normalSpeed * 10, ForceMode2D.Impulse);
    //           //	rb.AddForce(transform.up * -normalSpeedUp * 10, ForceMode2D.Impulse);
    //           //	//rightCollision = true;
    //           //}


    //           //Debug.Log("ImpulsePol");
    //	}
    //}

    public void Destroy()
	{
		if (Alive)
        {
			//Handheld.Vibrate();
			this.Alive = false;
			//GetComponent<SpriteRenderer>().enabled = false;

			//this.gameObject.transform.GetChild(1).GetComponent<Explodable>().explode();
			DNC.gameObject.SetActive(false);
			Destroy(ThisCircleCollider2D);
			//GetComponent<Explodable>().explode();

			this.gameObject.tag = "Untagged";
			//DNC.DestroyC();

			//rb.AddExplosionForce(100f, transform.position, 100f);
			SM.PlayersAlive = SM.PlayersAlive - 1;
			//this.GetComponent<Collider2D>().enabled = false;

			joystick.gameObject.SetActive(false);
			ScoreN.transform.parent = null;
			ThisSpriteRendrer.enabled = false;
			//transform.GetChild(0).gameObject.transform.parent = null;
			//foreach (Transform child in transform)
			//{
			//	//Debug.Log(child.gameObject.tag);
			//	if (child.gameObject.tag == "moneta")
			//          {
			//		//child.position = transform.position;
			//		child.parent = null;
			//		child.gameObject.SetActive(true);

			//		child.GetComponent<Rigidbody2D>().AddExplosionForce(Random.Range(50f, 1000f), transform.position, 10f);
			//	}
			//	else if (child.gameObject.name == "newCircle2")
			//          {
			//		child.parent = null;
			//	}
			//}
			//Transform[] childrenList = new Transform childrenList;
			//Adds all children to the list
			//List<Transform> childrenList2 = new List<Transform>();
			//foreach (Transform childTrans in transform)
			//	childrenList2.Add(childTrans);
			//Goes through the list assigning parents
			foreach (GameObject childTrans in childrenList2)
			{
				//if (childTrans.tag == "Bullet")
				//{
				//childTrans.parent = null;
				//childTrans.gameObject.SetActive(true);
				//childTrans.GetComponent<Rigidbody2D>().AddExplosionForce(Random.Range(50f, 1000f), transform.position, 10f);
				childTrans.gameObject.SetActive(true);
				//}
				//else if (childTrans.gameObject.name == "newCircle2")
				//{
				//	childTrans.parent = null;
				//}
			}
			if (HMPlayersF == 1)
			{
				this.enabled = false;
			}
			if (HMPlayersF > 1)
			{
				if (gamemode == "monetu")
				{
					List<Transform> childrenList = new List<Transform>();
					foreach (Transform childTrans in transform)
						childrenList.Add(childTrans);
					//Goes through the list assigning parents
					foreach (Transform childTrans in childrenList)
					{
						if (childTrans.tag == "moneta")
						{
							childTrans.parent = null;
							childTrans.gameObject.SetActive(true);
							childTrans.GetComponent<Rigidbody2D>().AddExplosionForce(Random.Range(50f, 1000f), transform.position, 10f);
						}
						//else if (childTrans.gameObject.name == "newCircle2")
						//{
						//	childTrans.parent = null;
						//}
					}
				}

				if (SM.PlayersAlive <= 1)
				{
					if (gamemode == "monetu")
					{
						CS.LevelEnd(false);
						PlayerPrefs.SetFloat("LastWin", 0);
						PlayerPrefs.SetFloat("CardsAfterMonetu", 1);
					}
					else
					{
						if (p1.Alive)
						{
							p1.AddScore();

						}
						if (p2 != null)
						{
							if (p2.Alive)
							{
								p2.AddScore();
							}
						}
						if (p3 != null)
						{
							if (p3.Alive)
							{
								p3.AddScore();
							}
						}
						this.enabled = false;
					}
				}
				else
				{
					this.enabled = false;
				}
			}
			else if (HMPlayersF == 1)
			{
				CS.LevelEnd(false);
			}
		}
		
		
	}

	public void AddScore()
    {

		if (!alreadyScore && gamemode == "dm")
        {
			//pla = this.gameObject.name;
			if (Player == 1)
			{
				PlayerPrefs.SetFloat("SP1", SP1 + 1);
				PlayerPrefs.SetFloat("LastWin", 1);
			}
			else if (Player == 2)
			{
				PlayerPrefs.SetFloat("SP2", SP2 + 1);
				PlayerPrefs.SetFloat("LastWin", 2);
			}
			else if (Player == 3)
			{
				PlayerPrefs.SetFloat("SP3", SP3 + 1);
				PlayerPrefs.SetFloat("LastWin", 3);
			}
			else if (Player == 4)
			{
				PlayerPrefs.SetFloat("SP4", SP4 + 1);
				PlayerPrefs.SetFloat("LastWin", 4);
			}
			//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
			alreadyScore = true;
			ScoreN.GetComponent<SpriteRenderer>().enabled = true;
			CS.LevelEnd(false);
		}
		else if (gamemode == "monetu" && SM.TimerDone && !alreadyScore && SM.PlayersAlive > 1)
        {
			float hmp = PlayerPrefs.GetFloat("HMPlayersF");
			//string name = this.gameObject.name;
			if (hmp == 0)
			{
				hmp = 2;
			}
			switch (hmp)
            {
				case 2:
					if (Player == 1)
					{

						PlayerPrefs.SetFloat("HMM1", HMM);
						if (HMM > p1.HMM)
						{
							PlayerPrefs.SetFloat("SP1", SP1 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 1);
							

						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}

					}
					else if (Player == 2)
					{
						PlayerPrefs.SetFloat("HMM2", HMM);
						if (HMM > p1.HMM)
						{
							PlayerPrefs.SetFloat("SP2", SP2 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 2);
							
						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}
					}
					else if (Player == 3)
					{
						PlayerPrefs.SetFloat("HMM3", HMM);
						if (HMM > p1.HMM)
						{
							PlayerPrefs.SetFloat("SP3", SP3 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 3);
							
						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}
					}
					else if (Player == 4)
					{
						PlayerPrefs.SetFloat("HMM4", HMM);
						if (HMM > p1.HMM)
						{
							PlayerPrefs.SetFloat("SP4", SP4 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 4);
							
						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}
					}
					alreadyScore = true;
					break;
				case 3:
					if (Player == 1)
					{

						PlayerPrefs.SetFloat("HMM1", HMM);
						if (HMM > p1.HMM && HMM > p2.HMM)
						{
							PlayerPrefs.SetFloat("SP1", SP1 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 1);
							
						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}

					}
					else if (Player == 2)
					{
						PlayerPrefs.SetFloat("HMM2", HMM);
						if (HMM > p1.HMM && HMM > p2.HMM)
						{
							PlayerPrefs.SetFloat("SP2", SP2 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 2);
							
						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}
					}
					else if (Player == 3)
					{
						PlayerPrefs.SetFloat("HMM3", HMM);
						if (HMM > p1.HMM && HMM > p2.HMM)
						{
							PlayerPrefs.SetFloat("SP3", SP3 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 3);
							
						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}
					}
					else if (Player == 4)
					{
						PlayerPrefs.SetFloat("HMM4", HMM);
						if (HMM > p1.HMM && HMM > p2.HMM)
						{
							PlayerPrefs.SetFloat("SP4", SP4 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 4);
							
						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}
					}
					alreadyScore = true;
					break;
				case 4:
					if (Player == 1)
					{

						PlayerPrefs.SetFloat("HMM1", HMM);
						if (HMM > p1.HMM && HMM > p2.HMM && HMM > p3.HMM)
						{
							PlayerPrefs.SetFloat("SP1", SP1 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 1);
							
						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}

					}
					else if (Player == 2)
					{
						PlayerPrefs.SetFloat("HMM2", HMM);
						if (HMM > p1.HMM && HMM > p2.HMM && HMM > p3.HMM)
						{
							PlayerPrefs.SetFloat("SP2", SP2 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 2);
							
						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}
					}
					else if (Player == 3)
					{
						PlayerPrefs.SetFloat("HMM3", HMM);
						if (HMM > p1.HMM && HMM > p2.HMM && HMM > p3.HMM)
						{
							PlayerPrefs.SetFloat("SP3", SP3 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 3);
							
						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}
					}
					else if (Player == 4)
					{
						PlayerPrefs.SetFloat("HMM4", HMM);
						if (HMM > p1.HMM && HMM > p2.HMM && HMM > p3.HMM)
						{
							PlayerPrefs.SetFloat("SP4", SP4 + 1);
							ScoreN.GetComponent<SpriteRenderer>().enabled = true;
							//PlayerPrefs.SetFloat("LastWin", float.Parse(this.name.Replace("circle", "")));
							PlayerPrefs.SetFloat("LastWin", 4);
							
						}
						//else
						//{
						//	PlayerPrefs.SetFloat("LastWin", 0);
						//}
					}
					alreadyScore = true;
					break;
			}	
			
			//SM.PlayersAlive = 0;
			//CS.LevelEnd(false);
		}
	}

	public void ImpulsePlayers(Collider2D otherE, string tag)
    {
		var a = otherE.gameObject;
		var oR = a.GetComponent<Rigidbody2D>();
		float v = oR.velocity.x;
		float vU = oR.velocity.y;
		
		
		if (tag == "Player")
		{
			if (otherE.GetComponent<CirclesMovement>().Takealookaround == 0 && Takealookaround == 0)
			{
				ns = normalSpeed;
				nsU = normalSpeedUp;
				//if (!alreadyImpulsePlayer && !otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer) //  

				//if (ns > 0 || nsU > 0 || ns < 0 || nsU < 0)
				//Ray2D ray = new Ray2D(transform.position, new Vector2(ns, nsU));
				//Ray2D ray = new Ray2D(transform.position, new Vector2(ns, nsU));
				//RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10f);
				//RaycastHit2D[] hit2 = 1;
				//RaycastHit2D[] hit = Collider2D.Raycast(ray.direction, hit);
				//RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(ns, nsU));
				//int objectsHit = playerCollider.Raycast(new Vector2(ns, nsU), filter, hits, 1);

				//for (int i = 0; i < objectsHit; i++)
				//{
				//if ((ns > 0 || nsU > 0 || ns < 0 || nsU < 0))
				if ((ns > 0 || nsU > 0 || ns < 0 || nsU < 0))
				{
					if (!alreadyImpulsePlayer)
					{

						//var oR = a.GetComponent<Rigidbody2D>();

						a.GetComponent<CirclesMovement>().vs = a.GetComponent<Rigidbody2D>().velocity.x;
						a.GetComponent<CirclesMovement>().vsU = a.GetComponent<Rigidbody2D>().velocity.y;
						//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
						//if ((oR.velocity.x > 3 || oR.velocity.y > 3 || oR.velocity.x < -3 || oR.velocity.y < -3) && ((oR.velocity.x <= 0 && ns >= 0) || (oR.velocity.x >= 0 && ns <= 0) || (oR.velocity.y >= 0 && nsU <= 0) || (oR.velocity.y <= 0 && nsU >= 0)))
						if ((v < -1 && ns > 0) || (v > 1 && ns < 0) || (vU > 1 && nsU < 0) || (vU < -1 && nsU > 0))
						{
							rb.velocity = new Vector2(v * 2, vU * 2);
							//Debug.Log("rb.velocity = new Vector2(v*2, vU*2);" + " " + oR.velocity.x + " " + oR.velocity.y + " " + ns + " " + nsU);
						}

						oR.velocity = new Vector3(ns * 2 * BouncyForce * a.GetComponent<CirclesMovement>().BouncySelfForce, nsU * 2 * BouncyForce * a.GetComponent<CirclesMovement>().BouncySelfForce, 0f);
						a.GetComponent<CirclesMovement>().velocityXAfter = a.GetComponent<Rigidbody2D>().velocity.x;
						a.GetComponent<CirclesMovement>().velocityYAfter = a.GetComponent<Rigidbody2D>().velocity.y;
						////Debug.Log("rb.velocity = new Vector2(v*2, vU*2);");
						//rb.velocity = new Vector3(otherE.gameObject.GetComponent<Rigidbody2D>().velocity.x, otherE.gameObject.GetComponent<Rigidbody2D>().velocity.y, 0f);
						//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * ns*5, ForceMode2D.Force);
						//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * nsU * 5, ForceMode2D.Force);
						//Debug.Log("Player impulse" + " " + ns + " " + nsU + " " + this.gameObject.name + " " + rb.velocity);
						otherE.gameObject.GetComponent<CirclesMovement>().LastName = this.gameObject.name;
						otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;

						ns = 0;
						nsU = 0;
					}
				}
				if (Freezing != 0)
				{

					//otherE.GetComponent<CirclesMovement>().
					var cm = otherE.GetComponent<CirclesMovement>();
					if (cm.FreezingBool == false)
					{
						cm.FreezingBool = true;
						cm.StartCoroutine(Freeze((float)FreezingTime, (CirclesMovement)a.GetComponent<CirclesMovement>(), FreezingMultSaved, FreezingColor));
					}
					//otherE.GetComponent<SpriteRenderer>().color = new Color(FreezingColor, 255, 255, 255);

				}
				if (otherE.GetComponent<CirclesMovement>().Freezing != 0)
                {
					if (FreezingBool == false)
					{
						FreezingBool = true;
						StartCoroutine(Freeze(otherE.GetComponent<CirclesMovement>().FreezingTime, this, otherE.GetComponent<CirclesMovement>().FreezingMultSaved, otherE.GetComponent<CirclesMovement>().FreezingColor));
					}
					//otherE.GetComponent<SpriteRenderer>().color = new Color(FreezingColor, 255, 255, 255);
				}
				//if (Freezing != 0)
				//{
				//	otherE.GetComponent<CirclesMovement>().FreezingBool = true;
				//	otherE.GetComponent<CirclesMovement>().Freeze((float)FreezingTime);
				//}
				//}

				//if (hit.collider != null && )
				//{
				//	//Debug.Log("Хвала Небесам!!! Луч надежды снизошел на нас и соприкоснулся с LayerPlus!");
				//}
				//if (((ns > 0 && otherE.gameObject.GetComponent<CirclesMovement>().normalSpeed > 0) && (nsU > 0 && otherE.gameObject.GetComponent<CirclesMovement>().normalSpeedUp > 0)) && ((ns + nsU) > (otherE.gameObject.GetComponent<CirclesMovement>().normalSpeed + otherE.gameObject.GetComponent<CirclesMovement>().normalSpeedUp)))

				//((ns == 0 && nsU == 0) && (vs != 0 || vsU != 0)) && 


				//

			}

		}
		else if (tag == "PTrigger")
        {
			if (otherE.GetComponent<CirclesMovement>().Takealookaround == 0 && Takealookaround == 0)
			{
				ns = normalSpeed;
				nsU = normalSpeedUp;
				if ((ns > 0 || nsU > 0 || ns < 0 || nsU < 0))
				{
					if (!alreadyImpulsePlayer)
					{
						//if (Bouncy != 0)
						//{
						//	ns = ns;
						//	nsU = nsU * BouncyForce;
						//}
						//var a = otherE.gameObject;
						a.GetComponent<CirclesMovement>().vs = a.GetComponent<Rigidbody2D>().velocity.x;
						a.GetComponent<CirclesMovement>().vsU = a.GetComponent<Rigidbody2D>().velocity.y;
						//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
						rb.velocity = new Vector2(a.GetComponent<CirclesMovement>().normalSpeed, a.GetComponent<CirclesMovement>().normalSpeedUp);
						a.GetComponent<Rigidbody2D>().velocity = new Vector3(ns * 2 * BouncyForce * a.GetComponent<CirclesMovement>().BouncySelfForce, nsU * 2 * BouncyForce * a.GetComponent<CirclesMovement>().BouncySelfForce, 0f);
						a.GetComponent<CirclesMovement>().velocityXAfter = a.GetComponent<Rigidbody2D>().velocity.x;
						a.GetComponent<CirclesMovement>().velocityYAfter = a.GetComponent<Rigidbody2D>().velocity.y;
						//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * ns*5, ForceMode2D.Force);
						//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * nsU * 5, ForceMode2D.Force);
						//Debug.Log("Player impulse" + " " + ns + " " + nsU + " " + this.gameObject.name + " " + rb.velocity);
						otherE.gameObject.GetComponent<CirclesMovement>().LastName = this.gameObject.name;
						otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;

						ns = 0;
						nsU = 0;
					}
				}
				if (Freezing != 0)
				{

					//otherE.GetComponent<CirclesMovement>().
					var cm = otherE.GetComponent<CirclesMovement>();
					if (cm.FreezingBool == false)
					{
						cm.FreezingBool = true;
						cm.StartCoroutine(Freeze((float)FreezingTime, (CirclesMovement)a.GetComponent<CirclesMovement>(), FreezingMultSaved, FreezingColor));
					}
					//otherE.GetComponent<SpriteRenderer>().color = new Color(FreezingColor, 255, 255, 255);
				}
				if (otherE.GetComponent<CirclesMovement>().Freezing != 0)
				{
					if (FreezingBool == false)
					{
						FreezingBool = false;
						StartCoroutine(Freeze(otherE.GetComponent<CirclesMovement>().FreezingTime, this, otherE.GetComponent<CirclesMovement>().FreezingMultSaved, otherE.GetComponent<CirclesMovement>().FreezingColor));
					}
					//otherE.GetComponent<SpriteRenderer>().color = new Color(FreezingColor, 255, 255, 255);

				}
				//if (Freezing != 0)
				//{
				//	otherE.GetComponent<CirclesMovement>().FreezingBool = true;
				//	otherE.GetComponent<CirclesMovement>().Freeze((float)FreezingTime);
				//}
			}
		}
		else if (tag == "Bot")
        {
			if (Takealookaround == 0)
			{
				ns = normalSpeed;
				nsU = normalSpeedUp;
				if ((ns > 0 || nsU > 0 || ns < 0 || nsU < 0))
				{
					if (!alreadyImpulsePlayer)
					{
						//if (Bouncy != 0)
						//{
						//	ns = ns;
						//	nsU = nsU * BouncyForce;
						//}
						//var a = otherE.gameObject;
						//a.GetComponent<BotMovement>().vs = a.GetComponent<Rigidbody2D>().velocity.x;
						//a.GetComponent<CirclesMovement>().vsU = a.GetComponent<Rigidbody2D>().velocity.y;
						//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
						//rb.velocity = new Vector2(a.GetComponent<BotMovement>().normalSpeed, a.GetComponent<BotMovement>().normalSpeedUp);
						a.GetComponent<Rigidbody2D>().velocity = new Vector3(ns * 4 * BouncyForce, nsU * 4 * BouncyForce, 0f);
						//a.GetComponent<CirclesMovement>().velocityXAfter = a.GetComponent<Rigidbody2D>().velocity.x;
						//a.GetComponent<CirclesMovement>().velocityYAfter = a.GetComponent<Rigidbody2D>().velocity.y;
						//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * ns*5, ForceMode2D.Force);
						//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * nsU * 5, ForceMode2D.Force);
						//Debug.Log("Player impulse" + " " + ns + " " + nsU + " " + this.gameObject.name + " " + rb.velocity);
						//otherE.gameObject.GetComponent<BotMovement>().LastName = this.gameObject.name;
						otherE.gameObject.GetComponent<BotMovement>().alreadyImpulsePlayer = true;

						ns = 0;
						nsU = 0;
					}
				}
				if ((ns == 0 && nsU == 0 && ns == 0 && nsU == 0))
				{
					if (!alreadyImpulsePlayer)
					{
						//if (Bouncy != 0)
						//{
						//	ns = ns;
						//	nsU = nsU * BouncyForce;
						//}
						//var a = otherE.gameObject;
						//a.GetComponent<BotMovement>().vs = a.GetComponent<Rigidbody2D>().velocity.x;
						//a.GetComponent<CirclesMovement>().vsU = a.GetComponent<Rigidbody2D>().velocity.y;
						//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
						//rb.velocity = new Vector2(a.GetComponent<BotMovement>().normalSpeed, a.GetComponent<BotMovement>().normalSpeedUp);
						a.GetComponent<Rigidbody2D>().velocity = new Vector3(joystick.Horizontal * 8 * BouncyForce, joystick.Vertical * 8 * BouncyForce, 0f);
						//a.GetComponent<CirclesMovement>().velocityXAfter = a.GetComponent<Rigidbody2D>().velocity.x;
						//a.GetComponent<CirclesMovement>().velocityYAfter = a.GetComponent<Rigidbody2D>().velocity.y;
						//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * ns*5, ForceMode2D.Force);
						//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * nsU * 5, ForceMode2D.Force);
						//Debug.Log("Player impulse" + " " + ns + " " + nsU + " " + this.gameObject.name + " " + rb.velocity);
						//otherE.gameObject.GetComponent<BotMovement>().LastName = this.gameObject.name;
						otherE.gameObject.GetComponent<BotMovement>().alreadyImpulsePlayer = true;

						ns = 0;
						nsU = 0;
					}
				}
				if (Freezing != 0)
				{

					//otherE.GetComponent<CirclesMovement>().
					otherE.GetComponent<BotMovement>().FreezeBot((float)FreezingTime, (BotMovement)a.GetComponent<BotMovement>(), FreezingColor, FreezingMultSaved, FrostEffectScript);
				}
				//if (Freezing != 0)
				//{
				//	otherE.GetComponent<CirclesMovement>().FreezingBool = true;
				//	otherE.GetComponent<CirclesMovement>().Freeze((float)FreezingTime);
				//}
			}
		}


	}

	void PolImpulse()
    {
		LastName = "";
		//if (XvelI < rb.velocity.x)
  //      {
		//	XvelI = rb.velocity.x;
  //      }
		//if (YvelI < rb.velocity.y)
  //      {

  //      }
		//rb.velocity = new Vector2(0, 0);
		//rb.constraints = RigidbodyConstraints2D.FreezePosition;
		//rb.constraints = RigidbodyConstraints2D.None;
		//Vector3 contactPoint = other.contacts[0].point;
		//Vector3 center = collider.bounds.center;

		//bool right = contactPoint.x > center.x;
		//bool top = contactPoint.y > center.y;
		//////normalspeed * cos naklona
		if (YvelI == 0 && velocityYAfter != 0)
        {
			YvelI = velocityYAfter;
        }
		if (XvelI == 0 && velocityXAfter != 0)
        {
			XvelI = velocityXAfter;
		}


		if (!alreadyImpulse)
		{
		if (rightCollision && (XvelI > 0f || XvelI < 0f))
			{

				//rb.AddForce(transform.right * -XvelI * 10f, ForceMode2D.Impulse);
				//rb.AddForce(transform.up * YvelI * 10f, ForceMode2D.Impulse);
				rb.velocity = new Vector2(-XvelI, YvelI);
				//Debug.Log("1)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));
				XvelI = 0f;
				XvelI = 0f;



			}
			else if (!rightCollision && (YvelI > 0f || YvelI < 0f))
			{
				//rb.AddForce(transform.right * XvelI * 10f, ForceMode2D.Impulse);

				//rb.AddForce(transform.up * -YvelI * 10f, ForceMode2D.Impulse);
				rb.velocity = new Vector2(XvelI, -YvelI);
				//Debug.Log("2)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));
				XvelI = 0f;
				XvelI = 0f;
			}
			else if (!rightCollision && YvelI > 0f)
			{
				//rb.AddForce(transform.right * -XvelI * 10f, ForceMode2D.Impulse);
				//rb.AddForce(transform.up * YvelI * 10f, ForceMode2D.Impulse);
				rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
				//Debug.Log("3)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));
				XvelI = 0f;
				XvelI = 0f;
			}
			else if (rightCollision && YvelI > 0f)
			{
				//rb.AddForce(transform.right * XvelI * 10f, ForceMode2D.Impulse);
				//rb.AddForce(transform.up * -YvelI * 10f, ForceMode2D.Impulse);
				rb.velocity = new Vector2(XvelI, -YvelI);
				//Debug.Log("4)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));
				XvelI = 0f;
				XvelI = 0f;
			}



			else if (rightCollision && (ns > 0f || ns < 0f))
			{
				rb.velocity = new Vector2(-ns * 2f, nsU * 2f);
				//rb.AddForce(transform.right * , ForceMode2D.Impulse);
				//rb.AddForce(transform.up * , ForceMode2D.Impulse);
				//Debug.Log("1n)" + " " + ns + " " + nsU);
				ns = 0f;
				nsU = 0f;
				//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeedUp), ForceMode2D.Impulse);
				////Debug.Log("1)" + " " + (Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeed) + " " + (Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeedUp));
			}
			else if (!rightCollision && (nsU > 0f || nsU < 0f))
			{
				//rb.AddForce(transform.right * ns * 10, ForceMode2D.Impulse);

				//rb.AddForce(transform.up * -nsU * 10, ForceMode2D.Impulse);
				rb.velocity = new Vector2(ns * 2f, -nsU * 2f);
				//Debug.Log("2n)" + " " + ns + " " + nsU);
				ns = 0f;
				nsU = 0f;
				//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeedUp), ForceMode2D.Impulse);
			}
			else if (!rightCollision && nsU > 0f && nsU < 0.2f)
			{
				//rb.AddForce(transform.right * -ns * 10, ForceMode2D.Impulse);
				//rb.AddForce(transform.up * nsU * 10, ForceMode2D.Impulse);
				rb.velocity = new Vector2(-ns * 2f, nsU * 2f);
				//Debug.Log("3n)" + " " + ns + " " + nsU);
				ns = 0f;
				nsU = 0f;
				//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeedUp), ForceMode2D.Impulse);
			}
			else if (rightCollision && ns > 0f && ns < 0.2f)
			{
				//rb.AddForce(transform.right * ns * 10, ForceMode2D.Impulse);
				//rb.AddForce(transform.up * -nsU * 10, ForceMode2D.Impulse);
				rb.velocity = new Vector2(ns * 2f, -nsU * 2f);
				//Debug.Log("4n)" + " " + ns + " " + nsU);
				ns = 0f;
				nsU = 0f;
				//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeedUp), ForceMode2D.Impulse);

			}
			ImpulsePolAfter = true;
			alreadyImpulse = true;
		}






		//else if (rightCollision && normalSpeed > 0f || normalSpeed < 0f)
		// {
		//	rb.AddForce(transform.right * -normalSpeed * 10, ForceMode2D.Impulse);
		//	rb.AddForce(transform.up * normalSpeedUp * 10, ForceMode2D.Impulse);
		//	//rightCollision = false;
		//}
		//else if (!rightCollision && normalSpeedUp > 0f || normalSpeedUp < 0f)
		//{
		//	rb.AddForce(transform.right * normalSpeed * 10, ForceMode2D.Impulse);
		//	rb.AddForce(transform.up * -normalSpeedUp * 10, ForceMode2D.Impulse);
		//	//rightCollision = true;
		//}


		//Debug.Log("ImpulsePol" + " " + XvelI + " " + YvelI);
		//SM.CameraShake();
		//GetComponent<TraumaInducer>().
	}

	public void Cards(bool OtherPlayers)
    {
		if (Player == 1)
		{
			if (!OtherPlayers)
            {
				if (p1 != null)
				{
					p1.Cards(true);
				}
				if (p2 != null)
				{
					p2.Cards(true);
				}
				if (p3 != null)
				{
					p3.Cards(true);
				}
			}
			

			Freezing = PlayerPrefs.GetFloat("Freezing1");
			Energizer = PlayerPrefs.GetFloat("Energizer1");
			Bouncy = PlayerPrefs.GetFloat("Bouncy1");
			FriendOfGlass = PlayerPrefs.GetFloat("Friend of Glass1");
			HMRTakealookaround = PlayerPrefs.GetFloat("HMRLook around1");
			WaveSpeed = PlayerPrefs.GetFloat("WaveSpeed1");
			TripleTake = PlayerPrefs.GetFloat("TripleTake1"); 
			if (TripleTake > 0)
            {
				HMRTripleTake = PlayerPrefs.GetFloat("HMRTripleTake1");
				if (HMRTripleTake > 0)
				{
					//WaveSpeedModifier = PlayerPrefs.GetFloat("WaveSpeedModifier1");
					//WaveScaleSpeedModifier = PlayerPrefs.GetFloat("WaveScaleSpeedModifier1");
					PlayerPrefs.SetFloat("HMRTripleTake1", HMRTripleTake - 1);
					Bubbles.Bubble(8, 1, HMRTripleTake);
				}
				else if (HMRTripleTake <= 0)
                {
					TripleTake = 0;
					PlayerPrefs.SetFloat("TripleTake1", 0);
				}
			}
			if (WaveSpeed >= 711 && WaveSpeed <= 717)
			{
				HMRWaveSpeed = PlayerPrefs.GetFloat("HMRWaveSpeed1");
				if (HMRWaveSpeed > 0)
				{
					WaveSpeedModifier = PlayerPrefs.GetFloat("WaveSpeedModifier1");
					WaveScaleSpeedModifier = PlayerPrefs.GetFloat("WaveScaleSpeedModifier1");
					PlayerPrefs.SetFloat("HMRWaveSpeed1", HMRWaveSpeed - 1);
					Bubbles.Bubble(7, float.Parse(WaveSpeed.ToString().Remove(0, 2)), HMRWaveSpeed);
				}
			}
			if (HMRTakealookaround > 0)
			{
				Takealookaround = PlayerPrefs.GetFloat("Take a look around1");
			}
			if (Freezing >= 111 && Freezing <= 117)
			{
				HMRFreezing = PlayerPrefs.GetFloat("HMRFreezing1");
				if (HMRFreezing > 0)
                {
					FreezingTime = PlayerPrefs.GetFloat("FreezingTime1");
					FreezingMultSaved = PlayerPrefs.GetFloat("FreezingMult1");
					FreezingColor = PlayerPrefs.GetFloat("FreezingColor1");
					PlayerPrefs.SetFloat("HMRFreezing1", HMRFreezing - 1);
					Bubbles.Bubble(1, float.Parse(Freezing.ToString().Remove(0, 2)), HMRFreezing);
				}
			}
			if (Energizer >= 211 && Energizer <= 217)
			{
				HMREnergizer = PlayerPrefs.GetFloat("HMREnergizer1");
				if (HMREnergizer > 0)
                {
					MaxSpeed = PlayerPrefs.GetFloat("MaxSpeed1");
					Acceleration = PlayerPrefs.GetFloat("Acceleration1");
					PlayerPrefs.SetFloat("HMREnergizer1", HMREnergizer - 1);
					Bubbles.Bubble(2, float.Parse(Energizer.ToString().Remove(0, 2)), HMREnergizer);

				}
			}
			if (Bouncy >= 311 && Bouncy <= 317)
			{
				HMRBouncy = PlayerPrefs.GetFloat("HMRBouncy1");
				if (HMRBouncy > 0)
				{
					BouncyForce = PlayerPrefs.GetFloat("BouncyForce1");
					BouncySelfForce = PlayerPrefs.GetFloat("BouncySelfForce1");
                    PlayerPrefs.SetFloat("HMRBouncy1", HMRBouncy - 1);
					Bubbles.Bubble(3, float.Parse(Bouncy.ToString().Remove(0, 2)), HMRBouncy);

				}
			}
			if (FriendOfGlass == 41)
            {

            }
			if (Takealookaround >= 511 && Takealookaround <= 517)
			{
				HMRTakealookaround = PlayerPrefs.GetFloat("HMRLook around1");
                if (HMRTakealookaround > 0)
                {
                    TakealookaroundTime = PlayerPrefs.GetFloat("Take a look aroundTime1");
                    TakealookaroundMaxSpeed = PlayerPrefs.GetFloat("Take a look aroundMaxSpeed1");
                    TakealookaroundAcc = PlayerPrefs.GetFloat("Take a look aroundAcc1");
                    StartCoroutine(TakeaLookAround());
					PlayerPrefs.SetFloat("HMRLook around1", HMRTakealookaround - 1);
					Bubbles.Bubble(5, float.Parse(Takealookaround.ToString().Remove(0, 2)), HMRTakealookaround);
				}

				//BouncySelfForce = PlayerPrefs.GetFloat("BouncySelfForce1");
			}

        }
		else if (Player == 2)
		{
			if (!OtherPlayers)
			{
				if (p1 != null)
				{
					p1.Cards(true);
				}
				if (p2 != null)
				{
					p2.Cards(true);
				}
				if (p3 != null)
				{
					p3.Cards(true);
				}
			}
			Freezing = PlayerPrefs.GetFloat("Freezing2");
			Energizer = PlayerPrefs.GetFloat("Energizer2");
			Bouncy = PlayerPrefs.GetFloat("Bouncy2");
			FriendOfGlass = PlayerPrefs.GetFloat("Friend of Glass2");
			HMRTakealookaround = PlayerPrefs.GetFloat("HMRLook around2");
			WaveSpeed = PlayerPrefs.GetFloat("WaveSpeed2");
			TripleTake = PlayerPrefs.GetFloat("TripleTake2");
			if (TripleTake > 0)
			{
				HMRTripleTake = PlayerPrefs.GetFloat("HMRTripleTake2");
				if (HMRTripleTake > 0)
				{
					//WaveSpeedModifier = PlayerPrefs.GetFloat("WaveSpeedModifier1");
					//WaveScaleSpeedModifier = PlayerPrefs.GetFloat("WaveScaleSpeedModifier1");
					PlayerPrefs.SetFloat("HMRTripleTake2", HMRTripleTake - 1);
					Bubbles.Bubble(8, 1, HMRTripleTake);
				}
				else if (HMRTripleTake <= 0)
				{
					TripleTake = 0;
					PlayerPrefs.SetFloat("TripleTake2", 0);
				}
			}
			if (WaveSpeed >= 721 && WaveSpeed <= 727)
			{
				HMRWaveSpeed = PlayerPrefs.GetFloat("HMRWaveSpeed2");
				if (HMRWaveSpeed > 0)
				{
					WaveSpeedModifier = PlayerPrefs.GetFloat("WaveSpeedModifier2");
					WaveScaleSpeedModifier = PlayerPrefs.GetFloat("WaveScaleSpeedModifier2");
					PlayerPrefs.SetFloat("HMRWaveSpeed2", HMRWaveSpeed - 1);
					Bubbles.Bubble(7, float.Parse(WaveSpeed.ToString().Remove(0, 2)), HMRWaveSpeed);
				}
			}
			if (HMRTakealookaround > 0)
			{
				Takealookaround = PlayerPrefs.GetFloat("Take a look around2");
			}
			//Takealookaround = PlayerPrefs.GetFloat("Take a look around2");
			if (Freezing >= 121 && Freezing <= 127)
			{
				HMRFreezing = PlayerPrefs.GetFloat("HMRFreezing2");
				if (HMRFreezing > 0)
				{
					FreezingTime = PlayerPrefs.GetFloat("FreezingTime2");
					FreezingMultSaved = PlayerPrefs.GetFloat("FreezingMult2");
					FreezingColor = PlayerPrefs.GetFloat("FreezingColor2");
					PlayerPrefs.SetFloat("HMRFreezing2", HMRFreezing - 1);
					Bubbles.Bubble(1, float.Parse(Freezing.ToString().Remove(0, 2)), HMRFreezing);
				}
			}
			if (Energizer >= 221 && Energizer <= 227)
			{
				HMREnergizer = PlayerPrefs.GetFloat("HMREnergizer2");
				if (HMREnergizer > 0)
				{
					MaxSpeed = PlayerPrefs.GetFloat("MaxSpeed2");
					Acceleration = PlayerPrefs.GetFloat("Acceleration2");
					PlayerPrefs.SetFloat("HMREnergizer2", HMREnergizer - 1);
					Bubbles.Bubble(2, float.Parse(Energizer.ToString().Remove(0, 2)), HMREnergizer);
				}
			}
			if (Bouncy >= 321 && Bouncy <= 327)
			{
				HMRBouncy = PlayerPrefs.GetFloat("HMRBouncy2");
				if (HMRBouncy > 0)
				{
					BouncyForce = PlayerPrefs.GetFloat("BouncyForce2");
					BouncySelfForce = PlayerPrefs.GetFloat("BouncySelfForce2");
					PlayerPrefs.SetFloat("HMRBouncy2", HMRBouncy - 1);
					Bubbles.Bubble(3, float.Parse(Bouncy.ToString().Remove(0, 2)), HMRBouncy);
				}
			}
			if (FriendOfGlass == 42)
			{

			}
			if (Takealookaround >= 521 && Takealookaround <= 527)
			{
				HMRTakealookaround = PlayerPrefs.GetFloat("HMRLook around2");
				if (HMRTakealookaround > 0)
				{
					TakealookaroundTime = PlayerPrefs.GetFloat("Take a look aroundTime2");
				TakealookaroundMaxSpeed = PlayerPrefs.GetFloat("Take a look aroundMaxSpeed2");
				TakealookaroundAcc = PlayerPrefs.GetFloat("Take a look aroundAcc2");
				StartCoroutine(TakeaLookAround());
					PlayerPrefs.SetFloat("HMRLook around2", HMRTakealookaround - 1);
					Bubbles.Bubble(5, float.Parse(Takealookaround.ToString().Remove(0, 2)), HMRTakealookaround);
				}
				//BouncySelfForce = PlayerPrefs.GetFloat("BouncySelfForce1");
			}
		}
		else if (Player == 3)
		{
			if (!OtherPlayers)
			{
				if (p1 != null)
				{
					p1.Cards(true);
				}
				if (p2 != null)
				{
					p2.Cards(true);
				}
				if (p3 != null)
				{
					p3.Cards(true);
				}
			}
			Freezing = PlayerPrefs.GetFloat("Freezing3");
			Energizer = PlayerPrefs.GetFloat("Energizer3");
			Bouncy = PlayerPrefs.GetFloat("Bouncy3");
			FriendOfGlass = PlayerPrefs.GetFloat("Friend of Glass3");
			HMRTakealookaround = PlayerPrefs.GetFloat("HMRLook around3");
			WaveSpeed = PlayerPrefs.GetFloat("WaveSpeed3");
			TripleTake = PlayerPrefs.GetFloat("TripleTake3");
			if (TripleTake > 0)
			{
				HMRTripleTake = PlayerPrefs.GetFloat("HMRTripleTake3");
				if (HMRTripleTake > 0)
				{
					//WaveSpeedModifier = PlayerPrefs.GetFloat("WaveSpeedModifier1");
					//WaveScaleSpeedModifier = PlayerPrefs.GetFloat("WaveScaleSpeedModifier1");
					PlayerPrefs.SetFloat("HMRTripleTake3", HMRTripleTake - 1);
					Bubbles.Bubble(8, 1, HMRTripleTake);
				}
				else if (HMRTripleTake <= 0)
				{
					TripleTake = 0;
					PlayerPrefs.SetFloat("TripleTake3", 0);
				}
			}
			if (WaveSpeed >= 731 && WaveSpeed <= 737)
			{
				HMRWaveSpeed = PlayerPrefs.GetFloat("HMRWaveSpeed3");
				if (HMRWaveSpeed > 0)
				{
					WaveSpeedModifier = PlayerPrefs.GetFloat("WaveSpeedModifier3");
					WaveScaleSpeedModifier = PlayerPrefs.GetFloat("WaveScaleSpeedModifier3");
					PlayerPrefs.SetFloat("HMRWaveSpeed3", HMRWaveSpeed - 1);
					Bubbles.Bubble(7, float.Parse(WaveSpeed.ToString().Remove(0, 2)), HMRWaveSpeed);
				}
			}
			if (HMRTakealookaround > 0)
			{
				Takealookaround = PlayerPrefs.GetFloat("Take a look around3");
			}
			if (Freezing >= 131 && Freezing <= 137)
			{
				HMRFreezing = PlayerPrefs.GetFloat("HMRFreezing3");
				if (HMRFreezing > 0)
				{
					FreezingTime = PlayerPrefs.GetFloat("FreezingTime3");
					FreezingMultSaved = PlayerPrefs.GetFloat("FreezingMult3");
					FreezingColor = PlayerPrefs.GetFloat("FreezingColor3");
					PlayerPrefs.SetFloat("HMRFreezing3", HMRFreezing - 1);
					Bubbles.Bubble(1, float.Parse(Freezing.ToString().Remove(0, 2)), HMRFreezing);
				}
			}
			if (Energizer >= 231 && Energizer <= 237)
			{
				HMREnergizer = PlayerPrefs.GetFloat("HMREnergizer3");
				if (HMREnergizer > 0)
				{
					MaxSpeed = PlayerPrefs.GetFloat("MaxSpeed3");
				Acceleration = PlayerPrefs.GetFloat("Acceleration3");
					PlayerPrefs.SetFloat("HMREnergizer3", HMREnergizer - 1);
					Bubbles.Bubble(2, float.Parse(Energizer.ToString().Remove(0, 2)), HMREnergizer);
				}
			}
			if (Bouncy >= 331 && Bouncy <= 337)
			{
				HMRBouncy = PlayerPrefs.GetFloat("HMRBouncy3");
				if (HMRBouncy > 0)
				{
					BouncyForce = PlayerPrefs.GetFloat("BouncyForce3");
				BouncySelfForce = PlayerPrefs.GetFloat("BouncySelfForce3");
					PlayerPrefs.SetFloat("HMRBouncy3", HMRBouncy - 1);
					Bubbles.Bubble(3, float.Parse(Bouncy.ToString().Remove(0, 2)), HMRBouncy);
				}
			}
			if (FriendOfGlass == 43)
			{

			}
			if (Takealookaround >= 531 && Takealookaround <= 537)
			{
				HMRTakealookaround = PlayerPrefs.GetFloat("HMRLook around3");
				if (HMRTakealookaround > 0)
				{
					TakealookaroundTime = PlayerPrefs.GetFloat("Take a look aroundTime3");
				TakealookaroundMaxSpeed = PlayerPrefs.GetFloat("Take a look aroundMaxSpeed3");
				TakealookaroundAcc = PlayerPrefs.GetFloat("Take a look aroundAcc3");
				StartCoroutine(TakeaLookAround());
					PlayerPrefs.SetFloat("HMRLook around3", HMRTakealookaround - 1);
					Bubbles.Bubble(5, float.Parse(Takealookaround.ToString().Remove(0, 2)), HMRTakealookaround);
				}
				//BouncySelfForce = PlayerPrefs.GetFloat("BouncySelfForce1");
			}
		}
		else if (Player == 4)
		{
			if (!OtherPlayers)
			{
				if (p1 != null)
				{
					p1.Cards(true);
				}
				if (p2 != null)
				{
					p2.Cards(true);
				}
				if (p3 != null)
				{
					p3.Cards(true);
				}
			}
			Freezing = PlayerPrefs.GetFloat("Freezing4");
			Energizer = PlayerPrefs.GetFloat("Energizer4");
			Bouncy = PlayerPrefs.GetFloat("Bouncy4");
			FriendOfGlass = PlayerPrefs.GetFloat("Friend of Glass4");
			HMRTakealookaround = PlayerPrefs.GetFloat("HMRLook around4");
			WaveSpeed = PlayerPrefs.GetFloat("WaveSpeed4");
			TripleTake = PlayerPrefs.GetFloat("TripleTake4");
			if (TripleTake > 0)
			{
				HMRTripleTake = PlayerPrefs.GetFloat("HMRTripleTake4");
				if (HMRTripleTake > 0)
				{
					//WaveSpeedModifier = PlayerPrefs.GetFloat("WaveSpeedModifier1");
					//WaveScaleSpeedModifier = PlayerPrefs.GetFloat("WaveScaleSpeedModifier1");
					PlayerPrefs.SetFloat("HMRTripleTake4", HMRTripleTake - 1);
					Bubbles.Bubble(8, 1, HMRTripleTake);
				}
				else if (HMRTripleTake <= 0)
				{
					TripleTake = 0;
					PlayerPrefs.SetFloat("TripleTake4", 0);
				}
			}
			if (WaveSpeed >= 741 && WaveSpeed <= 747)
			{
				HMRWaveSpeed = PlayerPrefs.GetFloat("HMRWaveSpeed4");
				if (HMRWaveSpeed > 0)
				{
					WaveSpeedModifier = PlayerPrefs.GetFloat("WaveSpeedModifier4");
					WaveScaleSpeedModifier = PlayerPrefs.GetFloat("WaveScaleSpeedModifier4");
					PlayerPrefs.SetFloat("HMRWaveSpeed4", HMRWaveSpeed - 1);
					Bubbles.Bubble(7, float.Parse(WaveSpeed.ToString().Remove(0, 2)), HMRWaveSpeed);
				}
			}
			if (HMRTakealookaround > 0)
			{
				Takealookaround = PlayerPrefs.GetFloat("Take a look around4");
			}
			if (Freezing >= 141 && Freezing <= 147)
			{
				HMRFreezing = PlayerPrefs.GetFloat("HMRFreezing4");
				if (HMRFreezing > 0)
				{
					FreezingTime = PlayerPrefs.GetFloat("FreezingTime4");
					FreezingMultSaved = PlayerPrefs.GetFloat("FreezingMult4");
					FreezingColor = PlayerPrefs.GetFloat("FreezingColor4");

					PlayerPrefs.SetFloat("HMRFreezing4", HMRFreezing - 1);
					Bubbles.Bubble(1, float.Parse(Freezing.ToString().Remove(0, 2)), HMRFreezing);
				}
			}
			if (Energizer >= 241 && Energizer <= 247)
			{
				HMREnergizer = PlayerPrefs.GetFloat("HMREnergizer4");
				if (HMREnergizer > 0)
				{
					MaxSpeed = PlayerPrefs.GetFloat("MaxSpeed4");
				Acceleration = PlayerPrefs.GetFloat("Acceleration4");
					PlayerPrefs.SetFloat("HMREnergizer4", HMREnergizer - 1);
					Bubbles.Bubble(2, float.Parse(Energizer.ToString().Remove(0, 2)), HMREnergizer);
				}
			}
			if (Bouncy >= 341 && Bouncy <= 347)
			{
				HMRBouncy = PlayerPrefs.GetFloat("HMRBouncy4");
				if (HMRBouncy > 0)
				{
					BouncyForce = PlayerPrefs.GetFloat("BouncyForce4");
				BouncySelfForce = PlayerPrefs.GetFloat("BouncySelfForce4");
					PlayerPrefs.SetFloat("HMRBouncy4", HMRBouncy - 1);
					Bubbles.Bubble(3, float.Parse(Bouncy.ToString().Remove(0, 2)), HMRBouncy);
				}
			}
			if (FriendOfGlass == 44)
			{

			}
			if (Takealookaround >= 541 && Takealookaround <= 547)
			{
				HMRTakealookaround = PlayerPrefs.GetFloat("HMRLook around4");
				if (HMRTakealookaround > 0)
				{
					TakealookaroundTime = PlayerPrefs.GetFloat("Take a look aroundTime3");
				TakealookaroundMaxSpeed = PlayerPrefs.GetFloat("Take a look aroundMaxSpeed3");
				TakealookaroundAcc = PlayerPrefs.GetFloat("Take a look aroundAcc3");
				StartCoroutine(TakeaLookAround());
					PlayerPrefs.SetFloat("HMRLook around4", HMRTakealookaround - 1);
					Bubbles.Bubble(5, float.Parse(Takealookaround.ToString().Remove(0, 2)), HMRTakealookaround);
				}
				//BouncySelfForce = PlayerPrefs.GetFloat("BouncySelfForce1");
			}
		}
		PlayerPrefs.SetFloat("CardsAfterMonetu", 0);
	}

	public void Impulse(float ns, float nsU)
    {
		
		
	}

}
