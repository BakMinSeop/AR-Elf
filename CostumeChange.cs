using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeChange : MonoBehaviour
{
    //public GameObject[] Elf;
    //public GameObject[] ElfAni;
    //public GameObject[] Weapon;
    //public GameObject[] Pet;

    //public int ElfNum;
    //public int AniNum;
    //public int WeaponNum;
    //public int PetNum;

    public GameObject[] Elf;
    public GameObject[] Pet;
    public Animator Ani;

    public int ElfNum;
    public int PetNum;
    public int AniNum;

    public bool isIdle;
    public bool isPet;



    void Start ()
    {
        ElfNum = 0;
        PetNum = 0;
        AniNum = 0;

        for (int i = 0; i < Pet.Length; i++)
        {
            Pet[i].SetActive(false);
        }

        for (int i = 1; i < Elf.Length; i++)
        {
            Elf[i].SetActive(false);
        }

        Ani = GetComponent<Animator>();

        Elf[0].SetActive(true);
    }
	
	void Update ()
    {
        Anime();
	}

    public void CharacterChange()
    {
        ElfNum++;
        isIdle = true;
        isPet = false;

        if (ElfNum >= Elf.Length)
        {
            ElfNum = 0;
        }

        for (int i = 0; i < Elf.Length; i++)
        {
            if (ElfNum != i)
            {
                Elf[i].SetActive(false);
            }
        }

        Elf[ElfNum].SetActive(true);
    }

    void Anime()
    {
        if (PetNum == 0)
        {
            Ani.SetBool("Idle", true);
            Ani.SetBool("Pet", false);
        }
        else
        {
            Ani.SetBool("Idle", false);
            Ani.SetBool("Pet", true);
        }
    }

    public void PetChange()
    {
        PetNum++;

        if (PetNum >= Pet.Length)
        {
            PetNum = 0;
        }

        if (PetNum == 0)
        {
            for (int i = 0; i < Pet.Length; i++)
            {
                Pet[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 1; i < Pet.Length; i++)
            {
                if (PetNum != i)
                {
                    Pet[i].SetActive(false);
                }
            }

            Pet[PetNum].SetActive(true);
        }
    }
}
