using System;
using System.Collections.Generic;

public class Planet<T>
{
    public int Id { get; }
    public string StarSystem { get; set; }
    public static List<Planet<T>> Planets { get; }
    public T Name { get; }
    
    private Planet(int id, T name, string starSystem)
    {
        throw new NotImplementedException();
    }

    public static void CreatePlanet(int id, T name, string starSystem)
    {
        throw new NotImplementedException();
    }
}

