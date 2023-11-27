using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableCube : MonoBehaviour
{
    public GameObject testObject;
    private bool isActivated = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isActivated)
            {
                testObject.SetActive(false);
                isActivated = false;
            }
            else
            {
                testObject.SetActive(true);
                isActivated = true;
            }
        }
    }
}
