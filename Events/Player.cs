class Player {
    public event Action OnDeath;
    private int health = 100;

    private void Die() {
        Console.WriteLine("Игрок погиб!!!!!");
        OnDeath?.Invoke();
    }
    public void TakeDamage(int damage) {
        health -= damage;
        if (health <= 0) {
            Die();
        }
    }
}