using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;

namespace SIGVerse.Competition.CrestCamp
{
	public interface IRosMarkerMsgReceiveHandler : IEventSystemHandler
	{
		void OnReceiveMarkerRosMessage(ROSBridge.visualization_msgs.Marker markerMsg);
	}

	public class MarkerSubMessage : RosSubMessage<ROSBridge.visualization_msgs.Marker>
	{
		override public void SubscribeMessageCallback(ROSBridge.visualization_msgs.Marker markerMsg)
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

