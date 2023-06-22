using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasticBottleInTrashcan : MonoBehaviour
{
    public int co2ReduktionDurchMuelltrennung = 0;

    private void OnTriggerEnter(Collider other)
    {
        co2ReduktionDurchMuelltrennung = 125;
    }
}
