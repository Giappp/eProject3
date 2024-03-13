﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CompanySubscription
    {
       public int CompanyId { get; set; }
       public int SubscriptionId { get; set; }
       public Company Company { get; set; }
       public Subscription Subscription { get; set; }
    }
}