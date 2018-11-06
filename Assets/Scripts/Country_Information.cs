using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Country_Information : MonoBehaviour {

    public GameObject temp;

    public string[] relations;

    public GameObject Information;
    public GameObject Status;
    public GameObject Infrastructure;
    public GameObject Relations;

    public bool homeSelect = false;
    public Text homeName;
    public Text homeGov;
    public Text homeMotive;
    public Text homeFaction;
    public Text homeRelationI;
    public Text homeRelationA;
    public Text agencyName;
    public Text agencyGov;
    public Text agencyMotive;
    public Text agencyFaction;
    public Text agencyRelation;
    public Text selectName;
    public Text selectGov;
    public Text selectMotive;
    public Text selectFaction;
    public Text selectRelationI;
    public Text selectRelationA;

    public Text countryName;
    public Text countryDescription;
    public Text countryLanguage;
    public Text countryPopulation;
    public Text countryWealth;
    public Text countryTech;
    public Text countryEducation;
    public Text countrySecurity;
    public Text countryGovernment;
    public Text countryRelation;
    public Image countryFlag;

    public string[] countryNames;
    public string[] countryDescriptions;
    public string[] countryLanguages;
    public string[] countryPopulations;
    public string[] countryWealths;
    public string[] countryTechs;
    public string[] countryEducations;
    public string[] countrySecuritys;
    public string[] countryGovernments;
    public string[] countryRelations;
    public Sprite[] countryFlags;

    public void SetValues(int countryNumber)
    {
        if (!homeSelect)
        {
            homeName.text = countryNames[countryNumber];
            homeGov.text = countryGovernments[countryNumber];
            //homeMotive.text = countryMotives[countryNumber];
            //homeFaction = 
            homeRelationA.text = "HQ";
            homeSelect = true;
        }
        countryName.text = countryNames[countryNumber];
        countryDescription.text = countryDescriptions[countryNumber];
        countryLanguage.text = countryLanguages[countryNumber];
        countryPopulation.text = countryPopulations[countryNumber];
        countryWealth.text = countryWealths[countryNumber];
        countryTech.text = countryTechs[countryNumber];
        countryEducation.text = countryEducations[countryNumber];
        countrySecurity.text = countrySecuritys[countryNumber];
        countryGovernment.text = countryGovernments[countryNumber];
        countryRelation.text = countryRelations[countryNumber];
        countryFlag.sprite = countryFlags[countryNumber];
    }

    public void CloseScreen()
    {
        gameObject.SetActive(false);
    }

    public void OpenScreen()
    {
        int x = temp.GetComponent< Current_Selected >().currentCountry;
        SetValues(x);
        Information.SetActive(true);
        Status.SetActive(false);
        Infrastructure.SetActive(false);
        Relations.SetActive(false);
        gameObject.SetActive(true);
    }

    public void OpenStatus()
    {
        Information.SetActive(false);
        Status.SetActive(true);
        Infrastructure.SetActive(false);
        Relations.SetActive(false);
        gameObject.SetActive(true);
    }

    public void OpenInfrastructure()
    {
        Information.SetActive(false);
        Status.SetActive(false);
        Infrastructure.SetActive(true);
        Relations.SetActive(false);
        gameObject.SetActive(true);
    }

    public void OpenRelations()
    {
        int x = temp.GetComponent<Current_Selected>().currentCountry;
        //do stuff
        selectName.text = countryNames[x];
        selectGov.text = countryGovernments[x];
        //selectMotive.text = countryNames[x];
        //selectFaction.text = countryNames[x];
        selectRelationI.text = CalculateRelationI();
        selectRelationA.text = CalculateRelationA();
        //activate

        Information.SetActive(false);
        Status.SetActive(false);
        Infrastructure.SetActive(false);
        Relations.SetActive(true);
        gameObject.SetActive(true);
    }

    public string CalculateRelationI()
    {
        int x = 0;

        if (selectGov.text == homeGov.text)
        {
            x++;
        }
        if (selectMotive.text == selectMotive.text)
        {
            x++;
        }
        if (selectFaction.text == homeFaction.text)
        {
            x++;
        }
        if (selectName == homeName)
        {
            x++;
        }

        return relations[x];
        
    }

    public string CalculateRelationA()
    {
        int x = 0;

        if (selectGov.text == agencyGov.text)
        {
            x++;
        }
        if (selectMotive.text == agencyMotive.text)
        {
            x++;
        }
        if (selectFaction.text == agencyFaction.text)
        {
            x++;
        }

        return relations[x];
    }

}
