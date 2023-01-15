using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotObstacleCheck : MonoBehaviour
{
	//public Joystick joystick;
	public GameObject Object;
	public BotMovement Bot;
	//public Collider2D ThisCollider;
	Vector2 GameobjectRotation;
	private float GameobjectRotation2;
	private float GameobjectRotation3;

	public bool FacingRight = true;

	

	void Update()
	{
		//Gets the input from the jostick
		GameobjectRotation = new Vector2(Bot.hss / 12, Bot.hssu / 12);

		GameobjectRotation3 = GameobjectRotation.x;

		if (Bot.hssu / 12 > 0)
		{
			//Rotates the object if the player is facing right
			GameobjectRotation2 = GameobjectRotation.x + GameobjectRotation.y * 90;
			Object.transform.rotation = Quaternion.Euler(0f, 0f, GameobjectRotation2);
		}
		else
		{
			//Rotates the object if the player is facing left
			GameobjectRotation2 = GameobjectRotation.x + GameobjectRotation.y * -90;
			Object.transform.rotation = Quaternion.Euler(0f, 180f, -GameobjectRotation2);
		}
		if (GameobjectRotation3 < 0 && FacingRight)
		{
			// Executes the void: Flip()
			//Flip();
		}
		else if (GameobjectRotation3 > 0 && !FacingRight)
		{
			// Executes the void: Flip()
			//Flip();
		}
	}

	//IEnumerator BotObstacleOff()
	//{
	//	//print(Time.time);
	//	ThisCollider.
	//	yield return new WaitForSecondsRealtime(1);
	//	Trail.SetActive(false);
	//	//print(Time.time);

	//}

	private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
			if (collision.transform.localScale.x > collision.transform.localScale.y)
            {
				//Bot.hss = Bot.hss;
				Bot.hssu = -Bot.hssu;
			}
			else if (collision.transform.localScale.x < collision.transform.localScale.y)
			{
				Bot.hss = -Bot.hss;
				//Bot.hssu = Bot.hssu;
			}
			Bot.StartCoroutine(Bot.BotObstacleOff());
			//Bot.hss = Random.Range(-12f, 12f);
			//Bot.hssu = Random.Range(-12f, 12f);
		}
    }

}
