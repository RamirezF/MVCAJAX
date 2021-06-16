using API.Models;
using AutoMapper;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Repository
{
    public class EntityMapper<Tsource, TDestination> where Tsource : class where TDestination : class
    {
        public EntityMapper()
        {
            Mapper.CreateMap<Models.StudentModel, Student>();
            Mapper.CreateMap<Student, Models.StudentModel>();
        }

        public TDestination Translate(Tsource obj)
        {
            return Mapper.Map < TDestination>(obj);
        }

        internal Student Translate(StudentModel student)
        {
            throw new NotImplementedException();
        }
    }
}