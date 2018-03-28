// Generated by gencs from visualization_msgs/InteractiveMarkerFeedback.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.ROSBridge;
using UnityEngine;

using SIGVerse.ROSBridge.std_msgs;
using SIGVerse.ROSBridge.geometry_msgs;

namespace SIGVerse.ROSBridge 
{
	namespace visualization_msgs 
	{
		[System.Serializable]
		public class InteractiveMarkerFeedback : ROSMessage
		{
			public std_msgs.Header header;
			public string client_id;
			public string marker_name;
			public string control_name;
			public byte event_type;
			public geometry_msgs.Pose pose;
			public System.UInt32 menu_entry_id;
			public UnityEngine.Vector3 mouse_point;
			public bool mouse_point_valid;

			public const byte KEEP_ALIVE = 0;
			public const byte POSE_UPDATE = 1;
			public const byte MENU_SELECT = 2;
			public const byte BUTTON_CLICK = 3;
			public const byte MOUSE_DOWN = 4;
			public const byte MOUSE_UP = 5;

			public InteractiveMarkerFeedback()
			{
				this.header = new std_msgs.Header();
				this.client_id = "";
				this.marker_name = "";
				this.control_name = "";
				this.event_type = 0;
				this.pose = new geometry_msgs.Pose();
				this.menu_entry_id = 0;
				this.mouse_point = new UnityEngine.Vector3();
				this.mouse_point_valid = false;
			}

			public InteractiveMarkerFeedback(std_msgs.Header header, string client_id, string marker_name, string control_name, byte event_type, geometry_msgs.Pose pose, System.UInt32 menu_entry_id, UnityEngine.Vector3 mouse_point, bool mouse_point_valid)
			{
				this.header = header;
				this.client_id = client_id;
				this.marker_name = marker_name;
				this.control_name = control_name;
				this.event_type = event_type;
				this.pose = pose;
				this.menu_entry_id = menu_entry_id;
				this.mouse_point = mouse_point;
				this.mouse_point_valid = mouse_point_valid;
			}

			new public static string GetMessageType()
			{
				return "visualization_msgs/InteractiveMarkerFeedback";
			}

			new public static string GetMD5Hash()
			{
				return "ab0f1eee058667e28c19ff3ffc3f4b78";
			}
		} // class InteractiveMarkerFeedback
	} // namespace visualization_msgs
} // namespace SIGVerse.ROSBridge

