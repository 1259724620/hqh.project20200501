using AutoMapper;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace hqh.project.Common
{
    public class MapperHelper
    {

        public MapperHelper(IApplicationBuilder app)
        {
            ServiceLocator.Instance = app.ApplicationServices;
        }

        /// <summary>
        /// Mapper.Map转换
        /// </summary>
        /// <typeparam name="DtoEntity"></typeparam>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static TDestination ResultData<TDestination>(object source)
        {
            try
            {
                var mapper =(Mapper)ServiceLocator.Instance.GetService(typeof(Mapper));
                var dto = mapper.Map<TDestination>(source);
                return dto;
            }
            catch (Exception ex)
            {
                return default(TDestination);
            }
        }

        /// <summary>
        /// Mapper.Map实体转换
        /// </summary>
        /// <typeparam name="DtoEntity"></typeparam>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity">需要转换的实体</param>
        /// <param name="entity">接收的实体</param>
        /// <returns></returns>
        public static TDestination ResultData<TSource, TDestination>(TSource source, TDestination destination)
        {
            try
            {
                var mapper = (Mapper)ServiceLocator.Instance.GetService(typeof(Mapper));
                var dto = mapper.Map(source, destination);
                return dto;
            }
            catch (Exception ex)
            {
                return default(TDestination);
            }
        }
    }
}
