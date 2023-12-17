using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public bool isLeft;
    public SpriteRenderer spriter;

    SpriteRenderer player;

    Vector3 rightPos = new Vector3(0.35f, -0.15f, 0);//�������� ��ġ�� ����
    Vector3 rightPosReverse = new Vector3(-0.15f, -0.15f, 0);
    Quaternion leftRot = Quaternion.Euler(0, 0, -35);//�޼��� �� ȸ���� ����
    Quaternion leftRotReverse = Quaternion.Euler(0, 0, -135);


    private void Awake()
    {
        player = GetComponentsInParent<SpriteRenderer>()[1]; //0�� ����
    }
}
