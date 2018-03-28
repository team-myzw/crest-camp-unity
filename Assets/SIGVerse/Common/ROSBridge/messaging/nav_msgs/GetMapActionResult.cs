// Generated by gencs from nav_msgs/GetMapActionResult.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.ROSBridge;
using UnityEngine;

using SIGVerse.ROSBridge.std_msgs;
using SIGVerse.ROSBridge.actionlib_msgs;
using SIGVerse.ROSBridge.nav_msgs;

namespace SIGVerse.ROSBridge 
{
	namespace nav_msgs 
	{
		[System.Serializable]
		public class GetMapActionResult : ROSMessage
		{
			public std_msgs.Header header;
			public actionlib_msgs.GoalStatus status;
			public nav_msgs.GetMapResult result;


			public GetMapActionResult()
			{
				this.header = new std_msgs.Header();
				this.status = new actionlib_msgs.GoalStatus();
				this.result = new nav_msgs.GetMapResult();
			}

			public GetMapActionResult(std_msgs.Header header, actionlib_msgs.GoalStatus status, nav_msgs.GetMapResult result)
			{
				this.header = header;
				this.status = status;
				this.result = result;
			}

			new public static string GetMessageType()
			{
				return "nav_msgs/GetMapActionResult";
			}

			new public static string GetMD5Hash()
			{
				return "ac66e5b9a79bb4bbd33dab245236c892";
			}
		} // class GetMapActionResult
	} // namespace nav_msgs
} // namespace SIGVerse.ROSBridge
