// Generated by gencs from file turtlesim/TeleportAbsolute.srv
// DO NOT EDIT THIS FILE BY HAND


using SIGVerse.RosBridge.turtlesim;

namespace SIGVerse.RosBridge 
{
	namespace turtlesim 
	{
		public class TeleportAbsolute : RosBridgeServiceProvider<turtlesim.TeleportAbsoluteRequest>
		{
			public TeleportAbsolute(string serviceName) : base(serviceName)
			{
				base.type = "turtlesim/TeleportAbsolute";
			}

			public TeleportAbsolute(string serviceName, string typeName = "turtlesim/TeleportAbsolute") : base(serviceName, typeName) 
			{
			}
		}
	} // namespace turtlesim
} // namespace SIGVerse.ROSBridge

