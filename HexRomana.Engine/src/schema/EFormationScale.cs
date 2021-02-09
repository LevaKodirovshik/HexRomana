namespace HexRomana.Engine
{
    public enum EFormationScale : ushort
    {
        Century = 80,
        // 6 centuriae or a total of 480 fighting men
        Cohort = Century * 6,
        // 10 cohorts, 4,800 men + 300 cavalry
        Legion = Cohort * 10 + EquiteCohort,
        // 30 cavalry 
        Turma = 30,
        // 10 Turma 300 cavalry 
        EquiteCohort = Turma * 10,
    }
}
