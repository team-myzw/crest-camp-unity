using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SIGVerse.Competition.CrestCamp
{
	public class ObjectConceptVisualizer : MonoBehaviour, IRosMarkerMsgReceiveHandler
	{
		public GameObject objectConceptTextPrefab;

		private GameObject objectConceptText;

		// Use this for initialization
		void Start() {
		}

		// Update is called once per frame
		void Update() {
		}

		public void OnReceiveMarkerRosMessage(RosBridge.visualization_msgs.Marker markerMsg)
		{
			this.objectConceptText = GameObject.Instantiate(this.objectConceptTextPrefab);

			this.objectConceptText.transform.position = new Vector3(-markerMsg.pose.position.y, markerMsg.pose.position.z, markerMsg.pose.position.x);
			this.objectConceptText.GetComponentInChildren<TextMesh>().text = markerMsg.header.frame_id;
		}
	}
}