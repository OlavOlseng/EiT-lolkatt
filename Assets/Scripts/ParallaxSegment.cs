using UnityEngine;
using System.Collections;

public class ParallaxSegment : MonoBehaviour
{
		
	public float startX;
	public float duration;
	public Vector3 translation;

	// Use this for initialization
	void Start ()
	{
		
	}

	// Update is called once per frame
	void Update ()
	{


	}

	public Vector3 getTranslation(float x)
	{
		float progression = 0.0f;
		
		if (x > startX + duration) {
			progression = 1.0f;
		}
		else if (startX < x) {
			progression = (x - startX) / duration;
		}
		return Vector3.Lerp (new Vector3(), translation, progression);
	}
}

