using System;
using System.Collections.Generic;
using System.Text;

class Soldier
{   
    public string Attack()
    {
        throw new NotImplementedException();
    }
}

class CoolerSoldier : Soldier
{
    public string Attack()
    {
        throw new NotImplementedException();
    }
}

class ManInBlack : Soldier
{
    public string Attack()
    {
        throw new NotImplementedException();
    }
}

class ManInBlackBoss : ManInBlack
{
    public string Attack()
    {
        throw new NotImplementedException();
    }
}