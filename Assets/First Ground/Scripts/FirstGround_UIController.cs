// First Ground 1.3.5
//
// Author:	Gold Experience Team (http://www.ge-team.com)
// Details:	https://www.assetstore.unity3d.com/en/#!/content/18442
// Support:	geteamdev@gmail.com
//
// Please direct any bugs/comments/suggestions to support e-mail.

#region Namespaces

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

#endregion // Namespaces

// ######################################################################
// FirstGround_UIController class
// Handles user inputs.
//
// Note this class is attached with "Canvas  (Scenes)" object in all demo scenes.
// ######################################################################

public class FirstGround_UIController : MonoBehaviour
{
	// ########################################
	// Variables
	// ########################################

	#region Variables

	// Canvas
	public Canvas m_Canvas = null;

	// SelectDemo
	public Button m_SelectDemo_Button = null;
	public GameObject m_SelectDemo_Window = null;

	#endregion //Variables

	// ########################################
	// MonoBehaviour Functions
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.html
	// ########################################

	#region MonoBehaviour

	// Awake is called when the script instance is being loaded.
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html
	void Awake()
	{
		// Set GUIAnimSystemFREE.Instance.m_AutoAnimation to false, 
		// this will let you control all GUI Animator elements in the scene via scripts.
		if (enabled)
		{
			//GUIAnimSystemFREE.Instance.m_GUISpeed = 1.0f;
			GUIAnimSystemFREE.Instance.m_AutoAnimation = false;
		}
	}

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html
	void Start()
	{
		// Play UI move-in animations
		StartCoroutine(ShowUIs());
	}

	// Update is called once per frame
	void Update()
	{
	}

	#endregion // MonoBehaviour

	// ########################################
	// Show UI functions
	// ########################################

	#region Show UI functions

	// Play UI move-in animations
	IEnumerator ShowUIs()
	{
		// Disable all buttons of m_Canvas
		// http://docs.unity3d.com/Manual/script-GraphicRaycaster.html
		GUIAnimSystemFREE.Instance.SetGraphicRaycasterEnable(m_Canvas, false);

		yield return new WaitForSeconds(0.5f);

		GUIAnimSystemFREE.Instance.MoveIn(m_SelectDemo_Button.transform, true);

		yield return new WaitForSeconds(0.25f);

		// Enable all buttons of m_Canvas
		// http://docs.unity3d.com/Manual/script-GraphicRaycaster.html
		GUIAnimSystemFREE.Instance.SetGraphicRaycasterEnable(m_Canvas, true);
	}

	#endregion // Show UI functions

	// ########################################
	// UI Responders
	// ########################################

	#region UI Responders

	// Show demo window
	public void Button_SelectDemo()
	{
		GUIAnimSystemFREE.Instance.MoveOut(m_SelectDemo_Button.transform, true);
		GUIAnimSystemFREE.Instance.MoveIn(m_SelectDemo_Window.transform, true);
	}

	// Show demo button
	public void Button_SelectDemo_Minimize()
	{
		GUIAnimSystemFREE.Instance.MoveIn(m_SelectDemo_Button.transform, true);
		GUIAnimSystemFREE.Instance.MoveOut(m_SelectDemo_Window.transform, true);
	}

	// Open Arctic demo scene
	public void Button_SelectDemo_Arctic()
	{
		GUIAnimSystemFREE.Instance.LoadLevel("First Ground - Arctic (960x600px)", 0.1f);
	}

	// Open Grassland demo scene
	public void Button_SelectDemo_Grassland()
	{
		GUIAnimSystemFREE.Instance.LoadLevel("First Ground - Grassland (960x600px)", 0.1f);
	}

	// Open Volcano demo scene
	public void Button_SelectDemo_Volcano()
	{
		GUIAnimSystemFREE.Instance.LoadLevel("First Ground - Volcano (960x600px)", 0.1f);
	}

	// Open Wasteland demo scene
	public void Button_SelectDemo_Wasteland()
	{
		GUIAnimSystemFREE.Instance.LoadLevel("First Ground - Wasteland (960x600px)", 0.1f);
	}

	// Support button
	public void Button_Help_Support()
	{
		// http://docs.unity3d.com/ScriptReference/Application.OpenURL.html
		Application.OpenURL("mailto:geteamdev@gmail.com");
	}

	// Products button
	public void Button_Help_Products()
	{
		// http://docs.unity3d.com/ScriptReference/Application.ExternalEval.html
		//Application.ExternalEval("window.open('http://ge-team.com/pages/unity-3d/','GOLD EXPERIENCE TEAM')");

        // http://docs.unity3d.com/ScriptReference/Application.OpenURL.html
        Application.OpenURL("http://ge-team.com/pages/unity-3d/");
	}

	#endregion // UI Responders
}
