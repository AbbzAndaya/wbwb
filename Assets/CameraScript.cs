using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject CraneTopView;
    public GameObject Craneguyview;
    public GameObject BallView;


    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraOne();
        }

        if (Input.GetKeyDown("2"))
        {
            CameraTwo();
        }

        if (Input.GetKeyDown("3"))
        {
            CameraThree();
        }
    }

    void CameraOne()
    {
        CraneTopView.SetActive(true);
        Craneguyview.SetActive(false);
        BallView.SetActive(false);
    }

    void CameraTwo()
    {
        BallView.SetActive(false);
        Craneguyview.SetActive(true);
        CraneTopView.SetActive(false);
    }

    void CameraThree()
    {
        BallView.SetActive(true);
        Craneguyview.SetActive(false);
        CraneTopView.SetActive(false);
    }
}