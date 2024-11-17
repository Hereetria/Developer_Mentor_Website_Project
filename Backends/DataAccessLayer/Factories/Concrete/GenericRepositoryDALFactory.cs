﻿using DataAccessLayer.Factories.Abstract;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Factories.Concrete
{
    public class GenericRepositoryDALFactory : IGenericRepositoryDALFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public GenericRepositoryDALFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IGenericRepositoryDAL<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey> CreateRepositoryDAL<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey>()
            where TEntity : class
            where TCreateDto : class
            where TUpdateDto : class
            where TResultDto : class
            where TResultById : class
        {
            return _serviceProvider.GetRequiredService<IGenericRepositoryDAL<TEntity, TCreateDto, TUpdateDto, TResultDto, TResultById, TKey>>();
        }
    }
}
