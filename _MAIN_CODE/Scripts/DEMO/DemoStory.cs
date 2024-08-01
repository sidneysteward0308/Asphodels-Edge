using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DIALOGUE;
using UnityEngine.SceneManagement;

public class DemoStory : MonoBehaviour
{

    /**
    DRAFT FOR THE GAMEPLAY
    - Load Scene from Main Menu (handled by title script)
    - Start With Black Screen
    - Click, dialogue box appears. load introtext1.txt, the player
    wakes up in a strange place
    - the morgue appears. load introtext2.txt, the head detective
    employs them. tells them to go put some clothes on by the mirror.
    - black screen. load introtext3.txt of the character going to the mirror
    - camera change to mirror. load introtext4.txt, the character is now visible,
    the user is prompted to open up the journal. the button appears
    - user closes journal, bool isclosed = true
    - back to mirror screen. load introtext5.txt, seems like youll need to transport
    to this harbor.
    - black screen. load introtext6.txt, the user is transported
    - load map scene
    - user clicks dock house
    END OF DEMO SCREEN
    (optional) load a dialogue scene talking to the dock worker

    **/
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

    // Start is called before the first frame update
    private void Start()
    {
        startScenes();
    }

    private void startScenes()
    {
        blackscreen.SetActive(true);
        maincharactercolor.SetActive(false);
        maincharacterhidden.SetActive(true);
        detectivecharacter.SetActive(true);
        journalbutton.SetActive(false);
        nextButton.SetActive(false);
        CameraOne();
        scene1();
        waitCoroutine();
        scene2();
        scene3();
        scene4();
        scene5();
    }

    private void scene1()
    {
        lines = FileManager.ReadTextAsset("introtext1");
        DialogueSystem.instance.Say(lines);
    }

    private void scene2()
    {
        blackscreen.SetActive(false);
        lines = FileManager.ReadTextAsset("introtext2");
        DialogueSystem.instance.Say(lines);
    }

    private void scene3()
    {
        blackscreen.SetActive(true);
        lines = FileManager.ReadTextAsset("introtext3");
        DialogueSystem.instance.Say(lines);
        CameraTwo();
    }

    private void scene4()
    {

        blackscreen.SetActive(false);
        lines = FileManager.ReadTextAsset("introtext4");
        DialogueSystem.instance.Say(lines);
        journalbutton.SetActive(true);
        waitCoroutine();
        nextButton.SetActive(true);
    }

    private void scene5()
    {
        blackscreen.SetActive(true);
        lines = FileManager.ReadTextAsset("introtext5");
        DialogueSystem.instance.Say(lines);
        SceneManager.LoadScene("Map");
    }

    IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(5);
    }

    private void CameraOne()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }

    private void CameraTwo()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
    }
}
