using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
	{
        Debug.Log(this.power + " 데미지 입힘");
	}

    public void Damage(int damage)
	{
        this.hp -= damage;
        Debug.Log(damage + " 데미지 받음");
	}
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player p1 = new Player();
        p1.Attack();
        p1.Damage(30);

        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 3.0f;
        Debug.Log(playerPos);

        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;
        Debug.Log(dir);

        Debug.Log(dir.magnitude); // len
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
