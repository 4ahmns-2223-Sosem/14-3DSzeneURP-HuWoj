using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilMultiplier : MonoBehaviour
{
    public GameObject pencil;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(pencil);
            pencil.transform.Translate(Random.Range(1.7233f,1.7937f),0,Random.Range(-1.548f,-1.6179f));
        }
    }
}
