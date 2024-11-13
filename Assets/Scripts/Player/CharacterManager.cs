using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager Instance;

    public Player Player;

    private void Awake()
    {
        Instance = this;
    }
}