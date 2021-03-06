// Generated by gencs from shape_msgs/Mesh.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;

using SIGVerse.RosBridge.shape_msgs;
using SIGVerse.RosBridge.geometry_msgs;

namespace SIGVerse.RosBridge 
{
	namespace shape_msgs 
	{
		[System.Serializable]
		public class Mesh : RosMessage
		{
			public System.Collections.Generic.List<shape_msgs.MeshTriangle>  triangles;
			public System.Collections.Generic.List<UnityEngine.Vector3>  vertices;


			public Mesh()
			{
				this.triangles = new System.Collections.Generic.List<shape_msgs.MeshTriangle>();
				this.vertices = new System.Collections.Generic.List<UnityEngine.Vector3>();
			}

			public Mesh(System.Collections.Generic.List<shape_msgs.MeshTriangle>  triangles, System.Collections.Generic.List<UnityEngine.Vector3>  vertices)
			{
				this.triangles = triangles;
				this.vertices = vertices;
			}

			new public static string GetMessageType()
			{
				return "shape_msgs/Mesh";
			}

			new public static string GetMD5Hash()
			{
				return "1ffdae9486cd3316a121c578b47a85cc";
			}
		} // class Mesh
	} // namespace shape_msgs
} // namespace SIGVerse.ROSBridge

