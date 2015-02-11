using UnityEngine;
using System.Collections;

public class ParallaxSegment : MonoBehaviour
{
		
	public float startX;
	public float duration;
	public Vector3 startKeyFrame;
	public Vector3 endKeyframe;

	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{
		MainParallaxer p = (GameObject.FindGameObjectWithTag ("Parallaxer")).GetComponent<MainParallaxer>();

		float progression = 0.0f;

		if (p.x > startX + duration) {
			progression = 1.0f;
		}
		else if (startX < p.x) {
			progression = (p.x - startX) / (startX + duration);
		}
		transform.position = Vector3.Lerp (startKeyFrame, endKeyframe, progression * 2);
	}
}

