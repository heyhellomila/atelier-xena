using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FrameSynthesis.VR.Example
{
    public class cubefly : MonoBehaviour
    {

        void Start()
        {
            
            VRGestureRecognizer.Current.NodHandler += OnNod;
            VRGestureRecognizer.Current.HeadshakeLeftHandler += OnHeadshakeLeft;
            VRGestureRecognizer.Current.HeadshakeRightHandler += OnHeadshakeRight;

        }

        void OnNod()
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 5, 0, ForceMode.Impulse);
        }

        void OnHeadshakeLeft()
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-5, 0, 0, ForceMode.Impulse);
        }
        void OnHeadshakeRight()
        {
            gameObject.GetComponent<Rigidbody>().AddForce(5, 0, 0, ForceMode.Impulse);
        }
    }
}