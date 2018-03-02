using System;
using Dapper;
using XCare.DMS.Entity;

namespace XCare.DMS.DataProc.DAL
{
    public class JbxxDataAccess
    {
        public void Create(YdhlJbxx obj)
        {
            using (var conn = DbHelper.GetDbConnection())
            {
                conn.Execute(@"
INSERT  INTO dbo.YDHL_JBXX ( ZYH, ZYHM, BRXM, XB, NL, BRQK, BRXX, RYQK, BRZT, BRXZ, RYZD, ZYZT, SFZH, XX, YSQK, CYRQ,
                             YWGM )
VALUES  ( @ZYH, -- ZYH - bigint
          @ZYHM, -- ZYHM - nvarchar(8)
          @BRXM, -- BRXM - nvarchar(20)
          @XB, -- XB - numeric
          @NL, -- NL - int
          @BRQK, -- BRQK - int
          @BRXX, -- BRXX - int
          @RYQK, -- RYQK - int
          @BRZT, -- BRZT - nvarchar(40)
          @BRXZ, -- BRXZ - nvarchar(30)
          @RYZD, -- RYZD - nvarchar(150)
          @ZYZT, -- ZYZT - smallint
          @SFZH, -- SFZH - nvarchar(20)
          @XX, -- XX - nvarchar(4)
          @YSQK, -- YSQK - nvarchar(40)
          @CYRQ, -- CYRQ - datetime
          @YWGM  -- YWGM - tinyint
          )",
                    new
                    {
                        ZYH = obj.Zyh,
                        ZYHM = obj.Zyhm,
                        BRXM = obj.Brxm,
                        XB = obj.Xb,
                        NL = obj.Nl,
                        BRQK = obj.Brqk,
                        BRXX = obj.Brxx,
                        RYQK = obj.Ryqk,
                        BRZT = obj.Brzt,
                        BRXZ = obj.Brxz,
                        RYZD = obj.Ryzd,
                        ZYZT = obj.Zyzt,
                        SFZH = obj.Sfzh,
                        XX = obj.Xx,
                        YSQK = obj.Ysqk,
                        RYRQ = obj.Ryrq,
                        CYRQ = obj.Cyrq,
                        YWGM = obj.Ywgm
                    });
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}