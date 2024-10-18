﻿using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfSocialmediaDal : GenericRepository<SocialMedia>, ISocialMediaDal
    {
        public EfSocialmediaDal(SignalRContext context) : base(context)
        {
        }
    }
}