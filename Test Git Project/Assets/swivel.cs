using UnityEngine;
using System.Collections;

public class swivel : MonoBehaviour {

	public float amount;
	private float pos;
	private Vector3 initialPos;
	// Use this for initialization
	void Start () {
		pos = amount;
		initialPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = initialPos + Vector3.up * amount * Mathf.Sin( Time.time );
	}
}
