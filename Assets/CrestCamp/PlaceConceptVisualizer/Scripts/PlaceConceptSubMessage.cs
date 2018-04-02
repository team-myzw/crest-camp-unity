using UnityEngine;
using UnityEngine.EventSystems;
using SIGVerse.Common;
using SIGVerse.RosBridge;
using System.Collections.Generic;

namespace SIGVerse.Competition.CrestCamp
{
	public interface IRosMsgReceiveHandler : IEventSystemHandler
	{
		void OnReceiveRosMessage(RosBridge.CrestCamp.PlaceConceptMsg placeConceptMsg);
	}

	public class PlaceConceptSubMessage : RosSubMessage<RosBridge.CrestCamp.PlaceConceptMsg>
	{
		public List<GameObject> destinations;

		override protected void SubscribeMessageCallback(RosBridge.CrestCamp.PlaceConceptMsg placeConceptMsg)
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
