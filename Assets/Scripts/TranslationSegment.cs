using UnityEngine;
using System.Collections;

public class TranslationSegment : ParallaxSegment {

	public Vector3 translation;

	public TranslationSegment()
	{
		this.segmentType = ParallaxSegment.SEGMENT_TYPE_TRANSLATION;
	}



	override public System.Object progress(float x) 
	{
		float progression = getProgression (x);
		return Vector3.Lerp (new Vector3 (), translation, progression);
	}
}
