using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using XCare.DMS.DataProc.Common;
using XCare.DMS.Entity;

namespace XCare.DMS.DataProc.DAL
{
    public class JcbgDataAccess
    {
        public void Create(IEnumerable<YdhlJcbg> objs)
        {
            using (var conn = DbHelper.GetDbConnection())
            {
                conn.Execute(@"
INSERT  INTO dbo.YDHL_JCBG ( ID, BRBH, SQDH, JKLB, JCXM, YJ_YINGXIANGSJ, YJ_YINGXIANGZD )
VALUES  ( @ID, -- ID - uniqueidentifier
          @BRBH, -- BRBH - bigint
          @SQDH, -- SQDH - bigint
          @JKLB, -- JKLB - nvarchar(9)
          @JCXM, -- JCXM - nvarchar(60)
          @YJ_YINGXIANGSJ, -- YJ_YINGXIANGSJ - nvarchar(255)
          @YJ_YINGXIANGZD  -- YJ_YINGXIANGZD - nvarchar(255)
          )",
                    objs.Select(e =>
                        new
                        {
                            ID = e.Id,
                            BRBH = e.Brbh,
                            SQDH = e.Sqdh,
                            JKLB = e.Jklb,
                            JCXM = e.Jcxm,
                            YJ_YINGXIANGSJ = e.YjYingxiangsj,
                            YJ_YINGXIANGZD = e.YjYingxiangzd
                        }));
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}