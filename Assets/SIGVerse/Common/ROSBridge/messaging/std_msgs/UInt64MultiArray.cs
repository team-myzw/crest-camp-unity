// Generated by gencs from std_msgs/UInt64MultiArray.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.ROSBridge;
using UnityEngine;

using SIGVerse.ROSBridge.std_msgs;

namespace SIGVerse.ROSBridge 
{
	namespace std_msgs 
	{
		[System.Serializable]
		public class UInt64MultiArray : ROSMessage
		{
			public std_msgs.MultiArrayLayout layout;
			public System.Collections.Generic.List<System.UInt64>  data;


			public UInt64MultiArray()
			{
				this.layout = new std_msgs.MultiArrayLayout();
				this.data = new System.Collections.Generic.List<System.UInt64>();
			}

			public UInt64MultiArray(std_msgs.MultiArrayLayout layout, System.Collections.Generic.List<System.UInt64>  data)
			{
				this.layout = layout;
				this.data = data;
			}

			new public static string GetMessageType()
			{
				return "std_msgs/UInt64MultiArray";
			}

			new public static string GetMD5Hash()
			{
				return "6088f127afb1d6c72927aa1247e945af";
			}
		} // class UInt64MultiArray
	} // namespace std_msgs
} // namespace SIGVerse.ROSBridge
