using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class vb_anim : MonoBehaviour
{

    public GameObject vbBtnObj;
    public Animator ogreAni;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("Laciebtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        ogreAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        ogreAni.Play("attack");
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        ogreAni.Play("idle");
        Debug.Log("Button released");
    }
}