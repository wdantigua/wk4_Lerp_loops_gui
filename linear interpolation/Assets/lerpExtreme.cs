using UnityEngine;
using System.Collections;

public class lerpExtreme : MonoBehaviour {

	public Transform pointA;
	public Transform pointB;


	public float per =0;
	public float dir =-1;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
		{
	
		transform.position = Vector3.Lerp (pointA.position, pointB.position, per);
		transform.rotation = Quaternion.Slerp (pointA.rotation, pointB.rotation, per);
		per = per + Time.deltaTime * dir;

		if (per > 1) 
		{
			dir = -1;
		}

		if (per < 0) 
		{
			dir = 1;
		}
	}
}
