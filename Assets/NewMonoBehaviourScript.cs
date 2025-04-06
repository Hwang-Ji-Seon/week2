using UnityEngine;

public class Player
{
    private int currentHP;

    public void SetCurrentHP(int hp)
    {
        if(hp > 0)
        {
            currentHP = hp;
        }
    }

    public int GetCurrentHP()
    {
        return currentHP;
    }
}

public class GameController: MonoBehaviour
{
    private void Awake()
    {
        Player player=new Player();

        player.SetCurrentHP = 100;
        Debug.Log($"HP:{player.GetCurrentHP()}");
    }
}