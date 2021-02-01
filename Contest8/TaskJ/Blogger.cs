using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Blogger
{
    DayOfWeek postDay;

    public event Action<DateTime> Post;

    public Blogger(DayOfWeek postDay)
    {
        throw new NotImplementedException();
    }

    public void MakePost(DateTime date)
    {
        throw new NotImplementedException();
    }
}

