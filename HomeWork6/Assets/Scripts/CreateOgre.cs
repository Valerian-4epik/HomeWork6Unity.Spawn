using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateOgre : MonoBehaviour
{
    [SerializeField] private GameObject _ogre;
    [SerializeField] private Transform[] _spawns;
    [SerializeField] private int _countOgres;

    private void Start()
    {
        var createOgre = StartCoroutine(CreateOgres());
    }

    private IEnumerator CreateOgres()
    {
        while (_countOgres > 0)
        {
            for (int i = 0; i < _spawns.Length; i++)
            {
                GameObject newOgre = Instantiate(_ogre, _spawns[i].position, Quaternion.identity);
                _countOgres--;

                yield return new WaitForSeconds(2F);        

                if(_countOgres == 0)
                {
                    break;
                }
            }
        }
     
    }
}
