using UnityEngine;
using System.Collections;

public abstract class ParallaxSegment : MonoBehaviour
{
		
	public float startX;
	public float duration;
	protected string segmentType = null;

	public static readonly string SEGMENT_TYPE_TRANSLATION = "trans";
	public static readonly string SEGMENT_TYPE_SCALE = "scale";
	public static readonly string SEGMENT_TYPE_ROTATE = "rot";
	public static readonly string SEGMENT_TYPE_ALPHA = "alpha";

	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{


	}

	public string getSegmentType() 
	{
		return this.segmentType;
	}

	protected float getProgression(float x) 
	{
		float progression = 0.0f;
		
		if (x > startX + duration) {
			progression = 1.0f;
		} else if (startX < x) {
			progression = (x - startX) / duration;
		}
		return progression;
	}

	public abstract void progress(float x);
	
}

