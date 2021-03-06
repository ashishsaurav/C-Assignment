USE [PracticeAssignment]
GO
/****** Object:  StoredProcedure [dbo].[InsertT_OrderAndSub]    Script Date: 9/14/2020 4:11:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertT_OrderAndSub]
@Symbol varchar(50),
@Side varchar(50),
@Account varchar(50),
@Quantity int,
@AvgPrice decimal(18, 0),
@RemainingQuantity int,
@OrderStatus varchar(50)
as 
begin
	insert into T_OrderAndSub(Symbol,Side,Account,Quantity,AvgPrice,RemainingQuantity,OrderStatus) values(@Symbol,@Side,@Account,@Quantity,@AvgPrice,@RemainingQuantity,@OrderStatus)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertT_TradedOrders]    Script Date: 9/14/2020 4:11:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertT_TradedOrders]
@Symbol varchar(50),
@Side varchar(50),
@Account varchar(50),
@Quantity int,
@AvgPrice decimal(18, 0),
@RemainingQuantity int,
@OrderStatus varchar(50),
@ParentCLOrderId int
as 
begin
	insert into T_TradedOrders(Symbol,Side,Account,Quantity,AvgPrice,RemainingQuantity,OrderStatus,ParentCLOrderId) values(@Symbol,@Side,@Account,@Quantity,@AvgPrice,@RemainingQuantity,@OrderStatus,@ParentCLOrderId)
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateT_OrderAndSub]    Script Date: 9/14/2020 4:11:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateT_OrderAndSub]
@Account varchar(50),
@Quantity int,
@AvgPrice decimal(18, 0),
@RemainingQuantity int,
@OrderStatus varchar(50),
@CLOrderId int
as 
begin
     update T_OrderAndSub set Account =	@Account, Quantity = @Quantity, AvgPrice = @AvgPrice, RemainingQuantity = @RemainingQuantity, OrderStatus = @OrderStatus where CLOrderId = @CLOrderId
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateT_OrderAndSubEdit]    Script Date: 9/14/2020 4:11:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateT_OrderAndSubEdit]
@Account varchar(50),
@Quantity int,
@AvgPrice decimal(18, 0),
@RemainingQuantity int,
@CLOrderId int
as 
begin
     update T_OrderAndSub set Account =	@Account, Quantity = @Quantity, AvgPrice = @AvgPrice, RemainingQuantity = @RemainingQuantity where CLOrderId = @CLOrderId
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateT_TradedOrders]    Script Date: 9/14/2020 4:11:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateT_TradedOrders]
@Account varchar(50),
@CLOrderId int
as 
begin
     update T_TradedOrders set Account =	@Account where CLOrderId = @CLOrderId
end
GO
