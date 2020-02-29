
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VRInstScale: MonoBehaviour
{
	public GameObject Player;
	public GameObject PlayerPrefab;

	public GameObject SpawnLocation;

	void Awake()
	{
		if (GameObject.FindGameObjectWithTag("Player") != null)
		{
			Player = GameObject.FindGameObjectWithTag("Player");
			Player.transform.position = SpawnLocation.transform.position;
			Player.transform.localScale = new Vector3(3.480065f, 3.480065f, 3.480065f);
		}
		else
		{
			Player = Instantiate(PlayerPrefab);
			Player.transform.position = SpawnLocation.transform.position;
			Player.transform.localScale = new Vector3(3.480065f, 3.480065f, 3.480065f);
		}
	}

}