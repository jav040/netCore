CREATE PROCEDURE [dbo].[spOrders_GetById]
	@Id int 
AS
begin

	set nocount on;

	select *
	from dbo.[Order]
	where Id = @Id;


end