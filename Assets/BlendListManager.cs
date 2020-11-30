using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class BlendListManager : MonoBehaviour
{
    [SerializeField]private CinemachineBlendListCamera blendlist;
    
    // Start is called before the first frame update
    void Start()
    {
        blendlist = GetComponent<CinemachineBlendListCamera>();
        foreach (var VARIABLE in blendlist.m_Instructions)
        {
            Debug.Log(VARIABLE.m_VirtualCamera.VirtualCameraGameObject.name);
        }

        foreach (var VARIABLE in blendlist.ChildCameras)
        {
            Debug.Log(VARIABLE.LookAt.root.gameObject.name);
            Debug.Log(VARIABLE.Follow.root.gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}