﻿using System;

class Time
{
    private int hour, min, sec;
    public Time(int h, int m, int s)
    {
        hour = h; min = m; sec = s;
    }
    public int Hour
    {
        get { return hour; }
        set { if (value < 60) min = value; }
    }
    public int Min
    { 
        get { return min; }
        set { if (value < 60) min = value; }
    }
    public int Sec
    { get { return sec; }
        set { if (value < 60) sec = value; }
    }
    public void OutTime()
    {
        Console.WriteLine("현재 시간은 {0}시 {1}분 {2}초이다.", Hour, Min, Sec);
    }
}

class CSTest
{
    static void Main()
    {
        Time Now;
        Now = new Time(12, 30, 45);
        Now.OutTime();
        Now.Hour = 55;
        Now.OutTime();
    }
}