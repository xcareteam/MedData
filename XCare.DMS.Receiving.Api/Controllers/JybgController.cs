using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Nelibur.ObjectMapper;
using XCare.DMS.Entity;
using XCare.DMS.Receiving.DTO;

namespace XCare.DMS.Receiving.Api.Controllers
{
    /// <summary>
    ///     检验报告
    /// </summary>
    public class JybgController : ApiController
    {
        private readonly JybgService _jybgService = new JybgService();

        static JybgController()
        {
            TinyMapper.Bind<JybgxqCreateionDTO, YdhlJybgxq>();
            TinyMapper.Bind<JybgCreationDTO, YdhlJybg>();
        }

        /// <summary>
        ///     新增检验报告
        /// </summary>
        /// <param name="dtos"></param>
        public void Post(IEnumerable<JybgCreationDTO> dtos)
        {
            var objs = dtos.Select(e =>
            {
                var obj = TinyMapper.Map<YdhlJybg>(e);
                obj.Id = Guid.NewGuid();
                obj.Items = e.Items.Select(item =>
                {
                    var itemObj = TinyMapper.Map<YdhlJybgxq>(item);
                    itemObj.Id = Guid.NewGuid();
                    itemObj.JybgId = obj.Id;
                    return itemObj;
                }).ToList();
                return obj;
            });
            _jybgService.Create(objs);
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