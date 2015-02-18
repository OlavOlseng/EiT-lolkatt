using UnityEngine;
using System.Collections;

public class ScalingSegment : ParallaxSegment {

	public Vector3 scaleChange;

	public ScalingSegment()
	{
		this.segmentType = ParallaxSegment.SEGMENT_TYPE_SCALE;
	}

	override public System.Object progress(float x)
	{
		float progression = getProgression (x);
		return Vector3.Lerp (new Vector3 (), scaleChange, progression);
	}
}
