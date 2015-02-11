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

		MainParallaxer p = (GameObject.FindGameObjectWithTag ("Parallaxer")).GetComponent<MainParallaxer>();
		foreach (ParallaxSegment ps in segments) 
		{
			transform.position += ps.getTranslation(p.x);
		}
	}
}
