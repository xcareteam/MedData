﻿using System.Web.Http;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     检验报告
    /// </summary>
    public class JybgController : ApiController
    {
        /// <summary>
        ///     新增检验报告
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        ///     修改检验报告
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        ///     删除检验报告
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}