using UnityEngine;
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

        ogreAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        ogreAni.Play("Attack");
        Debug.Log("Button pressed");
    }
}