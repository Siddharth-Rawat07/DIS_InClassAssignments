using System;

class Professor : Person
{
    public string ProfessorID;

    public Professor() : base()
    {
        ProfessorID = "PID1234";
    }

    public Professor(string sNumber, string sal, string ftName, string ltName) : base(sal, ftName, ltName)
    {
        ProfessorID = sNumber;
    }

    new public string getName()
    {
        return ProfessorID + " " + base.getName();
    }
}