using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageFlip : MonoBehaviour
{
    [SerializeField] public GameObject page1;
    [SerializeField] public GameObject page2;

    void Start()
    {
        page1.SetActive(true);
        page2.SetActive(false);
    }

    public void pageFlipRight()
    {
        page1.SetActive(false);
        page2.SetActive(true);
    }

    public void pageFlipLeft()
    {
        page2.SetActive(false);
        page1.SetActive(true);
    }
}