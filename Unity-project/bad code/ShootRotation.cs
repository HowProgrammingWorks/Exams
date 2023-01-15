using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRotation : MonoBehaviour
{
	public Joystick joystick;
	public GameObject Object;
	Vector2 GameobjectRotation;
	private float GameobjectRotation2;
	private float GameobjectRotation3;

	public bool FacingRight = true;

	void Update()
	{
		//Gets the input from the jostick
		//if (joystick.Horizontal > 0 || joystick.Vertical > 0 || joystick.Horizontal < 0 || joystick.Vertical < 0)
  //      {
		//	GameobjectRotation = new Vector2(joystick.Horizontal, joystick.Vertical);

		//	GameobjectRotation3 = GameobjectRotation.x;

		//	if (joystick.Horizontal > 0)
		//	{

		//		//Rotates the object if the player is facing right
		//		GameobjectRotation2 = GameobjectRotation.x + GameobjectRotation.y * 90;
		//		Object.transform.rotation = Quaternion.Euler(0f, 0f, GameobjectRotation2);
		//	}
		//	else
		//	{
		//		//Rotates the object if the player is facing left
		//		GameobjectRotation2 = GameobjectRotation.x + GameobjectRotation.y * -90;
		//		Object.transform.rotation = Quaternion.Euler(0f, 180f, -GameobjectRotation2);
		//	}
		//	if (GameobjectRotation3 < 0 && FacingRight)
		//	{
		//		// Executes the void: Flip()
		//		//Flip();
		//	}
		//	else if (GameobjectRotation3 > 0 && !FacingRight)
		//	{
		//		// Executes the void: Flip()
		//		//Flip();
		//	}
		//}
		Vector3 lookVec = new Vector3(joystick.Horizontal, joystick.Vertical, 4096);

		if (lookVec.x != 0 && lookVec.y != 0)
		{
			//transform.rotation = Quaternion.LookRotation(lookVec, Vector3.back);
			Quaternion targetRotation = Quaternion.LookRotation(lookVec, Vector3.back);
			Object.transform.rotation = Quaternion.Lerp(Object.transform.rotation, targetRotation, 200);
		}
	}

}
