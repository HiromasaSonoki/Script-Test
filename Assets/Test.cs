using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53;

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    public void Magic()
    {
        if(mp > 5)
        {
            mp = mp - 5;
            Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        for(int i = 0;i < 11; i++)
        {
            lastboss.Magic();
        }
        // �U���p�̊֐����Ăяo��
        //lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        //lastboss.Defence(3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
