USE [TestDB]
GO
/****** Object:  StoredProcedure [dbo].[GetLocationdetails]    Script Date: 2/18/2024 8:34:29 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[GetLocationdetails]
as
begin
select * from LocationDdetails where CAST(starttime as time) >= '12:00:00' or CAST(starttime as time) < '13:00:00' -- EXTRACT(HOUR, starttime)='11' and EXTRACT(HOUR, endtime)=

end 

insert LocationDdetails values(getdate(),getdate(),'sss')
GO
