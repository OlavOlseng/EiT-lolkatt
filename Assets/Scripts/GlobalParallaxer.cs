using UnityEngine;
using System.Collections;

public class GlobalParallaxer : MonoBehaviour {
	//TODO Add support for multifinger speed scrolling.
	public float dampening = 0.02f;
	public float x = 0;

	float dx;
	float ddx;

	private bool newTouch = false;
	private bool touching = false;


	public float xMax = 1000;
	public float dxMax = 100;
	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float dampening = this.dampening;
		ddx = 0;
		float speedMultiplier = 1.0f;
		if (Input.touchSupported) {
			Touch[] touches = Input.touches;

			if(touches.Length > 0) {
				speedMultiplier = touches.Length;
				Touch t = touches[0];
				ddx = -t.deltaPosition.x * t.deltaTime;
				/*
				if (newTouch && t.deltaPosition.x == 0.0f) {
					dx = 0;
				}
				*/
				if(!touching) {
					newTouch = true;
				}
				else if (touching){
					newTouch = false;
				}
				touching = true;
			}
			else {
				touching = false;
				newTouch = false;
			}
		} 
		else {
			ddx = Input.GetAxis ("Horizontal");
		}
		dx -= (dx * dampening);
		dx += ddx * speed * speedMultiplier;


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