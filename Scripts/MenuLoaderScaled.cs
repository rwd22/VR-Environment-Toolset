using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class MenuLoader : MonoBehaviour
{
	private GameObject CamPos;
	public GameObject MenuObj;
	private GameObject MenuLoad;

	public SteamVR_Input_Sources handType;
	public SteamVR_Behaviour_Pose controllerPose;
	public SteamVR_Action_Boolean menuAction;

    // Start is called before the first frame update
    void Start()
    {
		CamPos = GameObject.FindGameObjectWithTag("Cam");
    }

    // Update is called once per frame
    void Update()
    {
		if (menuAction.GetLastStateDown(handType))
		{
			if (GameObject.FindGameObjectWithTag("Menu") == null)
			{
				MenuLoad = Instantiate(MenuObj);
				MenuLoad.transform.position = CamPos.transform.position + (CamPos.transform.forward * 4);
				MenuLoad.transform.LookAt(CamPos.transform);
				MenuLoad.transform.Rotate(0.0f,90.0f,0.0f);

			}
			else
			{
				Destroy (GameObject.FindGameObjectWithTag("Menu"));
			}
		}
    }

}
