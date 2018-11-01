using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicePoint : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		if (other.CompareTag("MimLight"))
		{
			Debug.Log("Light is in zone;");

			if (other.GetComponent<LightController>().lerpProgress == 1)
			{
				Debug.Log("Choice is made");
			}
		}
	}
}
