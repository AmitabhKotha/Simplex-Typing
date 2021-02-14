using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveScript : MonoBehaviour
{
    public GameObject elements;
    // Start is called before the first frame update
    void Update()
    {
        elements.SetActive(true);
    }
}
