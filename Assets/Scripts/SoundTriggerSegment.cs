﻿using UnityEngine;
using System.Collections;

public class SoundTriggerSegment : ParallaxSegment {

	public AudioSource source;
	private float previousX = 0;
	private bool fired;
	
	override public void progress(float x) 
	{

		float progress = getProgression (x);
		if (progress > 0.0f && progress <= 1.0f) 
		{
			if (!fired && previousX < startX) {
				print("Fired sound");
				fired = true;
				if(source.clip.isReadyToPlay) {
					print("Sound triggered");
					source.Play();
				}
			}
		}
		else 
		{
			fired = false;
		}
		this.previousX = x;	
	}
}
