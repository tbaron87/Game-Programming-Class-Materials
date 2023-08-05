using UnityEngine;

public class DifficultyExample : MonoBehaviour
{

    // This would normally go in a separate file it's just here for berevity
    private enum Difficulty
    {
        EASY,
        NORMAL,
        HARD
    }

    // You would normally want this to be a static value in a static class
    // so that it is easily accessible by multiple classes. Again, berevity
    [SerializeField]
    private Difficulty difficulty;

    private int enemyHealth;

    public void Start()
    {
        switch (difficulty)
        {
            case Difficulty.EASY:
                enemyHealth = 50;
                break;
            case Difficulty.NORMAL:
                enemyHealth = 100;
                break;
            case Difficulty.HARD:
                enemyHealth = 150;
                break;
        }
    }

    // This is not used - it is to eliminate warnings for not using variables
    public void dummy()
    {
        Debug.Log(enemyHealth);
    }

}
