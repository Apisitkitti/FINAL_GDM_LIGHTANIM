using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animation_control : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] int round = 0;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        AnimSetter();
    }

    void AnimSetter()
    {
        // Use modulo operator to create a loop
        int round_check = round > 0 ? (int)Mathf.Repeat(Time.time, round) : 0;

        anim.SetInteger("anim_round", round_check + 1);
    }
}
