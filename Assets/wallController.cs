using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallController : MonoBehaviour
{
        private Animator animator;
        private bool isWallUp;

        private void Start()
        {
            animator = GetComponent<Animator>();
            isWallUp = false;
        }

        public void SetWallState(bool goesUp)
        {
            if (goesUp && !isWallUp)
            {
                animator.SetTrigger("goesUp");
                isWallUp = true;
            }
            else if (!goesUp && isWallUp)
            {
                animator.SetTrigger("idle");
                isWallUp = false;
            }
        }
}
