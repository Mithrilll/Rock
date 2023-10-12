using System;
using UnityEngine;

public class UIController : MonoBehaviour
{
	private static UIController _instance;

	private void Awake()
	{
		_instance = this;
	}

	public UIController Instance
	{
		get { return _instance; }
	}

	private void Start()
	{
		
	}

	// Logic goes here:

	public void BlurScreen()
	{

	}

	public void UnblurScreen()
	{

	}
}
