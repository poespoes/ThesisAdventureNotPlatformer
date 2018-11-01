using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollowMouse : MonoBehaviour
{
	private Vector3 prevMosuePos;
	public float horizontalSpeed;
	public float verticalSpeed;
	private bool isOn;

	// Use this for initialization
	void Start () {
		
		prevMosuePos = Camera.main.ScreenToWorldPoint( Input.mousePosition);
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		isOn = this.GetComponent<LightController>().isOn;
		
		//this.transform.position = Input.mousePosition;

		//Camera.main.ScreenPointToRay(Input.mousePosition);
		
		//float h = horizontalSpeed * Input.GetAxisRaw("Mouse X");
		//float v = verticalSpeed * Input.GetAxisRaw("Mouse Y");
		
		//transform.position = transform.position + new Vector3(h,v,0);
		
		Cursor.visible = false;
		if (isOn == false)
		{
			transform.position += Camera.main.ScreenToWorldPoint(Input.mousePosition) - prevMosuePos;
			prevMosuePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		}
	}
}
