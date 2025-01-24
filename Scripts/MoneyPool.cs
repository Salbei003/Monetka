using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyPool : MonoBehaviour
{
    public GameObject prefab;
    [Min(1)]
    public int count = 10;

    private readonly List<Money> pool = new();

    private void Start()
    {
        FillPool();
    }


    public void GetItem()
    {
        foreach (Money money in pool)
        {
            if (!money.active)
            {
                money.SetOn();
                return;
            }
        }

        InstNewItem().SetOn();
    }

    private Money InstNewItem()
    {
        Money item = Instantiate(prefab, transform).GetComponent<Money>();
        pool.Add(item);
        return item;
    }

    private void FillPool()
    {
        for (int i = 0; i < count; i++)
        {
            Money item = Instantiate(prefab, transform).GetComponent<Money>();
            pool.Add(item);
        }
    }








}
