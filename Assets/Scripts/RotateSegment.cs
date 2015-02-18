using UnityEngine;
using System.Collections;

public class RotateSegment : ParallaxSegment {
	public Vector3 rotation;

	public RotateSegment() 
	{
		this.segmentType = ParallaxSegment.SEGMENT_TYPE_ROTATE;
	}

	override public System.Object progress(float x) 
	{
		float progression = getProgression (x);
		return Vector3.Lerp (new Vector3(), this.rotation, progression);

	}
}
