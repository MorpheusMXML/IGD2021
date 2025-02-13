﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLegs : MonoBehaviour
{
    public enum LegsOptions
    {
        RightLegFront,
        RightLegSide,
        RightLegMain,
        LeftLegFront,
        LeftLegSide,
        LeftLegMain,
    }

    public SkinnedMeshRenderer rightLegFront;
    public SkinnedMeshRenderer rightLegSide;
    public SkinnedMeshRenderer rightLegMain;

    public SkinnedMeshRenderer leftLegFront;
    public SkinnedMeshRenderer leftLegSide;
    public SkinnedMeshRenderer leftLegMain;

    public List<Material> rightLegFrontOptions = new List<Material>();
    public List<Material> rightLegSideOptions = new List<Material>();
    public List<Material> rightLegMainOptions = new List<Material>();

    public List<Material> leftLegFrontOptions = new List<Material>();
    public List<Material> leftLegSideOptions = new List<Material>();
    public List<Material> leftLegMainOptions = new List<Material>();

    private int currentRightLegFrontOption = 0;
    private int currentRightLegSideOption = 0;
    private int currentRightLegMainOption = 0;

    private int currentLeftLegFrontOption = 0;
    private int currentLeftLegSideOption = 0;
    private int currentLeftLegMainOption = 0;

    public void NextOption()
    {
        //Right Leg "Next" set up
        currentRightLegFrontOption++; currentRightLegSideOption++; currentRightLegMainOption++;
        if(currentRightLegFrontOption >= rightLegFrontOptions.Count && currentRightLegSideOption >= rightLegSideOptions.Count 
               && currentRightLegMainOption >= rightLegMainOptions.Count )
        {
            currentRightLegFrontOption = 0; currentRightLegSideOption = 0; currentRightLegMainOption = 0;
            
        }
        
        rightLegFront.material = rightLegFrontOptions[currentRightLegFrontOption];
        rightLegSide.material = rightLegSideOptions[currentRightLegSideOption];
        rightLegMain.material = rightLegMainOptions[currentRightLegMainOption];

        //Left Leg "Next" set up
        currentLeftLegFrontOption++; currentLeftLegSideOption++; currentLeftLegMainOption++;
        if(currentLeftLegFrontOption >= leftLegFrontOptions.Count && currentLeftLegSideOption >= leftLegSideOptions.Count 
               && currentLeftLegMainOption >= leftLegMainOptions.Count )
        {
            currentLeftLegFrontOption = 0; currentLeftLegSideOption = 0; currentLeftLegMainOption = 0;
            
        }
        
        leftLegFront.material = leftLegFrontOptions[currentLeftLegFrontOption];
        leftLegSide.material = leftLegSideOptions[currentLeftLegSideOption];
        leftLegMain.material = leftLegMainOptions[currentLeftLegMainOption];
        
        

    }

    public void PreviousOption()
    {
        //Right Leg "Previous" set up
        currentRightLegFrontOption--; currentRightLegSideOption--; currentRightLegMainOption--;

        if (currentRightLegFrontOption < 0 && currentRightLegSideOption < 0 && currentRightLegMainOption < 0)
        {
            currentRightLegFrontOption = rightLegFrontOptions.Count - 1;
            currentRightLegSideOption = rightLegSideOptions.Count - 1;
            currentRightLegMainOption = rightLegMainOptions.Count - 1;
        }
        rightLegFront.material = rightLegFrontOptions[currentRightLegFrontOption];
        rightLegSide.material = rightLegSideOptions[currentRightLegSideOption];
        rightLegMain.material = rightLegMainOptions[currentRightLegMainOption];

        //Left Leg "Previous" set up
        currentLeftLegFrontOption--; currentLeftLegSideOption--; currentLeftLegMainOption--;

        if (currentLeftLegFrontOption < 0 && currentLeftLegSideOption < 0 && currentLeftLegMainOption < 0)
        {
            currentLeftLegFrontOption = leftLegFrontOptions.Count - 1;
            currentLeftLegSideOption = leftLegSideOptions.Count - 1;
            currentLeftLegMainOption = leftLegMainOptions.Count - 1;
        }
        leftLegFront.material = leftLegFrontOptions[currentLeftLegFrontOption];
        leftLegSide.material = leftLegSideOptions[currentLeftLegSideOption];
        leftLegMain.material = leftLegMainOptions[currentLeftLegMainOption];

    }

    public void Randomize()
    {
      
        int newIndexOption = Random.Range(0, rightLegFrontOptions.Count - 1);

        //Right leg
        rightLegFront.material = rightLegFrontOptions[newIndexOption];
        rightLegSide.material = rightLegSideOptions[newIndexOption];
        rightLegMain.material = rightLegMainOptions[newIndexOption];

        //Left leg
        leftLegFront.material = leftLegFrontOptions[newIndexOption];
        leftLegSide.material = leftLegSideOptions[newIndexOption];
        leftLegMain.material = leftLegMainOptions[newIndexOption];

        //Update index
        currentRightLegFrontOption = newIndexOption;
        currentRightLegSideOption = newIndexOption;
        currentRightLegMainOption = newIndexOption;

        currentLeftLegFrontOption = newIndexOption;
        currentLeftLegSideOption = newIndexOption;
        currentLeftLegMainOption = newIndexOption;

    }

    
    public Material GetCurrentSelection(LegsOptions legOption)
    {
        switch (legOption)
        {
            case LegsOptions.RightLegFront:
                return rightLegFrontOptions[currentRightLegFrontOption];
            case LegsOptions.RightLegSide:
                return rightLegSideOptions[currentRightLegSideOption];
            case LegsOptions.RightLegMain:
                return rightLegMainOptions[currentRightLegMainOption];
            case LegsOptions.LeftLegFront:
                return leftLegSideOptions[currentLeftLegSideOption];
            case LegsOptions.LeftLegSide:
                return leftLegSideOptions[currentLeftLegSideOption];
            case LegsOptions.LeftLegMain:
                return leftLegMainOptions[currentLeftLegMainOption];
            default:
                return leftLegMainOptions[currentLeftLegMainOption];
        }
    }
}
