using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateOgre : MonoBehaviour
{
    [SerializeField] private Ogre _template;
    [SerializeField] private Transform[] _spawns;

    private void Start()
    {
        StartCoroutine(CreateOgres());
    }

    private IEnumerator CreateOgres()
    {
        while (true)
        {
            for (int i = 0; i < _spawns.Length; i++)
            {
                Ogre newOgre = Instantiate(_template, _spawns[i].position, Quaternion.identity);

                yield return new WaitForSeconds(1.0f);
            }

            yield return new WaitForSeconds(1.0f);
        }     
    }
}
