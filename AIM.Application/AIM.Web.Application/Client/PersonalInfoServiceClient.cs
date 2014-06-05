﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using AIM.Web.ClientApp.Models.EntityModels;
using WebApiRestService;

namespace AIM.Web.ClientApp.Client
{
    public class PersonalInfoServiceClient : WebApiClient<PersonalInfo>
    {
private static WebApiClientOptions options = new WebApiClientOptions()
        {
            BaseAddress = "http://aimadminstrativeservice.cloudapp.net/",
            ContentType = ContentType.Json,
            Timeout = 30000,
            Controller = "api/PersonalInfo"
        };

        /// <summary>
        /// Creates an instance of PersonalInfoClient using default options
        /// </summary>
        public PersonalInfoServiceClient()
            : this(options)
        {
        }

        /// <summary>
        /// Creates an instance of PersonalInfoClient using explicit options
        /// </summary>
        private PersonalInfoServiceClient(WebApiClientOptions options)
            : base(options)
        {
        }


        public async Task<IEnumerable<PersonalInfo>> GetPersonalInfos()
        {
            return await GetManyAsync();
        }

        public async Task<PersonalInfo> GetPersonalInfoById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            try
            {
                return await GetOneAsync(id);
            }
            catch (WebApiClientException e)
            {
                if (e.StatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw e;
            }
        }

        public async Task<PersonalInfo> CreatePersonalInfo(PersonalInfo personalInfo)
        {
            return await CreateAsync(personalInfo);
        }

        public async Task<PersonalInfo> EditPersonalInfo(PersonalInfo personalInfo)
        {
            return await EditAsync(personalInfo);
        }

        public async Task DeletePersonalInfo(int id)
        {
            await DeleteAsync(id);
        }
    }
}