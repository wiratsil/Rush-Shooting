// First Fantasy for Mobile
// Version: 1.4.5
// Compatilble: Unity 5.5.1 or higher, see more info in Readme.txt file.
//
// Developer:			Gold Experience Team (https://www.assetstore.unity3d.com/en/#!/search/page=1/sortby=popularity/query=publisher:4162)
// Unity Asset Store:	https://www.assetstore.unity3d.com/en/#!/content/10822
//
// Please direct any bugs/comments/suggestions to geteamdev@gmail.com

#region Namespaces

using UnityEngine;
using System.Collections;

#endregion // Namespaces

// ######################################################################
// GE_FF_WaterFlow class.
// Changes UV coordinate.
// ######################################################################

public class GE_FF_WaterFlow : MonoBehaviour
{
	// ########################################
	// Variables
	// ########################################

	#region Variables

	public float m_SpeedU = 0.1f;
	public float m_SpeedV = -0.1f;

	#endregion // Variables

	// ########################################
	// MonoBehaviour Functions
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.html
	// ########################################

	#region MonoBehaviour

	// Update is called every frame, if the MonoBehaviour is enabled.
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html
	void Update()
	{
		float newOffsetU = Time.time * m_SpeedU;
		float newOffsetV = Time.time * m_SpeedV;

		if (this.GetComponent<Renderer>())
		{
			GetComponent<Renderer>().material.mainTextureOffset = new Vector2(newOffsetU, newOffsetV);
		}
	}

	#endregion // MonoBehaviour
}
