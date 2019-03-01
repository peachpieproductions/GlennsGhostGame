using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour {

    public static MainManager inst;
    public List<Player> players = new List<Player>();


    private void Awake() {
        inst = this;
    }

    private void Start() {
        foreach (Player p in FindObjectsOfType<Player>()) players.Add(p);
    }



}
