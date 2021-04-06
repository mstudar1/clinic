USE [master]
GO
ALTER DATABASE [cs6232-g2] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
USE [master]
GO
DROP DATABASE IF EXISTS [cs6232-g2]
GO
/****** Object:  Database [cs6232-g2]    Script Date: 4/5/2021 10:55:46 PM ******/
CREATE DATABASE [cs6232-g2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Clinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Clinic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Clinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Clinic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cs6232-g2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-g2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-g2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-g2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-g2] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-g2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-g2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-g2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-g2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-g2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-g2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-g2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-g2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-g2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-g2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-g2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-g2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-g2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-g2] SET RECOVERY FULL 
GO
ALTER DATABASE [cs6232-g2] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-g2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-g2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-g2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-g2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs6232-g2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs6232-g2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-g2', N'ON'
GO
ALTER DATABASE [cs6232-g2] SET QUERY_STORE = OFF
GO
USE [cs6232-g2]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[personId] [int] NOT NULL,
	[administratorId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[administratorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[appointmentId] [int] IDENTITY(1,1) NOT NULL,
	[patientId] [int] NOT NULL,
	[startDateTime] [datetime] NOT NULL,
	[endDateTime] [datetime] NOT NULL,
	[doctorId] [int] NOT NULL,
	[reasonForVisit] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[appointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConductedLabTest]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConductedLabTest](
	[appointmentId] [int] NOT NULL,
	[testCode] [int] NOT NULL,
	[datePerformed] [datetime] NOT NULL,
	[results] [varchar](250) NOT NULL,
	[isNormal] [bit] NOT NULL,
 CONSTRAINT [PK_ConductedLabTest] PRIMARY KEY CLUSTERED 
(
	[appointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credential]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credential](
	[personId] [int] NOT NULL,
	[role] [varchar](25) NOT NULL,
	[userName] [varchar](25) NOT NULL,
	[password] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Credential] PRIMARY KEY CLUSTERED 
(
	[personId] ASC,
	[role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diagnosis]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnosis](
	[appointmentId] [int] NOT NULL,
	[diagnosisName] [varchar](50) NOT NULL,
	[isFinal] [bit] NULL,
 CONSTRAINT [PK_Diagnosis] PRIMARY KEY CLUSTERED 
(
	[appointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[personId] [int] NOT NULL,
	[doctorId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[doctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoctorSpecialty]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoctorSpecialty](
	[doctorId] [int] NOT NULL,
	[specialtyName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DoctorSpecialty] PRIMARY KEY CLUSTERED 
(
	[doctorId] ASC,
	[specialtyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabTest]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTest](
	[testCode] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LabTest] PRIMARY KEY CLUSTERED 
(
	[testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurse]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurse](
	[personId] [int] NOT NULL,
	[nurseId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Nurse] PRIMARY KEY CLUSTERED 
(
	[nurseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[personId] [int] NOT NULL,
	[patientId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[patientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[personId] [int] IDENTITY(1,1) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[dateOfBirth] [date] NOT NULL,
	[ssn] [varchar](11) NOT NULL,
	[gender] [varchar](10) NULL,
	[phoneNumber] [varchar](20) NULL,
	[addressLine1] [varchar](100) NOT NULL,
	[addressLine2] [varchar](100) NULL,
	[city] [varchar](50) NOT NULL,
	[state] [varchar](2) NOT NULL,
	[zipCode] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[personId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[roleName] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[roleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialty]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialty](
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Specialty] PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visit]    Script Date: 4/5/2021 10:55:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[appointmentId] [int] NOT NULL,
	[nurseId] [int] NULL,
	[weight] [decimal](4, 1) NULL,
	[pulse] [int] NULL,
	[systolicBloodPressure] [int] NULL,
	[diastolicBloodPressure] [int] NULL,
	[bodyTemperature] [decimal](4, 1) NULL,
	[symptoms] [varchar](500) NULL,
 CONSTRAINT [PK_Visit] PRIMARY KEY CLUSTERED 
(
	[appointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrator] ON 

INSERT [dbo].[Administrator] ([personId], [administratorId]) VALUES (7, 1)
SET IDENTITY_INSERT [dbo].[Administrator] OFF
GO
SET IDENTITY_INSERT [dbo].[Appointment] ON 

INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (1, 4, CAST(N'2021-04-15T08:00:00.000' AS DateTime), CAST(N'2021-04-15T08:30:00.000' AS DateTime), 2, N'broken leg and neck and back')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (2, 1, CAST(N'2021-04-17T08:00:00.000' AS DateTime), CAST(N'2021-04-17T09:00:00.000' AS DateTime), 1, N'dislocated shoulder')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (3, 2, CAST(N'2021-04-02T11:30:00.000' AS DateTime), CAST(N'2021-04-02T11:45:00.000' AS DateTime), 2, N'soar throat')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (4, 3, CAST(N'2021-03-29T14:15:00.000' AS DateTime), CAST(N'2021-03-29T14:45:00.000' AS DateTime), 2, N'ear ache')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (5, 1, CAST(N'2021-03-31T10:00:00.000' AS DateTime), CAST(N'2021-03-31T10:10:00.000' AS DateTime), 1, N'COVID')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (6, 2, CAST(N'2021-04-09T07:45:00.000' AS DateTime), CAST(N'2021-04-09T08:15:00.000' AS DateTime), 1, N'Toe fungus')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (7, 1, CAST(N'2021-03-31T02:15:00.000' AS DateTime), CAST(N'2021-03-31T02:35:00.000' AS DateTime), 2, N'Restless leg syndrome')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (8, 3, CAST(N'2021-04-15T11:30:00.000' AS DateTime), CAST(N'2021-04-15T11:45:00.000' AS DateTime), 1, N'Bloody nose')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (9, 2, CAST(N'2021-04-15T08:30:00.000' AS DateTime), CAST(N'2021-04-15T09:10:00.000' AS DateTime), 2, N'Ocular migraines')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (10, 1, CAST(N'2021-04-01T08:00:00.000' AS DateTime), CAST(N'2021-04-01T08:30:00.000' AS DateTime), 2, N'Parkinson''s disease')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (11, 3, CAST(N'2021-04-05T08:00:00.000' AS DateTime), CAST(N'2021-04-05T08:30:00.000' AS DateTime), 1, N'Missing limbs')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (12, 4, CAST(N'2021-04-25T08:15:00.000' AS DateTime), CAST(N'2021-04-25T08:45:00.000' AS DateTime), 2, N'Swallowd a cat')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (14, 1, CAST(N'2021-04-15T11:45:00.000' AS DateTime), CAST(N'2021-04-15T11:55:00.000' AS DateTime), 1, N'Multiple bee stings')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (15, 3, CAST(N'2021-03-31T11:10:00.000' AS DateTime), CAST(N'2021-03-31T11:30:00.000' AS DateTime), 1, N'Attacked by a three-toed sloth')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (16, 2, CAST(N'2021-03-31T12:15:00.000' AS DateTime), CAST(N'2021-03-31T12:30:00.000' AS DateTime), 1, N'Traumatic brain injury')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (17, 3, CAST(N'2021-04-10T08:00:00.000' AS DateTime), CAST(N'2021-04-10T08:15:00.000' AS DateTime), 2, N'Nerf gun eye injury')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (18, 1, CAST(N'2021-04-15T10:15:00.000' AS DateTime), CAST(N'2021-04-15T10:30:00.000' AS DateTime), 2, N'Amnesia')
INSERT [dbo].[Appointment] ([appointmentId], [patientId], [startDateTime], [endDateTime], [doctorId], [reasonForVisit]) VALUES (21, 4, CAST(N'2021-04-14T08:20:00.000' AS DateTime), CAST(N'2021-04-14T08:40:00.000' AS DateTime), 1, N'Soar Throat')
SET IDENTITY_INSERT [dbo].[Appointment] OFF
GO
INSERT [dbo].[ConductedLabTest] ([appointmentId], [testCode], [datePerformed], [results], [isNormal]) VALUES (1, 1, CAST(N'2021-04-15T00:00:00.000' AS DateTime), N'compund fracture of the femur', 0)
GO
INSERT [dbo].[Credential] ([personId], [role], [userName], [password]) VALUES (5, N'Nurse', N'nurse2', N'test2')
INSERT [dbo].[Credential] ([personId], [role], [userName], [password]) VALUES (6, N'Nurse', N'nurse1', N'test1')
INSERT [dbo].[Credential] ([personId], [role], [userName], [password]) VALUES (7, N'Admin', N'admin', N'test0')
GO
INSERT [dbo].[Diagnosis] ([appointmentId], [diagnosisName], [isFinal]) VALUES (1, N'Compund fracture of the femur', 1)
INSERT [dbo].[Diagnosis] ([appointmentId], [diagnosisName], [isFinal]) VALUES (2, N'Compund fracture of the ulna', 0)
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([personId], [doctorId]) VALUES (2, 2)
INSERT [dbo].[Doctor] ([personId], [doctorId]) VALUES (4, 1)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
GO
INSERT [dbo].[DoctorSpecialty] ([doctorId], [specialtyName]) VALUES (1, N'Pediatrics')
INSERT [dbo].[DoctorSpecialty] ([doctorId], [specialtyName]) VALUES (2, N'Orthopedics')
GO
INSERT [dbo].[LabTest] ([testCode], [name]) VALUES (1, N'X-ray')
INSERT [dbo].[LabTest] ([testCode], [name]) VALUES (2, N'MRI')
INSERT [dbo].[LabTest] ([testCode], [name]) VALUES (3, N'Strep Test')
GO
SET IDENTITY_INSERT [dbo].[Nurse] ON 

INSERT [dbo].[Nurse] ([personId], [nurseId]) VALUES (5, 2)
INSERT [dbo].[Nurse] ([personId], [nurseId]) VALUES (6, 1)
INSERT [dbo].[Nurse] ([personId], [nurseId]) VALUES (13, 3)
INSERT [dbo].[Nurse] ([personId], [nurseId]) VALUES (25, 9)
INSERT [dbo].[Nurse] ([personId], [nurseId]) VALUES (27, 10)
INSERT [dbo].[Nurse] ([personId], [nurseId]) VALUES (28, 11)
INSERT [dbo].[Nurse] ([personId], [nurseId]) VALUES (29, 12)
SET IDENTITY_INSERT [dbo].[Nurse] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([personId], [patientId]) VALUES (1, 1)
INSERT [dbo].[Patient] ([personId], [patientId]) VALUES (8, 2)
INSERT [dbo].[Patient] ([personId], [patientId]) VALUES (10, 3)
INSERT [dbo].[Patient] ([personId], [patientId]) VALUES (11, 4)
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (1, N'Smith', N'John', CAST(N'1980-07-25' AS Date), N'444-55-7777', N'M', N'(555) 555-5555', N'15. E. Main St.', N'', N'Smithfield', N'NC', N'27577')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (2, N'Fudd', N'Elmer', CAST(N'1937-12-03' AS Date), N'111-22-3333', N'M', N'(555) 222-5555', N'2343 East Wabbit Ln.', N'Apt. 3C', N'Morgantown', N'WV', N'26508')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (4, N'Bunny', N'Bugs', CAST(N'1938-04-30' AS Date), N'999-00-2222', N'M', N'(555) 333-5555', N'5567 Whatsupdoc Ave.', N'', N'Albuquerque', N'NM', N'87101')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (5, N'Puma', N'Pete', CAST(N'1952-11-15' AS Date), N'065-22-7770', N'M', N'(555) 444-5555', N'1298 W. Mountain Lane', N'Suite 1658', N'Santa Fe', N'NM', N'87501')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (6, N'Cat', N'Sylvia', CAST(N'1953-06-01' AS Date), N'333-22-1111', N'F', N'(555) 666-5555', N'227 Purple Bow Cir.', N'Apt. 5G', N'Lancaster', N'PA', N'17601')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (7, N'Pig', N'Porky', CAST(N'1935-03-02' AS Date), N'543-45-0022', N'M', N'(555) 777-5555', N'6784 Bacon Ln.', N'', N'Sweetwater', N'TN', N'37874')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (8, N'Cat', N'Tom', CAST(N'1937-04-17' AS Date), N'232-23-2323', N'M', N'(555) 888-5555', N'2 N. E. 2nd St.', N'Suite 2E Room 4', N'New York', N'NY', N'10151')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (10, N'Mouse', N'Jerry', CAST(N'1940-06-24' AS Date), N'123-45-6789', N'M', N'(555) 999-5555', N'16 West Spring St.', N'Hole 5A', N'Dayton', N'OH', N'45390')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (11, N'Cat', N'Tom', CAST(N'1940-06-20' AS Date), N'333-65-4573', N'M', N'(555) 555-1111', N'16 West Spring St.', N'', N'Dayton', N'OH', N'45390')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (12, N'Cat', N'Tom', CAST(N'1940-06-20' AS Date), N'343-65-4573', N'M', N'(555) 555-2222', N'16 West Spring St.', N'', N'Dayton', N'OH', N'45390')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (13, N'Bob', N'Builder', CAST(N'1970-06-01' AS Date), N'485-97-4902', N'M', N'(555) 555-3333', N'5 E. The St.', N'', N'Bison', N'WY', N'33333')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (25, N'Gordon', N'Flash', CAST(N'2012-12-12' AS Date), N'212-21-2121', N'M', N'(555) 555-4444', N'4 T. St.', N'', N'Cat', N'TN', N'55555')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (27, N'Man', N'Super', CAST(N'1932-01-25' AS Date), N'676-67-6767', N'M', N'(555) 555-5555', N'1 S. St.', N'', N'Gotham', N'NY', N'44444')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (28, N'Flintstone', N'Fred', CAST(N'1955-05-22' AS Date), N'535-53-5353', N'M', N'(555) 555-5555', N'44 Dino Ln.', N'', N'Bedrock', N'ND', N'44444')
INSERT [dbo].[Person] ([personId], [lastName], [firstName], [dateOfBirth], [ssn], [gender], [phoneNumber], [addressLine1], [addressLine2], [city], [state], [zipCode]) VALUES (29, N'Flintsone', N'Wilma', CAST(N'1963-12-24' AS Date), N'444-44-5454', N'F', N'(555) 555-5555', N'4 Dino Ln.', N'', N'Bedrock', N'ND', N'22222')
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
INSERT [dbo].[Role] ([roleName]) VALUES (N'Admin')
INSERT [dbo].[Role] ([roleName]) VALUES (N'Nurse')
GO
INSERT [dbo].[Specialty] ([name]) VALUES (N'Orthopedics')
INSERT [dbo].[Specialty] ([name]) VALUES (N'Pediatrics')
GO
INSERT [dbo].[Visit] ([appointmentId], [nurseId], [weight], [pulse], [systolicBloodPressure], [diastolicBloodPressure], [bodyTemperature], [symptoms]) VALUES (1, 1, CAST(185.5 AS Decimal(4, 1)), 76, 121, 80, CAST(98.7 AS Decimal(4, 1)), N'leg pain with femur apparently protruding through the epidermis')
INSERT [dbo].[Visit] ([appointmentId], [nurseId], [weight], [pulse], [systolicBloodPressure], [diastolicBloodPressure], [bodyTemperature], [symptoms]) VALUES (2, 2, CAST(205.0 AS Decimal(4, 1)), 98, 130, 90, CAST(98.6 AS Decimal(4, 1)), N'arm pain with missing bone')
GO
/****** Object:  Index [UK_Administrator]    Script Date: 4/5/2021 10:55:46 PM ******/
ALTER TABLE [dbo].[Administrator] ADD  CONSTRAINT [UK_Administrator] UNIQUE NONCLUSTERED 
(
	[personId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_Appointment]    Script Date: 4/5/2021 10:55:46 PM ******/
ALTER TABLE [dbo].[Appointment] ADD  CONSTRAINT [UK_Appointment] UNIQUE NONCLUSTERED 
(
	[patientId] ASC,
	[startDateTime] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_ConductedLabTest]    Script Date: 4/5/2021 10:55:46 PM ******/
ALTER TABLE [dbo].[ConductedLabTest] ADD  CONSTRAINT [UK_ConductedLabTest] UNIQUE NONCLUSTERED 
(
	[appointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_Diagnosis]    Script Date: 4/5/2021 10:55:46 PM ******/
ALTER TABLE [dbo].[Diagnosis] ADD  CONSTRAINT [UK_Diagnosis] UNIQUE NONCLUSTERED 
(
	[appointmentId] ASC,
	[diagnosisName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_Doctor]    Script Date: 4/5/2021 10:55:46 PM ******/
ALTER TABLE [dbo].[Doctor] ADD  CONSTRAINT [UK_Doctor] UNIQUE NONCLUSTERED 
(
	[personId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_Nurse]    Script Date: 4/5/2021 10:55:46 PM ******/
ALTER TABLE [dbo].[Nurse] ADD  CONSTRAINT [UK_Nurse] UNIQUE NONCLUSTERED 
(
	[personId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_Patient]    Script Date: 4/5/2021 10:55:46 PM ******/
ALTER TABLE [dbo].[Patient] ADD  CONSTRAINT [UK_Patient] UNIQUE NONCLUSTERED 
(
	[personId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_Person_ssn]    Script Date: 4/5/2021 10:55:46 PM ******/
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [UK_Person_ssn] UNIQUE NONCLUSTERED 
(
	[ssn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointment] ADD  CONSTRAINT [DF_Appointment_endDateTime]  DEFAULT ('2020-12-12 00:00:00.000') FOR [endDateTime]
GO
ALTER TABLE [dbo].[Diagnosis] ADD  CONSTRAINT [DF_Diagnosis_isFinal]  DEFAULT ((0)) FOR [isFinal]
GO
ALTER TABLE [dbo].[Administrator]  WITH CHECK ADD  CONSTRAINT [FK_Administrator_Person] FOREIGN KEY([personId])
REFERENCES [dbo].[Person] ([personId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Administrator] CHECK CONSTRAINT [FK_Administrator_Person]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctor] FOREIGN KEY([doctorId])
REFERENCES [dbo].[Doctor] ([doctorId])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Doctor]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([patientId])
REFERENCES [dbo].[Patient] ([patientId])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
ALTER TABLE [dbo].[ConductedLabTest]  WITH CHECK ADD  CONSTRAINT [FK_ConductedLabTest_Appointment] FOREIGN KEY([appointmentId])
REFERENCES [dbo].[Appointment] ([appointmentId])
GO
ALTER TABLE [dbo].[ConductedLabTest] CHECK CONSTRAINT [FK_ConductedLabTest_Appointment]
GO
ALTER TABLE [dbo].[Credential]  WITH CHECK ADD  CONSTRAINT [FK_Credential_Person] FOREIGN KEY([personId])
REFERENCES [dbo].[Person] ([personId])
GO
ALTER TABLE [dbo].[Credential] CHECK CONSTRAINT [FK_Credential_Person]
GO
ALTER TABLE [dbo].[Credential]  WITH CHECK ADD  CONSTRAINT [FK_Credential_Role] FOREIGN KEY([role])
REFERENCES [dbo].[Role] ([roleName])
GO
ALTER TABLE [dbo].[Credential] CHECK CONSTRAINT [FK_Credential_Role]
GO
ALTER TABLE [dbo].[Diagnosis]  WITH CHECK ADD  CONSTRAINT [FK_Diagnosis_Appointment] FOREIGN KEY([appointmentId])
REFERENCES [dbo].[Appointment] ([appointmentId])
GO
ALTER TABLE [dbo].[Diagnosis] CHECK CONSTRAINT [FK_Diagnosis_Appointment]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Person] FOREIGN KEY([personId])
REFERENCES [dbo].[Person] ([personId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Person]
GO
ALTER TABLE [dbo].[DoctorSpecialty]  WITH CHECK ADD  CONSTRAINT [FK_DoctorSpecialty_Specialty] FOREIGN KEY([specialtyName])
REFERENCES [dbo].[Specialty] ([name])
GO
ALTER TABLE [dbo].[DoctorSpecialty] CHECK CONSTRAINT [FK_DoctorSpecialty_Specialty]
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD  CONSTRAINT [FK_Nurse_Person] FOREIGN KEY([personId])
REFERENCES [dbo].[Person] ([personId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nurse] CHECK CONSTRAINT [FK_Nurse_Person]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Person] FOREIGN KEY([personId])
REFERENCES [dbo].[Person] ([personId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Person]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Appointment] FOREIGN KEY([appointmentId])
REFERENCES [dbo].[Appointment] ([appointmentId])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Appointment]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Nurse] FOREIGN KEY([nurseId])
REFERENCES [dbo].[Nurse] ([nurseId])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [FK_Visit_Nurse]
GO
USE [master]
GO
ALTER DATABASE [cs6232-g2] SET  READ_WRITE 
GO
