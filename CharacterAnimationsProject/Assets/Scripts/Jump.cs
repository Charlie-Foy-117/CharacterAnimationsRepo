using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Animator animate;
    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        StartCoroutine(ExecuteAfterTime((float)1.3));
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        animate.SetFloat("jump", 1);
        yield return new WaitForSeconds(time);

        yield return new WaitForSeconds(time);
        animate.SetFloat("jump", 0);
    }
}
