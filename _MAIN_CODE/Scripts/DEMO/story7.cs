using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;
using UnityEngine.SceneManagement;

public class Story7 : MonoBehaviour
{
    [SerializeField] public GameObject blackscreen;
    [SerializeField] public GameObject maincharactercolor;
    [SerializeField] public GameObject maincharacterhidden;
    [SerializeField] public GameObject harborcharacter;
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
        harborcharacter.SetActive(true);
        journalbutton.SetActive(true);
        nextButton.SetActive(true);

        blackscreen.SetActive(false);
        lines = FileManager.ReadTextAsset("docktext2");
        DialogueSystem.instance.Say(lines);
    }
}