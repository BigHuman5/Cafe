using Cafe.Infrastructure.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Infrastructure.services
{
    public class Result
    {
        public bool Success { get; set; }
        public int id { get; set; }

        public bool Faulure => !Success;

        public string Meggase { get; set; }

        public static implicit operator Result(bool succeeded)
        {
            return new Result() { Success = succeeded };
        }

        public static implicit operator Result(string message)
        {
            return new Result
            {
                Success = false,
                Meggase = message
            };
        }
    }
}