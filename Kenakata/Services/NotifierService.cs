using Kenakata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kenakata.Services
{
    public class NotifierService
    {
        public NotifierService()
        {

        }

        int rnd;
        int comparecount;
        decimal sub;
        decimal subwithship;
        public int Counter
        {
            get => rnd;
            set
            {
                if (rnd != value)
                {
                    rnd = value;

                    if (Notify != null)
                    {
                        Notify?.Invoke();
                    }
                }
            }
        }

        public int CompareCounter
        {
            get => comparecount;
            set
            {
                if (comparecount != value)
                {
                    comparecount = value;

                    if (Notify != null)
                    {
                        Notify?.Invoke();
                    }
                }
            }
        }
        public decimal Subtotal
        {
            get => sub;
            set
            {
                if (sub != value)
                {
                    sub = value;

                    if (Notify != null)
                    {
                        Notify?.Invoke();
                    }
                }
            }
        }

        public decimal SubWithShip
        {
            get => subwithship;
            set
            {
                if (subwithship != value)
                {
                    subwithship = value;

                    if (Notify != null)
                    {
                        Notify?.Invoke();
                    }
                }
            }
        }
        public event Func<Task> Notify;
    }
}
