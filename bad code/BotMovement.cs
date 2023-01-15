using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMovement : MonoBehaviour
{
	public float normalSpeed = 10f;
	public float normalSpeedUp = 10f;
	[SerializeField] float h;
	[SerializeField] float v;
	[SerializeField] public float hss = 5f;
	[SerializeField] public float hssu = 5f;
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
	//public CirclesMovement scriptPlayerController;
	//private bool isMine;
	public float PublicCircle;
	[SerializeField] float circle;
	[SerializeField] bool rightCollision = true;
	float ns;
	float nsU;
	float SpeedTime1;
	float SpeedTime2 = 0;
	//[SerializeField] private Joystick joystick;
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
	private bool Alive = true;
	bool alreadyScore = false;
	bool Yskoritel;
	[SerializeField] private GameObject DNC;
	public float F;
	public float BotSpeedUp;
	public float BotSpeed;
	public GameObject[] Piece;
	public bool area = false;
	GameObject circleGaOb;
	bool newHss;
	[SerializeField] SpriteRenderer ThisSpriteRenderer;
	[SerializeField] CircleCollider2D ThisCircleCollider2D;
	public List<GameObject> childrenList2 = new List<GameObject>();
	public GameObject BA;
	public bool FreezingBool;
	public float HMPlayersF;
	public GameObject ObstacleCheck;
	public string gamemode;
	public float Force = 1f;
	public string CurrentScene;
	public bool OneTime = true;
	public float difficulty;
	public CameraScript CS;
	public CirclesMovement Player;
	public float FreezingMult = 1;
	public bool FreezeBotBool;
	//public GameObject BotObstacleCollider;

	//public GameObject MyCircle;
	//public GameObject gameObject;
	// Start is called before the first frame update
	void Start()
	{

		//List<Transform> childrenList = new List<Transform>();
		//foreach (Transform childTrans in transform)
		//	childrenList.Add(childTrans);
		//foreach (Transform childTrans in childrenList)
		//{
		//	if (childTrans.tag == "Bullet")
		//	{
		//		Mesh mesh = childTrans.GetComponent<MeshFilter>().mesh;
		//		Vector3[] vertices = mesh.vertices;

		//		// create new colors array where the colors will be created.
		//		Color[] colors = new Color[vertices.Length];

		//		for (int i = 0; i < vertices.Length; i++)
		//			colors[i] = new Color(255, 182, 182);

		//		// assign the array of colors to the Mesh.
		//		mesh.colors = colors;
		//	}
		//	//else if (childTrans.gameObject.name == "newCircle2")
		//	//{
		//	//	childTrans.parent = null;
		//	//}
		//}
		//this.gameObject.tag = "Bot";
		HMPlayersF = PlayerPrefs.GetFloat("HMPlayersF");
		if (HMPlayersF == 0)
        {
			HMPlayersF = 2;
			PlayerPrefs.SetFloat("HMPlayersF", 2);
		}

		SM.GetActiveSceneForBot(this);


	}
	private void Awake()
	{
		CurrentScene = PlayerPrefs.GetString("CurrentScene");
		rb = GetComponent<Rigidbody2D>();
		T = GetComponent<Transform>();
		//SM = (SpawnManager)FindObjectOfType(typeof(SpawnManager));
		//nn = GameObject.Find("Noname").GetComponent<Noname>();
		SM = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
		//GetComponentInChildren<Canvas>().worldCamera = GameObject.Find("Camera").GetComponent<Camera>();
		//SP1 = PlayerPrefs.GetFloat("SP1");
		//SP2 = PlayerPrefs.GetFloat("SP2");
		//SP3 = PlayerPrefs.GetFloat("SP3");
		//SP4 = PlayerPrefs.GetFloat("SP4");
		//F = Random.Range(50f, 1000f);
	}

	private void LateUpdate()
	{
		alreadyImpulse = false;
		alreadyImpulsePlayer = false;
		Yskoritel = true;
	}
	public void FreezeBot(float ft, BotMovement cm, float fms, float color,  FrostEffect fe)
    {
		StartCoroutine(Freeze(ft, cm, fms, color, fe));
	}
	public IEnumerator Freeze(float ft, BotMovement cm, float fms, float color, FrostEffect fe)
	{
		//cm.FreezingBool = true;
		cm.FreezeBotBool = true;
		cm.FreezingMult = fms;
		cm.hss = cm.hss / (float)1.5;
		cm.hssu = cm.hssu / (float)1.5;
		fe.FrostAmount = (1 - (float)color) * (float)0.7;
		fe.enabled = true;
		yield return new WaitForSecondsRealtime(ft);
		//fe.FrostAmount = (1 - (float)color) * (float)0.7;
		fe.enabled = false;
		cm.FreezingMult = 1;
		cm.FreezeBotBool = false;
		cm.FreezingBool = false;
		
		//cm.FreezingBool = false;
	}

	public IEnumerator BotObstacleOff()
	{
		//print(Time.time);
		ObstacleCheck.SetActive(false);
		yield return new WaitForSecondsRealtime((float)0.3);
		ObstacleCheck.SetActive(true);
		//print(Time.time);

	}

	// Update is called once per frame
	void Update()
	{

		

		//if ((((joystick.Horizontal > 0f || joystick.Horizontal < 0f) || (joystick.Vertical > 0f || joystick.Vertical < 0f)) && hss < 16f && hssu < 16f))
		//{
		//if (!FreezingBool)
        //{
			if (hss < 9 || hssu < 9)
			{
				SpeedTime1 = SpeedTime1 + 1 * Time.deltaTime;
				if ((SpeedTime1 > SpeedTime2))
				{
					SpeedTime2 = SpeedTime2 + 18f * Time.deltaTime;
					hss = hss + 15f * FreezingMult * Time.deltaTime;
					hssu = hssu + 15f * FreezingMult * Time.deltaTime;
				}
			}
		//}
		
		
		//}


		//if (((joystick.Horizontal == 0f || joystick.Horizontal == 0f) && (joystick.Vertical == 0f || joystick.Vertical == 0f)))
		//{
		//	hss = 6f;
		//	hssu = 6f;
		//}

		//if (T.position.x > 15 || T.position.x < -15 || T.position.y > 9 || T.position.y < -9)
		//{
		//	Destroy();
		//}



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
		if (!FreezeBotBool)
        {
			if (area)
			{
				GoToPlayer();
			}
			else if ((rb.velocity.x < 3f && rb.velocity.x > -3f && rb.velocity.y < 3f && rb.velocity.y > -3f) && !area)
			{
				OneTime = true;
				newHss = false;
				alreadyImpulsePlayer = false;
				normalSpeed = hss;
				normalSpeedUp = hssu;
				//if (rb.velocity.x == 0f && rb.velocity.y == 0f)
				//{

				transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, normalSpeed * Time.deltaTime);
				transform.position = Vector3.MoveTowards(transform.position, transform.position + directionUp, (normalSpeedUp) * Time.deltaTime);
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

					rb.velocity = new Vector2(0, 0);


					//Debug.Log("1");
					//normalSpeed = normalSpeed / 10;
					//normalSpeedUp = normalSpeedUp / 10;
				}
			}
			else if (!area)
			{
				//if (OneTime)
				//{
					BotSpeed = Random.Range(-12f, 12f) * FreezingMult;
					BotSpeedUp = Random.Range(-12f, 12f) * FreezingMult;
					if (BotSpeed == BotSpeedUp)
					{
						BotSpeedUp = Random.Range(-12f, 12f) * FreezingMult;
					}
					//OneTime = false;
				//}
				if ((BotSpeed != 0 || BotSpeedUp != 0) && (BotSpeed != BotSpeedUp))
				{
					hss = BotSpeed;
					hssu = BotSpeedUp;

				}
				else
				{
					hss = 6f;
					hssu = 6f;
				}
				normalSpeed = 0f;
				normalSpeedUp = 0f;
			}
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

	public IEnumerator WaitToNextArea()
	{
		//print(Time.time);
		area = false;
		BA.SetActive(false);
		yield return new WaitForSecondsRealtime((float)2);
		BA.SetActive(true);
		//print(Time.time);

	}

	private void OnTriggerEnter2D(Collider2D otherE)
    {
		if (otherE.tag == "Bullet")
		{
			GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Discrete;
		}
		else
		{
			GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;
		}

		if (otherE.gameObject.tag == "Player")
		{
			StartCoroutine(WaitToNextArea());
			if (HMPlayersF != 1)
			{
				otherE.gameObject.GetComponent<CirclesMovement>().Destroy();
				area = false;
			}

			var a = otherE.gameObject;
			var oR = a.GetComponent<Rigidbody2D>();
			var Ac = a.GetComponent<CirclesMovement>();
			float v = oR.velocity.x;
			float vU = oR.velocity.y;
			if (otherE.gameObject.GetComponent<CirclesMovement>().Takealookaround == 0)
			{
				ns = normalSpeed;
				nsU = normalSpeedUp;
				if ((ns > 0 || nsU > 0 || ns < 0 || nsU < 0))
				{
					if (!alreadyImpulsePlayer)
					{
						if (!FreezeBotBool)
                        {
							otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
							otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(ns * 2, nsU * 2, 0f);
						}
						GetComponent<Rigidbody2D>().velocity = new Vector3(Ac.normalSpeed * 4f, Ac.normalSpeedUp * 4f, 0f);
						//Debug.Log("Player impulse" + " " + ns + " " + nsU + " " + this.gameObject.name + " " + rb.velocity);

						//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
						ns = 0;
						nsU = 0;
						//((ns == 0 && nsU == 0) && (vs != 0 || vsU != 0)) && 
					}
				}
				else if ((((otherE.gameObject.GetComponent<CirclesMovement>().normalSpeed <= 0) && (vs > 0)) || ((otherE.gameObject.GetComponent<CirclesMovement>().normalSpeed >= 0) && (vs < 0)) || ((otherE.gameObject.GetComponent<CirclesMovement>().normalSpeedUp >= 0) && (vsU < 0)) || ((otherE.gameObject.GetComponent<CirclesMovement>().normalSpeedUp <= 0) && (vsU > 0))))//((ns == 0 || nsU == 0) && (vs != 0 || vsU !=0) && ImpulsePolAfter)
				{
					if (!alreadyImpulsePlayer)
					{
						//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
						//otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(vs * 2, vsU * 2, 0f);
						//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * vs, ForceMode2D.Impulse);
						//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * vsU, ForceMode2D.Impulse);
						if (!FreezeBotBool)
						{
							otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(vs, vsU, 0f);
						}
						//Debug.Log("vs impulse player" + " " + vs + " " + vsU + " " + this.gameObject.name);

						//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
						ns = 0;
						nsU = 0;
						//if ((vs > 0f || vsU > 0f))
						//{

						//	//rb.AddForce(transform.right * -XvelI * 10f, ForceMode2D.Impulse);
						//	//rb.AddForce(transform.up * YvelI * 10f, ForceMode2D.Impulse);
						//	otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(vs, vsU, 0f);
						//	//Debug.Log("1)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

						//}
						//else if ((vs < 0f || vsU < 0f))
						//{
						//	//rb.AddForce(transform.right * XvelI * 10f, ForceMode2D.Impulse);

						//	//rb.AddForce(transform.up * -YvelI * 10f, ForceMode2D.Impulse);
						//	otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(vs, vsU, 0f);
						//	//Debug.Log("2)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

						//}
						//else if (!rightCollision && YvelI > 0f)
						//{
						//	//rb.AddForce(transform.right * -XvelI * 10f, ForceMode2D.Impulse);
						//	//rb.AddForce(transform.up * YvelI * 10f, ForceMode2D.Impulse);
						//	rb.velocity = new Vector2(-XvelI, YvelI);
						//	//Debug.Log("3)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

						//}
						//else if (rightCollision && XvelI > 0f)
						//{
						//	//rb.AddForce(transform.right * XvelI * 10f, ForceMode2D.Impulse);
						//	//rb.AddForce(transform.up * -YvelI * 10f, ForceMode2D.Impulse);
						//	rb.velocity = new Vector2(XvelI, -YvelI);
						//	//Debug.Log("4)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

						//}
					}
				}
			}
		}
		else if (otherE.gameObject.tag == "Bot")
		{
			//float ns = otherE.gameObject.GetComponent<CirclesMovement>().normalSpeed;
			//float nsU = otherE.gameObject.GetComponent<CirclesMovement>().normalSpeedUp;
			//float vs = otherE.gameObject.GetComponent<Rigidbody2D>().velocity.x;
			//float vsU = otherE.gameObject.GetComponent<Rigidbody2D>().velocity.y;
			//otherE.gameObject.GetComponent<CirclesMovement>().Impulse(normalSpeed*10f, normalSpeedUp*10f);
			//otherE.GetComponent<Rigidbody2D>().AddForce(new Vector3(((normalSpeed))* 7f, (normalSpeedUp)*7f, 0f), ForceMode2D.Impulse);
			////Debug.Log("Impulse" + " " + alreadyImpulsePlayer + " " + otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer);
			vs = rb.velocity.x;
			vsU = rb.velocity.y;
			ns = normalSpeed;
			nsU = normalSpeedUp;
			//if (!alreadyImpulsePlayer && !otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer) //  

			if (ns > 0 || nsU > 0 || ns < 0 || nsU < 0)
			{
				if (!alreadyImpulsePlayer)
				{
					otherE.gameObject.GetComponent<BotMovement>().alreadyImpulsePlayer = true;
					otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(ns * 2, nsU * 2, 0f);
					//Debug.Log("Player impulse" + " " + ns + " " + nsU + " " + this.gameObject.name + " " + rb.velocity);

					//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
					ns = 0;
					nsU = 0;
				}
			}
			//((ns == 0 && nsU == 0) && (vs != 0 || vsU != 0)) && 
			else if ((((otherE.gameObject.GetComponent<BotMovement>().normalSpeed <= 0) && (vs > 0)) || ((otherE.gameObject.GetComponent<BotMovement>().normalSpeed >= 0) && (vs < 0)) || ((otherE.gameObject.GetComponent<BotMovement>().normalSpeedUp >= 0) && (vsU < 0)) || ((otherE.gameObject.GetComponent<BotMovement>().normalSpeedUp <= 0) && (vsU > 0))))//((ns == 0 || nsU == 0) && (vs != 0 || vsU !=0) && ImpulsePolAfter)
			{
				//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
				//otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(vs * 2, vsU * 2, 0f);
				//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * vs, ForceMode2D.Impulse);
				//otherE.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * vsU, ForceMode2D.Impulse);
				otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(vs, vsU, 0f);

				//Debug.Log("vs impulse player" + " " + vs + " " + vsU + " " + this.gameObject.name);

				//otherE.gameObject.GetComponent<CirclesMovement>().alreadyImpulsePlayer = true;
				ns = 0;
				nsU = 0;
				//if ((vs > 0f || vsU > 0f))
				//{

				//	//rb.AddForce(transform.right * -XvelI * 10f, ForceMode2D.Impulse);
				//	//rb.AddForce(transform.up * YvelI * 10f, ForceMode2D.Impulse);
				//	otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(vs, vsU, 0f);
				//	//Debug.Log("1)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

				//}
				//else if ((vs < 0f || vsU < 0f))
				//{
				//	//rb.AddForce(transform.right * XvelI * 10f, ForceMode2D.Impulse);

				//	//rb.AddForce(transform.up * -YvelI * 10f, ForceMode2D.Impulse);
				//	otherE.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(vs, vsU, 0f);
				//	//Debug.Log("2)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

				//}
				//else if (!rightCollision && YvelI > 0f)
				//{
				//	//rb.AddForce(transform.right * -XvelI * 10f, ForceMode2D.Impulse);
				//	//rb.AddForce(transform.up * YvelI * 10f, ForceMode2D.Impulse);
				//	rb.velocity = new Vector2(-XvelI, YvelI);
				//	//Debug.Log("3)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

				//}
				//else if (rightCollision && XvelI > 0f)
				//{
				//	//rb.AddForce(transform.right * XvelI * 10f, ForceMode2D.Impulse);
				//	//rb.AddForce(transform.up * -YvelI * 10f, ForceMode2D.Impulse);
				//	rb.velocity = new Vector2(XvelI, -YvelI);
				//	//Debug.Log("4)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));

				//}
			}
			//

		}
	}
    private void OnTriggerStay2D(Collider2D otherE)
	{
		//if (otherE.GetComponent<Collider2D>().GetType == PolygonCollider2D)
		//Collider2D collider = otherE.GetComponent<Collider2D>();
		//Debug.Log("ColliderEnter");
		





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



		if (otherE.gameObject.tag == "polYgol")
		{
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
					float xcomponent = Mathf.Cos(Mathf.Abs(ygol) * Mathf.PI / 180) * ns * Force;
					float ycomponent = Mathf.Cos(Mathf.Abs(ygol) * Mathf.PI / 180) * nsU * Force;
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
					float xcomponent = Mathf.Cos(ygol * Mathf.PI / 180) * vsYgol * Force;
					float ycomponent = Mathf.Cos(ygol * Mathf.PI / 180) * vsUYgol * Force;
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

		else if (otherE.gameObject.tag == "polUp" && rightCollision)
		{
			rightCollision = false;

		}
		else if (otherE.gameObject.tag == "polRight" && !rightCollision)
		{
			rightCollision = true;
		}
		//rb.AddForce(new Vector2(0, 10000f), ForceMode2D.Impulse);
		else if (otherE.gameObject.tag == "pol")
		{
			XvelI = rb.velocity.x;
			YvelI = rb.velocity.y;
			ns = normalSpeed;
			nsU = normalSpeedUp;
			//rb.velocity = new Vector2(0, 0);
			//rb.constraints = RigidbodyConstraints2D.FreezePosition;
			//rb.constraints = RigidbodyConstraints2D.None;
			//Vector3 contactPoint = other.contacts[0].point;
			//Vector3 center = collider.bounds.center;

			//bool right = contactPoint.x > center.x;
			//bool top = contactPoint.y > center.y;
			//////normalspeed * cos naklona



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
					rb.velocity = new Vector2(-XvelI, YvelI);
					//Debug.Log("3)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));
					XvelI = 0f;
					XvelI = 0f;
				}
				else if (rightCollision && XvelI > 0f)
				{
					//rb.AddForce(transform.right * XvelI * 10f, ForceMode2D.Impulse);
					//rb.AddForce(transform.up * -YvelI * 10f, ForceMode2D.Impulse);
					rb.velocity = new Vector2(XvelI, -YvelI);
					//Debug.Log("4)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));
					XvelI = 0f;
					XvelI = 0f;
				}



				if (rightCollision && (ns > 0f || ns < 0f))
				{
					rb.velocity = new Vector2(-ns * Force, nsU * Force);
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
					rb.velocity = new Vector2(ns * Force, -nsU * Force);
					//Debug.Log("2n)" + " " + ns + " " + nsU);
					ns = 0f;
					nsU = 0f;
					//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeedUp), ForceMode2D.Impulse);
				}
				else if (!rightCollision && nsU > 0f && nsU < 0.2f)
				{
					//rb.AddForce(transform.right * -ns * 10, ForceMode2D.Impulse);
					//rb.AddForce(transform.up * nsU * 10, ForceMode2D.Impulse);
					rb.velocity = new Vector2(-ns * Force, nsU * Force);
					//Debug.Log("3n)" + " " + ns + " " + nsU);
					ns = 0f;
					nsU = 0f;
					//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeedUp), ForceMode2D.Impulse);
				}
				else if (rightCollision && ns > 0f && ns < 0.2f)
				{
					//rb.AddForce(transform.right * ns * 10, ForceMode2D.Impulse);
					//rb.AddForce(transform.up * -nsU * 10, ForceMode2D.Impulse);
					rb.velocity = new Vector2(ns * Force, -nsU * Force);
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


			//Debug.Log("ImpulsePol");
			//SM.CameraShake();
			//GetComponent<TraumaInducer>().
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
			XvelI = rb.velocity.x;
			YvelI = rb.velocity.y;
			ns = normalSpeed;
			nsU = normalSpeedUp;
			//rb.velocity = new Vector2(0, 0);
			//rb.constraints = RigidbodyConstraints2D.FreezePosition;
			//rb.constraints = RigidbodyConstraints2D.None;
			//Vector3 contactPoint = other.contacts[0].point;
			//Vector3 center = collider.bounds.center;

			//bool right = contactPoint.x > center.x;
			//bool top = contactPoint.y > center.y;
			//////normalspeed * cos naklon
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
					rb.velocity = new Vector2(-XvelI, YvelI);
					//Debug.Log("3)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));
					XvelI = 0f;
					XvelI = 0f;
				}
				else if (rightCollision && XvelI > 0f)
				{
					//rb.AddForce(transform.right * XvelI * 10f, ForceMode2D.Impulse);
					//rb.AddForce(transform.up * -YvelI * 10f, ForceMode2D.Impulse);
					rb.velocity = new Vector2(XvelI, -YvelI);
					//Debug.Log("4)" + " " + XvelI.ToString("0.00") + " " + YvelI.ToString("0.00"));
					XvelI = 0f;
					XvelI = 0f;
				}



				if (rightCollision && (ns > 0f || ns < 0f))
				{
					rb.velocity = new Vector2(-ns * Force, nsU * Force);
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
					rb.velocity = new Vector2(ns * Force, -nsU * Force);
					//Debug.Log("2n)" + " " + ns + " " + nsU);
					ns = 0f;
					nsU = 0f;
					//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeedUp), ForceMode2D.Impulse);
				}
				else if (!rightCollision && nsU > 0f && nsU < 0.2f)
				{
					//rb.AddForce(transform.right * -ns * 10, ForceMode2D.Impulse);
					//rb.AddForce(transform.up * nsU * 10, ForceMode2D.Impulse);
					rb.velocity = new Vector2(-ns * Force, nsU * Force);
					//Debug.Log("3n)" + " " + ns + " " + nsU);
					ns = 0f;
					nsU = 0f;
					//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeedUp), ForceMode2D.Impulse);
				}
				else if (rightCollision && ns > 0f && ns < 0.2f)
				{
					//rb.AddForce(transform.right * ns * 10, ForceMode2D.Impulse);
					//rb.AddForce(transform.up * -nsU * 10, ForceMode2D.Impulse);
					rb.velocity = new Vector2(ns * Force, -nsU * Force);
					//Debug.Log("4n)" + " " + ns + " " + nsU);
					ns = 0f;
					nsU = 0f;
					//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * normalSpeed, Mathf.Cos(ygol * Mathf.PI / 180) * -normalSpeedUp), ForceMode2D.Impulse);

				}
				ImpulsePolAfter = true;
				alreadyImpulse = true;
			}
		}
	}
	//private void OnTriggerStay2D(Collider2D otherE)
	//{
	//	if (otherE.gameObject.tag == "pol")
	//	{
	//		if (rightCollision && (((normalSpeed > 0f && normalSpeed < 3f) && (normalSpeedUp > 0f && normalSpeedUp < 0.3f)) || ((normalSpeedUp < 0f && normalSpeedUp > -0.3f) && (normalSpeed < 0f && normalSpeed > -0.3f)) || ((normalSpeedUp < 0f && normalSpeedUp > -0.3f) && (normalSpeed > 0f && normalSpeed < 0.3f)) || ((normalSpeedUp > 0f && normalSpeedUp < 0.3f) && (normalSpeed < 0f && normalSpeed > -0.3f))))
	//		{
	//			if (normalSpeed < 0f)
	//			{
	//				rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
	//				//Debug.Log("2");
	//			}
	//			else if (normalSpeed > 0f)
	//			{
	//				rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
	//				//Debug.Log("3");
	//			}
	//			//if (normalSpeedUp < 0f)
	//			//{
	//			//	rb.AddForce(transform.up * -50, ForceMode2D.Impulse);
	//			//}
	//			//else if (normalSpeedUp > 0f)
	//			//{
	//			//	rb.AddForce(transform.up * 50, ForceMode2D.Impulse);
	//			//}

	//			//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * -10, Mathf.Cos(ygol * Mathf.PI / 180) * 10), ForceMode2D.Impulse);
	//			//Debug.Log("<3 Impulse1");
	//		}
	//		else if (!rightCollision && (((normalSpeed > 0f && normalSpeed < 0.3f) && (normalSpeedUp > 0f && normalSpeedUp < 0.3f)) || ((normalSpeedUp < 0f && normalSpeedUp > -0.3f) && (normalSpeed < 0f && normalSpeed > -0.3f)) || ((normalSpeedUp < 0f && normalSpeedUp > -0.3f) && (normalSpeed > 0f && normalSpeed < 0.3f)) || ((normalSpeedUp > 0f && normalSpeedUp < 0.3f) && (normalSpeed < 0f && normalSpeed > -0.3f))))
	//		{
	//			//if (normalSpeed < 0f)
	//			//{
	//			//	rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
	//			//}
	//			//else if (normalSpeed > 0f)
	//			//{
	//			//	rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
	//			//}
	//			if (normalSpeedUp < 0f)
	//			{
	//				rb.AddForce(transform.up * 50, ForceMode2D.Impulse);
	//				//Debug.Log("4");
	//			}
	//			else if (normalSpeedUp > 0f)
	//			{
	//				rb.AddForce(transform.up * -50, ForceMode2D.Impulse);
	//				//Debug.Log("5");
	//			}
	//			//Debug.Log("<3 Impulse2" + " " + ns + " " + nsU);
	//			//rb.AddForce(transform.right * 50, ForceMode2D.Impulse);

	//			//rb.AddForce(transform.up * -nsU * 50, ForceMode2D.Impulse);
	//			//rb.AddForce(new Vector2(Mathf.Cos(ygol * Mathf.PI / 180) * 10, Mathf.Cos(ygol * Mathf.PI / 180) * -10), ForceMode2D.Impulse);
	//		}
	//	}


	//	if (otherE.gameObject.tag == "polYgol")
	//	{
	//		ygol = otherE.GetComponent<Transform>().rotation.z;
	//		vsYgol = rb.velocity.x;
	//		vsUYgol = rb.velocity.y;
	//		ns = normalSpeed;
	//		nsU = normalSpeedUp;
	//		//if (ygol == 45)
	//		//{
	//		//	rb.AddForce(transform.right * -normalSpeedUp * 10, ForceMode2D.Impulse);
	//		//	rb.AddForce(transform.up * -normalSpeed * 10, ForceMode2D.Impulse);
	//		//}



	//		//rb.velocity = new Vector3(-ycomponent, -xcomponent, 0);

	//		float xcomponent = Mathf.Cos(ygol * Mathf.PI / 180) * ns * 2;
	//		float ycomponent = Mathf.Cos(ygol * Mathf.PI / 180) * nsU * 2;
	//		if ((ygol < 0.5))
	//		{
	//			//rb.velocity = new Vector3(-ycomponent, -xcomponent, 0);
	//			//Debug.Log("impulse ygol<90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
	//			//if (((joystick.Horizontal > 0f && joystick.Horizontal < 0.3f) && (joystick.Vertical > 0f && joystick.Vertical < 0.3f)) || ((joystick.Vertical < 0f && joystick.Vertical > -0.3f) && (joystick.Horizontal < 0f && joystick.Horizontal > -0.3f)))
	//			if (((normalSpeed > 0f && normalSpeed < 0.3f) && (normalSpeedUp > 0f && normalSpeedUp < 0.3f)) || ((normalSpeedUp < 0f && normalSpeedUp > -0.3f) && (normalSpeed < 0f && normalSpeed > -0.3f)) || ((normalSpeedUp < 0f && normalSpeedUp > -0.3f) && (normalSpeed > 0f && normalSpeed < 0.3f)) || ((normalSpeedUp > 0f && normalSpeedUp < 0.3f) && (normalSpeed < 0f && normalSpeed > -0.3f)))
	//			{

	//				if (nsU < 0f)
	//				{
	//					//rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
	//					rb.velocity = new Vector3(10, -xcomponent, 0);
	//					//Debug.Log("6");
	//					//rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
	//				}
	//				else if (nsU > 0f)
	//				{
	//					//rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
	//					rb.velocity = new Vector3(-10, -xcomponent, 0);
	//					//Debug.Log("7");
	//					//rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
	//				}
	//				//Debug.Log("if impulse1");
	//			}
	//		}
	//		else if (ygol > 0.5)
	//		{
	//			if (((normalSpeed > 0f && normalSpeed < 0.3f) && (normalSpeedUp > 0f && normalSpeedUp < 0.3f)) || ((normalSpeedUp < 0f && normalSpeedUp > -0.3f) && (normalSpeed < 0f && normalSpeed > -0.3f)) || ((normalSpeedUp < 0f && normalSpeedUp > -0.3f) && (normalSpeed > 0f && normalSpeed < 0.3f)) || ((normalSpeedUp > 0f && normalSpeedUp < 0.3f) && (normalSpeed < 0f && normalSpeed > -0.3f)))
	//			{

	//				if (nsU < 0f)
	//				{
	//					//rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
	//					rb.velocity = new Vector3(-10, -xcomponent, 0);
	//					//Debug.Log("8");
	//					//rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
	//				}
	//				else if (nsU > 0f)
	//				{
	//					//rb.AddForce(transform.right * -50, ForceMode2D.Impulse);
	//					rb.velocity = new Vector3(10, -xcomponent, 0);
	//					//Debug.Log("9");
	//					//rb.AddForce(transform.right * 50, ForceMode2D.Impulse);
	//				}
	//				//Debug.Log("if impulse2");
	//			}
	//			//Debug.Log("impulse ygol>90" + " " + xcomponent + " " + ycomponent + " ygol = " + ygol);
	//		}
	//		ImpulsePolAfter = true;




	//	}

	//	if (otherE.gameObject.tag == "polYskoritel")
	//	{
	//		rb.AddForce(transform.right * normalSpeed * 30f, ForceMode2D.Impulse);
	//		rb.AddForce(transform.up * normalSpeedUp * 30f, ForceMode2D.Impulse);
	//		//Yskoritel = true;
	//		//rb.drag = 0;
	//	}
	//}
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

	public IEnumerator WaitToRespawn()
	{
		yield return new WaitForSecondsRealtime((float)3);
		SM.SpawnBot(this.gameObject);
		SM.PlayersAlive = SM.PlayersAlive + 1;
		//print(Time.time);

	}

	public void Destroy()
	{
		if (CurrentScene != "Menu" && CurrentScene != "Finish" && CurrentScene != "" && HMPlayersF == 1)
        {
			PlayerPrefs.GetFloat("LastWin", 0);
			difficulty = PlayerPrefs.GetFloat("difficulty");
			SM.PlayersAlive = SM.PlayersAlive - 1;
			if (SM.PlayersAlive > 1 && SM.AddedBots > 0)
			{
				StartCoroutine(WaitToRespawn());
				SM.AddedBots = SM.AddedBots - 1;
			}
			else if (SM.PlayersAlive <= 1)
            {
				CS.LevelEnd(false);
				if (Player.Alive)
                {
					Player.AddScore();
				}					
			}

		}
		else if (CurrentScene == "Menu")
        {
			SM.SpawnBot(this.gameObject);

		}

		//List<Transform> childrenList = new List<Transform>();
		//foreach (Transform childTrans in transform)
		//	childrenList.Add(childTrans);
		//foreach (Transform childTrans in childrenList)
		//{
		//	if (childTrans.tag == "Bullet")
		//	{
		//		//Collider2D c = childTrans.GetComponent<Collider2D>();
		//		//Physics2D.IgnoreCollision(c, obstacle);
		//		foreach (Collider2D obstacleC in nn.Obstacles)
		//		{
		//			Collider2D c = childTrans.GetComponent<BoxCollider2D>();
		//			Physics2D.IgnoreCollision(c, obstacleC);
		//		}
		//	}
		//}
		//while (this.transform.childCount > 0)
		//{

		//	Piece = transform.GetChild(0).gameObject;
		//}
		this.Alive = false;
		//GetComponent<SpriteRenderer>().enabled = false;

		//this.gameObject.transform.GetChild(1).GetComponent<Explodable>().explode();
		//GetComponent<Explodable>().explode();
		
	    this.gameObject.tag = "Untagged";
		Destroy(DNC);
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
		//rb.AddExplosionForce(100f, transform.position, 100f);
		//SM.PlayersAlive = SM.PlayersAlive - 1;
		//this.GetComponent<Collider2D>().enabled = false;
		//if (gamemode != "dm")
        //{
			
		//}
		Destroy(BA);
		Destroy(ThisCircleCollider2D);

		//List<Transform> childrenList = new List<Transform>();
		//foreach (Transform childTrans in transform)
		//	childrenList.Add(childTrans);
		//foreach (Transform childTrans in childrenList)
		//{
		//	if (childTrans.tag == "Bullet")
		//	{
		//		childTrans.parent = null;
		//		//childTrans.gameObject.SetActive(true);
		//		//childTrans.GetComponent<Rigidbody2D>().AddExplosionForce(Random.Range(50f, 1000f), transform.position, 10f);
		//	}
		//	//else if (childTrans.gameObject.name == "newCircle2")
		//	//{
		//	//	childTrans.parent = null;
		//	//}
		//}
		//GetComponent<SpriteRenderer>().enabled = false;
		ThisCircleCollider2D.enabled = false;
		//Destroy(ThisCircleCollider2D);
		ThisSpriteRenderer.enabled = false;
		//Destroy(this.gameObject);
		this.enabled = false;
		//Destroy(this);
	}

	public void AddScore()
	{
		if (SM.PlayersAlive <= 1 && !alreadyScore)
		{
			string name = this.gameObject.name;
			if (name == "circle1")
			{
				PlayerPrefs.SetFloat("SP1", SP1 + 1);
			}
			else if (name == "circle2")
			{
				PlayerPrefs.SetFloat("SP2", SP2 + 1);
			}
			else if (name == "circle3")
			{
				PlayerPrefs.SetFloat("SP3", SP3 + 1);
			}
			else if (name == "circle4")
			{
				PlayerPrefs.SetFloat("SP4", SP4 + 1);
			}
			alreadyScore = true;
			transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;

		}
	}

	public void Impulse(float ns, float nsU)
	{


	}

	public void GoToPlayer()
    {
		//if (!FreezingBool)
		//{
			if (rb.velocity.x < 3f && rb.velocity.x > -3f && rb.velocity.y < 3f && rb.velocity.y > -3f)
			{
				//normalSpeed = (float)(3 + 0.1);
				//normalSpeedUp = (float)(3 + 0.1);
				//Vector3 direction = new Vector3(transform.right.x, circleGaOb.transform.position.y, 0);
				//Vector3 directionUp = new Vector3(circleGaOb.transform.position.x, transform.up.y, 0);
				//transform.position = Vector3.MoveTowards(transform.position, direction, normalSpeed * Time.deltaTime);
				//transform.position = Vector3.MoveTowards(transform.position, directionUp, normalSpeedUp * Time.deltaTime);
				//Vector3 direction = transform.right;
				//Vector3 directionUp = transform.up;
				if (!newHss)
				{
					hss = Random.Range(3, 5f) * FreezingMult;
					hssu = Random.Range(3, 5f) * FreezingMult;
					newHss = true;
				}
				alreadyImpulsePlayer = false;
				normalSpeed = hss;
				normalSpeedUp = hssu;
				//if (normalSpeed < 13)
				//         {
				//	normalSpeed = hss + (25 * Time.deltaTime);
				//}
				//if (normalSpeedUp < 13)
				//         {
				//	normalSpeedUp = hssu + (25 * Time.deltaTime);
				//}

				//if (rb.velocity.x == 0f && rb.velocity.y == 0f)
				//{

				transform.position = Vector3.MoveTowards(transform.position, circleGaOb.transform.position, normalSpeed * Time.deltaTime);
				transform.position = Vector3.MoveTowards(transform.position, circleGaOb.transform.position, (normalSpeedUp) * Time.deltaTime);

				//transform.position = Vector3.MoveTowards(transform.position, transform.position + directionUp, 8 * Time.deltaTime);
			}
			else
			{
				newHss = false;
				normalSpeed = 0;
				normalSpeedUp = 0;
			}
		//}
	}

	public void GaObInArea(GameObject circle)
    {
		circleGaOb = circle;
	}

	public void DestroyByEventTrigger()
    {
		if (CurrentScene == "Menu" || CurrentScene == "Finish")
        {
			Destroy();
		}
	}

}
