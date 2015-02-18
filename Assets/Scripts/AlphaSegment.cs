using UnityEngine;
using System.Collections;

public class AlphaSegment : ParallaxSegment {

	public float alphaChange;

	public AlphaSegment() 
	{
		this.segmentType = ParallaxSegment.SEGMENT_TYPE_ALPHA;
	}

	override public void progress(float x) 
	{
		float progression = getProgression(x);
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		Color c = new Color(sr.color.r, sr.color.g, sr.color.b,sr.color.a + progression * alphaChange);
		sr.color = c;
	}
}
