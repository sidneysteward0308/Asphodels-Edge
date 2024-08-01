using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;
using UnityEngine.SceneManagement;

public class Story1 : MonoBehaviour
{
    [SerializeField] public GameObject blackscreen;
    [SerializeField] public GameObject maincharactercolor;
    [SerializeField] public GameObject maincharacterhidden;
    [SerializeField] public GameObject detectivecharacter;
    [SerializeField] public GameObject journalbutton;
    [SerializeField] public GameObject journal;
    [SerializeField] public GameObject nextButton;
    [SerializeField] public GameObject Camera1;
    [SerializeField] public GameObject Camera2;
    List<string> lines = null;

    private void Start()
    {
        scene1();
    }

    private void scene1()
    {
        blackscreen.SetActive(true);
        maincharactercolor.SetActive(false);
        maincharacterhidden.SetActive(true);
        detectivecharacter.SetActive(true);
        journalbutton.SetActive(false);
        nextButton.SetActive(true);

        lines = FileManager.ReadTextAsset("introtext1");
        DialogueSystem.instance.Say(lines);
    }

}