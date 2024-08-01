using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationHover : MonoBehaviour
{
    [SerializeField] public GameObject text;
    [SerializeField] public GameObject light;

    void Start()
    {
        text.SetActive(false);
        light.SetActive(false);
    }

    public void OnMouseOver()
    {
        text.SetActive(true);
        light.SetActive(true);
    }

    public void OnMouseExit()
    {
        text.SetActive(false);
        light.SetActive(false);
    }
}
