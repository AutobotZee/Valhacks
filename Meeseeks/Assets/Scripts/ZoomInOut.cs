using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomInOut : MonoBehaviour
{


    public Button zoomIn;
    public Button zoomOut;
    public Camera m_OrthographicCamera;

    void Start () {

        m_OrthographicCamera.orthographic = true;

        zoomIn.onClick.AddListener(ZoomIn);
        zoomOut.onClick.AddListener(ZoomOut);
    }
	
	void Update () {
		
	}

    void ZoomIn()
    {
        m_OrthographicCamera.orthographicSize -= 7.0f;
    }

    void ZoomOut()
    {
        m_OrthographicCamera.orthographicSize += 7.0f;
    }
}
