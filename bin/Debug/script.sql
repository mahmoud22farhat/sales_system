USE [master]
GO
/****** Object:  Database [therd]    Script Date: 9/23/2023 11:08:35 PM ******/
CREATE DATABASE [therd]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'therd', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\therd.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'therd_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\therd_log.ldf' , SIZE = 16576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [therd] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [therd].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [therd] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [therd] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [therd] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [therd] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [therd] SET ARITHABORT OFF 
GO
ALTER DATABASE [therd] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [therd] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [therd] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [therd] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [therd] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [therd] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [therd] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [therd] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [therd] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [therd] SET  DISABLE_BROKER 
GO
ALTER DATABASE [therd] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [therd] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [therd] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [therd] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [therd] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [therd] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [therd] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [therd] SET RECOVERY FULL 
GO
ALTER DATABASE [therd] SET  MULTI_USER 
GO
ALTER DATABASE [therd] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [therd] SET DB_CHAINING OFF 
GO
ALTER DATABASE [therd] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [therd] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [therd] SET DELAYED_DURABILITY = DISABLED 
GO
USE [therd]
GO
/****** Object:  Table [dbo].[bank]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bank](
	[Mony] [real] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bank_insert]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bank_insert](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[Mony] [real] NULL,
	[Date] [nvarchar](250) NULL,
	[Name] [nvarchar](250) NULL,
	[Type] [nvarchar](250) NULL,
	[Reason] [nvarchar](250) NULL,
 CONSTRAINT [PK_bank_insert] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bank_pull]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bank_pull](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[Mony] [real] NULL,
	[Date] [nvarchar](250) NULL,
	[Name] [nvarchar](250) NULL,
	[Type] [nvarchar](250) NULL,
	[Reason] [nvarchar](250) NULL,
 CONSTRAINT [PK_bank_pull] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[buy]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buy](
	[Order_ID] [int] NOT NULL,
	[Date] [nvarchar](50) NULL,
	[Sup_ID] [int] NULL,
 CONSTRAINT [PK_buy] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[buy_datails]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[buy_datails](
	[Order_ID] [int] NOT NULL,
	[Sup_ID] [int] NULL,
	[Pro_ID] [int] NULL,
	[Date] [nvarchar](50) NULL,
	[Qty] [real] NULL,
	[User_name] [nvarchar](50) NULL,
	[price] [real] NULL,
	[discound] [real] NULL,
	[total] [real] NULL,
	[TotalOrder] [real] NULL,
	[madfoo3] [real] NULL,
	[Baky] [real] NULL,
	[tax_value] [real] NULL,
	[price_tax] [real] NULL,
	[time] [nvarchar](50) NULL,
	[unit_name] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[customer_mony]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer_mony](
	[Order_ID] [int] NULL,
	[cust_Name] [nvarchar](50) NULL,
	[price] [int] NULL,
	[Order_Date] [nvarchar](50) NULL,
	[Reminder_Date] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[customer_report]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer_report](
	[Order_ID] [int] NULL,
	[price] [real] NULL,
	[Date] [nvarchar](250) NULL,
	[cust_Name] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[customers]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[cust_ID] [int] NOT NULL,
	[cust_Name] [nvarchar](250) NULL,
	[cust_address] [nvarchar](250) NULL,
	[cust_phone] [nvarchar](50) NULL,
	[notes] [nvarchar](250) NULL,
 CONSTRAINT [PK_customers] PRIMARY KEY CLUSTERED 
(
	[cust_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[deserved]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deserved](
	[Des_ID] [int] NOT NULL,
	[price] [real] NULL,
	[Date] [nvarchar](50) NULL,
	[notes] [nvarchar](50) NULL,
	[type_ID] [int] NULL,
 CONSTRAINT [PK_deserved] PRIMARY KEY CLUSTERED 
(
	[Des_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[deserved_type]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[deserved_type](
	[Des_ID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_deserved_type] PRIMARY KEY CLUSTERED 
(
	[Des_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee_]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee_](
	[emp_ID] [int] NOT NULL,
	[emp_Name] [nvarchar](250) NULL,
	[salary] [real] NULL,
	[date] [nvarchar](50) NULL,
	[national_ID] [nvarchar](250) NULL,
	[emp_phone] [nvarchar](250) NULL,
	[emp_address] [nvarchar](250) NULL,
 CONSTRAINT [PK_Employee_] PRIMARY KEY CLUSTERED 
(
	[emp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[employee_Borrowiitems]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_Borrowiitems](
	[Order_ID] [nchar](10) NULL,
	[item_ID] [nchar](10) NULL,
	[emp_ID] [nchar](10) NULL,
	[Date] [nchar](10) NULL,
	[Qty] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[employee_salary]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_salary](
	[Order_ID] [int] NULL,
	[emp_ID] [int] NULL,
	[total_salary] [real] NULL,
	[total_Borrow] [real] NULL,
	[safy_salary] [real] NULL,
	[order_date] [nvarchar](50) NULL,
	[Date_reminder] [nvarchar](50) NULL,
	[Notes] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[employee_salarymainus]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_salarymainus](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[emp_ID] [int] NULL,
	[emp_Name] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[price] [real] NULL,
	[pay] [nvarchar](50) NULL,
 CONSTRAINT [PK_employee_salarymainus] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empployee_BorrowMoney]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empployee_BorrowMoney](
	[Order_ID] [int] NULL,
	[Borrow_From] [nvarchar](250) NULL,
	[Borrow_To] [nvarchar](250) NULL,
	[order_Date] [nvarchar](250) NULL,
	[Date_Reminder] [nvarchar](50) NULL,
	[price] [real] NULL,
	[notes] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[orderprintdata]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orderprintdata](
	[Logo] [image] NULL,
	[name] [nvarchar](250) NULL,
	[address] [nvarchar](250) NULL,
	[description] [nvarchar](250) NULL,
	[phone1] [nvarchar](250) NULL,
	[phone2] [nvarchar](250) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product_outstore]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_outstore](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[Pro_ID] [int] NULL,
	[pro_name] [nvarchar](250) NULL,
	[store_name] [nvarchar](250) NULL,
	[Qty] [real] NULL,
	[unit] [nvarchar](250) NULL,
	[Date] [date] NULL,
	[Name] [nvarchar](250) NULL,
	[Reason] [nvarchar](250) NULL,
 CONSTRAINT [PK_product_outstore] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product_unit]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_unit](
	[Pro_ID] [int] NULL,
	[unit_ID] [int] NULL,
	[unit_Name] [nvarchar](250) NULL,
	[Qtyinmain] [real] NULL,
	[unit_saleprice] [real] NULL,
	[total_saleprice] [real] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[products]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[Pro_ID] [int] NOT NULL,
	[Pro_name] [nvarchar](50) NULL,
	[Qty] [real] NULL,
	[gomla_price] [real] NULL,
	[sale_price] [real] NULL,
	[Barcode] [nvarchar](250) NULL,
	[minQty] [real] NULL,
	[maxdiscound] [real] NULL,
	[tax_value] [real] NULL,
	[sale_pricetax] [real] NULL,
	[is_tax] [nvarchar](250) NULL,
	[group_ID] [int] NULL,
	[main_UnitName] [nvarchar](250) NULL,
	[main_UnitID] [int] NULL,
	[sale_unitname] [nvarchar](250) NULL,
	[sale_unitID] [int] NULL,
	[buy_UnitName] [nvarchar](250) NULL,
	[buy_UnitID] [int] NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[Pro_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[products_Qty]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products_Qty](
	[Pro_ID] [int] NULL,
	[store_ID] [int] NULL,
	[store_Name] [nvarchar](250) NULL,
	[Qty] [real] NULL,
	[Buy_price] [real] NULL,
	[sale_pricetax] [real] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[products_transfer]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products_transfer](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[Pro_ID] [int] NULL,
	[pro_name] [nvarchar](250) NULL,
	[store_from] [nvarchar](250) NULL,
	[store_to] [nvarchar](250) NULL,
	[Qty] [real] NULL,
	[unit] [nvarchar](250) NULL,
	[Buy_price] [real] NULL,
	[sale_price] [real] NULL,
	[Date] [date] NULL,
	[Name] [nvarchar](250) NULL,
	[Reason] [nvarchar](250) NULL,
 CONSTRAINT [PK_products_transfer_1] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[prouducts_group]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prouducts_group](
	[group_ID] [int] NOT NULL,
	[group_Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_prouducts_group] PRIMARY KEY CLUSTERED 
(
	[group_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[random_barcode]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[random_barcode](
	[Barcode] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[returns]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[returns](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[Ordear_Date] [nvarchar](50) NULL,
	[Order_Type] [nvarchar](250) NULL,
 CONSTRAINT [PK_returns] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[returns_details]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[returns_details](
	[Order_ID] [int] NULL,
	[Sup_Name] [nvarchar](250) NULL,
	[Cust_Name] [nvarchar](250) NULL,
	[Pro_Name] [nvarchar](250) NULL,
	[Date] [nvarchar](50) NULL,
	[Qty] [real] NULL,
	[price] [real] NULL,
	[total] [real] NULL,
	[User_name] [nvarchar](50) NULL,
	[total_Orer] [real] NULL,
	[Madfoo3] [real] NULL,
	[Baky] [real] NULL,
	[tax_value] [real] NULL,
	[price_tax] [real] NULL,
	[unit_name] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sales]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[Order_ID] [int] NOT NULL,
	[Date] [nvarchar](50) NULL,
	[Cust_name] [nvarchar](20) NULL,
 CONSTRAINT [PK_sales] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sales_details]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales_details](
	[Order_ID] [int] NULL,
	[Cus_name] [nvarchar](20) NULL,
	[Pro_ID] [int] NULL,
	[Date] [nvarchar](50) NULL,
	[Qty] [real] NULL,
	[User_name] [nvarchar](50) NULL,
	[price] [real] NULL,
	[discound] [real] NULL,
	[total] [real] NULL,
	[TotalOrder] [real] NULL,
	[madfoo3] [real] NULL,
	[Baky] [real] NULL,
	[unit] [nvarchar](250) NULL,
	[tax_value] [real] NULL,
	[price_tax] [real] NULL,
	[time] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sales_Rb7h]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales_Rb7h](
	[Order_ID] [int] NULL,
	[Cus_name] [nvarchar](20) NULL,
	[Pro_ID] [int] NULL,
	[Date] [nvarchar](50) NULL,
	[Qty] [real] NULL,
	[User_name] [nvarchar](50) NULL,
	[price] [real] NULL,
	[discound] [real] NULL,
	[total] [real] NULL,
	[TotalOrder] [real] NULL,
	[madfoo3] [real] NULL,
	[Baky] [real] NULL,
	[unit] [nvarchar](250) NULL,
	[tax_value] [real] NULL,
	[price_tax] [real] NULL,
	[time] [nvarchar](50) NULL,
	[Buy_price] [real] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sanad_kabd]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sanad_kabd](
	[Order_ID] [int] NULL,
	[name] [nvarchar](250) NULL,
	[price] [real] NULL,
	[Date] [nvarchar](250) NULL,
	[from_] [nvarchar](250) NULL,
	[Reason] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sanad_sarf]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sanad_sarf](
	[Order_ID] [int] NULL,
	[name] [nvarchar](250) NULL,
	[price] [real] NULL,
	[Date] [nvarchar](250) NULL,
	[to_] [nvarchar](250) NULL,
	[Reason] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stock]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[stock_ID] [int] NULL,
	[Mony] [real] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stock_bsnktransfer]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock_bsnktransfer](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[Mony] [real] NULL,
	[Date] [nvarchar](50) NULL,
	[from_] [nvarchar](250) NULL,
	[to_] [nvarchar](250) NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_stock_bsnktransfer] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stock_Data]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock_Data](
	[stock_ID] [int] NOT NULL,
	[stock_name] [nvarchar](250) NULL,
 CONSTRAINT [PK_stock_Data] PRIMARY KEY CLUSTERED 
(
	[stock_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stock_insert]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock_insert](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[stock_ID] [int] NULL,
	[Mony] [real] NULL,
	[Date] [nvarchar](250) NULL,
	[Name] [nvarchar](250) NULL,
	[Type] [nvarchar](250) NULL,
	[Reason] [nvarchar](250) NULL,
 CONSTRAINT [PK_stock_insert] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stock_pull]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock_pull](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[stock_ID] [int] NULL,
	[Mony] [real] NULL,
	[Date] [nvarchar](250) NULL,
	[Name] [nvarchar](250) NULL,
	[Type] [nvarchar](250) NULL,
	[Reason] [nvarchar](250) NULL,
 CONSTRAINT [PK_stock_pull] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[stock_transfer]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock_transfer](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[Mony] [real] NULL,
	[Date] [nvarchar](50) NULL,
	[from_] [int] NULL,
	[to_] [int] NULL,
	[Name] [nvarchar](250) NULL,
	[Reason] [nvarchar](250) NULL,
 CONSTRAINT [PK_stock_transfer] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[store]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[store](
	[store_ID] [int] NOT NULL,
	[store_Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_store] PRIMARY KEY CLUSTERED 
(
	[store_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[suplier_mony]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suplier_mony](
	[Order_ID] [int] NULL,
	[sup_ID] [int] NULL,
	[price] [int] NULL,
	[Order_Date] [nvarchar](50) NULL,
	[Reminder_Date] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[suplier_Report]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suplier_Report](
	[Order_ID] [int] NULL,
	[price] [real] NULL,
	[Date] [nvarchar](50) NULL,
	[sup_ID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[supliers]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supliers](
	[sup_ID] [int] NOT NULL,
	[sup_Name] [nvarchar](250) NULL,
	[sup_address] [nvarchar](250) NULL,
	[sup_phone] [nvarchar](50) NULL,
	[notes] [nvarchar](250) NULL,
 CONSTRAINT [PK_suppliers] PRIMARY KEY CLUSTERED 
(
	[sup_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[taxes_Report]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[taxes_Report](
	[Order_ID] [int] IDENTITY(1,1) NOT NULL,
	[Order_Num] [int] NULL,
	[Order_Type] [nvarchar](250) NULL,
	[tax_type] [nvarchar](250) NULL,
	[sup_name] [nvarchar](250) NULL,
	[cust_name] [nvarchar](250) NULL,
	[total_order] [real] NULL,
	[total_tax] [real] NULL,
	[total_Aftertax] [real] NULL,
	[date] [nvarchar](250) NULL,
 CONSTRAINT [PK_taxes_Report] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[unit]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unit](
	[unit_ID] [int] NOT NULL,
	[unit_Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_unit] PRIMARY KEY CLUSTERED 
(
	[unit_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_backup]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_backup](
	[user_ID] [int] NULL,
	[take_backup] [int] NULL,
	[return_backup] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_buy]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_buy](
	[user_ID] [int] NULL,
	[buy] [int] NULL,
	[buyreport] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_customer]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_customer](
	[user_ID] [int] NULL,
	[cust_information] [int] NULL,
	[cust_money] [int] NULL,
	[cust_report] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_deserved]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_deserved](
	[user_ID] [int] NULL,
	[deservedtype] [int] NULL,
	[deserved] [int] NULL,
	[deservedreport] [int] NULL,
	[sanad_kabd] [int] NULL,
	[sanad_sarf] [int] NULL,
	[sanadreport] [int] NULL,
	[taxesreport] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_emp]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_emp](
	[user_ID] [int] NULL,
	[employee] [int] NULL,
	[employeepull] [int] NULL,
	[employeesalary] [int] NULL,
	[salaryreport] [int] NULL,
	[pullreport] [int] NULL,
	[borrow] [int] NULL,
	[borrowreport] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_employee]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_employee](
	[user_ID] [int] NULL,
	[employee] [int] NULL,
	[employee_money] [int] NULL,
	[employee_report] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_money]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_money](
	[user_ID] [int] NULL,
	[stockadd] [int] NULL,
	[stockaddmoney] [int] NULL,
	[bankaddmoney] [int] NULL,
	[stockpullmoney] [int] NULL,
	[bankpullmoney] [int] NULL,
	[stocktransfer] [int] NULL,
	[balance_bank_stock] [int] NULL,
	[transferbank_stock] [int] NULL,
	[report_bankstock] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_report]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_report](
	[user_ID] [int] NULL,
	[customer_report] [int] NULL,
	[employee_report] [int] NULL,
	[buy_report] [int] NULL,
	[sale_report] [int] NULL,
	[return_report] [int] NULL,
	[deserved_report] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_return]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_return](
	[user_ID] [int] NULL,
	[rreturn] [int] NULL,
	[returnreport] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_sale]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_sale](
	[user_ID] [int] NULL,
	[sale] [int] NULL,
	[salereport] [int] NULL,
	[salerep7h] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_supplier]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_supplier](
	[user_ID] [int] NOT NULL,
	[supp_data] [int] NULL,
	[supp_money] [int] NULL,
	[supp_report] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_ID] [int] NOT NULL,
	[user_Name] [nvarchar](250) NULL,
	[User_password] [nvarchar](250) NULL,
	[type] [nvarchar](50) NULL,
	[stock_ID] [int] NULL,
	[Rb7h] [real] NULL,
 CONSTRAINT [PK_users_1] PRIMARY KEY CLUSTERED 
(
	[user_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users_setting]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users_setting](
	[user_ID] [int] NULL,
	[unit] [int] NULL,
	[user_permission] [int] NULL,
	[setting] [int] NULL,
	[item_add] [int] NULL,
	[item_view] [int] NULL,
	[item_group] [int] NULL,
	[store_add] [int] NULL,
	[store_gard] [int] NULL,
	[store_transfer] [int] NULL,
	[store_out] [int] NULL,
	[store_transferreport] [int] NULL,
	[store_outreport] [int] NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[deserved]  WITH CHECK ADD  CONSTRAINT [FK_deserved_deserved_type] FOREIGN KEY([type_ID])
REFERENCES [dbo].[deserved_type] ([Des_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[deserved] CHECK CONSTRAINT [FK_deserved_deserved_type]
GO
ALTER TABLE [dbo].[returns_details]  WITH CHECK ADD  CONSTRAINT [FK_returns_details_returns] FOREIGN KEY([Order_ID])
REFERENCES [dbo].[returns] ([Order_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[returns_details] CHECK CONSTRAINT [FK_returns_details_returns]
GO
ALTER TABLE [dbo].[sales_details]  WITH CHECK ADD  CONSTRAINT [FK_sales_details_products] FOREIGN KEY([Pro_ID])
REFERENCES [dbo].[products] ([Pro_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sales_details] CHECK CONSTRAINT [FK_sales_details_products]
GO
ALTER TABLE [dbo].[sales_details]  WITH CHECK ADD  CONSTRAINT [FK_sales_details_sales] FOREIGN KEY([Order_ID])
REFERENCES [dbo].[sales] ([Order_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[sales_details] CHECK CONSTRAINT [FK_sales_details_sales]
GO
ALTER TABLE [dbo].[user_backup]  WITH CHECK ADD  CONSTRAINT [FK_user_backup_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_backup] CHECK CONSTRAINT [FK_user_backup_users]
GO
ALTER TABLE [dbo].[user_buy]  WITH CHECK ADD  CONSTRAINT [FK_user_buy_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_buy] CHECK CONSTRAINT [FK_user_buy_users]
GO
ALTER TABLE [dbo].[user_customer]  WITH CHECK ADD  CONSTRAINT [FK_user_customer_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_customer] CHECK CONSTRAINT [FK_user_customer_users]
GO
ALTER TABLE [dbo].[user_deserved]  WITH CHECK ADD  CONSTRAINT [FK_user_deserved_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_deserved] CHECK CONSTRAINT [FK_user_deserved_users]
GO
ALTER TABLE [dbo].[user_emp]  WITH CHECK ADD  CONSTRAINT [FK_user_employeeafffairs_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_emp] CHECK CONSTRAINT [FK_user_employeeafffairs_users]
GO
ALTER TABLE [dbo].[user_employee]  WITH CHECK ADD  CONSTRAINT [FK_user_employee_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_employee] CHECK CONSTRAINT [FK_user_employee_users]
GO
ALTER TABLE [dbo].[user_money]  WITH CHECK ADD  CONSTRAINT [FK_user_money_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_money] CHECK CONSTRAINT [FK_user_money_users]
GO
ALTER TABLE [dbo].[user_report]  WITH CHECK ADD  CONSTRAINT [FK_user_report_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_report] CHECK CONSTRAINT [FK_user_report_users]
GO
ALTER TABLE [dbo].[user_return]  WITH CHECK ADD  CONSTRAINT [FK_user_return_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_return] CHECK CONSTRAINT [FK_user_return_users]
GO
ALTER TABLE [dbo].[user_sale]  WITH CHECK ADD  CONSTRAINT [FK_user_sale_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_sale] CHECK CONSTRAINT [FK_user_sale_users]
GO
ALTER TABLE [dbo].[user_supplier]  WITH CHECK ADD  CONSTRAINT [FK_user_supplier_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[user_supplier] CHECK CONSTRAINT [FK_user_supplier_users]
GO
ALTER TABLE [dbo].[users_setting]  WITH CHECK ADD  CONSTRAINT [FK_users_setting_users] FOREIGN KEY([user_ID])
REFERENCES [dbo].[users] ([user_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[users_setting] CHECK CONSTRAINT [FK_users_setting_users]
GO
/****** Object:  StoredProcedure [dbo].[BuyReport]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BuyReport] 
as
SELECT [Order_ID] as'رقم الفاتوره'
      ,supliers.sup_Name as 'اسم المورد'
      ,products.Pro_name as'اسم المنتج'
      ,[Date] as'تاريخ الفاتوره'

      ,[buy_datails].[Qty] as'الكميه'
	  ,[unit_name]as'الوحدة'
      ,[User_name] as'اسم المستخدم'
      ,[price] as'السعر قبل الضريبة'
     ,buy_datails.tax_value as'الضريبة'
	 ,[price_tax]as'السعر بعد الضريبة'
	  ,[discound] as'الخصم'
      ,[total] as'اجمالي الصنف'
      ,[TotalOrder] as'الاجمالي العام'
      ,[madfoo3] as'المدفوع'
      ,[Baky] as'المبلغ المتبقي'
  FROM [dbo].[buy_datails],supliers,products where supliers.sup_ID = [buy_datails].Sup_ID and products.Pro_ID = [buy_datails].Pro_ID


GO
/****** Object:  StoredProcedure [dbo].[customerMony]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[customerMony]
as
SELECT [Order_ID]as 'رقم الفاتوره',[cust_Name]as 'العميل',[price]as 'المبلغ المستحق',[Order_Date]as 'تاريخ الفاتوره',[Reminder_Date]as 'تاريخ الاستحقاق'FROM [dbo].[customer_mony]


GO
/****** Object:  StoredProcedure [dbo].[orderbuy]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[orderbuy] 
as

SELECT [Order_ID] as'رقم الفاتوره'
      ,supliers.sup_Name as 'اسم المورد'
      ,products.Pro_name as'اسم المنتج'
      ,[Date] as'تاريخ الفاتوره'

      ,[buy_datails].[Qty] as'الكميه'
	  ,[unit_name]as'الوحدة'
      ,[User_name] as'اسم المستخدم'
      ,[price] as'السعر قبل الضريبة'
     ,buy_datails.tax_value as'الضريبة'
	 ,[price_tax]as'السعر بعد الضريبة'
	  ,[discound] as'الخصم'
      ,[total] as'اجمالي الصنف'
      ,[TotalOrder] as'الاجمالي العام'
      ,[madfoo3] as'المدفوع'
      ,[Baky] as'المبلغ المتبقي'
  FROM [dbo].[buy_datails],supliers,products where supliers.sup_ID = [buy_datails].Sup_ID and products.Pro_ID = [buy_datails].Pro_ID





GO
/****** Object:  StoredProcedure [dbo].[OrderSale]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OrderSale] 
as
SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المنتج',sales_details.[Qty]as'الكميه',unit as 'الوحدة',[price_tax]as' السعر شامل الضريبة',[discound]as'الخصم',[total]as'الاجمالي',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ',[sales_details].tax_value as'الضريبة' FROM [dbo].[sales_details],products where products.Pro_ID =sales_details.Pro_ID


GO
/****** Object:  StoredProcedure [dbo].[salesReport]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[salesReport] 
as
SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المتج',sales_details.[Qty]as'الكميه',[price]as'السعر',[discound]as'الخصم',[total]as'الاجمالي',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ'FROM [dbo].[sales_details],products where products.Pro_ID =sales_details.Pro_ID


GO
/****** Object:  StoredProcedure [dbo].[sanadkabd]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sanadkabd] 
as
SELECT [Order_ID] as'رقم العمليه'
      ,[name] as'اسم المسؤل عن القبض'
      ,[price] as'المبلغ'
      ,[Date] as'تاريخ العملية'
      ,[from_] as'تم القبض من'
      ,[Reason] as'السبب'
  FROM [dbo].[sanad_kabd]


GO
/****** Object:  StoredProcedure [dbo].[sanadsarf]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sanadsarf] 
as
SELECT [Order_ID] as'رقم العمليه'
      ,[name] as'اسم المسؤل عن الصرف'
      ,[price] as'المبلغ'
      ,[Date] as'تاريخ العملية'
      ,[to_] as'تم الصرف من'
      ,[Reason] as'السبب'
  FROM [dbo].[sanad_sarf]


GO
/****** Object:  StoredProcedure [dbo].[suppliermonyreport]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[suppliermonyreport]
as
SELECT [Order_ID] as 'رقم الفاتوره', supliers.sup_ID as 'رقم المورد', supliers.sup_Name as 'اسم المورد',[price] as'السعر',[Order_Date]as'تاريخ الفاتوره',[Reminder_Date]as'تاريخ الاستحقاق'FROM [therd].[dbo].[suplier_mony],supliers where supliers.sup_ID = [suplier_mony].sup_ID


GO
/****** Object:  StoredProcedure [dbo].[TaxesBuyreports]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[TaxesBuyreports] @frombuy nvarchar (30),@tobuy nvarchar(30) 
as

select ISNULL( sum(total_order),0) as'اجمالي فواتير المشتريات' ,ISNULL( sum(total_tax),0) as'قيمة ضرائب المشتريات',ISNULL( sum(total_Aftertax),0) as'السعر بعد ضرائب المشتريات' from taxes_Report where Order_Type =N'فاتورة مشتريات'and Date between @frombuy and @tobuy


GO
/****** Object:  StoredProcedure [dbo].[taxesreport]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[taxesreport] 
as

SELECT [Order_ID]as'رقم العمليه',[Order_Num]as'رقم الفاتوره',[Order_Type]as'نوع العملية',[tax_type]as'نوع الضريبة',[sup_name]as'اسم المورد',[cust_name]as'اسم العميل',[total_order]as'اجمالي الفاتوره قبل الضريبه',[total_tax]as'اجمالي الضريبة',[total_Aftertax]as'اجمالي الفاتوره بعد الضريبه',[date]as'تاريخ العملية'FROM [dbo].[taxes_Report]




GO
/****** Object:  StoredProcedure [dbo].[Taxessalereports]    Script Date: 9/23/2023 11:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Taxessalereports] @fromsale nvarchar (30),@tosale nvarchar(30) 
as

select ISNULL( sum(total_order),0) as'اجمالي فواتير المبيعات' ,ISNULL( sum(total_tax),0) as'قيمة ضرائب المبيعات',ISNULL( sum(total_Aftertax),0) as'السعر بعد ضرائب المبيعات' from taxes_Report where Order_Type =N'فاتورة مبيعات' and Date between @fromsale and @tosale


GO
USE [master]
GO
ALTER DATABASE [therd] SET  READ_WRITE 
GO
