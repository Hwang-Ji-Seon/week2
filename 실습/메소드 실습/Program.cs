public class Player
{
    private string ID;
    private int currentHP;

    public Player()
    {
        ID = "고박사";
    }
    public Player(int hp): this()
    {
        currentHP = hp;
    }
    public Player(int hp, int mp): this(hp)
    {
        currentMP=mp;
    }


    public Player(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }

    private void Awake()
    {
        TakeDamage(100);
    }
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}

public class Enemy
{
    private Player player;

    public void AttakToTarget(Player target)
    {
        target.TakeDamage(100);
    }
}

public class GameController
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player02 = new Player("유니티",10);
        player01.TakeDamage(100);
        player02.TakeDamage(200);
    }
}