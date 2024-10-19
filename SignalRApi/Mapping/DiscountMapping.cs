﻿using AutoMapper;
using SignalR.DtoLayer.DiscountDto;
using SignalRApi.EnitityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class DiscountMapping:Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount,ResultDiscountDto>().ReverseMap();
            CreateMap<Discount,CreateDiscountDto>().ReverseMap();
            CreateMap<Discount,GetDiscountDto>().ReverseMap();
            CreateMap<Discount,UpdateDiscountDto>().ReverseMap();
        }
    }
}
