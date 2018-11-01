using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {
    SpriteRenderer lightGlow;

    public Color A = Color.magenta;
    public Color B = Color.blue;
    public float fadeInSpeed = 0.001f;
    public float fadeOutSpeed = 0.001f;
    public float lerpProgress = 0;

    public bool readyToDecide;
    public bool isOn;
    private bool isInteractive;

    // Use this for initialization
    void Start () {
        lightGlow = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update ()
	{

	    isInteractive = GameObject.Find("GameManager").GetComponent<GameManager>().isInteractive;

        if (Input.GetMouseButton(0) && isInteractive==true) {
            isOn = true;
            Debug.Log("test");
        } else {
            isOn = false;
        }

        if (isOn == true) {
            lerpProgress += fadeInSpeed;

            if (lerpProgress > 1) {
                lerpProgress = 1;

            }

            if (lerpProgress > 0.95f) {
                readyToDecide = true;
            }
            
        } else {
            lerpProgress -= fadeOutSpeed;
            if (lerpProgress < 0) {
                lerpProgress = 0;
            }

            readyToDecide = false;
        }

        lightGlow.color = Color.Lerp(A, B, lerpProgress);



    }
}
