using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

public class Score
{
    protected int points;
    
    public Score(int points)
    {
        this.points = points;
    }
}

public class EvaluateScore : Score
{
    public EvaluateScore(int points) : base(points) { }

    public int Points()
    {
        return points;
    }
    public string range()
    {
        if(points <= 350)
        {
            return "Nivel: Novato";
        } else if(points >= 351 && points <= 800)
        {
            return "Nivel: Intermedio";
        }
        else
        {
            return "Nivel: Experto";
        }
    }
}