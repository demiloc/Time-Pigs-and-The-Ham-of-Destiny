﻿using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
	#region Public Variables
	public bool firing; //whether or not the enemy is firing bullets
	#endregion
	
	#region Protected Variables
	#endregion
	
	#region Private Variable
	private float health;
	private string enemy_type;
	#endregion
	
	#region Accessors
	#endregion
	
	#region Unity Defaults
	void Start ()
	{

	}
	
	void Update ()
	{

	}
	#endregion
	
	#region Public Methods
	public bool isAlive()
	{
		return true;
	}
	#endregion
	
	#region Protected Methods
	#endregion
	
	#region Private Methods
	/// <summary>
	/// Fires bullets according to a pattern determined by it's enemy type.
	/// </summary>
	private void fireBullets()
	{
		return;
	}
	#endregion
}
