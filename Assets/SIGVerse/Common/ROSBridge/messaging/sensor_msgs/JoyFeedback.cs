// Generated by gencs from sensor_msgs/JoyFeedback.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.ROSBridge;
using UnityEngine;


namespace SIGVerse.ROSBridge 
{
	namespace sensor_msgs 
	{
		[System.Serializable]
		public class JoyFeedback : ROSMessage
		{
			public byte type;
			public byte id;
			public float intensity;

			public const byte TYPE_LED = 0;
			public const byte TYPE_RUMBLE = 1;
			public const byte TYPE_BUZZER = 2;

			public JoyFeedback()
			{
				this.type = 0;
				this.id = 0;
				this.intensity = 0.0f;
			}

			public JoyFeedback(byte type, byte id, float intensity)
			{
				this.type = type;
				this.id = id;
				this.intensity = intensity;
			}

			new public static string GetMessageType()
			{
				return "sensor_msgs/JoyFeedback";
			}

			new public static string GetMD5Hash()
			{
				return "f4dcd73460360d98f36e55ee7f2e46f1";
			}
		} // class JoyFeedback
	} // namespace sensor_msgs
} // namespace SIGVerse.ROSBridge

