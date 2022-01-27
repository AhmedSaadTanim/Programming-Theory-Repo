using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //ENCAPSULATION

    [SerializeField] Animator cameraAnimation;
    [SerializeField] Vector3 playerPos;

    public bool gameStart { get; private set; }

    private int counter = 0, animationDuration = 15;
    private Vector3 offSet = new Vector3(0, 0, -25);
   
    // Use this for initialization
    void Start()
    {
        cameraAnimation = GameObject.Find("Main Camera").GetComponent<Animator>();
        StartCoroutine(AnimationPlay());
    }

    //starting animation
    IEnumerator AnimationPlay()
    {
        while (counter != animationDuration)
        {
            yield return new WaitForSeconds(1f);
            counter++;
        }
        stopAnimation();
    }

    //stopping animation and starting the gameplay
    void stopAnimation()
    {
        cameraAnimation.enabled = false;
        gameStart = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (gameStart)
        {
            //ABSTRACTION
            MoveCamera();
        }
    }

    //moving camera according to player input
    void MoveCamera()
    {
        playerPos = GameObject.Find("Jammo_Player").transform.position;
        offSet.x = playerPos.x;
        transform.position = offSet;
    }
}
