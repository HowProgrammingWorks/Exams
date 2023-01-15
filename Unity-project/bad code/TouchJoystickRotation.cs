using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchJoystickRotation : MonoBehaviour
{
	public Joystick joystick;
	public GameObject Object;
	public GameObject ChildObject;
	public SpriteRenderer SRObject;
	public bool IsTrigger;
	public float x;
	Vector2 GameobjectRotation;
	private float GameobjectRotation2;
	private float GameobjectRotation3;

	public bool FacingRight = true;

	void Update()
	{
		//Gets the input from the jostick
		//GameobjectRotation = new Vector2(joystick.Horizontal, joystick.Vertical);

		//GameobjectRotation3 = GameobjectRotation.x;

		//if (joystick.Horizontal > 0)
		//{
		//	//Rotates the object if the player is facing right
		//	GameobjectRotation2 = GameobjectRotation.x + GameobjectRotation.y*90;
		//	Object.transform.rotation = Quaternion.Euler(0f, 0f, GameobjectRotation2);
		//}
		//else
		//{
		//	//Rotates the object if the player is facing left
		//	GameobjectRotation2 = GameobjectRotation.x + GameobjectRotation.y * -90;
		//	Object.transform.rotation = Quaternion.Euler(0f, 180f, -GameobjectRotation2);
		//}
		//if (GameobjectRotation3 < 0 && FacingRight)
		//{
		//	// Executes the void: Flip()
		//	//Flip();
		//}
		//else if (GameobjectRotation3 > 0 && !FacingRight)
		//{
		//	// Executes the void: Flip()
		//	//Flip();
		//}
		Vector3 lookVec = new Vector3(joystick.Horizontal, joystick.Vertical, 4096);

		if (lookVec.x != 0 && lookVec.y != 0)
        {
			//Object.transform.rotation = Quaternion.Euler(-90, 0, 0);
			//Object.transform.rotation = new Vector3(-90, 0, 0);
			Quaternion targetRotation = Quaternion.LookRotation(lookVec, Vector3.back);
			//Object.transform.rotation.Set(0, 0, Object.transform.rotation.z - 90, Object.transform.rotation.w);
			Object.transform.rotation = Quaternion.Lerp(Object.transform.rotation, targetRotation, 200);
			
			//if (OneTime == false)
			//         {
			//	Object.transform.rotation = Quaternion.Euler(Object.transform.rotation.x - 90, 0, 0);

			//}
		}
		//if (!IsTrigger)
  //      {
		//	if (lookVec.x < 0)
		//	{
		//		SRObject.flipY = false;
		//		x = Object.transform.localPosition.x;
		//		if (Object.transform.localPosition.x > 0)
		//		{
		//			Object.transform.localPosition = new Vector3(-x, Object.transform.localPosition.y);

		//		}
		//	}
		//	else if (lookVec.x > 0)
		//	{
		//		SRObject.flipY = true;
		//		x = Object.transform.localPosition.x;
		//		if (Object.transform.localPosition.x < 0)
		//		{
		//			Object.transform.localPosition = new Vector3(-x, Object.transform.localPosition.y);

		//		}
		//	}
		//}
		

	}
	private void Flip()
	{
		// Flips the player.
		FacingRight = !FacingRight;

		transform.Rotate(0, 180, 0);
	}
}
