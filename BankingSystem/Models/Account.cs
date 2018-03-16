using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BankingSystem.Models
{
    public class Account
    {
        [Key]
        public int AccountID { get; set; }
        public double Balance { get; set; }
    }
}