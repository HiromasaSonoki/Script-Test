using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Magic()
    {
        if(mp > 5)
        {
            mp = mp - 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        for(int i = 0;i < 11; i++)
        {
            lastboss.Magic();
        }
        // 攻撃用の関数を呼び出す
        //lastboss.Attack();
        // 防御用の関数を呼び出す
        //lastboss.Defence(3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
