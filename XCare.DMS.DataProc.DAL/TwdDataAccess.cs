using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using XCare.DMS.Entity;

namespace XCare.DMS.DataProc.DAL
{
    public class TwdDataAccess
    {
        public void Create(IEnumerable<YdhlTwd> objs)
        {
            using (var conn = DbHelper.GetDbConnection())
            {
                conn.Execute(@"
IF NOT EXISTS ( SELECT  0
                FROM    dbo.YDHL_TWD
                WHERE   ZYH = @ZYH
                        AND CLRQ = @CLRQ
                        AND XH = @XH ) 
   BEGIN
         INSERT INTO dbo.YDHL_TWD ( ID, ZYH, CLRQ, DBCS, XBCS, PRL, PCL, XY, TZ, SHTS, XH, MB, TW, HX, TT, JWHTW, QBQMB,
                                    HXJHX, YWGM )
         VALUES ( @ID, -- ID - uniqueidentifier
                  @ZYH, -- ZYH - bigint
                  @CLRQ, -- CLRQ - date
                  @DBCS, -- DBCS - nvarchar(20)
                  @XBCS, -- XBCS - nvarchar(20)
                  @PRL, -- PRL - nvarchar(20)
                  @PCL, -- PCL - nvarchar(20)
                  @XY, -- XY - nvarchar(20)
                  @TZ, -- TZ - nvarchar(20)
                  @SHTS, -- SHTS - nvarchar(20)
                  @XH, -- XH - decimal
                  @MB, -- MB - decimal
                  @TW, -- TW - decimal
                  @HX, -- HX - decimal
                  @TT, -- TT - decimal
                  @JWHTW, -- JWHTW - decimal
                  @QBQMB, -- QBQMB - decimal
                  @HXJHX, -- HXJHX - decimal
                  @YWGM  -- YWGM - nvarchar(20)
                  )
   END", objs.Select(
                    e => new
                    {
                        ID = e.Id,
                        ZYH = e.Zyh,
                        CLRQ = e.Clrq,
                        DBCS = e.Dbcs,
                        XBCS = e.Xbcs,
                        PRL = e.Prl,
                        PCL = e.Pcl,
                        XY = e.Xy,
                        TZ = e.Tz,
                        SHTS = e.Shts,
                        XH = e.Xh,
                        MB = e.Mb,
                        TW = e.Tw,
                        HX = e.Hx,
                        TT = e.Tt,
                        JWHTW = e.Jwhtw,
                        QBQMB = e.Qbqmb,
                        HXJHX = e.Hxjhx,
                        YWGM = e.Ywgm
                    }));
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}