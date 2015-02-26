using UnityEngine;
using System.Collections;

public class ShakingSegment : ParallaxSegment {

	public Vector3 halfAngle;
	public int periods;

	override public void progress(float x) {
		float progression = getProgression (x);
		float scale = Mathf.Sin (periods * progression * Mathf.PI * 2);
		Vector3 newVec = new Vector3 (halfAngle.x * scale, halfAngle.y * scale, halfAngle.z * scale);
		print (halfAngle);			
		print (newVec);			
		transform.Rotate(newVec);
	}
}
