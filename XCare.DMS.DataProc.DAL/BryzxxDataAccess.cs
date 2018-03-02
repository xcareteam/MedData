using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using XCare.DMS.DataProc.Common;
using XCare.DMS.Entity;

namespace XCare.DMS.DataProc.DAL
{
    public class BryzxxDataAccess
    {
        public void Create(IEnumerable<YdhlBryzxx> objs)
        {
            using (var conn = DbHelper.GetDbConnection())
            {
                conn.Execute(@"
IF NOT EXISTS ( SELECT  0
                FROM    dbo.YDHL_BRYZXX
                WHERE   ROWID = @ROWID ) 
   BEGIN
         INSERT INTO dbo.YDHL_BRYZXX ( ROWID, ZYH, SQDH, YZZH, LSYZ, YZMC, YZLX, YCJL, JLDW, SL, KSSJ, TZSJ, GYTJ, SYPC,
                                       MRCS, MZCS, DJ, ZXSJ, FYSX, YJZX, XMLX, CODE, PCCODE, SYBZ, YSTJ, FYSJ, YYSJ )
         VALUES ( @ROWID, -- ROWID - bigint
                  @ZYH, -- ZYH - bigint
                  @SQDH, -- SQDH - bigint
                  @YZZH, -- YZZH - bigint
                  @LSYZ, -- LSYZ - tinyint
                  @YZMC, -- YZMC - nvarchar(50)
                  @YZLX, -- YZLX - tinyint
                  @YCJL, -- YCJL - decimal
                  @JLDW, -- JLDW - nvarchar(8)
                  @SL, -- SL - decimal
                  @KSSJ, -- KSSJ - datetime
                  @TZSJ, -- TZSJ - datetime
                  @GYTJ, -- GYTJ - nvarchar(20)
                  @SYPC, -- SYPC - nvarchar(20)
                  @MRCS, -- MRCS - smallint
                  @MZCS, -- MZCS - smallint
                  @DJ, -- DJ - decimal
                  @ZXSJ, -- ZXSJ - datetime
                  @FYSX, -- FYSX - nvarchar(8)
                  @YJZX, -- YJZX - tinyint
                  @XMLX, -- XMLX - smallint
                  @CODE, -- CODE - int
                  @PCCODE, -- PCCODE - nvarchar(6)
                  @SYBZ, -- SYBZ - tinyint
                  @YSTJ, -- YSTJ - tinyint
                  @FYSJ, -- FYSJ - nvarchar(50)
                  @YYSJ  -- YYSJ - nvarchar(100)
                  )
   END",
                    objs.Select(
                        e => new
                        {
                            ROWID = e.Rowid,
                            ZYH = e.Zyh,
                            SQDH = e.Sqdh,
                            YZZH = e.Yzzh,
                            LSYZ = e.Lsyz,
                            YZMC = e.Yzmc,
                            YZLX = e.Yzlx,
                            YCJL = e.Ycjl,
                            JLDW = e.Jldw,
                            SL = e.Sl,
                            KSSJ = e.Kssj,
                            TZSJ = e.Tzsj,
                            GYTJ = e.Gytj,
                            SYPC = e.Sypc,
                            MRCS = e.Mrcs,
                            MZCS = e.Mzcs,
                            DJ = e.Dj,
                            ZXSJ = e.Zxsj,
                            FYSX = e.Fysx,
                            YJZX = e.Yjzx,
                            XMLX = e.Xmlx,
                            CODE = e.Code,
                            PCCODE = e.Pccode,
                            SYBZ = e.Sybz,
                            YSTJ = e.Ystj,
                            FYSJ = e.Fysj,
                            YYSJ = e.Yysj
                        }));
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}