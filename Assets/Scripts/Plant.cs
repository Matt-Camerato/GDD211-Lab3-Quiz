using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : Object
{
	public override void UseItem()
	{
		base.UseItem();
		Debug.Log("I'm a plant. My object name is: " + Name);
	}
}
