using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour {

    public static MainManager inst;
    public static Camera cam;
    public List<Player> players = new List<Player>();
    public List<Level> levels = new List<Level>();
    

    private void Awake() {
        inst = this;
        cam = Camera.main;
        foreach (Player p in FindObjectsOfType<Player>()) players.Add(p);
        foreach (Level l in FindObjectsOfType<Level>()) levels.Add(l);
    }

    private void Start() {
        
        
        
    }



}
