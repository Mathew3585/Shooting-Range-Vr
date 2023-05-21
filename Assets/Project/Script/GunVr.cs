using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class GunVr : MonoBehaviour
{
    public int Bullet;

    public SteamVR_Action_Boolean fireaction;
    public SimpleShoot simpleShoot;

    private Interactable interactable;  
    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Bullet > 0)
        {
            if (interactable.attachedToHand != null)
            {
                SteamVR_Input_Sources sources = interactable.attachedToHand.handType;

                if (fireaction[sources].stateDown)
                {
                    simpleShoot.PullTheTrigger();
                }
            }
        }
        
    }
}
