﻿using System;
using UnityEngine;

/**
 * http://wiki.unity3d.com/index.php?title=CameraFacingBillboard
 */
namespace Assets.Sources.components.behaviours.legacy
{
    [Obsolete("Not used anymore", false)]
    public class CameraFacingBillboard : MonoBehaviour
    {
        public Camera mCamera = Camera.main;

        public void Start()
        {
            if (mCamera == null) mCamera = Camera.main;
        }

        public void Update()
        {
           // var lookDirection = (camera.transform.position - transform.position).normalized;
           // transform.rotation = Quaternion.LookRotation(lookDirection, camera.transform.up);
            //transform.LookAt(transform.position + mCamera.transform.rotation * Vector3.back, mCamera.transform.rotation * mCamera.transform.up);
        }
    }
}