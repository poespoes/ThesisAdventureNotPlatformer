using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicePoint : MonoBehaviour {
	

	public Animator anim;
	public string boolName;
	public bool choiceMade;


	// Use this for initialization
	void Start ()
	{
		choiceMade = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		if (other.CompareTag("MimLight"))
		{
			Debug.Log("Light is in zone;");

			if (other.GetComponent<LightController>().readyToDecide==true)
			{
				choiceMade = true;
			}
		}

		if (choiceMade == true)
		{
			Debug.Log("The choice has been made");
			anim.SetBool(boolName,true);
			//GameObject.Find("GameManager").GetComponent<GameManager>().isInteractive = false;
		}
	}
}
