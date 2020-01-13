using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Level
{
    public GameObject[] activeObjects;

}

[System.Serializable]
public class LevelSet
{
    public Level[] levels;
}

public class LevelSelector : MonoBehaviour
{

    public GameObject phaseOneButtons;
    public GameObject phaseTwoThreeButtons;
    public Button[] P1Buttons;
    public Button[] P2P3Buttons;
    public static int level;
    public Text phaseText;
    public Text modeText;
    public Text[] levelTexts;

    public LevelSet[] levelSets;

    public void Show()
    {
        gameObject.SetActive(true);
        phaseText.text = "Phase " + PhaseSelector.phase;
        modeText.text = ModeSelector.mode.ToString();
        if (PhaseSelector.phase == 1)
        {
            phaseOneButtons.SetActive(true);
            phaseTwoThreeButtons.SetActive(false);
            if(ModeSelector.mode == ModeSelector.Modes.Shapes)
            {
                levelTexts[0].text = "Circle";
                P1Buttons[0].interactable = true;
                levelTexts[1].text = "Rectangle";
                P1Buttons[1].interactable = true;
                levelTexts[2].text = "Triangle";
                levelTexts[3].text = "Hexagon";
                levelTexts[4].text = "Pentagon";
                levelTexts[5].text = "Star";
            }
            else if (ModeSelector.mode == ModeSelector.Modes.Animals)
            {
                levelTexts[0].text = "Horse";
                P1Buttons[0].interactable = false;
                levelTexts[1].text = "Cow";
                P1Buttons[1].interactable = false;
                levelTexts[2].text = "Elephant";
                levelTexts[3].text = "Mouse";
                levelTexts[4].text = "Turtle";
                levelTexts[5].text = "Tiger";
            }
            else 
            {
                levelTexts[0].text = "Apple";
                P1Buttons[0].interactable = true;
                levelTexts[1].text = "Banana";
                P1Buttons[1].interactable = false;
                levelTexts[2].text = "Grapes";
                levelTexts[3].text = "Pineapple";
                levelTexts[4].text = "Strawberry";
                levelTexts[5].text = "Watermelon";
            }
        }
        else if (PhaseSelector.phase == 2)
        {
            if (ModeSelector.mode == ModeSelector.Modes.Shapes)
            {
                P2P3Buttons[0].interactable = true;
                P2P3Buttons[1].interactable = true;
            }
            else if (ModeSelector.mode == ModeSelector.Modes.Animals)
            {

                P2P3Buttons[0].interactable = false;
                P2P3Buttons[1].interactable = false;

            }
            else
            {
                P2P3Buttons[0].interactable = false;
                P2P3Buttons[1].interactable = false;

            }
            phaseOneButtons.SetActive(false);
            phaseTwoThreeButtons.SetActive(true);
        }
        else
        {
            if (ModeSelector.mode == ModeSelector.Modes.Shapes)
            {
                P2P3Buttons[0].interactable = true;
                P2P3Buttons[1].interactable = false;
            }
            else if (ModeSelector.mode == ModeSelector.Modes.Animals)
            {

                P2P3Buttons[0].interactable = false;
                P2P3Buttons[1].interactable = false;

            }
            else
            {
                P2P3Buttons[0].interactable = false;
                P2P3Buttons[1].interactable = false;

            }
        }
    }

    public void SetLevel(int level)
    {
        LevelSelector.level = level;
     
    }

    public void showLevel()
    {
        int LevelSetIndex;
        LevelSetIndex = (PhaseSelector.phase - 1) * 3;
        if (ModeSelector.mode == ModeSelector.Modes.Animals)
        {
            LevelSetIndex += 1;
        }
        else if (ModeSelector.mode == ModeSelector.Modes.Fruits)
        {
            LevelSetIndex += 2;
        }
        Level currentLevel = levelSets[LevelSetIndex].levels[LevelSelector.level-1];
        for(int i = 0; i < currentLevel.activeObjects.Length; i++)
        {
            currentLevel.activeObjects[i].SetActive(true);
        }

    }
    public void hideLevel()
    {
        int LevelSetIndex;
        LevelSetIndex = (PhaseSelector.phase - 1) * 3;
        if (ModeSelector.mode == ModeSelector.Modes.Animals)
        {
            LevelSetIndex += 1;
        }
        else if (ModeSelector.mode == ModeSelector.Modes.Fruits)
        {
            LevelSetIndex += 2;
        }
        Level currentLevel = levelSets[LevelSetIndex].levels[LevelSelector.level - 1];
        for (int i = 0; i < currentLevel.activeObjects.Length; i++)
        {
            currentLevel.activeObjects[i].SetActive(false);
        }

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
