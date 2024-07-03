using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private GameObject ball;    //��������� �� ��'��� �� ����
    private Vector3 offset;     // ������� ������ ������� ���������
    private Vector3 mAngeles;   // ����, ��������� ����� ����
    private float sensitivityH = 2.0f;
    private float sensitivityV = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
        offset = this.transform.position - ball.transform.position;
        mAngeles = this.transform.eulerAngles;
    }

    private void Update()
    {
        mAngeles.y += Input.GetAxis("Mouse X") * sensitivityH;
        mAngeles.x -= Input.GetAxis("Mouse Y") * sensitivityV;

        if (mAngeles.x > 40f) mAngeles.x = 40f;
        if (mAngeles.x < -20f) mAngeles.x = -20f;

        if (mAngeles.y > 360) mAngeles.y -= 360;
        if (mAngeles.y < 0) mAngeles.y += 360;
    }

    // Update is called once per frame
    void LateUpdate()   // ����� �� ������ ����� ������ � LateUpdate
    {
        // ��������� - ������ �������� ����� � ����������
        // !! ��������� ���� ���������
        this.transform.position = ball.transform.position + Quaternion.Euler(0, mAngeles.y, 0) * offset;
        this.transform.eulerAngles = mAngeles;
    }
}
