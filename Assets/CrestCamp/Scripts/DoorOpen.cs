using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
	public float duration = 1.0f;
	public float length = 1.1f;

	private Transform door;
	private float endTime;
	private Vector3 startPosition;
	private Vector3 endPosition;

	//private bool isOpen = false;

	private void Awake()
	{
		this.door = transform.parent;
	}

	private void OnEnable()
	{
		this.endTime = 0;
		this.startPosition = door.localPosition;
		this.endPosition = door.localPosition;
	}

	// Use this for initialization
	void Start ()
	{
	}

	// Update is called once per frame
	void Update ()
	{
		float diff = this.endTime - Time.time;
		if (diff <= this.duration)
		{
			float rate = 1 - diff / this.duration;
			door.localPosition = Vector3.Lerp(this.startPosition, this.endPosition, rate);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("Door open.");

		this.endPosition = door.localPosition - new Vector3(this.length, 0, 0);
		this.endTime = Time.time + this.duration;
	}
}
