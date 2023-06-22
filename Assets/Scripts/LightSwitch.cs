using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject lightSwitcher;
    public Collider lightSwitchCollider;

    public bool lightSwitchOnOrOff = true;

    public Material lightEmision;

    private void OnMouseDown()
    {
        if (lightSwitchOnOrOff)
        {
            lightSwitcher.transform.Rotate(0, 0, -30, Space.Self);
            lightSwitchOnOrOff = false;

            lightEmision.SetColor("_EmissionColor", Color.black);
            lightEmision.EnableKeyword("_EMISSION");
        }

        else
        {
            lightSwitcher.transform.Rotate(0, 0, +30, Space.Self);
            lightSwitchOnOrOff = true;

            lightEmision.SetColor("_EmissionColor", Color.yellow);
            lightEmision.EnableKeyword("_EMISSION");
        }
    }
}
