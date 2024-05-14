using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;




namespace OOP_laba1_Time
{
   
    
    interface ITime
    { 
        public string TimeNow();
    }

    class UsTime : ITime
    {
        CultureInfo cultureInfo = new CultureInfo("us-US");

        public string TimeNow()
        {
            return DateTime.Now.ToString(cultureInfo);
        }
    }

    class EsTime : ITime
    {
        CultureInfo cultureInfo = new CultureInfo("es-ES");


        public string TimeNow()
        {
            return DateTime.Now.ToString(cultureInfo);
        }
    }



    abstract class Decorator : ITime
    {

        protected ITime _time;    

        public Decorator(ITime time)
        {
            _time = time;
        }

        public virtual string TimeNow()
        {
            return _time.TimeNow();
        }
    }

    class SmileDecorator : Decorator
    {
        public SmileDecorator(ITime time) : base(time) { }

        public override string TimeNow()
        {
            return $"{_time.TimeNow()} :) (^.^) (~￣.￣)~";
        }
    }

    class EllipsisDecorator : Decorator
    {
        public EllipsisDecorator(ITime time) : base(time) { }

        public override string TimeNow()
        {
            return $"{_time.TimeNow()} ..........";
        }
    }
}
