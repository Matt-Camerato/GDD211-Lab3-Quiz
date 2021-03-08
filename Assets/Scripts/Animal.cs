using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : Object
{
	public override void UseItem()
	{
		base.UseItem();
		Debug.Log("I'm an animal. My object name is: " + Name);
	}
}
