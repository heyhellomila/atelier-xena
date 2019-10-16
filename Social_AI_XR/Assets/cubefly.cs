using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace FrameSynthesis.VR.Example
{
    public class cubefly : MonoBehaviour
    {
        public TextMesh textDebugger;
        void Start()
        {
            
            VRGestureRecognizer.Current.NodDownHandler += OnNodDown;
            //VRGestureRecognizer.Current.NodUpHandler += OnNodUp;
            VRGestureRecognizer.Current.HeadshakeLeftHandler += OnHeadshakeLeft;
            VRGestureRecognizer.Current.HeadshakeRightHandler += OnHeadshakeRight;
            textDebugger.text = "START";
        }

        void OnNodDown()
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 5, 0, ForceMode.Impulse);
            textDebugger.text = "Nod Down";
        }
        /*void OnNodUp()
        {
            gameObject.GetComponent<Rigidbody>().AddForce(0, 0, -5, ForceMode.Impulse);
            textDebugger.text = "Nod Up";
        }*/

        void OnHeadshakeLeft()
        {
            gameObject.GetComponent<Rigidbody>().AddForce(-5, 0, 0, ForceMode.Impulse);
            textDebugger.text = "Head Shake Left";
        }
        void OnHeadshakeRight()
        {
            gameObject.GetComponent<Rigidbody>().AddForce(5, 0, 0, ForceMode.Impulse);
            textDebugger.text = "Head Shake Right";
        }
    }
}