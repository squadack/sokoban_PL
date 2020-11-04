using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // 1. Gdzie znajduje się gracz?
    // 2. Czy na polu (x, y) znajduje się skrzynia?
    // 3. Spróbuj przesunąć gracza w kierunku d

    public GameObject wallPrefab;
    public GameObject floorPrefab;
    public GameObject targetPrefab;
    public GameObject playerPrefab;
    public GameObject cratePrefab;

    public List<Level> levels;
    public int currentLevel = 0;

    private Player playerGameObject;
    private GameObject[,] crates;
    private Vector2Int playerPosition;

    // Start is called before the first frame update
    void Start() {
        levels = new List<Level>();
        levels.Add(new Level());
    }

    // Update is called once per frame
    void Update() {
        
    }

    //po wykonianiu LoadLevel(idx) gra znajduje się w stanie początkowym poziomu o indeksie idx
    private void LoadLevel(int idx) {
        currentLevel = idx;
        Level lev = levels[currentLevel];

        crates = new GameObject[lev.width, lev.height];

        for (int row = 0; row < lev.height; row++) {
            for (int col = 0; col < lev.levelLayout[row].Count; col++) {
                InstantiateField(row, col);
            }
        }
        CenterCameraOn(lev.width / 2, lev.height / 2);
    }

    private void InstantiateField(int row, int col) {
        //Instantiate() na odpowiednim prefabie w zależności od FloorType i Entity
        // Instantiate(floor, new Vector3(row, col, 0), Quaternion.identity);
        // w wypdaku gracza lub skrzyni zapisujemy wynik Instantiate() w playerGameObject / crates

        //jezeli tworzymy gracza to od razu robimy playerObject.gameCotroller = this;
    }

    private void CenterCameraOn(float x, float y) {
        //TODO wycentrować Camera.main na (x, y) i ustawic orthographicSize tak aby cały poziom był widoczny
    }

    public bool TryMovePlayer(Vector2Int direction) {
        // probujemy przesunac gracza w zadanym kierunku i zwracamy info czy sie udalo
        // Możemy przesunąć gracza jeżeli w danym kierunku pole nie jest ścianą i:
        // - to pole jest puste
        // - na tym polu znajduje sie skrzynka, którą możemy przesunąć w tym samym kierunku

        // jesli sie da to:
            // zmienamy pozycję odpowiedniego GameObject
            // aktualizujemy playerPosition
            //zwracamy true
    }

    private bool TryMoveCrate(Vector2Int pos, Vector2Int dir) {
        // mozemy przesunac skrzynke pod warunkiem, że pole (pos + dir) jest puste i nie jest ścianą
        // jesli sie da to:
            // zmienamy pozycję odpowiedniego GameObject
            // przepisujemy ten Game Object na odpowiednie miejsce w tablicy crates 
            // zwracamy true
        return false;
    }
}
