﻿static double calculateAverage(int []arr)
{

    double avg1= 0;
        for (int i = 0; i < arr.Length; i++) 
        {
            avg1+=arr[i];
            
        }
        avg1 = avg1/arr.Length;
        return avg1;

    double average = 0;
        for (int i = 0; i < arr.Length; i++) 
        {
            average+=arr[i];
            
        }
        average = average/arr.Length;
        return average;

    }

//example use
int[] tmp = [1,2,3,4];
Console.WriteLine(calculateAverage(tmp));