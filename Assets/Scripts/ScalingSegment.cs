using UnityEngine;
using System.Collections;

public class ScalingSegment : ParallaxSegment {

	public Vector3 scaleChange;

	public ScalingSegment()
	{
		this.segmentType = ParallaxSegment.SEGMENT_TYPE_SCALE;
	}

	override public void progress(float x)
	{
		float progression = getProgression (x);
		transform.localScale += Vector3.Lerp (new Vector3 (), scaleChange, progression);
	}
}
