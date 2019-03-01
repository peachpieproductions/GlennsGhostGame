using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {


    public Player currentTarget;
    public float speed = 1;

    private void Start() {
        StartCoroutine(UpdateClosestPlayer());
    }

    private void Update() {
        if (currentTarget) {
            transform.position = Vector2.MoveTowards(transform.position, currentTarget.transform.position, speed * Time.deltaTime);
        } else {
            currentTarget = FindClosestPlayer();
        }
    }

    public Player FindClosestPlayer() {
        Player closest = MainManager.inst.players[0];
        float dist = Vector2.Distance(transform.position, closest.transform.position);
        foreach(Player p in MainManager.inst.players) {
            float checkDist = Vector2.Distance(transform.position, p.transform.position);
            if (checkDist < dist) {
                dist = checkDist;
                closest = p;
            }
        }
        return closest;
    }

    IEnumerator UpdateClosestPlayer() {
        while (true) {
            currentTarget = FindClosestPlayer();
            yield return new WaitForSeconds(3f);
        }
    }




}
