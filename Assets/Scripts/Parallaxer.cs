using UnityEngine;
using System.Collections;

public class Parallaxer : MonoBehaviour {

	private Vector3 initialPosition;
	private Vector3 initialScale;
	private Quaternion initialRotation;
	public ParallaxSegment[] segments;

	// Use this for initialization
	void Start () {
		this.initialPosition = transform.position;
		this.initialScale = transform.localScale;
		this.initialRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = initialPosition;
		transform.localScale = initialScale;
		transform.localRotation = initialRotation;

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
				transform.localScale += (Vector3) (ps.progress(p.x));
			}
			else if (type == ParallaxSegment.SEGMENT_TYPE_ROTATE) 
			{
				transform.Rotate((Vector3)(ps.progress(p.x)));
			}
		}
	}
}
