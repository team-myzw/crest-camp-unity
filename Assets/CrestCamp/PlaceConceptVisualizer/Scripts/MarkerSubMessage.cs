using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;
using SIGVerse.RosBridge;
using System.Collections.Generic;

namespace SIGVerse.Competition.CrestCamp
{
	public interface IRosMarkerMsgReceiveHandler : IEventSystemHandler
	{
		void OnReceiveMarkerRosMessage(RosBridge.visualization_msgs.Marker markerMsg);
	}

	public class MarkerSubMessage : RosSubMessage<RosBridge.visualization_msgs.Marker>
	{
		public List<GameObject> destinations;

		override protected void SubscribeMessageCallback(RosBridge.visualization_msgs.Marker markerMsg)
		{
			foreach (GameObject destination in this.destinations)
			{
				ExecuteEvents.Execute<IRosMarkerMsgReceiveHandler>
				(
					target: destination,
					eventData: null,
					functor: (reciever, eventData) => reciever.OnReceiveMarkerRosMessage(markerMsg)
				);
			}
		}
	}
}

