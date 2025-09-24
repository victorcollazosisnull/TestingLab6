public class Health
{
    public int Current { get; private set; }
    private int max;

    public Health(int maxHealth)
    {
        max = maxHealth;
        Current = max;
    }

    public void Apply(int damage)
    {
        Current -= damage;
        if (Current < 0)
            Current = 0;
    }
}
