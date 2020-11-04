using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level
{
    public List<List<Field>> levelLayout;
    public List<Vector2Int> targets; // na jakich pozycjach są pola docelowe
    public int width; // dlugosc najdluzszego wiersza
    public int height; // ile wierszy

    public Level() {
        string demoLevel =
@"######
#@.$_#
######";
        CreateFromString(demoLevel);
    }

    public Level(string s) {
        CreateFromString(s);
    }

    private void CreateFromString(string s) {
        // # - sciana, . - podloga, _ - pole docelowe, $ - skrzynia, @ - gracz
        //TODO uzupelnic levelLayout (i pozostałe zmienne)
        Debug.Log("Poziom stworzony.");
    }
}

