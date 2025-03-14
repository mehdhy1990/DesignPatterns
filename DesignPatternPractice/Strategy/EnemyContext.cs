namespace DesignPatternPractice.Strategy;

public class EnemyContext
{
    private IEenemy? _enemy;

    public void SetEnemy(IEenemy enemy)
    {
        _enemy = enemy;
    }

    public void Execute()
    {
        _enemy.Attack();
    }
}