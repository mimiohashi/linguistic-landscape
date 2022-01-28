using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class trigger_text : MonoBehaviour
{
    public GameObject textLeft;
    public GameObject textRight;
    public GameObject checkpoint;

    // Start is called before the first frame update
    void Start()
    {
        textLeft.SetActive(false);
        textRight.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
          textLeft.SetActive(true);
          textRight.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit(Collider other)
    {
        Destroy(checkpoint);
    }

}
