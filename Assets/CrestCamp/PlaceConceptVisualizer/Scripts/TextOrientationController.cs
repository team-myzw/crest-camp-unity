using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TextOrientationController : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 sceneCameraPosition = SceneView.lastActiveSceneView.camera.transform.position;
		this.transform.localRotation = Quaternion.LookRotation (sceneCameraPosition);
	}
}
