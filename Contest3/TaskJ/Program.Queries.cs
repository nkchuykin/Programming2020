using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;

partial class Program
{
    private static bool ValidateQuery(string query, out string[] queryParameters)
    {
        CultureInfo cul = new CultureInfo("us-US");
        Thread.CurrentThread.CurrentCulture = cul;
        Thread.CurrentThread.CurrentUICulture = cul;
        queryParameters = query.ToLower().Split();
        if (queryParameters.Length != 3)
        {
            return false;
        }
        switch (queryParameters[0])
        {
            case "first_name":
                {
                    if (queryParameters[1] == "==" || queryParameters[1] == "<>")
                    {
                        return true;
                    }
                    return false;
                }
            case "last_name":
                {
                    if (queryParameters[1] == "==" || queryParameters[1] == "<>")
                    {
                        return true;
                    }
                    return false;
                }
            case "group":
                {
                    if (queryParameters[1] == "==" || queryParameters[1] == "<>")
                    {
                        return true;
                    }
                    return false;
                }
            case "rating":
                {
                    if (queryParameters[1] == ">=" || queryParameters[1] == "<=")
                    {
                        if (int.TryParse(queryParameters[2], out int r))
                        {
                            return true;
                        }
                    }
                    return false;
                }
            case "gpa":
                {
                    if (queryParameters[1] == ">=" || queryParameters[1] == "<=")
                    {
                        if (double.TryParse(queryParameters[2], out double r))
                        {
                            return true;
                        }
                    }
                    return false;
                }
            default:
                {
                    return false;
                }
        }

    }

    private static List<string> ProcessQuery(string[] queryParameters, string pathToDatabase)
    {
        CultureInfo cul = new CultureInfo("us-US");
        Thread.CurrentThread.CurrentCulture = cul;
        Thread.CurrentThread.CurrentUICulture = cul;
        string[] lines = File.ReadAllLines(pathToDatabase);
        List<string> output = new List<string>();
        foreach (string line in lines)
        {
            if (line == "first_name;last_name;group;rating;gpa")
            {
                continue;
            }
            string[] parsedLine = line.ToLower().Split(new char[] { ';' });
            switch (queryParameters[0])
            {
                case "first_name":
                    {
                        if (queryParameters[1] == "==")
                        {
                            if (parsedLine[0] == queryParameters[2])
                            {
                                output.Add(line);
                            }
                        }
                        else
                        {
                            if (parsedLine[0] != queryParameters[2])
                            {
                                output.Add(line);
                            }
                        }
                        break;
                    }
                case "last_name":
                    {
                        if (queryParameters[1] == "==")
                        {
                            if (parsedLine[1] == queryParameters[2])
                            {
                                output.Add(line);
                            }
                        }
                        else
                        {
                            if (parsedLine[1] != queryParameters[2])
                            {
                                output.Add(line);
                            }
                        }
                        break;
                    }
                case "group":
                    {
                        if (queryParameters[1] == "==")
                        {
                            if (parsedLine[2] == queryParameters[2])
                            {
                                output.Add(line);
                            }
                        }
                        else
                        {
                            if (parsedLine[2] != queryParameters[2])
                            {
                                output.Add(line);
                            }
                        }
                        break;
                    }
                case "rating":
                    {
                        int needRat = int.Parse(queryParameters[2]);
                        int curRat = int.Parse(parsedLine[3]);
                        if (queryParameters[1] == ">=")
                        {
                            if (curRat >= needRat)
                            {
                                output.Add(line);
                            }
                        }
                        else
                        {
                            if (curRat <= needRat)
                            {
                                output.Add(line);
                            }
                        }
                        break;
                    }
                case "gpa":
                    {
                        double needGpa = double.Parse(queryParameters[2]);
                        double curGpa = double.Parse(parsedLine[4]);
                        if (queryParameters[1] == ">=")
                        {
                            if (!(curGpa < needGpa))
                            {
                                output.Add(line);
                            }
                        }
                        else
                        {
                            if (!(curGpa > needGpa))
                            {
                                output.Add(line);
                            }
                        }
                        break;
                    }
            }

        }
        return output;
    }
}