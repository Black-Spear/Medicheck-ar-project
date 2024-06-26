using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundexit : MonoBehaviour {
    public AudioClip[] aClips;
    public AudioSource myAudioSource;
    public GameObject Firstbtn;
    string btnName;
    [SerializeField]
    private Camera ARCamera;

 // Use this for initialization
 void Start () {
        myAudioSource = GetComponent<AudioSource>();
  
 }
 
 // Update is called once per frame
 void Update () {

   if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = ARCamera.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit))
            {
                btnName = Hit.transform.name;
                switch (btnName)
                {
                    case "X":
                        myAudioSource.clip = aClips[0];
                        myAudioSource.Play();
                        Firstbtn.GetComponent<FadeScript>().HideUI();
                        Debug.Log("The button is pressed 1");
                        break;
                    case "myButton2":
                        myAudioSource.clip = aClips[1];
                        myAudioSource.Play();
                        break;
                    case "myButton3":
                        myAudioSource.clip = aClips[2];
                        myAudioSource.Play();
                        break;
                    case "myButton4":
                        myAudioSource.clip = aClips[3];
                        myAudioSource.Play();
                        break;
                    case "myButton5":
                        myAudioSource.clip = aClips[4];
                        myAudioSource.Play();
                        break;
                    case "myButton6":
                        myAudioSource.clip = aClips[5];
                        myAudioSource.Play();
                        break;
                    default:
                        break;

                }
            }
        }
        
 }
}