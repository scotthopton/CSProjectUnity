using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeSelector : MonoBehaviour
{
    public enum Modes
    {
        Shapes,
        Fruits,
        Animals
    };
    public static Modes mode;
    public Text phaseText;

    public void setMode(int mode)
    {
        if (mode == 1) {
            ModeSelector.mode = Modes.Shapes;
        }
        else if (mode == 3)
        {
            ModeSelector.mode = Modes.Fruits;
        }
        else
        {
            ModeSelector.mode = Modes.Animals;
        }

    }
    public void Show()
    {
        gameObject.SetActive(true);
        phaseText.text = "Phase " + PhaseSelector.phase;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
