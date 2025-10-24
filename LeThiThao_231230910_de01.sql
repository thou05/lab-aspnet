USE [ltt_231230910_de01]
GO

/****** Object:  Table [dbo].[LttComputer]    Script Date: 10/24/2025 8:07:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LttComputer](
	[lttComId] [int] IDENTITY(1,1) NOT NULL,
	[lttComName] [nvarchar](max) NOT NULL,
	[lttComPrice] [float] NOT NULL,
	[lttComImage] [nvarchar](max) NOT NULL,
	[lttComStatus] [bit] NOT NULL,
 CONSTRAINT [PK_LttComputer] PRIMARY KEY CLUSTERED 
(
	[lttComId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


INSERT INTO [dbo].[LttComputer]
           ([lttComName]
           ,[lttComPrice]
           ,[lttComImage]
           ,[lttComStatus])
     VALUES
           ('dell', 1500, 'pic1.png', 0), 
		   ('lenovo', 3000, 'pic2.jpg', 1),
		   ('macbook', 3500, 'pic3.jpg', 0)
GO


