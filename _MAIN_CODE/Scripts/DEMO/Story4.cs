using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;
using UnityEngine.SceneManagement;

public class Story4 : MonoBehaviour
{
    [SerializeField] public GameObject blackscreen;
    [SerializeField] public GameObject maincharactercolor;
    [SerializeField] public GameObject maincharacterhidden;
    [SerializeField] public GameObject detectivecharacter;
    [SerializeField] public GameObject journalbutton;
    [SerializeField] public GameObject journal;
    [SerializeField] public GameObject nextButton;
    List<string> lines = null;

    private void Start()
    {
        scene1();
    }

    private void scene1()
    {
        maincharactercolor.SetActive(true);
        maincharacterhidden.SetActive(false);
        detectivecharacter.SetActive(false);
        journalbutton.SetActive(false);
        nextButton.SetActive(true);

        blackscreen.SetActive(false);
        lines = FileManager.ReadTextAsset("introtext4");
        DialogueSystem.instance.Say(lines);
        journalbutton.SetActive(true);
        nextButton.SetActive(true);
    }
}