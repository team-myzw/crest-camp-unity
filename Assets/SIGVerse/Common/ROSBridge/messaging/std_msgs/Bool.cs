// Generated by gencs from std_msgs/Bool.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;


namespace SIGVerse.RosBridge 
{
	namespace std_msgs 
	{
		[System.Serializable]
		public class Bool : RosMessage
		{
			public bool data;


			public Bool()
			{
				this.data = false;
			}

			public Bool(bool data)
			{
				this.data = data;
			}

			new public static string GetMessageType()
			{
				return "std_msgs/Bool";
			}

			new public static string GetMD5Hash()
			{
				return "8b94c1b53db61fb6aed406028ad6332a";
			}
		} // class Bool
	} // namespace std_msgs
} // namespace SIGVerse.ROSBridge

