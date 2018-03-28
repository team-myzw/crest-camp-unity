// Generated by gencs from handyman/PlaceConceptMsg.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.ROSBridge;
using UnityEngine;


namespace SIGVerse.ROSBridge 
{
	namespace CrestCamp
	{
		[System.Serializable]
		public class PlaceConceptMsg : ROSMessage
		{
			public string name;
			public double x;
			public double y;
			public double vx;
			public double vy;


			public PlaceConceptMsg()
			{
				this.name = "";
				this.x = 0.0;
				this.y = 0.0;
				this.vx = 0.0;
				this.vy = 0.0;
			}

			public PlaceConceptMsg(string name, double x, double y, double vx, double vy)
			{
				this.name = name;
				this.x = x;
				this.y = y;
				this.vx = vx;
				this.vy = vy;
			}

			new public static string GetMessageType()
			{
				return "handyman/PlaceConceptMsg";
			}

			new public static string GetMD5Hash()
			{
				return "f48ada863ae6dd3e9a737b7add6e5dea";
			}
		} // class PlaceConceptMsg
	} // namespace handyman
} // namespace SIGVerse.ROSBridge

