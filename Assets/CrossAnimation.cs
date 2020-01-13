using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimation : MonoBehaviour
{
    IEnumerator Animation()
    {
        yield return new WaitForSeconds(0.4f);
        gameObject.SetActive(false);
     
    }
    public void RunAnimation()
    {
        gameObject.SetActive(true);
        StartCoroutine(Animation());
    }
}
