/****** Object:  Table [dbo].[PersonnelDepartement]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonnelDepartement](
	[personnelID] [int] NOT NULL,
	[departementID] [int] NOT NULL,
 CONSTRAINT [PK_PersonnelDepartement] PRIMARY KEY CLUSTERED 
(
	[personnelID] ASC,
	[departementID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cours]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cours](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[intitule] [varchar](128) NOT NULL,
	[nbGroupes] [smallint] NOT NULL,
	[nbHeures] [int] NOT NULL,
	[typeCoursID] [int] NOT NULL,
	[idEC] [int] NOT NULL,
 CONSTRAINT [PK_Cours] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorie]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorie](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[intitule] [varchar](128) NOT NULL,
	[nbEQTD] [int] NOT NULL,
 CONSTRAINT [PK_Categorie] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personnel]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personnel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](128) NOT NULL,
	[prenom] [varchar](128) NOT NULL,
	[categorieID] [int] NOT NULL,
 CONSTRAINT [PK_Personnel] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeCours]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeCours](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](8) NOT NULL,
 CONSTRAINT [PK_TypeCours_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EquivalentTD]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquivalentTD](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[eqtd] [float] NOT NULL,
	[typeCoursId] [int] NOT NULL,
	[categorieID] [int] NOT NULL,
 CONSTRAINT [PK_EquivalentTD] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EnseignantCours]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EnseignantCours](
	[idEnseignant] [int] NOT NULL,
	[idCours] [int] NOT NULL,
	[nbHeures] [int] NOT NULL,
	[groupe] [int] NOT NULL,
 CONSTRAINT [PK_EnseignantCours] PRIMARY KEY CLUSTERED 
(
	[idEnseignant] ASC,
	[idCours] ASC,
	[groupe] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[personnel_dashboard]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[personnel_dashboard]
AS
SELECT p.nom AS [Nom],
 p.prenom AS [Prénom],
 c.intitule AS [Catégorie],
 ROUND(ISNULL(CAST(heures AS float) / CAST(c.nbEQTD AS float) * 100, 0),2) AS [Pourcentage du service],
 ISNULL(heures, 0) AS [Heures EQTD effectuées], 
 c.nbEQTD AS [Heures EQTD à effectuer],
 pd.departementID AS departementID
FROM Personnel p 
JOIN Categorie c ON c.id = p.categorieID 
JOIN dbo.PersonnelDepartement pd on pd.PersonnelID = p.id
CROSS APPLY
   (
   SELECT SUM(E.nbHeures * eqtd.eqtd) AS heures FROM EnseignantCours E 
   LEFT JOIN Categorie c ON c.id = p.categorieID 
   LEFT JOIN Cours cours ON cours.id = E.idCours
   LEFT JOIN TypeCours tc ON tc.id = cours.typeCoursID
   LEFT JOIN EquivalentTD eqtd ON eqtd.typeCoursId = tc.id AND eqtd.categorieID = p.categorieID
   WHERE E.idEnseignant = p.id
   ) H
GO
/****** Object:  Table [dbo].[Annee]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Annee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[intitule] [varchar](50) NOT NULL,
	[diplomeID] [int] NOT NULL,
	[ordre] [int] NOT NULL,
 CONSTRAINT [PK_Annee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnneeUE]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnneeUE](
	[idAnnee] [int] NOT NULL,
	[idUE] [int] NOT NULL,
 CONSTRAINT [PK_AnneeUE] PRIMARY KEY CLUSTERED 
(
	[idAnnee] ASC,
	[idUE] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Composante]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Composante](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](128) NOT NULL,
 CONSTRAINT [PK_Composante] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departement]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departement](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](128) NOT NULL,
	[composanteID] [int] NOT NULL,
 CONSTRAINT [PK_Departement] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diplome]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diplome](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[intitule] [varchar](255) NOT NULL,
	[departementID] [int] NOT NULL,
	[nbAnnees] [int] NOT NULL,
 CONSTRAINT [PK_Diplome] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EC]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EC](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[abbreviation] [varchar](16) NULL,
	[nomComplet] [varchar](128) NOT NULL,
	[ueID] [int] NOT NULL,
	[nbHeures] [int] NOT NULL,
 CONSTRAINT [PK_EC] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UE]    Script Date: 03/05/2019 14:14:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UE](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[abbreviation] [varchar](16) NULL,
	[nomComplet] [varchar](128) NOT NULL,
	[semestre] [smallint] NOT NULL,
 CONSTRAINT [PK_UE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Annee] ON 

INSERT [dbo].[Annee] ([id], [intitule], [diplomeID], [ordre]) VALUES (1, N'L1', 1, 1)
INSERT [dbo].[Annee] ([id], [intitule], [diplomeID], [ordre]) VALUES (2, N'L2', 1, 2)
INSERT [dbo].[Annee] ([id], [intitule], [diplomeID], [ordre]) VALUES (3, N'L3', 1, 3)
INSERT [dbo].[Annee] ([id], [intitule], [diplomeID], [ordre]) VALUES (4, N'M1 (FC)', 4, 1)
INSERT [dbo].[Annee] ([id], [intitule], [diplomeID], [ordre]) VALUES (6, N'M1 (APP)', 4, 1)
INSERT [dbo].[Annee] ([id], [intitule], [diplomeID], [ordre]) VALUES (7, N'M2GI', 4, 2)
INSERT [dbo].[Annee] ([id], [intitule], [diplomeID], [ordre]) VALUES (8, N'M2IHM', 4, 2)
INSERT [dbo].[Annee] ([id], [intitule], [diplomeID], [ordre]) VALUES (9, N'M2SID', 4, 2)
INSERT [dbo].[Annee] ([id], [intitule], [diplomeID], [ordre]) VALUES (15, N'M1 (FI)', 4, 1)
SET IDENTITY_INSERT [dbo].[Annee] OFF
INSERT [dbo].[AnneeUE] ([idAnnee], [idUE]) VALUES (4, 1)
INSERT [dbo].[AnneeUE] ([idAnnee], [idUE]) VALUES (4, 10)
INSERT [dbo].[AnneeUE] ([idAnnee], [idUE]) VALUES (6, 1)
INSERT [dbo].[AnneeUE] ([idAnnee], [idUE]) VALUES (15, 1)
SET IDENTITY_INSERT [dbo].[Categorie] ON 

INSERT [dbo].[Categorie] ([id], [intitule], [nbEQTD]) VALUES (1, N'Maitre de Conférences', 192)
INSERT [dbo].[Categorie] ([id], [intitule], [nbEQTD]) VALUES (2, N'PRAG', 384)
INSERT [dbo].[Categorie] ([id], [intitule], [nbEQTD]) VALUES (6, N'Professeur', 250)
SET IDENTITY_INSERT [dbo].[Categorie] OFF
SET IDENTITY_INSERT [dbo].[Composante] ON 

INSERT [dbo].[Composante] ([id], [nom]) VALUES (1, N'UFR MIM')
SET IDENTITY_INSERT [dbo].[Composante] OFF
SET IDENTITY_INSERT [dbo].[Cours] ON 

INSERT [dbo].[Cours] ([id], [intitule], [nbGroupes], [nbHeures], [typeCoursID], [idEC]) VALUES (2, N'TP .NET', 2, 24, 3, 1)
INSERT [dbo].[Cours] ([id], [intitule], [nbGroupes], [nbHeures], [typeCoursID], [idEC]) VALUES (3, N'CM .NET', 1, 24, 1, 1)
SET IDENTITY_INSERT [dbo].[Cours] OFF
SET IDENTITY_INSERT [dbo].[Departement] ON 

INSERT [dbo].[Departement] ([id], [nom], [composanteID]) VALUES (1, N'Informatique', 1)
INSERT [dbo].[Departement] ([id], [nom], [composanteID]) VALUES (2, N'Mathématiques', 1)
INSERT [dbo].[Departement] ([id], [nom], [composanteID]) VALUES (3, N'Mécanique', 1)
SET IDENTITY_INSERT [dbo].[Departement] OFF
SET IDENTITY_INSERT [dbo].[Diplome] ON 

INSERT [dbo].[Diplome] ([id], [intitule], [departementID], [nbAnnees]) VALUES (1, N'Licence', 1, 3)
INSERT [dbo].[Diplome] ([id], [intitule], [departementID], [nbAnnees]) VALUES (2, N'Licence', 2, 3)
INSERT [dbo].[Diplome] ([id], [intitule], [departementID], [nbAnnees]) VALUES (3, N'Licence', 3, 3)
INSERT [dbo].[Diplome] ([id], [intitule], [departementID], [nbAnnees]) VALUES (4, N'Master', 1, 2)
INSERT [dbo].[Diplome] ([id], [intitule], [departementID], [nbAnnees]) VALUES (5, N'Master', 2, 2)
INSERT [dbo].[Diplome] ([id], [intitule], [departementID], [nbAnnees]) VALUES (6, N'Master', 3, 2)
SET IDENTITY_INSERT [dbo].[Diplome] OFF
SET IDENTITY_INSERT [dbo].[EC] ON 

INSERT [dbo].[EC] ([id], [abbreviation], [nomComplet], [ueID], [nbHeures]) VALUES (1, N'.NET', N'La plateforme .NET', 1, 96)
SET IDENTITY_INSERT [dbo].[EC] OFF
INSERT [dbo].[EnseignantCours] ([idEnseignant], [idCours], [nbHeures], [groupe]) VALUES (1, 2, 24, 2)
INSERT [dbo].[EnseignantCours] ([idEnseignant], [idCours], [nbHeures], [groupe]) VALUES (1, 3, 24, 1)
INSERT [dbo].[EnseignantCours] ([idEnseignant], [idCours], [nbHeures], [groupe]) VALUES (2, 2, 24, 1)
SET IDENTITY_INSERT [dbo].[EquivalentTD] ON 

INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (2, 1, 2, 1)
INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (3, 0.66, 3, 1)
INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (4, 1.66, 4, 1)
INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (6, 1, 2, 2)
INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (7, 0.5, 3, 2)
INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (8, 1.3, 4, 2)
INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (24, 1.5, 1, 1)
INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (25, 1, 1, 2)
INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (30, 2, 1, 6)
INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (31, 1, 2, 6)
INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (32, 0.75, 3, 6)
INSERT [dbo].[EquivalentTD] ([id], [eqtd], [typeCoursId], [categorieID]) VALUES (33, 1, 4, 6)
SET IDENTITY_INSERT [dbo].[EquivalentTD] OFF
SET IDENTITY_INSERT [dbo].[Personnel] ON 

INSERT [dbo].[Personnel] ([id], [nom], [prenom], [categorieID]) VALUES (1, N'Martin', N'Benoit', 6)
INSERT [dbo].[Personnel] ([id], [nom], [prenom], [categorieID]) VALUES (2, N'Pecci', N'Isabelle', 1)
INSERT [dbo].[Personnel] ([id], [nom], [prenom], [categorieID]) VALUES (1003, N'Nauer', N'Emmanuel', 2)
INSERT [dbo].[Personnel] ([id], [nom], [prenom], [categorieID]) VALUES (1004, N'Nagih', N'Anass', 1)
INSERT [dbo].[Personnel] ([id], [nom], [prenom], [categorieID]) VALUES (1005, N'Kamel', N'Chelgoum', 1)
INSERT [dbo].[Personnel] ([id], [nom], [prenom], [categorieID]) VALUES (1032, N'Herrmann', N'Francine', 2)
INSERT [dbo].[Personnel] ([id], [nom], [prenom], [categorieID]) VALUES (1034, N'Lanuel', N'Yann', 2)
SET IDENTITY_INSERT [dbo].[Personnel] OFF
INSERT [dbo].[PersonnelDepartement] ([personnelID], [departementID]) VALUES (1, 1)
INSERT [dbo].[PersonnelDepartement] ([personnelID], [departementID]) VALUES (2, 1)
INSERT [dbo].[PersonnelDepartement] ([personnelID], [departementID]) VALUES (1003, 1)
INSERT [dbo].[PersonnelDepartement] ([personnelID], [departementID]) VALUES (1004, 1)
INSERT [dbo].[PersonnelDepartement] ([personnelID], [departementID]) VALUES (1005, 2)
INSERT [dbo].[PersonnelDepartement] ([personnelID], [departementID]) VALUES (1032, 2)
INSERT [dbo].[PersonnelDepartement] ([personnelID], [departementID]) VALUES (1034, 1)
INSERT [dbo].[PersonnelDepartement] ([personnelID], [departementID]) VALUES (1034, 2)
SET IDENTITY_INSERT [dbo].[TypeCours] ON 

INSERT [dbo].[TypeCours] ([id], [nom]) VALUES (1, N'CM')
INSERT [dbo].[TypeCours] ([id], [nom]) VALUES (2, N'TD')
INSERT [dbo].[TypeCours] ([id], [nom]) VALUES (3, N'TP')
INSERT [dbo].[TypeCours] ([id], [nom]) VALUES (4, N'EI')
SET IDENTITY_INSERT [dbo].[TypeCours] OFF
SET IDENTITY_INSERT [dbo].[UE] ON 

INSERT [dbo].[UE] ([id], [abbreviation], [nomComplet], [semestre]) VALUES (1, N'.NET', N'La plateforme .NET', 2)
INSERT [dbo].[UE] ([id], [abbreviation], [nomComplet], [semestre]) VALUES (10, N'TEST', N'UE TEST', 2)
SET IDENTITY_INSERT [dbo].[UE] OFF
ALTER TABLE [dbo].[Annee]  WITH CHECK ADD  CONSTRAINT [FK_Annee_Diplome] FOREIGN KEY([diplomeID])
REFERENCES [dbo].[Diplome] ([id])
GO
ALTER TABLE [dbo].[Annee] CHECK CONSTRAINT [FK_Annee_Diplome]
GO
ALTER TABLE [dbo].[AnneeUE]  WITH CHECK ADD  CONSTRAINT [FK_AnneeUE_Annee] FOREIGN KEY([idAnnee])
REFERENCES [dbo].[Annee] ([id])
GO
ALTER TABLE [dbo].[AnneeUE] CHECK CONSTRAINT [FK_AnneeUE_Annee]
GO
ALTER TABLE [dbo].[AnneeUE]  WITH CHECK ADD  CONSTRAINT [FK_AnneeUE_UE] FOREIGN KEY([idUE])
REFERENCES [dbo].[UE] ([id])
GO
ALTER TABLE [dbo].[AnneeUE] CHECK CONSTRAINT [FK_AnneeUE_UE]
GO
ALTER TABLE [dbo].[Cours]  WITH CHECK ADD  CONSTRAINT [FK_Cours_EC] FOREIGN KEY([idEC])
REFERENCES [dbo].[EC] ([id])
GO
ALTER TABLE [dbo].[Cours] CHECK CONSTRAINT [FK_Cours_EC]
GO
ALTER TABLE [dbo].[Cours]  WITH CHECK ADD  CONSTRAINT [FK_Cours_TypeCours] FOREIGN KEY([typeCoursID])
REFERENCES [dbo].[TypeCours] ([id])
GO
ALTER TABLE [dbo].[Cours] CHECK CONSTRAINT [FK_Cours_TypeCours]
GO
ALTER TABLE [dbo].[Departement]  WITH CHECK ADD  CONSTRAINT [FK_Departement_Composante] FOREIGN KEY([composanteID])
REFERENCES [dbo].[Composante] ([id])
GO
ALTER TABLE [dbo].[Departement] CHECK CONSTRAINT [FK_Departement_Composante]
GO
ALTER TABLE [dbo].[Diplome]  WITH CHECK ADD  CONSTRAINT [FK_Diplome_Departement] FOREIGN KEY([departementID])
REFERENCES [dbo].[Departement] ([id])
GO
ALTER TABLE [dbo].[Diplome] CHECK CONSTRAINT [FK_Diplome_Departement]
GO
ALTER TABLE [dbo].[EC]  WITH CHECK ADD  CONSTRAINT [FK_EC_UE] FOREIGN KEY([ueID])
REFERENCES [dbo].[UE] ([id])
GO
ALTER TABLE [dbo].[EC] CHECK CONSTRAINT [FK_EC_UE]
GO
ALTER TABLE [dbo].[EnseignantCours]  WITH CHECK ADD  CONSTRAINT [FK_EnseignantCours_Cours] FOREIGN KEY([idCours])
REFERENCES [dbo].[Cours] ([id])
GO
ALTER TABLE [dbo].[EnseignantCours] CHECK CONSTRAINT [FK_EnseignantCours_Cours]
GO
ALTER TABLE [dbo].[EnseignantCours]  WITH CHECK ADD  CONSTRAINT [FK_EnseignantCours_Personnel] FOREIGN KEY([idEnseignant])
REFERENCES [dbo].[Personnel] ([id])
GO
ALTER TABLE [dbo].[EnseignantCours] CHECK CONSTRAINT [FK_EnseignantCours_Personnel]
GO
ALTER TABLE [dbo].[EquivalentTD]  WITH CHECK ADD  CONSTRAINT [FK_EquivalentTD_Categorie] FOREIGN KEY([categorieID])
REFERENCES [dbo].[Categorie] ([id])
GO
ALTER TABLE [dbo].[EquivalentTD] CHECK CONSTRAINT [FK_EquivalentTD_Categorie]
GO
ALTER TABLE [dbo].[EquivalentTD]  WITH CHECK ADD  CONSTRAINT [FK_EquivalentTD_TypeCours] FOREIGN KEY([typeCoursId])
REFERENCES [dbo].[TypeCours] ([id])
GO
ALTER TABLE [dbo].[EquivalentTD] CHECK CONSTRAINT [FK_EquivalentTD_TypeCours]
GO
ALTER TABLE [dbo].[Personnel]  WITH CHECK ADD  CONSTRAINT [FK_Personnel_Categorie] FOREIGN KEY([categorieID])
REFERENCES [dbo].[Categorie] ([id])
GO
ALTER TABLE [dbo].[Personnel] CHECK CONSTRAINT [FK_Personnel_Categorie]
GO
ALTER TABLE [dbo].[PersonnelDepartement]  WITH CHECK ADD  CONSTRAINT [FK_PersonnelDepartement_Departement] FOREIGN KEY([departementID])
REFERENCES [dbo].[Departement] ([id])
GO
ALTER TABLE [dbo].[PersonnelDepartement] CHECK CONSTRAINT [FK_PersonnelDepartement_Departement]
GO
ALTER TABLE [dbo].[PersonnelDepartement]  WITH CHECK ADD  CONSTRAINT [FK_PersonnelDepartement_Personnel] FOREIGN KEY([personnelID])
REFERENCES [dbo].[Personnel] ([id])
GO
ALTER TABLE [dbo].[PersonnelDepartement] CHECK CONSTRAINT [FK_PersonnelDepartement_Personnel]
GO
