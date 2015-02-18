using UnityEngine;
using System.Collections;

public class Parallaxer : MonoBehaviour {

	public Vector3 initialPosition;
	public ParallaxSegment[] segments;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = initialPosition;

		GlobalParallaxer p = (GameObject.FindGameObjectWithTag("GlobalParallaxer")).GetComponent<GlobalParallaxer>();
		foreach (ParallaxSegment ps in segments) 
		{
			string type = ps.getSegmentType();
			if (type == ParallaxSegment.SEGMENT_TYPE_TRANSLATION) 
			{
				transform.position += (Vector3) (ps.progress(p.x));
			}
			else if (type == ParallaxSegment.SEGMENT_TYPE_SCALE) 
			{

			}
			else if (type == ParallaxSegment.SEGMENT_TYPE_ROTATE) 
			{

			}
		}
	}
}
