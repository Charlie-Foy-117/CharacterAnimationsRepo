using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    Animator animate;
    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        StartCoroutine(ExecuteAfterTime((float)0.75));
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        animate.SetFloat("die", 1);
        yield return new WaitForSeconds(time);

        yield return new WaitForSeconds(time);
        animate.SetFloat("die", 0);
    }
}
