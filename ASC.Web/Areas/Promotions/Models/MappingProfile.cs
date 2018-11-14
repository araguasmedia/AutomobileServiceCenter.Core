using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASC.Models.Models;
using AutoMapper;

namespace ASC.Web.Areas.Promotions.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Promotion, PromotionsViewModel>();
            CreateMap<PromotionViewModel, Promotion>();
        }
    }
}
