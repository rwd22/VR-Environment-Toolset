using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class ActionsTest : MonoBehaviour
{
	public SteamVR_Input_Sources handType; // 1
	public SteamVR_Action_Boolean teleportAction; // 2
	public SteamVR_Action_Boolean grabAction; // 3
	public SteamVR_Action_Boolean menuAction; // 4

    // Update is called once per frame
    void Update()
    {
		if (GetTeleportDown())
		{
			print("Teleport " + handType);
		}

		if (GetGrab())
		{
			print("Grab " + handType);
		}
		if (GetMenu())
		{
			print("Menu " + handType);
		}


    }
	public bool GetTeleportDown() // 1
	{
		return teleportAction.GetStateDown(handType);
	}

	public bool GetGrab() // 2
	{
		return grabAction.GetState(handType);
	}

	public bool GetMenu() // 3
	{
		return menuAction.GetStateDown(handType);
	}

}
