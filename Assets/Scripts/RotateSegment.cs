using UnityEngine;
using System.Collections;

public class RotateSegment : ParallaxSegment {
	public Vector3 rotation;

	public RotateSegment() 
	{
		this.segmentType = ParallaxSegment.SEGMENT_TYPE_ROTATE;
	}

	override public void progress(float x) 
	{
		float progression = getProgression (x);
		transform.Rotate(Vector3.Lerp (new Vector3(), this.rotation, progression));

	}
}
