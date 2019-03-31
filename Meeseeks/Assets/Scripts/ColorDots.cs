using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorDots : MonoBehaviour
{

    private GameObject[] dots1;
    private GameObject[] dots2;
    private GameObject[] dots3;

    public Button red;
    public Button yellow;
    public Button green;

    public Button more1;
    public Button more2;
    public Button more3;

    private bool redOn = false;
    private bool yellowOn = false;
    private bool greenOn = false;

    public GameObject infoBox1;
    public GameObject infoBox2;
    public GameObject infoBox3;

    public Button close1;
    public Button close2;
    public Button close3;

    public Button addEvent;
    public GameObject form;
    public Button close4;

    void Start ()
    {
        dots1 = GameObject.FindGameObjectsWithTag("Dots1");
        dots2 = GameObject.FindGameObjectsWithTag("Dots2");
        dots3 = GameObject.FindGameObjectsWithTag("Dots3");

        for (int i = 0; i < dots1.Length; i++)
        {
            dots1[i].SetActive(false);
        }
        for (int i = 0; i < dots2.Length; i++)
        {
            dots2[i].SetActive(false);
        }
        for (int i = 0; i < dots3.Length; i++)
        {
            dots3[i].SetActive(false);
        }
        
        red.onClick.AddListener(RedOn);
        yellow.onClick.AddListener(YellowOn);
        green.onClick.AddListener(GreenOn);
        more1.gameObject.SetActive(false);
        more2.gameObject.SetActive(false);
        more3.gameObject.SetActive(false);

        infoBox1.SetActive(false);
        infoBox2.SetActive(false);
        infoBox3.SetActive(false);
        form.SetActive(false);

        close1.onClick.AddListener(Close1);
        close2.onClick.AddListener(Close2);
        close3.onClick.AddListener(Close3);

        more1.onClick.AddListener(Open1);
        more2.onClick.AddListener(Open2);
        more3.onClick.AddListener(Open3);

        addEvent.onClick.AddListener(OpenForm);
        close4.onClick.AddListener(CloseForm);
    }
	
	void Update () {
		
	}

    void RedOn()
    {
        if(!redOn)
        {
            for (int i = 0; i < dots1.Length; i++)
            {
                dots1[i].SetActive(true);
            }

            redOn = true;
            red.GetComponent<Image>().color = Color.green;
            more1.gameObject.SetActive(true);
        }
        else
        {
            for (int i = 0; i < dots1.Length; i++)
            {
                dots1[i].SetActive(false);
            }

            redOn = false;
            red.GetComponent<Image>().color = Color.white;
            more1.gameObject.SetActive(false);
            infoBox1.SetActive(false);
            infoBox2.SetActive(false);
            infoBox3.SetActive(false);
        }
    }

    void YellowOn()
    {
        if(!yellowOn)
        {
            for (int i = 0; i < dots2.Length; i++)
            {
                dots2[i].SetActive(true);
            }

            yellowOn = true;
            yellow.GetComponent<Image>().color = Color.green;
            more2.gameObject.SetActive(true);
        }
        else
        {
            for (int i = 0; i < dots2.Length; i++)
            {
                dots2[i].SetActive(false);
            }

            yellowOn = false;
            yellow.GetComponent<Image>().color = Color.white;
            more2.gameObject.SetActive(false);
            infoBox1.SetActive(false);
            infoBox2.SetActive(false);
            infoBox3.SetActive(false);
        }
    }
    

    void GreenOn()
    {
        if(!greenOn)
        {
            for (int i = 0; i < dots3.Length; i++)
            {
                dots3[i].SetActive(true);
            }

            greenOn = true;
            green.GetComponent<Image>().color = Color.green;
            more3.gameObject.SetActive(true);
        }
        else
        {
            for (int i = 0; i < dots3.Length; i++)
            {
                dots3[i].SetActive(false);
            }

            greenOn = false;
            green.GetComponent<Image>().color = Color.white;
            more3.gameObject.SetActive(false);
            infoBox1.SetActive(false);
            infoBox2.SetActive(false);
            infoBox3.SetActive(false);
        }
    }

    void Close1()
    {
        infoBox1.SetActive(false);
        more1.gameObject.SetActive(true);
        if (greenOn)
        {
            more3.gameObject.SetActive(true);
        }
        if (yellowOn)
        {
            more2.gameObject.SetActive(true);
        }
    }

    void Close2()
    {

        infoBox2.SetActive(false);
        more2.gameObject.SetActive(true);
        if (greenOn)
        {
            more3.gameObject.SetActive(true);
        }
        if (redOn)
        {
            more1.gameObject.SetActive(true);
        }
    }

    void Close3()
    {

        infoBox3.SetActive(false);
        more3.gameObject.SetActive(true);
        if (redOn)
        {
            more1.gameObject.SetActive(true);
        }
        if (yellowOn)
        {
            more2.gameObject.SetActive(true);
        }
    }

    void Open1()
    {
        form.SetActive(false);
        infoBox1.SetActive(true);
        infoBox2.SetActive(false);
        infoBox3.SetActive(false);
        more1.gameObject.SetActive(false);
        if (greenOn)
        {
            more3.gameObject.SetActive(true);
        }
        if (yellowOn)
        {
            more2.gameObject.SetActive(true);
        }
    }
    void Open2()
    {
        form.SetActive(false);
        infoBox2.SetActive(true);
        infoBox1.SetActive(false);
        infoBox3.SetActive(false);
        more2.gameObject.SetActive(false);
        if (greenOn)
        {
            more3.gameObject.SetActive(true);
        }
        if (redOn)
        {
            more1.gameObject.SetActive(true);
        }
    }
    void Open3()
    {
        form.SetActive(false);
        infoBox3.SetActive(true);
        infoBox2.SetActive(false);
        infoBox1.SetActive(false);
        more3.gameObject.SetActive(false);
        if (redOn)
        {
            more1.gameObject.SetActive(true);
        }
        if (yellowOn)
        {
            more2.gameObject.SetActive(true);
        }
    }

    void OpenForm()
    {
        form.SetActive(true);
        infoBox3.SetActive(false);
        infoBox2.SetActive(false);
        infoBox1.SetActive(false);
    }

    void CloseForm()
    {
        form.SetActive(false);
    }
}
