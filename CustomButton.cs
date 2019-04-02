using System;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class CustomButton : MonoBehaviour, IVirtualButtonEventHandler
{
	public UnityEvent onPress;
	public UnityEvent onRelease;

	public VirtualButtonBehaviour btn;

	void Start()
	{
		btn = GetComponent<VirtualButtonBehaviour>();
		btn.RegisterEventHandler(this);
	}

	void Update()
	{

	}

	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
		//if (onPress != null)
			onPress.Invoke();
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
		//if (onRelease != null)
			onRelease.Invoke();
	}
}
