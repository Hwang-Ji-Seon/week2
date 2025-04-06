using UnityEngine;

public class Entity
{
    public string ID;
    protected int currentHP;

    private void Initialize()
    {
        ID = "Noname";
    }

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }

    public Entity() { .. }
    ~Entity() { ..}
}

public class Player:Entity
{
    public Player(string id, int hp)
    {
        base.ID = "Noname";
        ID = id;
        currentHP = hp;

        RecoveryHP(1000);

        //private�̱� ������ ��� �Ұ�
        Initialize();
    }

    public Player() { ..}
    ~Player() { ..}
}

public class GameController
{
    private Player player;

    private void Awake()
    {
        player=new Player();
    }
}