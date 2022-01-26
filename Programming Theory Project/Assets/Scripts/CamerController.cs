using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    public float speed;
    public float clampLeft;
    public float clampRight;
    public Animator cameraAnimation;
    private int counter = 0, animationDuration = 15;
    private float cameraX;
    private bool gameStart;
    // Use this for initialization
    void Start()
    {
        cameraX = transform.position.x;
        cameraAnimation = GameObject.Find("Main Camera").GetComponent<Animator>();
        StartCoroutine(AnimationPlay());
    }

    IEnumerator AnimationPlay()
    {
        while (counter != animationDuration)
        {
            yield return new WaitForSeconds(1f);
            counter++;
        }
        stopAnimation();
    }

    void stopAnimation()
    {
        cameraAnimation.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < clampRight)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > clampLeft)
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }

    }

}
