using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityPeople
{
    public class CityPeople : MonoBehaviour
    {
        private AnimationClip[] myClips;
        private Animator animator;

        void Start()
        {
            animator = GetComponent<Animator>();
            if (animator != null)
            {
                myClips = animator.runtimeAnimatorController.animationClips;
                StartCoroutine(StartWalking());
                //PlayAnyClip();
                //StartCoroutine(ShuffleClips());
            }
        }
        void Update()
        {
            
        }

        // void PlayAnyClip()
        // {
        //     var cl = myClips[Random.Range(0, myClips.Length)];
        //     animator.CrossFadeInFixedTime(cl.name, 1.0f, -1, Random.value * cl.length);
        // }

        // IEnumerator ShuffleClips()
        // {
        //     while (true)
        //     {
        //         yield return new WaitForSeconds(15.0f + Random.value * 5.0f);
        //         PlayAnyClip();
        //     }
        // }

        IEnumerator StartWalking()
        {
            yield return new WaitForSeconds(0.5f);
            animator.SetTrigger("Walking");
        }

    }
}
