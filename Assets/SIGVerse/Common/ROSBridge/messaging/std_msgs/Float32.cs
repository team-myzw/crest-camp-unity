// Generated by gencs from std_msgs/Float32.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.ROSBridge;
using UnityEngine;


namespace SIGVerse.ROSBridge 
{
	namespace std_msgs 
	{
		[System.Serializable]
		public class Float32 : ROSMessage
		{
			public float data;


			public Float32()
			{
				this.data = 0.0f;
			}

			public Float32(float data)
			{
				this.data = data;
			}

			new public static string GetMessageType()
			{
				return "std_msgs/Float32";
			}

			new public static string GetMD5Hash()
			{
				return "73fcbf46b49191e672908e50842a83d4";
			}
		} // class Float32
	} // namespace std_msgs
} // namespace SIGVerse.ROSBridge

