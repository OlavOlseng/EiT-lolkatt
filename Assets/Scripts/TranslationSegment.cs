using UnityEngine;
using System.Collections;

public class TranslationSegment : ParallaxSegment {

	public TranslationSegment()
	{
		this.segmentType = ParallaxSegment.SEGMENT_TYPE_TRANSLATION;
	}

	override public System.Object progress(float x) 
	{
		float progression = 0.0f;

		if (x > startX + duration) {
				progression = 1.0f;
		} else if (startX < x) {
				progression = (x - startX) / duration;
		}
		return Vector3.Lerp (new Vector3 (), translation, progression);
	}
}
