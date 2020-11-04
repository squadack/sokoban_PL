using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2Int direction;
        // ustaw wartosc direction na jedno z (1, 0), (-1, 0), (0, 1), (0, -1) w zaleznosci od wcisnietych klawiszy
        gameController.TryMovePlayer(direction);
    }
}
