﻿using UnityEngine;
using System.Collections;

public class NewBookcaseScript : MonoBehaviour
{
    public bool activated;
    public bool inCase;
    public GameObject bookPrefab;
    GameObject books;
    Transform[] bookTransforms;
    int resetTimer;

    // Use this for initialization
    void Start()
    {
        activated = false;
        inCase = true;
        books = transform.FindChild("Books").gameObject;
        bookTransforms = new Transform[books.transform.childCount];
        for (int i = 0; i < books.transform.childCount; i++)
        {
            bookTransforms[i] = books.transform.GetChild(i).transform;
        }
        resetTimer = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (activated && inCase)
        {
            for (int i = 0; i < books.transform.childCount; i++)
            {
                books.transform.GetChild(i).GetChild(0).gameObject.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * Random.Range(100, 200));
                activated = false;
            }
            inCase = false;
        }
        if (!inCase)
        {
            resetTimer++;

            if (resetTimer > 50)
            {
                GetComponent<Interaction>().fearingOn = false;
            }
            if (resetTimer > 200)
            {
                Reset();
            }
        }
    }

    void Reset()
    {
        for (int i = 0; i < books.transform.childCount; i++)
        {
            Destroy(books.transform.GetChild(i).GetChild(0).gameObject);
            GameObject Book = Instantiate(bookPrefab);
            Book.transform.parent = books.transform.GetChild(i);
            Book.transform.localPosition = new Vector3(0, 0, 0);
            Book.transform.localRotation = new Quaternion(0, 0, 0, 0);
            Book.transform.localScale = new Vector3(1, 1, 1);
        }
        activated = false;
        inCase = true;
        resetTimer = 0;
    }
}
