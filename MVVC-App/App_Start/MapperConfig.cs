using AutoMapper;
using EntityFramework_ClassLibrary.Domain.Model;
using MVVC_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVVC_App.App_Start
{
    public class MapperConfig
    {
        public static void Setup()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<AddPersonViewModel, PersonEntity>();

                cfg.CreateMap<PersonEntity, SeePersonViewModel>()
                .ForMember(desti => desti.PersonState, opt => opt.MapFrom(src => src.State));

            });
        }
    }
}