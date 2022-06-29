using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Turbo.az
{
    class CustomIDGenerator //GetcurrentTimeID etdikde error verir duzelis ucun bele yazdi..
}

namespace Turbo.az
{
    public static Int64 GetCurrentTimeId()
    {
        string year = DateTime.Now.Year.ToString();
        string month = DateTime.Now.Month.ToString();
        string day = DateTime.Now.Day.ToString();
        string hour = DateTime.Now.Hour.ToString();
        string minute = DateTime.Now.Minute.ToString();
        string second = DateTime.Now.Second.ToString();
        string milliSecond = DateTime.Now.Millisecond.ToString();
        if (int.Parse(month) < 10)
        {
            month = "0" + month;
        }
        if (int.Parse(day) < 10)
        {
            day = "0" + day;
        }
        if (int.Parse(hour) < 10)
        {
            hour = "0" + hour;
        }
        if (int.Parse(minute) < 10)
        {
            minute = "0" + minute;
        }
        if (int.Parse(second) < 10)
        {
            second = "0" + second;
        }
        if (int.Parse(milliSecond) < 10)
        {
            milliSecond = "0" + milliSecond;
        }
        else if (int.Parse(milliSecond) < 100)
        {
            milliSecond = "0" + milliSecond;

        }
        string number = year + month + day + hour + minute + second + milliSecond;
        Thread.Sleep(1000);
        long id = Int64.Parse(number);
        return id;

    }
}
