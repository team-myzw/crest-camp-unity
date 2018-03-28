using UnityEngine;
using UnityEngine.EventSystems;
using SIGVerse.Common;

namespace SIGVerse.Competition.CrestCamp
{
	public interface IRosMsgReceiveHandler : IEventSystemHandler
	{
		void OnReceiveRosMessage(ROSBridge.CrestCamp.PlaceConceptMsg placeConceptMsg);
	}

	public class PlaceConceptSubMessage : RosSubMessage<ROSBridge.CrestCamp.PlaceConceptMsg>
	{
		override public void SubscribeMessageCallback(ROSBridge.CrestCamp.PlaceConceptMsg placeConceptMsg)
		{
			foreach(GameObject destination in this.destinations)
			{
				ExecuteEvents.Execute<IRosMsgReceiveHandler>
				(
					target: destination,
					eventData: null,
					functor: (reciever, eventData) => reciever.OnReceiveRosMessage(placeConceptMsg)
				);
			}
		}
	}
}
