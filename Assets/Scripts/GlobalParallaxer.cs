using UnityEngine;
using System.Collections;

public class GlobalParallaxer : MonoBehaviour {

	public float dampening;
	public float x = 0;

	float dx;
	float ddx;
	

	public float xMax = 1000;
	public float dxMax = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ddx = Input.GetAxis ("Horizontal");
		dx += -(dx * dampening) + ddx  * 2;

		if (dx > dxMax) {
			dx = dxMax;
		} 
		else if (dx < -dxMax) {
			dx = -dxMax;
		}

		//add x to 
		x += dx * Time.deltaTime;


		if (x > xMax) {
			x = xMax;
			dx = 0;
		}
		else if (x < 0) {
			x = 0;
			dx = 0;
		}
	}
}