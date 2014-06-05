using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using AIM.Web.Admin.Models.EntityModels;
using WebApiRestService;

namespace AIM.Web.Admin.Client
{
    public class ApplicationServiceClient : WebApiClient<Application>
    {
        private static WebApiClientOptions options = new WebApiClientOptions()
        {
            BaseAddress = "http://aimadminstrativeservice.cloudapp.net/",
            ContentType = ContentType.Json,
            Timeout = 30000,
            Controller = "api/Application"
        };

        /// <summary>
        /// Creates an instance of ApplicationClient using default options
        /// </summary>
        public ApplicationServiceClient()
            : this(options)
        {
        }

        /// <summary>
        /// Creates an instance of ApplicationClient using explicit options
        /// </summary>
        private ApplicationServiceClient(WebApiClientOptions options)
            : base(options)
        {
        }


        public async Task<IEnumerable<Application>> GetApplications()
        {
            return await GetManyAsync();
        }

        public async Task<Application> GetApplicationById(int? id)
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

        public async Task<Application> CreateApplication(Application application)
        {
            return await CreateAsync(application);
        }

        public async Task<Application> EditApplication(Application application)
        {
            return await EditAsync(application);
        }

        public async Task DeleteApplication(int id)
        {
            await DeleteAsync(id);
        }
    }
}