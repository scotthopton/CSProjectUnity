using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnimation : MonoBehaviour
{
    public LevelSelector levelSelect;
    public GameObject levelCompletePg;
    IEnumerator Animation()
    {
        yield return new WaitForSeconds(0.6f);
        levelSelect.hideLevel();    
        gameObject.SetActive(false);
        levelCompletePg.SetActive(true);
    }
    public void RunAnimation()
    {
        gameObject.SetActive(true);
        StartCoroutine(Animation());
    }
}
