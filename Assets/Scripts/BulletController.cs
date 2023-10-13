using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private Robot robot;
    [SerializeField] public int numderBullet = 1;
    [SerializeField] public TMP_Text textBullet;

    private void OnTriggerEnter(Collider other)
    {
        numderBullet++;
        if (numderBullet >= 4)
        {
            numderBullet = 1;
        }
        for (int i = 0; i < robot.prefab.Length; i++)
        {
            robot.bullet = robot.prefab[numderBullet - 1];
        }
        textBullet.text = numderBullet.ToString();
    }
}
