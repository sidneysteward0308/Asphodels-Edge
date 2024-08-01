using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;
using UnityEngine.SceneManagement;

public class Story3 : MonoBehaviour
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
        maincharactercolor.SetActive(false);
        maincharacterhidden.SetActive(true);
        detectivecharacter.SetActive(true);
        journalbutton.SetActive(false);
        nextButton.SetActive(true);

        blackscreen.SetActive(true);
        lines = FileManager.ReadTextAsset("introtext3");
        DialogueSystem.instance.Say(lines);
    }

}