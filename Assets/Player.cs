using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera playerVC;
    [SerializeField] private int playerNo = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerNo(int no)
    {
        if (playerNo == 0)
        {
            playerNo = no;
        }
    }
}
