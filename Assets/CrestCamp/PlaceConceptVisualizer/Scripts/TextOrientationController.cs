using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TextOrientationController : MonoBehaviour
{
	private Vector3 cameraPosition;

	private void OnEnable()
	{
		this.cameraPosition = new Vector3();
	}

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (SceneView.lastActiveSceneView == null)
		{
			if(Camera.current != null)
			{
				this.cameraPosition = Camera.current.transform.position;
			}
		}
		else
		{
			this.cameraPosition = SceneView.lastActiveSceneView.camera.transform.position;
		}
		Vector3 direction = this.cameraPosition - this.transform.position;
		direction.y = 0.0f;
		this.transform.rotation = Quaternion.LookRotation(direction);
	}
}
