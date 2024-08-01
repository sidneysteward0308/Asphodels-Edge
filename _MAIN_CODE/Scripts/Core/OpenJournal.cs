using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenJournal : MonoBehaviour
{
    [SerializeField] public GameObject journal;
    public bool isClosed = false;

    void Start()
    {
        journal.SetActive(false);
    }

    public void openJournal()
    {
        journal.SetActive(true);
        isClosed = false;
    }

    public void closeJournal()
    {
        journal.SetActive(false);
        isClosed = true;
    }
}
