using UnityEngine;
using System.Collections.Generic;
using System;

public class Grid : MonoBehaviour {

    public GameObject sprite;
    public GameObject playerspr;

    int col;
    int row;
    string[] map;
    GameObject block;

    void Awake() {
        // Считывание 
        read();
        // Создание объектов
        create();
        players();
    }

    void read() {
        map = System.IO.File.ReadAllLines(@"Assets/LV1.map"); // первые две строчки - количество колонок и строк
        col = Convert.ToInt32(map[0]);
        row = Convert.ToInt32(map[1]);
    }

    void create() {     // Посимвольно считываем карту, в зависимости от символа меняем спрайт
        for (int i = 0; i < row; i++)
            for (int j = 0; j < col; j++)
            {
                switch (map[i + 2][j])
                {
                    case '0':
                        block = (GameObject)Instantiate(sprite, new Vector3(0 + i, 0 - j, 0), Quaternion.identity);
                        break;
                }
                block.name = "Block" + j + i;
                block.transform.parent = GameObject.Find("Grid").transform;
            }
    }

    void players()
    {
        Instantiate(playerspr, new Vector3(0 , 0 , 0), Quaternion.identity).name = "Player";
        GameObject.Find("Player").GetComponent<player>().pos = new Vector2(0, 0);
    }




}
