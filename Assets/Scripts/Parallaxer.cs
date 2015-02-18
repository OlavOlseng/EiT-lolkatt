using UnityEngine;
using System.Collections;

public class Parallaxer : MonoBehaviour {

	private Vector3 initialPosition;
	private Vector3 initialScale;
	private Quaternion initialRotation;
	private Color initialColor;
	public ParallaxSegment[] segments;

	// Use this for initialization
	void Start () {
		this.initialPosition = transform.position;
		this.initialScale = transform.localScale;
		this.initialRotation = transform.rotation;
		this.initialColor = GetComponent<SpriteRenderer> ().color;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = initialPosition;
		transform.localScale = initialScale;
		transform.localRotation = initialRotation;
		this.initialColor = GetComponent<SpriteRenderer> ().color = initialColor;

		GlobalParallaxer p = (GameObject.FindGameObjectWithTag("GlobalParallaxer")).GetComponent<GlobalParallaxer>();
		foreach (ParallaxSegment ps in segments) 
		{
			string type = ps.getSegmentType();
				ps.progress(p.x);
		}
	}
}
