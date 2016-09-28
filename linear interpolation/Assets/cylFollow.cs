using UnityEngine;
using System.Collections;

public class cylFollow : MonoBehaviour {


	public Transform thingToFollow;
	public float sp = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (thingToFollow);
		transform.position += transform.forward * Time.deltaTime * sp;
	}
}
