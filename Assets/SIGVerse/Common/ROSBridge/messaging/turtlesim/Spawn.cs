// Generated by gencs from file turtlesim/Spawn.srv
// DO NOT EDIT THIS FILE BY HAND


using SIGVerse.ROSBridge.turtlesim;

namespace SIGVerse.ROSBridge 
{
	namespace turtlesim 
	{
		public class Spawn : ROSBridgeServiceProvider<turtlesim.SpawnRequest>
		{
			public Spawn(string serviceName) : base(serviceName)
			{
				base.type = "turtlesim/Spawn";
			}

			public Spawn(string serviceName, string typeName = "turtlesim/Spawn") : base(serviceName, typeName) 
			{
			}
		}
	} // namespace turtlesim
} // namespace SIGVerse.ROSBridge
