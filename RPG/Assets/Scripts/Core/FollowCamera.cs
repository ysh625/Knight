﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPG.core
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField] Transform target;
        

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = target.position;
        }
    }
}

