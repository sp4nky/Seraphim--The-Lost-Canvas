using UnityEngine;

public class CharacterMagicalDefence : MonoBehaviour
{
    public float defence;

    public void defaultDefence(float maxDefence)
    {
        defence = maxDefence;
    }

    public void decreaseDefence(float less)
    {
        defence -= less;
        if (defence < 0)
        {
            defence = 0;
        }
    }
}
