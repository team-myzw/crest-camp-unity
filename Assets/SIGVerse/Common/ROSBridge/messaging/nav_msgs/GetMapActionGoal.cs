// Generated by gencs from nav_msgs/GetMapActionGoal.msg
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
		public class GetMapActionGoal : ROSMessage
		{
			public std_msgs.Header header;
			public actionlib_msgs.GoalID goal_id;
			public nav_msgs.GetMapGoal goal;


			public GetMapActionGoal()
			{
				this.header = new std_msgs.Header();
				this.goal_id = new actionlib_msgs.GoalID();
				this.goal = new nav_msgs.GetMapGoal();
			}

			public GetMapActionGoal(std_msgs.Header header, actionlib_msgs.GoalID goal_id, nav_msgs.GetMapGoal goal)
			{
				this.header = header;
				this.goal_id = goal_id;
				this.goal = goal;
			}

			new public static string GetMessageType()
			{
				return "nav_msgs/GetMapActionGoal";
			}

			new public static string GetMD5Hash()
			{
				return "4b30be6cd12b9e72826df56b481f40e0";
			}
		} // class GetMapActionGoal
	} // namespace nav_msgs
} // namespace SIGVerse.ROSBridge

